using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Lag.txt";
            if (File.Exists(path))
            {
                File.Create(path);
            }
            int[] array = new int[10];
            Random random = new Random();
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write("{0} ", array[i]);
                S += array[i];
            }
            using (StreamWriter sum = new StreamWriter(path, true))
            {
                sum.WriteLine(S);
            }
            int s1 = 0; //сумма цифр
            string[] p;
            using (StreamReader ou = new StreamReader(path))
            {
                p= Convert.ToInt32(ou.ReadToEnd());
                foreach (int a in p)
                {
                    s1 += a;
                }
            }
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
