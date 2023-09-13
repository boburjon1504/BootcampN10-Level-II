using N37_HT_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N37_HT_1.Services
{
    public class EmailService
    {
        public IEnumerable<EmailMessage> GetMessages(IEnumerable<(User user,EmailTemplate temp)> templates)
        {

            foreach (var template in templates)
            {
                yield return new EmailMessage(template.temp.Subject, template.temp.Body
                    .Replace("{{FullName}}", $"{template.user.FirstName} {template.user.LastName}"),
                    "oursystem@gmail.com", template.user.EmailAddress);
            }

        }
    }
}
