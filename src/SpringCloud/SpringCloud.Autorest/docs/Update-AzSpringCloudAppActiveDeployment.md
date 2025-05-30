---
external help file:
Module Name: Az.SpringCloud
online version: https://learn.microsoft.com/powershell/module/az.springcloud/update-azspringcloudappactivedeployment
schema: 2.0.0
---

# Update-AzSpringCloudAppActiveDeployment

## SYNOPSIS
Set existing Deployment under the app as active

## SYNTAX

### SetExpanded (Default)
```
Update-AzSpringCloudAppActiveDeployment -Name <String> -ResourceGroupName <String> -ServiceName <String>
 [-SubscriptionId <String>] [-DeploymentName <String[]>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentityExpanded
```
Update-AzSpringCloudAppActiveDeployment -InputObject <ISpringCloudIdentity> [-DeploymentName <String[]>]
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### SetViaIdentitySpringExpanded
```
Update-AzSpringCloudAppActiveDeployment -Name <String> -SpringInputObject <ISpringCloudIdentity>
 [-DeploymentName <String[]>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SetViaJsonFilePath
```
Update-AzSpringCloudAppActiveDeployment -Name <String> -ResourceGroupName <String> -ServiceName <String>
 -JsonFilePath <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### SetViaJsonString
```
Update-AzSpringCloudAppActiveDeployment -Name <String> -ResourceGroupName <String> -ServiceName <String>
 -JsonString <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Set existing Deployment under the app as active

## EXAMPLES

### Example 1: Set existing Deployment under the app as active
```powershell
Update-AzSpringCloudAppActiveDeployment -ResourceGroupName springcloudrg -ServiceName standardspring-demo -Name demo -DeploymentName 'green'
```

```output
Name    SystemDataCreatedAt SystemDataCreatedBy     SystemDataCreatedByType SystemDataLastModifiedAt SystemDataLastModi
                                                                                                     fiedBy
----    ------------------- -------------------     ----------------------- ------------------------ ------------------
default 2022/7/1 3:41:45    *********@microsoft.com User                    2022/7/1 3:49:11         **********@microso…
```

Set existing Deployment under the app as active.

### Example 2: Set existing Deployment under the app as active by pipeline
```powershell
Get-AzSpringCloudApp -ResourceGroupName springcloudrg -ServiceName standardspring-demo -Name demo | Update-AzSpringCloudAppActiveDeployment -DeploymentName 'green'
```

```output
Name    SystemDataCreatedAt SystemDataCreatedBy     SystemDataCreatedByType SystemDataLastModifiedAt SystemDataLastModi
                                                                                                     fiedBy
----    ------------------- -------------------     ----------------------- ------------------------ ------------------
default 2022/7/1 3:41:45    *********@microsoft.com User                    2022/7/1 3:49:11         **********@microso…
```

Set existing Deployment under the app as active by pipeline.

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
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

### -DeploymentName
Collection of Deployment name.

```yaml
Type: System.String[]
Parameter Sets: SetExpanded, SetViaIdentityExpanded, SetViaIdentitySpringExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity
Parameter Sets: SetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Set operation

```yaml
Type: System.String
Parameter Sets: SetViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Set operation

```yaml
Type: System.String
Parameter Sets: SetViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the App resource.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaIdentitySpringExpanded, SetViaJsonFilePath, SetViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group that contains the resource.
You can obtain this value from the Azure Resource Manager API or the portal.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaJsonFilePath, SetViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceName
The name of the Service resource.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaJsonFilePath, SetViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SpringInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity
Parameter Sets: SetViaIdentitySpringExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SubscriptionId
Gets subscription ID which uniquely identify the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: SetExpanded, SetViaJsonFilePath, SetViaJsonString
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
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

### Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ISpringCloudIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IAppResource

## NOTES

## RELATED LINKS

