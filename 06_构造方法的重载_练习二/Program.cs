using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_构造方法的重载_练习二
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket huochepiao = new Ticket(999);
            huochepiao.ShowTicket();
            Console.ReadKey(true);
        }
    }
}
