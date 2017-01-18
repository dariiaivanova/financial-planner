using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using financialplanner.Data;

namespace Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "UserService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы UserService.svc или UserService.svc.cs в обозревателе решений и начните отладку.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class UserService : IUserService
    {
        private readonly static List<User> Users = new List<User>();  

        public bool Register(string email, string password)
        {
            Users.Add(new User(Users.Count)
            {
                Email = email,
                Password = password
            });
            return true;
        }

        public bool LogIn(string email, string password)
        {
            foreach (var user in Users)
            {
                if (user.Email.Equals(email) && user.Password.Equals(password))
                {
                    return true;
                }
            }

            return false;
        }

        public bool ResetPassword(string email)
        {
            throw new NotImplementedException();
        }

        public void ExportUser(string email, string password)

        {
            foreach (var user in Users)
            {
                if (user.Email.Equals(email) && user.Password.Equals(password))
                {
                    var fileName = "D:\\tmp.xlsx";
                    var storage = new ExcelStorage(fileName);
                    user.Save(storage);
                    SendToUser(fileName, user.Email);
                }
            }
        }

        private void SendToUser(string fileName, string email)
        {
            /* здесь указываете SMTP и Порт, у меня например mail.ru - я 
            указал smtp.mail.ru, а порт smtp.mail.ru - 25 или 2525 */
            var Smtp = new SmtpClient("smtp.mail.ru", 25)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential("financial.planner", "qwertyuiopasdfghjklzxcvbnm1234567890")
            };

            /* здесь на месте login указываете логин, на месте password - пароль, 
            если у вас example@mail.ru то указываете просто example (без mail.ru) */
            MailMessage Message = new MailMessage {From = new MailAddress("financial.planner@mail.ru")};

            /* на месте login@mail.ru указываете свой E-mail, на месте KUDA@rambler.ru 
            указываете куда будет отправлено письмо (это может быть не обязательно rambler)*/
            try
            {
                Message.To.Add(new MailAddress(email));
            }
            catch (Exception)
            {
                Console.WriteLine("Unsuccessful");
                throw;
            }

            /*Тема сообщения на месте Theme и текст сообщения на месте Text*/
            Message.Subject = "Your financial data";
            Message.Body = "Your financial data is in attachment";

            Attachment attach = new Attachment(fileName, MediaTypeNames.Application.Octet);
            Message.Attachments.Add(attach);

            Smtp.Send(Message); //сообщение отправлено
        }
    }
}
