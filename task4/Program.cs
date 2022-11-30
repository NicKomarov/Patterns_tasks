using System;
using System.Text;

namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Create ConcreteComponent and two Decorators
            ConcreteChristmasTree t = new ConcreteChristmasTree();
            ChristmasBall b = new ChristmasBall();
            Garland g = new Garland();

            // Link decorators
            b.SetComponent(t);
            g.SetComponent(t);
            b.Operation();
            g.Operation();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class ChristmasTree
    {
        public abstract void Operation();
    }

    // "ConcreteComponent"
    class ConcreteChristmasTree : ChristmasTree
    {
        public override void Operation()
        {
            Console.WriteLine("На ялинку додали прикрасу: ");
        }
    }
    // "Decorator"
    abstract class Decorator : ChristmasTree
    {
        protected ChristmasTree christmasTree;

        public void SetComponent(ChristmasTree tree)
        {
            christmasTree = tree;
        }
        public override void Operation()
        {
            if (christmasTree != null)
            {
                christmasTree.Operation();
            }
        }
    }

    // "ConcreteDecoratorA"
    class ChristmasBall : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "шарик";
            Console.WriteLine(addedState);
        }
    }

    // "ConcreteDecoratorB" 
    class Garland : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("гірлянда");
            AddedBehavior();
        }
        void AddedBehavior()
        {
            Console.WriteLine("Тепер ялинка може світитися!");
        }
    }
}