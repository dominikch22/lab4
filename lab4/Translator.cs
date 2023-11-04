using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Translator
    {
        public SortedDictionary<String, String> PolishAnglishDictionary
        { get; private set; }

        public SortedDictionary<String, String> EnglishPolishDictionary
        { get; private set; }

        public LinkedList<Translation> TranslationHistory
        { get; private set; }

        public SortedDictionary<String, String> CurrentDictionary;
        public SortedDictionary<String, String> ReverseDictionary;



        private Language _language;
        public Language Language
        {
            get { return _language; }
            set
            {
                if (value.Equals(Language.Polski))
                {
                    CurrentDictionary = PolishAnglishDictionary;
                    ReverseDictionary = EnglishPolishDictionary;
                }
                else if (value.Equals(Language.English)) {
                    CurrentDictionary = EnglishPolishDictionary;
                    ReverseDictionary = PolishAnglishDictionary;
                }
                _language = value;
            }
        }



        public Translator(Language language)
        {         
            EnglishPolishDictionary = loadEnglishPolishDictionary();
            PolishAnglishDictionary = loadPolishEnglishDictionary(EnglishPolishDictionary);
            TranslationHistory = new LinkedList<Translation>();
            Language = language;
        }

        public SortedDictionary<String, String> getDictionaryByLanguage(Language language) {
            if (language.Equals(Language.Polski))
                return PolishAnglishDictionary;
            else if(language.Equals(Language.English))
                return EnglishPolishDictionary;
            return null;
        }

        public void addNewWord(string word, string translatedWord)
        {
            if (word.Length == 0 || translatedWord.Length == 0)
                throw new ArgumentException("Słowo nie może być puste");

            try
            {
                ReverseDictionary.Add(translatedWord, word);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("Słowo już istnieje");
            }
          

            try
            {
                CurrentDictionary.Add(word, translatedWord);
            }
            catch (ArgumentException ex)
            {
                ReverseDictionary.Remove(translatedWord);
                throw new Exception("Słowo już istnieje");
            }
            
        }

        public bool removeWord(string word)
        {
            string translatedWord = translate(word);
            ReverseDictionary.Remove(translatedWord);
            return CurrentDictionary.Remove(word);
        }

        public string translate(string word)
        {
            string translatedWord = "";
            CurrentDictionary.TryGetValue(word, out translatedWord);
            if (translatedWord == null)
                return "";
            Translation translation = new Translation(word, translatedWord, Language);
            TranslationHistory.AddLast(translation);
            return translatedWord;
        }

        public SortedDictionary<String, String> loadEnglishPolishDictionary() {
            SortedDictionary<String, String> englishPolishDictionary = new SortedDictionary<string, string>();

            englishPolishDictionary.Add("apple", "jabłko");
            englishPolishDictionary.Add("banana", "banan");
            englishPolishDictionary.Add("car", "samochód");
            englishPolishDictionary.Add("house", "dom");
            englishPolishDictionary.Add("dog", "pies");
            englishPolishDictionary.Add("cat", "kot");
            englishPolishDictionary.Add("book", "książka");
            englishPolishDictionary.Add("computer", "komputer");
            englishPolishDictionary.Add("school", "szkoła");
            englishPolishDictionary.Add("pencil", "ołówek");
            englishPolishDictionary.Add("desk", "biurko");
            englishPolishDictionary.Add("chair", "krzesło");
            englishPolishDictionary.Add("shoes", "buty");
            englishPolishDictionary.Add("tree", "drzewo");
            englishPolishDictionary.Add("sun", "słońce");

            return englishPolishDictionary;
        }

        public SortedDictionary<String, String> loadPolishEnglishDictionary(SortedDictionary<String, String> englishPolishDictionary)
        {
            SortedDictionary<String, String> polishEnglishDictionary = new SortedDictionary<string, string>();


            foreach (var pair in englishPolishDictionary)
            {
                polishEnglishDictionary.Add(pair.Value, pair.Key);
            }
          

            return polishEnglishDictionary;
        }
    }
}

