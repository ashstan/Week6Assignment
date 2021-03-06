using System;
using System.IO;
using System.Collections.Generic;

namespace Week6Assignment
{
    public class Task : Ticket
    {
        public string projectName {get ; set; }
        public string dueDate {get ; set; }
        public Task(int id)
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

            Console.WriteLine("What is the name of the project?: ");
            this.projectName = Console.ReadLine();

            Console.WriteLine("Enter task due date: ");
            this.dueDate = Console.ReadLine();
        }

        public void writeTicketToFile(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName, true);
            sw.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", ticketID, summary, status, priority, submitter, assigned, watching, projectName, dueDate);
            sw.Close();
        }
    }
}