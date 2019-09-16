using System;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = Vector.GetNewVector();
            Vector vector2 = Vector.GetNewVector();
            

            Console.WriteLine(vector1);
            Console.WriteLine(vector2);
            Console.WriteLine("Сумма равно = " + (vector1 + vector2));
            Console.WriteLine("Разность равно = " + (vector1 - vector2));
            Console.WriteLine("Произведение равно = " + (vector1 * vector2));



            Console.WriteLine("END!!!");
            Console.ReadLine();
        }
    }
}
