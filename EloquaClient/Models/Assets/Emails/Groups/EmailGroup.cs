using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Emails.Groups
{
    [Resource("/assets/email/group", "EmailGroup")]
    public class EmailGroup : RestObject, ISearchable
    {
        public string displayName { get; set; }
        public long? emailFooterId { get; set; }
        public long? emailHeaderId { get; set; }
        public List<string> emailIds { get; set; }
        public bool? isVisibleInOutlookPlugin { get; set; }
        public string subscriptionListDataLookupId { get; set; }
        public long? subscriptionLandingPageId { get; set; }
        public long? subscriptionListId { get; set; }
        public string unSubscriptionListDataLookupId { get; set; }
        public long? unsubscriptionLandingPageId { get; set; }
        public long? unSubscriptionListId { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }
        public string orderByField { get; set; }
        public bool? isVisibleInPublicSubscriptionList { get; set; }
        public bool? requireOptIn { get; set; }
        public bool? useSecureChannel { get; set; }
        public string currentStatus { get; set; }
        public int? accessedAt { get; set; }
        public int? createdAt { get; set; }
        public int? createdBy { get; set; }
        public int? updatedAt { get; set; }
        public int? updatedBy { get; set; }
    }
}