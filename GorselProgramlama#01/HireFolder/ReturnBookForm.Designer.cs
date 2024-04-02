namespace GorselProgramlama_01
{
    partial class ReturnBookForm
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
            LastReturnTimeTxt = new TextBox();
            label2 = new Label();
            HireTimeTxt = new TextBox();
            label1 = new Label();
            ReturnBookBtn = new Button();
            MemberIdTxtNew = new TextBox();
            MemberIdLabel = new Label();
            BookIDTxtNew = new TextBox();
            bookIdLabelnew = new Label();
            FindBookBtn = new Button();
            BookIdTxt = new TextBox();
            BookIdLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LastReturnTimeTxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(HireTimeTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ReturnBookBtn);
            groupBox1.Controls.Add(MemberIdTxtNew);
            groupBox1.Controls.Add(MemberIdLabel);
            groupBox1.Controls.Add(BookIDTxtNew);
            groupBox1.Controls.Add(bookIdLabelnew);
            groupBox1.Controls.Add(FindBookBtn);
            groupBox1.Controls.Add(BookIdTxt);
            groupBox1.Controls.Add(BookIdLabel);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(422, 370);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Hire";
            // 
            // LastReturnTimeTxt
            // 
            LastReturnTimeTxt.Enabled = false;
            LastReturnTimeTxt.Location = new Point(164, 282);
            LastReturnTimeTxt.Margin = new Padding(3, 4, 3, 4);
            LastReturnTimeTxt.Name = "LastReturnTimeTxt";
            LastReturnTimeTxt.Size = new Size(205, 27);
            LastReturnTimeTxt.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 284);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 18;
            label2.Text = "Last Return Time:";
            // 
            // HireTimeTxt
            // 
            HireTimeTxt.Enabled = false;
            HireTimeTxt.Location = new Point(164, 247);
            HireTimeTxt.Margin = new Padding(3, 4, 3, 4);
            HireTimeTxt.Name = "HireTimeTxt";
            HireTimeTxt.Size = new Size(205, 27);
            HireTimeTxt.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 249);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 16;
            label1.Text = "Hire Time:";
            // 
            // ReturnBookBtn
            // 
            ReturnBookBtn.Location = new Point(164, 331);
            ReturnBookBtn.Margin = new Padding(3, 4, 3, 4);
            ReturnBookBtn.Name = "ReturnBookBtn";
            ReturnBookBtn.Size = new Size(206, 31);
            ReturnBookBtn.TabIndex = 15;
            ReturnBookBtn.Text = "Return Book";
            ReturnBookBtn.UseVisualStyleBackColor = true;
            ReturnBookBtn.Click += ReturnBookBtn_Click;
            // 
            // MemberIdTxtNew
            // 
            MemberIdTxtNew.Enabled = false;
            MemberIdTxtNew.Location = new Point(165, 212);
            MemberIdTxtNew.Margin = new Padding(3, 4, 3, 4);
            MemberIdTxtNew.Name = "MemberIdTxtNew";
            MemberIdTxtNew.Size = new Size(205, 27);
            MemberIdTxtNew.TabIndex = 10;
            // 
            // MemberIdLabel
            // 
            MemberIdLabel.AutoSize = true;
            MemberIdLabel.Location = new Point(21, 214);
            MemberIdLabel.Name = "MemberIdLabel";
            MemberIdLabel.Size = new Size(87, 20);
            MemberIdLabel.TabIndex = 9;
            MemberIdLabel.Text = "Member ID:";
            // 
            // BookIDTxtNew
            // 
            BookIDTxtNew.Enabled = false;
            BookIDTxtNew.Location = new Point(166, 177);
            BookIDTxtNew.Margin = new Padding(3, 4, 3, 4);
            BookIDTxtNew.Name = "BookIDTxtNew";
            BookIDTxtNew.Size = new Size(205, 27);
            BookIDTxtNew.TabIndex = 8;
            // 
            // bookIdLabelnew
            // 
            bookIdLabelnew.AutoSize = true;
            bookIdLabelnew.Location = new Point(22, 179);
            bookIdLabelnew.Name = "bookIdLabelnew";
            bookIdLabelnew.Size = new Size(65, 20);
            bookIdLabelnew.TabIndex = 7;
            bookIdLabelnew.Text = "Book ID:";
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
            BookIdLabel.Location = new Point(22, 48);
            BookIdLabel.Name = "BookIdLabel";
            BookIdLabel.Size = new Size(65, 20);
            BookIdLabel.TabIndex = 0;
            BookIdLabel.Text = "Book ID:";
            // 
            // ReturnBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 396);
            Controls.Add(groupBox1);
            Name = "ReturnBookForm";
            Text = "ReturnBookForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button ReturnBookBtn;
        private TextBox MemberIdTxtNew;
        private Label MemberIdLabel;
        private TextBox BookIDTxtNew;
        private Label bookIdLabelnew;
        private Button FindBookBtn;
        private TextBox BookIdTxt;
        private Label BookIdLabel;
        private TextBox LastReturnTimeTxt;
        private Label label2;
        private TextBox HireTimeTxt;
        private Label label1;
    }
}