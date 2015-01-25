using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_构造方法的重载_练习一
{
    class Program
    {
        static void Main(string[] args)
        {
            Student zsStudent = new Student("张三", '男', 18, 80, 85, 82);
            Student xlStudent = new Student("小兰", '女');
            xlStudent.Chinese = 85;
            xlStudent.Math = 90;
            xlStudent.English = 92;
            Console.WriteLine("下面是{0}的个人情况:", zsStudent.Name);
            zsStudent.SayHello();
            zsStudent.ShowScore();
            Console.WriteLine("下面是{0}的个人情况:", xlStudent.Name);
            xlStudent.SayHello();
            xlStudent.ShowScore();
            Console.ReadKey(true);
        }
    }
}
