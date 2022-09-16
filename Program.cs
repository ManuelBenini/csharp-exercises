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