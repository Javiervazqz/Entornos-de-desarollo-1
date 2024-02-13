namespace TPVLib
{
    internal class RAMTPV : ITPV
    {
        List<Product> _products = new List<Product>();
        public int ProductCount => _products.Count;
        public int CurrentIdCount = 1;
        public long? AddProduct(Product product)
        {
            if (product == null)
                return null;
            Product clone = product.Clone(product);
            clone.id = CurrentIdCount++;
            return CurrentIdCount;
        }

        public Product? GetProduct(long? id)
        {
            if (id == null)
                return null;
            for (int i = 0; i < ProductCount; i++)
            {
                if (id == _products[i].id)
                    return _products[i].Clone(_products[i]);
            }
            return null;
        }

        public void RemoveProductWithId(long id)
        {
            if (id == null)
                return;
            for (int i = 0; i < ProductCount; i++)
            {
                if (id == _products[i].id)
                {
                    _products.Remove(_products[i]);
                    return;
                }
            }
        }

        public void UpdateProductWithId(long id, Product product)
        {
            for (int i = 0; i < ProductCount; i++)
            {
                if (_products[i].id == id)
                {
                    _products[i].RewriteProduct(product);
                    return;
                }
            }
        }
    }
}