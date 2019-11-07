using System;
using System.Collections.Generic;
using System.Text;

namespace IT_Service_Desk
{
    class Incident : Ticket
    {

        private string _clarification;


        //initialize Incident counter.
        private static int _incidentCount = 0;

        //initialize Priorities counters.
        public static int _p1 = 0;
        public static int _p2 = 0;
        public static int _p3 = 0;
        public static int _p5 = 0;

        public Incident(string clarification, string categoryAndPriority) : base(categoryAndPriority)
        {
            _incidentCount++; //once the Incident has been created, Incident counter will be increased from 0 to 1.
            //_categoryAndPriority = categoryAndPriority; // calling (_categoryAndPriority) from Ticket CLASS.
            _clarification = clarification; // justification or explanation.
        }
    

       public string getClarification()
        {
            return _clarification;
        }

        public static int GetP1Count()
        {
            return _p1;
        }

        public static int GetP2Count()
        {
            return _p2;
        }

        public static int GetP3Count()
        {
            return _p3;
        }

        public static int GetP5Count()
        {
            return _p5;
        }

        public static int GetIncidentCount()
        {
            return _incidentCount;
        }

    }
}