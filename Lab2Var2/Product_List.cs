using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Var2
{
    public class Product_List
    {
        public Product data { get; private set; }
        public Product_List next_item { get; private set; }

        public Product_List() : this(null) { }
        public Product_List(Product data)
        {
            this.data = data;
        }

        public void Add(Product new_data)
        {
            if (this.data == null)
            {
                this.data = new_data;
            }
            else if (this.next_item != null)
            {                
                this.next_item.Add(new_data);
            }
            else
            {
                this.next_item = new Product_List(new_data);                
            }
        }

        public void Remove(int i)
        {

        }

        public void Clear(int i)
        {

        }

        //public Product this[int index]
        //{
        //    get
        //    {
                
        //    }

        //    set
        //    {
                
        //    }
        //} //перегрузка индексатора






    }
}
