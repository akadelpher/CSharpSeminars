﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int [,] GenerateRandomArray(int m, int n)
{
    int numberOfElements=m*n;
    var result = new int[m,n];
    var count=1;
    for (int i=0;i<n;i++)
    {
        result[0,i]=count;
        count++;
    }
    for (int j=1;j<m;j++)
    {
        result[j,n-1]=count;
        count++;
    }
      for (int i=n-2;i>=0;i--)
    {
        result[m-1,i]=count;
        count++;
    }
    for (int j=m-2;j>0;j--)
    {
        result[j,0]=count;
        count++;
    }
  
    return result;
}

//Вывести массив
void PrintIntArray (int[,] array)
{
    int m=array.GetLength(0); //количество строк (M)
    int n=array.GetLength(1);
    for (int i=0;i<m;i++)
    {
       if (i!=0) 
       {
        Console.WriteLine(); //Новая строка но не перед первой строкой
       }
        for (int k=0;k<n;k++)
        {
            Console.Write(array[i,k]+"\t");
        }
    }
}
//Получение целого числа
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

var m=ReadInt("Введите количество строк матрицы: ");
var n=ReadInt("Введите количество столбцов матрицы: ");
var matrix=GenerateRandomArray(m,n);
Console.WriteLine("Сгенерирована матрица заполненная спирально:");
PrintIntArray(matrix);