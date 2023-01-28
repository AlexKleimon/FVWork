public class MyMethods
{
    public static string[] InputStringArray(int quntiElements)
    {
        string[] dataArray = new string[quntiElements];
        int lengthArray = dataArray.Length;
        for (int i = 0; i < lengthArray; i++)
        {
            Console.WriteLine($"Введите элемент массива под индексом {i}: ");
            dataArray[i] = Console.ReadLine();
        }
        return dataArray;
    }
    public static void OutputStringArray(string[] dataArray)
    {
        int lengthArray = dataArray.Length;
        string text = string.Empty;
        Console.Write($"[ {dataArray[0]}");
        for (int i = 0; i < lengthArray; i++)
        {
            text += $", {dataArray[i]}";
        }
        Console.Write($"{text} ]\n");
    }
}