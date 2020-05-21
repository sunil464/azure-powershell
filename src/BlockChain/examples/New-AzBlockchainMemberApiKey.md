### Example 1: Regenerate Api keys for a blockchain member
```powershell
PS C:\> New-AzBlockchainMemberApiKey -BlockchainMemberName $blockchainMember -ResourceGroupName $resourceGroup -KeyName $keyName -Value $value

KeyName Value
------- -----
key1    D7wyajHMZcBw4MndMgytqanz
key2    eu9kx94TKH506R0i4JhYBmsx
```

This command regenerates Api keys for a blockchain member.
