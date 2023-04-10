using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduceti cate nume si prenume doriti:");
        int numarNume = int.Parse(Console.ReadLine());
        string[] numeSiPrenume = new string[numarNume];

        for (int i = 0; i < numeSiPrenume.Length; i++)
        {
            Console.WriteLine("Introduceti numele si prenumele " + (i + 1) + ":");
            numeSiPrenume[i] = Console.ReadLine();
        }

        string[] numeInversate = GenerareNumeInversate(numeSiPrenume);
        Console.WriteLine("Numele introduse, inversate, sunt:");
        foreach (string nume in numeInversate)
        {
            Console.WriteLine(nume);
        }

        Console.Read();
    }

    static string[] GenerareNumeInversate(string[] numeSiPrenume)
    {
        string[] numeInversate = new string[numeSiPrenume.Length];

        for (int i = 0; i < numeSiPrenume.Length; i++)
        {
            string[] cuvinte = numeSiPrenume[i].Split(' ');
            numeInversate[i] = cuvinte[1] + " " + cuvinte[0];
        }

        return numeInversate;
    }
}
