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

/*Console.WriteLine("Inserisci un numero");

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
*/

//Snack 4- Array

//festa fitzgerald

 string[] partyname = { "nome1", "nome2", "nome3", "nome4", "nome5", "nome6", "nome7", "nome8", "nome9", "nome10" };

Console.WriteLine("Inserisci il tuo nome per vedere se sei invitato a festa Gatsby");
string? userName = Console.ReadLine();

if (userName != null)
{
    bool invited = Array.Exists(partyname, element => element == userName);
    if (invited)
        Console.WriteLine($"{userName} sei nella lista. Goditi la festa!");
    else
        Console.WriteLine($"{userName} non sei invitato. Non puoi entrare!");
}
else
    Console.WriteLine("Non hai inserito un nome valido");


//numeri dispari (o forse pari?)

var numEven = new List<int>();
var numOdd = new List<int>();

Console.WriteLine("Inserisci 6 numeri in successione");

for(int i = 0; i < 6; i++)
{
    int numSnack4;
    if (int.TryParse(Console.ReadLine(), out numSnack4))
    {
        if (numSnack4 % 2 == 0) 
        numEven.Add(numSnack4); 
        else
            numOdd.Add(numSnack4);
    }
    else
        Console.WriteLine("Il numero inserito non è valido");
}

int[] arrNumEven = numEven.ToArray();
int[] arrNumOdd = numOdd.ToArray();

Console.WriteLine($"I numeri dispari che hai scritto sono:");
foreach (int num in arrNumOdd) Console.WriteLine(num); 


Console.WriteLine($"Invece i numeri pari sono:");
foreach (int num in arrNumEven) Console.WriteLine(num);

//somma numeri ad indice dispari

Console.WriteLine("Magia: vedrai prima un insieme di numeri e poi, magicamente, SOLO la somma di quelli in posizione dispari");
int[] arrSumOdd = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

for (int i = 0; i < arrSumOdd.Length; i++) Console.WriteLine($"{i}: {arrSumOdd[i]}");
var sumOdd = new List<int>();

for (int i = 0; i < arrSumOdd.Length; i++)
{
    if (arrSumOdd[i] % 2 != 0) sumOdd.Add(arrSumOdd[i]);
}
int[] sumTotalOdd = sumOdd.ToArray();
int sumTotal = sumTotalOdd.Sum();

Console.WriteLine($"La somma totale degli elementi a indice dispari dell'array è: {sumTotal}");

