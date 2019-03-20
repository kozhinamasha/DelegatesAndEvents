using System;

namespace DelegatesAndEvents
{
    public class MessageService
    {
        public void SendMessage(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message service sending the text message " + args.Video.Title);
        }
    }
}
