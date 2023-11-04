using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        private DictionariesForm dictionariesForm;
        private Translator Translator;
        private Test Test;
        private int IndexOfQuestion;
        private Question Question;
        public Form1()
        {
            InitializeComponent();
            Translator = new Translator(Language.English);

            dictionariesForm = new DictionariesForm(Translator);


            foreach (Language language in Enum.GetValues(typeof(Language))) {
                translatorLanguage.Items.Add(language.ToString());
                languageOfTest.Items.Add(language.ToString());
            }
            translatorLanguage.SelectedIndex = 0;
            languageOfTest.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void languageOfText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dictionaryEditorButton_Click(object sender, EventArgs e)
        {

            dictionariesForm.Show();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm(Translator);
            history.Show();
        }

        private void translatedWordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wordTextBox_TextChanged(object sender, EventArgs e)
        {
            translatedWordTextBox.Text = Translator.translate(wordTextBox.Text);
        }

        private void translatorLanguageSelectedIndex(object sender, EventArgs e)
        {
            Language selectedLanguage;
            Enum.TryParse(translatorLanguage.Text, out selectedLanguage);
            Translator.Language = selectedLanguage;
            translatedWordTextBox.Text = Translator.translate(wordTextBox.Text);
        }

        private void startNextEnd_Click(object sender, EventArgs e)
        {
            try
            {
                if (startNextEnd.Text.Equals("Rozpocznij test"))
                {
                    startTest();

                }
                else if (startNextEnd.Text.Equals("Następne pytanie"))
                {
                    nextQuestion();
                }
                else if (startNextEnd.Text.Equals("Zakończ test"))
                {
                    endTest();
                }
            }
            catch { 
            }
            
        }

        private void startTest() {
            score.Text = "";
            Language selectedLanguage;
            Enum.TryParse(languageOfTest.Text, out selectedLanguage);
            Test = new Test(selectedLanguage, Translator, ((int)numberOfQuestions.Value));
            startNextEnd.Text = "Następne pytanie";

            IndexOfQuestion = 0;
            Question = Test.QuestionsList[IndexOfQuestion];
            questionTextBox.Text = Question.Word;
        }

        private void nextQuestion() {
            Question.Answer = answer.Text;
            answer.Text = "";

            IndexOfQuestion++;
            Question = Test.QuestionsList[IndexOfQuestion];
            questionTextBox.Text = Question.Word;
            if (IndexOfQuestion == Test.Size - 1)
                startNextEnd.Text = "Zakończ test";

        }
        private void endTest() {
            Question.Answer = answer.Text;
            answer.Text = "";
            questionTextBox.Text = "";

            int result = Test.EndTest();
            score.Text = "Wynik: " + result + "/" + Test.Size;
            startNextEnd.Text = "Rozpocznij test";
        }
    }
}
