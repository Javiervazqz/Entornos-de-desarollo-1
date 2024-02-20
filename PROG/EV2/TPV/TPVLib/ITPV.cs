namespace TPVLib
{
    public interface ITPV
    {
        static ITPV CreateNewTPV()
        {
            return new RAMTPV();
        }
        long? AddProduct(Product product);
        void RemoveProductWithId(int? id);
        void RemoveProduct(Product product)
        {
            if (product != null)
                RemoveProductWithId(product.id);
        }
        Product? GetProduct(int id);
        void UpdateProductWithId(long id, Product product);
        long AddTicket(Ticket ticket);
        void RemoveTicket(Ticket ticket);
    }
}
