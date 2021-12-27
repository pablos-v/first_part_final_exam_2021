int[] RandomArray()
{
    int[] array = new int[new Random().Next(5, 10)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

int[] EvenArray(int[] startArray)
{
    int count = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i] % 2 == 0) 
        {
            startArray[count++] = startArray[i]; // Здесь мы складываем значения к началу массива и сразу считаем их количество
        }
    }
    int[] evenArray = new int[count];
    for (int i = 0; i < count; i++) evenArray[i] = startArray[i];
    return evenArray;
}

int[] startArray = RandomArray();
Console.WriteLine("Начальный массив: " + string.Join(' ', startArray));
int[] newArray = EvenArray(startArray);
Console.Write("Массив чётных чисел из начального массива: " + string.Join(' ', newArray));

