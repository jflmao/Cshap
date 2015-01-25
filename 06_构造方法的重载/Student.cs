using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_构造方法的重载_练习一
{
    class Student
    {
        public Student(string name,char sex,int age,int chinese,int math,int english)
        {
            this.name = name;
            if (sex == '男' || sex == '女')
            {
                this.sex = sex;
            }
            else
            {
                this.sex = ' ';
            }
            this.age = age;
            this.chinese = chinese;
            this.math = math;
            this.english = english;
        }
        public Student(string name,char sex)
        {
            this.name = name;
            if (sex == '男' || sex == '女')
            {
                this.sex = sex;
            }
            else
            {
                this.sex = ' ';
            }
            this.age = 18;
            this.chinese = 0;
            this.math = 0;
            this.english = 0;
        }
        string name;

        public string Name
        {
            get { return name; }
        }
        char sex;

        public char Sex
        {
            get { return sex; }
        }
        int age;

        public int Age
        {
            get { return age; }
        }
        int chinese;

        public int Chinese
        {
            get { return chinese; }
            set { chinese = value; }
        }
        int math;

        public int Math
        {
            get { return math; }
            set { math = value; }
        }
        int english;

        public int English
        {
            get { return english; }
            set { english = value; }
        }
        
        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我是{1}同学，我今年{2}岁了。", name, sex, age);
        }
        public void ShowScore()
        {
            int sum = chinese + math + english;
            int avg = sum / 3;
            Console.WriteLine("我叫{0}，这次考试总成绩为{1}分，平均成绩为{2}分。", name, sum, avg);
        }
    }
}
