// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

//Main
// string[] array = Promt("Введите массив строк через запятую: ");
string[] array = {"Russia", "Denmark", "Kazan"};
int count = 0;
string[] result = new string[count];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        Array.Resize(ref result,count + 1);
        result[count++] = array[i];
    }
}
PrintResult(array, result);


//Methods
string[] Promt(string message)
{
    char[] separators = new char[] { ',', ';' };

    while (true)
    {
        Console.Write(message);
        string? value = Console.ReadLine();
        if (!String.IsNullOrEmpty(value))
        {
            string[] strValue = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return strValue;
        }
        System.Console.WriteLine("Введен пустой массив. Повторите попытку.");
    }
}

string[] AddItem(string[] array, string item)
{
    int size = array.Length + 1;
    Array.Resize(ref array, size);
    array[size - 1] = item;
    return array;
}

void PrintResult(string[] value, string[] resultValue)
{
    PrintArray(value);
    Console.Write(" --> ");
    PrintArray(resultValue);
}

void PrintArray(string[] value)
{
    Console.Write("[");
    for (int i = 0; i < value.Length; i++)
    {
        Console.Write(i < value.Length - 1 ? $"\"{value[i]}\", " : $"\"{value[i]}\"");
    }
    Console.Write("]");
}
