using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Добрый день, в задании не указано явно нужно-ли реализовывать список в который складываются результаты поиска, поэтому реализовывать не стал, если есть такая необходимость то пожалуйста верните работу на доработку



//    Вариант 2
//«Работа со стандартной библиотекой шаблонов».
//На языке С++ реализовать класс, описывающий товар на складе, содержащий
//поля: наименование, артикул, дата поступления на склад, количество товара,
//цена за единицу товара.Реализовать класс контейнер - вектор, содержащий
//объекты класса «Товар». Отсортировать контейнер. С использованием
//алгоритма двоичного поиска, провести поиск в контейнере по артикулу,
//названию, и дате поступления.При поиске осуществлять запись найденных
//объектов в контейнер-список.В качестве отчетности представить исходный
//код программы.




namespace Lab2Var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product_Vector vector = new Product_Vector();




            vector.PushBack(new Product("Apple Green", 111, 1000, 150));
            vector.PushBack(new Product("Orange", 222, 999, 200));
            vector.PushBack(new Product("Qiwi", 333, 1001, 500));
            vector.PushBack(new Product("Apple Red", 444, 500, 160));

            vector.PushBack(new Product("Apple Green2", 555, 1000, 150));
            vector.PushBack(new Product("Orange2", 666, 999, 200));
            vector.PushBack(new Product("Qiwi2", 777, 1001, 500));
            vector.PushBack(new Product("Apple Red2", 888, 500, 160));

            //Console.WriteLine(vector);


            //Console.WriteLine("Выполняем Сортировку name ----------------------------------------------");
            //vector.Sort((X, Y) => X.name.CompareTo(Y.name));
            //Console.WriteLine(vector);


            Console.WriteLine("Выполняем Сортировку Vendor_code ----------------------------------------------");
            vector.Sort((X, Y) => X.vendor_code.CompareTo(Y.vendor_code));
            Console.WriteLine(vector);

            List<Product> FindedList = new List<Product>(); //список для сохранения результатов поиска

            vector.Find(ref FindedList, (X, Y) => X.name.CompareTo(Y.name), (product) => product.name.CompareTo("Apple Green2"));
            vector.Find(ref FindedList, (X, Y) => X.vendor_code.CompareTo(Y.vendor_code), (product) => product.vendor_code.CompareTo(888));
            vector.Find(ref FindedList, (X, Y) => X.vendor_code.CompareTo(Y.vendor_code), (product) => product.vendor_code.CompareTo(777));


            Console.WriteLine("Вывод результатов поиска");
            foreach (var item in FindedList)
            {                
                Console.WriteLine(item.ToString());
            }
            

            Console.ReadKey();
        }
    }
}
