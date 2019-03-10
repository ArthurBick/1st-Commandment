using System.Collections.Generic;
using ImageGallery.Data.Models;

namespace _1stCommandment.Models
{
    public class GalleryIndexModel
    {
        public IEnumerable<GalleryImage> Images { get; set; }
        public string SearchQuery { get; set; }
    }
}
