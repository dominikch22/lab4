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

        public override bool Equals(object obj)
        {
            return obj is Question question &&
                   Word == question.Word &&
                   TranslatedWord == question.TranslatedWord;
        }

        public override int GetHashCode()
        {
            int hashCode = 1539046180;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Word);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TranslatedWord);
            return hashCode;
        }
    }
}
