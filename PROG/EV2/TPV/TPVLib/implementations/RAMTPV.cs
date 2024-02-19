namespace TPVLib
{
    internal class RAMTPV : ITPV
    {
        List<Product> _products = new List<Product>();
        List<Ticket> _tickets = new List<Ticket>();
        public int ProductCount => _products.Count;
        public int CurrentIdCount = 1;
        private IDatabase _database;
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

        public void RemoveProductWithId(long? id)
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
                    _products[i].Update(product);
                    return;
                }
            }
        }

        public long AddTicket(Ticket ticket)
        {
            try
            {
                _database.BeginTransaction();
                long id = _database.AddTicket(ticket.header);
                foreach(var line in ticket.body.Lines)
                {
                    _database.AddTicketLine(id, line);
                }
                _database.Commit();
                return id;
            }
            catch(Exception ex)
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