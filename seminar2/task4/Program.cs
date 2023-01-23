bool func()
{
    Console.WriteLine("func");
    return true;
}

int x = 0;

if(x >= 50 && func())
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
