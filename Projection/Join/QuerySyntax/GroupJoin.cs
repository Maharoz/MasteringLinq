using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join.QuerySyntax
{
    public class GroupJoin
    {
        public class Product
        {
            public string? Name { get; set; }
            public int CategoryId { get; set; }
        }

        public class Category
        {
            public int Id { get; set; }
            public string? CategoryName { get; set; }
        }

        public static void GroupJoinExample()
        {
            List<Product> products =
            [
                new Product { Name = "Cola", CategoryId = 0 },
                new Product { Name = "Tea", CategoryId = 0 },
                new Product { Name = "Apple", CategoryId = 1 },
                new Product { Name = "Kiwi", CategoryId = 1 },
                new Product { Name = "Carrot", CategoryId = 2 },
            ];

            List<Category> categories =
            [
                new Category { Id = 0, CategoryName = "Beverage" },
                new Category { Id = 1, CategoryName = "Fruit" },
                new Category { Id = 2, CategoryName = "Vegetable" }
            ];

            // Join categories and product based on CategoryId and grouping result
            var productGroups = from category in categories
                                join product in products on category.Id equals product.CategoryId into productGroup
                                select productGroup;

            foreach (IEnumerable<Product> productgroup in productGroups)
            {
                Console.WriteLine("Group");
                foreach (Product product in productgroup)
                {
                    Console.WriteLine($"{product.Name,8}");
                }
            }

            // This code produces the following output:
            //
            // Group
            //     Cola
            //      Tea
            // Group
            //    Apple
            //     Kiwi
            // Group
            //   Carrot
        }
    }
}
