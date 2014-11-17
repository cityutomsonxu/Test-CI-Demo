using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib1;
namespace MainApp
{
    class Program
    {   
        static void Main(string[] args)
        {
            CalculatorCore cal=new CalculatorCore(); 
            Console.WriteLine(cal.add(1,2));
            Console.ReadLine();
        }
    }
}
