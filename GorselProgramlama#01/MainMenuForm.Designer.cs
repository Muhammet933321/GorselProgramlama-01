namespace GorselProgramlama_01
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            AddMemberBtn = new Button();
            HireMangerBtn = new Button();
            AddBookBtn = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            loadDataToolStripMenuItem = new ToolStripMenuItem();
            BookDataTable = new DataGridView();
            MemberDataTable = new DataGridView();
            HireDataTable = new DataGridView();
            EditBookBtn = new Button();
            RemoveBookBtn = new Button();
            RemoveMemberBtn = new Button();
            EditMemberBtn = new Button();
            ReturnBtn = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookDataTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MemberDataTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HireDataTable).BeginInit();
            SuspendLayout();
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.Location = new Point(697, 554);
            AddMemberBtn.Name = "AddMemberBtn";
            AddMemberBtn.Size = new Size(136, 51);
            AddMemberBtn.TabIndex = 1;
            AddMemberBtn.Text = "Add Member";
            AddMemberBtn.UseVisualStyleBackColor = true;
            AddMemberBtn.Click += UyeEkle_Click;
            // 
            // HireMangerBtn
            // 
            HireMangerBtn.Location = new Point(1252, 554);
            HireMangerBtn.Name = "HireMangerBtn";
            HireMangerBtn.Size = new Size(136, 51);
            HireMangerBtn.TabIndex = 2;
            HireMangerBtn.Text = "Hire Manager";
            HireMangerBtn.UseVisualStyleBackColor = true;
            HireMangerBtn.Click += EmanetEkleBtn_Click;
            // 
            // AddBookBtn
            // 
            AddBookBtn.Location = new Point(91, 554);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(136, 51);
            AddBookBtn.TabIndex = 3;
            AddBookBtn.Text = "Add Book";
            AddBookBtn.UseVisualStyleBackColor = true;
            AddBookBtn.Click += KitapEkleBtn_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1692, 27);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { loadDataToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(46, 24);
            toolStripDropDownButton1.Text = "File";
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // loadDataToolStripMenuItem
            // 
            loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            loadDataToolStripMenuItem.Size = new Size(224, 26);
            loadDataToolStripMenuItem.Text = "Load Data";
            loadDataToolStripMenuItem.Click += loadDataToolStripMenuItem_Click;
            // 
            // BookDataTable
            // 
            BookDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDataTable.Location = new Point(12, 43);
            BookDataTable.Name = "BookDataTable";
            BookDataTable.RowHeadersWidth = 51;
            BookDataTable.Size = new Size(678, 505);
            BookDataTable.TabIndex = 5;
            // 
            // MemberDataTable
            // 
            MemberDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberDataTable.Location = new Point(697, 43);
            MemberDataTable.Name = "MemberDataTable";
            MemberDataTable.RowHeadersWidth = 51;
            MemberDataTable.Size = new Size(428, 505);
            MemberDataTable.TabIndex = 6;
            // 
            // HireDataTable
            // 
            HireDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HireDataTable.Location = new Point(1131, 43);
            HireDataTable.Name = "HireDataTable";
            HireDataTable.RowHeadersWidth = 51;
            HireDataTable.Size = new Size(553, 505);
            HireDataTable.TabIndex = 7;
            // 
            // EditBookBtn
            // 
            EditBookBtn.Location = new Point(270, 554);
            EditBookBtn.Name = "EditBookBtn";
            EditBookBtn.Size = new Size(136, 51);
            EditBookBtn.TabIndex = 8;
            EditBookBtn.Text = "Edit Book";
            EditBookBtn.UseVisualStyleBackColor = true;
            EditBookBtn.Click += EditBookBtn_Click;
            // 
            // RemoveBookBtn
            // 
            RemoveBookBtn.Location = new Point(457, 554);
            RemoveBookBtn.Name = "RemoveBookBtn";
            RemoveBookBtn.Size = new Size(136, 51);
            RemoveBookBtn.TabIndex = 9;
            RemoveBookBtn.Text = "Remove Book";
            RemoveBookBtn.UseVisualStyleBackColor = true;
            RemoveBookBtn.Click += RemoveBookBtn_Click;
            // 
            // RemoveMemberBtn
            // 
            RemoveMemberBtn.Location = new Point(989, 555);
            RemoveMemberBtn.Name = "RemoveMemberBtn";
            RemoveMemberBtn.Size = new Size(136, 51);
            RemoveMemberBtn.TabIndex = 10;
            RemoveMemberBtn.Text = "Remove Member";
            RemoveMemberBtn.UseVisualStyleBackColor = true;
            RemoveMemberBtn.Click += RemoveMemberBtn_Click;
            // 
            // EditMemberBtn
            // 
            EditMemberBtn.Location = new Point(847, 554);
            EditMemberBtn.Name = "EditMemberBtn";
            EditMemberBtn.Size = new Size(136, 51);
            EditMemberBtn.TabIndex = 11;
            EditMemberBtn.Text = "Edit Member";
            EditMemberBtn.UseVisualStyleBackColor = true;
            EditMemberBtn.Click += EditMemberBtn_Click;
            // 
            // ReturnBtn
            // 
            ReturnBtn.Location = new Point(1436, 554);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(136, 51);
            ReturnBtn.TabIndex = 12;
            ReturnBtn.Text = "Return Manager";
            ReturnBtn.UseVisualStyleBackColor = true;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1692, 618);
            Controls.Add(ReturnBtn);
            Controls.Add(EditMemberBtn);
            Controls.Add(RemoveMemberBtn);
            Controls.Add(RemoveBookBtn);
            Controls.Add(EditBookBtn);
            Controls.Add(HireDataTable);
            Controls.Add(MemberDataTable);
            Controls.Add(BookDataTable);
            Controls.Add(toolStrip1);
            Controls.Add(AddBookBtn);
            Controls.Add(HireMangerBtn);
            Controls.Add(AddMemberBtn);
            Name = "MainMenuForm";
            Text = "GirisEkraniForm";
            FormClosing += MainMenu_FormClosing;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookDataTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)MemberDataTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)HireDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddMemberBtn;
        private Button HireMangerBtn;
        private Button AddBookBtn;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem loadDataToolStripMenuItem;
        private DataGridView BookDataTable;
        private DataGridView MemberDataTable;
        private DataGridView HireDataTable;
        private Button EditBookBtn;
        private Button RemoveBookBtn;
        private Button RemoveMemberBtn;
        private Button EditMemberBtn;
        private Button ReturnBtn;
    }
}