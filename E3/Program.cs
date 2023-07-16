// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Write("Введите количество строк первой матрицы: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов первой матрицы: ");
int colom = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк второй матрицы: ");
int row2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов второй матрицы: ");
int colom2 = int.Parse(Console.ReadLine()!);

int[,] massive = new int[row,colom];
FillArray(massive);
Console.WriteLine("Исходный массив №1 : ");
PrintArray(massive);
Console.WriteLine();

int[,] massive2 = new int[row2,colom2];
FillArray(massive2);
Console.WriteLine("Исходный массив №2 : ");
PrintArray(massive2);
Console.WriteLine();

int[,] array = new int[massive.GetLength(0),massive2.GetLength(1)];

if (colom==row2) 
{
    Proisvedenie(massive,massive2);
    
}
else 
{
    Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй матрицы. Умножение невозможно. Введите другие значения. ");
}


void Proisvedenie(int[,] m1, int[,] m2)
{
    int[,] arr = new int[m1.GetLength(0),m2.GetLength(1)];
    int k = 0;
    int kk = 0;
    int p = 0;

    for (int i=0; i < m1.GetLength(0); i++)
    {
        
        for (kk=0; kk < m2.GetLength(1); kk++)
        {
            k = i;
            for (int j=0; j < m1.GetLength(1); j++)
            {
                p = p + m1[i,j]*m2[j,kk];
            }
            arr[i,kk] = p;
            k++;
            p = 0;
        }
        
    }
    Console.WriteLine("Произведение матриц это : ");
    PrintArray(arr);
}


void PrintArray(int[,] mass)
{
    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[ i , j ] }  ");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] mass)
{
    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            mass[i,j] = new Random().Next(1,5);
        }
    }
}