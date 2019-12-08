using Autofac;
using DependencyInjection.Notification;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionCore
{
    class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleNotification>().As<INotification>();
            builder.RegisterType<UserService>().AsSelf();
        }
    }
}
