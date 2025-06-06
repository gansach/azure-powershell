function RandomString([bool]$allChars, [int32]$len) {
    if ($allChars) {
        return -join ((33..126) | Get-Random -Count $len | % {[char]$_})
    } else {
        return -join ((48..57) + (97..122) | Get-Random -Count $len | % {[char]$_})
    }
}
function Start-TestSleep {
    [CmdletBinding(DefaultParameterSetName = 'SleepBySeconds')]
    param(
        [parameter(Mandatory = $true, Position = 0, ParameterSetName = 'SleepBySeconds')]
        [ValidateRange(0.0, 2147483.0)]
        [double] $Seconds,

        [parameter(Mandatory = $true, ParameterSetName = 'SleepByMilliseconds')]
        [ValidateRange('NonNegative')]
        [Alias('ms')]
        [int] $Milliseconds
    )

    if ($TestMode -ne 'playback') {
        switch ($PSCmdlet.ParameterSetName) {
            'SleepBySeconds' {
                Start-Sleep -Seconds $Seconds
            }
            'SleepByMilliseconds' {
                Start-Sleep -Milliseconds $Milliseconds
            }
        }
    }
}

$env = @{}
if ($UsePreviousConfigForRecord) {
    $previousEnv = Get-Content (Join-Path $PSScriptRoot 'env.json') | ConvertFrom-Json
    $previousEnv.psobject.properties | Foreach-Object { $env[$_.Name] = $_.Value }
}
# Add script method called AddWithCache to $env, when useCache is set true, it will try to get the value from the $env first.
# example: $val = $env.AddWithCache('key', $val, $true)
$env | Add-Member -Type ScriptMethod -Value { param( [string]$key, [object]$val, [bool]$useCache) if ($this.Contains($key) -and $useCache) { return $this[$key] } else { $this[$key] = $val; return $val } } -Name 'AddWithCache'
function setupEnv() {
    # Preload subscriptionId and tenant from context, which will be used in test
    # as default. You could change them if needed.
    $env.SubscriptionId = (Get-AzContext).Subscription.Id
    $env.Tenant = (Get-AzContext).Tenant.Id
    # For any resources you created for test, you should add it to $env here.
    $env.ResourceGroupName = 'abdul-test'
    $env.ResourceName = 'test-cli-instance-1'
    $env.NewResourceName = 'test-arize-instance-test-1'
    $env.PartnerPropertyLicensesSubscribed = 1
    $env.Location = "Central US EUAP"
    $env.SubscriptionId = "fc35d936-3b89-41f8-8110-a24b56826c37"
    $env.MarketplaceSubscriptionId = "fc35d936-3b89-41f8-8110-a24b56826c37"
    $env.OfferDetailOfferId = "lambdatest_liftr_testing"
    $env.OfferDetailPlanId = "testing"
    $env.OfferDetailPlanName = "testing_liftr"
    $env.OfferDetailPublisherId = "lambdatestinc1584019832435"
    $env.OfferDetailTermId = "o73usof6rkyy"
    $env.OfferDetailTermUnit = "P1Y"
    $env.UserEmailAddress = "aggarwalsw@microsoft.com"
    $env.UserFirstName = "" 
    $env.UserLastName = ""
    $env.UserUpn = "aggarwalsw@microsoft.com"
    $env.DeleteResourceName = "test-cli-instance-test-1"

    $envFile = 'env.json'
    if ($TestMode -eq 'live') {
        $envFile = 'localEnv.json'
    }
    set-content -Path (Join-Path $PSScriptRoot $envFile) -Value (ConvertTo-Json $env)
}
function cleanupEnv() {
    # Clean resources you create for testing
}

