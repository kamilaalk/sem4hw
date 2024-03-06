int [] numbers = new int [10];
Random random = new Random();
int CountEven = 0;

for(int i = 0; i < numbers.Length; i++){
    numbers[i] = random.Next(100, 1000);
    Console.Write(numbers[i] + " "); 
if (numbers[i] % 2 == 0)
{
CountEven++;
}
}
Console.WriteLine($"Количество четных чисел в массиве: {CountEven}");