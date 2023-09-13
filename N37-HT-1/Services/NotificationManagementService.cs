using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N37_HT_1.Services
{
    public class NotificationManagementService
    {
        private readonly UserService _userService;
        private readonly EmailTemplateService _emailTemplateService;
        private readonly EmailService _emailService;
        private readonly EmailSenderService _emailSenderService;

        public NotificationManagementService(UserService userService,
            EmailTemplateService emailTemplateService,
            EmailService emailService,EmailSenderService emailSenderService)
        {
            _userService = userService;
            _emailTemplateService = emailTemplateService;
            _emailService = emailService;
            _emailSenderService = emailSenderService;
        }

        public async void NotifyUsers()
        {
            var users = _userService.GetUsers();
            var templates = _emailTemplateService.GetTemplates(users);
            var messages = _emailService.GetMessages(templates);
            await _emailSenderService.SendEmailsAsync(messages);
        }
    }
}
