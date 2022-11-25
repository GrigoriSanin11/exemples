Console.WriteLine("Введите число A") ; 
int namber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B") ; 
int namber2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C") ; 
int namber3 = Convert.ToInt32(Console.ReadLine());

int MAX = namber1;

if (namber1 > MAX) MAX = namber1;
if (namber2 > MAX) MAX = namber2;
if (namber3 > MAX) MAX = namber3;

Console.Write("MAX = ");
Console.WriteLine(MAX);