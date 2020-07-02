using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeoFrendlyUrl.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Image { get; set; }
    }
}
