using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GorselProgramlama_01.MemberFolder;

namespace GorselProgramlama_01
{
    public partial class AddMemberForm : Form
    {
        MainMenuForm mainForm;
        public AddMemberForm()
        {
            InitializeComponent();
        }
        public AddMemberForm(MainMenuForm form)
        {
            if (form != null)
            {
                mainForm = form;
            }
            InitializeComponent();
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            bool isntHaveError = true;
            int sayi;
            MemberClass member = new MemberClass();
            if (int.TryParse(MemberIdTxt.Text, out sayi))
                member.ID = sayi;
            else
            {
                MessageBox.Show("Please Enter the Id Just Numeric Characters");
                MemberIdTxt.Text = "";
                isntHaveError = false;
            }
            member.Name = MemberNameTxt.Text;
            member.Mail = MemberMailTxt.Text;
            if (isntHaveError)
            {
                if (DataBase.Members.Find(o => o.ID == Convert.ToInt32(MemberIdTxt.Text)) == null)
                {
                    SQLManager.AddMember(member);
                    mainForm.ShowInMembersDataTable();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This Id Is Already Usins");
                    MemberIdTxt.Text = "";
                }
            }
            
        }
    }
}
