using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//лямбда выражение 
//анонимная фукция
namespace Lab_9._2
{
    delegate int Lambda(int rus, int mat, int inf);
    delegate void Lambda_OP();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №9_2");
            Console.WriteLine("Step 1 Lambda");
            Console.WriteLine("Сумма баллов ЕГЭ");
            //Lambda lambda = null;
            Lambda lambda = (rus, mat, inf) => { return rus + mat + inf; }; //применяем оператор => лямбда-выражения
            Console.WriteLine("Сумма баллов ЕГЭ (85, 82, 96) = {0} ", lambda(85, 82, 96));
            //разница между делегатами: не задаём конкретный тип параметров
            Lambda_OP print = () => Console.WriteLine("Закончили школу :-(");
            print();

            Console.WriteLine();
            Console.WriteLine("Step 2 использование Lambda");

            Lambda AnonDel = delegate (int rus1, int mat1, int inf1)
            {
                return rus1 + mat1 + inf1;
            };

            Func<string, string, string> stroka = (s1,s2) => s1 + s2;
            Console.WriteLine(stroka("МАИ-","лучший ВУЗ!"));


            Console.WriteLine();
            List<int> elements = new List<int>() {85, 82, 96};
            Console.WriteLine("Найдём максимальный балл:");
            int NetNum = elements.Find(x => x > 90);
            Console.WriteLine("NetNum = {0}", NetNum);

            Console.ReadKey();
        }
    }
}
