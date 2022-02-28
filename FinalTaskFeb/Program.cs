// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] sourceArray = {"hello", "12345", "red", "world", "1984", "cat", "computer science", ":-)"};

int CountNewArray(string[] array)
{
    int newCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i].Length <=3)
          newCount++; 
    }
    return newCount;
}
void GenerateNewArray(string[] array, string[] newArray)
{
    int countNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[countNewArray] = array[i];
            countNewArray++;
        }
    }
}
void PrintArray(string[] array)
{
    int length = array.Length;
    Console.Write("[");
    for (int i = 0; i < length - 1; i++)
        Console.Write($"'{array[i]}', ");
    Console.WriteLine($"'{array[length - 1]}']");
}

