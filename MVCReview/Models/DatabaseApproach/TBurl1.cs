using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReview.Models.DatabaseApproach
{
    [MetadataType(typeof(UrlMetaData))]
    public partial class TBurl
    {
    }
    public class UrlMetaData
    {
        public int URLid { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [DataType(DataType.Url)]
        public string PersonalWebsite { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }

    }
}