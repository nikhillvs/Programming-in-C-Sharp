using System;

namespace SingleInheritance
{
    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing Started");
        }
    }

    public class Rectangle : Shape
    {
        public override void draw()
        {
            base.draw();
            Console.WriteLine("Drawing Rectangle");
        }
    }

    public class Square : Shape
    {
        public override void draw()
        {
            base.draw();
            Console.WriteLine("Drawing Square");
        }
    }

    public class Circle : Shape
    {
        public override void draw()
        {
            base.draw();
            Console.WriteLine("Drawing Circle");
        }
    }

    public class Triangle : Shape
    {
        public override void draw()
        {
            base.draw();
            Console.WriteLine("Drawing Triangle");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            Shape s;

            Console.WriteLine("1. Rectangle\n2. Square\n3. Circle\n4. Triangle\n5. Exit");
            Console.WriteLine("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    s = new Rectangle();
                    s.draw();
                    break;

                case 2:
                    s = new Square();
                    break;

                case 3:
                    s = new Circle();
                    break;

                case 4:
                    s = new Triangle();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
