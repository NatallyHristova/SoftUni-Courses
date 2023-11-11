

string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();

foreach (string word in bannedWords)
{
    string censorWord = "".PadLeft(word.Length, '*');

    if (text.Contains(word))
    {
        text = text.Replace(word, censorWord);
    }
}

Console.WriteLine(text);