using System;
using Model;
using Model.Interface;
using Model.Service;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your username");
            var username = Console.ReadLine();

            Console.WriteLine("Please enter your password");
            var password = Console.ReadLine();

            IAuthService authService = new AuthService();

            if (authService.Login(username, password))
            {
                Console.WriteLine("Login Success");
            }
            else
            {
                Console.WriteLine("Login Failed.");
            }

            Console.ReadLine();
        }
    }
}
