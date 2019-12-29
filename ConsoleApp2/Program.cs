using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생 수를 입력해 주세요.");
            int studentcount = int.Parse(Console.ReadLine());
            string[] name = new string[studentcount];                
            int[] korean = new int[studentcount];
            int[] english = new int[studentcount];
            int[] math = new int[studentcount];

            for (int number = 0;number<studentcount;number++)
            {
                Console.Write(number);
                Console.WriteLine("번의 이름을 입력하세요.");
                name[number] = Console.ReadLine();
                Console.WriteLine("국어 점수를 입력하세요.");
                korean[number] = int.Parse(Console.ReadLine());
                Console.WriteLine("영어 점수를 입력하세요.");
                english[number] = int.Parse(Console.ReadLine());
                Console.WriteLine("수학 점수를 입력하세요.");
                math[number] = int.Parse(Console.ReadLine());
            }

            for (int number = 0; number < studentcount; number++)
            {
                Console.Write(name[number]);
                Console.Write("의 총점은 ");
                Console.Write(korean[number] + english[number] + math[number]);
                Console.WriteLine("점 입니다.");
                Console.Write("평균 점수는 ");
                Console.Write((korean[number] + english[number] + math[number]) / 3);
                Console.WriteLine("점 입니다.");
            }
        }
    }
}
