using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var userServiceClient = new UserServiceReference.UserServiceClient();

            while (true)
            {
                var line = Enter("Do you want to register?");
                string email;
                string password;

                if (Confirm(line))
                {
                    email = Enter("Enter your email:");
                    password = Enter("Enter your password");
                    Print("register", userServiceClient.Register(email, password));
                }
                else
                {
                    email = Enter("Enter your email:");
                    password = Enter("Enter your password");
                    Print("log in", userServiceClient.LogIn(email, password));
                }


                line = Enter("Do you want to export your data?");
                if (Confirm(line))
                {
                    userServiceClient.ExportUser(email , password);
                }

                line = Enter("Do you want to exit?");
                if (Confirm(line))
                {
                    return;
                }
            }
        }

        private static string Enter(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();

        }

        private static bool Confirm(string message)
        {
            return message.Equals("yes") || message.Equals("y");

        }

        private static void Print(string message, bool complete)
        {
            if (complete)
            {
                Console.WriteLine("Successfully: " + message);
            }
            else
            {
                Console.WriteLine("Unsuccessfully: " + message);
            }
            Console.WriteLine();
        }
    }
}
