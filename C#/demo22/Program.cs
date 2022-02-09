using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo22
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { productid  = 5, productname = "mung", Price = 904.05M, Quantity = 12 },
                new Product { productid  = 2, productname = "tea", Price = 98.00M, Quantity = 35 },
                new Product { productid  = 1, productname = "arhad", Price =242.00M, Quantity = 7 },
                new Product { productid  = 3, productname = "chaval", Price = 25.00M, Quantity = 65 },
                new Product { productid  = 4, productname = "papad", Price = 86.00M, Quantity = 57 }
            };

            Console.WriteLine("{0:000}   {1,-15} {2,10} {3,10} {4,12}",
                    "ID", "Name", "Price", "Quantity", "Cost");
            foreach (Product p in products)
            {
                Console.WriteLine("{0:000}   {1, -15} {2,10} {3,10} {4,12}",
                    p.productid, p.productname, p.Price, p.Quantity, p.Price * p.Quantity);
            }
            Console.WriteLine();


            products.Sort();


            Console.WriteLine("{0:000}   {1,-15} {2,10} {3,10} {4,12}",
                    "ID", "Name", "Price", "Quantity", "Cost");
            foreach (Product p in products)
            {
                Console.WriteLine("{0:000}   {1, -15} {2,10} {3,10} {4,12}",
                    p.productid, p.productname, p.Price, p.Quantity, p.Price * p.Quantity);
            }
            Console.WriteLine();


            var query1 = from prod in products
                         orderby prod.productname descending
                         select prod;
            Console.WriteLine("{0:000}   {1,-15} {2,10} {3,10} {4,12}",
                    "ID", "Name", "Price", "Quantity", "Cost");
            foreach (Product p in query1)
            {
                Console.WriteLine("{0:000}   {1, -15} {2,10} {3,10} {4,12}",
                    p.productid, p.productname, p.Price, p.Quantity, p.Price * p.Quantity);
            }
            Console.WriteLine();

            var query2 = from prod in products
                         orderby prod.productname descending
                         where prod.productid >= 3
                         select new                   
                         {
                             ID = prod.productid,
                             Name = prod.productname,
                             Qty = prod.Quantity,
                             prod.Price,
                             Cost = prod.Quantity * prod.Price
                         };
            Console.WriteLine("{0:000}   {1,-15} {2,10} {3,10} {4,12}",
                    "ID", "Name", "Price", "Quantity", "Cost");
            foreach (var p in query2)
            {
                Console.WriteLine("{0:000}   {1, -15} {2,10} {3,10} {4,12}",
                    p.ID, p.Name, p.Price, p.Qty, p.Cost);
            }
            Console.WriteLine();

            var query3 = products
                         .Where(p => p.productid >= 3)
                         .OrderByDescending(p => p.productname)
                         .Skip(1)
                         .Take(2);

            var isFound = products.Any(p => p.productid == 3);
            if (isFound)
            {
                Console.WriteLine("Product with ID == 5 was found");
            }

            var prod4 = products.SingleOrDefault(p => p.productid == 2);
            if (prod4 != null)
            {
                Console.WriteLine("Product with ID 4 was found!");
                Console.WriteLine("{0} {1}", prod4.productid, prod4.productname);
            }
        }
    }
}
