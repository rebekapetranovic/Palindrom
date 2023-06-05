using System;
namespace Prvi
{
    class Program
    {
        /// <summary>
        /// ISPITATI ZA SVAKU RIJEC U RECENICI JE LI PALINDRON
        /// </summary>
        static void Main()
        {
            int i;
            int n = 0;
            string rec;
            Console.Write("Upišite rečenicu: ");
            rec = Console.ReadLine();
            string[] rij = rec.Split();
            string novo = null;
            foreach (string x in rij)
            {
                n = x.Length;
                for (i = n - 1; i >= 0; i--)
                {
                    novo += x[i];
                }
                if (novo == x)
                {
                    Console.WriteLine("Rijec {0} je palindrom", x);
                }
                else
                {
                    Console.WriteLine("Rijec {0} nije palindrom", x);
                }
            }
        }
    }
}