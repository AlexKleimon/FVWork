Console.Write("Введите количество элементов массива: ");
int quntity = int.Parse(Console.ReadLine());
string[] dataArray = MyMethods.InputStringArray(quntity);
Console.Write("Исходный массив: ");
MyMethods.OutputStringArray(dataArray);
dataArray = MyMethods.ReformArray(dataArray);
Console.Write("Итоговый массив: ");
MyMethods.OutputStringArray(dataArray);
