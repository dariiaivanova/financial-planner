using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //var userServiceClient = new UserSR.UserServiceClient();
            //var exportServiceClient = new ExcelServiceReference.ExcelExportServiceClient();

            while (true)
            {
                var line = Enter("Do you want to register?");
                if (Confirm(line))
                {
                    line = Enter("Enter your email:");
                    Print("register", userServiceClient.Register(line, Enter("Enter your password")));
                }

                line = Enter("Enter your email:");
                var password = Enter("Enter your password");
                var user = userServiceClient.LogIn(line, password);
                Print("log in", user != null);

                line = Enter("Do you want to export your data?");
                if (Confirm(line))
                {
                    exportServiceClient.ExportUser(user);
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
