using System.Linq;

//Snack 1 istruzioni condizionali

/* int num1;
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
    Console.WriteLine("Non puoi inserire parole nulle"); */

// Snack 2 - Ciclo For


/*int[] userNum = new int[10];


Console.WriteLine("inserisci 10 numeri in successione");

for (int i = 0; i < userNum.Length; i++)
{
    int num;
    if (int.TryParse(Console.ReadLine(), out num))
    {
        userNum[i] = num;
    }

    else
        Console.WriteLine("Inserisci numeri validi");
}

int[] userNumMin2 = new int[8];
Array.Copy(userNum, 0, userNumMin2, 0, 8);
int userNumSum = userNum.Sum();
int sumUserNumMin2 = userNumMin2.Sum();
int avgUserNum= userNumMin2.Sum() / userNumMin2.Length;

Console.WriteLine($"La somma dei numeri inseriti è: {userNumSum}");
Console.WriteLine($"La somma degli ultimi 8 numeri inseriti è: {sumUserNumMin2} e la loro media è: {avgUserNum}");*/


//Snack 3 - Operatore modulo

Console.WriteLine("Inserisci un numero");

int numEvenOdd;
if (int.TryParse(Console.ReadLine(), out numEvenOdd))
{
    if (numEvenOdd % 2 == 0)
        Console.WriteLine($"Il numero che hai inserito ({numEvenOdd}) è pari");
    else
        Console.WriteLine($"Il numero pari più vicino a quello da te indicato è: {numEvenOdd + 1}");
}
else
    Console.WriteLine("Il numero non è valido");




