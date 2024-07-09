using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//event
//
//ассоциации. Один ко многим
namespace Lab_9_3
{
    public class Message : EventArgs //нужен чтобы передать сообщение каждому подписчику
    {
        public string message { set; get; }
        public Message(string message) : base()
        {
            this.message = message;
        }
    }
    public class Boss
    {
        public delegate void PublisherEventHanler(Message message);
        public delegate void EventHandler(Object sender, EventArgs args);
        public event PublisherEventHanler Changed; // +=

        public Boss() { }
        public void EventForPublisher(Message message)
        {
            Console.WriteLine(" Внимание! {0}", message.message);
            Changed(message);
        }
    }
    public class Worker
    {
        int Id { set; get; }
        string name { set; get; }
        public Worker(int Id, string name)
        {
            this.Id = Id;
            this.name = name;
        }

        public void worker(Message message) //+= операция для подписки
        {
            Console.WriteLine(" Worker {0}  {1} {2}", this.Id, this.name, message.message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Лабораторная работа №9_3");

            //step 1
            Boss boss = new Boss();
            Worker subscriber_1 = new Worker(1, "Artem");
            Worker subscriber_2 = new Worker(2, "Mark");
            Worker subscriber_3 = new Worker(3, "Lida");

            //step 2 worker подписка
            boss.Changed += subscriber_1.worker;
            boss.Changed += subscriber_2.worker;
            boss.Changed += subscriber_3.worker;

            //step 3
            boss.EventForPublisher(new Message("Закрываемся на карантин"));

            Console.ReadKey();
        }
    }
}
