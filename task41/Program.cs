//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую: ");
string numbers = Console.ReadLine();
string [] ar = numbers.Split(",");
int[] array = Array.ConvertAll(ar, int.Parse);
Console.WriteLine("\nВаши числа: {0}",String.Join("|", array));

int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i]>0)
    count++;
    
}
Console.WriteLine(count);
