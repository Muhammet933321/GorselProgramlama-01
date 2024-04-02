namespace GorselProgramlama_01
{
    partial class EditMemberForm
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
            MemberMailTxt = new TextBox();
            MemberMailLabel = new Label();
            MemberNameTxt = new TextBox();
            MemberNameLabel = new Label();
            MemberIDTxtNew = new TextBox();
            label1 = new Label();
            FindMemberBtn = new Button();
            MemberIdTxt = new TextBox();
            MemberIdLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SaveChangedBtn);
            groupBox1.Controls.Add(MemberMailTxt);
            groupBox1.Controls.Add(MemberMailLabel);
            groupBox1.Controls.Add(MemberNameTxt);
            groupBox1.Controls.Add(MemberNameLabel);
            groupBox1.Controls.Add(MemberIDTxtNew);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FindMemberBtn);
            groupBox1.Controls.Add(MemberIdTxt);
            groupBox1.Controls.Add(MemberIdLabel);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(422, 364);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Hire";
            // 
            // SaveChangedBtn
            // 
            SaveChangedBtn.Location = new Point(165, 305);
            SaveChangedBtn.Margin = new Padding(3, 4, 3, 4);
            SaveChangedBtn.Name = "SaveChangedBtn";
            SaveChangedBtn.Size = new Size(206, 31);
            SaveChangedBtn.TabIndex = 15;
            SaveChangedBtn.Text = "Save Changed";
            SaveChangedBtn.UseVisualStyleBackColor = true;
            SaveChangedBtn.Click += SaveChangedBtn_Click;
            // 
            // MemberMailTxt
            // 
            MemberMailTxt.Location = new Point(165, 247);
            MemberMailTxt.Margin = new Padding(3, 4, 3, 4);
            MemberMailTxt.Name = "MemberMailTxt";
            MemberMailTxt.Size = new Size(205, 27);
            MemberMailTxt.TabIndex = 14;
            // 
            // MemberMailLabel
            // 
            MemberMailLabel.AutoSize = true;
            MemberMailLabel.Location = new Point(21, 248);
            MemberMailLabel.Name = "MemberMailLabel";
            MemberMailLabel.Size = new Size(101, 20);
            MemberMailLabel.TabIndex = 13;
            MemberMailLabel.Text = "Member Mail:";
            // 
            // MemberNameTxt
            // 
            MemberNameTxt.Location = new Point(165, 212);
            MemberNameTxt.Margin = new Padding(3, 4, 3, 4);
            MemberNameTxt.Name = "MemberNameTxt";
            MemberNameTxt.Size = new Size(205, 27);
            MemberNameTxt.TabIndex = 10;
            // 
            // MemberNameLabel
            // 
            MemberNameLabel.AutoSize = true;
            MemberNameLabel.Location = new Point(21, 213);
            MemberNameLabel.Name = "MemberNameLabel";
            MemberNameLabel.Size = new Size(112, 20);
            MemberNameLabel.TabIndex = 9;
            MemberNameLabel.Text = "Member Name:";
            // 
            // MemberIDTxtNew
            // 
            MemberIDTxtNew.Location = new Point(166, 177);
            MemberIDTxtNew.Margin = new Padding(3, 4, 3, 4);
            MemberIDTxtNew.Name = "MemberIDTxtNew";
            MemberIDTxtNew.Size = new Size(205, 27);
            MemberIDTxtNew.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 178);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 7;
            label1.Text = "Member ID:";
            // 
            // FindMemberBtn
            // 
            FindMemberBtn.Location = new Point(165, 104);
            FindMemberBtn.Margin = new Padding(3, 4, 3, 4);
            FindMemberBtn.Name = "FindMemberBtn";
            FindMemberBtn.Size = new Size(206, 31);
            FindMemberBtn.TabIndex = 6;
            FindMemberBtn.Text = "Find The Member";
            FindMemberBtn.UseVisualStyleBackColor = true;
            FindMemberBtn.Click += FindMemberBtn_Click;
            // 
            // MemberIdTxt
            // 
            MemberIdTxt.Location = new Point(166, 44);
            MemberIdTxt.Margin = new Padding(3, 4, 3, 4);
            MemberIdTxt.Name = "MemberIdTxt";
            MemberIdTxt.Size = new Size(205, 27);
            MemberIdTxt.TabIndex = 1;
            // 
            // MemberIdLabel
            // 
            MemberIdLabel.AutoSize = true;
            MemberIdLabel.Location = new Point(22, 47);
            MemberIdLabel.Name = "MemberIdLabel";
            MemberIdLabel.Size = new Size(87, 20);
            MemberIdLabel.TabIndex = 0;
            MemberIdLabel.Text = "Member ID:";
            // 
            // EditMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 391);
            Controls.Add(groupBox1);
            Name = "EditMemberForm";
            Text = "EditMemberForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button SaveChangedBtn;
        private TextBox MemberMailTxt;
        private Label MemberMailLabel;
        private TextBox MemberNameTxt;
        private Label MemberNameLabel;
        private TextBox MemberIDTxtNew;
        private Label label1;
        private Button FindMemberBtn;
        private TextBox MemberIdTxt;
        private Label MemberIdLabel;
    }
}