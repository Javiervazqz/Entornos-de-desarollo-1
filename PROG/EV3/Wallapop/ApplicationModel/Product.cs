using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ApplicationModel
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
    }

    //public class DataAccess
    //{
    //    private string connectionString = "Data Source=(WALLAPOP.dbo)\\MSSQLLocalDB;AttachDbFilename=|C:\\Users\\javvazgar\\Documents\\GitHub\\Entornos-de-desarollo-1\\PROG\\EV3\\Wallapop\\WALLAPOP.sql|\\MiBaseDeDatos.mdf;Integrated Security=True";

    //    public List<Product> LoadProducts()
    //    {
    //        List<Product> products = new List<Product>();

    //        using (var connection = new SqlConnection(connectionString))
    //        {
    //            string query = "SELECT Id, Name, Description, ImagePath FROM Productos";
    //            SqlCommand command = new SqlCommand(query, connection);

    //            connection.Open();
    //            SqlDataReader reader = command.ExecuteReader();

    //            while (reader.Read())
    //            {
    //                Product product = new Product
    //                {
    //                    Id = Convert.ToInt32(reader["Id"]),
    //                    Name = reader["Name"].ToString(),
    //                    Description = reader["Description"].ToString(),
    //                    ImagePath = reader["ImagePath"].ToString()
    //                    // Otras propiedades si es necesario
    //                };
    //                products.Add(product);
    //            }
    //        }

    //        return products;
    //    }
    //}
}