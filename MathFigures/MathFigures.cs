using System;

namespace MathFigures
{
    public class Figures
    {
        static public bool IsTriangle(double a, double b, double c) //проверка треугольника
        {
            bool TriangleBool;
            double AOver = a - b - c;
            double BOver = b - a - c;
            double COver = c - b - a;
            if (AOver < 0 && BOver < 0 && COver < 0) TriangleBool = true;
            else TriangleBool = false;
            return TriangleBool;
        }

        static public double TriangleAre(double a, double b, double c) //нахождение площади треугольника
        {
            double area = -1;
            if (IsTriangle(a,b,c))
            {
                double p = (a + b + c) / 2;
                area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return area; // area=-1 значить не являеться треугольником
        }

        static public double CircleAre(double r) //нахождение площади Круга
        {
            double area = -1;
            if (r>0)
            {
                area = Math.PI*r*r;
            }
            return area; // area=-1 значить не являеться кругом
        }

        static public bool IsRightTriangle(double a, double b, double c) //проверка прямоугольного треугольника
        {
            bool hypotenuse = false;
            if (a * a == b * b + c * c) hypotenuse = true;
            if (b * b == a * a + c * c) hypotenuse = true;
            if (c * c == b * b + a * a) hypotenuse = true;
            if (IsTriangle(a,b,c) == false) hypotenuse = false;
            return hypotenuse;
        }
        
    }
}
