string GetLeter(string s)
{
    string letter = "";
    foreach (var e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letter = letter + e;
        }

    }
    return letter;


}
string str = Console.ReadLine();
string result = GetLeter(str);

System.Console.WriteLine(result);
