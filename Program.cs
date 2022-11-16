using System;
using System.IO;
using System.Linq;

namespace Marius.Dobrovolskis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readText = File.ReadAllText(@"C:\Users\r7hbs\Desktop\FAILAS.txt");

            char[] charArr = readText.ToCharArray();

            Console.WriteLine(charArr);


            for (int i = 0; i < charArr.Length; i++)
            {

                int count = 0;


                foreach (char c2 in charArr)

                {

                    if (i == c2)
                        count++;
                    if (i != c2)
                        continue;
                }

                if (count == 1) { Console.Write(i); }

                if (count > 1) { Console.Write($"{i}{count}"); }





            }


        }
    }
}

