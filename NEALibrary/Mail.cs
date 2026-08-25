using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NEALibrary
{
    public class Mail
    {
        string MyMessage;
        string FromMail;
        string FromPassword;
        string ToMail;
        string Subject;

        public Mail(string mymessage, string tomail, string subject)
        {
            MyMessage = mymessage;
            FromMail = "YOUR_EMAIL@gmail.com";        // Placeholder
            FromPassword = "YOUR_APP_PASSWORD";      // Placeholder
            this.ToMail = tomail;
            Subject = subject;
        }
        public void SendMail()
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress(FromMail);
                message.Subject = Subject;
                message.To.Add(new MailAddress(ToMail.ToString()));
                
                message.Body = "<html><body>" + MyMessage + "</body></html>";
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(FromMail, FromPassword),
                    EnableSsl = true,
                };

                smtpClient.Send(message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }



        }
        public static int CodeGenerator()
        {
            Random random = new Random();
            return random.Next(10000, 100000);

        }
    }
}
