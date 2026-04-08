using System;
using System.Collections.Generic;
using System.Text;

//- -pilet klass on, on eraldi omad omadused (pileti id, event nimi, ostnud kasutaja, hind)

namespace FinalProject
{
    internal class Ticket
    {
        public int ticketID;
        public string eventName = "";
        public string buyerUserName = "";
        public double price;

        public enum TicketType
        {
            Regular,
            VIP,
            EarlyBird
        }
        public enum eventType
        {
            Rock,
            Jazz,
            Tech
        }
    }
}
