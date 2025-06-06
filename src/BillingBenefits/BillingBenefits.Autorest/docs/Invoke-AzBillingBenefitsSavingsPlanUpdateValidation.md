---
external help file:
Module Name: Az.BillingBenefits
online version: https://learn.microsoft.com/powershell/module/az.billingbenefits/invoke-azbillingbenefitssavingsplanupdatevalidation
schema: 2.0.0
---

# Invoke-AzBillingBenefitsSavingsPlanUpdateValidation

## SYNOPSIS
Validate savings plan patch.

## SYNTAX

### ValidateExpanded (Default)
```
Invoke-AzBillingBenefitsSavingsPlanUpdateValidation -SavingsPlanId <String> -SavingsPlanOrderId <String>
 [-Benefit <ISavingsPlanUpdateRequestProperties[]>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ValidateViaIdentityExpanded
```
Invoke-AzBillingBenefitsSavingsPlanUpdateValidation -InputObject <IBillingBenefitsIdentity>
 [-Benefit <ISavingsPlanUpdateRequestProperties[]>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### ValidateViaIdentitySavingsPlanOrderExpanded
```
Invoke-AzBillingBenefitsSavingsPlanUpdateValidation -SavingsPlanId <String>
 -SavingsPlanOrderInputObject <IBillingBenefitsIdentity> [-Benefit <ISavingsPlanUpdateRequestProperties[]>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ValidateViaJsonFilePath
```
Invoke-AzBillingBenefitsSavingsPlanUpdateValidation -SavingsPlanId <String> -SavingsPlanOrderId <String>
 -JsonFilePath <String> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ValidateViaJsonString
```
Invoke-AzBillingBenefitsSavingsPlanUpdateValidation -SavingsPlanId <String> -SavingsPlanOrderId <String>
 -JsonString <String> [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Validate savings plan patch.

## EXAMPLES

### Example 1: Validate savings plan patch
```powershell
$model = @{
    AppliedScopeType = "Single"
    AppliedScopePropertiesSubscriptionId = "/subscriptions/eef82110-c91b-4395-9420-fcfcbefc5a47"
}

$models = @($model)

$response = Invoke-AzBillingBenefitsSavingsPlanUpdateValidation -SavingsPlanId "9fde2a72-776b-49fc-869c-dca8859d7d62" -SavingsPlanOrderId "d7ea1620-2bba-46e2-8434-11f31bfb984d" -Benefit $models
```

```output
Valid ReasonCode Reason
----- ---------- ------
True
```

Validate savings plan patch

## PARAMETERS

### -Benefit
.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.ISavingsPlanUpdateRequestProperties[]
Parameter Sets: ValidateExpanded, ValidateViaIdentityExpanded, ValidateViaIdentitySavingsPlanOrderExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IBillingBenefitsIdentity
Parameter Sets: ValidateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Validate operation

```yaml
Type: System.String
Parameter Sets: ValidateViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Validate operation

```yaml
Type: System.String
Parameter Sets: ValidateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SavingsPlanId
ID of the savings plan

```yaml
Type: System.String
Parameter Sets: ValidateExpanded, ValidateViaIdentitySavingsPlanOrderExpanded, ValidateViaJsonFilePath, ValidateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SavingsPlanOrderId
Order ID of the savings plan

```yaml
Type: System.String
Parameter Sets: ValidateExpanded, ValidateViaJsonFilePath, ValidateViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SavingsPlanOrderInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IBillingBenefitsIdentity
Parameter Sets: ValidateViaIdentitySavingsPlanOrderExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.IBillingBenefitsIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.ISavingsPlanValidateResponse

## NOTES

## RELATED LINKS

