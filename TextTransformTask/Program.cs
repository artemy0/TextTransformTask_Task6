using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformTask
{
    class Program
    {
        static void Main(string[] args)
        {
            TextTransformer tt = new TextTransformer("Hello world. It's me.");
            Console.WriteLine(tt.ToUpper());

            TextTransformer tt2 = new TextTransformer();
            Console.WriteLine(tt2.CustomToUpper());

            Console.ReadKey();
        }
    }
}
