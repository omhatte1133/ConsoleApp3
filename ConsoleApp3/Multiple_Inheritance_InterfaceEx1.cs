using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public interface IFather1
    {
        void Teach(string sub, int hr);
        void Guid(string topic);
    }

    public interface IFather2
    {
        void Play(string game, int duration);
        void Encourage(string activity);
    }

    public class Child : IFather1, IFather2
    {
        public void Teach(string sub, int hr)
        {
            Console.WriteLine($"Child is learning {sub} for {hr} hours from father1");
        }
        public void Guid(string topic)
        {
            Console.WriteLine($"Child is guided on {topic} from father1");
        }
        public void Play(string game, int duration)
        {
            Console.WriteLine($"Child playing {game} for {duration} hours from father2");
        }
        public void Encourage(string activity)
        {
            Console.WriteLine($"Child encourage to do {activity} from father2");
        }
    }
    internal class Multiple_Inheritance_InterfaceEx1
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Teach("Math", 3);
            c.Guid("Determinants");
            c.Play("Cricket", 4);
            c.Encourage("To do hard work");

            Console.ReadLine();

        }
    }
}
