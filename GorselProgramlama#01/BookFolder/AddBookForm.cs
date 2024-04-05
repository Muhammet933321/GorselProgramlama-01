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

    public partial class AddBookForm : Form
    {

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ogrenciEkleBtn_Click(object sender, EventArgs e)
        {
            bool isntHaveError = true;
            int sayi;

            BookClass book = new BookClass();
            if (int.TryParse(BookIdTxt.Text, out sayi))
                book.ID = sayi;
            else
            {
                MessageBox.Show("Please Enter the Id Just Numeric Characters");
                BookIdTxt.Text = "";
                isntHaveError = false;
            }
                
            if (int.TryParse(NumberOfPagesTxt.Text, out sayi))
                book.NumberOfPages = sayi;
            else
            {
                MessageBox.Show("Please Enter the Number Of Pages Just Numeric Characters");
                NumberOfPagesTxt.Text = "";
                isntHaveError = false;
            }
            book.BookName = BookNameTxt.Text;
            book.WriterName = WriterNameTxt.Text;
            if (isntHaveError)
            {
                if (isntHaveError && DataBase.Books.FirstOrDefault(o => o.ID == Convert.ToInt32(BookIdTxt.Text)) == null)
                {

                    DataBase.Books.Add(book);
                    SQLManager.AddBook(book);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("This Id Is Already Usins");
                    BookIdTxt.Text = "";
                }
            }
            

                
        }

        private void KitapEklemeForm_Load(object sender, EventArgs e)
        {

        }

        private void yukleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
