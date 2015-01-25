using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_构造方法的重载_练习二
{
    class Ticket
    {
        public Ticket(int distance)
        {
            if (distance>=0)
            {
                this.distance = distance;
            }
            else
            {
                throw new Exception("距离不能为负数!");//抛出异常:throw new Exception("错误信息");
            }
        }
        int distance;

        public int Distance
        {
            get { return distance; }
        }

        public decimal Price
        {
            get
            {
                switch (distance / 100)
                {
                    case 0:
                        return distance * 1.0m;
                    case 1:
                        return distance * 1.0m * 0.95m;//数字后面加后缀"m",表示数据类型为"decimal"
                    case 2:
                        return distance * 1.0m * 0.9m;
                    default:
                        return distance * 1.0m * 0.8m;
                }
            }
        }
        public void ShowTicket()
        {
            
            Console.WriteLine("这张票可以到达的距离为{0}公里,价格为{1}元。", distance, Price);
        }
    }
}
