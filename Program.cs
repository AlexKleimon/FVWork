/*  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
    Первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
    лучше обойтись исключительно массивами.
    Пример: 
    ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
*/
Console.Write("Введите количество элементов массива: ");
int quntity = MyMethods.InputNumber();
string[] dataArray = MyMethods.InputStringArray(quntity);
Console.Write("Исходный массив: ");
MyMethods.OutputStringArray(dataArray);
dataArray = MyMethods.ReformArray(dataArray);
Console.Write("Итоговый массив: ");
MyMethods.OutputStringArray(dataArray);
