using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage2.Utils;

namespace Storage2.Entities
{
    public class ProductStore : Item, IParse
    {
        public ProductInfo product_info;
        public int quantity;
        public bool is_supplied;

        public ProductStore
        (
            ProductInfo product_info,
            int quantity,
            bool is_supplied
        )
        {
            this.product_info = product_info;
            this.quantity = quantity;
            this.is_supplied = is_supplied;
        }

        public ProductStore() { }

        public override object Clone() => new ProductStore
            (
                product_info,
                quantity,
                is_supplied
            )
            { id = this.id };

        public override object[] row => new object[4]
        {
            id,
            product_info.id,
            quantity,
            MySqlConvert.ToBit(is_supplied)
        };


        public Item Parse(params object[] row)
        {
            id = row[0].ToInt32();

            int id_pi = row[1].ToInt32();
            product_info = Tables.product_info.Search(id_pi);

            quantity = row[2].ToInt32();

            is_supplied = Convert.ToBoolean(row[3]);

            return this.Clone() as ProductStore;
        }

        public override string ToString() => product_info.name;
    }
}
