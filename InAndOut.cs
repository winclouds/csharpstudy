using System;


namespace ConsoleAppcsharp
{
    class InAndOut
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("请问您最喜欢的运动是什么？");
            string ? sport = Console.ReadLine();
            Console.ReadKey();
            // Output
            Console.WriteLine("哈哈，正好我也喜欢" + sport + "！");

        }
    }
}
