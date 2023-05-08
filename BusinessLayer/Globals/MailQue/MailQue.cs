using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Globals.MailQue
{
    public class MailQue : IMailQue
    {
        public Tuple<bool, string> SendMail(string smtpServer, string to, string from, string fromName, string subject, string body, string userName, string password)
        {
            try
            {
                SmtpClient server = new SmtpClient(smtpServer);
                server.EnableSsl = true;
                server.Port = 587;
                server.Credentials = new System.Net.NetworkCredential(userName, password);
                MailMessage email = new MailMessage();
                email.IsBodyHtml = true;
                email.From = new MailAddress(from);
                email.Subject = subject;
                email.Body = body;
                foreach (var address in to.Split(';'))
                {
                    email.To.Add(new MailAddress(address.Trim(), ""));
                }
                server.Send(email);

                return Tuple.Create(true, "Success");
            }
            catch (Exception ex)
            {
                return Tuple.Create(false, "Fail: " + ex.ToString());
            }



        }

    }
}
