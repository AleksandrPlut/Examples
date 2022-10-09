// See Conditions If and Else
Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "plut")
{
    Console.WriteLine("Рад встречи с тобой о Великий, Plut");
}
else
{
    Console.Write("Чего тебе смертный, ");
    Console.WriteLine(username);
}