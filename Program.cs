//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.Clear();
Console.WriteLine($"\nВведите размер массива n1 x n2 и диапазон случайных значений:");
int n1 = InputNumbers("Введите n1: ");
int n2 = InputNumbers("Введите n2: ");
int range = InputNumbers("Введите интервал: от 1 до ");

int[,] array = new int[n1, n2];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nУпорядоченный массив: ");
OrderArrayLines(array);
WriteArray(array);

void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.Clear();
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int n1 = InputNumbers("Введите n1: ");
int n2 = InputNumbers("Введите n2: ");
int range = InputNumbers("Введите интервал: от 1 до ");

int[,] array = new int[n1, n2];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n< {minSumLine + 1} > - строкa с наименьшей суммой элементов равной {sumLine} ");


int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

*/

//---------------------------------------------------------------------------------------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.WriteLine($"\nВводим размеры матриц и интервал случайных значений:"); //значения должны быть положительными
int n1 = InputNumbers("Введите число строк в 1-й матрице: ");
int n2 = InputNumbers("Введите число столбцов 1-й матрицы, оно же число строк 2-й мтрицы: ");
int n3 = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите интервал случайных значений: от 1 до ");

int[,] firstMartrix = new int[n1, n2];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n2, n3];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[n1, n3];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение двух матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


//---------------------------------------------------------------------------------------------------------------------------------------
//Задача *1. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


Console.Clear();
Console.WriteLine($"\nВведите размер массива A x B x C:");
int a = InputNumbers("Введите A: ");
int b = InputNumbers("Введите B: ");
int c = InputNumbers("Введите C: ");
Console.WriteLine($"");

int[,,] array3D = new int[a, b, c];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void WriteArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write($"A({i}) B({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"C({k})={array3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int a = 0; a < array3D.GetLength(0); a++)
    {
        for (int b = 0; b < array3D.GetLength(1); b++)
        {
            for (int c = 0; c < array3D.GetLength(2); c++)
            {
                array3D[a, b, c] = temp[count];
                count++;
            }
        }
    }
}


//------------------------------------------------------------------------------------------------------------------------------------------
//Задача *2. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int n = 4;
int[,] spiralMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
    spiralMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(spiralMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

