using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class SoloArtist : Artist
    {
        public string Instrument { get; set; }
    }
}