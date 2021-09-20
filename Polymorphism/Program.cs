using System;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Human human = new European();
            human.HumanInfo();

            human = new African();
            human.HumanInfo();

            Identify identify = new Identify();
            identify.Print(new Alien());

            Console.ReadKey();
        }
    }

    public class Human
    {
        public virtual void HumanInfo()
        {
            Console.WriteLine("No information");
        }
    }

    public class European : Human
    {
        public void HumanInfo()
        {
            Console.WriteLine("My name is John, Im 56 years old, Im from Britain");
        }
    }

    public class African : Human
    {
        public override void HumanInfo()
        {
            Console.WriteLine("My name is Zumba, I don't know how old I am, Im from Tanzania");
        }
    }

    public sealed class Alien : Human
    {
        public override sealed void HumanInfo()
        {
            base.HumanInfo();
            Console.WriteLine("My name is Alien-005, I do not have access to another database");
        }
    }

    public class Identify
    {
        public void Print(Human human)
        {
            human.HumanInfo();
        }
    }
}
