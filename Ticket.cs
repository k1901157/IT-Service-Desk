using System;
using System.Collections.Generic;
using System.Text;

namespace IT_Service_Desk
{
    abstract class Ticket
    {

        private string _priority1;
        private string _priority2;
        private string _priority3;
        private string _priority5;

        private static int _ticketCount = 0; //initialize Ticket counter.


        public Ticket()
        {
            //once the Ticket has been created, Ticket counter will be increased from 0 to 1.
            _ticketCount++;

        }
        // get Ticket Count.
        public static int GetTicketCount()
        {
            return _ticketCount;
        }

        internal static void Add(Ticket newTicket)
        {
            
        }


    }
}
