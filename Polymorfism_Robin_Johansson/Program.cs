namespace Polymorfism_Robin_Johansson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Geometry is an abstract parent class to the diferent classes of shapes and therefore it can take different forms (Polymorphism)
            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();
            Geometry triangle = new Triangle();

            //an array of the different geometries:
            Geometry[] geometries = { circle, square, rectangle, triangle };

            //a loop that goes through the diferent geometries and prints info about each one:
            foreach (Geometry geo in geometries)
            {
                // Class Geometry has an abstract method which is overrided to the sub classes, which makes the "same" method work for all the classes.
                Console.WriteLine($"Area of {geo.GetType().Name}: {geo.Area()}");
            }
        }
    }
}
