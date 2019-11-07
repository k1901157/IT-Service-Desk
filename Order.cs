using System;
using System.Collections.Generic;
using System.Text;

namespace IT_Service_Desk
{
    class Order : Ticket
    {
        private int _device; //will be used to set the max number of devices to be ordered.
        private string _category; //Laptop, Desktop, IP Phone, Monitor,.....etc.
        private string _Justifiation;


        //initialize Order counter.
        private static int _orderCount = 0;

        //initialize Priorities 5 counter, because in Order ticket we have only Priority 5.
        private static int _p5 = 0;

        //Max number of devices to be ordered by customers.
        private const int MAX_DEVICE = 1; 

        public Order(string Justifiation, string category ) : base(category)
        {
            _Justifiation = Justifiation;// justification email from the customer.
            _category = category;//Laptop, Desktop, IP Phone, Monitor,.....etc.
            _orderCount++; //once the Order has been created, Order counter will be increased from 0 to 1.
            _p5++; //once the Order has been created, P5 counter will be increased from 0 to 1.
        }

        //set maximum number of Devices to be Ordered by customers.
        public bool deviceRequirement(int requirment)
        {

            if (requirment < 0 || requirment > MAX_DEVICE)
            {
                return false;
            }
            else
            {

                _device = requirment;

                return true;
            }
        }

        //get maximum number of Devices to be Ordered by customers.
        public int getDeviceRequirement()
        {
            return _device;
        }
        //Laptop, Desktop,........etc.
        public string getCategory()
        {
            return _category;

        }

        public string getJustification()
        {
            return _Justifiation;
        }

        public static int getOrderCount()
        {
            return _orderCount;
        }

        public static int GetP5Count()
        {
            return _p5;
        }
    }

}
