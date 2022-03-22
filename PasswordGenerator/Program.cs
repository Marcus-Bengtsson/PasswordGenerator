using static passwordGenerator.GenerateRandom;
Random random = new Random();

if (!IsValid(args))
{
    ShowHelpText();
    return;
}

int passwordLength = Convert.ToInt32(args[0]);
string pattern = args[1];
string password = "";
pattern = pattern.PadRight(passwordLength, 'l');

//Console.WriteLine(pattern);
while (pattern.Length > 0)
{
    int nextCharIndex = random.Next(0, pattern.Length - 1);
    string c = pattern.Substring(nextCharIndex, 1);
    if (c == "l")
    {
        password += GenerateRandomLowerCaseLetter();
    }
    else if (c == "L")
    {
        password += GenerateRandomUpperCaseLetter();
    }
    else if (c == "d")
    {
        password += GenerateRandomDigit();
    }
    else if (c == "s")
    {
        password += GenerateRandomSpecialCharacter();
    }
    else
    {
        ShowHelpText();
        return;
    }
    
    pattern = pattern.Remove(nextCharIndex, 1);
    //Console.WriteLine(pattern);
}
Console.WriteLine(password);

static void ShowHelpText()
{
    Console.WriteLine(
@"PasswordGenerator
Options:
- l = lower case 
- L = upper case letter 
- d = digit 
- s = special character !""#¤%&/(){}[]
Example: PasswordGenerator 14 lLssdd
Min. 1 lower case
Min. 1 upper case
Min. 2 special characters
Min. 2 digits");
}

static bool IsValid(string[] args)
{
    if (args.Length == 2)
    {
        foreach (var c in args[0])
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }


        foreach (var c in args[1])
        {
            if (c != 'l' && c != 'L' && c != 's' && c != 'd')
            {
                return false;
            }
        }
        return true;
    }
    return false;
}