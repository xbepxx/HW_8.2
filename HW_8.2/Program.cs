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
            string path = "Lag2.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sum = new StreamWriter(path))
            {
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sum.Write(random.Next(0, 10));
                }
            }
            using (StreamReader ou = new StreamReader(path))
            {
                string arStr = ou.ReadToEnd();
                int s1 = 0;
                char[] s = arStr.ToCharArray();
                foreach (int x in s)
                {
                    s1 += x;
                }
                Console.WriteLine(s1);
            }
            Console.ReadKey();
        }
    }
}
