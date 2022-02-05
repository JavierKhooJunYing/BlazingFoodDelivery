using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingFoodDelivery.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingFoodDelivery.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Pizzas",
                    Url = "pizzas"
                },
                new Category
                {
                    Id = 2,
                    Name = "Beverages",
                    Url = "beverages"
                },
                new Category
                {
                    Id = 3,
                    Name = "Desserts",
                    Url = "desserts"
                });

            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem
                {
                    Id = 1,
                    Title = "Aloha",
                    Description = "Turkey bacon and sweet pineapples topped with 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/aloha.jpg",
                    Price = 10.90M,
                    Featured = true,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 2,
                    Title = "Pepperoni",
                    Description = "Beef pepperoni topped with 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/pepperoni.jpg",
                    Price = 10.90M,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 3,
                    Title = "San Remo",
                    Description = "Grilled oregano chicken strips loaded with roasted red peppers, parmesa and 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/sanRemo.jpg",
                    Price = 10.90M,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 4,
                    Title = "Teriyaki Chicken",
                    Description = "Home-made teriyaki sauce, oregano chicken, olive oil, white onions with 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/teriyakiChicken.jpg",
                    Price = 10.90M,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 5,
                    Title = "Margherita",
                    Description = "Tomatoes, fresh basil leaves, olive oil, topped with 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/margherita.jpg",
                    Price = 10.90M,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 6,
                    Title = "Cheese",
                    Description = "Made with freshly handmade dough, topped with our handmade pizza sauce and secret spices and completed with 100% imported Italian mozzarella cheese.",
                    ImageUrl = "images/cheese.jpg",
                    Price = 10.90M,
                    CategoryId = 1
                },
                new MenuItem
                {
                    Id = 7,
                    Title = "Coca-Cola",
                    Description = "Delicious and refreshing since 1886.",
                    ImageUrl = "images/cocaCola.png",
                    Price = 2.90M,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 8,
                    Title = "Green Tea",
                    Description = "100% real brewed from selected premium tea leaves, POKKA Jasmine Green Tea delivers the superior taste you have come to love. Its blend of aromatic jasmine with the highest quality green tea promises a refreshing enjoyment with natural antioxidant goodness.",
                    ImageUrl = "images/greenTea.jpg",
                    Price = 2.90M,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 9,
                    Title = "Hot Tea",
                    Description = "A full-bodied infusion of black tea with rich cocoa undertones.",
                    ImageUrl = "images/tea.jpg",
                    Price = 2.90M,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 10,
                    Title = "Hot Coffee",
                    Description = "Enjoy our rich, flavorful brewed coffees any time of the day. Easy-drinking on its own and delicious with milk and sugar.",
                    ImageUrl = "images/coffee.jpg",
                    Price = 2.90M,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 11,
                    Title = "Caffè Mocha",
                    Description = "There’s no question chocolate and coffee are flavors that meant for each other. Both are rich and full of depth. Where one is creamy, the other is roasty. They complement each other perfectly. And when they come together under a fluffy cloud of sweetened whipped cream, you’ll wish their union would last forever.",
                    ImageUrl = "images/mocha.jpg",
                    Price = 5.90M,
                    Featured = true,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 12,
                    Title = "Dasani Water (600ML)",
                    Description = "DASANI® combines the process of reverse osmosis filtration with a proprietary blend of minerals to create fresh, clean, and premium tasting water that is pure and delicious.",
                    ImageUrl = "images/dasani.jpg",
                    Price = 1.90M,
                    CategoryId = 2
                },
                new MenuItem
                {
                    Id = 13,
                    Title = "Hot Chocolate Lava Cake",
                    Description = "Rich and moist with oozing Belgian chocolate lava inside.",
                    ImageUrl = "images/chocLavaCake.jpg",
                    Price = 8.90M,
                    Featured = true,
                    CategoryId = 3
                },
                new MenuItem
                {
                    Id = 14,
                    Title = "Tiramisu",
                    Description = "It is made of ladyfingers dipped in coffee, layered with a whipped mixture of eggs, sugar, and mascarpone cheese, flavoured with cocoa.",
                    ImageUrl = "images/tiramisu.jpg",
                    Price = 8.90M,
                    CategoryId = 3
                },
                new MenuItem
                {
                    Id = 15,
                    Title = "Lemon Meringue Cheesecake",
                    Description = "Our delicious take on the lemon meringue pie – A sweet, tangy tango of lemon curd, cheesecake, and a beautifully torched meringue.",
                    ImageUrl = "images/lemonMeringue.jpg",
                    Price = 8.90M,
                    CategoryId = 3
                });
        }

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
