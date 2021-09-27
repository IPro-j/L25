using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L25
{
    [AttributeUsage(AttributeTargets.All)]
    //[AttributeUsage(AttributeTargets.Constructor) | AttributeUsage(AttributeTargets.Method)]

    public class Geo : Attribute
    {

        public int X { get; set; }

        public int Y { get; set; }

        public Geo() { }

        public Geo(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }

    }
}
