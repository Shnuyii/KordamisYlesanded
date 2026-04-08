using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                B
            - Kontserdipiletiprogramm
            - - user klass on, tal on email username ja parool
            - - registreeritakse emailiga (kontrolli et on @)
            - - sisse logitakse kasutajanime ja parooliga
            - - pilet klass on, on eraldi omad omadused (pileti id, event nimi, ostnud kasutaja, hind)
            - kasutaja saab vaadata kas andmebaasis (soldticket list) on tal ostetud pileteid tema kasutajale
            - on ka event klass, kasutaja saab osta pileteid eventile. kasutaja sisestab rahasumma piletisumma küsimisel
            - piletil on juures ka bool ischeckedin omadus mis ütleb kas kasutaja on eventil käinud
            - kasutaja saab oma pileteid checkinida.
            - kasutaja saab vaadata ainult oma check-initud evente

            = koodinõuded Variandile A ja B:
            - muutujad
            - tingimuslaused
            - tsüklid
            - meetodid
            - klassid
            - liht ja komposiitandmetüübid

            AIkasutus ja kopipasta kellegi teise pealt ei ole lubatud.

            Konspekt ja Stackoverflow ON LUBATUD */
            User account = new User();
            account.userName = "";
            account.email = "";
            account.password = "";
            //List<string> validEmails = new List<string>() {"@example.com","@gmail.com","@local.com" };
            Console.WriteLine("Welcome!\nWould you like to log in or register a new account?");
            string userInput = GetLogin();
            if (userInput == "register")
            {
                Console.WriteLine("Great, lets get you started then!");
                RegisterAccount(account.email, account.userName, account.password/*, validEmails*/); // validEmails ei tööta, ei oska lahendada
                Console.WriteLine("Would you like to log in now?");
                string answer = GetString();
                if (answer == "yes" || answer == "log in")
                {
                    Console.WriteLine("Great, lets log you in then!");
                }
            }
            else if (userInput == "log in")
            {
                LoginSystem(account.userName, account.password);
            }
        }

        private static void LoginSystem(string userName, string password)
        {
            Console.WriteLine("Enter your username:");
            userName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter your password:");
            password = Console.ReadLine() ?? string.Empty;
        }

        private static void RegisterAccount(string email, string username, string password/*, List<string> validEmails*/)
        {
            do
            {
                Console.WriteLine("To register an account, first please enter a valid email:");
                email = Console.ReadLine()?.Trim() ?? string.Empty;
            } while (!email.Contains("@"));

            do
            {
                Console.WriteLine("A password must contain 5 or more letters at least. Enter your password:");
                password = Console.ReadLine() ?? string.Empty;
            } while (password.Length < 5);

            Console.WriteLine("Enter your username:");
            username = Console.ReadLine()?.Trim() ?? string.Empty;

            string line = $"{email},\n{username},\n{password}"/*{Environment.NewLine}*/;

            File.AppendAllText("RegisteredAccounts.txt", line);
        }

        private static string GetLogin()
        {
            string input = string.Empty;
            do
            {
                Console.WriteLine("Enter the action register or log in to continue:");
                input = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
            } while (input != "register" && input != "log in");
            return input;
        }

        private static string GetString()
        {
            string input = string.Empty;
            do
            {
                Console.WriteLine("Enter yes/no or log in to continue:");
                input = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
            } while (input != "yes" && input != "no" && input != "log in");
            return input;
        }
    }
}
