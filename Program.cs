/* Задача 47. Задайте двумерный массив (вручную) размером m×n, 
заполненный вещественными числами.
Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает 
индекс этого элемента или же указание, что такого элемента нет. Если элементов несколько, то выводим
позицию каждого. Двумерный массив задаётся на ваш выбор
Задача 52. Задайте двумерный массив (вручную) из целых чисел. Найдите среднее арифметическое элементов 
в каждом столбце. */

Console.WriteLine ("Выберите номер задачи");
Console.WriteLine ("Задача 47. Заполнить двумерный массив вещественными числами");
Console.WriteLine ("Задача 50. Возвращает индекс элемента двумерн массива");
Console.WriteLine ("Задача 52. Найти средн. арифм. элементов в каждом солбце");
int n = Convert.ToInt32(Console.ReadLine ());

switch (n)
{
    case 47:
        Task47();
        break;
    case 50:
        Task50();
        break;
    case 52:
        Task52();
        break;
    default:
        break;
}
void Task47()
{
    Console.WriteLine("Введите m и n");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    double [,] array2d = new double [m,n];
    Console.WriteLine("Введите элементы вашего массива построчно через запятую");
    for (int i = 0; i < m; i++)
    {   
        string []text = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
        for(int j = 0; j < n; j++)
        { 
            array2d [i,j] = Convert.ToInt32(text[j]);
        }
    }
}

void Task50()
{
    Console.WriteLine("Введите m и n");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите искомый элемент");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int [,] array2d = new int [m,n];
    Random random = new Random ();
    bool f = false;
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
         array2d [i,j] = random.Next(1,5);
         Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();
    for ( int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array2d[i,j] == number)
            {  
                f = true;
                Console.WriteLine("Индекс заданного элемента " + i + " , " + j);
            }     
        }
    }
    if (f==false)
        Console.WriteLine("Число не найдено");
}

void Task52()
{
    Console.WriteLine("Введите m и n");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int [,] array2d = new int [m,n];
    Console.WriteLine("задайте массив построчно через запятую");
    for (int i = 0; i < m; i++)
    {  
        string []text = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
        for(int j = 0; j < n; j++)
        { 
            array2d [i,j] = Convert.ToInt32(text[j]);
        }
    }
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        double sum = 0;
        for (int i = 0; i < m; i++)
        {
            sum += array2d[i, j];
        }
        Console.WriteLine($"Среднее арифметическое {j+1} столбца:{ sum / m} ");
    }
}

