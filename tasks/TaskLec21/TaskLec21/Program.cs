namespace TaskLec21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BikeStoresContext())
            {
                using var customer= new BikeStoresContext(); 
                
                var customers = context.Customers
                                       .Select(c => new { c.FirstName, c.LastName, c.Email })
                                       .ToList();

                Console.WriteLine("=== Customers List ===");
                foreach (var c in customers)
                {
                    Console.WriteLine($"{c.FirstName} {c.LastName} - {c.Email}");
                }

                Console.WriteLine("");

               

            }
        }
    }
}
