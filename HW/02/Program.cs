// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}
void printMassive(double[] massive) //метод ля вывода массива
{
    foreach (var item in massive)/*оператор для вывода массива (каждый элемент в массиве massive называется item (в данном случае) )
                                    и для каждого элемента выполняется описаное ниже действие, пока не закончится массив)*/
    {
        Console.Write(item + " ");

    }
    Console.WriteLine();
}
double[] CreateMassive(double num) //Метод для создания массива определённой длины
{
    double[] array = new double[2];//создаём массив заданной длинны
    int i = 0;
    while (i < 2) //счётчик менее длины массива
    {
        array[i] = ReadIn("Введите коэфициент" + (i+1) + " для линии " + num + ":"); //заполнение поля массива случайным числом
        i++;
    }
    
    return array; //возврат массва из функции
}
double[] dot(double[] line1, double[] line2)
{
printMassive(line1);
printMassive(line2);
    double x = (line1[0] - line2[0]) / (line2[1] - line1[1]);
    double y = line2[1] * x + line2[0];
    double[] array = new double[2];
    array[0] = x;
    array[1] = y;
    
    return array;
}

double[] line1 = CreateMassive(1);//коэфициенты для линии 1
double[] line2 = CreateMassive(2);//коэфициенты для линии 2
double[] dotMassive = dot(line1, line2);//вычисление координат точки пересечения прямых
printMassive(dotMassive);//вывод координат
