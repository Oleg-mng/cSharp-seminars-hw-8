// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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
void SortArrayByRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
            if (array[i, k+1] < array[i, k])
            {
                temp = array[i, k+1];
                array[i, k+1]= array[i, k];
                array[i, k] = temp;
            }
            }
        }
    }
}
FillArrayToNumbers(arrayrandom);
PrintArrayToNumbers(arrayrandom);
SortArrayByRows(arrayrandom);
System.Console.WriteLine($"Массив отсортированный по строкам:");
PrintArrayToNumbers(arrayrandom);