﻿//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int [,] Create2DArray (int rows, int cols, int min, int max)
{
    int [,] array2D = new int [rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array2D[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array2D;
}

void Print2DArray (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] SortArray (int [,] array2D)
{
    int minIndex = 0;
    int maxIndex = 1; 
    if(minIndex < array2D.GetLength(0) && maxIndex > array2D.GetLength(0))
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                // int temp = array2D[minIndex, j];
              //   array2D[i,j] = array2D[minIndex, j];
                 array2D[minIndex, j] = array2D[maxIndex, j];
              //   array2D[maxIndex, j] = temp;
            }  
        } 
        return array2D;
}   

/*
Задача с семинара, пример
           int temp = array2D[userRow1, j];
            array2D[userRow1, j] = array2D[userRow2, j];
            array2D[userRow2, j] = temp;
            return array2D;
        }
*/ 


/*
Console.Write("Enter rows number: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns number: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] createdArray = Create2DArray(rows, columns, min, max);
Print2DArray(createdArray);
Console.WriteLine();
int [,] changedArray = SortArray(createdArray);
Print2DArray(changedArray);
*/

/////////////////////////////////////////////////////////////

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int [,] CreateArray (int rows, int columns, int min, int max)
{
    int [,] createdArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i,j] = new Random().Next(min, max + 1);
        }
    }
    return createdArray;
}

void ShowArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] SumFinderElem (int [,] array2D)
{
    int sum = 0;
    int count = 0;
    int minI = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        { 
            sum = array2D[i,j] + count;
            minI = array2D[minI, j];
            count++;
            if(array2D[i,j] < array2D[minI,j])
            {
                count = array2D[minI,j];
                Console.WriteLine(count + " this row has minimum sum");
            }
        }
        
    }
    return array2D;
}

Console.Write("Enter rows number: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns number: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] createdArray = CreateArray(rows, columns, min, max);
ShowArray(createdArray);
Console.WriteLine();
int [,] changedArray = SumFinderElem(createdArray);
ShowArray(changedArray);
*/

//////////////////////////////////////////////////////////

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц.
/*
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int [,][,] CreateArray (int rows, int columns, int min, int max)
{
    int [,] createdArray = new int [rows, columns];
    int [,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i,j] = new Random().Next(min, max + 1);
            newArray[i,j] = new Random().Next(min, max + 1);
        }
    }
    return createdArray;
    return newArray;
}

void ShowArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ShowArray (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] MultiplicationOfMatrix (int [,] array, int [,] array2D)
{

}



////////////////////////////////////////////////////////////

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
//надо проверку на неповторяющиеся числа

/*

int [,,] Create3DArray (int zPage, int yRow, int xCol, int min, int max)
{
    int [,,] created3DArray = new int [zPage, yRow, xCol];
    for (int i = 0; i < created3DArray.GetLength(0); i++) //перебор страниц
    {
        for (int j = 0; j < created3DArray.GetLength(1); j++) //перебор строк
        {
            for (int k = 0; k <created3DArray.GetLength(2); k++) //перебор колонок
            { 
                created3DArray[i,j,k] = new Random().Next(10, 99);
               // created3DArray[i,j,k] = new Random().Next(10, 99); //заполнение массива рандомными числами от 10 до 99
               if(zPage == xCol && zPage == yRow || yRow == zPage && yRow == xCol || xCol == zPage && xCol == yRow)
                  created3DArray[zPage, yRow, xCol] = new Random().Next(10, 99);
                
            }
        }
    }
    return created3DArray;
}

void Show3DArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + " ");
            }
            Console.WriteLine();
        } 
        Console.WriteLine();
    }
}

int [,,] AddIndex (int [,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write(array3D[i,j,k]);
            }
        }
    }
    return array3D;
}


Console.Write("Enter Page number: ");
int pages = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter rows number: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter columns number: ");
int columns = Convert.ToInt32(Console.ReadLine());

int minVal = 10;
int maxVal = 99;

int [,,] createdArray = Create3DArray(pages, rows, columns, minVal, maxVal);
Show3DArray(createdArray);
int [,,] new3dArray = AddIndex(createdArray);
Show3DArray(new3dArray);
*/

    
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int [,] CreateArray (int rows, int columns)
{
    int [,] createdArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
         //  createdArray[i,j] = createdArray[createdArray.GetLength(0) - 1 - i, j];
           // createdArray[i,j] = createdArray[i, createdArray.GetLength(1) - 1  - j];
            createdArray[i,j] = createdArray[i, j - 1];
            createdArray[i, j - 1] = createdArray[i - 1, j - 1];
            
        }
    }
    return createdArray;
}

void ShowArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
int rows = 4;
int cols = 4;

int [,] createdArray = CreateArray(rows, cols);
ShowArray(createdArray);

