// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.WriteLine("Введите количество элментов массива: ");
int[] mass = new int[Convert.ToInt32(Console.ReadLine())];
void FillMass()
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.WriteLine($"Введите {i} число массива: ");
        mass[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Clear();
}
void PrintMass(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void Compare(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Вы ввели {count} числа(-ел), котоорые больше 0");
}
FillMass();
PrintMass(mass);
Compare(mass);