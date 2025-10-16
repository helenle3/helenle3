namespace Program2
{
    partial class CodeQuest
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
            this.codeQuestTxt = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.exerciseNumLbl = new System.Windows.Forms.Label();
            this.difficultyLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.exerciseNumTxt = new System.Windows.Forms.TextBox();
            this.difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.actualQuestionGroupBox = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.scoreOutGroupBox = new System.Windows.Forms.GroupBox();
            this.scoreOutLbl = new System.Windows.Forms.Label();
            this.actualQuestionGroupBox.SuspendLayout();
            this.scoreOutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeQuestTxt
            // 
            this.codeQuestTxt.AutoSize = true;
            this.codeQuestTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeQuestTxt.Location = new System.Drawing.Point(103, 21);
            this.codeQuestTxt.Name = "codeQuestTxt";
            this.codeQuestTxt.Size = new System.Drawing.Size(167, 32);
            this.codeQuestTxt.TabIndex = 0;
            this.codeQuestTxt.Text = "CodeQuest";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Location = new System.Drawing.Point(69, 70);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(91, 20);
            this.userLbl.TabIndex = 1;
            this.userLbl.Text = "Username:";
            // 
            // exerciseNumLbl
            // 
            this.exerciseNumLbl.AutoSize = true;
            this.exerciseNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseNumLbl.Location = new System.Drawing.Point(17, 115);
            this.exerciseNumLbl.Name = "exerciseNumLbl";
            this.exerciseNumLbl.Size = new System.Drawing.Size(143, 20);
            this.exerciseNumLbl.TabIndex = 2;
            this.exerciseNumLbl.Text = "Exercise Number:";
            // 
            // difficultyLbl
            // 
            this.difficultyLbl.AutoSize = true;
            this.difficultyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLbl.Location = new System.Drawing.Point(80, 164);
            this.difficultyLbl.Name = "difficultyLbl";
            this.difficultyLbl.Size = new System.Drawing.Size(80, 20);
            this.difficultyLbl.TabIndex = 3;
            this.difficultyLbl.Text = "Difficulty:";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(61, 215);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(99, 20);
            this.timeLbl.TabIndex = 4;
            this.timeLbl.Text = "Time Spent:";
            // 
            // userTxt
            // 
            this.userTxt.BackColor = System.Drawing.Color.Silver;
            this.userTxt.Location = new System.Drawing.Point(170, 68);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(159, 22);
            this.userTxt.TabIndex = 5;
            // 
            // exerciseNumTxt
            // 
            this.exerciseNumTxt.BackColor = System.Drawing.Color.Silver;
            this.exerciseNumTxt.Location = new System.Drawing.Point(170, 112);
            this.exerciseNumTxt.Name = "exerciseNumTxt";
            this.exerciseNumTxt.Size = new System.Drawing.Size(159, 22);
            this.exerciseNumTxt.TabIndex = 6;
            // 
            // difficultyComboBox
            // 
            this.difficultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Very Hard"});
            this.difficultyComboBox.Location = new System.Drawing.Point(170, 164);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(159, 24);
            this.difficultyComboBox.TabIndex = 7;
            // 
            // timeTxt
            // 
            this.timeTxt.BackColor = System.Drawing.Color.Silver;
            this.timeTxt.Location = new System.Drawing.Point(170, 215);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(159, 22);
            this.timeTxt.TabIndex = 8;
            // 
            // actualQuestionGroupBox
            // 
            this.actualQuestionGroupBox.BackColor = System.Drawing.Color.LightGray;
            this.actualQuestionGroupBox.Controls.Add(this.noRadioButton);
            this.actualQuestionGroupBox.Controls.Add(this.yesRadioButton);
            this.actualQuestionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualQuestionGroupBox.Location = new System.Drawing.Point(13, 261);
            this.actualQuestionGroupBox.Name = "actualQuestionGroupBox";
            this.actualQuestionGroupBox.Size = new System.Drawing.Size(348, 70);
            this.actualQuestionGroupBox.TabIndex = 9;
            this.actualQuestionGroupBox.TabStop = false;
            this.actualQuestionGroupBox.Text = "Actual Interview Question";
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(211, 32);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(51, 24);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(71, 32);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(58, 24);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(43, 337);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(286, 45);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate Score";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // scoreOutGroupBox
            // 
            this.scoreOutGroupBox.BackColor = System.Drawing.Color.LightGray;
            this.scoreOutGroupBox.Controls.Add(this.scoreOutLbl);
            this.scoreOutGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOutGroupBox.Location = new System.Drawing.Point(12, 388);
            this.scoreOutGroupBox.Name = "scoreOutGroupBox";
            this.scoreOutGroupBox.Size = new System.Drawing.Size(349, 75);
            this.scoreOutGroupBox.TabIndex = 11;
            this.scoreOutGroupBox.TabStop = false;
            this.scoreOutGroupBox.Text = "Your Score:";
            // 
            // scoreOutLbl
            // 
            this.scoreOutLbl.BackColor = System.Drawing.SystemColors.Control;
            this.scoreOutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreOutLbl.Location = new System.Drawing.Point(68, 32);
            this.scoreOutLbl.Name = "scoreOutLbl";
            this.scoreOutLbl.Size = new System.Drawing.Size(224, 23);
            this.scoreOutLbl.TabIndex = 0;
            // 
            // CodeQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 471);
            this.Controls.Add(this.scoreOutGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.actualQuestionGroupBox);
            this.Controls.Add(this.timeTxt);
            this.Controls.Add(this.difficultyComboBox);
            this.Controls.Add(this.exerciseNumTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.difficultyLbl);
            this.Controls.Add(this.exerciseNumLbl);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.codeQuestTxt);
            this.Name = "CodeQuest";
            this.Text = "CodeQuest";
            this.actualQuestionGroupBox.ResumeLayout(false);
            this.actualQuestionGroupBox.PerformLayout();
            this.scoreOutGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codeQuestTxt;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label exerciseNumLbl;
        private System.Windows.Forms.Label difficultyLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox exerciseNumTxt;
        private System.Windows.Forms.ComboBox difficultyComboBox;
        private System.Windows.Forms.TextBox timeTxt;
        private System.Windows.Forms.GroupBox actualQuestionGroupBox;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox scoreOutGroupBox;
        private System.Windows.Forms.Label scoreOutLbl;
    }
}

