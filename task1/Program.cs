// 5зн число, является ли палиндромом.
// Число хранить в int, решать с помощью арифм операций (не string)
int[] array = new int [5] {2, 2, 3, 2, 2}; // массив из 5 чисел
Console.WriteLine(string.Join(",", array));
if (array[0] == array[4])
{
    if (array[1] == array[3])
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
    Console.WriteLine("Не палиндром");
    }
}
else
{
    Console.WriteLine("Не палиндром");
}