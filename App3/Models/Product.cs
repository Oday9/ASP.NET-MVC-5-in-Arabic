using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App3.Models
{
 
    public class Products
    {
        public List<Product> GetProducts()
        {
            var products = new List<Product>();

            products.Add(new Product { Name = "P 1",  Price = 200, Type = Type.Affordable, InStock = false });
            products.Add(new Product { Name = "P 2",  Price = 50, Type = Type.ShoppingResort, InStock = true });
            products.Add(new Product { Name = "P 3", Price = 10, Type = Type.Special, InStock = true });

            return products;
        }
    }
    [DisplayName("المنتجات")]
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("الاسم")]
        public string Name { get; set; }
        public int YearProduction { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public Availability Availability { get; set; }

        public string Category { get; set; }

        public Type Type { get; set; }
        public string Description { get; set; }
    }

    public enum Type
    {
        Affordable,
        ShoppingResort,
        Special,
    }

    public enum Availability
    {
        Pickup,
        Delivery,
        Reseller
    }
}