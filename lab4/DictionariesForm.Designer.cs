
namespace lab4
{
    partial class DictionariesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dictionaries = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.word = new System.Windows.Forms.TextBox();
            this.translatedWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addWord = new System.Windows.Forms.Button();
            this.dictionary = new System.Windows.Forms.ListBox();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dictionaries
            // 
            this.dictionaries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dictionaries.FormattingEnabled = true;
            this.dictionaries.Location = new System.Drawing.Point(70, 12);
            this.dictionaries.Name = "dictionaries";
            this.dictionaries.Size = new System.Drawing.Size(121, 21);
            this.dictionaries.TabIndex = 0;
            this.dictionaries.SelectedIndexChanged += new System.EventHandler(this.dictionariesOnSelectIndex);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj nowe słowo: do słowników ";
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(105, 356);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(100, 20);
            this.word.TabIndex = 3;
            this.word.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // translatedWord
            // 
            this.translatedWord.Location = new System.Drawing.Point(105, 382);
            this.translatedWord.Name = "translatedWord";
            this.translatedWord.Size = new System.Drawing.Size(100, 20);
            this.translatedWord.TabIndex = 4;
            this.translatedWord.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Słowo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Słowniki: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tłumaczenie: ";
            // 
            // addWord
            // 
            this.addWord.Location = new System.Drawing.Point(130, 408);
            this.addWord.Name = "addWord";
            this.addWord.Size = new System.Drawing.Size(75, 23);
            this.addWord.TabIndex = 8;
            this.addWord.Text = "Dodaj";
            this.addWord.UseVisualStyleBackColor = true;
            this.addWord.Click += new System.EventHandler(this.addWord_Click);
            // 
            // dictionary
            // 
            this.dictionary.FormattingEnabled = true;
            this.dictionary.Location = new System.Drawing.Point(12, 37);
            this.dictionary.Name = "dictionary";
            this.dictionary.Size = new System.Drawing.Size(243, 290);
            this.dictionary.TabIndex = 9;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(12, 413);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 10;
            // 
            // DictionariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 453);
            this.Controls.Add(this.error);
            this.Controls.Add(this.dictionary);
            this.Controls.Add(this.addWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.translatedWord);
            this.Controls.Add(this.word);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dictionaries);
            this.Name = "DictionariesForm";
            this.Text = "Słowniki";
            this.Load += new System.EventHandler(this.DictionariesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dictionaries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.TextBox translatedWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addWord;
        private System.Windows.Forms.ListBox dictionary;
        private System.Windows.Forms.Label error;
    }
}