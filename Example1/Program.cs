using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gidyyy.MathParser;

namespace Example1 {
    class Program {
        static void Main( string[] args ) {
            Console.WriteLine( MathParser.ParseToInt( "10 + 10 ^ 2 ^ 2 + 10 * 10" ) );
            Console.WriteLine( MathParser.ParseToFloat( "245.345 * 1032 + 834" ) );
            Console.WriteLine( MathParser.ParseToDouble( "1 / 3" ) );
            Console.ReadLine( );
        }
    }
}
