﻿using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            //KİMDEN
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "selviyildirim176@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            
            //KİME
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            //İÇERİK
            var bodyBuilder=new BodyBuilder();
            bodyBuilder.TextBody = model.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            //KONU
            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587,false);
            client.Authenticate("selviyildirim176@gmail.com", "jqxrwyhctycyjtzy");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}