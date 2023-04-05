//Snack 1 numeri

int num1;
int num2;

Console.WriteLine("Inserisci due numeri in successione");
if (int.TryParse(Console.ReadLine(), out num1) && int.TryParse(Console.ReadLine(), out num2))
{
    if (num1 > num2)
        Console.WriteLine($"il numero maggiore è: {num1}");
    else if (num1 < num2)
        Console.WriteLine($"il numero maggiore è: {num2}");
    else Console.WriteLine($"i due numeri inseriti ({num1} e {num2}) sono uguali");
}
else
    Console.WriteLine("Non hai inserito numeri validi");

// Snack 1 parole

Console.WriteLine("Inserisci due parole in successione");

string? parola1 = Console.ReadLine();
string? parola2 = Console.ReadLine();
if (parola1 != null && parola2 != null)
{
    if (parola1.Length > parola2.Length)
        Console.WriteLine($"La parola più lunga è: {parola1}");
    else if (parola1.Length < parola2.Length)
        Console.WriteLine($"La parola più lunga è: {parola2}");
    else
        Console.WriteLine($"Le due parole ({parola1} e {parola2}) sono di uguale lunghezza");
}
else
    Console.WriteLine("Non puoi inserire parole nulle");
