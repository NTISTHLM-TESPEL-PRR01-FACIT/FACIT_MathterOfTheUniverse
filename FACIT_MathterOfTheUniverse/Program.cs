Mathter();


static void Mathter()
{

  int points = 0;
  int answer = 0;

  int correctAnswer = 7;
  int factor = 6;
  int sum = correctAnswer * factor;

  string answerString = "";
  bool successful = false;

  Console.WriteLine("Välkommen till mattespelet MATHTER OF THE UNIVERSE!");

  Console.WriteLine($"x * {factor} = {sum}");
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

  if (answer != correctAnswer)
  {
    int falseSum = answer * factor;
    Console.WriteLine($"Nej! {answer} * {factor} = {falseSum}.");

    if (answer < correctAnswer)
    {
      Console.WriteLine("Ditt svar var för lågt.");
    }
    else if (answer > correctAnswer)
    {
      Console.WriteLine("Ditt svar var för högt.");
    }
  }
  else
  {
    points++;
    Console.WriteLine($"Korrekt! Du får 1 poäng och har nu totalt {points} poäng.");
  }

  Console.WriteLine("Tryck på ENTER för att avsluta.");
  Console.ReadLine();
}