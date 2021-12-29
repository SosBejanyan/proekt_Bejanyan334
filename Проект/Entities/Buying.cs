using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage2.Utils;
using Storage2.Entities;

namespace Storage2.Entities
{
    public class Buying : Item, IParse
    {
        public ProductStore product_store;
        public int quantity;
        public Client cleint;
        public Worker worker;
        public DateTime date;
        public decimal price;

        public Buying
        (
            ProductStore product_store,
            int quantity,
            Client client,
            Worker worker,
            DateTime date
        )
        {
            this.quantity = quantity;
            this.cleint = client;
            this.worker = worker;
            this.date = date;
            this.product_store = product_store;
        }

        //знак изменения количества
        protected virtual int sign => 1;

        //рассчитывает цену и производит переучет
        //количества товара на складе
        public decimal ComputePrice(int q = 0)
        {
            q = q != 0 ? q : quantity;
            if (q == Int32.MinValue) { q = 0; }
            this.price = this.quantity * product_store.product_info.cost;
            product_store.quantity += (q - this.quantity) * sign;
            Tables.product_store.Update(product_store);
            return this.price;
        }

        public Buying() { }

        public override object Clone() => new Buying
            (
                product_store,
                quantity,
                cleint,
                worker,
                date
            )
            { id = this.id, price = this.price };

        public override object[] row => new object[7]
        {
            id,
            product_store.id,
            quantity,
            cleint.id,
            worker.id,
            MySqlConvert.ToString(date),
            MySqlConvert.ToString(price)
        };

        public Item Parse(params object[] row)
        {
            string[] r = MySqlConvert.ToString(row);
            id = r[0].ToInt32();
            product_store = Tables.product_store.Search(r[1].ToInt32());
            quantity = r[2].ToInt32();
            cleint = Tables.clients.Search(r[3].ToInt32());
            worker = Tables.worker.Search(r[4].ToInt32());
            date = DateTime.Parse(r[5]);
            price = r[6].ToDecimal();
            return this.Copy();
        }
        protected virtual Buying Copy() => this.Clone() as Buying;
    }
}
