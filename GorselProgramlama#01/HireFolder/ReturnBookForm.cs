using GorselProgramlama_01.BookFolder;
using GorselProgramlama_01.HireFolder;
using GorselProgramlama_01.MemberFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama_01
{
    public partial class ReturnBookForm : Form
    {
        MainMenuForm mainForm;
        public ReturnBookForm()
        {
            InitializeComponent();
        }
        public ReturnBookForm(MainMenuForm form)
        {
            if (form != null)
            {
                mainForm = form;
            }
            InitializeComponent();
        }
        
    private void FindBookBtn_Click(object sender, EventArgs e)
        {
            int sayi;
            bool isWrong;
            if (int.TryParse(BookIdTxt.Text, out sayi))
            {
                isWrong = false;
            }
            else
            {
                MessageBox.Show("Please enter just numeric characters for ID");
                isWrong = true;
            }
            if (!isWrong)
                if (DataBase.Hires.Find(o => o.BookId == Convert.ToInt32(BookIdTxt.Text)) != null)
                {

                    HiresClass hire = DataBase.Hires.Find(o => o.BookId == Convert.ToInt32(BookIdTxt.Text));
                    int MemberId = hire.UserId;
                    MemberClass member = DataBase.Members.Find(o => o.ID == MemberId);
                    BookIDTxtNew.Text = hire.BookId.ToString();
                    BookIDTxtNew.Text = hire.BookId.ToString();
                    MemberIdTxtNew.Text = MemberId.ToString();
                    string HireTime = $"{hire.HireTime.Day}.{hire.HireTime.Month}.{hire.HireTime.Year}";
                    string ReturnTime = $"{hire.ReturnTime.Day}.{hire.ReturnTime.Month}.{hire.ReturnTime.Year}";
                    HireTimeTxt.Text = HireTime;
                    LastReturnTimeTxt.Text = ReturnTime;
                }
                else
                {
                    MessageBox.Show("We Dindn,t Find The Book");
                    BookIdTxt.Text = "";

                }
        }

        private void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            int sayi;
            if (int.TryParse(BookIdTxt.Text, out sayi))
            {
                if (DataBase.Hires.Find(o => o.BookId == Convert.ToInt32(BookIdTxt.Text)) != null)
                {
                    SQLManager.RemoveHire(sayi);
                    mainForm.ShowInHiresDataTable();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("We didn't find the book with this ID");
                }
            }
            else
            {
                MessageBox.Show("Please enter just numeric characters for ID");
            }
        }
    }
}