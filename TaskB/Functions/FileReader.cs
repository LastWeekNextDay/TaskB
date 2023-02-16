using System;

namespace TaskB
{
    public static class FileReader
    {
        public static string ReadFileAndReturnString(string file, string textToFind, int lengthBefore, int lengthAfter)
        {
            // Read the file and find textToFind
            string fileText = System.IO.File.ReadAllText(file);
            int index = fileText.IndexOf(textToFind, StringComparison.Ordinal);
            string textToReturn = "";
            // if the text is found, assign it to textToReturn, add the lengthBefore and lengthAfter amount of characters
            // in the file before and after the textToFind to the variable and return it
            if (index > -1)
            {
                // if there is not enough characters before the textToFind, add the maximum available amount
                if (index - lengthBefore < 0)
                {
                    lengthBefore = index;
                }
                // if there is not enough characters after the textToFind, add the maximum available amount
                if (index + textToFind.Length + lengthAfter > fileText.Length)
                {
                    lengthAfter = fileText.Length - (index + textToFind.Length);
                }
                textToReturn =
                    fileText.Substring(index - lengthBefore, textToFind.Length + lengthBefore + lengthAfter);
            }
            return textToReturn;
        }
    }
}