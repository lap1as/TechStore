using System;
using System.Collections.Generic;
using System.Linq;
using TechStore.Models;
using TechStore;
using Microsoft.Data.SqlClient;

public class DatabaseService
{
    private readonly TechStoreContext _context;
    string connectionString = "Data Source=LAPLAS;Initial Catalog=TechStore;Integrated Security=True;User Id=techstore;Password=techstore;Encrypt=False";
    public DatabaseService()
    {
        _context = new TechStoreContext();
    }

    // Метод для отримання списку товарів
    public List<Product> GetProducts()
    {
        return _context.Products.ToList();
    }

    // Метод для отримання списку замовлень
    public List<Order> GetOrders()
    {
        return _context.Orders.ToList();
    }

    // Метод для отримання списку користувачів
    public List<User> GetUsers()
    {
        return _context.Users.ToList();
    }
    public void AddProduct(Product product)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Products (Name, Description, Price, StockQuantity) " +
                               "VALUES (@Name, @Description, @Price, @StockQuantity)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                command.ExecuteNonQuery();
                Console.WriteLine("Product added successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding product: {ex.Message}");
        }
    }

    public void AddUser(User user)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (Username, Password, Email) " +
                               "VALUES (@Username, @Password, @Email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.ExecuteNonQuery();
                Console.WriteLine("User added successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding user: {ex.Message}");
        }
    }
    
    public void UpdateProduct(Product product)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Products SET Name = @Name, Description = @Description, " +
                               "Price = @Price, StockQuantity = @StockQuantity WHERE ProductID = @ProductID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
                command.Parameters.AddWithValue("@ProductID", product.ProductID);
                command.ExecuteNonQuery();
                Console.WriteLine("Product updated successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating product: {ex.Message}");
        }
    }
    public void ExecuteQuery(string query)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Query executed successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error executing query: {ex.Message}");
        }
    }

    // Інші методи для додавання, редагування та видалення даних можуть бути додані згідно з потребами вашого додатку
}
