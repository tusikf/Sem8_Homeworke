// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Write("Введите размер трехмерной матрицы: ");
int row = int.Parse(Console.ReadLine()!);

int colom = row;
int k = row;

int[,,] massive = new int[row,colom,k];
FillArray(massive);

Console.WriteLine("Получилась матрица: ");

PrintArray(massive);
Console.WriteLine();





void PrintArray(int[,,] mass)
{
    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(0); j++)
        {
            for (int v=0; v < mass.GetLength(0); v++)
            {
                Console.Write($"{mass[ i , j , v] }, ({i}, {j}, {v}) ");
            }
            
        }
        Console.WriteLine();
    }
}


void FillArray(int[,,] mass)
{
    for (int i=0; i < mass.GetLength(0); i++)
    {
        for (int j=0; j < mass.GetLength(0); j++)
        {
            int v = 0;
            while( v < mass.GetLength(0))
            {
                int temp = new Random().Next(0,1000);
                if (FindeEl(temp,mass[i,j,v])) continue;
                mass[i,j,v] = temp;
                v++;
            }
        }
    }
}

bool FindeEl(int el,int[,,]array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(0); j++)
        {
            for (int v=0; v < array.GetLength(0); v++)
            {
                if (array[i,j,v] == el) return true;
            }
            
        }
    }
    return false;
}
