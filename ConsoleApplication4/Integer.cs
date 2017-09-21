using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public interface MyType
    {
        void Print();
    }

    public class Integer : MyType
    {
        public int? Value;

        public void Print()
        {
            Console.WriteLine(Value.ToString());
        }
    }
}
