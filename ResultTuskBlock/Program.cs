Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());


string[] Array(int size)            // создаём массив и вводим данные
{
    string[] massive = new string[size];

    for (int i = 0; i < massive.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}  элемент массива");
        massive[i] = Console.ReadLine();
    }
    return massive;
}

int NewSizeArray(string[] massive)     //получаем длину нового массива
{
    int newSize = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        int a = massive[i].Length;
        if (a <= 3) newSize++;
    }
    return newSize;
}

string[] MaxThirdElem(string[] massive, int newSize)  // в новый массив записываем значения элементов где меньше 4 символов
{
    string[] newArray = new string[newSize];

    int i = 0;
    int j = 0;

    while (i < massive.Length)
    {
        if (massive[i].Length < 4)
        {
            newArray[j] = massive[i];
            i++;
            j++;
        }
        else
            i++;
    }
    return newArray;
}

void PrintArrayDouble(string[] massive) // печатаем массив
{
    Console.Write("[ ");
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"{massive[i]}" + "  ");
    }
    Console.Write("]");
}


string[] array = Array(size);
PrintArrayDouble(array);
int newSizeArray = NewSizeArray(array);        // переменная - длина нового массива

string[] maxThirdElem = MaxThirdElem(array, newSizeArray);
Console.WriteLine();
Console.Write("Массив, элементы которых меньше трёх символов ");
PrintArrayDouble(maxThirdElem);