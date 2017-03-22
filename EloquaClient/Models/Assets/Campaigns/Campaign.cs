using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Campaigns
{
    [Resource("/assets/campaign", "Campaign")]
    public class Campaign : RestObject, ISearchable
    {
        public string currentStatus { get; set; }
        public int memberCount { get; set; }
        public int? folderId { get; set; }
        public int? createdAt { get; set; }
        public int? createdBy { get; set; }
        public int? updatedAt { get; set; }
        public int? updatedBy { get; set; }
        public bool? isReadOnly { get; set; }
        public int? runAsUserId { get; set; }
        public decimal? actualCost { get; set; }
        public decimal? budgetedCost { get; set; }
        public string campaignCategory { get; set; }
        public string crmId { get; set; }
        public int? startAt { get; set; }
        public int? endAt { get; set; }

        public List<CampaignField> fieldValues { get; set; }

        public List<string> permissions { get; set; }

        public List<CampaignRelatedElement> elements { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }
        public string orderByField { get; set; }
        #endregion
    }
}
