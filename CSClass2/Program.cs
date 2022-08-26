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
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화A";
                this.testB = "초기화B";
            }
            public Point(int x, int y, string testA, string testB)
            {
                this.x = x;
                this.y = y;
                this.testA = testA;
                this.testB = testB;
            }

        }

        class PointClass
        {
            public int x;
            public int y;
            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct  PointStruct
        {
            public int x;
            public int y;
            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            ////generic
            //Wanted<string> wantedString = new Wanted<string>("김다흰⊙﹏⊙");
            //Wanted<int> wantedInt = new Wanted<int>(1234);
            //Wanted<double> wantdeDouble = new Wanted<double>(1234.12);

            //Console.WriteLine(wantedString.Value);
            //Console.WriteLine(wantedInt.Value);
            //Console.WriteLine(wantdeDouble.Value);

            ////indexer
            //Products p = new Products();
            //Console.WriteLine("오늘의 점심 메뉴는 " + p[2] + "입니다.");
            //p[2] = "단무지";
            //Console.WriteLine("오늘의 점심 메뉴는 " + p[2] + "입니다.");

            ////out 키워드
            //Console.WriteLine("숫자 입력: ");
            ////int output;
            //bool result = int.TryParse(Console.ReadLine(), out int output);//TryParse는 문자열을 숫자로 바꿀 수 있으면 true, 아니면 false를 반환
            //if (result)
            //{
            //    Console.WriteLine("입력한 숫자:"+output);
            //}
            //else
            //{
            //    Console.WriteLine("숫자를 입력해주세요!");
            //}

            //int x = 0;
            //int y = 0;
            //int vx = 1;
            //int vy = 1;
            //Console.WriteLine("현재 좌표: (" + x + ", " + y + ")");
            //NextPosition(x, y, vx, vy, out x, out y);
            //Console.WriteLine("다음 좌표: (" + x + ", " + y + ")");

            //struct
            Point point = new Point(100, 200); //new 키워드는 생성자를 호출하는 키워드이다.
            //point.x = 10;
            //point.y = 20;
            Console.WriteLine("x:"+point.x+", y: "+point.y);
            
            PointClass pcA = new PointClass(10, 20);
            PointClass pcB = pcA;
            pcB.x = 100; pcB.y = 200;
            Console.WriteLine("pcA. x:" + pcA.x + ", y: " + pcA.y);
            Console.WriteLine("pcB. x:" + pcB.x + ", y: " + pcB.y);
           
            PointStruct psA = new PointStruct(10, 20);
            PointStruct psB = psA;
            psB.x = 100; psB.y = 200;
            Console.WriteLine("psA. x:" + psA.x + ", y: " + psA.y);
            Console.WriteLine("psB. x:" + psB.x + ", y: " + psB.y);
            Console.WriteLine("===========================================");

            List<Product> products = new List<Product>()
            {
                new Product(){Name="고구마", Price=1500 },
                new Product(){Name="사과", Price=3000 },
                new Product(){Name="바나나", Price=1000 },
                new Product(){Name="배", Price=4000},
            };

            products.Sort();

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

        }
    }
}
