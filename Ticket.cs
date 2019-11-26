using System;
using System.Collections.Generic;
using System.Text;

namespace IT_Service_Desk
{
    abstract class Ticket : TI_Service_Desk.Program
    {
        protected string _categoryAndPriority;// protected because we need to use it in Incident Class.

        //will be used to give random numbers for Incidents and Orders.
        private static int _ticketNumber;

        public static int _ticketNumberToFile;

        //initialize Ticket counter.
        private static int _ticketCount = 0;


        public Ticket(string categoryAndPriority)
        {
            //once the Ticket has been created, Ticket counter will be increased from 0 to 1.
            _ticketCount++;
            _categoryAndPriority = categoryAndPriority;//set category and priority(Hardware issue with priority 5) using string in the main program.
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
            _ticketNumberToFile = result;

            return _ticketNumber;
        }

        //get Incident category and priority as per the Incident Type.
        public string getCategoryAndPriority()
        {
            return _categoryAndPriority;
        }

        internal static void Add(Ticket newTicket)
        {

        }

    }
}
