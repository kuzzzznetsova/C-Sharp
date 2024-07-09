using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //Агрегация по значению вложениями 
    class School
    {
        public School() { }
        public class Сanteen
        {
            public Сanteen() { }
            public class Buffet
            {
                public Buffet() { }
                public void mBuffet() { Console.WriteLine(" объелись пирожными в буфете"); }
            }
            public void mСanteen() { Console.WriteLine("кушаем в столовой"); }

            public Buffet buffetSchool { get { Console.Write("идём в буфет --> "); return buffet; } }

            private Buffet buffet = new Buffet();

        }

        public class Rooms
        {
            public Rooms() { }
            ~Rooms() { }
            public class Director
            {
                public Director() { }
                public void mDirector() { Console.WriteLine(" мы у директора"); }
            }

            public class Students
            {
                public Students() { }
                public void mStudents() { Console.WriteLine(" мы в кабинете математики"); }
            }


            public class Medic
            {
                public Medic() { }
                public void mMedic() { Console.WriteLine(" нас вылечили"); }
            }


            public void mRooms() { Console.WriteLine("нашли нужный кабинет"); }

            public Director directorSchool { get { Console.Write(" идём в кабинет директора --> "); return director; } }
            public Students studentsSchool { get { Console.Write(" идём в кабинет математики --> "); return students; } }
            public Medic medicSchool { get { Console.Write(" идём в мед. кабинет --> "); return medic; } }

            private Director director = new Director();
            private Students students = new Students();
            private Medic medic = new Medic();
        }



        public class Gym
        {
            public Gym() { }
            public void mGym() { Console.WriteLine(" качаемся в зале"); }
        }


        public void mSchool() { Console.WriteLine("Добро пожаловать в школу №33"); }
        public Сanteen canteenSchool { get { Console.Write("хотим кушать? --> "); return canteen; } }
        public Rooms roomsSchool { get { Console.Write("ищем кабинет --> "); return rooms; } }
        public Gym gymSchool { get { Console.Write("ищем спортзал --> "); return gym; } }

        private Сanteen canteen = new Сanteen ();
        private Rooms rooms = new Rooms();
        private Gym gym = new Gym();
    }
 



 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Лабраторная работа №2");
            Console.WriteLine(" Агрегация по значению вложениями");
            School school = new School();
            school.mSchool();
            school.canteenSchool.mСanteen();
            school.roomsSchool.mRooms();
            school.gymSchool.mGym();

            school.canteenSchool.buffetSchool.mBuffet();

            school.roomsSchool.directorSchool.mDirector();
            school.roomsSchool.studentsSchool.mStudents();
            school.roomsSchool.medicSchool.mMedic();

            Console.ReadKey();

        }
    }
}
