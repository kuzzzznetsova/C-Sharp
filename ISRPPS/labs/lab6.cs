using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lr_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            teacher.SetCommand(new Student_Command(student));
            teacher.Command_w();
            teacher.Command_r();
            teacher.Command_t();
            Console.Read();
        }
    }

    interface Homework//класс с командами
    {
        void Write();
        void Read();
        void Test();
    }

    // Receiver - Получатель
    class Student
    {
        public void write()
        {
            Console.WriteLine("Сделать письменно № 11.");
        }

        public void read()
        {
            Console.WriteLine("Прочитать и выучить правило.");
        }

        public void test()
        {
            Console.WriteLine("Подтовиться к тесту.");
        }
    }

    class Student_Command : Homework //
    {
        Student student;
        public Student_Command(Student tvSet)
        {
            student = tvSet;
        }
        public void Test()
        {
            student.test();
        }
        public void Write()
        {
            student.write();
        }
        public void Read()
        {
            student.read();
        }
    }

    // Invoker - инициатор
    class Teacher
    {
        Homework command;

        public Teacher() { }

        public void SetCommand(Homework com)
        {
            command = com;
        }

        public void Command_w()
        {
            if (command != null)
                command.Write();
        }
        public void Command_r()
        {
            if (command != null)
                command.Read();
        }
        public void Command_t()
        {
            if (command != null)
                command.Test();
        }
    }

}
