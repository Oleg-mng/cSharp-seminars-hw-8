// Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Clear();
System.Console.WriteLine("Введите количество строк m 3-х мерного массива");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n 3-х мерного массива");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество элементов в высоту n 3-х мерного массива");
int c = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Вы ввели размерность 3-х мерного массива {m}x{n}x{c}");

int[,,] array3d = new int[m, n, c];
Random r = new Random();

void FillArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
            array3d[i, j, k] = r.Next(10, 32);
            }
        }
    }
}
void PrintArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
             for (int k = 0; k < array3d.GetLength(2); k++)
             {
               System.Console.Write($"{array3d[i, j, k],7}({i},{j},{k})");  
             }
             System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
FillArray3d(array3d);
System.Console.WriteLine($"3-х мерный массив с координатами точек будет выглядеть:");
PrintArray3d(array3d);

