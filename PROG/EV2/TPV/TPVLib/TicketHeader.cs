using System;

namespace TPVLib
{
    public class TicketHeader
    {
        public string barcode;
        public long id;
        public DateTime date { get; set; }
    }
}
