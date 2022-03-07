using System;
using System.IO;
using System.Collections.Generic;

namespace Week6Assignment
{
    public class Bug : Ticket
    {
        public string severity {get ; set; }

        public Bug(int id)
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

            Console.WriteLine("Enter ticket severity (1 [low] - 5 [high]): ");
            this.severity = Console.ReadLine();
        }

        public void writeTicketToFile(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", ticketID, summary, status, priority, submitter, assigned, watching, severity);
            sw.Close();
        }
    }
}