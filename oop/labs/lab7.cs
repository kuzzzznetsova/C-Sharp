using System;
//использование
//клиент (использует ресурсы) - сервер (ресурсы - атрибуты, функции, методы и т.д) 
//иерархия подчинения
//клиент-утилита применяется 

//две разные версии: клиент-сервер и клиент-утилита
namespace Lab_7
{
    // Human -> Shop use
    class Human //client
    {
        public Human() { Console.WriteLine(" constr Human"); }
        public void fh(Shop s) //параметр - объект класса сервера //запрос к серверу
        {
            Console.WriteLine(" Поиск товара в интернет магазине: ");
            // В классе Human используется атрибут s и функция, принадлежащие классу Shop
            this.h = s.shop1() + s.shop2(5)+Shopss.shop3();
            Console.WriteLine(" Всего филиалов магазина: this.h = {0}", h);
            Console.WriteLine(" Shopss.shop2() = {0}", Shopss.shop2(5)); //утилита из Shopss static
            Console.WriteLine(" Shopss.shop3() = {0}", Shopss.shop3()); //утилита из Shopss static
            Console.WriteLine(" Shop.onlyne() = {0}", Shop.onlyne());// из Shop но static!!!
        }
        private int h { set; get; }
    }
    class Shop //server
    {
        public int k = 3;
        public Shop() { Console.WriteLine(" constr Shop"); }
        public int shop1() { return 3; }
        public int shop2(int k) { return 4*k; }
        public static int onlyne() { return 100; } //можно обратиться не создавая объект
        public void ms() //из сервера можно вызвать статич. ф. сервера
        {
            Console.WriteLine("class Shopss function shop2 = {0}", Shopss.shop2(k));
            Console.WriteLine("class Shopss function shop3 = {0}", Shopss.shop3());
        }
    }

    //клиент утилита в одном классе набор функций методов, операций, без атрибутов, сама ф-я статич
    static class Shopss
    {
        public static int shop2(int k) { return 4*k; } //можем вызывать от класса утилиты, а не от объекта класса
        //static - метод, который не зависит от объекта класса. Он общий для всего класса
        //метод, для которого не нужно создавать объект.
        public static int shop3() { return 10; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human(); // client
            Shop s = new Shop(); // server
            h.fh(s);

            Console.WriteLine("Static");//из сервера вызываем функции из Сервера и Сервиса
            Console.WriteLine("Shopss.shop2() = {0}", Shopss.shop2(5));
            Console.WriteLine("Shopss.shop3() = {0}", Shopss.shop3());
            Console.WriteLine("Shop.onlyne() = {0}", Shop.onlyne());
            Console.WriteLine();
            s.ms(); //через объект s вызываем статич. функции Shopss

            Console.ReadKey();
        }
    }
}
