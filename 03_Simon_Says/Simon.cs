namespace _03_Simon_Says
{
    internal class Simon
    {
        

        public Simon()
        {
            

        }

        public string Echo(string word)
        {
            return word.ToLower();
        }

        public string Shout(string words)
        {
            return words.ToUpper();
        }

        public string Repeat(string word, int itt = 2)
        {
            string finalstring = "";
            for (int i = 0; i < itt; i++)
            {
                finalstring += word + " ";
            }
            return finalstring.Trim();
        }

        public string StartOfWord(string word, int amount)
        {
            string finalstring = "";

            for (int i = 0; i < amount; i++)
            {
                finalstring += word[i];
            }
            return finalstring;
        }

        public string FirstWord(string sentence)
        {
            string finalstring = "";
            bool running = true;
            int i = 0;

            while (running)
            {
                if (!char.IsWhiteSpace(sentence[i]))
                {
                    finalstring += sentence[i];
                }
                else
                {
                    running = false;
                }
                i++;
            }

            return finalstring; 
        }

    
    }
}