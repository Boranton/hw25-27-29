// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] FillArray(int size)
{
    
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine("Ваш массив: " + string.Join(", ", array));
int count = 0;
for (int i = 0; i < array.Length; i++)
 {
     if(array[i] % 2 == 0)
    {
         count++;
     }
 }

 Console.WriteLine("Колличество четных чисел:" + count );
