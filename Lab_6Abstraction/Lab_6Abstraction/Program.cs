

using Lab_6Abstraction;
//Lab1();
Lab2();

void Lab1()
{
    var radius = int.Parse(Console.ReadLine());
    IDrawable circle = new Circle(radius);
    var width = int.Parse(Console.ReadLine());
    var height = int.Parse(Console.ReadLine());
    IDrawable rect = new Rectangle(width, height);

    circle.Draw();
    rect.Draw();
}
void Lab2()
{
    ICar seat = new Seat("Leno", "Grey");
    ICar tesla = new Tesla("Model 3", "Res", 2);
    Console.WriteLine(seat.ToString());
    Console.WriteLine(tesla.ToString());
}