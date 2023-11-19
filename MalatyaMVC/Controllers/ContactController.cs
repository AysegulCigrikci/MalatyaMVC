using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace MalatyaMVC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(FormCollection fc)
        {
                string adSoyad = fc["adSoyad"];
                string email = fc["eposta"];
                string body = fc["mesaj"];

  
                MailMessage mail = new MailMessage();
                mail.To.Add("aysegulcigrikci2@gmail.com");
                mail.From = new MailAddress(email);
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential("aysegulcigrikci2@gmail.com", " şifre bilgisi"); // ***use valid credentials***
                smtp.Port = 587;

                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);    

            return RedirectToAction("/Contact/Contact");
        }
    }
}