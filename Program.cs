using System;
using System.Collections.Generic; // This is needed for lists
using IT_Service_Desk;
using System.IO;

namespace TI_Service_Desk
{
    class Program
    {
        static void Main(string[] args)
        {
            //we will use it later to create file to save the date in and read the data from.
            List<string> lists = new List<string>();

            //the app started.
            Console.Write("****Welcome to IT Service Desk****" + "\n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.Write("Please enter your contact details: " + "\n");
            Console.WriteLine();
            //asking the customer to enter the contact details.
            //calling Employee class
            List<Employee> employees = new List<Employee>();

            Console.Write("ID: ");// the customer will enter ID.
            int ID = int.Parse(Console.ReadLine());

            Console.Write("First Name : ");// the customer will enter First Name.
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");// the customer will enter Last Name.
            string lastName = Console.ReadLine();

            Console.Write("Phone Number: ");// the customer will enter Phone Number.
            int phoneNumber = int.Parse(Console.ReadLine());

            Console.Write("Email: ");// the customer will enter Email.
            string email = Console.ReadLine();

            Console.Write("Date (DD.MM.YYYY): ");// the customer will enter Email.
            string date = Console.ReadLine();

            //creating list for the customer entries .
            Employee newEmployee = new Employee(ID, firstName, lastName, phoneNumber, email, date);
            employees.Add(newEmployee);

            //create a list for Tickets 
            List<Ticket> tickets = new List<Ticket>();
            //create a list for Incidents
            List<Incident> incidentList = new List<Incident>();
            //create a list for Orders
            List<Order> orderList = new List<Order>();

            //keep looping until the customer choose end.
            int response;
            do
            {
                Console.WriteLine("(1) - Incident");
                Console.WriteLine("(2) - Order");
                Console.WriteLine("(0) - End");
                response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    
                    case 1:// once the customer selected (1- Incident).
                          // the customer creating new Incident.
                        int incidentResponse;
                        //here the customer will select the incident type.
                        Console.WriteLine("{1} - Hardware");
                        Console.WriteLine("{2} - Software");
                        Console.WriteLine("{3} - Network");
                        Console.WriteLine("{4} - Not Listed");
                        incidentResponse = int.Parse(Console.ReadLine());


                        switch (incidentResponse)
                        {
                            case 1://once the customer selected (1 - Hardware).
                                //here the customers can give more details about their issues.
                                Console.WriteLine("Explain more as possible as you can about your issue : ");
                                string clarificationHardware = Console.ReadLine();
                                //here assigning the incident category with priority5.
                                string category_priority5 = ("Hardware Issue with Priority 5");
                                //increasing p5 count.
                                Incident._p5++; // p5 count has been increased from 0 to 1.

                                //create new Incident (Hardware Incidnt with priority 5).
                                Incident HardwareIncident = new Incident(clarificationHardware, category_priority5);
                                incidentList.Add(HardwareIncident);
                               
                                break;
                            case 2://once the customer selected (2- Software ).
                                Console.WriteLine("Explain more as possible as you can about your issue : ");
                                string clarificationSoftware = Console.ReadLine();
                                //here assigning the incident category with priority3.
                                string category_priority3 = ("Software Issue with Priority 3");
                                //increasing p3 count.
                                Incident._p3++;
                                //creating new Incident (Software Incident with Priority 3)
                                Incident SoftwareIncident = new Incident(clarificationSoftware, category_priority3);
                                incidentList.Add(SoftwareIncident);
                                
                                break;

                            case 3://once the customer selected (3- Network).
                                Console.WriteLine("Explain more as possible as you can about your issue : ");
                                string writeNetworkEmail = Console.ReadLine();
                                //here assigning the incident category with priority1.
                                string category_priority1 = ("NetWork Iuuse with Priority 1");
                                //increasing p1 count
                                Incident._p1++;
                                //creating new Incident (Network Incident with Priority 1)
                                Incident NetworkIncident = new Incident(writeNetworkEmail, category_priority1);
                                incidentList.Add(NetworkIncident);
                                break;

                            case 4://once the customer selected (4- Not Listed)
                                Console.WriteLine("Explain more as possible as you can about your issue : ");
                                string writeNotListedEmail = Console.ReadLine();
                                //here assigning the incident category with priority2.
                                string category_priority2 = ("Unknown Issue with Priority 2");
                                //increasing p2 count.
                                Incident._p2++;
                                //creating new Incident (Unknown Issue with Priority 2)
                                Incident NotListedIncident = new Incident(writeNotListedEmail, category_priority2);
                                incidentList.Add(NotListedIncident);
                                break;
                        }
                        Console.WriteLine();
                        break;
                    
                    
                    case 2:// once the customer selected (2- Order).
                          // the customer creating new Order.
                        int orderResponse;
                        //here the custumers will choose what they would like to order.
                        Console.WriteLine("{1} - Laptop");
                        Console.WriteLine("{2} - Desktop");
                        Console.WriteLine("{3} - IP Phone");
                        Console.WriteLine("{4} - Monitor");
                        Console.WriteLine("{5} - Keyboard");
                        Console.WriteLine("{6} - Mouse");
                        orderResponse = int.Parse(Console.ReadLine());
                        switch (orderResponse)
                        {
                            case 1://once the customer selected (1- Laptop).
                                //if the customers want to order many devices/accessories so they can mention in the Justification.
                                //if the customer want to order devices/accessories on behalf of another customer also they can use the Justification .
                                Console.WriteLine("write Justification: ");
                                string laptopJustification = Console.ReadLine();
                                string laptopCategory = ("Laptop");// here assigning the Device type, we will use it later using the class.
                                //create new Order (Laptop).
                                Order laptopOrder = new Order(laptopJustification, laptopCategory);
                                orderList.Add(laptopOrder);
                                break;

                                case 2://once the customer selected (2- Desktop).
                                Console.WriteLine("write Justification: ");
                                string desktopJustification = Console.ReadLine();
                                string desktopCategory = ("Desktop");
                                Order desktopOrder = new Order(desktopJustification, desktopCategory);
                                orderList.Add(desktopOrder);
                                break;

                            case 3://once the customer selected (3- IP Phone).
                                Console.WriteLine("write Justification: ");
                                string ipPhoneJustification = Console.ReadLine();
                                string ipPhoneCategory = ("IP Phone");
                                Order ipPhoneOrder = new Order(ipPhoneJustification, ipPhoneCategory);
                                orderList.Add(ipPhoneOrder);
                                break;

                            case 4://once the customer selected (4- Monitor).
                                Console.WriteLine("write Justification: ");
                                string monitorJustification = Console.ReadLine();
                                string monitorCategory = ("Monitor");
                                Order monitorOrder = new Order(monitorJustification, monitorCategory);
                                orderList.Add(monitorOrder);
                                break;

                            case 5://once the customer selected (5- Keyboard).
                                Console.WriteLine("write Justification: ");
                                string keyboardJustification = Console.ReadLine();
                                string keyboardCategory = ("Keyboard");
                                
                                Order keyboardOrder = new Order(keyboardJustification, keyboardCategory);
                                orderList.Add(keyboardOrder);
                                break;

                            case 6://once the customer selected (6- Mouse).
                                Console.WriteLine("write Justification: ");
                                string mouseJustification = Console.ReadLine();
                                string mouseCategory = ("Mouse");
                                
                                Order mouseOrder = new Order(mouseJustification, mouseCategory);
                                orderList.Add(mouseOrder);
                                break;
                        }

                        // here asking the customers to put the number of devices or accessories to be ordered.
                        foreach (Order orders in orderList)
                        {

                            Console.Write($"number of ({orders.getCategory()})s that you want to order: ");

                            while (!orders.deviceRequirement(int.Parse(Console.ReadLine())))
                            {
                                Console.WriteLine("Invalid!"); //max number of devices to be order is 1.
                                Console.Write($"Maximum numbers of ({ orders.getCategory() }) to be orderd is 1: ");
                            }

                        }
                        break;
                
                default:
                        break;
            }
                Console.WriteLine();
            } while (response > 0);


            //start saving and printing required data.

            Console.WriteLine("");

            //saving here importent details regarding Tickets (Incidents/Orders).
            //saving here number of Tickets, Incidents and Orders have been created.
            //save all data to the file.
                lists.Add("Thanks for using IT Service Desk ticketing System");
                lists.Add("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                lists.Add($"Number of Tikets: { Ticket.GetTicketCount() }.");
                lists.Add($"Number of Incidents: { Incident.GetIncidentCount() }.");
                lists.Add($"Number of Orders: { Order.getOrderCount() }.");
            //we will save here the number of Incidents and Orders as per the Priority (P1, P2, P3....etc.
                lists.Add($"Number of Ticket/Incident with priority1 (P1) : { Incident.GetP1Count() }.");
                lists.Add($"Number of Ticket/Incident with priority2 (P2) : { Incident.GetP2Count() }.");
                lists.Add($"Number of Ticket/Incident with priority3 (P3) : { Incident.GetP3Count() }.");
                lists.Add($"Number of Ticket/Incident with priority5 (P5) : { Incident.GetP5Count() }.");
                lists.Add($"Number of Ticket/Order with priority5 (P5) : { Order.GetP5Count() }.");



            //saving data in the file.
           // File.WriteAllLines($"IT_Service_Desk{Ticket._ticketNumberToFile}.txt", lists);
         

            //here we will save all customer data (contact Details).
            foreach (Employee employee in employees)
            {
                //save data to the file
                lists.Add($"ID: {Employee.getId()}");
                lists.Add($"Full Name: {employee.getLastName()}, {employee.getFirstName()}");
                lists.Add($"Phone Number: {employee.getPhoneNumber()}");
                lists.Add($"Email: {employee.getEmail()}" + "\n");

                //saving data in the file.
                //creating file as per the ID and the Date.
                File.WriteAllLines("IT_Service_Desk" + " " + $"{Employee.getId()}--{Employee.getDate()}.txt", lists);
            }

            //here we will save all the Incident's details that we need.
            foreach (Incident incidents in incidentList)
            {

                //save data to the file
                lists.Add($"You have : {incidents.getCategoryAndPriority()}" + "\n");
                lists.Add($"Your Clarification is: {incidents.getClarification()}" + "\n");
                lists.Add("We will check your issue, and we will contact you as per your Ticket priority" + "\n");
                lists.Add($"Your Incident Number is " + "TI-" + Ticket.getTiketNumber() + "\n");

                //saving data in the file.
                //creating file as per the ID and the Date.
                File.WriteAllLines("IT_Service_Desk" + " " + $"{Employee.getId()}--{Employee.getDate()}.txt", lists);
            }

            //here we will save all the Order's details that we need.
            foreach (Order orders in orderList)
            {

                //save data to the file
                lists.Add($"type of Devices/Accessories that you have ordered is : {orders.getCategory()}" + "\n");
                lists.Add($"with this Justification:  {orders.getJustification()}" + "\n");
                lists.Add("Once your order has been approved, you will recieve your device" + "\n");
                lists.Add($"Your Order Number is " + "TO-" + Ticket.getTiketNumber() + "\n");

                //saving data in the file.
                //creating file as per the ID and the Date.
                File.WriteAllLines("IT_Service_Desk"+" "+$"{Employee.getId()}--{Employee.getDate()}.txt", lists);
            }

                //here print out all data tha we saved in the file IT_Service_Desk.txt
                string[] printData = File.ReadAllLines($"IT_Service_Desk" + " " + $"{Employee.getId()}--{Employee.getDate()}.txt");
            foreach (var item in printData)
            {
                Console.WriteLine(item);
            }
        }
    }
}
