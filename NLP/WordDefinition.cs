using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavisNLP
{
    public class WordDefinition
    {
        public enum WordPOS // POS Tags based on: http://universaldependencies.github.io/docs/u/pos/
        {
            ADJ // adjective -> modify nouns (ie. big, old, green)
            , ADP // adposition -> prepositions and postpositions (ie. in, to, during)
            , ADV // adverb -> modifies verbs with time, place, direction or manner(ie. very, well, up, down, tomorrow)
            , AUX // auxiliary verb -> verb that changes based on person, number, tense, mood, aspect, voice (ie. has, is, will)
            , CONJ // coordinating conjunction -> links words or larger constituents (ie, and, or, but)
            , DET // determiner -> express reference of noun phrase IN CONTEXT (ie. a, an, the, my, this, which)
            , INTJ // interjection -> typically expresses emotional reaction (ie. ouch, hello, psst, bravo)
            , NOUN // noun -> denotes person, place, thing, animal or idea -> common
            , NUM // numeral -> functions most typically as a determiner, adjective or pronoun, defines number and relation to number (ie. seven, three)
            , PART // particle -> must be associated with another word or phrase to impart meaning (ie. 's, not)
            , PRON // pronoun -> substitute for nouns / noun phrases, meaning comes from context (ie. I, you, he, she, myself, this)
            , PROPN // proper noun -> noun that is the name of a specific individual, place, or object (Mary, London, HBO)
            , PUNCT // punctuation -> delimits linguistic units in printed text (ie. ., ,, () // Lol these examples are ridiculous xD
            , SCONJ // subordinating conjunction -> links constructions by making one of them a constituent of the other (ie. that, if, while)
            , SYM // symbol -> word like entity that differs from ordinary words by form, function, or both (ie. $, john.doe@universal.org
            , VERB // verb -> signals events and actions (ie. run, runs, running)
            , X // other -> word could not be categorized (ie. xfgh) <- we will try and figure out which category these are in and store them
        }
        // The root word that other words will extend off of
        public string rootWord;
        // Stores previous ways the program has seen this word being used
        public WordPOS[] partsSeen;
    }
}
