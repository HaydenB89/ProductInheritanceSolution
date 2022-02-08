using System;

namespace ProductInheritance {
    class Program {
        static void Main(string[] args) {

            Widget w = new Widget("Widget", 543.21m, "Large", "MAX Red");
            Console.WriteLine(w.ToPrint());

            Product p = new Product("Echo", 123.45m);
            string message = p.ToPrint();
            Console.WriteLine(message);
        }
    }
}
