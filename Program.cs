Console.Write("Введите количество элементов массива: ");
int quntity = int.Parse(Console.ReadLine());
string[] dataArray = MyMethods.InputStringArray(quntity);
Console.Write("Массив: ");
MyMethods.OutputStringArray(dataArray);
