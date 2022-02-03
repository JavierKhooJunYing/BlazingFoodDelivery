﻿// <auto-generated />
using BlazingFoodDelivery.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazingFoodDelivery.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220203104826_MenuItemSeeding")]
    partial class MenuItemSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazingFoodDelivery.Shared.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Turkey bacon and sweet pineapples topped with 100% imported Italian mozzarella cheese.",
                            ImageUrl = "images/aloha.jpg",
                            Price = 10.90m,
                            Title = "Aloha"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Beef pepperoni topped with 100% imported Italian mozzarella cheese.",
                            ImageUrl = "images/pepperoni.jpg",
                            Price = 10.90m,
                            Title = "Pepperoni"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Grilled oregano chicken strips loaded with roasted red peppers, parmesa and 100% imported Italian mozzarella cheese.",
                            ImageUrl = "images/sanRemo.jpg",
                            Price = 10.90m,
                            Title = "San Remo"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Home-made teriyaki sauce, oregano chicken, olive oil, white onions with 100% imported Italian mozzarella cheese.",
                            ImageUrl = "images/teriyakiChicken.jpg",
                            Price = 10.90m,
                            Title = "Teriyaki Chicken"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Tomatoes, fresh basil leaves, olive oil, topped with 100% imported Italian mozzarella cheese.",
                            ImageUrl = "images/margherita.jpg",
                            Price = 10.90m,
                            Title = "Margherita"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Made with freshly handmade dough, topped with our handmade pizza sauce and secret spices and completed with 100% imported Italian mozzarella cheese.",
                            ImageUrl = "images/cheese.jpg",
                            Price = 10.90m,
                            Title = "Cheese"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Delicious and refreshing since 1886.",
                            ImageUrl = "images/cocaCola.png",
                            Price = 2.90m,
                            Title = "Coca-Cola"
                        },
                        new
                        {
                            Id = 8,
                            Description = "100% real brewed from selected premium tea leaves, POKKA Jasmine Green Tea delivers the superior taste you have come to love. Its blend of aromatic jasmine with the highest quality green tea promises a refreshing enjoyment with natural antioxidant goodness.",
                            ImageUrl = "images/greenTea.jpg",
                            Price = 2.90m,
                            Title = "Green Tea"
                        },
                        new
                        {
                            Id = 9,
                            Description = "A full-bodied infusion of black tea with rich cocoa undertones.",
                            ImageUrl = "images/tea.jpg",
                            Price = 2.90m,
                            Title = "Hot Tea"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Enjoy our rich, flavorful brewed coffees any time of the day. Easy-drinking on its own and delicious with milk and sugar.",
                            ImageUrl = "images/coffee.jpg",
                            Price = 2.90m,
                            Title = "Hot Coffee"
                        },
                        new
                        {
                            Id = 11,
                            Description = "There’s no question chocolate and coffee are flavors that meant for each other. Both are rich and full of depth. Where one is creamy, the other is roasty. They complement each other perfectly. And when they come together under a fluffy cloud of sweetened whipped cream, you’ll wish their union would last forever.",
                            ImageUrl = "images/mocha.jpg",
                            Price = 5.90m,
                            Title = "Caffè Mocha"
                        },
                        new
                        {
                            Id = 12,
                            Description = "DASANI® combines the process of reverse osmosis filtration with a proprietary blend of minerals to create fresh, clean, and premium tasting water that is pure and delicious.",
                            ImageUrl = "images/dasani.jpg",
                            Price = 1.90m,
                            Title = "Dasani Water (600ML)"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Rich and moist with oozing Belgian chocolate lava inside.",
                            ImageUrl = "images/chocLavaCake.jpg",
                            Price = 8.90m,
                            Title = "Hot Chocolate Lava Cake"
                        },
                        new
                        {
                            Id = 14,
                            Description = "It is made of ladyfingers dipped in coffee, layered with a whipped mixture of eggs, sugar, and mascarpone cheese, flavoured with cocoa.",
                            ImageUrl = "images/tiramisu.jpg",
                            Price = 8.90m,
                            Title = "Tiramisu"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Our delicious take on the lemon meringue pie – A sweet, tangy tango of lemon curd, cheesecake, and a beautifully torched meringue.",
                            ImageUrl = "images/lemonMeringue.jpg",
                            Price = 8.90m,
                            Title = "Lemon Meringue Cheesecake"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
