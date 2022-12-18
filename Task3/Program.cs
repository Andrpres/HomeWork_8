/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

1. Генерация матриц
2. Выведение матриц на экран
3. Нахождение произведения 2-х матриц
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

// Нахождение произведения 2-х матриц
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(0); j++)
        {
            matrixResult[i, j] = matrix1[i, j] * matrix2[i, j];   
        }
    }
    return matrixResult;
}


int[,] matrix1 = GetArray(2, 2);
int[,] matrix2 = GetArray(2, 2);
PrintArray(matrix1);
Console.WriteLine("-------------");
PrintArray(matrix2);
Console.WriteLine("-------------");
PrintArray(MultiplicationMatrix(matrix1, matrix2));