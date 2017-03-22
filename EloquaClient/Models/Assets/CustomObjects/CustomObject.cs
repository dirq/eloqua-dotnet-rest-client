using System.Collections.Generic;

namespace Eloqua.Api.Rest.ClientLibrary.Models.Assets.CustomObjects
{
    [Resource("/assets/customObject", "CustomObject")]
    public class CustomObject : RestObject, ISearchable
    {
        public string description { get; set; }
        public string currentStatus { get; set; }
        public int recordCount { get; set; }
        public List<CustomObjectField> fields { get; set; }
        public string displayNameFieldId { get; set; }
        public string uniqueCodeFieldId { get; set; }
        public string emailAddressFieldId { get; set; }
        public string folderId { get; set; }
        public string createdBy { get; set; }
        public string createdAt { get; set; }
        public string updatedBy { get; set; }
        public string updatedAt { get; set; }

        #region ISearchable

        public int page { get; set; }
        public int pageSize { get; set; }
        public string searchTerm { get; set; }
        public string orderByField { get; set; }

        #endregion
    }
}
