using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N37_HT_1.Models
{
    public class EmailTemplate
    {
        public string Subject { get; set; }
        public string Body { get; set; }

        public EmailTemplate(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }
    }
}
