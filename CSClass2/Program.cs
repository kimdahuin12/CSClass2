using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("김다흰⊙﹏⊙");
            Wanted<int> wantedInt = new Wanted<int>(1234);
            Wanted<double> wantdeDouble = new Wanted<double>(1234.12);
            
            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantdeDouble.Value);
        }
    }
}
