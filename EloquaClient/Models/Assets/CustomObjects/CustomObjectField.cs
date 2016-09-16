namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.CustomObjects
{
    public class CustomObjectField 
    {
        public int? id { get; set; }
        public string name { get; set; }

        public string type;
        public string depth { get; set; }
        public string description { get; set; }
        public string currentStatus { get; set; }
        public string dataType { get; set; }
        public string defaultValue { get; set; }
        public string displayType { get; set; }
        public string internalName { get; set; }
        public string optionListId { get; set; }
        public string uncheckedValue { get; set; }
        public string folderId { get; set; }
        public string createdBy { get; set; }
        public string createdAt { get; set; }
        public string updatedBy { get; set; }
        public string updatedAt { get; set; }
    }
}
