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

        private static int _ticketNumber;//will be used to give random number

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

        //get Random Ticket Number.
        //When this method is called many times, it still has good Randoms.

        public static int getTiketNumber()
        {
            Random _random = new Random();

            int result = _random.Next();

            _ticketNumber = result;

            return _ticketNumber;

        }

        internal static void Add(Ticket newTicket)
        {
            
        }


    }
}
