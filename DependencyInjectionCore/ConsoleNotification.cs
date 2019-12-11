using DependencyInjection.Init;
using DependencyInjection.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionCore
{
   internal class ConsoleNotification : INotification
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Username has been changed to: {user.Username}");
        }
    }
}
