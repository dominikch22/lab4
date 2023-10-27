using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Translator
    {
        public SortedDictionary<String, String> PolishAnglishDictionary
        { get; private set; }

        public SortedDictionary<String, String> EnglishPolishDictionary
        { get; private set; }

        public LinkedList<Translation> TranslationHistory
        { get; private set; }

        public SortedDictionary<String, String> CurrentDictionary;

        private Language _language;
        public Language Language
        {
            get { return _language; }
            set
            {
                if (value.Equals(Language.Polski))
                    CurrentDictionary = PolishAnglishDictionary;
                else if (value.Equals(Language.English))
                    CurrentDictionary = EnglishPolishDictionary;
                _language = value;
            }
        }



        public Translator(Language language)
        {
            PolishAnglishDictionary = new SortedDictionary<string, string>();
            EnglishPolishDictionary = new SortedDictionary<string, string>();
            TranslationHistory = new LinkedList<Translation>();
            Language = language;
        }



        public void addNewWord(string word, string translatedWord)
        {
            try
            {
                CurrentDictionary.Add(word, translatedWord);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Słowo już istnieje");
            }
            catch
            {
            }
        }

        public bool removeWord(string word)
        {
            return CurrentDictionary.Remove(word);
        }

        public string translate(string word)
        {
            string translatedWord = "";
            CurrentDictionary.TryGetValue(word, out translatedWord);
            Translation translation = new Translation(word, translatedWord, Language);
            TranslationHistory.AddLast(translation);
            return translatedWord;
        }
    }
}

