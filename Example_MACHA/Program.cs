Console.WriteLine("Введите своё имя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("fack you");
}
else
{
    Console.Write("Добро пожаловать,");
    Console.WriteLine(username);
}
