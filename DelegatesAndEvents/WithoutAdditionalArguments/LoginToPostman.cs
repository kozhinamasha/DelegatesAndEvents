using System;
using System.Threading;

namespace DelegatesAndEvents
{
    public class LoginToPostman
    {
        public delegate void LoggedInEventHandler(object source, EventArgs args);

        public event LoggedInEventHandler LoggedIn;

        public void Login(User user)
        {
            Console.WriteLine("User {0} has logged in", user.Name);
            Thread.Sleep(3000);
            OnLoggedIn(user);
        }

        protected virtual void OnLoggedIn(User user)
        {
            if (LoggedIn != null)
            {
                LoggedIn(this, EventArgs.Empty);
            }
        }
    }
}
