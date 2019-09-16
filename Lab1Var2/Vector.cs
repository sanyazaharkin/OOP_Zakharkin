using System;

namespace Lab1
{
    public class Vector
    {
        public double A { get; set; }
        public double B { get; set; }

        public double Length { get; set; } = 0;        
                

        private Vector(Point A, Point B) : this((B.x - A.x), (B.y - A.y))
        {            
        }
        private Vector(double A, double B)
        {
            this.A = A;
            this.B = B;
            Length = Math.Sqrt((this.A * this.A) + (this.B * this.B));
        }

        public override string ToString()
        {
            return string.Format("Координаты вектора: А = {0} , B = {1}, Длина = {2}", this.A, this.B, this.Length);
        }

        public static Vector operator + (Vector Left, Vector Right)
        {
            return new Vector((Left.A + Right.A), (Left.B + Right.B));
        }

        public static Vector operator -(Vector Left, Vector Right)
        {
            return new Vector((Left.A - Right.A), (Left.B - Right.B));
        }

        public static double operator * (Vector Left, Vector Right)
        {
            return (Left.A * Right.A) + (Left.B * Right.B);
        }


        public static Vector GetNewVector()
        {
            double Ax = 0, Ay = 0, Bx = 0, By = 0;
            Console.Write("Введите координаты точки A\nX = ");
            Ax = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            Ay = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты точки B\nX = ");
            Bx = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            By = double.Parse(Console.ReadLine());

            return new Vector(new Point(Ax, Ay), new Point(Bx, By));
        }

    }
}
