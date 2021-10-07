using System;
namespace S6CPO
{

    
    public class Point
    {
        private int abscisse { get; set; }
        private int ordonne { get; set; }

        public Point(){}
        public Point(int abscisse, int ordonne)
        {
            this.abscisse = abscisse;
            this.ordonne = ordonne;
        }

        public double Norme()
        {
            return Math.Sqrt(Math.Pow(this.abscisse,2)+Math.Pow(this.ordonne,2));
        }

        static void Main(string[] args)
        {
            Point p = new Point(1,2);
            Console.WriteLine($"Value : {p.Norme()}");

        }
    
    }
}