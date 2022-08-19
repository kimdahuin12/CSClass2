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

            Products p = new Products();
            Console.WriteLine("오늘의 점심 메뉴는 " + p[2] + "입니다.");
            p[2] = "단무지";
            Console.WriteLine("오늘의 점심 메뉴는 " + p[2] + "입니다.");
        }
    }
}
