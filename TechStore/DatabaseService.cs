using System;
using System.Collections.Generic;
using System.Linq;
using TechStore.Models;
using TechStore;

public class DatabaseService
{
    private readonly TechStoreContext _context;

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

    // Інші методи для додавання, редагування та видалення даних можуть бути додані згідно з потребами вашого додатку
}
