// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();
System.Console.WriteLine("Введите количество строк m двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вы ввели размерность массива {m}x{n}");
Console.WriteLine($"Двумерный массив заполненный случайным образом будет выгдядеть:");

int[,] arrayrandom = new int[m, n];
Random r = new Random();

void FillArrayToNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(0, 12);
        }
    }
}
void PrintArrayToNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],5} ");
        }
        System.Console.WriteLine();
    }
}
void CountMinSumInAllRow(int[,] array)
{
    int summin = 1000000;
    int countrow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < summin)
        {
            summin = sum;
            countrow = i;
        }
    }
    System.Console.WriteLine($"минимальная сумма находится на строке {countrow} и она равна {summin}");
}
FillArrayToNumbers(arrayrandom);
PrintArrayToNumbers(arrayrandom);
CountMinSumInAllRow(arrayrandom);
