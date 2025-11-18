using Microsoft.EntityFrameworkCore;

namespace scafullding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region muulti 
            BikeStoresContext testLinq = new BikeStoresContext();
            //var customers = testLinq.Customers.Where(c => c.State == "CA").ToList();
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine($"{customer.FirstName} {customer.LastName} - {customer.State}");
            //}

            #endregion
            #region challenge
            
            var product = testLinq.Products;
            var orderItems  = testLinq.orderitems.orderBy(x => x.ProductId);
            // select products 1 by 5 ways 
            //var  product1 = testLinq.Products.Where(p => p.ProductId == 1).FirstOrDefault();
            var product1 = testLinq.Products.Find(  1);
            #endregion
        }
    }
}
