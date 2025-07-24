using System;

namespace TestDemo
{
    class Pro
    {
        void demo()
        {

            #region
            Console.WriteLine("请输入您的姓名");
            String? nameInput = Console.ReadLine(); // 允许 null
            String name = nameInput ?? ""; // 如果为 null，赋值为空字符串
            Console.ReadKey();
            Console.WriteLine(name);
            Console.WriteLine("请输入您的年龄");
            string? ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput ?? "0"); // 如果为 null，赋值为 "0"
            Console.ReadKey();
            Console.WriteLine(age);
            Console.WriteLine("请输入您的班级：");
            String? classNameInput = Console.ReadLine();
            String className = classNameInput ?? "";
            Console.ReadKey();
            Console.WriteLine(className);

            Console.Write("好好学习，天天向上"); // 输出到控制台且不换行
            Console.Write("努力工作，快乐生活");
            #endregion

        }
    }
}

