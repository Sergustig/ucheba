/* 
Задача “Класс «Точки в 3х-мерном пространстве»”. Создайте
класс «Point». У этого класса должны быть заданы значения по
умолчанию для координат точки в пространстве, а также реализован
метод для вычисления расстояния до другой точки. В коде
программы создайте не менее 2х экземпляров класса, один из
которых - с параметрами по умолчанию, другие - с произвольными
параметрами. Выведите на экран результаты работы методов для
вычисления заданных параметров (расстояния между точками). 
Реализация возможна в виде консольного приложения
 */

using System;

    class Point
{
    public double X { get; set; } = 5;
    public double Y { get; set; } = 10;
    public double Z { get; set; } = 15;

    public Point() //конструктор по умолчанию
    {

    }

    public Point(double x, double y, double z) //конструктор с заданными координатами
    {
        X = x;
        Y = y;
        Z = z;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point point1 = new Point(); //конструктор по умолчанию
        Point point2 = new Point(20, 25, 30); //конструктор с координатами


        // Вывод в консоль
        Console.WriteLine($"Расстояние между точкой ({point1.X};{point1.Y};{point1.Z}) и точкой ({point2.X};{point2.Y};{point2.Z}) = {CalculateDistance(point1, point2):N2}");
        Console.ReadKey();
    }

    static double CalculateDistance(Point point1, Point point2) // метод, который по заданным точкам рассчитывает координаты
    {
        // Math.Pow() – возведения числа в степень
        // Math.Sqrt() – извлечение квадратного корня

        return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2) + Math.Pow(point2.Z - point1.Z, 2)); 
    }

}


