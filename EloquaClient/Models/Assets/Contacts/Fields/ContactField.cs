namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.Contacts.Fields
{
    public class ContactField : DataField
    {
        public string updateType { get; set; }
        
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
