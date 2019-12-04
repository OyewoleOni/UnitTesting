using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionCore
{
   internal class User
   {
       private INotification _notification;

        public User(string name, INotification notification)
        {
            Username = name;
            _notification = notification;
        }

        public string Username { get; set; }

        public void ChangeUserName(string name)
        {
            Username = name;
            _notification.NotifyUsernameChanged(this);
        }
    }
}
