using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Week6Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //commented out, ticket class will create these
            // string ticketID;
            // string summary;
            // string status;
            // string priority;
            // string submitter;
            // string assigned;
            // string watching;

            //create parallel lists of string details
            //lists are used since we do not know number of lines of data
            string file = "systemtickets.csv";
            string addTicket;

             List<string> ticketID = new List<string>();
             List<string> summary = new List<string>();
             List<string> status = new List<string>();
             List<string> priority = new List<string>();
             List<string> submitter = new List<string>();
             List<string> assigned = new List<string>();
             List<string> watching = new List<string>();


            Console.WriteLine("Ticketing System Application\n");

            Console.WriteLine("Would you like to add a ticket? (y/n)");
            addTicket = Console.ReadLine().ToLower();

            //split ticket ID # so it autogenerates
            StreamReader sr = new StreamReader(file);
            string ticketIDstring = File.ReadLines(file).Last().Split(',')[0];
            int ticketIDNumber;
            if (!int.TryParse(ticketIDstring, out ticketIDNumber)) {
                Console.WriteLine("Error");
            } else {
                ticketIDNumber += 1;

                Console.WriteLine(ticketIDNumber);
            }

           
 

            StreamWriter sw = new StreamWriter(file);
            do
            {               
                Console.WriteLine("Enter ticket ID: ");
                ticketID = Console.ReadLine();

                Console.WriteLine("Enter ticket summary: ");
                summary = Console.ReadLine();

                Console.WriteLine("Enter ticket status: ");
                status = Console.ReadLine();

                Console.WriteLine("Enter ticket priority: ");
                priority = Console.ReadLine();

                Console.WriteLine("Enter ticket submitter: ");
                submitter = Console.ReadLine();

                Console.WriteLine("Who is assigned ticket?: ");
                assigned = Console.ReadLine();

                Console.WriteLine("Who is watching ticket?: ");
                watching = Console.ReadLine();

                sw.WriteLine(ticketID + "," + summary + "," + status + "," + priority + "," + submitter + "," + assigned + "," + watching);

                Console.WriteLine("Would you like to add a ticket? (y/n)");
                addTicket = Console.ReadLine();

            } while (addTicket == "y");

            sw.Close();

        }
    }
}
