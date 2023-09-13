using N37_HT_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N37_HT_1.Services
{
    public class EmailSenderService
    {
        public async ValueTask<bool> SendEmailsAsync(IEnumerable<EmailMessage> messages)
        {
            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }
            return true;
        }
    }
}
