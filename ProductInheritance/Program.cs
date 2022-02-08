using System;

namespace ProductInheritance {
    class Program {
        static void Main(string[] args) {

            Widget w = new Widget();
            w.Code = "Widget2";
            w.Price = 543.21m;
            Console.WriteLine(w.ToPrint());

            Product p = new Product("Widget", 123.45m);
            string message = p.ToPrint();
            Console.WriteLine(message);
        }
    }
}
