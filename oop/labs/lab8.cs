
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//конкретизация
//это переход от абстрактному к частному
//общее является шаблоны. Алгоритм общий, не зависимый от типа класса
//повторное использование алгоритма
//СВОП

namespace Lab_8
{
    class Post 
    {
        string adress;
        public Post(string adress) {
            this.adress = adress;
        }
        public void print()
        {
            Console.WriteLine(adress);
        }    
    }
    public interface IA // Postamat -> IA
    {
        void F();
    }
    class Postamat : IA
    {
        public void F() { Console.WriteLine("Leningradsky pr., d.76"); }
    }

    class U<T> where T : class
    {
        public U(T t) //конкретизация конструктора
        {
            if (t is IA) //конкретизация с ограничениями
            {
                Console.WriteLine("Посылку можно забрать из постамата.");
                this.t = t; //конкретизация атрибута
            }
            else
                Console.WriteLine("Постамата нет, нужно идти на почту.");
        }
        //public void F1() { Console.WriteLine("Забрать можно с 9:00 до 21:00"); }
        public T t { set; get; }
        public void F() //конкретизация метода
        {
            //
            Console.WriteLine(t is IA);
            //Console.WriteLine(t);
            if (t is IA)
            {
                IA ia = (IA)t;
                ia.F();
            }
            else Console.WriteLine("Постамата нет, нужно идти на почту.");
        }
    } //end class U
    class End<T1, T2> where T1 : class
                     where T2 : class //множественная конкретизация
    {
        public void f1(T1 t1, T2 t2)
        {
            Console.WriteLine("Посылку можно забрать на почте или через постамат.Забрать можно с 9:00 до 21:00.");
        }
    }
    class Swap //<T> //параметр Т. можно подставить А, В и даже С при желании
    {
        public Swap() { }
        public void FSwap(ref Post x, ref Post y) //берётся конкретно ссылка вне зоны действия операции
        //public void FSwap(Post x, Post y) берется ссылка по объекту
        {
            Post t = x; //А т - локальная переменная
            x = y;
            y = t;
        }
    }
    //конкретизация параметров функции
    class SwapT<T> where T: class  //конкретизируем T <- Классами. Конкретизация с ограничениями
                                   //предикат where. Вместо Т могу контекретизировать только классом
                                   //можем прописать структуру. Тогда будет ограничение 
    {
        public SwapT() { }
        //ref  для того, чтобы мы могли менять ссылки
        //он передаёт адреса в памяти
        public void FSwap(ref T x, ref T y) //конкретизация параметров функции
        {
            T t = x;
            x = y;
            y = t;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №8");
            Console.WriteLine("Конкретизация. Множественная конкретизация. Конкретизация с ограничениями (операция is).");
            Swap swap = new Swap();
            Post a1, a2 = null;
            a1 = new Post("ul.Kirova 21");
            a2 = new Post("pr.Lenina 44");
            a1.print();
            a2.print();
            Console.WriteLine();

            swap.FSwap(ref a1, ref a2); // подставляем объекты
            a1.print();
            a2.print();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("  Step 1");

            SwapT<Post> swapt = new SwapT<Post>();
            swapt.FSwap(ref a1, ref a2); //берём адрес этих объектов
            a1.print();
            a2.print(); 
            
            //SwapT<int> swaptI = new SwapT<int>(); //с ограничениями не получится
            //int a_1 = 5; int a_2 = 6;
            //swapt.FSwap(ref a_1,ref a_2);// не можем взять целочисленные значения

            Console.WriteLine();
            Console.WriteLine("  Step 2");
            U<Post> ua = new U<Post>(a1);
            ua.F();
            Console.WriteLine();

            Console.WriteLine("  Step 2.1");
            U<Postamat> ud = new U<Postamat>(new Postamat());
            ud.F();
            Console.WriteLine();

            Postamat d1 = new Postamat();
            U<Postamat> ud_1 = new U<Postamat>(d1);
            ud_1.F();
            Console.WriteLine();

            End<Postamat, Post> l = new End<Postamat, Post>();
            l.f1(d1, a1);

            Console.ReadKey();
        }
    }
}
