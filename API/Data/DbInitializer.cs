using API.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Acer Aspire 5",
                    Description = "Vivamus varius magna ante, nec semper ipsum porttitor quis. Maecenas neque mi, pretium ut gravida tristique, malesuada vitae dolor. Aliquam quis lacus a tellus interdum consequat at at eros. Aliquam sed ipsum justo. Etiam vitae maximus turpis.",
                    Price = 3000,
                    PictureUrl = "/images/products/Acer Aspire 5.jpg",
                    Brand = "Acer",
                    Type = "Laptops",
                    QuantityInStock = 4
                },
                new Product
                {
                    Name = "BENGOO G9000",
                    Description = "Vivamus varius magna ante, nec semper ipsum porttitor quis. Maecenas neque mi, pretium ut gravida tristique, malesuada vitae dolor. Aliquam quis lacus a tellus interdum consequat at at eros. Aliquam sed ipsum justo. Etiam vitae maximus turpis.",
                    Price = 15000,
                    PictureUrl = "/images/products/BENGOO G9000.jpg",
                    Brand = "Bengoo",
                    Type = "Headphones",
                    QuantityInStock = 6
                },
                new Product
                {
                    Name = "YSSOA FNGAMECHAIR01",
                    Description = "Vivamus varius magna ante, nec semper ipsum porttitor quis. Maecenas neque mi, pretium ut gravida tristique, malesuada vitae dolor. Aliquam quis lacus a tellus interdum consequat at at eros. Aliquam sed ipsum justo. Etiam vitae maximus turpis.",
                    Price = 2500,
                    PictureUrl = "/images/products/YSSOA FNGAMECHAIR01.jpg",
                    Brand = "YSSOA",
                    Type = "Chair",
                    QuantityInStock = 6
                },
                new Product
                {
                    Name = "BENGOO G9900",
                    Description = "Vivamus varius magna ante, nec semper ipsum porttitor quis. Maecenas neque mi, pretium ut gravida tristique, malesuada vitae dolor. Aliquam quis lacus a tellus interdum consequat at at eros. Aliquam sed ipsum justo. Etiam vitae maximus turpis.",
                    Price = 1200,
                    PictureUrl = "/images/products/BENGOO G9900.jpg",
                    Brand = "Bengoo",
                    Type = "Headphones",
                    QuantityInStock = 3
                },
                new Product
                {
                    Name = "Razer Viper V2 Pro",
                    Description = "Vivamus varius magna ante, nec semper ipsum porttitor quis. Maecenas neque mi, pretium ut gravida tristique, malesuada vitae dolor. Aliquam quis lacus a tellus interdum consequat at at eros. Aliquam sed ipsum justo. Etiam vitae maximus turpis.",
                    Price = 900,
                    PictureUrl = "/images/products/Razer Viper V2 Pro.jpg",
                    Brand = "Razer",
                    Type = "Mouse",
                    QuantityInStock = 9
                },
                new Product
                {
                    Name = "Xbox Core Wireless Controller",
                    Description = "Vivamus varius magna ante, nec semper ipsum porttitor quis. Maecenas neque mi, pretium ut gravida tristique, malesuada vitae dolor. Aliquam quis lacus a tellus interdum consequat at at eros. Aliquam sed ipsum justo. Etiam vitae maximus turpis.",
                    Price = 1000,
                    PictureUrl = "/images/products/Xbox Core Wireless Controller.jpg",
                    Brand = "Xbox",
                    Type = "Joystick",
                    QuantityInStock = 10
                },
                new Product
                {
                    Name = "HP Premium",
                    Description = "Vivamus varius magna ante, nec semper ipsum porttitor quis. Maecenas neque mi, pretium ut gravida tristique, malesuada vitae dolor. Aliquam quis lacus a tellus interdum consequat at at eros. Aliquam sed ipsum justo. Etiam vitae maximus turpis.",
                    Price = 2000,
                    PictureUrl = "/images/products/HP Premium.jpg",
                    Brand = "HP",
                    Type = "Laptops",
                    QuantityInStock = 2
                },
                new Product
                {
                    Name = "Lenovo IdeaPad 3",
                    Description = "Vivamus varius magna ante, nec semper ipsum porttitor quis. Maecenas neque mi, pretium ut gravida tristique, malesuada vitae dolor. Aliquam quis lacus a tellus interdum consequat at at eros. Aliquam sed ipsum justo. Etiam vitae maximus turpis.",
                    Price = 12000,
                    PictureUrl = "/images/products/Lenovo IdeaPad 3.jpg",
                    Brand = "Lenovo",
                    Type = "Laptops",
                    QuantityInStock = 20
                }
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}
