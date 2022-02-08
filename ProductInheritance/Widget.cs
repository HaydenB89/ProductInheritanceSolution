using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance {
    public class Widget:Product {
        public string Size { get; set; } = "Medium";
        public string Color { get; set; } = "Black";

        public override string ToPrint() {           //'override' key word means this will bump the virtual method of the parent
            return $"{base.ToPrint()} | {Size} | {Color}";    //'base.' refers to the parent Class that this Class derives from
        }                                                        //in this case Product is the parent
        
        public Widget(string code, decimal price, string size, string color) 
            :base(code, price){    //call Constructor in the parent Class (Product) to avoid duplicate code
            Size = size;
            Color = color;

        }

    }
}
