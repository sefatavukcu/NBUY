//using Solid_DependencyInversion.Before;
using Solid_DependencyInversion.After;


namespace Solid_DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MailService mailService = new MailService();
            //mailService.SendMail(new GmailServer());

            MailService mailService = new MailService();
            mailService.SendMail(new GmailServer(), "engin", "asdf");

            mailService.SendMail(new HotmailServer(), "hahhhaha", "fdjkjdlf");
        }
    }
}   