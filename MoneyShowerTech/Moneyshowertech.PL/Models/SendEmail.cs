using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Moneyshowertech.PL.Models
{
    public class SendEmail
    {
        public static void SendMail(string body)
        {
            var fromAddress = new MailAddress("hakan.kayfeci@gmail.com", "Money Shower Tech - Yardım");
            var toAddress = new MailAddress("hakan.kayfeci@gmail.com");
            const string subject = "Money Shower Tech - Yardım";
            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "trololol")
                //trololol kısmı e-posta adresinin şifresi
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
    }
}