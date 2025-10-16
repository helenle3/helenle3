namespace Program_3
{
    partial class contractCalculatorForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.catererLbl = new System.Windows.Forms.Label();
            this.businessLbl = new System.Windows.Forms.Label();
            this.contractYearsLbl = new System.Windows.Forms.Label();
            this.catererComboBox = new System.Windows.Forms.ComboBox();
            this.businessComboBox = new System.Windows.Forms.ComboBox();
            this.contractYearsTxt = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.contractPriceLbl = new System.Windows.Forms.Label();
            this.finalPriceOutputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(37, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(341, 29);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Catering Contract Calculator";
            // 
            // catererLbl
            // 
            this.catererLbl.AutoSize = true;
            this.catererLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catererLbl.Location = new System.Drawing.Point(21, 53);
            this.catererLbl.Name = "catererLbl";
            this.catererLbl.Size = new System.Drawing.Size(70, 20);
            this.catererLbl.TabIndex = 1;
            this.catererLbl.Text = "Caterer:";
            // 
            // businessLbl
            // 
            this.businessLbl.AutoSize = true;
            this.businessLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessLbl.Location = new System.Drawing.Point(21, 90);
            this.businessLbl.Name = "businessLbl";
            this.businessLbl.Size = new System.Drawing.Size(79, 20);
            this.businessLbl.TabIndex = 2;
            this.businessLbl.Text = "Business";
            // 
            // contractYearsLbl
            // 
            this.contractYearsLbl.AutoSize = true;
            this.contractYearsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractYearsLbl.Location = new System.Drawing.Point(21, 128);
            this.contractYearsLbl.Name = "contractYearsLbl";
            this.contractYearsLbl.Size = new System.Drawing.Size(126, 20);
            this.contractYearsLbl.TabIndex = 3;
            this.contractYearsLbl.Text = "Contract Years:";
            // 
            // catererComboBox
            // 
            this.catererComboBox.FormattingEnabled = true;
            this.catererComboBox.Items.AddRange(new object[] {
            "Hill Catering Co.",
            "Food in a Flash",
            "Sally\'s Sandwiches",
            "Perry\'s Pierogis"});
            this.catererComboBox.Location = new System.Drawing.Point(244, 53);
            this.catererComboBox.Name = "catererComboBox";
            this.catererComboBox.Size = new System.Drawing.Size(152, 24);
            this.catererComboBox.TabIndex = 4;
            // 
            // businessComboBox
            // 
            this.businessComboBox.FormattingEnabled = true;
            this.businessComboBox.Items.AddRange(new object[] {
            "John\'s Books",
            "Office Supplies",
            "J.B. Car Parts",
            "Gevalia Coffee",
            "Ceylon Tea",
            "My Footwear"});
            this.businessComboBox.Location = new System.Drawing.Point(244, 90);
            this.businessComboBox.Name = "businessComboBox";
            this.businessComboBox.Size = new System.Drawing.Size(152, 24);
            this.businessComboBox.TabIndex = 5;
            // 
            // contractYearsTxt
            // 
            this.contractYearsTxt.Location = new System.Drawing.Point(244, 128);
            this.contractYearsTxt.Name = "contractYearsTxt";
            this.contractYearsTxt.Size = new System.Drawing.Size(152, 22);
            this.contractYearsTxt.TabIndex = 6;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(132, 176);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(151, 28);
            this.calculateBtn.TabIndex = 7;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // contractPriceLbl
            // 
            this.contractPriceLbl.AutoSize = true;
            this.contractPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractPriceLbl.Location = new System.Drawing.Point(25, 236);
            this.contractPriceLbl.Name = "contractPriceLbl";
            this.contractPriceLbl.Size = new System.Drawing.Size(122, 20);
            this.contractPriceLbl.TabIndex = 8;
            this.contractPriceLbl.Text = "Contract Price:";
            // 
            // finalPriceOutputLbl
            // 
            this.finalPriceOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalPriceOutputLbl.Location = new System.Drawing.Point(244, 236);
            this.finalPriceOutputLbl.Name = "finalPriceOutputLbl";
            this.finalPriceOutputLbl.Size = new System.Drawing.Size(152, 25);
            this.finalPriceOutputLbl.TabIndex = 9;
            this.finalPriceOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contractCalculatorForm
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 288);
            this.Controls.Add(this.finalPriceOutputLbl);
            this.Controls.Add(this.contractPriceLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.contractYearsTxt);
            this.Controls.Add(this.businessComboBox);
            this.Controls.Add(this.catererComboBox);
            this.Controls.Add(this.contractYearsLbl);
            this.Controls.Add(this.businessLbl);
            this.Controls.Add(this.catererLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "contractCalculatorForm";
            this.Text = "Contract Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label catererLbl;
        private System.Windows.Forms.Label businessLbl;
        private System.Windows.Forms.Label contractYearsLbl;
        private System.Windows.Forms.ComboBox catererComboBox;
        private System.Windows.Forms.ComboBox businessComboBox;
        private System.Windows.Forms.TextBox contractYearsTxt;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label contractPriceLbl;
        private System.Windows.Forms.Label finalPriceOutputLbl;
    }
}

