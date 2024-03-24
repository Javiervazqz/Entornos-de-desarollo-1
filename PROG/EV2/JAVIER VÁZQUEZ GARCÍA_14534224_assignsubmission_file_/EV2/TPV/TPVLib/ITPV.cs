namespace TPVLib
{
    public interface ITPV
    {
        static ITPV CreateNewTPV()
        {
            return new RAMTPV();
        }
        int? AddProduct(Product product);
        void RemoveProductWithId(int id);
        void RemoveProduct(Product product)
        {
            if (product != null)
                RemoveProductWithId(product.id);
        }
        Product? GetProduct(int id);
        void UpdateProductWithId(int id, Product product);
        int AddTicket(Ticket ticket);
        void RemoveTicket(Ticket ticket);
    }
}
