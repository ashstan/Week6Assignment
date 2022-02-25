using System;
using System.IO;

namespace Week6Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "systemtickets.csv";
            string addTicket;

            string ticketID;
            string summary;
            string status;
            string priority;
            string submitter;
            string assigned;
            string watching;
            
            Console.WriteLine("Ticketing System Application\n");

            Console.WriteLine("Would you like to add a ticket? (y/n)");
            addTicket = Console.ReadLine().ToLower();

            // if (addTicket == "y") {
            //     if (File.Exists(file))
            //     {
                    //creating file
                    StreamWriter sw = new StreamWriter(file);
                    do {
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

                    } while(addTicket == "y");

                    sw.Close();

            //     }
            // }

        }
    }
}
