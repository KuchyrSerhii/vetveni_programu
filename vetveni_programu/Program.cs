// See https://aka.ms/new-console-template for more information
Console.WriteLine("Umím porovnavát vaše číslo s číslem 5");
Console.WriteLine("Zadejte, prosím první číslo");
string z_klavesnice = Console.ReadLine();
Console.WriteLine("Zadejte, prosím druhý číslo");
string z_klavesnice2 = Console.ReadLine();
double a = Convert.ToDouble(z_klavesnice);
double b = Convert.ToDouble(z_klavesnice2);
if (a == b)
    Console.WriteLine("Čísla jsou stejná");
if (a < b)
    Console.WriteLine( a + " Je menší" );
if (a > b)
    Console.WriteLine( a + " Je větší" );
Console.ReadKey();