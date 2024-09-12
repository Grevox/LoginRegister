Console.WriteLine("Hello, welcome to the loginform made by Grevox! it's pretty simple. press enter to continue");
Console.ReadLine();
Console.WriteLine("Ok, so You need to register first (or any other time u login, because I'm broke and i dont know how to connect this to a database");
Console.WriteLine("Press Enter to continue");
Console.ReadLine();
Console.WriteLine("Input username here, please");
string username  = Console.ReadLine();
Console.WriteLine("ok, so now input the password");
string password = Console.ReadLine();
Console.WriteLine("Great! now just login with the username first and then with the password!");
Console.WriteLine("username = ");
string usernameChek = Console.ReadLine();
Console.WriteLine("Password = ");
string passwordChek = Console.ReadLine();
if (usernameChek == username)
{
    Console.WriteLine("username is correct");
}
 if (username != usernameChek)
{
    Console.WriteLine("username incorrect");
}
if (passwordChek == password)
{
    Console.WriteLine("password is correct");
}
if (password != passwordChek)
{
    Console.WriteLine("Password is incorrect");
}
if (username == usernameChek || password == passwordChek)
{
    Console.WriteLine("You're all set! u can enjoy now the ending! the username and password are both correct");
}