using System;

namespace DependencyInjectionCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new ConsoleNotification();

            var user1 = new User("Tim", notificationService);
            user1.ChangeUserName("Robert");

            // Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
