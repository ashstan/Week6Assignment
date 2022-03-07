using System;
using System.IO;
using System.Collections.Generic;

namespace Week6Assignment
{
    public class Enhancements : Ticket
    {
        public string software {get ; set; }
        public string cost {get ; set; }
        public string reason {get ; set; }
        public string estimate {get ; set; }
        public Enhancements(int id)
        {
            this.ticketID = id;
        }

        public void getTicketInfo()
        {
            Console.WriteLine("Enter ticket summary: ");
            this.summary = Console.ReadLine();

            Console.WriteLine("Enter ticket status: ");
            this.status = Console.ReadLine();

            Console.WriteLine("Enter ticket priority: ");
            this.priority = Console.ReadLine();

            Console.WriteLine("Enter ticket submitter: ");
            this.submitter = Console.ReadLine();

            Console.WriteLine("Who is assigned ticket?: ");
            this.assigned = Console.ReadLine();

            Console.WriteLine("Who is watching ticket?: ");
            this.watching = Console.ReadLine();

            Console.WriteLine("Enter name of software: ");
            this.software = Console.ReadLine();

            Console.WriteLine("Enter cost: ");
            this.cost = Console.ReadLine();

            Console.WriteLine("Enter reason for enhancement: ");
            this.reason = Console.ReadLine();

            Console.WriteLine("Enter estimate: ");
            this.estimate = Console.ReadLine();
        }

        public void writeTicketToFile(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", ticketID, summary, status, priority, submitter, assigned, watching, software, cost, reason, estimate);
            sw.Close();
        }
    }
}