using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class MultiMediaModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public MediaType type { get; set; }
        public String Description { get => $"Title:{Title} Artist:{Artist} Genre:{Genre} type:{type}"; }

    }
}
