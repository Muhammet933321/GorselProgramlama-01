using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GorselProgramlama_01.BookFolder;

namespace GorselProgramlama_01
{
    public partial class RemoveBookForm : Form
    {
        int nowBookId;
        MainMenuForm mainForm;
        public RemoveBookForm()
        {
            InitializeComponent();
        }
        public RemoveBookForm(MainMenuForm form)
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
                isWrong = true;
            }
            if (!isWrong)
            {
                if (DataBase.Books.Find(o => o.ID == Convert.ToInt32(BookIdTxt.Text)) != null)
                {
                    BookClass book = DataBase.Books.Find(o => o.ID == Convert.ToInt32(BookIdTxt.Text));
                    BookNameTxtNew.Text = book.BookName;
                    BookWriterTxtNew.Text = book.WriterName;
                    NumberOfPagesTxtNew.Text = book.NumberOfPages.ToString();
                    BookIDTxtNew.Text = book.ID.ToString();
                    nowBookId = book.ID;
                    
                }
                else
                {
                    MessageBox.Show("We Dindn,t Find The Book");
                    BookIdTxt.Text = "";

                }
            }

        }

        private void RemoveBookBtn_Click(object sender, EventArgs e)
        {
            SQLManager.RemoveBook(Convert.ToInt32(BookIdTxt.Text));
            mainForm.ShowInBooksDataTable();
            this.Close();
        }
    }
}
