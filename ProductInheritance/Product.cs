using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance {
    public class Product {
        //properties
        private bool Flag { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }

        //methods(actions)
        public string ToPrint() {
            return $"{GetType().ToString()} | {Code} | {Price:c}"; 

        }
        //Constructor (default would be no parameters (null or 0) if you dont create a Constructor)
                            //strings default to null
                            //boolean default to false
                            //decimals default to 0
        public Product(string Code, decimal price) {
            Flag = true;
            this.Code = Code; // "this." notifies the system that the first 'Code' is the property (this. only works for properties and methods)
            this.Price = price;
        }
        public Product() {

        }
    }
}
