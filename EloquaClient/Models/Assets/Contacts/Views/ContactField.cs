namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Views
{
    [Resource("/assets/contact/field", "ContactField")]
    public class ContactField : RestObject, ISearchable
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }

        public string updateType { get; set; }
        public string displayType { get; set; }
        public string dataType { get; set; }

        public string checkedValue { get; set; }
        public string defaultValue { get; set; }
        public string internalName { get; set; }
        public string accessedAt { get; set; }
        public string isReadOnly { get; set; }
        public string isRequired { get; set; }
        public string isStandard { get; set; }
        public int? optionListId { get; set; }
        public string uncheckedValue { get; set; }
        public string description { get; set; }
        public string currentStatus { get; set; }
        public string isPopulatedInOutlookPlugin { get; set; }
        public int? outputFormatId { get; set; }
        public string permissions { get; set; }
        public string createdBy { get; set; }
        public string createdAt { get; set; }
        public string updatedBy { get; set; }
        public string updatedAt { get; set; }
    }
}