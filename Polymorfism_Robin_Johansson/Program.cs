namespace Polymorfism_Robin_Johansson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables is of the type Geometry, but are created with the sub classes:
            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();

            //an array of the different geometries:
            Geometry[] geometries = { circle, square, rectangle };

            //a loop that goes through the diferent geometries and prints info about each one:
            foreach (Geometry geo in geometries)
            {
                Console.WriteLine($"Area of {geo.GetType().Name}: {geo.Area()}");
            }
        }
    }
}
