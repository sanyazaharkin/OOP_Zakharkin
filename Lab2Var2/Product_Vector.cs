using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Var2
{
    class Product_Vector
    {
        private Product[] products;

        
        public delegate int CompareMethod(Product first, Product second);
        public delegate int FindMethod(Product product);



        public Product_Vector() : this(0) { }        
        public Product_Vector(int numb)
        {
            products = new Product[numb];
        }

        public Product GetItem(int i)
        {
            return products[i];
        }               
        public Product Back
        {
            get
            {
                return products[products.Length - 1];
            }
            set
            {
                products[products.Length - 1] = value;
            }
        }
        public Product Front
        {
            get
            {
                return products[0];
            }
            set
            {
                products[0] = value;
            }
        }
        public void Crear()
        {
            products = new Product[0];
        }

        
               
        public List<Product> Find(ref List<Product> list, CompareMethod compare_by, FindMethod find)
        {
            Sort(compare_by);            
            BinarySearch(ref list, find, 0, products.Length - 1);
            return list;
        }
        private void BinarySearch(ref List<Product> list, FindMethod find, int left, int right)
        {
            
            if (left > right)
                return;

            int middle = (left + right) / 2;
            Product item = products[middle];
            int compare_result = find(item);
            if (compare_result == 0)
            {
                list.Add(item);
                return;
            }
            else
            {
                if (compare_result == 1)
                {
                    BinarySearch(ref list, find, left, middle);
                }
                else 
                {
                    BinarySearch(ref list, find, middle + 1, right);
                }
            }
            return;

        }



        public void Sort(CompareMethod compare_by)   //метод сортировки пузырьком по выбранному полю
        {            
            for (int i = 0; i < products.Length; i++)
            {                
                for (int j = 0; j < products.Length - 1 - i; j++)
                {                    
                    if (compare_by(products[j], products[j + 1]) > 0)
                    {                        
                        Swap(ref products[j], ref products[j + 1]);
                    }
                }
            }
        }

        private static void Swap(ref Product x, ref Product y)
        {
            Product tmp = x;            
            x = y;            
            y = tmp;
        }

        public Product this[int index]
        {
            get
            {
                return products[index];
            }

            set
            {
                products[index] = value;
            }
        } //перегрузка квадратных скобок

        public void Insert(int pos, Product item)
        {
            Array.Resize(ref products, products.Length + 1);
            for (int i = products.Length - 1; i > pos; i--)
            {
                products[i] = products[i - 1];
            }
            products[pos] = item;
        }
        public void PushBack(Product item)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = item;
        }
        public void PushFront(Product item)
        {
            Insert(0, item);
        }
        public int Count
        {
            get
            {
                return products.Length;
            }
        }
        public Product[] ToArray()
        {
            return products;
        }
        public override string ToString()
        {

            string result = string.Empty;
            foreach (Product item in products)
            {
                result += item.ToString() + "\n";
            }
            return result;
        }


    }
}
