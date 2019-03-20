using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService();     // subscriber
            var messageService = new MessageService();   //subscriber
            videoEncoder.VideoEncoded += mailService.SendEmail;     //we do subscription,  "+=" means register the handler for this event   VideoEncoded  it is like a list of pointers to methods 
            videoEncoder.VideoEncoded += messageService.SendMessage;  // no() because it is a pointer to the method
            videoEncoder.Encode(video);

            User user = new User() { Name = "Tom" };
            LoginToPostman login = new LoginToPostman();
            OpenGithubPage page = new OpenGithubPage();
            login.LoggedIn += page.OpenPage;
            login.Login(user);

            Console.ReadKey();
        }
    }
}