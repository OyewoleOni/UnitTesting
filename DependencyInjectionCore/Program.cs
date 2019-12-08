using System;
using Autofac;
using DependencyInjection.Init;
using DependencyInjection.Notification;

namespace DependencyInjectionCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<ProgramModule>();

            var container = containerBuilder.Build();

            var notificationService = container.Resolve<INotification>();


            UserService userService = container.Resolve<UserService>();

            var user1 = new User("Tim");
            userService.ChangeUserName(user1, "test");

            // Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
