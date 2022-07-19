// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

//Console.Clear();
int[,] array = new int[4, 4];
void FillArrayOnSpiral(int[,] array)
{
    int f = 0;
    for (int i = 0; i < array.GetLength(0)-3; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = f + 1;
            f++;
        }   
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, array.GetLength(1)-1] = f + 1;
            f++;
    }
    for (int j = 2; j >-1; j--)
    {
        array[3, j] = f + 1;
            f++;
    }
    for (int i = 2; i >0; i--)
    {
        array[i, 0] = f + 1;
            f++;
    }
    for (int j = 1; j <3; j++)
    {
        array[1, j] = f + 1;
            f++;
    }
    for (int j = 2; j >0; j--)
    {
        array[2, j] = f + 1;
            f++;
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
FillArrayOnSpiral(array);
PrintArrayToNumbers(array);
