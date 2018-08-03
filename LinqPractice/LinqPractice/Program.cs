using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var linqTest = new[] { 3, 4, 3, 50, 34, 5 };
            var classTest = new[]
            {
                new {age = 19, name = "taro"},
                new {age = 4,  name = "hana"},
                new {age = 2,  name = "pes"},
                new {age = 34, name = "ken"}
            };

            // selectは値を操作する.
            //var tmp = linqTest.OrderBy(_ => _).Select(_ => _ * 2);
            var tmp = classTest
                .Where(_ => _.age >= 9)
                .OrderBy(_ => _.age);

            foreach (var item in tmp)
            {
                Console.WriteLine(item.name);
                
            }
            Console.ReadKey();
        }
    }
}
