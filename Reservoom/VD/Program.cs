using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD
{
    public class Father
    {
        public virtual void Do()
        {
            System.Console.WriteLine("Cha làm");
        }
    }
    class Program : Father
    {
        public override void Do()
        {
            base.Do();
        }
        static void Main(string[] args)
        {
            
        }
    }
}
