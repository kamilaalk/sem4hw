while (true){
Console.Write("Введите число или 'q' для выхода: ");
string input = Console.ReadLine();
if (input == "q"){
    break;
}

int num = Convert.ToInt32(input);
int sum = 0;
while (num > 0){
    sum += num % 10;
    num /= 10;
}
if (sum % 2 == 0)
{
Console.WriteLine("[STOP]");
break;
}
}