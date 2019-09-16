using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Var2
{
    public class Product
    {
        public string name = string.Empty;
        public int vendor_code;
        public DateTime date_of_receipt;
        public int quantity_of_goods;
        public int unit_price;


        public Product()
        {
            throw new Exception("Невозможно создать объект с пустыми полями!!!");
        }



        public Product(string name, int vendor_code, int quantity_of_goods, int unit_price)
        {
            this.name = name;
            this.vendor_code = vendor_code;
            this.date_of_receipt = DateTime.Now;
            this.quantity_of_goods = quantity_of_goods;
            this.unit_price = unit_price;
        }

        public override string ToString()
        {
            return String.Format( "---------------------------------------" +
                                "\nНаименование = {0}" +
                                "\nАртикул = {1}" +
                                "\nДата поступления на склад = {2}" +
                                "\nКол-во на складе = {3}" +
                                "\nЦена за штуку = {4}" +
                                "\n---------------------------------------", name,vendor_code,date_of_receipt,quantity_of_goods,unit_price);
        }



    }
}
