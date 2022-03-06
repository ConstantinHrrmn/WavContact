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
    public class Mailing
    {

        public static void SendMail(string to, string pass)
        {
            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential("waviewrecovery@gmail.com", "Waview2022_!")
            };

            MailMessage mail = new MailMessage();

            //Setting From , To and CC
            mail.From = new MailAddress("waviewrecovery@gmail.com", "Waview Recovery");
            mail.To.Add(new MailAddress(to));
            mail.Subject = "Votre mot de passe";
            mail.Body = "Le code est : " + pass;

            
            smtp.Send(mail);
        }
    }
}
