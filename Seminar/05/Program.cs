// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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
        array[i] = new Random().Next(10); //заполнение поля массива случайным числом
        i++;
    }
    return array; //возврат массва из функции
}
int[] copyArray(int[] array)
{
    int[] massive = new int[array.Length];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = array[i];
    }
    return massive;
}
int lenght = ReadIn("Введите длину массива:");
int[] massive = CreateMassive(lenght);
int[] massive2 = copyArray(massive);
printMassive(massive);
massive[0] = 100;
printMassive(massive);
printMassive(massive2);