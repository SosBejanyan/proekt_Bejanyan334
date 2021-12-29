using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage2.Entities;
using Storage2.Utils;

namespace Storage2
{
    public static class Tables
    {

        public readonly static Table<ProductType> product_type
            = new Table<ProductType>
            (
                "product_type", new ProductType(),
                new Field("type", EMySqlType.VARCHAR)
            );

        public readonly static Table<ProductInfo> product_info
            = new Table<ProductInfo>
            (
                "product_info", new ProductInfo(),
                new Field("product_type", EMySqlType.INT32),
                new Field("name", EMySqlType.VARCHAR),
                new Field("brand", EMySqlType.VARCHAR),
                new Field("description", EMySqlType.VARCHAR),
                new Field("cost", EMySqlType.DECIMAL)
            );

        public readonly static Table<ProductStore> product_store
            = new Table<ProductStore>
            (
                "product_store", new ProductStore(),
                new Field("product_info", EMySqlType.INT32),
                new Field("quantity", EMySqlType.INT32),
                new Field("is_supplied", EMySqlType.BOOLEAN)
            );

        public readonly static Table<Client> clients
            = new Table<Client>
            (
                "client", new Client(),
                new Field("name", EMySqlType.VARCHAR),
                new Field("owner_fio", EMySqlType.VARCHAR),
                new Field("address", EMySqlType.VARCHAR),
                new Field("post_index", EMySqlType.INT32),
                new Field("phone", EMySqlType.INT64),
                new Field("email", EMySqlType.VARCHAR),
                new Field("Buyer_Saler", EMySqlType.VARCHAR),
                new Field("notes", EMySqlType.TEXT)
            );

        public readonly static Table<Worker> worker
            = new Table<Worker>
            (
                "worker", new Worker(),
                new Field("fio", EMySqlType.VARCHAR),
                new Field("role", EMySqlType.VARCHAR),
                new Field("phone", EMySqlType.INT64),
                new Field("email", EMySqlType.VARCHAR),
                new Field("is_internal", EMySqlType.BOOLEAN)
            );

        public readonly static Table<Buying> buying
            = new Table<Buying>
            (
                "buying", new Buying(),
                new Field("product_store", EMySqlType.INT32),
                new Field("quantity", EMySqlType.INT32),
                new Field("client", EMySqlType.INT32),
                new Field("worker", EMySqlType.INT32),
                new Field("date", EMySqlType.DATE),
                new Field("price", EMySqlType.DECIMAL)
            );

        public readonly static Table<Buying> sale
            = new Table<Buying>
            (
                "sale", new Sale(),
                new Field("product_store", EMySqlType.INT32),
                new Field("quantity", EMySqlType.INT32),
                new Field("client", EMySqlType.INT32),
                new Field("worker", EMySqlType.INT32),
                new Field("date", EMySqlType.DATE),
                new Field("price", EMySqlType.DECIMAL)
            );

    }
}
