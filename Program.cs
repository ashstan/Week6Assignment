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


            Console.WriteLine("Ticketing System Application\n");

            Console.WriteLine("Would you like to add a ticket? (y/n)");
            addTicket = Console.ReadLine().ToLower();
            do
            {
                Console.WriteLine("What type of ticket would you like to add?");
                Console.WriteLine("Enter 1 for bug/defect ticket, 2 for enhancement ticket, or 3 for task ticket: ");
                string ticketType = Console.ReadLine();

                if (ticketType == "1")
                {
                    //bug ticket
                    StreamReader sr = new StreamReader(bugFile);
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
                    StreamReader sr = new StreamReader(enhancementsFile);
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
                    StreamReader sr = new StreamReader(taskFile);
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

    }
}
