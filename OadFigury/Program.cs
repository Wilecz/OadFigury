using OadFigury;
var figury = new List<Figure> { new Circle(1), new Rectangle(2, 3), new Triangle(3, 4, 5) };
foreach (var f in figury)
{
    Console.WriteLine(f.Description());
}