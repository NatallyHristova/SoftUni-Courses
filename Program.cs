using System.Text;

string text = Console.ReadLine();

StringBuilder digit = new StringBuilder();


StringBuilder letters = new StringBuilder();


StringBuilder otherCharacters = new StringBuilder();

foreach(char symbol in text)
{
    if (char.IsDigit(symbol))
    {
        digit.Append(symbol);
    }
    else if (char.IsLetter(symbol))
    {
        letters.Append(symbol);
    }
    else
    {
        otherCharacters.Append(symbol);
    }

}

Console.WriteLine(digit);
Console.WriteLine(letters);
Console.WriteLine(otherCharacters);