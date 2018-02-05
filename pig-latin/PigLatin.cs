using System;

public static class PigLatin
{
    public static string Translate(string word)
    {

        string firstLetter = word.Substring(0, 1);
        string secondLetter = word.Substring(1, 1);
        string thirdLetter = word.Substring(2, 1);

        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        string translation = "";

        switch (firstLetter)
        {
            case "a":
                translation = word + "ay";
                break;
            case "e":
                translation = word + "ay";
                break;
            case "i":
                translation = word + "ay";
                break;
            case "o":
                translation = word + "ay";
                break;
            case "u":
                translation = word + "ay";
                break;
            default:
                // None of the other checks passed, so the word must start with a consonant.
                // Turn string into array of character.
                char[] charArray = word.ToCharArray();

                // check if the second letter is also a consonant, essentially verifying that the word starts with a consonant cluster
                bool isVowel = false;
                foreach (char letter in vowels)
                {
                    if (charArray[1] == letter)
                    {
                        if (letter != 'u')
                        {
                            // handles test where "queen" must be translated to "eenquay"
                            isVowel = true;
                        }
                    }
                }

                if (isVowel)
                {
                    // the second letter is a vowel
                    translation = word.Substring(1) + firstLetter + "ay";
                    isVowel = false; // reset value
                }
                else
                {
                    // check if the third letter is also a consonant, essentially verifying that the word starts with a consonant cluster
                    foreach (char letter in vowels)
                    {
                        if (charArray[2] == letter)
                        {
                            if (letter != 'u')
                            {
                                // handles test where "square" must be translated to "uaresqay"
                                isVowel = true;
                            }
                        }
                    }

                    if (isVowel)
                    {
                        // the second letter is consonant
                        translation = word.Substring(2) + firstLetter + secondLetter + "ay";
                    }
                    else
                    {
                        translation = word.Substring(3) + firstLetter + secondLetter + thirdLetter + "ay";
                    }

                }

                break;
        }

        return translation;
    }
}
