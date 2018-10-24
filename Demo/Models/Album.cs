using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    [Table(name:"tblAlbum")]
    public class Album
    {
        public int AlbumId { get; set; }
        [Required]
        [StringLength(100, MinimumLength =2)]
        public string Title { get; set; }
        public int ArtistID { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual List<Reviewer> Reviewers { get; set; }
        public string AlbumArtUrl { get; internal set; }
        public int GenreId { get; internal set; }
        public decimal Price { get; internal set; }
    }
}