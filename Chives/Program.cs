using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chives
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入韭菜人數(N <= 999,999,999,999):");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.Write("請輸入割韭菜次數(M <= 999,999):");
            int m = int.Parse(Console.ReadLine());

            int[] chivesArr = new int[2];
            int tmp;
            //使用GUID產生亂數
            Random rnd = new Random(Guid.NewGuid().GetHashCode());            
            List<int> tatalList = new List<int>();

            Console.WriteLine($"=========共有{m}次割韭菜，每次割韭菜範圍如下========");
            for (int i = 1; i<= m; i++)
            {
                //列出每次割韭菜範圍(random)
                for (int a = 0; a <= chivesArr.Length - 1; a++)
                {
                    chivesArr[a] = rnd.Next(1, (int)n + 1);
                }

                for (int k = 0; k < chivesArr.Length; k++)
                {
                    for (int h = 0; h < k; h++)
                    {
                        //割韭菜範圍(random)泡泡排序
                        if (chivesArr[h] > chivesArr[h + 1])
                        {
                            tmp = chivesArr[h];
                            chivesArr[h] = chivesArr[h + 1];
                            chivesArr[h + 1] = tmp;
                        }
                        Console.WriteLine(string.Join(" ~ ", chivesArr));

                        //列出韭菜list
                        int chiLength = chivesArr[h+1] - chivesArr[h] + 1;
                        List<int> chivesList = new List<int>();
                        for (int x = 0; x < chiLength; x++)
                        {
                            chivesList.Add(chivesArr[h]);
                            chivesArr[h] += 1;
                        }
                        //Console.WriteLine(string.Join(",", chivesList));

                        tatalList.AddRange(chivesList);
                    }
                }  
            }
            //Console.WriteLine(string.Join(",", tatalList));

            //計算每位韭菜被割次數
            var q = from p in tatalList
                    group p by p into g
                    orderby g.Key
                    select new
                    {
                        ChivesNo = g.Key,
                        Num = g.Count()
                    };

            int oddNum = 0;
            foreach (var x in q)
            {
                //Console.WriteLine(x);
                if(x.Num % 2 == 1)
                {
                    oddNum += 1;
                }
            }

            //計算非韭菜人數(被割的次數為偶數次)
            int notChiNum = (int)n - oddNum;
            Console.WriteLine("=============================");
            Console.WriteLine($"沒賣出比特幣的韭菜:{notChiNum}人");          
            Console.ReadLine();

        }
    }
}
