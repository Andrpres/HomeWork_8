/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// Создаем массив
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

// Выводим массив на экран
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Ищем наименьшую строку по сумме элементов
int FindMin (int[,] array){
    int summStrok = 0;
    int minSumm = 0;
    int summResult = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summStrok = summStrok + array[i,j]; 
        }
        if (i == 0){
            minSumm = summStrok;
        }else if(summStrok < minSumm){
            summResult = i;
        }
        summStrok = 0;
    }
    return summResult;
}

int[,] matrix = GetArray(4, 3);
PrintArray(matrix);
int result = FindMin(matrix);
Console.WriteLine($"{result + 1} сторока с наименьшей суммой элементов");