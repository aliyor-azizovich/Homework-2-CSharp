int Middle(int x)
{
   string result = x.ToString();
   return int.Parse(result[1].ToString());
} 

Console.Write("Введите трехзначное число: ");

int num = int.Parse(Console.ReadLine());

if (num.ToString().Length == 3)
{
    int middleDigit = Middle(num);
    Console.Write(middleDigit);
}
else
{
    Console.WriteLine("Это не трехзначное число!");
}