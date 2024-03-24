using System;

namespace TPVLib
{
    // Javi: Mejor pon esto en el archivo de Ticket
    public class TicketHeader
    {
        public string barcode;
        public long id;
        public DateTime date { get; set; }
    }
}
