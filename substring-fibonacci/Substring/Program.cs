// See https://aka.ms/new-console-template for more information

//  substring

Console.Write("Input string: ");
string input1 = Console.ReadLine();
Console.Write("input substring to search: ");
string input2 = Console.ReadLine();

if (input1.Contains(input2)) {
    Console.WriteLine($"String contains {input2} substring");
} else {
    Console.WriteLine($"String does not contain {input2} substring");
}


//---------------------------------------------------------------------


//fibonacci 0 1 1 2 3 5 8....


Console.Write("Input number: ");
int input = Convert.ToInt32( Console.ReadLine());
int num1 = 0;
int num2 = 1;
int result;

//a=0 b=1 c=a+b >1
//a=1 b=1 c=a+b >2
//a=1 b=2 c=a+b >3
for (int i = 0; i < input; i++) {
    Console.Write($"{num1} ");
    result = num1 + num2;
    num1 = num2;
    num2 = result;
}

Console.ReadLine();



