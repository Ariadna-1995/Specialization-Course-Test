﻿//Задача: Написать программу, которая из имеющегося массива строк формирует
//массив из строк, длина которых меньше либо равна 3 символа.
string[] array1 = new string[5] {"1", "27", "world", "hello", "-2"};
string[] array2 = new string[array1.Length];
void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}