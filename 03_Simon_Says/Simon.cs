using System.Collections.Generic;

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

            // Alternative:

            //string[] output = sentence.Split();
            //return output[0];
        }

        public string Titleize(string sentence)
        {

            string[] templist = sentence.Split();

         // The List<> class can be used by adding "using System.Collections.Generic;" to the top of this page.
          
            List<string> whitelist = new List<string>();
            whitelist.Add("and");
            whitelist.Add("over");
            whitelist.Add("the");


            char[] arr;

            for (int i = 0; i < templist.Length; i++)
            {
                if (i == 0 || !whitelist.Contains(templist[i]))
                {
                    arr = templist[i].ToCharArray();
                    arr[0] = char.ToUpperInvariant(arr[0]);
                    templist[i] = new string(arr);
                }

            }

            return string.Join(" ", templist);

    // Array variant:

    //string[] templist = sentence.Split();
    //string[] whitelist = { "and", "over", "the" };
    //char[] arr;

    //for (int i = 0; i < templist.Length; i++)
    //{
    //    bool upper = true;

    //    foreach (string s in whitelist)
    //    {
    //        if (templist[i] == s)
    //        {
    //            upper = false;
    //        }
    //    }

    //    if (i == 0 ||upper == true )
    //    {
    //        arr = templist[i].ToCharArray();
    //        arr[0] = char.ToUpperInvariant(arr[0]);
    //        templist[i] = new string(arr);
    //    }
    //}

    //return string.Join(" ", templist);
}



    }
}