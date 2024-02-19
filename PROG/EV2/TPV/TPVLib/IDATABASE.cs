using System;

namespace TPVLib
{
    public interface IDATABASE
    {
        void AddTicketHeader(long index);
        void AddTicketLine(long index);
        void AddTicketBody(long index);
    }
}
