﻿// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов стоящих на нечетных позициях
// [3,7,23,12]->19
// [-4, -6, 89, 6]->0
int[] array = new int [4];
int sum = 0;
int[] GetArray(int[] array);
{for(int i=0; i< array.Length; i++)
{
    array[i]= new Random().Next(1,10);
    if(i % 2 ==1)
    {
sum+= array[i];
    }
    }
    return array;
    }
    GetArray(array);

Console.WriteLine(String.Join("",array));
 Console.WriteLine("сумма элементов, стоящих на нечетных позициях равна"+ sum);















