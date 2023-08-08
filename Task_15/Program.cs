

bool IsDayOff(int x)
{
    if (x ==6 || x==7)
    {
        return true;
    }    
    
    else
    {
         return false;
    }
} 

Console.Write("Enter the number of the day of the week: ");

int num = int.Parse(Console.ReadLine());

bool answer = IsDayOff(num);
Console.Write(answer ? "Yes" : "No");

