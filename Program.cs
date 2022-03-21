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

            //string file = "systemtickets.csv"; -- old program
            string bugFile = "Bug.csv";
            string enhancementsFile = "Enhancements.csv";
            string taskFile = "Task.csv";

            string addTicket;
            string searchTickets;

            List<Ticket> Tickets = new List<Ticket>();
            StreamReader sr = new StreamReader("Bug.csv");
            while (!sr.EndOfStream){
                string line = sr.ReadLine();
                string[] bugDetails = line.Split(',');

                Bug bug = new Bug(UInt16.Parse(bugDetails[0]));
                bug.summary = bugDetails[1];
                bug.status = bugDetails[2];
                bug.priority = bugDetails[3];
                bug.submitter = bugDetails[4];
                bug.assigned = bugDetails[5];
                bug.watching = bugDetails[6];
                bug.severity = bugDetails[7];                                                                

                Tickets.Add(bug);
            }
            sr.Close();
            sr = new StreamReader("Task.csv");
            while (!sr.EndOfStream){
                string line = sr.ReadLine();
                string[] taskDetails = line.Split(',');

                Task task = new Task(UInt16.Parse(taskDetails[0]));
                task.summary = taskDetails[1];
                task.status = taskDetails[2];
                task.priority = taskDetails[3];
                task.submitter = taskDetails[4];
                task.assigned = taskDetails[5];
                task.watching = taskDetails[6];
                task.projectName = taskDetails[7];                                                                
                task.dueDate = taskDetails[7];                                                                

                Tickets.Add(task);
            }
            sr.Close();
            sr = new StreamReader("Enhancements.csv");
            while (!sr.EndOfStream){
                string line = sr.ReadLine();
                string[] enhancementsDetails = line.Split(',');

                Enhancements enhancements = new Enhancements(UInt16.Parse(enhancementsDetails[0]));
                enhancements.summary = enhancementsDetails[1];
                enhancements.status = enhancementsDetails[2];
                enhancements.priority = enhancementsDetails[3];
                enhancements.submitter = enhancementsDetails[4];
                enhancements.assigned = enhancementsDetails[5];
                enhancements.watching = enhancementsDetails[6];
                enhancements.software = enhancementsDetails[7];                                                                
                enhancements.cost = enhancementsDetails[7];
                enhancements.reason = enhancementsDetails[8];                                                                
                enhancements.estimate = enhancementsDetails[9];                                                                
                                                                
                Tickets.Add(enhancements);
            }
            sr.Close();

            Console.WriteLine("Ticketing System Application\n");

            Console.WriteLine("Would you like to add a ticket? (y/n)");
            addTicket = Console.ReadLine().ToLower();
            if (addTicket == "y")
            {
                do
                {
                    Console.WriteLine("What type of ticket would you like to add?");
                    Console.WriteLine("Enter 1 for bug/defect ticket, 2 for enhancement ticket, or 3 for task ticket: ");
                    string ticketType = Console.ReadLine();

                    if (ticketType == "1")
                    {
                        //bug ticket
                        sr = new StreamReader(bugFile);
                        string last_line = File.ReadLines(bugFile).LastOrDefault();
                        int ticketIDNumber = 1;
                        if (!string.IsNullOrEmpty(last_line))
                        {
                            string ticketIDstring = File.ReadLines(bugFile).Last().Split(',')[0];
                            if (!int.TryParse(ticketIDstring, out ticketIDNumber))
                            {
                                Console.WriteLine("Error");
                            }
                            else
                            {
                                ticketIDNumber += 1;
                                Console.WriteLine(ticketIDNumber);
                            }
                        }
                        sr.Close();

                        Bug bug = new Bug(ticketIDNumber);
                        bug.getTicketInfo();
                        bug.writeTicketToFile("Bug.csv");

                    }
                    else if (ticketType == "2")
                    {
                        //enhancement ticket
                        sr = new StreamReader(enhancementsFile);
                        string last_line = File.ReadLines(enhancementsFile).LastOrDefault();
                        int ticketIDNumber = 1;
                        if (!string.IsNullOrEmpty(last_line))
                        {
                            string ticketIDstring = File.ReadLines(enhancementsFile).Last().Split(',')[0];
                            if (!int.TryParse(ticketIDstring, out ticketIDNumber))
                            {
                                Console.WriteLine("Error");
                            }
                            else
                            {
                                ticketIDNumber += 1;
                                Console.WriteLine(ticketIDNumber);
                            }
                        }
                        sr.Close();

                        Enhancements enhancements = new Enhancements(ticketIDNumber);
                        enhancements.getTicketInfo();
                        enhancements.writeTicketToFile("Enhancements.csv");
                    }
                    else if (ticketType == "3")
                    {
                        //task ticket
                        sr = new StreamReader(taskFile);
                        string last_line = File.ReadLines(taskFile).LastOrDefault();
                        int ticketIDNumber = 1;
                        if (!string.IsNullOrEmpty(last_line))
                        {
                            string ticketIDstring = File.ReadLines(taskFile).Last().Split(',')[0];
                            if (!int.TryParse(ticketIDstring, out ticketIDNumber))
                            {
                                Console.WriteLine("Error");
                            }
                            else
                            {
                                ticketIDNumber += 1;
                                Console.WriteLine(ticketIDNumber);
                            }
                        }
                        sr.Close();

                        Task task = new Task(ticketIDNumber);
                        task.getTicketInfo();
                        task.writeTicketToFile("Task.csv");
                    }
                    Console.WriteLine("Would you like to add a ticket? (y/n)");
                    addTicket = Console.ReadLine();
                } while (addTicket == "y");
            }



            Console.WriteLine("Would you like to search tickets (y/n)? ");
            searchTickets = Console.ReadLine().ToLower();
            if(searchTickets == "y"){
                //??first enter options to search based on status, priority, submitter?
                
                //then enter keyword for search for each ticket type?
                Console.WriteLine("Enter search keyword(s): ");
                var ticketSearch = Console.ReadLine();

                var tickets = Tickets.Where(m => m.status.Contains(ticketSearch, StringComparison.OrdinalIgnoreCase));
                Console.WriteLine(tickets.Count());
            }

        }

    }
}
