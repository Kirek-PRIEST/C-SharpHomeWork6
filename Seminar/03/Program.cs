// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}
void printMassive(int[] massive) //метод ля вывода массива
{
    foreach (var item in massive)/*оператор для вывода массива (каждый элемент в массиве massive называется item (в данном случае) )
                                    и для каждого элемента выполняется описаное ниже действие, пока не закончится массив)*/
    {
        Console.Write(item + " ");

    }
    Console.WriteLine();
}
int[] binarryArray(int num)
{
    int[] array = new int[8];
    int i = 0;
    int temp = 0;
    while (num > 0)
    {
        if (num % 2 == 0)
        {
            array[i] = 0;
        }
        else
        {
            array[i] = 1;
        }
        num = num / 2;
        i++;
    }
    return array;
}
int[] arrayRevers(int[] array)
{
    int temp = 0;
    int[] massive = array;
    for (int i = 0; i < massive.Length / 2; i++)
    {
        temp = massive[i];
        massive[i] = massive[massive.Length - 1 - i];
        massive[massive.Length - 1 - i] = temp;
        
    }
    printMassive(array);
    return massive;
}
//int[] massive = binarryArray(ReadIn("Введу число:"));
printMassive(arrayRevers(binarryArray(ReadIn("Введу число:"))));