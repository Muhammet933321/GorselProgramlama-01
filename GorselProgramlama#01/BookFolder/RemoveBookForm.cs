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
        public RemoveBookForm()
        {
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
                if (DataBase.Books.FirstOrDefault(o => o.ID == Convert.ToInt32(BookIdTxt.Text)) != null)
                {
                    BookClass book = DataBase.Books.FirstOrDefault(o => o.ID == Convert.ToInt32(BookIdTxt.Text));
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

            DataBase.RemoveBook(Convert.ToInt32(BookIdTxt.Text));
            SQLManager.RemoveBook(Convert.ToInt32(BookIdTxt.Text));
            this.Close();
        }
    }
}
