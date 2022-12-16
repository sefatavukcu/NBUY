using ShoppingApp.Web.EmailServices.Abstract;
using System.Net;
using System.Net.Mail;

namespace ShoppingApp.Web.EmailServices.Concrete
{
    public class SmtpEmailSender : IEmailSender
    {
        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _userName;
        private string _password;

        public SmtpEmailSender(string host, int port, bool enableSSL, string userName, string password)
        {
            //sunucu bilgileri
            _host = host;
            _port = port;
            _enableSSL = enableSSL;
            //kullanıcı bilgileri
            _userName = userName;
            _password = password;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(this._host, this._port)
            {
                Credentials = new NetworkCredential(this._userName, this._password),
                EnableSsl= this._enableSSL
            };
            return client.SendMailAsync(
                new MailMessage(_userName, email,subject, htmlMessage)
                {
                    IsBodyHtml=true
                });
        }
    }
}
