using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP
{
    static class Tokenizer
    {
        /*
        TODO: Make it good, titles and abreviations cause splits in sentences - fix

        params: string text - text to split into sentences
        returns: string[] - contains each sentence from the text
        */
        public static string[] BySentences(string text)
        {
            List<string> sentences = new List<string>();
            string nextSentence = "";
            for(int i = 0; i < text.Length; i++)
            {
                nextSentence += text[i];
                if(text[i] == '?' || text[i] == '!' || text[i] == '.')
                {
                    sentences.Add(nextSentence);
                    nextSentence = "";
                }
            }
            return sentences.ToArray();
        }
    }
}
