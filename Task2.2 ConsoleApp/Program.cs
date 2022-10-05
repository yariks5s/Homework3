using System;
using System.Collections.Generic;

namespace Task2._2


{
    public abstract class Worker
    {

        protected Worker(string name)
        {
            Name = name;
        }

        public string Name, Position, Workday;

        protected void Call()
        {
            Console.WriteLine("Calling...");
        }
        protected void WriteCode()
        {
            Console.WriteLine("Writing the code...");
        }
        protected void Relax()
        {
            Console.WriteLine("Relaxing...");
        }

        public abstract void FillWorkDay();
    }

    class Developer : Worker
    {
        public Developer(string name) : base(name)
        {
            Position = "Розробник";
        }
        
        public override void FillWorkDay()
        {
            WriteCode();
            Call();
            Relax();
            WriteCode();
            Workday = "WriteCode() Call() Relax() WriteCode()";
        }
    }

    class Manager : Worker
    {
        public Manager(string name) : base(name)
        {
            Position = "Менеджер";
        }

        private Random _rnd = new Random();
        
        public override void FillWorkDay()
        {
            Workday = "";
            for (var i = 0; i < _rnd.Next(1, 10); i++)
            {
                Call();
                Workday += "Call() ";
            }
            Relax();
            Workday += "Relax() ";
            for (var i = 0; i < _rnd.Next(1, 5); i++)
            {
                Call();
                Workday += "Call() ";
            }
        }
    }

    class Team
    {
        protected string Name;
        
        public Team(string name)
        {
            Name = name;
        }
    
        List<Worker> _listOfWorkers = new List<Worker>();
        
        public void AddMember(Worker bob)
        {
            _listOfWorkers.Add(bob);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name of the Team: {0}", Name);
            Console.WriteLine("Here's the list of the workers:");
            Worker[] temp = _listOfWorkers.ToArray();
            foreach (var t in temp)
            {
                Console.WriteLine(t.Name);
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine("Name of the Team: {0}", Name);
            Console.WriteLine("Here's the list of the workers:");
            Worker[] temp = _listOfWorkers.ToArray();
            foreach (var t in temp)
            {
                Console.WriteLine("{0}-{1}-{2}", t.Name, t.Position, t.Workday);
            }
        }
    }
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Manager yarik = new Manager("Yaroslav");
            Developer olexandr = new Developer("Olexandr");
            Team k27 = new Team("K27");
            k27.AddMember(yarik);
            k27.AddMember(olexandr);
            Console.WriteLine("Work day of Yarik:");
            yarik.FillWorkDay();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Work day of Olexandr:");
            olexandr.FillWorkDay();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Info about Team:");
            k27.ShowInfo();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Details about team:");
            k27.ShowDetails();
            Console.WriteLine("-------------------------");
        }
    }
}