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
    public partial class RemoveMemberForm : Form
    {
        int nowMemberId;
        public RemoveMemberForm()
        {
            InitializeComponent();
        }

        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {
            DataBase.RemoveMember(nowMemberId);
            SQLManager.RemoveMember(nowMemberId);
            this.Close();
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
                if (DataBase.Members.FirstOrDefault(o => o.ID == Convert.ToInt32(MemberIdTxt.Text)) != null)
                {
                    MemberClass member = DataBase.Members.FirstOrDefault(o => o.ID == Convert.ToInt32(MemberIdTxt.Text));
                    MemberIDTxtNew.Text = member.ID.ToString();
                    MemberNameTxt.Text = member.Name;
                    MemberMailTxt.Text = member.Mail;
                    nowMemberId = member.ID;
                }
                else
                {
                    MessageBox.Show("We Dindn,t Find The Member");
                    MemberIdTxt.Text = "";

                }
            }
        }
    }
}
