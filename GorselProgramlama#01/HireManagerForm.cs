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

    public partial class HireManagerForm : Form
    {

        public HireManagerForm()
        {
            InitializeComponent();
        }

        private void HireTheBookBtn_Click(object sender, EventArgs e)
        {
            bool isntHaveError = true;
            int sayi;

            HiresClass hire = new HiresClass();
            if (int.TryParse(MemberIdTxt.Text, out sayi))
                hire.UserId = sayi;
            else
            {
                MessageBox.Show("Please Enter the Member Id Just Numeric Characters");
                MemberIdTxt.Text = "";
                isntHaveError = false;
            }
            if (int.TryParse(BookIdTxt.Text, out sayi))
                hire.BookId = sayi;
            else
            {
                MessageBox.Show("Please Enter the Book Id Just Numeric Characters");
                BookIdTxt.Text = "";
                isntHaveError = false;
            }
            bool IsValuesTrue = false;
            if (isntHaveError)
            {
                if (DataBase.Books.FirstOrDefault(o => o.ID == Convert.ToInt32(BookIdTxt.Text)) != null)
                {
                    DataBase.Books.FirstOrDefault(o => o.ID == Convert.ToInt32(BookIdTxt.Text)).State = 1;
                    IsValuesTrue = true;
                }
                else
                {
                    MessageBox.Show("We Dindn,t Find The Book");
                    BookIdTxt.Text = "";
                    IsValuesTrue = false;
                }
                if (DataBase.Members.FirstOrDefault(o => o.ID == Convert.ToInt32(MemberIdTxt.Text)) != null)
                {
                    if (IsValuesTrue)
                    {
                        DataBase.Hires.Add(hire);
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("We Dindn,t Find The Member");
                    MemberIdTxt.Text = "";
                    IsValuesTrue = false;

                }
            }
            


        }
    }
}
