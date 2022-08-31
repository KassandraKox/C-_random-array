// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
Double x1=0, x2=0, y1=0, y2=0, z1=0, z2=0;  //объявляю переменные
Double distance;
Console.Write("x1=");
x1 = Convert.ToDouble(Console.ReadLine());  // ввод точек
Console.Write("y1=");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1=");
z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2=");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2=");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2=");
z2 = Convert.ToDouble(Console.ReadLine());
// расчет дистанции (квадрат разниц координат)
distance = (Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
distance = (Math.Pow(distance, 0.5));  // корень из квадрата
Console.WriteLine(Math.Round(distance, 2));  // оставить 2 знака после запятой