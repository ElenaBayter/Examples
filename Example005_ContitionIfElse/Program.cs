Console.Write("TextWriter username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Hurray, its MASHA");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}