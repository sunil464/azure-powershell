---
external help file: Az.Storage-help.xml
Module Name: Az.Storage
online version: https://docs.microsoft.com/en-us/powershell/module/az.storage/clear-azblobcontainerlegalhold
schema: 2.0.0
---

# Clear-AzBlobContainerLegalHold

## SYNOPSIS
Clears legal hold tags.
Clearing the same or non-existent tag results in an idempotent operation.
ClearLegalHold clears out only the specified tags in the request.

## SYNTAX

### Clear (Default)
```
Clear-AzBlobContainerLegalHold -AccountName <String> -ContainerName <String> -ResourceGroupName <String>
 -SubscriptionId <String> [-LegalHold <ILegalHold>] [-DefaultProfile <PSObject>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ClearExpanded
```
Clear-AzBlobContainerLegalHold -AccountName <String> -ContainerName <String> -ResourceGroupName <String>
 -SubscriptionId <String> -Tag <String[]> [-DefaultProfile <PSObject>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ClearViaIdentityExpanded
```
Clear-AzBlobContainerLegalHold -InputObject <IStorageIdentity> -Tag <String[]> [-DefaultProfile <PSObject>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ClearViaIdentity
```
Clear-AzBlobContainerLegalHold -InputObject <IStorageIdentity> [-LegalHold <ILegalHold>]
 [-DefaultProfile <PSObject>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Clears legal hold tags.
Clearing the same or non-existent tag results in an idempotent operation.
ClearLegalHold clears out only the specified tags in the request.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -AccountName
The name of the storage account within the specified resource group.
Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.

```yaml
Type: System.String
Parameter Sets: Clear, ClearExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContainerName
The name of the blob container within the specified storage account.
Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only.
Every dash (-) character must be immediately preceded and followed by a letter or number.

```yaml
Type: System.String
Parameter Sets: Clear, ClearExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

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
Type: Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.IStorageIdentity
Parameter Sets: ClearViaIdentityExpanded, ClearViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LegalHold
The LegalHold property of a blob container.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20190401.ILegalHold
Parameter Sets: Clear, ClearViaIdentity
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group within the user's subscription.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Clear, ClearExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: Clear, ClearExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Each tag should be 3 to 23 alphanumeric characters and is normalized to lower case at SRP.

```yaml
Type: System.String[]
Parameter Sets: ClearExpanded, ClearViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
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

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Storage.Models.Api20190401.ILegalHold
## NOTES

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/az.storage/clear-azblobcontainerlegalhold](https://docs.microsoft.com/en-us/powershell/module/az.storage/clear-azblobcontainerlegalhold)
