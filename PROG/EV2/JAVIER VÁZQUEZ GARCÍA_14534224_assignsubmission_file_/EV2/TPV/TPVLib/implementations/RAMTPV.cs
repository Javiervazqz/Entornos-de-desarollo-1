namespace TPVLib
{
    internal class RAMTPV : ITPV
    {
        List<Product> _products = new List<Product>();
        List<Ticket> _tickets = new List<Ticket>();
        public int ProductCount => _products.Count;
        public int CurrentIdCount = 1;
        private IDatabase _database;
        public int? AddProduct(Product product)
        {
            if (product == null)
                return -1;
            _products.Add(product);
            return product.id;
        }

        public Product? GetProduct(int id)
        {
            if (id == null)
                return null;
            for (int i = 0; i < ProductCount; i++)
            {
                if (id == _products[i].id)
                    return _products[i].Clone();
            }
            throw new Exception("Product wasn't found");
        }

        public void RemoveProductWithId(int id)
        {
            if (id == null || id <= 0)
                throw new Exception("Product wasn't found");
            _products.Remove(_products[id]);
            
        }

        public void UpdateProductWithId(int id, Product product)
        {
            for (int i = 0; i < ProductCount; i++)
            {
                if (_products[i].id == id)
                {
                    _products[i].Update(product);
                    return;
                }
            }
        }

        public int AddTicket(Ticket ticket)
        {
            try
            {
                _database.BeginTransaction();
                int id = _database.AddTicket(ticket.header);
                foreach(var line in ticket.body.Lines)
                {
                    _database.AddTicketLine(id, line);
                }
                _database.Commit();
                return id;
            }
            catch (Exception ex)
            {
                _database.Rollback();
                return -1;
            }
        }

        public void RemoveTicket(Ticket ticket)
        {
            if (ticket == null)
                return;
            for (int i = 0; i < _tickets.Count; i++)
            {
                if (ticket == _tickets[i])
                { 
                    _tickets.Remove(ticket);
                    return;
                }
            }
        }
    }
}