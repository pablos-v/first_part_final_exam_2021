int[] startArray = { 1, 2, 3, 4, 5, 6 };

int count = 0;
for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i] % 2 == 0)
    {
        startArray[count++] = startArray[i];
    }
}
int[] evenArray = new int[count];

for (int i = 0; i < count; i++)
{
    evenArray[i] = startArray[i];
}

Console.Write(string.Join(' ', evenArray));