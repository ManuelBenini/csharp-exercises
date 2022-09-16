#region SNACK 1

/* Consegna

    L'utente inserisce due numeri in successione. Il software stampa il maggiore.

*/

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
#endregion

#region SNACK 2

/* Consegna

    L'utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la più lunga.

*/

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
#endregion