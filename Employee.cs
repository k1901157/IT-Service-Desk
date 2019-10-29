using System;
using System.Collections.Generic;
using System.Text;

namespace IT_Service_Desk
{
    class Employee
    {

        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _phoneNumber;


        
        public Employee(int id, string firstName, string lastName, int phoneNumber, string email)
        {

            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _phoneNumber = phoneNumber;
            _email = email;
        }

        public int getId()
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
