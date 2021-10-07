using System;
using s6cpo;

namespace s6cpo
{
    public class Prog
    {
        static void Main(string[] args)
        {
            Compte compte1 = new Compte();
            CompteEpargne compte2 = new CompteEpargne(52);
            ComptePayant compte3 = new ComptePayant(63);

            compte1.AddCash(5);
            compte2.AddCash(5);
            compte3.AddCash(5);

            Console.WriteLine($"Solde compte1: {compte1.ToString()}\n");
            Console.WriteLine($"Solde compte2: {compte2.ToString()}\n");
            Console.WriteLine($"Solde compte3: {compte3.ToString()}\n");

            compte1.SubtractCash(5);
            compte2.SubtractCash(5);
            compte3.SubtractCash(5);

            Console.WriteLine($"Solde compte1: {compte1.ToString()}\n");
            Console.WriteLine($"Solde compte2: {compte2.ToString()}\n");
            Console.WriteLine($"Solde compte3: {compte3.ToString()}\n");

            compte2.InterestCalcul();
            Console.WriteLine($"Solde compte2: {compte2.ToString()}\n");

        }
    }
}