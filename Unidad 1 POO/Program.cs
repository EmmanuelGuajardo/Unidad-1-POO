class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine().ToLower();
        // Convert the word to lowercase to make the comparison case-insensitively

        bool find;

        do
        {
           Console.WriteLine("Enter a letter:");
            char letter = Console.ReadLine().ToLower()[0];
            // Convert the letter to lowercase and take only the first character
            Console.Clear();

            find = SearchLetterInTheWord(word, letter);

            if (find)
            {
                Console.WriteLine("The letter '" + letter + "' is present in the word '" + word + "'.");
            }
            else
            {
                Console.WriteLine("The letter '" + letter + "' isn´t present in the word '" + word + "'.");
            }
        } while (true);
    }

    static bool SearchLetterInTheWord(string word, char letter)
    {
        foreach (char character in word)
        // Cycle through each character of the word and compare it to the letter you are looking for
        {
            if (character == letter)
            {
                return true; 
                // The letter is present in the word
            }
        }
        return false; 
        // The letter isn´t present in the word
    }
}