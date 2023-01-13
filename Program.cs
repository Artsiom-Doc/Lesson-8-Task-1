/*Задача 1: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

void FillArray(int[,]matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,]matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
 

int [,] matrix = new int [4, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

for(int i = 0; i < matrix.GetLength(0); i++)
{
    
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            if(matrix[i,k] <= matrix[i,k + 1])
            {
                int tmp = matrix[i,k + 1];
                matrix[i,k + 1] = matrix[i,k];
                matrix[i,k] = tmp;
            }
            
        }
        
    
        Console.Write($"{matrix[i, j]} ");
    }
    
    
    Console.WriteLine();  
}

