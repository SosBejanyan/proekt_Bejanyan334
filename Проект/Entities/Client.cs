using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage2.Utils;

namespace Storage2.Entities
{
    public class Client : Item, IParse
    {
        public string name;
        public string owner_fio;
        public string address;
        public int post_index;
        public long phone;
        public string email;
        public bool BuyerSaler;
        public string notes;

        public Client
        (
            string name,
            string owner_fio,
            string address,
            int post_index,
            long phone,
            string email,
            bool BuyerSaler,
            string notes
        )
        {
            this.name = name;
            this.owner_fio = owner_fio;
            this.address = address;
            this.post_index = post_index;
            this.phone = phone;
            this.email = email;
            this.BuyerSaler = BuyerSaler;
            this.notes = notes;
        }

        public Client() { }

        public override object Clone() => new Client
            (
                name,
                owner_fio,
                address,
                post_index,
                phone,
                email,
                BuyerSaler,
                notes
            )
            { id = this.id }; 

        public override object[] row => new object[9]
        {
            id,
            name,
            owner_fio,
            address,
            post_index,
            phone,
            email,
            MySqlConvert.ToBit(BuyerSaler),
            notes
        };

        public Item Parse(params object[] row)
        {
            string[] r = MySqlConvert.ToString(row);
            id = (r[0]).ToInt32();
            name = r[1];
            owner_fio = r[2];
            address = r[3];
            post_index = r[4].ToInt32();
            phone = r[5].ToInt64();
            email = r[6];
            BuyerSaler = Convert.ToBoolean(row[7]);
            notes = r[8];
            return this.Clone() as Client;
        }

        public override string ToString() => name;
    }
}
