using Microsoft.Ajax.Utilities;
using SupplementShop.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace SupplementShop.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Whey Protein"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Mass Gainer"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Creatine"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "BCAA"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Multivitamins"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Whey Hydrolysed",
                    Description = "This is Whey Hydrolysed!", 
                    ImagePath="superwhey.png",
                    UnitPrice = 115,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Whey Isolate",
                    Description = "This is Whey Isolate!",
                    ImagePath ="wheyisolate.png",
                    UnitPrice = 100,
                     CategoryID = 1
               },                               
                new Product
                {
                    ProductID = 5,
                    ProductName = "Whey Concentrate with BCAA",
                    Description = "This is Whey Concentrate with BCAA!",               
                    ImagePath="",
                    UnitPrice = 105,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Mass Gainer Isolate",
                    Description = "This is Mass Gainer Isolate!",
                    ImagePath="",
                    UnitPrice = 90,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Mass Gainer Concentrate",
                    Description = "This is Mass Gainer Concentrate!",
                    ImagePath="",
                    UnitPrice = 80,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Creatine Monohydrate",
                    Description = "This is Creatine Monohydrate!",
                    ImagePath="",
                    UnitPrice = 50,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Creatine Capsule",
                    Description = "This is Creatine Capsule!",
                    ImagePath="",
                    UnitPrice = 30,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Creatine Tablet",
                    Description = "This is Creatine tablet!",
                    ImagePath="",
                    UnitPrice = 30,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "BCAA XTEND",
                    Description = "This is BCAA XTEND!",                                  
                    ImagePath="",
                    UnitPrice = 70,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "BCAA Modern",
                    Description = "This is BCAA Modern!",                                 
                    ImagePath="",
                    UnitPrice = 60,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Multivatamins Plus",
                    Description = "This is Mutivitamins Plus!",
                    ImagePath="",
                    UnitPrice = 30,
                    CategoryID = 5
                }
            };

            return products;
        }
    }
}