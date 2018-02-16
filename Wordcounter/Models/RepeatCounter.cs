using System.Collections.Generic;
using System;
namespace Wordcounter.Models
{
    public class RepeatCounter
    {
        private string _word;
        private string _sentence;
        private int _wordCount = 0;

        public RepeatCounter()
        {
            _word = "";
            _sentence = "";
        }

        public RepeatCounter(string word, string sentence)
        {
            _word = word;
            _sentence = sentence;
        }
        public void SetSentence(string inputSentence)
        {
            _sentence = inputSentence;
        }
        public void SetWord(string setWord)
        {
            _word = setWord;
        }
        public string GetSentence()
        {
            return _sentence;
        }
        public string GetWord()
        {
            return _word;
        }
        public int GetWordCount()
        {
            return _wordCount;
        }

    }
}
