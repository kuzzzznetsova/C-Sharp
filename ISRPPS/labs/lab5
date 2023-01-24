using System;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea_bag tea_bag = new Tea_bag();
            Water water = new Water();
            Sugar sugar = new Sugar();

            VisualStudioFacade fa = new VisualStudioFacade(tea_bag, water, sugar);

            Human human = new Human();
            human.CreateApplication(fa);

            Console.Read();
        }
    }
    // текстовый редактор
    class Tea_bag
    {
        public void Get_cup()
        {
            Console.WriteLine("Достать чашку");
        }
        public void Put_tea()
        {
            Console.WriteLine("Положить в чашку чайный пакетик");
        }
    }
    class Water
    {
        public void Add_water()
        {
            Console.WriteLine("Налить кипяток");
        }
    }
    class Sugar
    {
        public void Add_sugar()
        {
            Console.WriteLine("Добавить сахар");
        }
        public void Mix()
        {
            Console.WriteLine("Перемешать");
        }
    }

    class VisualStudioFacade
    {
        Tea_bag tea_bag;
        Water water;
        Sugar sugar;
        public VisualStudioFacade(Tea_bag tee, Water water, Sugar sugar)
        {
            this.tea_bag = tee;
            this.water = water;
            this.sugar = sugar;
        }
        public void Start()
        {
            tea_bag.Get_cup();
            tea_bag.Put_tea();
            water.Add_water();
            sugar.Add_sugar();
            sugar.Mix();
        }
    }

    class Human
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
        }
    }
}
