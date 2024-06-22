using AzureManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace AzureManagementSystem.Cmdlets
{
    [Cmdlet(VerbsCommon.New, "AzureResourceGroup")]
    [OutputType(typeof(ResourceGroup))]
    public class NewAzureResourceGroup: PSCmdlet
    {
        [Parameter(Mandatory = true)]
        public string Name { get; set; }

        [Parameter(Mandatory = true)]
        public string Location { get; set; }

        [Parameter(Mandatory = true)]
        public string SubscriptionId { get; set; }
    }
}
