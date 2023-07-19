// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// не получается, запуталась)

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colom = int.Parse(Console.ReadLine()!);

int[,] massive = new int[row,colom];

FillArray(massive);

Console.WriteLine("Получился массив: ");
PrintArray(massive);
Console.WriteLine();





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
    int k=0;
    int a = 1;
    for (int i=0; i < mass.GetLength(0)/2; i++)
    {
        for (int j=0; j < mass.GetLength(1)-a; j++)
        {
            mass[i,j] = k;
            k++;
        }
        int jj = mass.GetLength(1)-a-2;
        for (int ii =1; ii < mass.GetLength(0)-a; ii++)
        {
            mass[i,jj] = k;
            k++;
        }
        for (int j = mass.GetLength(1)-a-1; j< 0; j--)
        {
            mass[i,j] = k;
            k++;
        }
        int jjj = 0;
        for (int ii = mass.GetLength(0)-a-1; ii < 0; i--)
        {
            mass[ii,jjj] = k;
            k++;
        }
        a++;

    }
}
