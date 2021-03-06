using System;
using System.Collections.Generic;

namespace ProductInheritance {
    class Program {
        static void Main(string[] args) {

            List<Product> salesOrder = new List<Product>();

            Product widget1 = new Widget("W1", 50, "Small", "Red");
            Product widget2 = new Widget("W2", 100, "Medium", "White");
            Product widget3 = new Widget("W3", 200, "Large", "Blue");
            Product service = new Service("SVC", 500, "Premium", 5);
            Product software = new Software("SFWR", 150, true);

            salesOrder.Add(widget1);
            salesOrder.Add(widget2);
            salesOrder.Add(widget3);
            salesOrder.Add(service);
            salesOrder.Add(software);

            decimal salesOrderTotal = 0;
            foreach(Product p in salesOrder) {
                salesOrderTotal += p.Price; //totals up all the product lines
                if(p is Widget) {
                    Widget w = p as Widget;                                           //you have to define p as sometimes being a Widget/Service Class,
                    Console.WriteLine($"{p.Code} {p.Price:c} {w.Size} {w.Color}");    //otherwise it only assumes Product class which does not 
                    continue;                                                         //include all properties, just the base
                }                                                                     
                if(p is Service) {
                    Service s = p as Service;
                    Console.WriteLine($"{p.Code} {p.Price:c} {s.ServiceLevel} {s.NumberOfYears} years");
                    continue;
                }
                if(p is Software) {
                    Software sfwr = p as Software;
                    Console.WriteLine($"{p.Code} {p.Price:c} {(sfwr.Book ? "w/Book" : "w/o Book")}");
                    continue;
                }
            }
            Console.WriteLine($"Total sales order is {salesOrderTotal:c}");


            /*
             * the next lines are just the initial test of the Program w/o using the 
             * classes to input products
             */

            //Service s1 = new Service("BASIC", 100, "Basic", 3);
            //Console.WriteLine(s1.ToPrint());

            //Widget w = new Widget("Widget", 543.21m, "Large", "MAX Red");
            //Console.WriteLine(w.ToPrint());

            //Product p = new Product("Echo", 123.45m);
            //string message = p.ToPrint();
            //Console.WriteLine(message);
        }
    }
}
