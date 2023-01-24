using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public interface Films
    {
        void ff();
        int F_year();
    }
    public interface Actor : Films
    {
        void fa();
        int Fa();
    }

    public class Romantic : Films
    {
        public Romantic() { Console.WriteLine(" Сonstr Romantic"); this.year= 2015; }
        public Romantic(int year) { this.year = year; Console.WriteLine(" Constr Romantic year"); }
        public Romantic(int year, int min) { this.year = year; this.min = min; Console.WriteLine(" Constr 2 Romantic year"); }
        public virtual void ff() { Console.WriteLine(" method Films in class Romantic"); }
        public virtual int F_year() { return 2021 - this.year; } //выводит сколько лет фильму
        public int year { set; get; }
        protected int min { set; get; }
        protected int Fromantic(int year) { return this.year; }
    }

    public class Yolky: Romantic, Actor
    {
        //конфликт имён при множественном наследовании
        public Yolky() { Console.WriteLine(" constr Yolky"); this.part = 1; this.year = 2010; }
        public Yolky(int part) : base(part)
        {
            this.part = part;
            this.min = part * 20 +  50;
            Console.WriteLine(" constr Yolky");
        }
        //значение передается в конструктор Yolky. Значения параметра конструктора производного класса, передаётся в конструктор базового класса.
        public Yolky(int part, int year) : base(part) { this.part = part; this.year = year; Console.WriteLine(" constr Yolky"); }
        //base - когда записываем параметр через конструктор, то он передается в супер класс
        //забыли написать? не будет передан параметр в суперкласс, не проинициализируется
        //вызовется без параметров
        public override int F_year() { return 2021 - this.year; }
        public int part { set; get; }
        public int Fa() { return this.part * 10; }// но номеру фильма определяет кол-во героев
        public void fa() { Console.WriteLine(" Method Actor in class Yolky"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №5");
            Console.WriteLine("Наследование: комбинирование через общих предков");
            Films f = null;
            //a.fa();
            Console.WriteLine();
            f = new Romantic(); //в ин-с Films передаём указатель на объект класса Romantic
            Console.WriteLine("Сколько лет фильму: f.F_year() = {0}", f.F_year());//должно вывести 6
            Console.WriteLine();
            f = new Yolky(); //в ин-с Films передаём указатель на объект класса Yolky
            Console.WriteLine("Сколько лет фильму Ёлки1: f.F_year() = {0}", f.F_year()); //должно вывести 11
            Console.WriteLine();
            f = new Yolky(2, 2011);//просто вызов конструктора
            Console.WriteLine("Сколько лет фильму Ёлки2: f.F_year() = {0}", f.F_year());//должно вывести 7
            Console.WriteLine("----");

            //комбинирование
            Actor a = new Yolky();
            Console.WriteLine(" a.Fa() = {0}", a.Fa()); //10
            a.fa();
            Console.WriteLine(" a.F_year() + a.Fa() = {0}", a.F_year() + a.Fa()); //кол-во лет фильму+ герои
            Console.WriteLine("----");

            //преобразование объекта c в Actor
            Yolky y = new Yolky();
            Console.WriteLine(" y.Fa() = {0}", y.F_year());//4
            Console.WriteLine("----");
            Console.WriteLine(" ((Actor)y).F_year() = {0}", ((Actor)y).F_year()); //преобразование типа ссылки с к типу В
            Console.WriteLine("----");

            //в А
            Console.WriteLine(" f = {0}", ((Films)((Actor)y)).F_year());
            //созданные объекты с помощью конструктора Yolky разные, потому что по-разному проинициализированы
            Actor a1 = new Yolky();
            Films f1 = new Yolky();
            Console.WriteLine(" a1.F_year() = {0}", a1.F_year());
            Console.WriteLine(" f1.F_year() = {0}", f1.F_year());
            Console.WriteLine(" a1.Fa() = {0}", a1.Fa());
            Console.WriteLine(" ((Actor)f1).Fa() = {0}", ((Actor)f1).Fa());
            Console.WriteLine("----");

            Console.Write(" ((Actor)a).fa() - ");
            ((Actor)f).fa();
            Console.Write(" ((Yolky)a).fa() - ");
            ((Yolky)f).fa();
            Console.Write(" ((Yolky)a).fa() - ");
            ((Yolky)f).fa();

           // Yolky y = new Yolky();

            Console.WriteLine();
            Console.WriteLine(" step 2");

            Yolky y1 = new Yolky(3);
            Console.WriteLine(" part = {0}", y1.part);
           // Console.WriteLine(" d = {0}", y1.year);

            Console.ReadKey();
        }
    }
}
