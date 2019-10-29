using System;
using System.Collections.Generic;
using System.Text;

namespace IT_Service_Desk
{
    class Order : Ticket
    {
        private int _device;
        private string _deviceType;
        private string _deviceTypeJustifiation;
        private string _accessoriesType;
        private string _accessoriesTypeJustifiation;



        //initialize Priority 5 counter.
        private static int _p5 = 0;


        //initialize Order counter.
        private static int _orderCount = 0;

        //Max number of devices or Orders to be ordered by customers.
        private const int MAX_DEVICE = 1; 

        public Order(string deviceType, string deviceTypeJustifiation, string accessoriesType, string accessoriesTypeJustifiation) : base()
        {

            _deviceType = deviceType;
            _deviceTypeJustifiation = deviceTypeJustifiation;
            _accessoriesType = accessoriesType;
            _accessoriesTypeJustifiation = accessoriesTypeJustifiation;
            _orderCount++; //once the Order has been created, Order counter will be increased from 0 to 1.
            _p5++; //once the Order has been created, P5 counter will be increased from 0 to 1.


        }

        //set maximum number of Devices or Orders to be Ordered by customers.
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

        //get maximum number of Devices or Orders to be Ordered by customers.
        public int getDeviceRequirement()
        {
            return _device;
        }

        public string getDeviseType()
        {
            return _deviceType;

        }

        public string getDeviceTypeJustification()
        {
            return _deviceTypeJustifiation;
        }


        public string getAccessoriesTypeJustification()
        {
            return _accessoriesTypeJustifiation;
        }
        public string getAccessoriesType()
        {
            return _accessoriesType;
        }

        public static int GetP5Count()
        {
            return _p5;
        }

        public static int GetOrderCount()
        {
            return _orderCount;
        }


    }

}
