using System;
using System.IO;

namespace Day3_2021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            int[] NumOfOnes = new int[12], NumOfZero = new int[12];
            int[] GBinary = new int[12], Ebinary = new int[12];
            string G = "", E = "";
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '1')
                        {
                            NumOfOnes[i]++;
                        }
                        else if (line[i] == '0')
                        {
                            NumOfZero[i]++;
                        }
                    }
                }
            }
            for (int i = 0; i < NumOfOnes.Length; i++)
            {
                if (NumOfOnes[i] > NumOfZero[i])
                {
                    GBinary[i] = 1;
                    Ebinary[i] = 0;
                }
                else
                {
                    Ebinary[i] = 1;
                    GBinary[i] = 0;
                }
            }
            foreach (int i in Ebinary)
            {
                E += i.ToString();
            }
            foreach (int i in GBinary)
            {
                G += i.ToString();
            }

            int EDec = Convert.ToInt32(G, 2);
            int GDec = Convert.ToInt32(E, 2);

            Console.WriteLine(EDec);
            int product = GDec * EDec;
            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}
