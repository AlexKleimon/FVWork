public class MyMethods
{
    public static string[] InputStringArray(int quntiElements)
    {
        string[] dataArray = new string[quntiElements];
        int lengthArray = dataArray.Length;
        for (int i = 0; i < lengthArray; i++)
        {
            Console.WriteLine($"Введите элемент массива под номером {i}: ");
            dataArray[i] = Console.ReadLine();
        }
        return dataArray;
    }
}