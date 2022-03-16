using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    //Агрегация по ссылке
    class School
    {
        private Сanteen canteen = null;
        private Rooms rooms = null;
        private Gym gym = null;
        public School(Сanteen сanteen, Rooms rooms, Gym gym)
        {
            this.canteen = сanteen;
            this.rooms = rooms;
            this.gym = gym;
        }

        public void mSchool()
        {
            Console.WriteLine(" Добро пожаловать в Школу №33");
        }
        public Сanteen canteenSchool
        {
            set { Console.WriteLine("set canteen"); canteen = value; }
            get { Console.Write(" хотим есть? --> "); return canteen; }
        }
        public Rooms roomsSchool //атрибут доступа к атрибутам
        {
            set { Console.WriteLine("set rooms"); rooms = value; }
            get { Console.Write(" ищем кабинет --> "); return rooms; }
        }
        public Gym gymSchool
        {
            set { Console.WriteLine("set gym"); gym = value; }
            get { Console.Write(" ищем спортзал --> "); return gym; }
        }
    }
    class Сanteen
    {
        private Buffet buffet = null;
        public Сanteen(Buffet buffet)
        {
            this.buffet = buffet;
        }

        public void mCanteen()
        {
            Console.WriteLine(" кушаем в столовой ");
        }
        public Buffet buffetSchool
        {
            set { Console.WriteLine("set buffet "); buffet = value; }
            get { Console.Write(" идём в буфет --> "); return buffet; }
        }
    }

    class Rooms
    {
        private Director director = null;
        private Students students = null;
        private Medic medic = null;
        public int cq { get; set; }
        public Rooms(Director director, Students students, Medic medic)
        {
            this.director = director;
            this.students = students;
            this.medic = medic;
        }

        public void mRooms()
        {
            Console.WriteLine(" пришли в кабинет ");
        }
        public Director directorSchool
        {
            set { Console.WriteLine(" set director"); director = value; }
            get { Console.Write(" идём в кабинет директора --> "); return director; }
        }
        public Students studentsSchool
        {
            set { Console.WriteLine("set students"); students = value; }
            get { Console.Write(" идём в кабинет математики --> "); return students; }
        }
        public Medic medicSchool
        {
            set { Console.WriteLine("set medic"); medic = value; }
            get { Console.Write(" идём в мед. кабинет --> "); return medic; }
        }
    }
    class Buffet
    {
        public Buffet() { }

        public void mBuffet()
        {
            Console.WriteLine("объелись пирожными в буфете");
        }
    }

    class Director
    {
        public Director() { }

        public void mDirector()
        {
            Console.WriteLine(" мы у директора ");
        }
    }
    class Students
    {
        public Students() { }

        public void mStudents()
        {
            Console.WriteLine(" пришли в кабинет математики");
        }
    }
    class Gym
    {
        public Gym() { }

        public void mGym()
        {
            Console.WriteLine(" качаемся в зале");
        }
    }
    class Medic
    {
        public Medic() { }

        public void mMedic()
        {
            Console.WriteLine(" нас вылечили! :-)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Лабораторная работа № 1 ");
            Console.WriteLine(" Агрегация по ссылке ");
            Buffet buffet = new Buffet();
            Director director = new Director();
            Students students = new Students();
            Gym gym = new Gym();
            Medic medic = new Medic();
            Сanteen canteen = new Сanteen(buffet);
            Rooms rooms = new Rooms(director, students, medic);
            School school = new School(canteen, rooms, gym);

            school.mSchool();
            school.gymSchool.mGym();
            school.roomsSchool.mRooms();
            school.canteenSchool.mCanteen();
            school.canteenSchool.buffetSchool.mBuffet();
            school.roomsSchool.directorSchool.mDirector();
            school.roomsSchool.studentsSchool.mStudents();
            school.roomsSchool.medicSchool.mMedic();
            Console.ReadKey();
        }
    }
}
