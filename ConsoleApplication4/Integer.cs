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
        public Integer()
        {

        }
        public Integer(int k)
        {
            this.Value = k;
        }

        public void Decrement()
        {
            this.Value -= 1;
        }


        public int? Value {get; set;}

        
        public void Print()
        {
            Console.WriteLine(Value.ToString());
        }
    }
}
