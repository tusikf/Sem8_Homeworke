// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colom = int.Parse(Console.ReadLine()!);

int[,] massive = new int[row,colom];
FillArray(massive);
Console.WriteLine("Исходный массив: ");
PrintArray(massive);
Console.WriteLine();

for (int k=0; k < colom; k++)
{
   Sortirovka(massive);  
}

Console.WriteLine("Новый  массив: ");
PrintArray(massive);



int[,] Sortirovka(int[,] mass)
{
    int temp = 0;
    for (int i=0; i < mass.GetLength(0)-1; i++)
    {
        for (int j=0; j < mass.GetLength(1)-1; j++)
        {
           if (mass[i, j+1] > mass[i,j])
           {
            temp = mass[i,j];
            mass[i,j] = mass[i,j+1];
            mass[i,j+1] = temp;
           }
        }
    }
    return mass;
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
            mass[i,j] = new Random().Next(-10,11);
        }
    }
}