using System;

namespace Labb_3___Polymorphism
{
    public class Teckning
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Rektangel : Teckning
    {
        public double _bas { get; set; }
        public double _höjd { get; set; }
        public Rektangel(double bas, double höjd)
        {
            _bas = bas;
            _höjd = höjd;
        }
        public override double Area()
        {
            double area = this._bas * this._höjd;
            return area;
        }
    }

    public class Fyrkant : Teckning
    {
        public double _sida { get; set; }
        public Fyrkant(double sida)
        {
            _sida = sida;
        }
        public override double Area()
        {
            double area = Math.Pow(this._sida, 2);
            return area;
        }
    }

    public class Cirkel : Teckning
    {
        public double _radie { get; set; }
        public Cirkel(double radie)
        {
            _radie = radie;
        }
        public override double Area()
        {
            double area = Math.PI * Math.Pow(this._radie, 2);
            return area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Var vänlig och mata in rektangels bas: ");
            double svar1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Var vänlig och mata in rektangels höjd: ");
            double svar2 = Convert.ToDouble(Console.ReadLine());
            Teckning r = new Rektangel(svar1, svar2);
            Console.WriteLine($"Rektangels area är: {r.Area()}");

            Console.Write("\nVar vänlig och mata in fyrkantens sida: ");
            double svar3 = Convert.ToDouble(Console.ReadLine());
            Teckning f = new Fyrkant(svar3);
            Console.WriteLine($"Fyrkantens area är: {f.Area()}");

            Console.Write("\nVar vänlig och mata in cirkelns radie: ");
            double svar4 = Convert.ToDouble(Console.ReadLine());
            Teckning c = new Cirkel(svar4);
            Console.WriteLine($"Cirkelns area är: {c.Area()}");

            Console.ReadKey();
        }
    }
}
