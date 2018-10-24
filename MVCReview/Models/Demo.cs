using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReview.Models
{
    [DisplayColumn("EmailAddress")]
    public class Demo
    {
        // Display mailto hyperlink
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        // Display currency symbol. For country specific currency, set 
        // culture using globalization element in web.config. 
        // For Great Britain Pound symbol
        // <globalization culture="en-gb"/>
        [DataType(DataType.Currency)]
        public int? Salary { get; set; }

        // Generate a hyperlink
        [DataType(DataType.Url)]
        public string PersonalWebSite { get; set; }

        // Display only Time Part
        // [DataType(DataType.Time)]
        // Display only Date Part
        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }
    }
}