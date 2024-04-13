using GorselProgramlama_01.BookFolder;
using GorselProgramlama_01.MemberFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama_01
{
    public partial class EditMemberForm : Form
    {
        int nowMemberId;
        MemberClass memberOld;
        MainMenuForm mainForm;
        public EditMemberForm()
        {
            InitializeComponent();
        }
        public EditMemberForm(MainMenuForm form)
        {
            if (form != null)
            {
                mainForm = form;
            }
            InitializeComponent();
        }
        
        private void FindMemberBtn_Click(object sender, EventArgs e)
        {
            int sayi;
            bool isWrong;
            if (int.TryParse(MemberIdTxt.Text, out sayi))
            {
                isWrong = false;
            }
            
            else
            {
                isWrong = true;
            }
            if (!isWrong)
            {
                if (DataBase.Members.Find(o => o.ID == Convert.ToInt32(MemberIdTxt.Text)) != null)
                {
                    memberOld = DataBase.Members.Find(o => o.ID == Convert.ToInt32(MemberIdTxt.Text));
                    MemberIDTxtNew.Text = memberOld.ID.ToString();
                    MemberNameTxt.Text = memberOld.Name;
                    MemberMailTxt.Text = memberOld.Mail;
                    nowMemberId = memberOld.ID;
                }
                else
                {
                    MessageBox.Show("We Dindn,t Find The Member");
                    MemberIdTxt.Text = "";

                }
            }
        }

        private void SaveChangedBtn_Click(object sender, EventArgs e)
        {
            {
                int sayi;
                bool isWrong;
                if (int.TryParse(MemberIdTxt.Text, out sayi))
                {
                    isWrong = false;
                }
                else
                {
                    MessageBox.Show("Please enter just numeric character for ID");
                    isWrong = true;
                }
                if (int.TryParse(MemberIDTxtNew.Text, out sayi))
                {
                    isWrong = false;
                }
                else
                {
                    MessageBox.Show("Please enter just numeric character for new ID");
                    isWrong = true;
                }
                if (!isWrong)
                {
                    if (DataBase.Members.Find(o => o.ID == Convert.ToInt32(nowMemberId)) != null)
                    {
                        if (nowMemberId == Convert.ToInt32(MemberIDTxtNew.Text) || 
                            DataBase.Members.Find(o => o.ID == Convert.ToInt32(MemberIDTxtNew.Text)) == null)
                        {
                            MemberClass member = new MemberClass(
                                Convert.ToInt32(MemberIDTxtNew.Text),
                                MemberNameTxt.Text,
                                MemberMailTxt.Text);
                            SQLManager.EditMember(nowMemberId,member);
                            mainForm.ShowInMembersDataTable();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Already This Id is using");
                            isWrong = true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("We Dindn,t Find The Book");
                        MemberIdTxt.Text = "";
                    }
                }
            }
        }
    }
}
