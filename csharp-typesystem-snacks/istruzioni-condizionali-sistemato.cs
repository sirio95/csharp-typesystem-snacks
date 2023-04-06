using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_typesystem_snacks
{
    internal class istruzioni_condizionali_sistemato
    {
        static void Main(string[] args)
        {
            Snack1();
            Snack2();
            Snack3();
            Snack4();
            Snack5();
            Snack6();
        }


        public static void Snack1()
        {
            Console.WriteLine("---- SNACK 1 ----");

            int num1;
            int num2;

            Console.WriteLine("Inserisci due numeri in successione");

            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Non hai inserito numeri validi");
            }
            while(!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Non hai inserito numeri validi");
            }

            if (num1 > num2)
                Console.WriteLine($"il numero maggiore è: {num1}");
            else if (num1 < num2)
                Console.WriteLine($"il numero maggiore è: {num2}");
            else Console.WriteLine($"i due numeri inseriti ({num1} e {num2}) sono uguali");


            Console.WriteLine("Inserisci, ora, due parole in successione");

            string parola1;
            string parola2;
            do
            {
                parola1 = Console.ReadLine();
                parola2 = Console.ReadLine();
            } while (parola1 != null && parola2 != null);


            if (parola1.Length > parola2.Length)
                Console.WriteLine($"La parola più lunga è: {parola1}");
            else if (parola1.Length < parola2.Length)
                Console.WriteLine($"La parola più lunga è: {parola2}");
            else
                Console.WriteLine($"Le due parole ({parola1} e {parola2}) sono di uguale lunghezza");
        }

        public static void Snack2()
        {
            Console.WriteLine("----- SNACK 2 ----");


            int[] userNum = new int[10];
            int sumPartial = 0;

            Console.WriteLine("inserisci 10 numeri in successione");

            for (int i = 0; i < userNum.Length; i++)
            {
                int num;

                while(!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Sono accetti solo numeri");
                }
                userNum[i] = num;
                if (i >= 2)
                {
                    sumPartial += userNum[i];
                }
            }

            //metodo con copia di array

            /*int[] userNumMin2 = new int[8];
            Array.Copy(userNum, 2, userNumMin2, 0, 8);
            int sumUserNumMin2 = userNumMin2.Sum();
            int avgUserNum = userNumMin2.Sum() / userNumMin2.Length;*/

            //metodo senza copia di array
            int userNumSum = userNum.Sum();

            Console.WriteLine($"La somma dei numeri inseriti è: {userNumSum}");
            Console.WriteLine($"La somma degli ultimi 8 numeri inseriti è: {sumPartial} e la loro media è: {sumPartial / 8}");
        }

        public static void Snack3()
        {

            Console.WriteLine("----- SNACK 3 ----");

            Console.WriteLine("Inserisci un numero");

            int numEvenOdd;
            while(!int.TryParse(Console.ReadLine(), out numEvenOdd))
            {
                Console.WriteLine("Devi inserire un vero numero");
            }

            if (numEvenOdd % 2 == 0)
                Console.WriteLine($"Il numero che hai inserito ({numEvenOdd}) è pari");
            else
                Console.WriteLine($"Il numero pari più vicino a quello da te indicato è: {numEvenOdd + 1}");
        }

        public static void Snack4()
        {
            Console.WriteLine("----- SNACK 4 ----");
            //festa & invitati

            string[] partyname = { "nome1", "nome2", "nome3", "nome4", "nome5", "nome6", "nome7", "nome8", "nome9", "nome10" };

            Console.WriteLine("Inserisci il tuo nome per vedere se sei invitato a festa Gatsby");
            string userName;

            do
            {
                userName = Console.ReadLine();
            }while(userName != null);

            bool invited = Array.Exists(partyname, element => element == userName);
            if (invited)
                Console.WriteLine($"{userName} sei nella lista. Goditi la festa!");
            else
                Console.WriteLine($"{userName} non sei invitato. Non puoi entrare!");


            //numeri dispari (o forse pari?)


            int[] numEven = new int[6];
            int[] numOdd = new int[6];

            Console.WriteLine("Inserisci 6 numeri in successione");

            for (int i = 0; i < 6; i++)
            {
                int numSnack4;
                while(!int.TryParse(Console.ReadLine(),out numSnack4))
                {
                    Console.WriteLine("Il numero inserito non è valido");
                }
                if (numSnack4 % 2 == 0)
                    numEven[i] = numSnack4;
                else
                    numOdd[i] = numSnack4;
                    
            }

            Console.WriteLine($"I numeri dispari che hai scritto sono:");
            foreach (int num in numOdd)
            {
                if(num != 0) Console.WriteLine(num);
            }


            Console.WriteLine($"Invece i numeri pari sono:");
            foreach (int num in numEven)
            {
                if (num != 0) Console.WriteLine(num);
            };

            //somma numeri ad indice dispari

            Console.WriteLine("Magia: vedrai prima un insieme di numeri e poi, magicamente, SOLO la somma di quelli in posizione dispari");
            
            int[] arrSumOdd = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int sum = 0;

            for (int i = 0; i < arrSumOdd.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {arrSumOdd[i]}");
                if ((i + 1) % 2 != 0) sum += arrSumOdd[i];
            }

            Console.WriteLine($"La somma totale degli elementi a indice dispari dell'array è: {sum}");
        }

        public static void Snack5()
        {
            Console.WriteLine("----- SNACK 2 ----");

            //ciclo while

            Console.WriteLine("Devi continuare a inserire numeri fino a quando la loro somma non sarà maggiore o uguale a 50");


            int[] numSnack = new int[50];

            while (numSnack.Sum() <= 50)
            {
                int newNum;
                int i = 0;
                while(!int.TryParse(Console.ReadLine(), out newNum))
                {
                    Console.WriteLine("Devi inserire un numero, non altri caratteri");
                }
                numSnack[i]= newNum;
                i++;
            }
            Console.WriteLine($"Perfetto. La somma dei numeri inseriti è: {numSnack.Sum()}");

            //Random

            Console.WriteLine("Digita un numero casuale");
            int userRandNum;
            if (int.TryParse(Console.ReadLine(), out userRandNum))
            {
                if (userRandNum > 0)
                {
                    int[][] arrSquare = new int[userRandNum][];
                    int[] randomArr = new int[10];
                    for (int i = 0; i < userRandNum; i++)
                    {

                        for (int a = 0; a < randomArr.Length; a++)
                        {
                            Random rnd = new Random();
                            int casualNum = rnd.Next(100, 1000);

                            randomArr[a] = casualNum;
                        }
                        arrSquare[i] = randomArr;
                    }
                    for (int i = 0; i < arrSquare.Length; i++)
                    {
                        Console.WriteLine($"insieme numero {i + 1} di 10 numeri casuali");
                        foreach (int a in arrSquare[i]) Console.WriteLine(a);
                    }
                }
                else
                    Console.WriteLine("Non puoi inserire numeri negativi");


            }
            else
                Console.WriteLine("Il numero non è valido");
        }

        public static void Snack6()
        {
            Console.WriteLine("----- SNACK 6 ------");
            Console.WriteLine("Inserisci due parole");


            string word1;
            string word2;

            do
            {
                word1 = Console.ReadLine();
                word2 = Console.ReadLine();
            }while(word1 != null && word2 != null);

            LongestWord(word1, word2);
            static void LongestWord(string word1, string word2)
            {
                if (word1.Length == word2.Length)
                    Console.WriteLine($"le due parole ({word1} e {word2}) hanno la stessa lunghezza");
                else if (word1.Length < word2.Length)
                    Console.WriteLine($"{word2} è più lunga");
                else
                    Console.WriteLine($"{word1} è più lunga");
            }


            //numeri pari o dispari? Funzion(e)?

            int primo;

            Console.WriteLine("Inserisci un numero casuale");

            while(!int.TryParse(Console.ReadLine(), out primo))
            {
                Console.WriteLine("il numero inserito non è valido. RITENTA!");
            }

            
            EvenOdd(primo);
            
            
            static void EvenOdd(int primo)
            {
                if (primo % 2 == 0) Console.WriteLine($"{primo} è pari");
                else Console.WriteLine($"{primo} è dispari");
            }
        }
    }
}
