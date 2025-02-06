using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square form1 = new Square("Green", 3);
        shapes.Add(form1);

        Rectangle form2 = new Rectangle("White", 3, 5);
        shapes.Add(form2);

        Circle form3 = new Circle("Orange", 7);
        shapes.Add(form3);

        foreach(Shape i in shapes){
            string color = i.GetColor();

            double area = i.GetArea();

            Console.WriteLine($"The color {color} is in the area of {area}");
        }
        
    }
}