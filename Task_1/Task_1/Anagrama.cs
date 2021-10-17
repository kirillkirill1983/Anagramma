using System;


namespace Task_1
{
    public class Anagrama
    {
        public string Reverse(string myLine)
        {
            if (string.IsNullOrWhiteSpace(myLine))
            {
                throw new ArgumentNullException(nameof(myLine), "Error NULL"); ;
            }

            var separationIntoSpaces = myLine.Split(' ');
            var wordInLine = new string[separationIntoSpaces.Length];
            var temp = string.Empty;

            for (var i = 0; i < separationIntoSpaces.Length; i++)
            {
                wordInLine[i] = GetReverseWord(separationIntoSpaces[i]);
                temp = string.Join(" ", wordInLine);
            }
            return temp;
        }

        private bool IsDigital(char myString)
        {
            return char.IsDigit(myString) || char.IsSymbol(myString) || char.IsPunctuation(myString);
        }

        private string GetReverseWord(string myWord)
        {
            var wordResult = myWord.ToCharArray();

            for (int i = 0, j = wordResult.Length - 1; i < j;)
            {
                if (IsDigital(wordResult[i]))
                {
                    i++;
                }
                else if (IsDigital(wordResult[j]))
                {
                    j--;
                }
                else
                {
                    char currentliteral = wordResult[i];
                    wordResult[i] = wordResult[j];
                    wordResult[j] = currentliteral;
                    i++;
                    j--;
                }
            }
            return new string(wordResult);
        }
    }
}

