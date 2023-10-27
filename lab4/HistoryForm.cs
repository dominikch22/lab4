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
    public partial class HistoryForm : Form
    {
        public HistoryForm(Translator translator)
        {
            InitializeComponent();

            LinkedListNode<Translation> lastNode = translator.TranslationHistory.Last;

            while (lastNode != null)
            {
                history.Items.Add(lastNode.Value.Word + " -> " + lastNode.Value.TranslatedWord);
                lastNode = lastNode.Previous;
            }          
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void history_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
