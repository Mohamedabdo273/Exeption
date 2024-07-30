namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CheckForVowels("Hello");
                CheckForVowels("bcd");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        static void CheckForVowels(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            bool containsVowel = false;
            foreach (char e in vowels)
            {
                foreach (char i in input.ToLower())
                {
                    if (i == e)
                    {
                        containsVowel = true;
                        break;
                    }
                }
            }
            if (!containsVowel)
            {
                throw new ArgumentException("The input string does not contain any vowels");
            }

            Console.WriteLine("The input string contains vowels.");
        }
    }
}
