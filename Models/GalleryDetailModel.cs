using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1stCommandment.Models
{
    public class GalleryDetailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }

        public List<string> Tags { get; set; }
    }
}
