using System.Net.Mail;
using System.Net;
var email = "boburjon67joraboyev@gmail.com";
using (var smtp = new SmtpClient("smtp.gmail.com", 587))
{
    smtp.Credentials = new NetworkCredential("sultonbek.rakhimov.recovery@gmail.com", "szabguksrhwsbtie");
    smtp.EnableSsl = true;

    var mail = new MailMessage("boburjon67joraboyev@gmail.com", "anvarjonovozodbek416@gmail.com");
    mail.Subject = "hello";
    mail.Body = "wordl";

    await smtp.SendMailAsync(mail);
}