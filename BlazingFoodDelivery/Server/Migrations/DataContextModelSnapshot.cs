﻿// <auto-generated />
using System;
using BlazingFoodDelivery.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazingFoodDelivery.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazingFoodDelivery.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "MenuItemId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("BlazingFoodDelivery.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pizzas",
                            Url = "pizzas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Beverages",
                            Url = "beverages"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Desserts",
                            Url = "desserts"
                        });
                });

            modelBuilder.Entity("BlazingFoodDelivery.Shared.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Turkey bacon and sweet pineapples topped with 100% imported Italian mozzarella cheese.",
                            Featured = true,
                            ImageUrl = "images/aloha.jpg",
                            Price = 10.90m,
                            Title = "Aloha"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Beef pepperoni topped with 100% imported Italian mozzarella cheese.",
                            Featured = false,
                            ImageUrl = "images/pepperoni.jpg",
                            Price = 10.90m,
                            Title = "Pepperoni"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Grilled oregano chicken strips loaded with roasted red peppers, parmesa and 100% imported Italian mozzarella cheese.",
                            Featured = false,
                            ImageUrl = "images/sanRemo.jpg",
                            Price = 10.90m,
                            Title = "San Remo"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Home-made teriyaki sauce, oregano chicken, olive oil, white onions with 100% imported Italian mozzarella cheese.",
                            Featured = false,
                            ImageUrl = "images/teriyakiChicken.jpg",
                            Price = 10.90m,
                            Title = "Teriyaki Chicken"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Tomatoes, fresh basil leaves, olive oil, topped with 100% imported Italian mozzarella cheese.",
                            Featured = false,
                            ImageUrl = "images/margherita.jpg",
                            Price = 10.90m,
                            Title = "Margherita"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Made with freshly handmade dough, topped with our handmade pizza sauce and secret spices and completed with 100% imported Italian mozzarella cheese.",
                            Featured = false,
                            ImageUrl = "images/cheese.jpg",
                            Price = 10.90m,
                            Title = "Cheese"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Delicious and refreshing since 1886.",
                            Featured = false,
                            ImageUrl = "images/cocaCola.png",
                            Price = 2.90m,
                            Title = "Coca-Cola"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "100% real brewed from selected premium tea leaves, POKKA Jasmine Green Tea delivers the superior taste you have come to love. Its blend of aromatic jasmine with the highest quality green tea promises a refreshing enjoyment with natural antioxidant goodness.",
                            Featured = false,
                            ImageUrl = "images/greenTea.jpg",
                            Price = 2.90m,
                            Title = "Green Tea"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "A full-bodied infusion of black tea with rich cocoa undertones.",
                            Featured = false,
                            ImageUrl = "images/tea.jpg",
                            Price = 2.90m,
                            Title = "Hot Tea"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "Enjoy our rich, flavorful brewed coffees any time of the day. Easy-drinking on its own and delicious with milk and sugar.",
                            Featured = false,
                            ImageUrl = "images/coffee.jpg",
                            Price = 2.90m,
                            Title = "Hot Coffee"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "There’s no question chocolate and coffee are flavors that meant for each other. Both are rich and full of depth. Where one is creamy, the other is roasty. They complement each other perfectly. And when they come together under a fluffy cloud of sweetened whipped cream, you’ll wish their union would last forever.",
                            Featured = true,
                            ImageUrl = "images/mocha.jpg",
                            Price = 5.90m,
                            Title = "Caffè Mocha"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "DASANI® combines the process of reverse osmosis filtration with a proprietary blend of minerals to create fresh, clean, and premium tasting water that is pure and delicious.",
                            Featured = false,
                            ImageUrl = "images/dasani.jpg",
                            Price = 1.90m,
                            Title = "Dasani Water (600ML)"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = "Rich and moist with oozing Belgian chocolate lava inside.",
                            Featured = true,
                            ImageUrl = "images/chocLavaCake.jpg",
                            Price = 8.90m,
                            Title = "Hot Chocolate Lava Cake"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "It is made of ladyfingers dipped in coffee, layered with a whipped mixture of eggs, sugar, and mascarpone cheese, flavoured with cocoa.",
                            Featured = false,
                            ImageUrl = "images/tiramisu.jpg",
                            Price = 8.90m,
                            Title = "Tiramisu"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Description = "Our delicious take on the lemon meringue pie – A sweet, tangy tango of lemon curd, cheesecake, and a beautifully torched meringue.",
                            Featured = false,
                            ImageUrl = "images/lemonMeringue.jpg",
                            Price = 8.90m,
                            Title = "Lemon Meringue Cheesecake"
                        });
                });

            modelBuilder.Entity("BlazingFoodDelivery.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BlazingFoodDelivery.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "MenuItemId");

                    b.HasIndex("MenuItemId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("BlazingFoodDelivery.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlazingFoodDelivery.Shared.MenuItem", b =>
                {
                    b.HasOne("BlazingFoodDelivery.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazingFoodDelivery.Shared.OrderItem", b =>
                {
                    b.HasOne("BlazingFoodDelivery.Shared.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingFoodDelivery.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BlazingFoodDelivery.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
