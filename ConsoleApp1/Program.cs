using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //測試樣本
            var list = new List<int>();
            for (int i = 0; i < 5000; i++)
                list.Add(i);

            //運用NewGuid極度難重複特性取亂數
            var random_list = list.OrderBy(i => Guid.NewGuid()).ToList();

            var a = random_list.Count();
            Console.WriteLine(a);
            Console.WriteLine(string.Join(",", random_list));
            Console.ReadLine();
        }
    }
}
