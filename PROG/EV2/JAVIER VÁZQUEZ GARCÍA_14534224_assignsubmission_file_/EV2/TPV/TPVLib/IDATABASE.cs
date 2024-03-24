using System;

namespace TPVLib
{
    public interface IDatabase
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        long? AddProduct(Product product);
        void RemoveProductWithId(long? id);
        void RemoveProduct(Product product)
        {
            if (product != null)
                RemoveProductWithId(product.id);
        }
        Product? GetProduct(long? id);
        void UpdateProductWithId(long id, Product product);
        int AddTicket(TicketHeader ticket);
        void AddTicketHeader(TicketHeader ticket);
        void AddTicketLine(long id, TicketLine ticket);
        void AddTicketBody(TicketBody ticket);
    }
}