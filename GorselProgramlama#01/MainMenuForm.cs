using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using GorselProgramlama_01.BookFolder;
using GorselProgramlama_01.HireFolder;
using GorselProgramlama_01.MemberFolder;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GorselProgramlama_01
{
    public partial class MainMenuForm : Form
    {
        public DataTable dtMembers;
        public DataTable dtBooks;
        public DataTable dtHires;
        public MainMenuForm()
        {
            InitializeComponent();
            SQLManager.Conncet();
            BaseTable();
            //ReadAllDataFromJSON();
            ReadAllDataFromSQL();


        }
        private void BaseTable()
        {
            dtMembers = new DataTable();
            dtMembers.Columns.Add("Member Id:");
            dtMembers.Columns.Add("Member Name:");
            dtMembers.Columns.Add("Member Mail:");
            MemberDataTable.DataSource = dtMembers;

            dtBooks = new DataTable();
            dtBooks.Columns.Add("Book Id:");
            dtBooks.Columns.Add("Book Name:");
            dtBooks.Columns.Add("Number Of Pages:");
            dtBooks.Columns.Add("Writer Name:");
            dtBooks.Columns.Add("Book State:");
            BookDataTable.DataSource = dtBooks;

            dtHires = new DataTable();
            dtHires.Columns.Add("Hired User Id:");
            dtHires.Columns.Add("Hired Book Id:");
            dtHires.Columns.Add("Hired Time :");
            dtHires.Columns.Add("End Return Time:");
            HireDataTable.DataSource = dtHires;
        }
        public void ShowInMembersDataTable(MemberClass member)
        {
            dtMembers.Rows.Add(new object[]
                { member.ID,
                  member.Name,
                  member.Mail
                });
        }
        public void ShowInMembersDataTable()
        {
            dtMembers.Clear();
            foreach (MemberClass member in DataBase.Members )
            {
                dtMembers.Rows.Add(new object[]
                { member.ID,
                  member.Name,
                  member.Mail
                });
            }
            
        }
        public void ShowInBooksDataTable(BookClass book)
        {
            if (book.State == 0)
                dtBooks.Rows.Add(new object[]
                    { book.ID,
                  book.BookName,
                  book.NumberOfPages,
                  book.WriterName,
                  "In Library"});
            if (book.State == 1)
                dtBooks.Rows.Add(new object[]
                { book.ID,
                  book.BookName,
                  book.NumberOfPages,
                  book.WriterName,
                  "Hired"});
        }
        public void ShowInBooksDataTable()
        {
            dtBooks.Clear();
            foreach (BookClass book in DataBase.Books)
            {
                if (book.State == 0)
                    dtBooks.Rows.Add(new object[]
                        { book.ID,
                  book.BookName,
                  book.NumberOfPages,
                  book.WriterName,
                  "In Library"});
                if (book.State == 1)
                    dtBooks.Rows.Add(new object[]
                    { book.ID,
                  book.BookName,
                  book.NumberOfPages,
                  book.WriterName,
                  "Hired"});
            }

        }
        public void ShowInHiresDataTable(HiresClass hire)
        {
            string DateTime = $"{hire.HireTime.Day}.{hire.HireTime.Month}.{hire.HireTime.Year}";
            string ReturnTime = $"{hire.ReturnTime.Day}.{hire.ReturnTime.Month}.{hire.ReturnTime.Year}";
            dtHires.Rows.Add(new object[]
                { hire.UserId,
                  hire.BookId,
                  DateTime,
                  ReturnTime});
        }
        public void ShowInHiresDataTable()
        {
            dtHires.Clear();
            foreach (HiresClass hire in DataBase.Hires)
            {
                string DateTime = $"{hire.HireTime.Day}.{hire.HireTime.Month}.{hire.HireTime.Year}";
                string ReturnTime = $"{hire.ReturnTime.Day}.{hire.ReturnTime.Month}.{hire.ReturnTime.Year}";
                dtHires.Rows.Add(new object[]
                    { hire.UserId,
                  hire.BookId,
                  DateTime,
                  ReturnTime});
            }

        }


        public void WriteAllDataFromJSON()
        {
            File.Delete("Books.json");
            dtBooks.Rows.Clear();
            File.Delete("Members.json");
            dtMembers.Rows.Clear();
            File.Delete("Hires.json");
            dtHires.Rows.Clear();


            //If I didn't create this options object,
            //JsonSerializer was returning an empty object when both serializing and deserializing.
            //That's why I had to create it. ChatGPT couldn't solve this problem :),
            //so I had to find the answer on Stack Overflow.
            var options = new JsonSerializerOptions()
            {
                IncludeFields = true,
            };
            ///
            ///Save Books
            ///
            foreach (BookClass book in DataBase.Books)
            {
                ShowInBooksDataTable(book);
            }
            string WriteBooks = JsonSerializer.Serialize<List<BookClass>>(DataBase.Books, options);
            File.WriteAllText("Books.json", WriteBooks, Encoding.UTF8);
            ///
            ///Save Members
            ///
            foreach (MemberClass member in DataBase.Members)
            {
                ShowInMembersDataTable(member);
            }
            string WriteMembers = JsonSerializer.Serialize<List<MemberClass>>(DataBase.Members, options);
            File.WriteAllText("Members.json", WriteMembers, Encoding.UTF8);
            ///
            ///Save Hires
            ///
            foreach (HiresClass hire in DataBase.Hires)
            {
                ShowInHiresDataTable(hire);
            }
            string WriteHires = JsonSerializer.Serialize<List<HiresClass>>(DataBase.Hires, options);
            File.WriteAllText("Hires.json", WriteHires, Encoding.UTF8);
        }
        private void ReadAllDataFromJSON()
        {
            DataBase.Books.Clear();
            DataBase.Members.Clear();
            DataBase.Hires.Clear();
            var options = new JsonSerializerOptions()
            {
                IncludeFields = true,
            };
            if (File.Exists("Books.json"))
            {
                string dataBooks = File.ReadAllText("Books.json");
                if (!string.IsNullOrEmpty(dataBooks))
                {
                    List<BookClass> AllBooks = JsonSerializer.Deserialize<List<BookClass>>(dataBooks, options);
                    foreach (BookClass book in AllBooks)
                    {
                        DataBase.Books.Add(book);
                        ShowInBooksDataTable(book);
                    }

                }

            }
            if (File.Exists("Members.json"))
            {
                string dataMembers = File.ReadAllText("Members.json");
                if (!string.IsNullOrEmpty(dataMembers))
                {
                    List<MemberClass> AllMembers = JsonSerializer.Deserialize<List<MemberClass>>(dataMembers, options);
                    foreach (MemberClass member in AllMembers)
                    {
                        DataBase.Members.Add(member);
                        ShowInMembersDataTable(member);
                    }

                }


            }
            if (File.Exists("Hires.json"))
            {
                string dataHires = File.ReadAllText("Hires.json");
                if (!string.IsNullOrEmpty(dataHires))
                {
                    List<HiresClass> AllHires = JsonSerializer.Deserialize<List<HiresClass>>(dataHires, options);
                    foreach (HiresClass hire in AllHires)
                    {
                        DataBase.Hires.Add(hire);
                        ShowInHiresDataTable(hire);
                    }
                }

            }



        }
        private void ReadAllDataFromSQL()
        {
            SQLiteDataReader reader = SQLManager.GetDataReaderForBook();
            while (reader.Read())
            {
                BookClass book = new BookClass(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetString(3),
                    reader.GetInt32(4)
                    );
                DataBase.Books.Add(book);
                ShowInBooksDataTable(book);
            }
            reader = SQLManager.GetDataReaderForMember();
            while (reader.Read())
            {
                MemberClass member = new MemberClass(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2)
                    );
                DataBase.Members.Add(member);
                ShowInMembersDataTable(member);
            }
            reader = SQLManager.GetDataReaderForHires();
            while (reader.Read())
            {
                HiresClass hire = new HiresClass(
                    reader.GetInt32(0),
                    reader.GetInt32(1)
                    );
                DataBase.Hires.Add(hire);
                ShowInHiresDataTable(hire);
            }
        }


        private void UyeEkle_Click(object sender, EventArgs e)
        {
            AddMemberForm Form = new AddMemberForm(this);
            Form.Show();
        }

        private void KitapEkleBtn_Click(object sender, EventArgs e)
        {
            AddBookForm form = new AddBookForm(this);
            form.Show();
        }

        private void EmanetEkleBtn_Click(object sender, EventArgs e)
        {
            HireManagerForm form = new HireManagerForm(this);
            form.Show();
        }


        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtBooks.Clear();
            dtHires.Clear();
            dtMembers.Clear();
            ReadAllDataFromSQL();
        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteAllDataFromJSON();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLManager.DisConnect();
        }

        private void EditBookBtn_Click(object sender, EventArgs e)
        {
            EditBookForm form = new EditBookForm(this);
            form.Show();
        }

        

        private void RemoveBookBtn_Click(object sender, EventArgs e)
        {
            RemoveBookForm form = new RemoveBookForm(this);
            form.Show();
        }

        private void EditMemberBtn_Click(object sender, EventArgs e)
        {
            EditMemberForm form = new EditMemberForm(this);
            form.Show();
        }

        private void RemoveMemberBtn_Click(object sender, EventArgs e)
        {
            RemoveMemberForm form = new RemoveMemberForm(this);
            form.Show();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            ReturnBookForm form = new ReturnBookForm(this);
            form.Show();
        }
    }
}
