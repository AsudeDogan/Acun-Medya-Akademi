using ProductApi.Models;
using Microsoft.Data.Sqlite;

namespace ProductApi.Data
{
    public class ProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");

            // Ensure DB and table exist
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var tableCommand = connection.CreateCommand();
            tableCommand.CommandText = @"
                CREATE TABLE IF NOT EXISTS Products (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Price REAL NOT NULL,
                    Stock INTEGER NOT NULL
                );";
            tableCommand.ExecuteNonQuery();
        }

        public List<Product> GetAll()
        {
            var products = new List<Product>();
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Products";

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                products.Add(new Product
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetDecimal(2),
                    Stock = reader.GetInt32(3)
                });
            }

            return products;
        }

        public Product GetById(int id)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Products WHERE Id = $id";
            command.Parameters.AddWithValue("$id", id);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Product
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Price = reader.GetDecimal(2),
                    Stock = reader.GetInt32(3)
                };
            }

            return null;
        }

        public void Create(Product product)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Products (Name, Price, Stock) VALUES ($name, $price, $stock)";
            command.Parameters.AddWithValue("$name", product.Name);
            command.Parameters.AddWithValue("$price", product.Price);
            command.Parameters.AddWithValue("$stock", product.Stock);
            command.ExecuteNonQuery();
        }

        public void Update(Product product)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "UPDATE Products SET Name = $name, Price = $price, Stock = $stock WHERE Id = $id";
            command.Parameters.AddWithValue("$name", product.Name);
            command.Parameters.AddWithValue("$price", product.Price);
            command.Parameters.AddWithValue("$stock", product.Stock);
            command.Parameters.AddWithValue("$id", product.Id);
            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Products WHERE Id = $id";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }
    }
}
