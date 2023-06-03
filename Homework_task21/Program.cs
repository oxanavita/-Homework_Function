//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
  
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки A:");
        Console.Write("x: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("z: ");
        double z1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты точки B:");
        Console.Write("x: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("z: ");
        double z2 = double.Parse(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, z1, x2, y2, z2);

        Console.WriteLine($"Расстояние между точками A и B: {distance:F2}");
    }

    static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double dz = z2 - z1;

        double distanceSquared = dx * dx + dy * dy + dz * dz;
        double distance = Math.Sqrt(distanceSquared);

        return distance;
    }
}