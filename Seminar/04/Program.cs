// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    int b = int.Parse(a);

    return b;
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
int[] toFibon(int num)
{
    int[] array = new int[num];
    if (num != 0)
    {
        array[0] = 0;
        if (num > 1)
        {
            array[1] = 1;
            for (int i = 2; i < num; i++)
            {
                array[i] = array[i - 2] + array[i - 1];
            }
        }


    }
    return array;
}
printMassive(toFibon(ReadIn("введите натуральное число")));