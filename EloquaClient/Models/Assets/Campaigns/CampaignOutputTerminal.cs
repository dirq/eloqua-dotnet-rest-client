using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Campaigns
{
    public class CampaignOutputTerminal
    {
        public string type { get; set; }
        public long? id { get; set; }
        public int? connectedId { get; set; }
        public string connectedType { get; set; }
        public string terminalType { get; set; }
    }
}
