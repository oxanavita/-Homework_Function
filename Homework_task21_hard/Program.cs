// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размерность пространства N: ");
        int N = int.Parse(Console.ReadLine());

        double[] point1 = new double[N];
        double[] point2 = new double[N];

        Console.WriteLine("Введите координаты первой точки:");

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Координата {i + 1}: ");
            point1[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите координаты второй точки:");

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Координата {i + 1}: ");
            point2[i] = double.Parse(Console.ReadLine());
        }

        double distance = CalculateDistance(point1, point2);
        Console.WriteLine($"Расстояние между точками: {distance}");
    }

    static double CalculateDistance(double[] point1, double[] point2)
    {
        double sum = 0;

        for (int i = 0; i < point1.Length; i++)
        {
            double diff = point1[i] - point2[i];
            sum += diff * diff;
        }

        return Math.Sqrt(sum);
    }
}