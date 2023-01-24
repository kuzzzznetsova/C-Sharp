using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//делегат (delegate)
namespace Lab_9
{
    //делегат - указатель на методы, у которых совпадает сигнатура
    //сигнатура - название функции, её аргумент
    //объявляем класс сигнатуры. Мн-во функций, которые имеют одинаковую сигнатуру
    //объявляется мн-во сигнатур и объектам могут присвоить метод со сход сигнатурой
    delegate int A(int x, int y); //объявление класса сигнатур функций
    delegate void B();
    class Program
    {
        private static int Perimetr(int x1, int y1) //сигнатура соответствует
        {
            Console.WriteLine("Perimetr {0}", x1 + y1);
            return (x1 + y1)*2;
        }
        private static int Square(int x2, int y2) //сигнатура соответствует
        {
            Console.WriteLine("Square {0}", x2 * y2);
            return x2 * y2;
        }

        private static void Multicast(A apointer, int x, int y) //функция высокого порядка
        {
            apointer.Invoke(x, y);
        }
        static void Main(string[] args)
        {
            B b = delegate () { Console.WriteLine(" B b = delegate()"); };
            b();

            Console.WriteLine(" A s1 = new A(Perimetr)");
            A s1 = new A(Perimetr); //++ Создание с помощью конструктора

            A a = null; //а является полиморфной ссылкой на множество сигнатур данного класса
            a = Perimetr;
            A s2 = new A(a);
           
            Console.WriteLine();
            int result = a(5, 8);
            Console.WriteLine(" Периметр прямоугольника со сторонами x = 5, y = 8  равен {0}", result);
            b();

            Console.WriteLine();
            a = Square;
            Console.WriteLine(" Площадь прямоугольника со сторонами x = 3, y = 2 равна {0}", a(3, 2));
            b();

            Console.WriteLine();
            Console.WriteLine("a = delegate (int x, int y) { return x * x + y * y ;}");
            a = delegate (int x, int y) { return x * x + y * y ; }; //анонимный делегат
            Console.WriteLine(" Квадрат гипотенузы прямоугольного треугольника со сторонами x = 5, y = 2 равен {0}", a(5, 2));
            b();

            Console.WriteLine();
            Console.WriteLine("delegate as pointer");
            A apoiner = null;
            apoiner = Perimetr; //приписываю ссылку, использую как ссылку
            apoiner += Square; //инкременция ссылки. Указывает на две операции. Список apointer
            Console.WriteLine("result {0}", apoiner.Invoke(50, 10)); //выполняется всё, выводится последнее

            Console.WriteLine();
            apoiner -= Square;
            Console.WriteLine(" apoiner -= Square  = {0}", apoiner.Invoke(50, 10));
            apoiner += Square;
            Console.WriteLine(" apoiner += Square  = {0}", apoiner.Invoke(50, 10));
            apoiner -= Perimetr;
            Console.WriteLine(" apoiner -= Perimetr  = {0}", apoiner.Invoke(50, 10));

            apoiner += delegate (int x, int y) { return x * y; };
            Console.WriteLine(" apoiner += delegate (int x, int y)  return x * y; = {0}", apoiner.Invoke(50, 10));

            Console.WriteLine();
            Console.WriteLine("delegate as parametr");
            Multicast(apoiner, 80, 90);
            Console.ReadKey();
        }
        
    }
}
