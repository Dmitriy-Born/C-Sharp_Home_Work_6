//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

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
