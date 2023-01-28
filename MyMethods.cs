public class MyMethods
{
    /// <summary>
    /// Метод ввода элементов одномерного массива типа String с консоли.
    /// </summary>
    /// <param name="quntiElements">Количество элементов в массиве.</param>
    /// <returns>Заполненный массив типа String.</returns>
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
    /// <summary>
    /// Метод вывода элементов одномерного массива типа String в консоль.
    /// </summary>
    /// <param name="dataArray">Массив типа String.</param>
    public static void OutputStringArray(string[] dataArray)
    {
        int lengthArray = dataArray.Length;
        string text = string.Empty;
        Console.Write($"[ {dataArray[0]}");
        for (int i = 1; i < lengthArray; i++)
        {
            text += $", {dataArray[i]}";
        }
        Console.Write($"{text} ]\n");
    }
    /// <summary>
    /// Метод формирования одномерного массива типа String, длина элементов которого меньше либо равны 3.
    /// </summary>
    /// <param name="dataArray">Исходный массив типа String.</param>
    /// <returns>Итоговый массив типа String.</returns>
    public static string[] ReformArray(string[] dataArray)
    {
        int lengthArray = dataArray.Length;
        string[] finalArray = new string[lengthArray];
        string word = string.Empty;
        int count = 0;
        for (int i = 0; i < lengthArray; i++)
        {
            word = dataArray[i];
            if (word.Length < 4)
            {
                finalArray[count] = word;
                count++;
            }
        }
        if (count < lengthArray)
            Array.Resize(ref finalArray, count);
        return finalArray;
    }
    /// <summary>
    /// Метод ввода числа в консоль.
    /// </summary>
    /// <returns>Число.</returns>
    public static int InputNumber()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Ошибка! Введите число повторно: ");
        }
        return result;
    }
}