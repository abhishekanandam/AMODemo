using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    [Table(name:"tblReviewer")]
    public class Reviewer
    {
        public int ReviewerID { get; set; }
        public string Name { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}