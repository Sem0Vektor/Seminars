//'ReadLine' only reads string types -
string input;
input = Console.ReadLine()!;
Console.WriteLine(input);
//how to read integer number, here are two types:
int number;
number = int.Parse(Console.ReadLine()!);
number = Convert.ToInt32(Console.ReadLine());

int squareOfNumber = number * number;
//you can add something to output in 'WriteLine' by '+':
Console.WriteLine("squared number is " + squareOfNumber);
//you can add something inside of quotes by '$' before them:
Console.WriteLine($"Square of {number} = {squareOfNumber}");

//maximum value of 'int32' is 'int.MaxValue', 'MinValue' is the opposite:
Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);

//you can make equations inside of brackets of 'WriteLine':
Console.WriteLine(number + number);