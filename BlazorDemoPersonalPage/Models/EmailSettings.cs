using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoPersonalPage.Models
{
    public class EmailSettings
    {
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public bool IsSSL { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DefaultTitle { get; set; }
        public string[] Recipients { get; set; }
        public string SenderDisplayName { get; set; }
    }
}
