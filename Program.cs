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
            int ID = int.Parse(Console.ReadLine());

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


            //create a list for Tickets 
            List<Ticket> tickets = new List<Ticket>();
            //create a list for Incidents
            List<Incident> incidentList = new List<Incident>();
            //create a list for Orders
            List<Order> orderList = new List<Order>();

            int response;
            //keep looping until the customer choose end.
            do
            {
                Console.WriteLine("1 - Incident");
                Console.WriteLine("2 - Order");
                Console.WriteLine("0 - End");
                response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    // the customer creating new Incident.
                    case 1:

                        //here the customer will choose what kind of issues he would like to escalated to IT Department.
                        Console.Write("please Type your Issue (Hardware - Software -Network - Not Listed) : ");
                        string Issue = Console.ReadLine();
                        //here the customers can give more details about their issues.
                        Console.WriteLine("Explain more as possible as you can about your issue : ");
                        string writeEmail = Console.ReadLine();

                        //create new Incident.
                        Incident newIncident = new Incident(Issue, writeEmail);
                        incidentList.Add(newIncident);

                        break;

                    // the customer creating new Order.
                    case 2:

                        //here the custumers will choose what they would like to order.
                        Console.WriteLine("Please choose then type the Device/Accessory that you want to order " + "\n" +
                                          "(Laptop - Desktop - IP Phone - Monitor - Keyboard - Mouse): ");
                        string deviceType = Console.ReadLine();
                        //if the customers want to order many devices/accessories so they can mention in the Justification.
                        //if the customer want to order devices/accessories on behalf of another customer also they can use the Justification .
                        Console.WriteLine("write Justification: ");
                        string deviceTypeJustification = Console.ReadLine();

                        //create new Order.
                        Order newOrder = new Order(deviceType, deviceTypeJustification);
                        orderList.Add(newOrder);

                        // here asking the customers to put the number of devices or accessories those they want to order.
                        foreach (Order orders in orderList)
                        {

                            Console.Write($"number of Devices/ Accessories ({orders.getDeviseType()})s that you want to order: ");

                            while (!orders.deviceRequirement(int.Parse(Console.ReadLine())))
                            {
                                Console.WriteLine("Invalid!"); //max number of devices to be order is 1.
                                Console.Write($"Maximum numbers of Devices/ Accessories ({ orders.getDeviseType() }) are 1: ");
                            }

                        }

                        break;

                    default:
                        break;
                }
                Console.WriteLine();
            } while (response > 0);


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
                Console.WriteLine($"You have: {incidents.getIssue()} issue \t");
                Console.WriteLine();
                Console.WriteLine($"Your Justification Email is: {incidents.getwriteEmail()}");
                Console.WriteLine();
                Console.WriteLine("We will check your issue, and we will contact you as per your Ticket priority");
                Console.WriteLine();
                //rendom numbers (Incident Number) using Ticket Class.
                Console.WriteLine($"Your Incident Number is " + "TO-" + Ticket.getTiketNumber());
                Console.WriteLine();
            }

            //here we will print out all the Order's details that we need.
            foreach (Order orders in orderList)
            {

                Console.WriteLine($"type of Devices/Accessories that you have ordered : {orders.getDeviseType()}" +
                    "\n" + $"with this Justification:  {orders.getDeviceTypeJustification()}");
                Console.WriteLine();

                Console.WriteLine("Once your order has been approved, you will recieve your device");
                Console.WriteLine();

                //rendom numbers (Order Number) using Ticket Class.
                Console.WriteLine($"Your Order Number is " + "TO-" + Ticket.getTiketNumber());
                Console.WriteLine();
            }

        }
    }
}
