using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    //один ко многим. Связываем объект одного класса с несколькими объектами другого класса

    //1:N
    class Team
    {
        public Team()
        {
            this.size = 0;
            this.p = new Player[N];
           // Console.WriteLine(" constr Team ");
        }
        ~Team() { Console.WriteLine(" ~Team"); }
        private Player[] p = null;
        public Player eA
        {
            set
            {
                if (size < N)//если size < N , то добавляем новый узел
                {
                    this.p[size] = value;
                    size++;
                }
                else Console.WriteLine("size >= N");
            }
            get { return this.p[--size]; }
        }
        //массив располагается 
        //один ко многим в объекте К. Со стороны одного
        //public int size { set; get; }
        public int size = 0;
        private int N = 5;
        public string name_team = "MAXIMUM";
        public void ft() { Console.WriteLine("Team: {0}", name_team); }
    }
    class Player
    {
        //public Player() { Console.WriteLine(" Player"); }
        // public Player(Team d) { this.d = d; Console.WriteLine(" constr Player"); }
        ~Player() { Console.WriteLine(" ~Player"); }
        public Team t { set; get; }
        public string name1 = "Alexey";
        public string name2 = "Artem";
        public string name3 = "Maxim";
        public string name4 = "Dmitry";
        public string name5 = "Nikita";
        public void fp1() { Console.WriteLine("{0}", name1); }
        public void fp2() { Console.WriteLine("{0}", name2); }
        public void fp3() { Console.WriteLine("{0}", name3); }
        public void fp4() { Console.WriteLine("{0}", name4); }
        public void fp5() { Console.WriteLine("{0}", name5); }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Лабораторная работа №6");
            Console.WriteLine("Ассоциации (один ко многим) ");
            Team t = new Team();
            Player p1 = new Player();
            Player p2 = new Player();
            Player p3, p4, p5 = null;
            p3 = new Player();
            p4 = new Player();
            p5 = new Player();

            t.eA = p1; t.eA = p2; t.eA = p3; t.eA = p4; t.eA = p5;
            //Console.WriteLine("t.eA.fp() = ");


            t.eA.fp1();
            p1.t = t;
            p1.t.ft();

            t.eA.fp2();
            p2.t = t;
            p2.t.ft();

            t.eA.fp3();
            p3.t = t;
            p3.t.ft();

            t.eA.fp4();
            p4.t = t;
            p4.t.ft();

            t.eA.fp5();
            p5.t = t;
            p5.t.ft();

            Console.ReadKey();
        }
    }
}
