using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    [Table(name: "tblArtist")]
    public class Artist
    {
        public int ArtistID { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        [Timestamp]
        public byte[] RowVersions { get; set; }

        public virtual List<Album> Albums { get; set; }

        public virtual ArtistDetails ArtistDetails { get; set; }


    }
}