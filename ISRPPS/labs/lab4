using System;

namespace Laba_4
{
    class Student
    {
        static void Main()
        {
            Console.WriteLine("Chain of responsibility");
            Console.WriteLine("Введите сторону a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону c (либо введите 0)");
            int c = Convert.ToInt32(Console.ReadLine());
            Task v = new Volume();
            Task s = new Square();
            v.Successor = s;
            v.HandleRequest(a, b, c);
            //s.HandleRequest(0, 4, 5);
        }
    }
    abstract class Task
    {
        public Task Successor { get; set; }
        public abstract void HandleRequest(int a, int b, int c);
    }

    class Volume : Task
    {
        public override void HandleRequest(int a, int b, int c)
        {
            // некоторая обработка запроса

            if (a != 0 && b != 0 && c != 0)
            {
                Console.WriteLine("Объём фигуры равен: {0}", a * b * c);
            }
            // передача запроса дальше по цепи при наличии в ней обработчиков
            else if (Successor != null)
            {
                Successor.HandleRequest(a, b, c);
            }
        }
    }

    class Square : Task
    {
        public override void HandleRequest(int a, int b, int c)
        {

            Console.WriteLine("Площадь фигуры равна: {0}", a * b + b * c + a * c);
            // передача запроса дальше по цепи при наличии в ней обработчиков

            if (Successor != null)
            {
                Successor.HandleRequest(a, b, c);
            }
        }

    }
}
