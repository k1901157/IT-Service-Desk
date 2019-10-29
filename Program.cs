using System;
using System.Collections.Generic; // This is needed for lists
using IT_Service_Desk;

namespace WS5_Cars_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //the app started.
            Console.Write("****Welcome to IT Service Desk****" + "\n");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.Write("Please enter your contact details: " + "\n");
            Console.WriteLine();
            //asking the customer in enter the contact details.
            //calling Employee class
            List<Employee> employees = new List<Employee>();
            
            Console.Write("ID: ");// the customer will enter ID.
            int ID = int.Parse (Console.ReadLine());

            Console.Write("First Name : ");// the customer will enter First Name.
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");// the customer will enter Last Name.
            string lastName = Console.ReadLine();

            Console.Write("Phone Number: ");// the customer will enter Phone Number.
            int phoneNumber = int.Parse(Console.ReadLine());

            Console.Write("Email: ");// the customer will enter Email.
            string email = Console.ReadLine();

            Employee newEmployee = new Employee(ID, firstName, lastName, phoneNumber, email);
            employees.Add(newEmployee);





            
            bool addTicket, incident;
            //Ticket newTicket;
            //create a list for Tickets 
            List<Ticket> tickets = new List<Ticket>();
            //create a list for Incidents
            List<Incident> incidentList = new List<Incident>();
            //create a list for Orders
            List<Order> orderList = new List<Order>();

            //keep looping until the customer says no.
            do
            {
                //asking the customers if they would like to create a Ticket or not.
                Console.Write("Create a new Ticket? (y/n)");
                addTicket = Char.Parse(Console.ReadLine()) == 'y';

                if (addTicket)//the customer creating new Ticket.
                {

                    //asking the customers if they would like to create Incident OR Order?
                    Console.Write("Enter Incident or Order? (i/o)");
                    incident = Char.Parse(Console.ReadLine()) == 'i';

                    if (incident)//the custome creating new Incident.
                    {
                        //here the customer will choose what kind of issues he would like to escalated to IT Department.
                        Console.Write("If you have Hardware issue please confirm by typing  (Hardware) : ");
                        string hardwareIssue = Console.ReadLine();
                        Console.Write("If you have Softdware issue please confirm by typing  (Software): ");
                        string softwareIssue = Console.ReadLine();
                        Console.Write("If you have Network issue please confirm by typing  (Network): ");
                        string networkIssue = Console.ReadLine();
                        Console.Write("If you issue not listed please typing  (Not Listed): ");
                        string notListedIssue = Console.ReadLine();
                        Console.WriteLine("Explain more as possible as you can about your issue : ");
                        string writeEmail = Console.ReadLine();
                        //create new Incident.
                        Incident newIncident = new Incident(hardwareIssue, softwareIssue, networkIssue, notListedIssue,writeEmail);
                        incidentList.Add(newIncident);

                    }
                    else// the customer creating new Order.
                    {

                        //here the custumers will choose what they would like to order.
                        Console.WriteLine("Please choose then type the Device that you want to order " + "\n" +
                                          "(Laptop - Desktop - IP Phone): ");
                        string deviceType = Console.ReadLine();

                        Console.WriteLine("write Justification: ");
                        string deviceTypeJustification = Console.ReadLine();

                        Console.WriteLine("Please choose then type the Accessory that you want to order" + "\n" +
                                          "(Monitor - Keyboard - Mouse): ");
                        string accessoriesType = Console.ReadLine();

                        Console.WriteLine("write Justification: ");
                        string accessoriesTypeJustification = Console.ReadLine();
                        //create new Order.
                        Order newOrder = new Order(deviceType, deviceTypeJustification, accessoriesType, accessoriesTypeJustification);
                        orderList.Add(newOrder);
                    }
                    // here asking the customers to put the number of devices or accessories those they want to order.
                    foreach (Order orders in orderList)
                    {
                        
                        Console.Write($"number of {orders.getDeviseType()}s that you orderd: " );

                        while (!orders.deviceRequirement(int.Parse(Console.ReadLine())))
                        {
                            Console.WriteLine("Invalid!"); //max number of devices to be order is 1.
                            Console.Write($"number of devises(max 1!)  { orders.getDeviseType() }: ");
                        }

                        Console.Write($"number of { orders.getAccessoriesType()}s that you orderd: ");

                        while (!orders.deviceRequirement(int.Parse(Console.ReadLine())))
                        {
                            Console.WriteLine("Invalid!");//max number of accessories to be order is 1.
                            Console.Write($"number of devises(max 1!) { orders.getDeviseType() }: ");
                        }
                        
                    }


                }

                Console.WriteLine();
            } while (addTicket);


            //start printing required data.

            Console.WriteLine("");

            //print out the info about created Tickets with Contact Details
            //we will print here number of Tickets, Incidents and Orders those has been created.
            Console.WriteLine();
            Console.WriteLine("Thanks for using IT Service Desk ticketing System");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine($"Number of Tikets: { Ticket.GetTicketCount() }.");
            Console.WriteLine($"Number of Incidents: { Incident.GetIncidentCount() }.");
            Console.WriteLine($"Number of Orders: { Order.GetOrderCount() }.");
            //we will print here number of Incidents and Orders as per the Priority (P1, P2, P3....etc.)
            Console.WriteLine($"Number of Ticket/Incident with priority1 (P1) : { Incident.GetP1Count() }.");
            Console.WriteLine($"Number of Ticket/Incident with priority2 (P2) : { Incident.GetP2Count() }.");
            Console.WriteLine($"Number of Ticket/Incident with priority3 (P3) : { Incident.GetP3Count() }.");
            Console.WriteLine($"Number of Ticket/Incident with priority5 (P5) : { Incident.GetP5Count() }.");
            Console.WriteLine($"Number of Ticket/Order with priority5 (P5) : { Order.GetP5Count() }.");

            //here we will print all customer data (contact Details).
            foreach (Employee employee in employees)
            {
                Console.WriteLine(
                    $"ID: {employee.getId()} "
                    + "\n"
                    + $"Full Name: {employee.getLastName()}, {employee.getFirstName()} "
                    + "\n"
                    + $"Phone Number: {employee.getPhoneNumber()}"
                    + "\n"
                    + $"Email: {employee.getEmail()}");
                Console.WriteLine();
            }
            //here we will print out all the Incident's details that we need.
            foreach (Incident incidents in incidentList)
            {
                Console.WriteLine($"You have: {incidents.getHardwareIssue()} issue - \t  {incidents.getSoftwareIssue()} issue" +
                                  $"issue - \t {incidents.getNetworkIssue()} issue - \t {incidents.getNotListedIssue()} issue");
                Console.WriteLine();
                Console.WriteLine("We will check your issue, and we will contact you as per Ticket priority");
                Console.WriteLine();
                Console.WriteLine($"Your Justification Email was: {incidents.getwriteEmail()}");
            }
            Console.WriteLine();
            //here we will print out all the Order's details that we need.
            foreach (Order orders in orderList)
            {

                Console.WriteLine($"type of Devices that you have ordered {orders.getDeviseType()}" +
                    "\n" + $"with this Justification:  {orders.getDeviceTypeJustification()}");
                Console.WriteLine();
                Console.WriteLine($"type of Accessories you have ordered { orders.getAccessoriesType() }"
                + "\n" + $"with this Justification: { orders.getAccessoriesTypeJustification()}");
                Console.WriteLine();
                Console.WriteLine("Once your order has been approved, you will recieve your devise");



            }
            Console.WriteLine();

                //rendom numbers for tickets.

                UseStatic();
        }

        static Random _random = new Random();
        static void UseStatic()
        {
            //When this method is called many times, it still has good Randoms.
            int result = _random.Next();
            // If this method declared a local Random, it would repeat itself.
            Console.WriteLine($"your Ticket Number is: " +"T"+ result);
        }

    }
}
