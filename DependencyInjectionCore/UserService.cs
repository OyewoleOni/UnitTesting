using DependencyInjection.Init;
using DependencyInjection.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionCore
{
    class UserService
    {
        private INotification _notification;
        public UserService(INotification notification)
        {
            _notification = notification;
        }

        public void ChangeUserName(User user, string newUsername)
        {
            user.Username = newUsername;
            _notification.NotifyUsernameChanged(user);
        }
    }
}
