namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            Console.WriteLine("Please enter the shape to draw");
            String? shape = Console.ReadLine();
            var obj = shapeFactory.GetShape(shape);
            obj?.draw();
        }
    }
}
