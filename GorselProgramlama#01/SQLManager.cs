using GorselProgramlama_01.BookFolder;
using GorselProgramlama_01.HireFolder;
using GorselProgramlama_01.MemberFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama_01
{
    public static class SQLManager
    {
        static SQLiteConnection baglanti;
        public static void Conncet()
        {
            string baglanti_metni = "Data Source=LibraryDataBaseSQL.db;Version=3;";

            try
            {
                baglanti = new SQLiteConnection(baglanti_metni);
                baglanti.Open();

                //MessageBox.Show("SQLite Bağlantısı kuruldu",
                //               "Bağlantı sağlandı",
                //               MessageBoxButtons.OK,
                //               MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite Bağlantısı kurulamadı",
                                "Bağlantı hatası");
            }

        }
        public static void DisConnect()
        {
            if (baglanti != null && baglanti.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    baglanti.Close();

                    //MessageBox.Show("SQLite Bağlantısı başarıyla kapatıldı.",
                    //               "Bağlantı sonlandırıldı",
                    //               MessageBoxButtons.OK,
                    //               MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQLite Bağlantısı sonlandırılırken hata ile karşılaşıldı",
                                    "Bağlantı sonlandırma hatası",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        public static SQLiteDataReader GetDataReaderForBook()
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = baglanti;
            command.CommandText = "SELECT * FROM Book";
            SQLiteDataReader okuyucu = command.ExecuteReader();
            return okuyucu;
        }
        public static SQLiteDataReader GetDataReaderForMember()
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = baglanti;
            command.CommandText = "SELECT * FROM Member";
            SQLiteDataReader okuyucu = command.ExecuteReader();
            return okuyucu;
        }
        public static SQLiteDataReader GetDataReaderForHires()
        {
            SQLiteCommand command = new SQLiteCommand();
            command.Connection = baglanti;
            command.CommandText = "SELECT * FROM Hire";
            SQLiteDataReader okuyucu = command.ExecuteReader();
            return okuyucu;
        }

        
        public static void RemoveBook(BookClass book)
        {
             int id = book.ID;
             SQLiteCommand komut = new SQLiteCommand();
             komut.Connection = baglanti;
             komut.CommandText = $"DELETE FROM Book WHERE BookID = {id}";
             int eklenen_sayisi = komut.ExecuteNonQuery();
        }
        public static void RemoveMember(MemberClass member)
        {
            int id = member.ID;
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"DELETE FROM Member WHERE MemberID = {id}";
            int eklenen_sayisi = komut.ExecuteNonQuery();
        }
        public static void RemoveHire(int BookID)
        {
            int id = BookID;
            int zero = 0;
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"UPDATE Book SET State=\"{zero}\" WHERE BookID={id}";
            komut.ExecuteNonQuery();
            komut.CommandText = $"DELETE FROM Hire WHERE BookID = {id}";
            int eklenen_sayisi = komut.ExecuteNonQuery();
        }

        public static void AddBook(BookClass book)
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"INSERT INTO Book (BookID,BookName,NumberOfPages,WriterName,State) VALUES(\"{book.ID}\", \"{book.BookName}\", \"{book.NumberOfPages}\", \"{book.WriterName}\", \"{book.State}\")";
            komut.ExecuteNonQuery();
        }
        public static void AddMember(MemberClass member)
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"INSERT INTO Member (MemberID,MemberName,MemberMail) VALUES(\"{member.ID}\", \"{member.Name}\", \"{member.Mail}\")";
            komut.ExecuteNonQuery();
        }
        public static void AddHire(HiresClass hire)
        {
            int one = 1;
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"UPDATE Book SET State=\"{one}\" WHERE BookID={hire.BookId}";
            komut.ExecuteNonQuery();
            komut.CommandText = $"INSERT INTO Hire (MemberID,BookID) VALUES(\"{hire.UserId}\", \"{hire.BookId}\")";
            komut.ExecuteNonQuery();
        }

        public static void EditBook(int oldID, BookClass book)
        {
             SQLiteCommand komut = new SQLiteCommand();
             komut.Connection = baglanti;
             komut.CommandText = $"UPDATE Book SET BookID=\"{book.ID}\",BookName=\"{book.BookName}\",NumberOfPages=\"{book.NumberOfPages}\",WriterName=\"{book.WriterName}\",State=\"{book.State}\" WHERE BookID={oldID}";

             int eklenen_sayisi = komut.ExecuteNonQuery();
        }
        public static void EditMember(int oldID, MemberClass member)
        {
            SQLiteCommand komut = new SQLiteCommand();
            komut.Connection = baglanti;
            komut.CommandText = $"UPDATE Member SET MemberID=\"{member.ID}\",MemberName=\"{member.Name}\",MemberMail=\"{member.Mail}\" WHERE MemberID={oldID}";

            int eklenen_sayisi = komut.ExecuteNonQuery();
        }

    }
}
