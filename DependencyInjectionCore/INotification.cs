using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionCore
{
    interface INotification
    {
        void NotifyUsernameChanged(User user);
    }
}
