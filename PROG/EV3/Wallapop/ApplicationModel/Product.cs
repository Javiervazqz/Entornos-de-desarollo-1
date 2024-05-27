using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ApplicationModel
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public double Price { get; set; }
    }
}