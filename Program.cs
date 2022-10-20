Console.WriteLine("Введите номер задания (1-3): ");
int Ex = int.Parse(Console.ReadLine()!);
switch (Ex) {
    case 1:

//Задание №1
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4
Console.WriteLine("----------Задание №1----------");
Console.WriteLine("Введите количество элементов массива (целочисленное число): ");
int Number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите {Number} элементов массива: ");
double[] Data = Zapol(Number);
Console.WriteLine($"Заданный массив: [{String.Join(" | ", Data)}]");

int count = 0;
for(int i = 0; i < Data.Length; i++){
    if (Data[i] > 0){
        count++;
    }
}    

Console.WriteLine($"Пользователь ввел {count} чисел больше 0");

double[] Zapol(int Num){
double[] collection = new double[Num];
for(int i = 0; i < collection.Length; i++) collection[i] = double.Parse(Console.ReadLine()!);
return collection;
}
        break;

    case 2:
//Задание №2
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("----------Задание №2----------");
Console.WriteLine("Введите значение b1 для первой прямой: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1 для первой прямой: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2 для первой прямой: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2 для первой прямой: ");
double k2 = int.Parse(Console.ReadLine()!);

double x, y;

x = (b2 - b1)/(k1 - k2);
y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых имеет координаты: ({x}; {y})");
        break;

    case 3:

//Задача №3
//Найти произведение всех элементов массива целых чисел, меньших заданного числа. 
//Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.
Console.WriteLine("----------Задание №3----------");
Console.WriteLine("Введите число, меньше которого искать произведение: ");
int A = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(10);
Console.WriteLine($"Исходный массив: {String.Join(", ", Array)}");

int composition = 1;
for(int i = 0; i < Array.Length; i++){
    if(Array[i] < A){
        composition = composition * Array[i];
    }
}
if (composition == 1) Console.WriteLine($"В массиве нет чисел, меньших числа {A}");
if (composition < A && composition > 1) Console.WriteLine($"В массиве одно число, меньшее числа {A} и оно = {composition}");  
else {
    if (composition > 2){
    Console.WriteLine($"Произведение чисел в массиве, меньших числа {A} = {composition}");
    }
}

int[] GetArray(int size){
    int[] res = new int[size];
    for(int i = 0; i < res.Length; i++){
        res[i] = new Random().Next(50,101);
    }
    return res;
}
        break;

    default:
        Console.WriteLine("Такое задание не выполнялось");
        break;
}