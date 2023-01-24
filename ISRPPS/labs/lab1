using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laba №1");
            Human human = new Human();
            human.Day("2 апреля 2002 года");
            Console.WriteLine("Мой День Рождения:");
            Console.WriteLine(human.Birthday.State);
            Console.WriteLine("Попробуем поменять дату рождения...");
            // у нас не получится изменить Birthday, так как объект уже создан    
            human.Birthday = Birthday.getInstance("29 октября 2002 года");
            Console.WriteLine(human.Birthday.State);
            Console.WriteLine("Не получилось :-(...");

            Console.ReadLine();
        }
    }
    class Human
    {
        public Birthday Birthday { get; set; }
        public void Day(string date)
        {
            Birthday = Birthday.getInstance(date);
        }
    }
    class Birthday
    {
        private static Birthday instance;

        public string State { get; private set; }

        protected Birthday(string state)
        {
            this.State = state;
        }

        public static Birthday getInstance(string state)
        {
            if (instance == null)
                instance = new Birthday(state);
            return instance;
        }
    }
}
