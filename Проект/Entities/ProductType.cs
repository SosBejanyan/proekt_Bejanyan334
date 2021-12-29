using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage2.Utils;

namespace Storage2.Entities
{
    public class ProductType : Item, IParse
    {
        public string type;

        public ProductType(string type)
        { this.type = type; }

        public ProductType() { }

        public override object Clone() =>
            new ProductType(type) { id = this.id }; 

        public override object[] row => new object[2] { id, type }; 

        public Item Parse(params object[] row)
        {
            id = row[0].ToInt32();
            type = row[1].ToString();
            return this.Clone() as ProductType;
        }

        public override string ToString() => type;
    }
}
