int ThirdDigit(int x)
{
   string result = x.ToString();
   return int.Parse(result[2].ToString());
} 

Console.Write("Введите число: ");

int num = int.Parse(Console.ReadLine());

if (num.ToString().Length >= 3)
{
    int middleDigit = ThirdDigit(num);
    Console.Write(middleDigit);
}
else
{
    Console.WriteLine("Третьего числа нет!");
}
