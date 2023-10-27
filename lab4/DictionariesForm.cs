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
    public partial class DictionariesForm : Form
    {
        private Translator Translator;
        public DictionariesForm(Translator translator)
        {
            Translator = translator;
            InitializeComponent();
            foreach (Language language in Enum.GetValues(typeof(Language)))
            {
                dictionaries.Items.Add(language.ToString());
            }
            dictionaries.SelectedIndex = 0;
            loadDictionary();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DictionariesForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dictionariesOnSelectIndex(object sender, EventArgs e)
        {
            loadDictionary();
        }
        private void loadDictionary() {
            Language selectedLanguage;
            Enum.TryParse(dictionaries.Text, out selectedLanguage);
            dictionary.Items.Clear();
            foreach (var element in Translator.getDictionaryByLanguage(selectedLanguage))
            {
                dictionary.Items.Add(element.Key + " - " + element.Value + "\n");
            }
        }

        private void addWord_Click(object sender, EventArgs e)
        {
            Language selectedLanguage;
            Enum.TryParse(dictionaries.Text, out selectedLanguage);
            Language savedLanguage = Translator.Language;
            Translator.Language = selectedLanguage;
            try
            {
                Translator.addNewWord(word.Text, translatedWord.Text);
                error.Text = "";
            }
            catch (Exception ex) {
                error.Text = ex.Message;
            }
            Translator.Language = savedLanguage;

            loadDictionary();
        }
    }
}
