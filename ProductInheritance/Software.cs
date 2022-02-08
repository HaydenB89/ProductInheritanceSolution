using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInheritance {
    public class Software:Product {
        public bool Book { get; set; } = true;

        public override string ToPrint() {
            return $"{base.ToPrint()} | {(Book ? "Yes" : "No")}"; // turnery statement will produce yes/no instead of true/false
        }

        public Software(string code, decimal price, bool book)
            :base(code, price) {
            Book = book;
        }
        public Software() :base() {

        }
    }
}
