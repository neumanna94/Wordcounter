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

        public void WordCount()
        {
             _wordCount = 0; //Putting to 0 incase the function is called multiple times.
            List<string> indexedSentence = this.Splitter();

            for(int i = 0; i < indexedSentence.Count; i ++)
            {
                if(indexedSentence[i] == _word.ToLower() || indexedSentence[i] == _word.ToLower() + "."|| indexedSentence[i] == _word.ToLower() + "!" || indexedSentence[i] == _word.ToLower() + "?" || indexedSentence[i] == _word.ToLower() + ",")
                {
                    _wordCount += 1;
                } else {
                    //Do nothing!
                }
            }
        }
        public List<string> Splitter()
        {
            List<string> outputList = new List<string>{};
            int j = 0;
            for(int i = 0; i < _sentence.Length; i ++)
            {
                if(_sentence[i].ToString() == " " && j == 0)
                {
                    outputList.Add(_sentence.Substring(j,i-j).ToLower());
                    j=i;
                } else if(_sentence[i].ToString() == " " && j > 0)
                {
                    outputList.Add(_sentence.Substring(j+1,i-j-1).ToLower());
                    j=i;
                }
            }
            outputList.Add(_sentence.Substring(j+1, _sentence.Length-j-1).ToLower());
            return outputList;
        }

    }
}
