// See https://aka.ms/new-console-template for more information
string[] array1 = new string[4] {"Пекару", "23", "56", "world"};
string[] array2 = new string[array1.Length];
SecondArray(array1, array2);
PrintArray(array2);
void SecondArray(string[] array1, string[] array2)
{
    int n = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[n] = array1[i];
        n++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}