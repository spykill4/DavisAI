using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavisNLP
{
    /*
    Defines a word that has been categorized into a part of speech. Is a child of GroupedWords in order to allow it to be contained in the GroupedWords[] of its parent
    */
    class CategorizedWord : GroupedWords
    {
        //Part of speech that this word is associated with, in context
        public WordDefinition.WordPOS partOfSpeech;
        // Actual string representation of this word
        public string word;
        // Reference to this word's definition object
        public WordDefinition definition;
    }
}
