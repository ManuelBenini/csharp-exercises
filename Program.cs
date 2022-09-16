#region SNACK 1

/* Consegna

    L'utente inserisce due numeri in successione. Il software stampa il maggiore.

*/

/*

Console.WriteLine("Inserire primo numero");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserire secondo numero");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Il numero più grande è {firstNumber}, il più piccolo è {secondNumber}");
}
else
{
    Console.WriteLine($"Il numero più grande è {secondNumber}, il più piccolo è {firstNumber}");
}

*/

#endregion

#region SNACK 2

/* Consegna

    L'utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la più lunga.

*/

/*

Console.WriteLine("Inserire prima parola");
string firstWord = Console.ReadLine();

Console.WriteLine("Inserire seconda parola");
string secondWord = Console.ReadLine();

if (firstWord.Length > secondWord.Length)
{
    Console.WriteLine($"La parola più corta è {secondWord}, la più lunga è {firstWord}");
}
else
{
    Console.WriteLine($"La parola più corta è {firstWord}, la più lunga è {secondWord}");
}

*/

#endregion

#region SNACK 3

/* Consegna

    Il software deve chiedere per 10 volte all'utente di inserire un numero.
    Il programma stampa la somma di tutti i numeri inseriti.

*/

/*

int n = 10;
int sum = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Inserire un numero. Numeri rimanenti: {n - i}");
    int number = Convert.ToInt32(Console.ReadLine());

    sum = sum + number;
}

Console.WriteLine($"La somma di tutti i numeri inseriti è: {sum}");

*/

#endregion

#region SNACK 4

/* Consegna

    Calcola la somma e la media dei numeri da 2 a 10

*/

/*

int numbers = 10; 
int sum = 0;

for (int i = 2; i <= numbers; i++)
{
    sum = sum + i;
}

float median = (float)sum / (numbers - 2);

Console.WriteLine($"La somma dei numeri da 2 a 10 è: {sum} , mentre la media è {median}");

*/

#endregion

#region SNACK 5

/* Consegna

    Il software chiede all'utente di inserire un numero. Se il numero inserito è pari, stampa il numero,
    se è dispari, stampa il numero successivo.

*/

/*

Console.WriteLine("Inserire un numero");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Il numero inserito ({number}) è pari");
}
else
{
    Console.WriteLine($"Il numero inserito ({number} è dispari, per cui verrà stampato il numero successivo: {number + 1})");
}

*/

#endregion

#region SNACK 6

/* Consegna

    In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
    Chiedi all'utente il suo nome e comunicagli se può partecipare o meno alla festa.

*/

/*

string[] invitedGuests = { "Paolo", "Manuel", "Agostino", "Silvia", "Andrea", "Luca", "Sebastiano" };
bool isUserInvited = false;

Console.WriteLine("Scopri se sei invitato alla festa inserendo il tuo nome");
string guestName = Console.ReadLine();

for (int i = 0; i < invitedGuests.Length; i++)
{
    if (invitedGuests[i].ToLower() == guestName.ToLower())
    {
        isUserInvited = true;
    }
}

if (isUserInvited)
{
    Console.WriteLine("Sei nella lista degli invitati!");
}
else
{
    Console.WriteLine("Non sei nella lista degli invitati");
}

*/

#endregion

#region SNACK 7

/* Consegna

    Crea un array vuoto. Chiedi per 6 volte all'utente di inserire un numero, se è dispari inseriscilo nell'array.

*/


int[] oddNumbers = new int[6];

for (int i = 0; i < oddNumbers.Length; i++)
{
    Console.WriteLine($"Inserire un numero. Numeri da inserire rimanenti: {oddNumbers.Length - i}");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber % 2 != 0)
    {
        oddNumbers[i] = userNumber;
    }
}

Console.WriteLine($"L'array dei numeri dispari contiene questi numeri: {string.Join(", ", oddNumbers)}");

#endregion