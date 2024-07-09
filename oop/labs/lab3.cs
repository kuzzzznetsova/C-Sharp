using System;
using System.Threading;
namespace lab_3
{
    //определение класса
    class Dog //супер-класс (Definishion)
    {
        private int price = 20;
        public Dog() //спецификация (сигнатура)
        {
            //тело конструктора
            Console.WriteLine("constructor Dog(). this.pr = 20");
            this.pr = price;

        }

        ~Dog()
        {
            Console.WriteLine("distructor ~Dog()");
            Thread.Sleep(2000);
        }
        //замещаемая функция (определение замещаемой функции)
        public virtual int d_price()
        {
            Console.WriteLine("func class Dog d_price. pr + 10");
            return pr + 10;
        } //virtual для замещения функции
        protected int pr { set; get; }    //атрибут везде наследуется (атрибут доступа по умолчанию)

    }

    class Shpic : Dog // Shpic -> Dog
    {
        private int price = 30;
        public Shpic()
        {
            Console.WriteLine("constructor Shpic() . this.pr = 30; this.kol = 30");
            this.pr = price;
            this.kol = 30;
        }
        ~Shpic()
        {
            Console.WriteLine("distructor ~Shpic()");
            Thread.Sleep(2000);
        }
        //расширяю функцию, наследуемую классом Shpic из класса Dog
        public override int d_price()
        {
            Console.WriteLine("func class Shpic price_d(). pr + 100");
            return pr + 100;
        }//замещается 

        public virtual int s_kol()
        {
            Console.WriteLine("Func of class Shpic. kol + 150");
            return kol + 150;
        }
        protected int kol { get; set; }
    }

    class Pomeran : Shpic
    {
        private int price = 40;
        public Pomeran()
        {
            Console.WriteLine("constructor Pomeran(). this.pr = 40; this.kol = 20; this.size = 55");
            this.pr = price;
            this.kol = 20;
            this.size = 55;
        }
        ~Pomeran()
        {
            Console.WriteLine("distructor ~Pomeran()");
            Thread.Sleep(2000);
        }
        public override int d_price()
        {
            Console.WriteLine("func class Pomeran d_price(). pr + 1000");
            return pr + 1000;
        }//определение функции для замещения
        public virtual int p_size()
        {
            Console.WriteLine("Func of class Pomeran. size + 5;");
            return size + 5;
        }
        
        public override int s_kol()
        {
            Console.WriteLine("func class Shpic d_price(). kol + 50");
            return kol + 50;
        }
       
        protected int size { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3");
            Console.WriteLine("Принцип подстановки");
            //создаём обьект
            Console.WriteLine("step 1:");// сможем вывести только функции которые в доге
            Dog  pr = new Dog();   //полиморфная переменная
            Console.WriteLine("pr.d_price() = {0}", pr.d_price()); //вызываем метод d_price от обьекта класса Dog
            Console.WriteLine();

            pr = new Shpic(); //подстановка (объекта класса Dog в Shpic)
            Console.WriteLine("pr.d_price() = {0}", pr.d_price());
            //Замещённая функция (вместо супер-класса становится функцией подкласса)
            Console.WriteLine();

            pr = new Pomeran(); 
            Console.WriteLine("pr.d_price() = {0}", pr.d_price()); //замещение функции d_price
            Console.WriteLine();

            Console.WriteLine("проверка, является ли pr объектом класса Pomeran :");
            if (pr.GetType() == typeof(Pomeran)) //оператор typeof для определения типа
                Console.WriteLine("pr.GetType() == typeof (Pomeran)");
            else
                Console.WriteLine("pr.GetType() != typeof (Pomeran)");
            Console.WriteLine();

            {
                Pomeran c = new Pomeran(); // локальный объект
                int k = c.d_price();
                Console.WriteLine("k = {0} //локальный объект", k);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("step2:"); //сможем вывести функции которые в шпице
            Shpic sh = new Shpic();
            Console.WriteLine("sh.s_kol() = {0}", sh.s_kol());
            Console.WriteLine();

            sh = new Pomeran();
            Console.WriteLine("sh.s_kol() = {0}", sh.s_kol());
            Console.WriteLine("sh.d_price() = {0}", sh.d_price());
            Console.WriteLine();

            Pomeran p = new Pomeran(); //сможем вывести все функции померана
            Console.WriteLine("p.p_size() = {0}", p.p_size());
            Console.WriteLine("p.s_kol() = {0}", p.s_kol());
            Console.WriteLine("p.d_price() = {0}", p.d_price());

            Console.ReadKey();
        }
    }
}
