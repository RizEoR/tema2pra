
class Program
{
    public int Sam(int a, int b)
    {
        return a + b;
    }

    private double Ymnno(double x, double y)
    {
        return x * y;
    }

    static void Main()
    {
        Console.WriteLine("Введите число 1");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число 2:");
        int b = Convert.ToInt32(Console.ReadLine());

        Program program = new Program();
        int sum = program.Sam(a, b);
        Console.WriteLine($"Сумма: {sum}");

        Console.WriteLine("Введите число с плавающей точкой 1:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите число с плавающей точкой 2:");
        double y = Convert.ToDouble(Console.ReadLine());

        double p = program.Ymnno(x, y);
        Console.WriteLine($"Произведение: {p}");
    }
}
