using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Translation
    {
        public Language Language
        { get; private set; }
        public string Word
        { get; private set; }
        public string TranslatedWord
        { get; set; }

        public Translation(string word, string translatedWord, Language language)
        {
            this.Word = word;
            this.TranslatedWord = translatedWord;
            this.Language = language;
        }



    }
}
