using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.IsWeekEnd());
            //Console.WriteLine(dt.IsWeekDay());

            // Extension Method 
            //Console.WriteLine(DateTimeExtension.IsWeekEnd(dt));
            //Console.WriteLine(DateTimeExtension.IsWeekDay(dt));

            Pizza p = new Pizza();
            p.AddDough("Thin")
              .AddCheese(true)
              .AddSauce()
              .AddToppings("Olive", 3.57m);
            Console.WriteLine(p);

            Console.ReadKey();
        }
    }
}
