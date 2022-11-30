using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Examples
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            Programmer p = new Programmer();
            p.Work();
            p.Rest();
            // Wait for user 
            Console.Read();
        }
    }


    // "Subsystem ClassA" 
    class Write
    {
        public void WriteCode()
        {
            Console.WriteLine("writting code");
        }
    }

    // Subsystem ClassB" 
    class Read
    {
        public void ReadDocumentation()
        {
            Console.WriteLine("reading documentation");
        }
    }


    // Subsystem ClassC" 
    class Eat
    {
        public void EatPizza()
        {
            Console.WriteLine("eating pizza");
        }
    }
    // Subsystem ClassD" 
    class Play
    {
        public void PlayGame()
        {
            Console.WriteLine("playing game");
        }
    }
    // "Facade" 
    class Programmer
    {
        Write write;
        Read read;
        Eat eat;
        Play play;

        public Programmer()
        {
            write = new Write();
            read = new Read();
            eat = new Eat();
            play = new Play();
        }

        public void Work()
        {
            Console.WriteLine("\nWork() ---- ");
            write.WriteCode();
            read.ReadDocumentation();
        }

        public void Rest()
        {
            Console.WriteLine("\nRest() ---- ");
            eat.EatPizza();
            play.PlayGame();
        }
    }
}
