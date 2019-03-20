using System;

namespace DelegatesAndEvents
{
    public class MailService   //subscriber
    {
        public void SendEmail(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail service sending email " + e.Video.Title);
        }
    }
}
