using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    public class BusinessClass:TimerAbstract
    {
        public BusinessClass(double interval):base(interval) 
        {  
        }
        public override void Log()
        {
            Console.WriteLine("custom log:"+DateTime.Now);
        }

    }
}
