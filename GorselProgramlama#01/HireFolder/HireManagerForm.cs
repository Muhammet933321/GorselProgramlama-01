using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GorselProgramlama_01.HireFolder;

namespace GorselProgramlama_01
{

    public partial class HireManagerForm : Form
    {
        MainMenuForm mainForm;
        public HireManagerForm()
        {
            InitializeComponent();
        }
        public HireManagerForm(MainMenuForm form)
        {
            if (form != null)
            {
                mainForm = form;
            }
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
                
                if (DataBase.Members.Find(o => o.ID == Convert.ToInt32(MemberIdTxt.Text)) != null)
                {
                    if (DataBase.Books.Find(o => o.ID == Convert.ToInt32(BookIdTxt.Text)) != null)
                    {
                        IsValuesTrue = true;
                        if (IsValuesTrue)
                        {
                            if (DataBase.Books.Find(o => o.ID == Convert.ToInt32(BookIdTxt.Text)).State == 0)
                            {
                                DataBase.Books.Find(o => o.ID == Convert.ToInt32(BookIdTxt.Text)).State = 1;
                                SQLManager.AddHire(hire);
                                mainForm.ShowInBooksDataTable();
                                mainForm.ShowInHiresDataTable();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("This Book Is Already Hired");
                                BookIdTxt.Text = "";
                                IsValuesTrue = false;
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("We Dindn,t Find The Book");
                        BookIdTxt.Text = "";
                        IsValuesTrue = false;
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
