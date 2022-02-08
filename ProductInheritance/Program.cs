using System;

namespace ProductInheritance {
    class Program {
        static void Main(string[] args) {

            Product p = new Product("Widget", 123.45m);
            string message = p.ToPrint();
            Console.WriteLine(message);
        }
    }
}
