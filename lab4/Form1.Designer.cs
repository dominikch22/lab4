
namespace lab4
{
    partial class Form1
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
            this.translatorLanguage = new System.Windows.Forms.ComboBox();
            this.dictionaryEditorButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.translatedWordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.languageOfTest = new System.Windows.Forms.ComboBox();
            this.startNextEnd = new System.Windows.Forms.Button();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numberOfQuestions = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // translatorLanguage
            // 
            this.translatorLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.translatorLanguage.FormattingEnabled = true;
            this.translatorLanguage.Location = new System.Drawing.Point(173, 75);
            this.translatorLanguage.Name = "translatorLanguage";
            this.translatorLanguage.Size = new System.Drawing.Size(121, 21);
            this.translatorLanguage.TabIndex = 0;
            this.translatorLanguage.SelectedIndexChanged += new System.EventHandler(this.translatorLanguageSelectedIndex);
            // 
            // dictionaryEditorButton
            // 
            this.dictionaryEditorButton.Location = new System.Drawing.Point(12, 12);
            this.dictionaryEditorButton.Name = "dictionaryEditorButton";
            this.dictionaryEditorButton.Size = new System.Drawing.Size(99, 23);
            this.dictionaryEditorButton.TabIndex = 1;
            this.dictionaryEditorButton.Text = "Pokaż Słowniki";
            this.dictionaryEditorButton.UseVisualStyleBackColor = true;
            this.dictionaryEditorButton.Click += new System.EventHandler(this.dictionaryEditorButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(117, 12);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(75, 23);
            this.historyButton.TabIndex = 2;
            this.historyButton.Text = "historia";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(12, 115);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(100, 20);
            this.wordTextBox.TabIndex = 3;
            this.wordTextBox.TextChanged += new System.EventHandler(this.wordTextBox_TextChanged);
            // 
            // translatedWordTextBox
            // 
            this.translatedWordTextBox.Location = new System.Drawing.Point(194, 115);
            this.translatedWordTextBox.Name = "translatedWordTextBox";
            this.translatedWordTextBox.Size = new System.Drawing.Size(100, 20);
            this.translatedWordTextBox.TabIndex = 4;
            this.translatedWordTextBox.TextChanged += new System.EventHandler(this.translatedWordTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wybrany język do tłumaczenia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wybrany język testu: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // languageOfTest
            // 
            this.languageOfTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageOfTest.FormattingEnabled = true;
            this.languageOfTest.Location = new System.Drawing.Point(438, 75);
            this.languageOfTest.Name = "languageOfTest";
            this.languageOfTest.Size = new System.Drawing.Size(121, 21);
            this.languageOfTest.TabIndex = 7;
            this.languageOfTest.SelectedIndexChanged += new System.EventHandler(this.languageOfText_SelectedIndexChanged);
            // 
            // startNextEnd
            // 
            this.startNextEnd.Location = new System.Drawing.Point(495, 155);
            this.startNextEnd.Name = "startNextEnd";
            this.startNextEnd.Size = new System.Drawing.Size(105, 23);
            this.startNextEnd.TabIndex = 8;
            this.startNextEnd.Text = "Rozpocznij test";
            this.startNextEnd.UseVisualStyleBackColor = true;
            this.startNextEnd.Click += new System.EventHandler(this.startNextEnd_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(327, 115);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(100, 20);
            this.questionTextBox.TabIndex = 9;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(500, 115);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(100, 20);
            this.answer.TabIndex = 10;
            this.answer.TextChanged += new System.EventHandler(this.answer_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tłumacz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(324, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Test";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(327, 165);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(0, 13);
            this.score.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "->";
            // 
            // numberOfQuestions
            // 
            this.numberOfQuestions.Location = new System.Drawing.Point(566, 75);
            this.numberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfQuestions.Name = "numberOfQuestions";
            this.numberOfQuestions.Size = new System.Drawing.Size(34, 20);
            this.numberOfQuestions.TabIndex = 16;
            this.numberOfQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 217);
            this.Controls.Add(this.numberOfQuestions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.startNextEnd);
            this.Controls.Add(this.languageOfTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translatedWordTextBox);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.dictionaryEditorButton);
            this.Controls.Add(this.translatorLanguage);
            this.Name = "Form1";
            this.Text = "Program do nauki języka";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox translatorLanguage;
        private System.Windows.Forms.Button dictionaryEditorButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.TextBox translatedWordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox languageOfTest;
        private System.Windows.Forms.Button startNextEnd;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numberOfQuestions;
    }
}

