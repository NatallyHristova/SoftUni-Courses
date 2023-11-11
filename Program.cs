string[] words = Console.ReadLine().Split();

string output = "";

for (int i = 0; i < words.Length; i++)
{
    string curruntWort = words[i];
    for (int j = 0; j < curruntWort.Length; j++)
    {
        output += curruntWort;
    }
}
Console.WriteLine(output);
