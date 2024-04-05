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
            try
            {
                SQLiteCommand command1 = new SQLiteCommand();
                command1.Connection = baglanti;
                command1.CommandText = "SELECT * FROM Book";
                SQLiteDataReader okuyucu1 = command1.ExecuteReader();
                return okuyucu1;
            }
            catch 
            {
                string connectionString = $"Data Source=BookLibrary.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createTableQuery = "CREATE TABLE IF NOT EXISTS Books (BookID INTEGER PRIMARY KEY AUTOINCREMENT, BookName TEXT,NumberOfPages INTEGER, WriterName TEXT,State INTEGER)";
                    using (SQLiteCommand command2 = new SQLiteCommand(createTableQuery, connection))
                    {
                        command2.ExecuteNonQuery();
                    }
                }

            }

            SQLiteCommand command3 = new SQLiteCommand();
            command3.Connection = baglanti;
            command3.CommandText = "SELECT * FROM Book";
            SQLiteDataReader okuyucu2 = command3.ExecuteReader();
            return okuyucu2;

        }
        public static SQLiteDataReader GetDataReaderForMember()
        {
            

            try
            {
                SQLiteCommand command1 = new SQLiteCommand();
                command1.Connection = baglanti;
                command1.CommandText = "SELECT * FROM Member";
                SQLiteDataReader okuyucu1 = command1.ExecuteReader();
                return okuyucu1;
            }
            catch
            {
                string connectionString = $"Data Source=BookLibrary.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createTableQuery = "CREATE TABLE IF NOT EXISTS Member (MemberID INTEGER PRIMARY KEY AUTOINCREMENT, MemberName TEXT,MemberMail TEXT)";
                    using (SQLiteCommand command2 = new SQLiteCommand(createTableQuery, connection))
                    {
                        command2.ExecuteNonQuery();
                    }
                }

            }
            SQLiteCommand command3 = new SQLiteCommand();
            command3.Connection = baglanti;
            command3.CommandText = "SELECT * FROM Member";
            SQLiteDataReader okuyucu2 = command3.ExecuteReader();
            return okuyucu2;
        }
        public static SQLiteDataReader GetDataReaderForHires()
        {
            
            try
            {
                SQLiteCommand command1 = new SQLiteCommand();
                command1.Connection = baglanti;
                command1.CommandText = "SELECT * FROM Hire";
                SQLiteDataReader okuyucu1 = command1.ExecuteReader();
                return okuyucu1;
            }
            catch
            {
                string connectionString = $"Data Source=BookLibrary.db;Version=3;";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createTableQuery = "CREATE TABLE IF NOT EXISTS Hire (MemberID INTEGER, BookID INTEGER)";
                    using (SQLiteCommand command2 = new SQLiteCommand(createTableQuery, connection))
                    {
                        command2.ExecuteNonQuery();
                    }
                }

            }
            SQLiteCommand command3 = new SQLiteCommand();
            command3.Connection = baglanti;
            command3.CommandText = "SELECT * FROM Hire";
            SQLiteDataReader okuyucu2 = command3.ExecuteReader();
            return okuyucu2;

        }

        
        public static void RemoveBook(int bookID)
        {
             int id = bookID;
             SQLiteCommand komut = new SQLiteCommand();
             komut.Connection = baglanti;
             komut.CommandText = $"DELETE FROM Book WHERE BookID = {id}";
             int eklenen_sayisi = komut.ExecuteNonQuery();
        }
        public static void RemoveMember(int memberID)
        {
            int id = memberID;
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
