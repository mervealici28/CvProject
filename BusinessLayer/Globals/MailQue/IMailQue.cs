using System;

namespace BusinessLayer.Globals.MailQue
{
    public interface IMailQue
    {
        Tuple<bool, string> SendMail(string smtpServer, string to, string from, string fromName, string subject, string body, string userName, string password);

    }

}
