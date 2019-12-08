using DependencyInjection.Init;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Notification
{
    public interface INotification
    {
        void NotifyUsernameChanged(User user);
    }
}
