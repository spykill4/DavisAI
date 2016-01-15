using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavisNLP
{
    public static class Tokenizer
    {
        /*
        Splits a body of text into sentences.

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
            if(nextSentence != "")
            {
                sentences.Add(nextSentence);
                nextSentence = "";
            }
            return sentences.ToArray();
        }

        /*
        Splits a body of text into words, where punctuation acts as separate words for easier processing, excluding apostrophes and hyphens and periods, as periods are supposed to be removed by sentences

        TODO: Keep punctuation involved with titles and abreviations included with the word

        params: string text - text to split into sentences
        returns: string[] - contains all words split up
        */
        public static string[] ByWords(string text)
        {
            List<string> words = new List<string>();
            string nextWord = "";
            for(int i = 0; i < text.Length; i++)
            {
                if(text[i] == ' ')
                {
                    if (nextWord != "")
                    {
                        words.Add(nextWord);
                        nextWord = "";
                    }
                    continue;
                }
                if (text[i] == ',')
                {
                    if (nextWord != "")
                    {
                        words.Add(nextWord);
                        nextWord = "";
                    }
                    words.Add(",");
                    continue;
                }
                nextWord += text[i];
            }
            if(nextWord != "")
            {
                words.Add(nextWord);
            }
            return words.ToArray();
        }
    }
}
