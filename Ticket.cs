using System;
using System.Collections.Generic;

namespace Week6Assignment
{
    public abstract class Ticket
    {
            public int ticketID { get; set; }
            public string summary { get; set; }
            public string status { get; set; }
            public string priority { get; set; }
            public string submitter { get; set; }
            public string assigned { get; set; }
            public string watching { get; set; }

        

    }
}