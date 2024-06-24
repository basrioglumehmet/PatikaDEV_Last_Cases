using Draw_Triangle;

try
{
    int count = int.Parse(Console.ReadLine());
    IDrawer shape = new TriangleShapeService();
    shape.Draw(count);
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}