using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    internal class Event
    {
        public static void LoggedIn(string userName)
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?\n1. View tickets.\n2. Purchase tickets.\n3. Log out.");
            string userInput = Console.ReadLine().Trim().ToLower();
            if (userInput == "1" || userInput == "1." || userInput == "view")
            {
                TicketViewer(userName);
            }
            else if (userInput == "2" || userInput == "2." || userInput == "purchase")
            {
                TicketPurchase(userName);
            }
            else if (userInput == "3" || userInput == "3." || userInput == "log out")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Environment.Exit(0);
            }
        }

        private static void TicketPurchase(string userName)
        {
            int paid = 0;
            int amtToPay = 0;
            int a = 0;
            bool checkedIn = false;
            Ticket.TicketType ticketType;
            Console.Clear();
            Console.WriteLine("What kind of ticket would you like to buy?");
            foreach (var i in Enum.GetNames(typeof(Ticket.TicketType))) 
            {
                Console.WriteLine(a + 1+". "+i);
                a++;
            }
            string userInp = Console.ReadLine();
            Console.WriteLine("""
                Concert types with prices:
                1. Rock = 30$
                2. Jazz = 40$
                3. Tech = 34$
                """);
            string userInp2 = Console.ReadLine().ToLower();
            if (userInp == "1")
            {
                if (userInp2 == "rock")
                {
                    amtToPay = 30;
                    Console.WriteLine($"Event: Rock.\nTicket type: standard.\nAmount to pay: {amtToPay}$\nPlease insert the correct amount.");
                    do
                    {
                        paid = int.Parse(Console.ReadLine());
                    } while (paid < amtToPay);
                    Console.WriteLine("Thank you!");
                }
                else if (userInp2 == "jazz")
                {
                    amtToPay = 40;
                    Console.WriteLine($"Event: Jazz.\nTicket type: standard.\nAmount to pay: {amtToPay}$\nPlease insert the correct amount.");
                    do
                    {
                        paid = int.Parse(Console.ReadLine());
                    } while (paid < amtToPay);
                    Console.WriteLine("Thank you!");
                }
                else if (userInp2 == "tech")
                {
                    amtToPay = 34;
                    Console.WriteLine($"Event: Tech.\nTicket type: standard.\nAmount to pay: {amtToPay}$\nPlease insert the correct amount.");
                    do
                    {
                        paid = int.Parse(Console.ReadLine());
                    } while (paid < amtToPay);
                    Console.WriteLine("Thank you!");
                }
                else
                {
                    Console.WriteLine("Could not find the selected event type. :c");
                }
            string bought = $"{userName} {userInp2}, ticket type standard.Checked in = {checkedIn}\n";
            File.AppendAllText("BoughtTickets.txt", bought);
            }
            else if (userInp == "2")
            {
                int modifier = 3;
                if (userInp2 == "rock")
                {
                    amtToPay = 30 * modifier;
                    Console.WriteLine($"Event: Rock.\nTicket type: VIP.\nAmount to pay: {amtToPay}$\nPlease insert the correct amount.");
                    do
                    {
                        paid = int.Parse(Console.ReadLine());
                    } while (paid < amtToPay);
                    Console.WriteLine("Thank you!");
                }
                else if (userInp2 == "jazz")
                {
                    amtToPay = 34 * modifier;
                    Console.WriteLine($"Event: Jazz.\nTicket type: VIP.\nAmount to pay: {amtToPay}$\nPlease insert the correct amount.");
                    do
                    {
                        paid = int.Parse(Console.ReadLine());
                    } while (paid < amtToPay);
                    Console.WriteLine("Thank you!");
                }
                else if (userInp2 == "tech")
                {
                    amtToPay = 34 * modifier;
                    Console.WriteLine($"Event: Tech.\nTicket type: VIP.\nAmount to pay: {amtToPay}$\nPlease insert the correct amount.");
                    do
                    {
                        paid = int.Parse(Console.ReadLine());
                    } while (paid < amtToPay);
                    Console.WriteLine("Thank you!");
                }
                else
                {
                    Console.WriteLine("Could not find the selected event type. :c");
                }
                string bought = $"{userName} {userInp2}, ticket type VIP. Checked in = {checkedIn}\n";
                File.AppendAllText("BoughtTickets.txt", bought);
            }
            else if (userInp == "3")
            {
                int modifier = 2;
                if (userInp2 == "rock")
                {
                    amtToPay = 30 * modifier;
                    Console.WriteLine($"Event: Rock.\nTicket type: early birb.\nAmount to pay: {amtToPay}$\nPlease insert the correct amount.");
                    do
                    {
                        paid = int.Parse(Console.ReadLine());
                    } while (paid < amtToPay);
                    Console.WriteLine("Thank you!");
                }
                else if (userInp2 == "jazz")
                {
                    amtToPay = 40 * modifier;
                    Console.WriteLine($"Event: Jazz.\nTicket type: early birb.\nAmount to pay: {amtToPay}$\nPlease insert the correct amount.");
                    do
                    {
                        paid = int.Parse(Console.ReadLine());
                    } while (paid < amtToPay);
                    Console.WriteLine("Thank you!");
                }
                else if (userInp2 == "tech")
                {
                    amtToPay = 34 * modifier;
                    Console.WriteLine($"Event: Tech.\nTicket type: early birb.\nAmount to pay: {amtToPay}$\nPlease insert the correct amount.");
                    do
                    {
                        paid = int.Parse(Console.ReadLine());
                    } while (paid < amtToPay);
                    Console.WriteLine("Thank you!");
                }
                else
                {
                    Console.WriteLine("Could not find the selected event type. :c");
                }
            string bought = $"{userName} {userInp2}, ticket type early birb. Checked in = {checkedIn}\n";
            File.AppendAllText("BoughtTickets.txt", bought);
            }
            else
            {
                Console.WriteLine("Nani?! What ticket type??");
                Thread.Sleep(2500);
                Console.Clear();
            }
        LoggedIn(userName);
        }

        private static void TicketViewer(string userName)
        {
            Console.Clear();
            foreach (string line in File.ReadLines(@"BoughtTickets.txt"))
            {
                if (line.Contains($"{userName}"))
                {
                    Console.WriteLine(line);
                }
                Thread.Sleep(500);
            }
            Console.ReadLine();
            Console.WriteLine("Would you like to check in a ticket?");
            string userInpt = Console.ReadLine() ?? string.Empty;
            if (userInpt == "yes" || userInpt == "1")
            {
                Console.WriteLine("Which event would you like to check in? Insert event type:");
                string userInpt2 = Console.ReadLine().ToLower();
                Console.WriteLine("Also enter the ticket type please and thank you ^_^");
                string userInpt3 = Console.ReadLine().ToLower();
                string line = $"{userName} {userInpt2}";
                string line1 = $"{userName} {userInpt2}, ticket type {userInpt3}. Checked in = true.";
                if (File.ReadAllLines(@"BoughtTickets.txt").Contains(line)) //Check fail, idk miks
                {
                    File.AppendAllText("BoughtTickets.txt", line1);
                }
            }
            LoggedIn(userName);
        }
    }
}
