using N37_HT_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N37_HT_1.Services
{
    public class EmailTemplateService
    {
        private readonly List<EmailTemplate> _emailTemplates;
        public EmailTemplateService()=> _emailTemplates = new List<EmailTemplate>();
        public EmailTemplate Create(string subject,string body)
        {
            var newTemp = new EmailTemplate(subject, body);
            _emailTemplates.Add(newTemp);
            return newTemp;
        }
        public IEnumerable<(User?,EmailTemplate?)> GetTemplates(IEnumerable<User> users)
        {
            foreach(var user in users)
            {
                if (user.IsDeleted)
                    yield return (user, _emailTemplates
                        .Find(temp => temp.Subject.Contains("del", StringComparison.OrdinalIgnoreCase)));

                if(user.IsActive)
                    yield return (user, _emailTemplates
                        .Find(temp => temp.Subject.Contains("onl", StringComparison.OrdinalIgnoreCase)));

                if(user.IsRegistered)
                    yield return (user, _emailTemplates
                        .Find(temp => temp.Subject.Contains("reg", StringComparison.OrdinalIgnoreCase)));

            }
        }
    }
}
