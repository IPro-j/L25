using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L25
{
    class Program
    {
        static void Main(string[] args)
        {

            var photo = new Photo("hello.png")
            {
                Path = @"C:\hello.png"
            };

            var type = typeof(Photo);
            var attr = type.GetCustomAttributes(false);
            var attrd = type.GetCustomAttributesData();

            foreach (var a in attr)
            {
                Console.WriteLine(a.ToString());

                
            }
            var prop = type.GetProperties();
            foreach(var p in prop)
            {

                
                Console.WriteLine(p.ToString());
                
            }
                


            Console.Read();

        }
    }
}
