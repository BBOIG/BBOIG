using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // 顏色
            Console.ForegroundColor = ConsoleColor.Red;

            // 輸入
            Console.Write("請輸入身高(公分):");
            string height = Console.ReadLine();
            Console.Write("請輸入體重(公斤):");
            string weight = Console.ReadLine();

            // 變數                  
            double BMI = double.Parse(weight) / ((double.Parse(height) / 100) * (double.Parse(height) / 100));

            // 計算
            Console.Write("BMI=" + BMI);

            // 結果
            if (BMI >= 27)
            {
                Console.Write("過重了!");
            }

            if (BMI < 18.5)
            {
                Console.Write("過輕了!");
            }

            if (BMI > 18.5 && BMI < 24)
            {
                Console.WriteLine("標準體重");
            }
            // 結束
            Console.ReadLine();
        }
    }
}
