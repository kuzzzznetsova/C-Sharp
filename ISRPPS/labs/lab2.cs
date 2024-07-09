using System;

namespace lab2
{
    abstract class Create_pers
    {
        public abstract Beauty Create_Face();
        public abstract Power Create_Body();
        public abstract Power Create_Weapon();
    }
    class ConcretePers1 : Create_pers
    {
        public override Beauty Create_Face()
        {
            return new Hair();

        }
        public override Power Create_Body()
        {
            return new Hand();
        }
        public override Power Create_Weapon()
        {
            return new Weapon();

        }
    }
    class ConcretePers2 : Create_pers
    {
        public override Beauty Create_Face()
        {
            return new Eyes();

        }
        public override Power Create_Body()
        {
            return new Leg();
        }
        public override Power Create_Weapon()
        {
            return new Weapon();
        }
    }


    abstract class Power {}
    abstract class Beauty {}
    class Hand : Power { 
        public Hand()
        {
            Console.WriteLine("Сила: Супер-руки!");
        }
    
    }
    class Leg : Power {
        public Leg()
        {
            Console.WriteLine("Сила: Быстрые ноги!");
        }
    }
    class Weapon : Power {
        public Weapon()
        {
            Console.WriteLine("Оружие: Автомат");
        }
    }
    class Hair : Beauty {
        public Hair()
        {
            Console.WriteLine("Внешность: Русые волосы");
        }
    }
    class Eyes : Beauty {
        public Eyes()
        {
            Console.WriteLine("Внешность : Зеленые глаза");
        }
    }

    class Human
    {
        private Power abstractPower; //агрегация по значению
        private Beauty abstractBeauty;
        public Human(Create_pers pers) //мы не можем передать объект класса Create_pers, тк он абстрактный 
        {
            abstractBeauty = pers.Create_Face();
            abstractPower = pers.Create_Body();
            abstractPower = pers.Create_Weapon();
        }

        public void Run() {}
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laba №2!");
            Console.WriteLine("Создать персонажей:");
            ConcretePers1 pers1 = new ConcretePers1();
            ConcretePers2 pers2 = new ConcretePers2();
            Console.WriteLine("Создаём первого персонажа:");
            Human human1 = new Human(pers1);

            Console.WriteLine("Создаём второго персонажа:");
            Human human2 = new Human(pers2);

        }
    }
}
