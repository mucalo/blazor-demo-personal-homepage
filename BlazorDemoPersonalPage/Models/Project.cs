using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoPersonalPage.Models
{
    public class Project
    {
        public string ProjectTitle { get; set; }
        public string Client { get; set; }
        public string ProjectDescription { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public List<string> Technologies { get; set; }
    }
}
