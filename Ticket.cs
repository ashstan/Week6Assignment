using System;
using System.Collections.Generic;

namespace Week6Assignment
{
    public class Ticket
    {
            public int ticketID { get; set; }
            public string summary { get; set; }
            public string status { get; set; }
            public string priority { get; set; }
            public string submitter { get; set; }
            public string assigned { get; set; }
            public string watching { get; set; }

            public Ticket(int ticketID, string summary, string status, string priority, string submitter, string assigned, string watching)
            {
                ticketID = this.ticketID;
                summary = this.summary;
                status = this.status;
                priority = this.priority;
                submitter = this.submitter;
                assigned = this.assigned;
                watching = this.watching;
            }
    }
}