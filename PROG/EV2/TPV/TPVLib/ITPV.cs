namespace TPVLib
{
    public interface ITPV
    {
        static ITPV CreateNewTPV()
        {
            return new RAMTPV();
        }
        long? AddProduct(Product product);
        void RemoveProductWithId(long? id);
        void RemoveProduct(Product product)
        {
            if (product != null)
                RemoveProductWithId(product.id);
        }
        Product? GetProduct(long? id);
        void UpdateProductWithId(long id, Product product);
    }
}
