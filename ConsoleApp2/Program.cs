using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weekdays weekdays = new Weekdays();

            Console.WriteLine(Weekdays.Friday); //output: Friday 
            int day = (int)Weekdays.Friday; // enum to int conversion
            Console.WriteLine(day); //output: 4 

            var wd = (Weekdays)5; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday 
            Console.ReadKey();
        }
    }
}
