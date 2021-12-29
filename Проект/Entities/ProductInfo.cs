using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage2.Utils;

namespace Storage2.Entities
{
    public class ProductInfo : Item, IParse
    {
        public ProductType product_type;
        public string name;
        public string brand;
        public string description;
        public decimal cost;

        public ProductInfo
        (
            ProductType type, 
            string name,
            string brand,
            string description,
            decimal cost
        )
        {
            product_type = type;
            this.name = name;
            this.brand = brand;
            this.description = description;
            this.cost = cost;
        }

        public ProductInfo() { }

        public override object Clone() => new ProductInfo
            (
                product_type,
                name,
                brand,
                description,
                cost
            )
            { id = this.id };

        public override object[] row => new object[6]
        {
            id,
            product_type.id,
            name,
            brand,
            description,
            MySqlConvert.ToString(cost)
        };

        public Item Parse(params object[] row)
        {
            id = row[0].ToInt32();
            
            int id_pt = row[1].ToInt32();
            product_type = Tables.product_type.Search(id_pt);
            
            name = row[2].ToString();
            
            brand = row[3].ToString();
            
            description = row[4].ToString();

            cost = row[5].ToDecimal();
            
            return this.Clone() as ProductInfo;
        }

        public override string ToString() => name;
    }
}
