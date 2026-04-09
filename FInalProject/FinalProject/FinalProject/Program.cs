using System;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace FinalProject
{
    internal class Program
    {
        public static void Main(string[] args)
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
            Console.ResetColor();
            User account = new User();
            account.userName = "";
            account.email = "";
            account.password = "";
            //List<string> validEmails = new List<string>() {"@example.com","@gmail.com","@local.com" };
            Console.WriteLine("Welcome!\nWould you like to log in or register a new account?");
            string userInput = GetLogin();
            if (userInput == "register")
            {
                Console.Clear();
                Console.WriteLine("Great, lets get you started then!");
                RegisterAccount(account.email, account.userName, account.password/*, validEmails*/); // validEmails ei tööta, ei oska lahendada
                Console.WriteLine("Would you like to log in now?");
                string answer = GetString();
                if (answer == "yes" || answer == "log in")
                {
                    Console.Clear();
                    Console.WriteLine("Great, lets log you in then!");
                    LoginSystem(account.userName,account.password);
                }
            }
            else if (userInput == "log in")
            {
                LoginSystem(account.userName, account.password);
            }
        }

        private static void LoginSystem(string userName, string password)
        {
            Thread.Sleep(250);
            Console.Clear();
            Console.WriteLine("Enter your username:");
            userName = Console.ReadLine() ?? string.Empty; // ?? string.empty küsib uuesti kui string on tühi
            Console.WriteLine("Enter your password:");
            password = Console.ReadLine() ?? string.Empty;
            string line = $"{password}, {userName}";
            if (File.Exists("RegisteredAccounts.txt") && File.ReadAllLines("RegisteredAccounts.txt").Contains(line))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"You have now logged in. Welcome {userName}.");
                System.Threading.Thread.Sleep(2500);
                Event.LoggedIn(userName);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Login failed, try again.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Damn.");
                Console.ResetColor();
            }
        }

        private static void RegisterAccount(string email, string username, string password/*, List<string> validEmails*/)
        {
            string controlLine = $"{password}, {username}";
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
            if (!File.ReadAllLines("RegisteredAccounts.txt").Contains(controlLine))
            {
                string line1 = $"{email}\n";
                string line2 = $"{password}\n";
                string line3 = $"{username}\n";
                string allLines = $"{email} \n{password}, {username}\n";

                File.AppendAllText("RegisteredEmail.txt", line1);
                File.AppendAllText("RegisteredPasswords.txt", line2);
                File.AppendAllText("RegisteredUsernames.txt", line3);
                File.AppendAllText("RegisteredAccounts.txt", allLines);
                Console.WriteLine("Account registered successfully.");
            }
            //User.ExistingAccounts(line1, line2, line3);
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
