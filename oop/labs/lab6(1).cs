using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ассоциация (один к одному, один ко многим)
//не прослеживается четкой иерархии
//это двухсторооннее отношение (бинарное). Значит, что на графике пунктир - для ассоциации между двумя объектами. Там где пунктир (!)
//абстракция, когда мы определяем отношение между двумя объектами
namespace Lab_6
{
    //один к одному
    //ассоц. между двумя объектами разных классов
    class Doctor
    {
        public Doctor() { Console.WriteLine(" Doctor"); }
        public Doctor(Patient p) { this.p = p; Console.WriteLine(" constr Doctor "); }
        ~Doctor() { Console.WriteLine(" ~Doctor"); }
        //ассоциация делается по ссылке
        public void Fp() { Console.WriteLine("Patient: {0} {1} ", p.name, p.surname); }
        public Patient p = null; //атрибут имеет тип данных другого класса
        //с его помощью будут доступны функции, атрибуты и операции другого класса
        public string name = "Petr";
        public string surname = "Petrov";
    }
    class Patient
    {
        public Patient() { Console.WriteLine(" Patient"); }
        public Patient(Doctor d) { this.d = d; Console.WriteLine(" constr Patient"); }
        ~Patient() { Console.WriteLine(" ~Patient"); }
        public void Fd() { Console.WriteLine("Doctor: {0} {1} ", d.name, d.surname); }
        public Doctor d { set; get; }
        public string name = "Ivan";
        public string surname = "Ivanov";

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Лабораторная работа №6 ");
            Console.WriteLine(" Ассоциации (один к одному) ");
            Patient p = new Patient();
            Doctor d = new Doctor(p); //пока вышла связь только в одну сторону
            p.d = d; //теперь двухсторонняя

            Console.WriteLine(" d.Fp() = ");
            d.Fp(); // обращаемся к объекту p, атрибуту доступа d класса d 
            Console.WriteLine(" p.Fd() = ");
            p.Fd(); //один к одному

            Console.ReadKey();
        }
    }
}
