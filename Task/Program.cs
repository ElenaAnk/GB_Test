/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/


string[] ArrayFirst = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };
int size = ArrayFirst.Length;
string[] ArraySecond = new string[size];
Console.WriteLine($"[{String.Join(" ", ArrayFirst)}]");
ArrayResult(ArrayFirst, ArraySecond);
Console.WriteLine($"[{String.Join(" ", ArraySecond)}]");

void ArrayResult(string[] Array, string[] Array2)
{
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            Array2[j] = Array[i];
            j++;
        }
    }
}





















