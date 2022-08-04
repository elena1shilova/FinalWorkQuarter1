string[] arrayString(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} значение массива: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}
void printArrayString(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"'{array[i]}'; ");
        else if (i == array.Length - 1) Console.Write($"'{array[i]}' ");
    }
    Console.Write("]");
}
int elementsUpTo3characters(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}
string[] newArrayElementsUpTo3characters(string[] arrayStr, int length)
{
    string[] newArray = new string[length];
    int j = 0;
    for (int i = 0; i < arrayStr.Length; i++)
    {
        if (arrayStr[i].Length <= 3)
        {
            newArray[j] = arrayStr[i];
            j++;
        }
    }
    return newArray;
}
Console.Write("Введите количество значений массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] arrayStr = arrayString(length);
printArrayString(arrayStr);
Console.Write(" -> ");
int el3characters = elementsUpTo3characters(arrayStr);
string[] newArr = newArrayElementsUpTo3characters(arrayStr, el3characters);
printArrayString(newArr);
