namespace GorselProgramlama_01
{
    partial class AddBookForm
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
            WriterNameTxt = new TextBox();
            AddBookBtn = new Button();
            NumberOfPagesTxt = new TextBox();
            BookNameTxt = new TextBox();
            WriterNameLabel = new Label();
            NumberOfPagesLabel = new Label();
            BookIdTxt = new TextBox();
            BookNameLabel = new Label();
            BookIdLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WriterNameTxt);
            groupBox1.Controls.Add(AddBookBtn);
            groupBox1.Controls.Add(NumberOfPagesTxt);
            groupBox1.Controls.Add(BookNameTxt);
            groupBox1.Controls.Add(WriterNameLabel);
            groupBox1.Controls.Add(NumberOfPagesLabel);
            groupBox1.Controls.Add(BookIdTxt);
            groupBox1.Controls.Add(BookNameLabel);
            groupBox1.Controls.Add(BookIdLabel);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(422, 287);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Information";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // WriterNameTxt
            // 
            WriterNameTxt.Location = new Point(165, 158);
            WriterNameTxt.Margin = new Padding(3, 4, 3, 4);
            WriterNameTxt.Name = "WriterNameTxt";
            WriterNameTxt.Size = new Size(205, 27);
            WriterNameTxt.TabIndex = 7;
            // 
            // AddBookBtn
            // 
            AddBookBtn.Location = new Point(165, 221);
            AddBookBtn.Margin = new Padding(3, 4, 3, 4);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(206, 31);
            AddBookBtn.TabIndex = 6;
            AddBookBtn.Text = "Add";
            AddBookBtn.UseVisualStyleBackColor = true;
            AddBookBtn.Click += ogrenciEkleBtn_Click;
            // 
            // NumberOfPagesTxt
            // 
            NumberOfPagesTxt.Location = new Point(165, 121);
            NumberOfPagesTxt.Margin = new Padding(3, 4, 3, 4);
            NumberOfPagesTxt.Name = "NumberOfPagesTxt";
            NumberOfPagesTxt.Size = new Size(205, 27);
            NumberOfPagesTxt.TabIndex = 3;
            // 
            // BookNameTxt
            // 
            BookNameTxt.Location = new Point(165, 79);
            BookNameTxt.Margin = new Padding(3, 4, 3, 4);
            BookNameTxt.Name = "BookNameTxt";
            BookNameTxt.Size = new Size(205, 27);
            BookNameTxt.TabIndex = 2;
            // 
            // WriterNameLabel
            // 
            WriterNameLabel.AutoSize = true;
            WriterNameLabel.Location = new Point(22, 158);
            WriterNameLabel.Name = "WriterNameLabel";
            WriterNameLabel.Size = new Size(97, 20);
            WriterNameLabel.TabIndex = 0;
            WriterNameLabel.Text = "Writer Name:";
            // 
            // NumberOfPagesLabel
            // 
            NumberOfPagesLabel.AutoSize = true;
            NumberOfPagesLabel.Location = new Point(22, 121);
            NumberOfPagesLabel.Name = "NumberOfPagesLabel";
            NumberOfPagesLabel.Size = new Size(128, 20);
            NumberOfPagesLabel.TabIndex = 0;
            NumberOfPagesLabel.Text = "Number Of Pages:";
            // 
            // BookIdTxt
            // 
            BookIdTxt.Location = new Point(166, 44);
            BookIdTxt.Margin = new Padding(3, 4, 3, 4);
            BookIdTxt.Name = "BookIdTxt";
            BookIdTxt.Size = new Size(205, 27);
            BookIdTxt.TabIndex = 1;
            // 
            // BookNameLabel
            // 
            BookNameLabel.AutoSize = true;
            BookNameLabel.Location = new Point(22, 82);
            BookNameLabel.Name = "BookNameLabel";
            BookNameLabel.Size = new Size(87, 20);
            BookNameLabel.TabIndex = 0;
            BookNameLabel.Text = "Book Name";
            // 
            // BookIdLabel
            // 
            BookIdLabel.AutoSize = true;
            BookIdLabel.Location = new Point(22, 44);
            BookIdLabel.Name = "BookIdLabel";
            BookIdLabel.Size = new Size(63, 20);
            BookIdLabel.TabIndex = 0;
            BookIdLabel.Text = "Book Id:";
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 313);
            Controls.Add(groupBox1);
            Name = "AddBookForm";
            Text = "KitapEklemeForm";
            Load += KitapEklemeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button AddBookBtn;
        private TextBox NumberOfPagesTxt;
        private TextBox BookNameTxt;
        private Label WriterNameLabel;
        private Label NumberOfPagesLabel;
        private TextBox BookIdTxt;
        private Label BookNameLabel;
        private Label BookIdLabel;
        private TextBox WriterNameTxt;
    }
}