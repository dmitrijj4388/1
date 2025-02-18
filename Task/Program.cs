﻿// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["Hello", "2", "World", ";-)"] -> ["2", ";-)]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []

string[] ChoiseFromArray(string[] arr, int n) //Функция отбирает элементы с нужным колличеством символов, и записывает в массив.
{
    string text = "";
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= n) text += $"{arr[i]} ";
    }
    string[] result = text.Split(' ');
    return result;
}

Console.Clear();
string[] array = { "Moskva", "SPb", "21", ":-)!","2023" };
string[] result = ChoiseFromArray(array, 3);
Console.WriteLine(String.Join("\t " ,result)); 

