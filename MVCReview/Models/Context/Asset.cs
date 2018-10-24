namespace MVCReview.Models.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Asset
    {
        public Guid AssetID { get; set; }

        public string Barcode { get; set; }

        public string SerialNumber { get; set; }

        public string FacilitySite { get; set; }

        public string PMGuide { get; set; }

        [Required]
        public string AstID { get; set; }

        public string ChildAsset { get; set; }

        public string GeneralAssetDescription { get; set; }

        public string SecondaryAssetDescription { get; set; }

        public int Quantity { get; set; }

        public string Manufacturer { get; set; }

        public string ModelNumber { get; set; }

        public string Building { get; set; }

        public string Floor { get; set; }

        public string Corridor { get; set; }

        public string RoomNo { get; set; }

        public string MERNo { get; set; }

        public string EquipSystem { get; set; }

        public string Comments { get; set; }

        public bool Issued { get; set; }
    }
}
