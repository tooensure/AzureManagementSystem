# Get a list of all resource groups
$resourceGroups = Get-AzResourceGroup

# Display the list of resource groups
Write-Host "Resource Groups:"
$resourceGroups | Select-Object Name

# Prompt the user for confirmation before deleting
if ($Confirm -ne "Y") {
  Write-Host "Deletion canceled."
  exit
}

# Delete each resource group
foreach ($resourceGroup in $resourceGroups) {
  Write-Host "Deleting resource group: $($resourceGroup.Name)"
  Remove-AzResourceGroup -Name $resourceGroup.Name
}

Write-Host "All resource groups deleted successfully."