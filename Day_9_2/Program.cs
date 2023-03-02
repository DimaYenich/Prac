using System;
using System.IO;

class Program
{
    static void Main()
    {
        double x1, y1, r1, x2, y2, r2;
        Console.WriteLine("Введіть координати та радіуси двох кіл: ");
        Console.Write("Центр першого кола (X) = ");
        x1 = double.Parse(Console.ReadLine());
        Console.Write("Центр першого кола (Y) = ");
        y1 = double.Parse(Console.ReadLine());
        Console.Write("Радіус першого кола = ");
        r1 = double.Parse(Console.ReadLine());
        Console.Write("Центр другого кола (X) = ");
        x2 = double.Parse(Console.ReadLine());
        Console.Write("Центр другого кола (Y) = ");
        y2 = double.Parse(Console.ReadLine());
        Console.Write("Радіус другого кола = ");
        r2 = double.Parse(Console.ReadLine());

        int intersectionCount = CalculateIntersectionPoints(x1, y1, r1, x2, y2, r2);

        string textForWrite = null;
        if (intersectionCount == int.MaxValue)
            textForWrite += "Одне коло лежить в іншому";
        if (intersectionCount == 2)
            textForWrite += "Кола перетинаються в однох точках";
        if (intersectionCount == 1)
            textForWrite += "Кола перетинаються в одній точці";
        if (intersectionCount == 2)
            textForWrite += "Кола перетинаються в однох точках";
        if (intersectionCount == -1)
            textForWrite += "Кола не перетинаються";
        if (intersectionCount == 0)
            textForWrite += "Одне коло лежить в іншому";

        Console.WriteLine($"Кількість точок перетину: {intersectionCount}");

        using (StreamWriter sw = new StreamWriter("z9-2.rez"))
        {
            sw.WriteLine($"Кількість точок перетину: {intersectionCount}");
        }

        Console.WriteLine("Файли створено!");
        Console.ReadLine();
    }

    static int CalculateIntersectionPoints(double x1, double y1, double r1, double x2, double y2, double r2)
    {
        double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        if (d > r1 + r2)  // кола не перетинаються
        {
            return -1;
        }
        else if (d < Math.Abs(r1 - r2))  // одне коло лежить в середині іншого
        {
            return 0;
        }
        else if (d == 0 && r1 == r2)  // круги ідентичні
        {
            return int.MaxValue;
        }
        else
        {
            double a = (r1 * r1 - r2 * r2 + d * d) / (2 * d);
            double h = Math.Sqrt(r1 * r1 - a * a);
            if (h == 0)  // кола дотикаються одне до одного
            {
                return 1;
            }
            else  // кола перетинаються в двох точках
            {
                return 2;
            }
        }
    }
}
