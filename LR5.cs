using System;

class Polygon
{
    public int n;
    public double[] x;
    public double[] y;

    public void In()
    {
        Console.Write("Введіть кількість вершин: ");
        n = int.Parse(Console.ReadLine());
        x = new double[n];
        y = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Вершина {i + 1} (x y): ");
            string[] s = Console.ReadLine().Split();
            x[i] = double.Parse(s[0]);
            y[i] = double.Parse(s[1]);
        }
    }

    public void Out()
    {
        Console.WriteLine("\nВершини:");
        for (int i = 0; i < n; i++)
            Console.WriteLine($"({x[i]}, {y[i]})");
    }

    public double Perimeter()
    {
        double p = 0;
        for (int i = 0; i < n; i++)
        {
            int next = (i + 1) % n;
            double dx = x[i] - x[next];
            double dy = y[i] - y[next];
            p += Math.Sqrt(dx * dx + dy * dy);
        }
        return p;
    }

    public double Area()
    {
        double s = 0;
        for (int i = 0; i < n; i++)
        {
            int next = (i + 1) % n;
            s += x[i] * y[next] - x[next] * y[i];
        }
        return Math.Abs(s) / 2;
    }

    public bool IsPointOnEdge(double px, double py)
    {
        for (int i = 0; i < n; i++)
        {
            int next = (i + 1) % n;
            double cross = (px - x[i]) * (y[next] - y[i]) - (py - y[i]) * (x[next] - x[i]);
            if (Math.Abs(cross) < 0.0001)
            {
                double dot = (px - x[i]) * (x[next] - x[i]) + (py - y[i]) * (y[next] - y[i]);
                double lenSq = (x[next] - x[i]) * (x[next] - x[i]) + (y[next] - y[i]) * (y[next] - y[i]);
                if (dot >= 0 && dot <= lenSq) return true;
            }
        }
        return false;
    }
}

Polygon p = new Polygon(); 

p.In();
p.Out();

Console.WriteLine("Периметр: " + p.Perimeter());
Console.WriteLine("Площа: " + p.Area());

Console.Write("\nВведіть точку (x y): ");
string[] input = Console.ReadLine().Split();
double px = double.Parse(input[0]);
double py = double.Parse(input[1]);

if (p.IsPointOnEdge(px, py))
    Console.WriteLine("Точка належить ребру");
else
    Console.WriteLine("Точка НЕ належить ребру");