/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9


int rows = ReadInt("Введите количество строк: ");
int colums = ReadInt("Введите количество столбцов: ");
double[,] numbers = new double[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);


void FillArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}

void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[6, 8];
FillArray2D(numbers);
PrintArray2D(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
/*
 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int rows = 3;
int colums = 4;
int[,] numbers = new int[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);

double[] avgNumbers = new double[numbers.GetLength(1)];

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        result += numbers[j, i];
    }
    avgNumbers[i] = result / numbers.GetLength(0);
}
PrintArray(avgNumbers);



void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];

void mas(int m)
{
for (int i = 0; i < m; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива ");
Array[i] = Convert.ToInt32(Console.ReadLine());
}

}

int kol(int[] Array)
{
int i=0;
int sum = 0;
while (i < Array.Length)
{
if(Array[i]>0)
sum = sum + 1;
i = i + 1;
}
return sum;
}

mas(m);
Console.Write($"\n Чисел больше нуля: {kol(Array)}");

*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"\n Точка пересечения двух прямых: [{x},{y}]");
*/




//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
/*
 static void Main()
        {
            Console.WriteLine("Введите первую сторону");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третью сторону");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a<=0 || b<=0 || c<=0) || (a+b<=c || a+c<=b || c+b<=a))
            {
                Console.WriteLine("Треугольник не существует");
                Console.ReadKey();
                return;
            }
            Console.Write("Треугольник существует и он");
            int max=Math.Max(Math.Max(a, b), c);
            if (max == a)
            {
                a = b;
                b = c;
            }else
            if (max == b)
            {
                b = c;
            }
            Console.WriteLine("{0}является прямоугольным",Math.Pow(max,2)==Math.Pow(a,2)+Math.Pow(b,2)?" ":" не ");
            Console.ReadKey();
        }

        //Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

s = ""
n = int(input(
    "Введите число для преобразовывания десятичного числа в двоичное:\n"))
while n != 0:
    s = str(n % 2) + s
    n //= 2
print(s)
*/