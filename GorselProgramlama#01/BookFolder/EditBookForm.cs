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
    public partial class EditBookForm : Form
    {
        int nowBookId;
        public EditBookForm()
        {
            InitializeComponent();
        }
        BookClass bookOld;
        private void FindBookBtn_Click(object sender, EventArgs e)
        {
            int sayi;
            bool isWrong;
            if (    int.TryParse(BookIdTxt.Text, out sayi)){isWrong = false; }
            else{   isWrong = true; }
            if (!isWrong)
            {
                if (DataBase.Books.FirstOrDefault(o => o.ID == Convert.ToInt32(BookIdTxt.Text)) != null)
                {
                    bookOld = DataBase.Books.FirstOrDefault(o => o.ID == Convert.ToInt32(BookIdTxt.Text));
                    BookNameTxtNew.Text = bookOld.BookName;
                    BookWriterTxtNew.Text = bookOld.WriterName;
                    NumberOfPagesTxtNew.Text = bookOld.NumberOfPages.ToString();
                    BookIDTxtNew.Text = bookOld.ID.ToString();
                    nowBookId = bookOld.ID;
                }
                else
                {
                    MessageBox.Show("We Dindn,t Find The Book");
                    BookIdTxt.Text = "";
                }
            }
        }

        private void SaveChangedBtn_Click(object sender, EventArgs e)
        {
            int sayi;
            bool isWrong;
            if (int.TryParse(BookIDTxtNew.Text, out sayi)){ isWrong = false; }
            else
            {
                MessageBox.Show("Please enter just numeric character for ID");
                isWrong = true;
            }
            if (int.TryParse(NumberOfPagesTxtNew.Text, out sayi)){ isWrong = false; }
            else
            {
                MessageBox.Show("Please enter just numeric character for Number Of Pages");
                isWrong = true;
            }
            if (!isWrong)
            {
                if (DataBase.Books.FirstOrDefault(o => o.ID == Convert.ToInt32(nowBookId)) != null)
                {
                    if (nowBookId == Convert.ToInt32(BookIDTxtNew.Text) || 
                        DataBase.Books.FirstOrDefault(o => o.ID == Convert.ToInt32(BookIDTxtNew.Text)) == null )
                    {
                        BookClass book = new BookClass(
                            Convert.ToInt32(BookIDTxtNew.Text),
                            BookNameTxtNew.Text,
                            Convert.ToInt32(NumberOfPagesTxtNew.Text),
                            BookWriterTxtNew.Text,
                            bookOld.State
                        );
                        SQLManager.EditBook(nowBookId, book);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Already This ID is using");
                        isWrong = true;
                    }
                }
                else
                {
                    MessageBox.Show("We Dindn,t Find The Book");
                    BookIdTxt.Text = "";
                }
            }
        }
    }
}
