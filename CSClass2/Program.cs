using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Program
    {
        static void NextPosition(int x, int y, int vx ,int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
        static void Main(string[] args)
        {
            //generic
            Wanted<string> wantedString = new Wanted<string>("김다흰⊙﹏⊙");
            Wanted<int> wantedInt = new Wanted<int>(1234);
            Wanted<double> wantdeDouble = new Wanted<double>(1234.12);

            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantdeDouble.Value);

            //indexer
            Products p = new Products();
            Console.WriteLine("오늘의 점심 메뉴는 " + p[2] + "입니다.");
            p[2] = "단무지";
            Console.WriteLine("오늘의 점심 메뉴는 " + p[2] + "입니다.");

            //out 키워드
            Console.WriteLine("숫자 입력: ");
            //int output;
            bool result = int.TryParse(Console.ReadLine(), out int output);//TryParse는 문자열을 숫자로 바꿀 수 있으면 true, 아니면 false를 반환
            if (result)
            {
                Console.WriteLine("입력한 숫자:"+output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요!");
            }

            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;
            Console.WriteLine("현재 좌표: (" + x + ", " + y + ")");
            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표: (" + x + ", " + y + ")");

        }
    }
}
