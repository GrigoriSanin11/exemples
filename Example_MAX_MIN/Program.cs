Console.WriteLine("Введите число A") ; 
int namber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B") ; 
int namber2 = Convert.ToInt32(Console.ReadLine());
int max = namber1;
int min = namber2;

if (namber1 == namber2)
{
    Console.WriteLine("Числа равны");
}

else if (max > namber2)
{
    max = namber1;
    min = namber2;
    Console.Write("max =");
    Console.WriteLine(max );

    Console.Write("min =");
    Console.WriteLine( min );

}
else 
{
    max = namber2;
    min = namber1;
    Console.Write("max =");
    Console.WriteLine(max );

    Console.Write("min =");
    Console.WriteLine( min );

}

