using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Test
    {
        public Random random;

        private Language _language;
        public Language Language
        { 
            get { return _language; }
            set {
                if (value.Equals(Language.Polski))               
                    Dictionary = Translator.PolishAnglishDictionary;                
                else if (value.Equals(Language.English))               
                    Dictionary = Translator.EnglishPolishDictionary;
                
                _language = value;
            }
        }
        public List<Question> QuestionsList
        { get; private set; }
        public Translator Translator;
        public SortedDictionary<string, string> Dictionary;
        public List<string> answers;
        public int Size;

        public Test(Language language, Translator translator, int size) {
            random = new Random();
            Translator = translator;
            Language = language;
            Size = size;
            QuestionsList = CreateQuestionsList();        
            answers = new List<string>(size);
        }


        private List<Question> CreateQuestionsList() {
            HashSet<Question> QuestionsSet = new HashSet<Question>();
            for (int i = 0; i < Size; i++)
            {
                var dictionary = new List<KeyValuePair<string, string>>(Dictionary);
                int randomIndex = random.Next(0, dictionary.Count);
                string word = dictionary.ElementAt(randomIndex).Key;
                string translatedWord = dictionary.ElementAt(randomIndex).Value;
                Question question = new Question(word, translatedWord);
                if (!QuestionsSet.Add(question))
                {
                    i--;
                }
            }

           
            return QuestionsSet.ToList();
        }

        public bool AnswerQuestion(string answer, int index) {        
            Question question = QuestionsList[index];
            question.Answer = answer;
            return question.correct;
        }

        public int EndTest() {
            int correctAnswersCounter = 0;
            foreach (var question in QuestionsList) {
                if (question.correct)
                    correctAnswersCounter++;
            }
            return correctAnswersCounter;
        }
    }

    
}
