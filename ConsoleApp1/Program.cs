using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入数字1：");

            //string input1= Console.ReadLine();
            //int _input1 = Convert.ToInt32(input1);

            //Console.WriteLine("请输入数字2：");
            //string input2 = Console.ReadLine();
            //int _input2 = Convert.ToInt32(input2);

            //Console.WriteLine("请输入数字3：");
            //string input3 = Console.ReadLine();
            //int _input3 = Convert.ToInt32(input3);

            //int result = _input1 * _input2 * _input3;
            //Console.WriteLine("三个数的积等于" + result);
            //Console.ReadKey();


            Console.WriteLine("请输入圆的半径:");
            string r = Console.ReadLine();
            double _r = Convert.ToDouble(r);

            double area = 3.14 * _r *_r;
            double zhouchang = 3.14 * _r;
            Console.WriteLine("面积为" + area);
            Console.WriteLine("周长为" + zhouchang);
            Console.ReadKey();


        }
    }
}
