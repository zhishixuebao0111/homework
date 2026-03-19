using System;
namespace Shape{
    abstract class Shape
    {
       public abstract double GetArea();
    }
    class Circle : Shape 
    {
        public double radius { set; get; }
        public override double GetArea() { return this.radius * this.radius * 3.14; }
    }
    class Retangle:Shape
    {
        public double width { set; get; }
        public double height { set; get; }
        public override double GetArea() { return this.width * this.height; }
    }
    class Square:Shape
    {
        public double width { set; get; }
        public override double GetArea() { return this.width* this.width; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Shape []A= new Shape[10];
            for(int i = 0; i < 10; i++)
            {
                if(i%3==0)
                {
                    Circle A1 = new Circle();
                    A1.radius = i+1;
                    A[i] = A1;
                }
                if(i%3==1)
                {
                    Retangle A2 = new Retangle();
                    A2.width = i+1;
                    A2.height = i;
                    A[i] = A2;
                }
                if(i%3==2)
                {
                    Square A3 = new Square();
                    A3.width = i;
                    A[i]= A3;
                }
            }
            foreach (Shape i in A)
            {
                Console.WriteLine( i.GetArea());
            }
        }
    }
}