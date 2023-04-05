//Snack 1 

int num1;
int num2;

string parola1;
string parola2;

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