using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server = (localdb)\mssqllocaldb;initial catalog = ETrade;integrated security = true");

        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)",_connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();

        }


        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand commandUpdate = new SqlCommand(
                "Update Products set Name=@name, UnitPrice =@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);
            commandUpdate.Parameters.AddWithValue("@name", product.Name);
            commandUpdate.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            commandUpdate.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            commandUpdate.Parameters.AddWithValue("@id", product.Id);
            commandUpdate.ExecuteNonQuery();

            _connection.Close();

        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand commandDelete = new SqlCommand(
                "Delete from Products where Id=@id", _connection);
            commandDelete.Parameters.AddWithValue("@id",id);
            commandDelete.ExecuteNonQuery();

            _connection.Close();

        }
        //public DataTable GetAll2()
        //{
        //    SqlConnection connection = new SqlConnection(@"server = (localdb)\mssqllocaldb;initial catalog = ETrade;integrated security = true");
        //    if (connection.State == ConnectionState.Closed)
        //    {
        //        connection.Open();
        //    }

        //    SqlCommand command = new SqlCommand("Select * from Products",connection);

        //    SqlDataReader reader =  command.ExecuteReader();

        //    DataTable dataTable = new DataTable();
        //    dataTable.Load(reader);
        //    reader.Close();
        //    connection.Close();
        //    return dataTable;
        //}
    }
}
