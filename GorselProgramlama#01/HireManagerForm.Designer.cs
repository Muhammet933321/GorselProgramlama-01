namespace GorselProgramlama_01
{
    partial class HireManagerForm
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
            HireTheBookBtn = new Button();
            BookIdTxt = new TextBox();
            MemberIdTxt = new TextBox();
            BookIdLabel = new Label();
            MemberIdLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HireTheBookBtn);
            groupBox1.Controls.Add(BookIdTxt);
            groupBox1.Controls.Add(MemberIdTxt);
            groupBox1.Controls.Add(BookIdLabel);
            groupBox1.Controls.Add(MemberIdLabel);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(422, 199);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Hire";
            // 
            // HireTheBookBtn
            // 
            HireTheBookBtn.Location = new Point(165, 143);
            HireTheBookBtn.Margin = new Padding(3, 4, 3, 4);
            HireTheBookBtn.Name = "HireTheBookBtn";
            HireTheBookBtn.Size = new Size(206, 31);
            HireTheBookBtn.TabIndex = 6;
            HireTheBookBtn.Text = "Hire The Book";
            HireTheBookBtn.UseVisualStyleBackColor = true;
            HireTheBookBtn.Click += HireTheBookBtn_Click;
            // 
            // BookIdTxt
            // 
            BookIdTxt.Location = new Point(165, 79);
            BookIdTxt.Margin = new Padding(3, 4, 3, 4);
            BookIdTxt.Name = "BookIdTxt";
            BookIdTxt.Size = new Size(205, 27);
            BookIdTxt.TabIndex = 2;
            // 
            // MemberIdTxt
            // 
            MemberIdTxt.Location = new Point(166, 44);
            MemberIdTxt.Margin = new Padding(3, 4, 3, 4);
            MemberIdTxt.Name = "MemberIdTxt";
            MemberIdTxt.Size = new Size(205, 27);
            MemberIdTxt.TabIndex = 1;
            // 
            // BookIdLabel
            // 
            BookIdLabel.AutoSize = true;
            BookIdLabel.Location = new Point(22, 83);
            BookIdLabel.Name = "BookIdLabel";
            BookIdLabel.Size = new Size(63, 20);
            BookIdLabel.TabIndex = 0;
            BookIdLabel.Text = "Book Id:";
            // 
            // MemberIdLabel
            // 
            MemberIdLabel.AutoSize = true;
            MemberIdLabel.Location = new Point(22, 45);
            MemberIdLabel.Name = "MemberIdLabel";
            MemberIdLabel.Size = new Size(93, 20);
            MemberIdLabel.TabIndex = 0;
            MemberIdLabel.Text = "Memeber Id:";
            // 
            // HireManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 222);
            Controls.Add(groupBox1);
            Name = "HireManagerForm";
            Text = "EmanetIslemleriForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button HireTheBookBtn;
        private TextBox BookIdTxt;
        private TextBox MemberIdTxt;
        private Label BookIdLabel;
        private Label MemberIdLabel;
    }
}