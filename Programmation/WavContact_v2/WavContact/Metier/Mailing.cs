using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

using FluentEmail;
using FluentEmail.Smtp;
using System.Net.Mail;
using FluentEmail.Core;

namespace WavContact.Metier
{
    class Mailing
    {

        public static void SendMail(string to)
        {
            SmtpClient smtpClient = new SmtpClient("send.one.com", 465);

            smtpClient.Credentials = new System.Net.NetworkCredential("backup@waview.ch", "WaviewBackup");
            // smtpClient.UseDefaultCredentials = true; // uncomment if you don't want to use the network credentials
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();

            //Setting From , To and CC
            mail.From = new MailAddress("backup@waview.ch", "waview.ch");
            mail.To.Add(new MailAddress(to));
            mail.Subject = "Votre mot de passe";
            mail.Body = "HELLO WORLD";

            
            smtpClient.Send(mail);
        }
    }
}
