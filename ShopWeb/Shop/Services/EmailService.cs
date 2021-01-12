using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Shop.Configuration
{
    public class EmailService 
    {
        protected void Btn_SendMail_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("bohdan.tsiunyk.ki.2017@lpnu.ua", "Bohdan");
            // кому отправляем
            MailAddress to = new MailAddress("bohdan.tsiunyk@gmail.com");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = "<h2>EZShoes замовлення</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("bohdan.tsiunyk.ki.2017@lpnu.ua", "13.04.2000");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
