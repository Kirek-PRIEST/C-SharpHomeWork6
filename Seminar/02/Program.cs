// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}
void printResult(string msg)
{

}

int Edge1 = ReadIn("Введите длину стороны 1");
int Edge2 = ReadIn("Введите длину стороны 2");
int Edge3 = ReadIn("Введите длину стороны 3");
bool treangleChec(int Edge1, int Edge2, int Edge3)
{
    if (Edge1 + Edge2 > Edge3 && Edge2 + Edge3 > Edge1 && Edge3 + Edge1 > Edge2)
    {
        return true;
    }
    else
    {
    
    return false;
    }
}

Console.WriteLine((treangleChec(Edge1, Edge2, Edge3)? "Треугольник существует": "Треугольник не существует"));
