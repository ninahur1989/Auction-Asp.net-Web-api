using MarketPlace.Models;
using MarketPlace.Data.Enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketPlace.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationContext>();
                context.Database.EnsureCreated();

                //if (!context.Items.Any())
                //{
                //    context.Items.AddRange(new List<Item>()
                //    {
                //        new Item()
                //        {
                //            Description = "some",
                //            Metadata = "dsd",
                //            Name = "Apple"
                //        },
                //        new Item()
                //        {
                //            Description = "true",
                //            Metadata = "gfdg",
                //            Name = "phone"
                //        },
                //        new Item()
                //        {
                //            Description = "some",
                //            Metadata = "facebook",
                //            Name = "Window"
                //        }
                //    });
                //    context.SaveChanges();
                //}

                if (!context.Sales.Any())
                {
                    Random random = new Random();
                    for (int i = 0; i < 23; i++)
                    {
                        context.Sales.AddRange(new List<Sale>()
                        {
                            new Sale()
                            {
                                Buyer = "i",
                                Seller = "you",
                                CreatedDt = DateTime.Today,
                                FinishedDt = DateTime.Today.AddDays(1),
                                Item = new Item()
                                {
                                    Description = "some",
                                    Metadata = "dsd",
                                    Name = "Apple"
                                },
                                Price = 113.333M + random.Next(1, 10000),
                                Status = MarketStatus.None
                            },
                            new Sale()
                            {
                                Buyer = "Stas",
                                Seller = "Max",
                                CreatedDt = DateTime.Today,
                                FinishedDt = DateTime.Today.AddDays(3),
                                Item = new Item()
                                {
                                    Description = "true",
                                    Metadata = "gfdg",
                                    Name = "phone"
                                },
                                Price = 112.33M + random.Next(1, 10000),
                                Status = MarketStatus.Canceled
                            },
                            new Sale()
                            {
                                Buyer = "jon",
                                Seller = "Marry",
                                CreatedDt = DateTime.Today,
                                FinishedDt = DateTime.Today.AddDays(2),
                                Item = new Item()
                                {
                                    Description = "some",
                                    Metadata = "facebook",
                                    Name = "Window"
                                },
                                Price = 92.331M + random.Next(1, 10000),
                                Status = MarketStatus.Finished
                            },
                            new Sale()
                            {
                                Buyer = "i",
                                Seller = "you",
                                CreatedDt = DateTime.Today,
                                FinishedDt = DateTime.Today.AddDays(13),
                                Item = new Item()
                                {
                                    Description = "some",
                                    Metadata = "dsd",
                                    Name = "Apple"
                                },
                                Price = 43.333M + random.Next(1, 10000),
                                Status = MarketStatus.Active
                            },
                            new Sale()
                            {
                                Buyer = "Stas",
                                Seller = "Max",
                                CreatedDt = DateTime.Today,
                                FinishedDt = DateTime.Today.AddDays(10),
                                Item = new Item()
                                {
                                    Description = "true",
                                    Metadata = "gfdg",
                                    Name = "phone"
                                },
                                Price = 1142.33M + random.Next(1, 10000),
                                Status = MarketStatus.Canceled
                            },
                            new Sale()
                            {
                                Buyer = "jon",
                                Seller = "Marry",
                                CreatedDt = DateTime.Today,
                                FinishedDt = DateTime.Today.AddDays(24),
                                Item = new Item()
                                {
                                    Description = "some",
                                    Metadata = "facebook",
                                    Name = "Window"
                                },
                                Price = 912.331M + random.Next(1, 10000),
                                Status = MarketStatus.Finished
                            }
                        });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
