using System;
//Наследование: расширение, спецификация, специализация, конструирование, (комбинирование во втором проекте)

namespace Lab_4
{
    class Films
    {
        public Films()
        {
            Console.WriteLine("constr Films(), this.pr = 100");
            this.pr = 100;
        }
        ~Films()
        {
            Console.WriteLine(" destr Films()");
        }
        public virtual int f_price() { 
            Console.WriteLine("class Films f_price(). return pr + 10 ");
            return pr + 10; 
        }
        public int Filmspr
        {
            set { Console.Write("set"); }
            get { Console.Write("get"); return pr; }
        }
        protected int pr = 1;
    }
    class Romantic : Films    //расширение
    {
        public Romantic()
        {
            Console.WriteLine("constr Romantic(), this.pr = 200, this.y = 2015, this.y1 = 1999");
            this.pr = 200;
            this.y = 2015;
            this.y1 = 1999;
        }
        ~Romantic()
        {
            Console.WriteLine("destr Romantic()");
        }
        public int r_price_of_year()
        {
            Console.WriteLine("class  Romantic r_price_of_year(). return pr + y/100 + 10");
            return pr + y/100 + 10;
        }
        protected int y { set; get; }
        public int y1 { set; get; }

    }
    class Drama : Romantic     //специализация   
    {
        public Drama()
        {
            Console.WriteLine("constr Drama(). this.pr = 250");
            this.pr = 250;
        }
        public override int f_price() { 
            Console.WriteLine("class Drama f_price()"); 
            return pr + 50; 
        }
        ~Drama()
        {
            Console.WriteLine("destr Drama()");
        }
    }
  
    abstract class Horror
    {
        abstract public int h_top();
        public void print() { Console.WriteLine("class Horror print"); }
        public int Horrorh
        {
            set { Console.Write(""); }
            get { Console.Write("get"); return h; }
        }
        protected int h = 1;
    }
    
    class Zombi : Horror         //спецификация
    {
        public Zombi() { 
            Console.WriteLine("constr Zombi(). this.h = 10");
            this.h = 10; 
        }
        public override int h_top()
        {
            Console.WriteLine("class Zombi h_top(). return h * 2");
            return h * 2;
        }
    }
    class Psyho: Horror         //спецификация
    {
        public Psyho()
        {
            Console.WriteLine("constr Psyho(). this.h = 20");
            this.h = 20;
        }
        public override int h_top()
        {
            Console.WriteLine("class Psyho h_top(). return h * 3");
            return h * 3;
        }
    }

    class Reznya : Horror         //спецификация
    {
        public Reznya()
        {
            Console.WriteLine("constr Reznya(). this.h = 30");
            this.h = 30;
        }
        public override int h_top()
        {
            Console.WriteLine("class Reznya h_top(). return h * 4");
            return h * 4;
        }
    }
    interface Comedy // можно писать только функции, по опр все паблик, атрибуты нельзы определять
    {               // Интерфейс наследуется только от интерфейса!!!!!!!!!
        int cj_1(); // Нельзя абстр!!! Виртуальные по определению
        int cj_2();
        //int Fj() { return 0; } // оверрайт не пишем, такая сигнатура
        // public недопустим!!!!!
    }
    class Comedy1 : Comedy    //спецификация 
    {
        public Comedy1() { Console.WriteLine("constr Comedy1()"); }
        public int cj_1() { return 280; }
        public int cj_2() { return 290; }
    }
    class Happy_end : Romantic //комбинирование
    {
        public Happy_end() { Console.WriteLine("constr Happy_end()"); }
        public override int f_price() { Console.WriteLine("Not Happy end..."); return 0; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №4");
            Console.WriteLine("Наследование: расширение, спецификация, специализация, конструирование и комбинирование");
            Films pr = new Films();
            Console.WriteLine("pr.f_price() = {0}", pr.f_price());
            Console.WriteLine();

            // Расширение по функции
            Console.WriteLine(" Расширение по функции");
            pr = new Romantic();
            Console.WriteLine("((Romantic)pr).r_price_of_year () = {0}", ((Romantic)pr).r_price_of_year());
            Console.WriteLine();

            // Расширение по аргументу
            Console.WriteLine(" Расширение по аргументу");
            Console.WriteLine("((Romantic)pr).y1 () = {0}", ((Romantic)pr).y1);
            Console.WriteLine();

            Console.WriteLine(" Спецификация : абстрактный класс");
            Horror h = null; 
            //Спецификация : абстрактный класс
            h = new Zombi();
            Console.WriteLine("h.h_top() = {0}", h.h_top());
            Console.WriteLine();

             //Спецификация : абстрактный класс
            h = new Psyho();
            Console.WriteLine("h.h_top() = {0}", h.h_top());
            Console.WriteLine();

            //Спецификация : абстрактный класс
            h = new Reznya();
            Console.WriteLine("h.h_top() = {0}", h.h_top());
            Console.WriteLine();

            Console.WriteLine(" Спецификация : интерфейс");
            Comedy c = null; //Спецификация : интерфейс
            c = new Comedy1();
            Console.WriteLine("c.cj_1() = {0}", c.cj_1());
            Console.WriteLine("c.cj_2() = {0}", c.cj_2());
            Console.WriteLine();

            Console.WriteLine(" Специализация");
            pr = new Drama(); //Специализация
            Console.WriteLine("pr.f_price() = {0}", pr.f_price());
            Console.WriteLine();



            Console.WriteLine(" Конструирование"); 
            pr = new Happy_end();
            Console.WriteLine("pr.f_price() = {0}", pr.f_price());
            

            Console.ReadKey();

        }
    }
}
