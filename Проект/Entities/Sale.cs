using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage2.Entities
{
    //наследуемся от закупки
    public class Sale : Buying
    {

        public Sale
        (
            ProductStore product_store,
            int quantity,
            Client client,
            Worker worker,
            DateTime date
        )
        : base(product_store, quantity, client, worker, date) { }

        public Sale() { }

        //переопределяем знак подсчета количества
        protected override int sign => -1;

        //переопределяем метод клонирования на создание продажи
        public override object Clone() => new Sale
            (
                product_store,
                quantity,
                cleint,
                worker,
                date
            )
            { id = this.id, price = this.price };

        //переопределяем метод копирования объекта на продажу
        protected override Buying Copy() => (Sale)this.Clone();

    }
}
