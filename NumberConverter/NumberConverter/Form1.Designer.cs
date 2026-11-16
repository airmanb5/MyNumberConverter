namespace NumberConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textArabianNumbers = new TextBox();
            textRomanNumbers = new TextBox();
            labelArabianNumbers = new Label();
            labelRomanNumbers = new Label();
            buttonConvert = new Button();
            SuspendLayout();
            // 
            // textArabianNumbers
            // 
            textArabianNumbers.Location = new Point(75, 88);
            textArabianNumbers.Name = "textArabianNumbers";
            textArabianNumbers.Size = new Size(150, 31);
            textArabianNumbers.TabIndex = 0;
            // 
            // textRomanNumbers
            // 
            textRomanNumbers.Enabled = false;
            textRomanNumbers.Location = new Point(75, 274);
            textRomanNumbers.Name = "textRomanNumbers";
            textRomanNumbers.Size = new Size(150, 31);
            textRomanNumbers.TabIndex = 2;
            // 
            // labelArabianNumbers
            // 
            labelArabianNumbers.AutoSize = true;
            labelArabianNumbers.Location = new Point(75, 49);
            labelArabianNumbers.Name = "labelArabianNumbers";
            labelArabianNumbers.Size = new Size(77, 25);
            labelArabianNumbers.TabIndex = 3;
            labelArabianNumbers.Text = "Arabian:";
            // 
            // labelRomanNumbers
            // 
            labelRomanNumbers.AutoSize = true;
            labelRomanNumbers.Location = new Point(75, 246);
            labelRomanNumbers.Name = "labelRomanNumbers";
            labelRomanNumbers.Size = new Size(72, 25);
            labelRomanNumbers.TabIndex = 4;
            labelRomanNumbers.Text = "Roman:";
            // 
            // buttonConvert
            // 
            buttonConvert.Location = new Point(288, 168);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(112, 34);
            buttonConvert.TabIndex = 5;
            buttonConvert.Text = "Convert";
            buttonConvert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConvert);
            Controls.Add(labelRomanNumbers);
            Controls.Add(labelArabianNumbers);
            Controls.Add(textRomanNumbers);
            Controls.Add(textArabianNumbers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textArabianNumbers;
        private TextBox textRomanNumbers;
        private Label labelArabianNumbers;
        private Label labelRomanNumbers;
        private Button buttonConvert;
    }
}
