using N37_HT_1.Services;

var userService = new UserService();
var emailTemplateService = new EmailTemplateService();
var emailService = new EmailService();
var emailSender = new EmailSenderService();
emailTemplateService.Create("Register", "Hello {{FullName}} you are successfully registrated");
emailTemplateService.Create("Online", "Hello {{FullName}} you are logged in");
emailTemplateService.Create("Delete", "Hello {{FullName}} your account deleted by admin");
var user = userService.Create("Jon", "WICK", "asdas", "sagdyasgda@gmaisad");
var userA = userService.Create("Jon", "WICK", "asdas", "sagdyasgda@gmaisad");
var userB = userService.Create("Jon", "WICK", "asdas", "sagdyasgda@gmaisad");
userService.Delete(user.Id);
var notification = new NotificationManagementService(userService, emailTemplateService, emailService,emailSender);
notification.NotifyUsers();