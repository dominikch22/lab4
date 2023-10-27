using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Question
    {
        public string Word;
        public string TranslatedWord;

        private string _answer;
        public string Answer
        {
            get { return _answer; }
            set {
                if (value.Equals(TranslatedWord)) {
                    correct = true;
                }
                _answer = value;
            } 
        }
        public bool correct
        { get; private set; }

        public Question(string word, string translatedWord) {
            Word = word;
            TranslatedWord = translatedWord;
            Answer = "";
        }
    }
}
