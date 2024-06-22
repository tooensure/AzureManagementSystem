# Get the name of the resource group from the user
$resourceGroupName = Read-Host "Enter the name of the resource group:"

# Create the resource group
New-AzResourceGroup -Name $resourceGroupName -Location "eastus"

# Write to the console
Write-Host "Resource group '$resourceGroupName' created successfully!"