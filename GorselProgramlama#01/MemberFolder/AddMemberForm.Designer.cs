namespace GorselProgramlama_01
{
    partial class AddMemberForm
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
            AddMemberBtn = new Button();
            MemberMailTxt = new TextBox();
            MemberNameTxt = new TextBox();
            MemberMailLabel = new Label();
            MemberIdTxt = new TextBox();
            MemberNameLabel = new Label();
            MemberIdLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddMemberBtn);
            groupBox1.Controls.Add(MemberMailTxt);
            groupBox1.Controls.Add(MemberNameTxt);
            groupBox1.Controls.Add(MemberMailLabel);
            groupBox1.Controls.Add(MemberIdTxt);
            groupBox1.Controls.Add(MemberNameLabel);
            groupBox1.Controls.Add(MemberIdLabel);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(422, 238);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Member";
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.Location = new Point(165, 180);
            AddMemberBtn.Margin = new Padding(3, 4, 3, 4);
            AddMemberBtn.Name = "AddMemberBtn";
            AddMemberBtn.Size = new Size(206, 31);
            AddMemberBtn.TabIndex = 6;
            AddMemberBtn.Text = "Add Member";
            AddMemberBtn.UseVisualStyleBackColor = true;
            AddMemberBtn.Click += AddMemberBtn_Click;
            // 
            // MemberMailTxt
            // 
            MemberMailTxt.Location = new Point(165, 121);
            MemberMailTxt.Margin = new Padding(3, 4, 3, 4);
            MemberMailTxt.Name = "MemberMailTxt";
            MemberMailTxt.Size = new Size(205, 27);
            MemberMailTxt.TabIndex = 3;
            // 
            // MemberNameTxt
            // 
            MemberNameTxt.Location = new Point(165, 79);
            MemberNameTxt.Margin = new Padding(3, 4, 3, 4);
            MemberNameTxt.Name = "MemberNameTxt";
            MemberNameTxt.Size = new Size(205, 27);
            MemberNameTxt.TabIndex = 2;
            // 
            // MemberMailLabel
            // 
            MemberMailLabel.AutoSize = true;
            MemberMailLabel.Location = new Point(22, 122);
            MemberMailLabel.Name = "MemberMailLabel";
            MemberMailLabel.Size = new Size(101, 20);
            MemberMailLabel.TabIndex = 0;
            MemberMailLabel.Text = "Member Mail:";
            // 
            // MemberIdTxt
            // 
            MemberIdTxt.Location = new Point(166, 44);
            MemberIdTxt.Margin = new Padding(3, 4, 3, 4);
            MemberIdTxt.Name = "MemberIdTxt";
            MemberIdTxt.Size = new Size(205, 27);
            MemberIdTxt.TabIndex = 1;
            // 
            // MemberNameLabel
            // 
            MemberNameLabel.AutoSize = true;
            MemberNameLabel.Location = new Point(22, 83);
            MemberNameLabel.Name = "MemberNameLabel";
            MemberNameLabel.Size = new Size(112, 20);
            MemberNameLabel.TabIndex = 0;
            MemberNameLabel.Text = "Member Name:";
            // 
            // MemberIdLabel
            // 
            MemberIdLabel.AutoSize = true;
            MemberIdLabel.Location = new Point(22, 45);
            MemberIdLabel.Name = "MemberIdLabel";
            MemberIdLabel.Size = new Size(85, 20);
            MemberIdLabel.TabIndex = 0;
            MemberIdLabel.Text = "Member Id:";
            // 
            // AddMemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 257);
            Controls.Add(groupBox1);
            Name = "AddMemberForm";
            Text = "Add Member Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button AddMemberBtn;
        private TextBox MemberMailTxt;
        private TextBox MemberNameTxt;
        private Label MemberMailLabel;
        private TextBox MemberIdTxt;
        private Label MemberNameLabel;
        private Label MemberIdLabel;
    }
}