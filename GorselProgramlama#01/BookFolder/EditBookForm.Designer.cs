namespace GorselProgramlama_01
{
    partial class EditBookForm
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
            groupBox1 = new GroupBox();
            SaveChangedBtn = new Button();
            NumberOfPagesTxtNew = new TextBox();
            label4 = new Label();
            BookWriterTxtNew = new TextBox();
            label3 = new Label();
            BookNameTxtNew = new TextBox();
            BookNameLabel = new Label();
            BookIDTxtNew = new TextBox();
            label1 = new Label();
            FindBookBtn = new Button();
            BookIdTxt = new TextBox();
            BookIdLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SaveChangedBtn);
            groupBox1.Controls.Add(NumberOfPagesTxtNew);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(BookWriterTxtNew);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(BookNameTxtNew);
            groupBox1.Controls.Add(BookNameLabel);
            groupBox1.Controls.Add(BookIDTxtNew);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FindBookBtn);
            groupBox1.Controls.Add(BookIdTxt);
            groupBox1.Controls.Add(BookIdLabel);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(422, 424);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Hire";
            // 
            // SaveChangedBtn
            // 
            SaveChangedBtn.Location = new Point(165, 359);
            SaveChangedBtn.Margin = new Padding(3, 4, 3, 4);
            SaveChangedBtn.Name = "SaveChangedBtn";
            SaveChangedBtn.Size = new Size(206, 31);
            SaveChangedBtn.TabIndex = 15;
            SaveChangedBtn.Text = "Save Changed";
            SaveChangedBtn.UseVisualStyleBackColor = true;
            SaveChangedBtn.Click += SaveChangedBtn_Click;
            // 
            // NumberOfPagesTxtNew
            // 
            NumberOfPagesTxtNew.Location = new Point(165, 282);
            NumberOfPagesTxtNew.Margin = new Padding(3, 4, 3, 4);
            NumberOfPagesTxtNew.Name = "NumberOfPagesTxtNew";
            NumberOfPagesTxtNew.Size = new Size(205, 27);
            NumberOfPagesTxtNew.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 282);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 13;
            label4.Text = "Number Of Pages::";
            // 
            // BookWriterTxtNew
            // 
            BookWriterTxtNew.Location = new Point(165, 247);
            BookWriterTxtNew.Margin = new Padding(3, 4, 3, 4);
            BookWriterTxtNew.Name = "BookWriterTxtNew";
            BookWriterTxtNew.Size = new Size(205, 27);
            BookWriterTxtNew.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 247);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 11;
            label3.Text = "Book Writer:";
            // 
            // BookNameTxtNew
            // 
            BookNameTxtNew.Location = new Point(165, 212);
            BookNameTxtNew.Margin = new Padding(3, 4, 3, 4);
            BookNameTxtNew.Name = "BookNameTxtNew";
            BookNameTxtNew.Size = new Size(205, 27);
            BookNameTxtNew.TabIndex = 10;
            // 
            // BookNameLabel
            // 
            BookNameLabel.AutoSize = true;
            BookNameLabel.Location = new Point(21, 212);
            BookNameLabel.Name = "BookNameLabel";
            BookNameLabel.Size = new Size(90, 20);
            BookNameLabel.TabIndex = 9;
            BookNameLabel.Text = "Book Name:";
            // 
            // BookIDTxtNew
            // 
            BookIDTxtNew.Location = new Point(166, 177);
            BookIDTxtNew.Margin = new Padding(3, 4, 3, 4);
            BookIDTxtNew.Name = "BookIDTxtNew";
            BookIDTxtNew.Size = new Size(205, 27);
            BookIDTxtNew.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 177);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 7;
            label1.Text = "Book ID:";
            // 
            // FindBookBtn
            // 
            FindBookBtn.Location = new Point(165, 104);
            FindBookBtn.Margin = new Padding(3, 4, 3, 4);
            FindBookBtn.Name = "FindBookBtn";
            FindBookBtn.Size = new Size(206, 31);
            FindBookBtn.TabIndex = 6;
            FindBookBtn.Text = "Find The Book";
            FindBookBtn.UseVisualStyleBackColor = true;
            FindBookBtn.Click += FindBookBtn_Click;
            // 
            // BookIdTxt
            // 
            BookIdTxt.Location = new Point(166, 44);
            BookIdTxt.Margin = new Padding(3, 4, 3, 4);
            BookIdTxt.Name = "BookIdTxt";
            BookIdTxt.Size = new Size(205, 27);
            BookIdTxt.TabIndex = 1;
            // 
            // BookIdLabel
            // 
            BookIdLabel.AutoSize = true;
            BookIdLabel.Location = new Point(22, 46);
            BookIdLabel.Name = "BookIdLabel";
            BookIdLabel.Size = new Size(65, 20);
            BookIdLabel.TabIndex = 0;
            BookIdLabel.Text = "Book ID:";
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 450);
            Controls.Add(groupBox1);
            Name = "EditBookForm";
            Text = "EditBookForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button SaveChangedBtn;
        private TextBox NumberOfPagesTxtNew;
        private Label label4;
        private TextBox BookWriterTxtNew;
        private Label label3;
        private TextBox BookNameTxtNew;
        private Label BookNameLabel;
        private TextBox BookIDTxtNew;
        private Label label1;
        private Button FindBookBtn;
        private TextBox BookIdTxt;
        private Label BookIdLabel;
    }
}