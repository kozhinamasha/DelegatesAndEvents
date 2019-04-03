using System;
using System.Net.Mime;
using DelegatesAndEvents.SimpleDelegate;

namespace DelegatesAndEvents
{
    class Program
    {
        delegate string MyNew(string text);
        static void Main(string[] args)
        {
            //with additional arguments
            var video = new Video() { Title = "Video1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService();     // subscriber
            var messageService = new MessageService();   //subscriber
            videoEncoder.VideoEncoded += mailService.SendEmail;     //we do subscription,  "+=" means register the handler for this event   VideoEncoded  it is like a list of pointers to methods 
            videoEncoder.VideoEncoded += messageService.SendMessage;  // no() because it is a pointer to the method
            videoEncoder.Encode(video);

            //without additional arguments
            User user = new User() { Name = "Tom" };
            LoginToPostman login = new LoginToPostman();
            OpenGithubPage page = new OpenGithubPage();
            login.LoggedIn += page.OpenPage;
            login.Login(user);

            //the simple delegate C# 1.0
            Printer print = SimpleDelegate.SimpleDelegate.PrintText;
            print("simple delegate works correctly");

            //delegate with using Lambda expression  C# 3.0
            PrintWithLambdaSimple print3 = text => Console.WriteLine(text);
            print3("more simple delegate with lambda");

            MyNew mynew = text => text;
            Console.WriteLine(mynew("My"));

            //without declaration of delegate at all C# 3.5
            Func<string, string> funcTest = delegate (string text)
            {
                return text;
            };
            Console.WriteLine(funcTest("Func delegates without delegate declaration"));

            //without declaration of delegate with lambda C# 3.5
            Func<string, string> funcTest2 = text => { return text; };
            Console.WriteLine(funcTest2("The new func delegates with lambda"));

            //action delegates
            Action<string> actionTest = text => { Console.WriteLine(text); };
            actionTest("Action delegates");

            Console.ReadKey();
        }
    }
}