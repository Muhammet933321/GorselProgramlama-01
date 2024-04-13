using GorselProgramlama_01.BookFolder;
using GorselProgramlama_01.HireFolder;
using GorselProgramlama_01.MemberFolder;
using System.CodeDom;
using System.Xml.Linq;

namespace GorselProgramlama_01
{
    public static class DataBase
    {
        public static List<BookClass> Books = new List<BookClass>();
        public static List<MemberClass> Members = new List<MemberClass>();
        public static List<HiresClass> Hires = new List<HiresClass>();
        
        public static void BookEdit(int ID,int newID, string name, string writer, int numberofpages)
        {
            var book = Books.Find(x => x.ID == ID);
            book.ID = newID;
            book.BookName = name;
            book.WriterName = writer;
            book.NumberOfPages = numberofpages;
        }
        public static void RemoveBook(int ID)
        {
            var book = Books.Find(x => x.ID == ID);
            if (book.State == 0)
            {
                Books.Remove(book);
            }
            else
            {
                MessageBox.Show("Kiralanmis bir kitabi silemezsiniz !");
                throw new Exception();
            }
        }
        public static void MemberEdit(int ID,int newID, string name, string Mail)
        {
            var member = Members.Find(x => x.ID == ID);
            member.ID = newID;
            member.Name = name;
            member.Mail = Mail;
        }
        public static void RemoveMember(int ID)
        {
            var member = Members.Find(x => x.ID == ID);
            Members.Remove(member);
        }
        public static void ReturnBook(int ID)
        {
            try
            {
                var hire = Hires.Find(x => x.BookId == ID);
                var book = Books.Find(x => x.ID == hire.BookId);
                Hires.Remove(hire);
                book.State = 0;
            }
            catch
            {
                MessageBox.Show("Birseyler Yanlis Gitti Veriler Silinemedi !");
                throw new Exception();
            }
        }



    }
}
