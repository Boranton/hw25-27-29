

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArray(numbers);
WriteArray(numbers);
double min = numbers[0];
double max = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] < min) min = numbers[i];
    else if (numbers[i] > max) max = numbers[i];
}

Console.Write(max - min);

void FillArray(double[] array)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(1000)/10.0);
    }
}

void WriteArray(double[] array)
{
    for (int index = 0; index < array.Length;index++)
    continue;
    Console.Write("[" + String.Join(", ", array) + "] разница между максимальным и минимальным элементом равна  ");
}
