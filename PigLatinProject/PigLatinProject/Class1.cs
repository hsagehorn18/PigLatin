using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinProject
{
    public class PigLatin
    {
        public string PigLatinTranslator(string word)
        {
            string translation = "";
            word = word.ToUpper();

            if (word[0] != 'A' && word[0] != 'E' && word[0] != 'I' && word[0] != 'O' && word[0] != 'U')
            {
                if (word[1] != 'A' && word[1] != 'E' && word[1] != 'I' && word[1] != 'O' && word[1] != 'U')
                {
                    word = word.ToLower();
                    char firstLetters = word[0];
                    char secondLetter = word[1];
                    string temp = word.Substring(2);
                    translation = temp + "-" + (firstLetters + secondLetter + "ay");
                }
                else
                {
                    word = word.ToLower();
                    char firstLetters = word[0];
                    string temp = word.Substring(1);
                    translation = temp + "-" + (firstLetters + "ay");
                }
            }
            
            return translation;
        }
        
    }
}
