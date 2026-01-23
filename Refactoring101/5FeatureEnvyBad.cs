using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101.FeatureEnvyBad;

// 5
public class FeatureEnvyBad
{
    public void TestAdd()
    {
        var point = AddPoint(new Point(2, 3), new Point(4, 5));
    }
    public Point AddPoint(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }
}

public class Point
{
    public double X { get; }
    public double Y { get; }
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}

public class FeatureEnvyGood
{
    public void TestAdd()
    {
        var point = new Point2(2, 3).Add(new Point2(4, 5));
    }
}

public class Point2
{
       public double X { get; }
    public double Y { get; }
    public Point2(double x, double y)
    {
        X = x;
        Y = y;
    }
    public Point2 Add(Point2 b)
    {
        return new Point2(this.X + b.X, this.Y + b.Y);
    }
}

public class FeatureEnvyGoodAdvance
{
    public void TestAdd()
    {
        var point = new Point3(2, 3) + new Point3(4, 5);
    }
}

public class Point3
{
    public double X { get; }
    public double Y { get; }
    public Point3(double x, double y)
    {
        X = x;
        Y = y;
    }
    public static Point3 operator +(Point3 a, Point3 b)
    {
        return new Point3(a.X + b.X, a.Y + b.Y);
    }
}