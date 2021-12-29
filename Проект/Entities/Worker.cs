using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage2.Utils;

namespace Storage2.Entities
{
    public class Worker : Item, IParse
    {
        public string fio;
        public string role;
        public long phone;
        public string email;
        public bool is_internal;

        public Worker
        (
            string fio,
            string role,
            long phone,
            string email,
            bool is_internal
        )
        {
            this.fio = fio;
            this.role = role;
            this.phone = phone;
            this.email = email;
            this.is_internal = is_internal;
        }

        public Worker() { }

        public override object Clone() => new Worker
            (
                fio,
                role,
                phone,
                email,
                is_internal
            )
            { id = this.id };

        public override object[] row => new object[6]
        {
            id,
            fio,
            role,
            phone,
            email,
            MySqlConvert.ToBit(is_internal)
        };

        public Item Parse(params object[] row)
        {
            string[] r = MySqlConvert.ToString(row);
            id = r[0].ToInt32();
            fio = r[1];
            role = r[2];
            phone = r[3].ToInt64();
            email = r[4];
            is_internal = Convert.ToBoolean(row[5]);
            return this.Clone() as Worker;
        }

        public override string ToString() => 
            MySqlConvert.ToInitials(fio);
    }
}
