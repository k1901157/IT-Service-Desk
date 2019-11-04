using System;
using System.Collections.Generic;
using System.Text;

namespace IT_Service_Desk
{
    class Incident : Ticket
    {

        private string _issue;
        private string _writeEmail;
        private string _hardwareIssue;
        private string _softwareIssue;
        private string _networkIssue;
        private string _notListed;



        //initialize Incident counter.
        private static int _incidentCount = 0;
        //initialize Priorities counters.
        private static int _p1 = 0;
        private static int _p2 = 0;
        private static int _p3 = 0;
        private static int _p5 = 0;

        private const int INT_INCIDENT = 1;


        public Incident(string Issue, string Email) : base()
        {
            _incidentCount++; //once the Incident has been created, Incident counter will be increased from 0 to 1.
            _issue = Issue;
            _writeEmail = Email;

            if (Issue.Contains("Hardware"))
            {
                _p5++; // if the customer write (Hardware) then P5 counter will be increased from 0 to 1.
            }

            else
            {

                if (Issue.Contains("Software"))
                {
                    _p3++; // if the customer write (Software) then P3 counter will be increased from 0 to 1.
                }

                else
                {


                    if (Issue.Contains("Networ"))
                    {

                        _p1++; // if the customer write (Network) then P1 counter will be increased from 0 to 1.
                    }
                    else
                    {

                        if (Issue.Contains("Not listed"))
                        {
                            _p2++; // if the customer write (Not Listed) then P2 counter will be increased from 0 to 1.
                        }
                    }
                }

            }
        }
    

        public string getIssue() {
            return _issue;
        }


       public string getwriteEmail()
        {
            return _writeEmail;
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