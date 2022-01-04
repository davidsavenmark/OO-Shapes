using System;
namespace OO_Shapes
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract override string ToString();

        public virtual void SayHello(string greeting)
        {
            Console.WriteLine($"{this.GetType().Name} says hello!");
        }

        public virtual void ScreamHello()
        {
            Console.WriteLine($"{this.GetType().Name.ToUpper()} SCREAMS HELLO!");
        }
    }
}
