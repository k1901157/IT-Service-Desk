using System;
using System.Collections.Generic;
using System.Text;

namespace IT_Service_Desk
{
    class Employee : TI_Service_Desk.Program
    {

        private static int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _phoneNumber;

        //here we added date to be able to creating diffrent file names in every time we are runing the app.
        //here we are using string instead of (Date Time) because it is not accepttable to save the files with (: and /) if we are using (Date Time)
        private static string _date;



        public Employee(int id, string firstName, string lastName, int phoneNumber, string email, string date)
        {

            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _phoneNumber = phoneNumber;
            _email = email;
            _date = date;
        }

        public static int getId()
        {
            return _id;
        }

        public string getFirstName()
        {
            return _firstName;
        }

        public string getLastName()
        {
            return _lastName;
        }

        public int getPhoneNumber()
        {
            return _phoneNumber;
        }

        public string getEmail()
        {
            return _email;
        }

        //we are using this methode to be able to create diffrent file names.

        public static string getDate()
        {
            return _date;
        }

        // private static string setEmail()
        // we can use it also to make sure that customers writing their emails in correct way with (@).
        public string setEmail()
        {

            string email = _email;

            do
            {
                Console.Write("Email: ");
                email = Console.ReadLine();
            } while (!email.Contains("@"));

            return email;
        }


    }
}
