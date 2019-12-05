using System;
using Autofac;

namespace DependencyInjectionCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<ConsoleNotification>().As<INotification>();
            var container = containerBuilder.Build();

            var notificationService = container.Resolve<INotification>();

           // var notificationService = new ConsoleNotification();

            var user1 = new User("Tim", notificationService);
            user1.ChangeUserName("Robert");

            // Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
