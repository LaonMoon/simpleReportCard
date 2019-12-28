using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생 수를 입력해 주세요.");
            int studentcount = int.Parse(Console.ReadLine());
            
            int[] korean = new int[studentcount];
            int[] english = new int[studentcount];
            int[] math = new int[studentcount];

            int number = 0;
            while (number<studentcount)
            {
                Console.Write(number);
                Console.WriteLine("번의 점수를 입력하세요.");
                Console.WriteLine("국어 점수를 입력하세요.");
                korean[number] = int.Parse(Console.ReadLine());
                Console.WriteLine("영어 점수를 입력하세요.");
                english[number] = int.Parse(Console.ReadLine());
                Console.WriteLine("수학 점수를 입력하세요.");
                math[number] = int.Parse(Console.ReadLine());
                number = number + 1;
            }
            number = 0;
            while (number<studentcount)
            {
                Console.Write(number);
                Console.Write("번의 총점은 ");
                Console.Write(korean[number] + english[number] + math[number]);
                Console.WriteLine("점 입니다.");
                Console.Write("평균 점수는 ");
                Console.Write((korean[number] + english[number] + math[number]) / 3);
                Console.WriteLine("점 입니다.");
                number = number + 1;
            }
        }
    }
}
