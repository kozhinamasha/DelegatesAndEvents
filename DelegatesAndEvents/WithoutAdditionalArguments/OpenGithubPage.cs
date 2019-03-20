using System;

namespace DelegatesAndEvents
{
    public class OpenGithubPage
    {
        public void OpenPage(object source, EventArgs args)
        {
            Console.WriteLine(" I have opened the GitHub page");
        }
    }
}
