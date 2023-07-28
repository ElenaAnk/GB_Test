# Описание решения задачи

## Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение:

Для решения данной задачи я создала два массива, первый это массив с изначально заданными элементами и второй массив пока пустой, длинной равной длинне первого массиву.
Далее создаю метод для опредеоения подходящих элементов для нашего второго массива, в данном случае это элементы длинной 3 или менее символов.

Метод заключается в проверке каждого элемента первого массива, для этого мы как обычно создаем переменную " i ", с помощью которой мы будем обращаться к конкретному элементу, проверять на условие (длина меньше или равна 3 символам),и после проверки переходим к следующему элементу, до тех пор пока массив не закончится.
Если условие (длина элемента меньше или равна 3 символам) выполняется, тогда данное значение присваиваем первому элементу второго массива, далее следующий подходящий элемент первого массива присваиваем второму элементу второго массива и так далее. Для этого нам понадобится переменная " j ", с помощью кторой мы будем общаться к конкретному элементу второго массива.

Для вывода массивов на экран я использовала 
Console.WriteLine с использванием Join с разделителем - пробел.
