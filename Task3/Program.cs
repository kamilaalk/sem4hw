int [] numbers = {1, 4, 6, 9, 3, 4};
int temp;

Console.Write("Исходный массив: ");
foreach (int number in numbers)
{
Console.Write(number + " ");
}

for (int i = 0; i < numbers.Length / 2; i++)
{
temp = numbers[i];
numbers[i] = numbers[numbers.Length - 1 - i];
numbers[numbers.Length - 1 - i] = temp;
}

Console.Write("\nПеревернутый массив: ");
foreach (int number in numbers)
{
    Console.Write(number + " ");
}