using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionCore
{
   internal class User
   {
        public User(string name)
        {
            Username = name;
        }

        public string Username { get; set; }

        //public void ChangeUserName(string name)
        //{
        //    Username = name;
        //    _notification.NotifyUsernameChanged(this);
        //}
    }
}
