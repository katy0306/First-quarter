// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
string[] array = {"Dog", "Mouse", "Rabbit", "Horse", "Duck","Cat"};
int length = array.Length;
string[] array2 = new string[length];
for (int i = 0; i < length; i++)
{
    if (array[i].Length < 4)
    {
        array2[i] = array[i];
    }
}
void PrintArray(string[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if (arr[i] != "")
        {
            Console.Write($"{arr[i]}   ");
        }
    }
}
PrintArray(array2);