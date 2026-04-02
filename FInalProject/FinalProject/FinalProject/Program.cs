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
            - muutujad,
            - tingimuslaused
            - tsüklid
            - meetodid
            - klassid
            - liht ja komposiitandmetüübid

            AIkasutus ja kopipasta kellegi teise pealt ei ole kopipasta lubatud.

            Konspekt ja Stackoverflow ON LUBATUD */
            User account = new User();
            account.userName = "";
            account.email = "";
            account.password = "";
            //List<string> validEmails = new List<string>() {"@example.com","@gmail.com","@local.com" };
            Console.WriteLine("Welcome!\nWould you like to log in or register a new account?");
            string userInput = GetString();
            if (userInput == "register")
            {
                Console.WriteLine("Great, lets get you started then!");
                RegisterAccount(account.email, account.userName, account.password/*, validEmails*/);
            }
            else if (userInput == "log in")
            {

            }
            else
            {
                userInput = GetString();
            }
        }

        private static void RegisterAccount(string email, string username, string password/*, List<string> validEmails*/)
        {
            do
            {
                Console.WriteLine("To register an account, first please enter a valid email:");
                email = Console.ReadLine();
            } while (!email.Contains("@example.com") || email.Contains("@gmail.com"));
            do
            {
                Console.WriteLine("Enter your password:");
                password = Console.ReadLine();
            } while (!password.Length)
        }

        private static string GetString()
        {
            string input = "";
            do
            {
                Console.WriteLine("Enter the action:");
                input = Console.ReadLine();
            } while (!input.Contains("register") || input.Contains("log in"));
            return input;
        }
    }
}
