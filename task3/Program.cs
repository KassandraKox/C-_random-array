// Напишите программу, которая принимает на вход число (N) и помещает 
//в массив таблицу кубов чисел от 1 до N. Полученный массив вывести 
//на экран.
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine()); //считать и преобразовать число
int [] array = new int [N]; // создать массив на N мест
int index = 0; //индекс начинается с 0
while (index < N) // пока индекс < N
{
    array[index] = (index + 1) * (index + 1); //внутрь массива ставим куб числа индекс+1
    index++;
}
Console.WriteLine(string.Join(",", array)); // вывод массива