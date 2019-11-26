using System;
using System.Collections.Generic;

namespace BikeStore.Models
{
    public partial class ProductPage
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ListPrice { get; set; }
        public byte[] ThumbNailPhoto { get; set; }
        public string ThumbnailPhotoFileName { get; set; }
        public int? ProductModelId { get; set; }
       
    }
}
