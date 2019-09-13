using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoPersonalPage.Models
{
    public class EmailMessage
    {
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public string Company { get; set; }

        public string Phone { get; set; }
        public string Message { get; set; }
    }
}
