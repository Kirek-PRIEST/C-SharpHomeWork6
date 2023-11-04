// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
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

int[] CreateMassive(int length) //Метод для создания массива определённой длины
{
    int[] array = new int[length];//создаём массив заданной длинны
    int i = 0;
    while (i < array.Length) //счётчик менее длины массива
    {
        array[i] = ReadIn("Введите число "+(i+1)); //заполнение поля массива случайным числом
        i++;
    }
     printMassive(array);
    return array; //возврат массва из функции
   
}
int quantityOfPosityve(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
        count++;
        }
    }
    return count;
}

int quantity = ReadIn("Введите количество желаемых элементов");
int[] massive = CreateMassive(quantity);
Console.WriteLine("Количество положительных чисел в массиве: " + quantityOfPosityve(massive));