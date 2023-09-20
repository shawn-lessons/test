string StringJoin(string[] parts, string str2)
{
    string result = "";

    for(int i = 0; i < parts.Length; i++)
    {
        string part = parts[i];
        result = result + part;

        if (i != (parts.Length - 1))
            result = result + str2;
    }

    return result;
} 
string input = "The quick brown fox jumped over the lazy dog";
string[] parts = input.Split();
Console.WriteLine(StringJoin(parts, "-"));

