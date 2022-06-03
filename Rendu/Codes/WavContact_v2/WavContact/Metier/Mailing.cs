using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

using FluentEmail;
using FluentEmail.Smtp;
using System.Net.Mail;
using FluentEmail.Core;

/*using MailKit;
using MimeKit;
using MailKit.Net.Smtp;*/

namespace WavContact.Metier
{
    public class Mailing
    {

        public static void SendMail(string to, string pass)
        {
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp-relay.sendinblue.com",
                Port = 587,

                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,

                Credentials = new System.Net.NetworkCredential("cocoh2012@gmail.com", "6rgL1WRN4zJdfmMv")
            };

            MailMessage mail = new MailMessage();
            
            mail.From = new MailAddress("backup@waview.ch", "Waview Recovery");
            mail.To.Add(new MailAddress(to));
            mail.Subject = "Votre mot de passe";
            mail.Body = "Le code est : " + pass;

            
            smtp.Send(mail);

        }

        public static void SendMessage(string to, string obj, string msg)
        {
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp-relay.sendinblue.com",
                Port = 587,

                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,

                Credentials = new System.Net.NetworkCredential("cocoh2012@gmail.com", "6rgL1WRN4zJdfmMv")
            };
            
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("wavcontact@waview.ch", "WavContact");
            mail.To.Add(new MailAddress(to));
            mail.Subject = obj;
            mail.Body = msg;


            smtp.Send(mail);

        }
    }
}
