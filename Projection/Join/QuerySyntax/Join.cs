using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join.QuerySyntax
{
    public class Join
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

        public static void JoinExample()
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

            var query = from product in products
                        join category in categories on product.CategoryId equals category.Id
                        select new { product.Name, category.CategoryName };

            foreach(var item in query)
            {
                Console.WriteLine($"{item.Name} - {item.CategoryName}");
            }
            // This code produces the following output:
            //
            // Cola - Beverage
            // Tea - Beverage
            // Apple - Fruit
            // Kiwi - Fruit
            // Carrot - Vegetable
        }
    }
}
