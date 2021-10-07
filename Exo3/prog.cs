using s6cpo;
using System;
public class Prog
{
    public static void Main(string[] args)
    {
        DateTime birth1 = new DateTime(2000, 09, 29);
        DateTime birth2 = new DateTime(1985, 02, 15);
        DateTime birth3 = new DateTime(1995, 07, 17);
        DateTime birth4 = new DateTime(1967, 09, 26);
        DateTime birth5 = new DateTime(2000, 01, 01);
        DateTime birth6 = new DateTime(1987, 04, 05);
        DateTime birth7 = new DateTime(1982, 12, 09);
        DateTime birth8 = new DateTime(1962, 12, 06);

        Employee p1 = new Employee("Alexandre", "Choucq", birth1, 2500);
        Employee p2 = new Employee("Jean", "Dupont", birth2, 1800);
        Employee p3 = new Employee("Homard", "Faris", birth3,1500);
        Employee p4 = new Employee("Maurice", "Jones", birth4,3000);
        Employee p5 = new Employee("Carl", "Ito", birth5,1200);
        Chief p6 = new Chief("John", "Wick", birth6, 5000, "Security");
        Chief p7 = new Chief("Claire", "Redfield", birth7, 5000, "IT");
        CEO p8 = new CEO("Julie", "Mano", birth8, 10000, "Commercial", "Unknown Corp");

        Personne[] people = new Personne[8] {p1, p2, p3, p4, p5, p6, p7, p8};

        foreach (Personne p in people)
        {
            p.ShowInfo();
            Console.WriteLine("\n");
        }
    }

}