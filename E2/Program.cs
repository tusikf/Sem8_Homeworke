// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colom = int.Parse(Console.ReadLine()!);

int[,] massive = new int[row,colom];
FillArray(massive);
Console.WriteLine("Исходный массив: ");
PrintArray(massive);
Console.WriteLine();


Schet(massive);


void Schet(int[,] mass)
{
    int k = 0;
    int[,] matrix = new int[2, mass.GetLength(0)*mass.GetLength(1)];
    int kk = 0;

    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(1); j++)
        {
            for (int r=0; r < mass.GetLength(0); r++)
            {
                for (int c=0; c < mass.GetLength(1); c++)
                { 
                    if ( mass[i,j] == mass[r,c])
                    {
                        k++;
                    }
                }              
            } 
            matrix[0, kk] = mass[i,j];
            matrix[1, kk] = k;
            kk++;
            Console.WriteLine($"Элемент массива:{mass[i,j]} встречается {k} раз");
            k = 0;      
        }
    }
    PrintArray(matrix);
    // сложила все элементы в отдельный массив, но как вывести уникальные значения чтобы не повторялись - не смогла придумать.
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
            mass[i,j] = new Random().Next(0,5);
        }
    }
}