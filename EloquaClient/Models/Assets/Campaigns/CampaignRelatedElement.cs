using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Campaigns
{
    public class CampaignRelatedElement
    {

        public string type { get; set; }
        public long? id { get; set; }
        public string name { get; set; }
        public int memberCount { get; set; }
        public int? createdAt { get; set; }
        public int? createdBy { get; set; }
        public int? updatedAt { get; set; }
        public int? updatedBy { get; set; }

        public List<CampaignOutputTerminal> outputTerminals { get; set; }

        #region "CampaignSegment"
        public bool? isFinished { get; set; }
        public bool? isRecurring { get; set; }
        public int? segmentId { get; set; }

        #endregion

        #region "CampaignEmail"
        public long? emailId { get; set; }
        public bool? includeListUnsubscribeHeader { get; set; }
        public bool? isAllowingResend { get; set; }
        public bool? isAllowingSentToUnsubscribe { get; set; }
        public string sendTimePeriod { get; set; }

        #endregion
        
        #region "CampaignForm"
        public int? formId { get; set; }

        #endregion
        
        #region "CampaignLandingPage"
        public int? landingPageId { get; set; }

        #endregion
        
        #region "CampaignContactFilterMembershipRule"
        #endregion

        #region "CampaignWaitActions"
        #endregion
    }
}