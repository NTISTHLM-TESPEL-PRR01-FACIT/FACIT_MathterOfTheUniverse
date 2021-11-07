using System;

int points = 0;
int answer = 0;
string answerString = "";
bool successful = false;

Console.WriteLine("Välkommen till mattespelet MATHTER OF THE UNIVERSE!");

Console.WriteLine("x * 6 = 42");
Console.WriteLine("Vilket värde har x?");

while (successful == false)
{
    answerString = Console.ReadLine();
    successful = int.TryParse(answerString, out answer);

    if (!successful)
    {
        Console.WriteLine("Skriv bara siffror!");
    }
}

if (answer != 7)
{
    Console.WriteLine("Nej! " + answer + " * 6 = " + answer * 6 + ".");
}
else
{
    points++;
    Console.WriteLine("Korrekt! Du får 1 poäng och har nu totalt " + points + " poäng.");
}

Console.WriteLine("Tryck på ENTER för att avsluta.");
Console.ReadLine();