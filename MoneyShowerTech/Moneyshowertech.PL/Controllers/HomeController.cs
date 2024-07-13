using Moneyshowertech.PL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Moneyshowertech.PL.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            return View();
        }

        public ActionResult About(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            return View();
        }

        public ActionResult SSS(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            return View();
        }
        public ActionResult PaymentInfo(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            return View();
        }

        public ActionResult BillingInfo(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            return View();
        }
        [HttpPost]
        public ActionResult SendNewMessage(Mail model)
        {
            if (ModelState.IsValid)
            {
                MailMessage _mm = new MailMessage();
                _mm.SubjectEncoding = Encoding.Default;
                _mm.Subject = model.Topic;
                _mm.BodyEncoding = Encoding.Default;
                _mm.Body = "Maili Gönderen : " + model.Firstname + " " + model.Lastname + "\n" + " Maili : " + model.Email + "\n" + model.Message;


                _mm.From = new MailAddress(ConfigurationManager.AppSettings["emailAccount"]);
                _mm.To.Add("info@moneyshowertech.com");


                SmtpClient _smtpClient = new SmtpClient();
                _smtpClient.Host = ConfigurationManager.AppSettings["emailHost"];
                _smtpClient.Port = int.Parse(ConfigurationManager.AppSettings["emailPort"]);
                _smtpClient.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["emailAccount"], ConfigurationManager.AppSettings["emailPassword"]);
                _smtpClient.EnableSsl = bool.Parse(ConfigurationManager.AppSettings["emailSLLEnable"]);
                

                _smtpClient.Send(_mm);

                TempData["Success"] = "Teşekkürler mesajınız bize iletildi en kısa zamanda tarafınıza dönüş yapılacaktır.";
                return Redirect("~/tr/Anasayfa/#contact-section");
            }
            return Redirect("~/tr/Anasayfa/#contact-section");
        }


        public ActionResult MoneyShower(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            return View();
        }

        public ActionResult MoneyCountingShower(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            return View();
        }

        public ActionResult ThingShower(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            return View();
        }

      

        public ActionResult Gallery(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            return View();
        }
        public ActionResult Sepet(string language)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            return View();
        }
        [HttpPost]
        public ActionResult ThingShower(int id)
        {
            Session["Sepet"] = "ThingShower";
            Session["Color"] = id.ToString();
            return Redirect("~/"+Resources.Language.ShortName+"/ThingShower");
            
        }
        [HttpPost]
        public ActionResult MoneyCountingShower()
        {
            Session["Sepet"] = "MoneyCountingShower";
            return Redirect("~/"+Resources.Language.ShortName+ "/MoneyCountingShower");
            
        }
        [HttpPost]
        public ActionResult ClearBasket()
        {
            if (Session["Sepet"].ToString()=="ThingShower")
            {
                Session["Sepet"] = null;
                Response.Redirect(Resources.Language.ThingShowerLink);
            }
            else
            {
                Session["Sepet"] = null;
                Response.Redirect("https://iyzi.link/AFnXfg");
            }
            return Redirect("~/"+ Resources.Language.ShortName+"/"+ Resources.Language.Anasayfa);
            
        }

    }

}