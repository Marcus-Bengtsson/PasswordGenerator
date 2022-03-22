namespace passwordGenerator
{
	public static class GenerateRandom
    {
        static readonly Random Random = new();
        public static char GenerateRandomLowerCaseLetter()
        {
            return (char)Random.Next('a', 'z' + 1);
        }
        public static char GenerateRandomUpperCaseLetter()
        {
            return (char)Random.Next('A', 'Z' + 1);
        }
        public static string GenerateRandomDigit()
        {
            return Random.Next(0, 10).ToString();
        }
        public static string GenerateRandomSpecialCharacter()
        {
            string[] specialCharacters = {"!", "\"", "#", "¤", "%", "&", "/", "(", ")", "{", "}", "[", "]"};
            return specialCharacters[Random.Next(0, specialCharacters.Length)];
        }
    }
}

