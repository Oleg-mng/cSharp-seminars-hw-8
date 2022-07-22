// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.Clear();
System.Console.WriteLine("Введите количество строк m двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вы ввели размерность массива {m}x{n}");

int[,] array1random = new int[m, n];
int[,] array2random = new int[m, n];
int[,] multiarray = new int[m, n];
Random r = new Random();

void FillArrayToNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(0, 14);
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
void MultiplicationOfMatrices(int[,] multiarray)
{
    int sum = 0;
    //int pr = 0;
    for (int i = 0; i < multiarray.GetLength(0); i++)
    {
            //pr= 0;
        for (int j = 0; j < multiarray.GetLength(1); j++)
        {
            sum =0;
            for (int k = 0; k < multiarray.GetLength(0); k++)
            {
                sum += array1random[i, k] * array2random[k, j];
                //sum += pr;
            }
            multiarray[i, j] = sum;
            //System.Console.Write($"{multiarray[i, j],5} ");
        }
        //System.Console.WriteLine();
    }
}
FillArrayToNumbers(array1random);
Console.WriteLine($"Двумерный массив1 заполненный случайным образом будет выгдядеть:");
PrintArrayToNumbers(array1random);
FillArrayToNumbers(array2random);
Console.WriteLine($"Двумерный массив2 заполненный случайным образом будет выгдядеть:");
PrintArrayToNumbers(array2random);
MultiplicationOfMatrices(multiarray);
System.Console.WriteLine($"Произведение 2-х матриц равно следующему массиву:");
PrintArrayToNumbers(multiarray);