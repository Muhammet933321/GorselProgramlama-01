using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama_01
{
    public partial class GirisEkraniForm : Form
    {
        SQLiteConnection dataBaseConnection;
        public void AddBookSQLDataBase( int Id,string Name ,int NumberOfPagges,string WriterName) 
        {
            dataBaseConnection.Open();
            string insertQuery = $"INSERT INTO BookTable (Id, Name,NumberOfPages,WriterName,State) VALUES ('{Id}', '{Name}','{NumberOfPagges}','{WriterName}','0')";
            SQLiteCommand command = new SQLiteCommand(insertQuery, dataBaseConnection);
            command.ExecuteNonQuery();

            dataBaseConnection.Close();
        }
        public void GetSQLDataBase()
        {
            dataBaseConnection.Open();
            string selectQuery = "SELECT * FROM BookTable";
            SQLiteCommand command = new SQLiteCommand(selectQuery, dataBaseConnection);

            // Verileri okuma
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0); // İlk sütun Id
                string name = reader.GetString(1); // İkinci sütun Name
                int numberOfPages = reader.GetInt32(2); // Üçüncü sütun NumberOfPages
                string writerName = reader.GetString(3); // Dördüncü sütun WriterName
                int state = reader.GetInt32(4); // Beşinci sütun State

                // Verileri işleme veya ekrana yazdırma
                Console.WriteLine($"Id: {id}, Name: {name}, NumberOfPages: {numberOfPages}, WriterName: {writerName}, State: {state}");
            }

            // Veritabanı bağlantısını kapatma
            dataBaseConnection.Close();
        }
        public GirisEkraniForm()
        {
            InitializeComponent();
            string connectionText = "Data Source=./SQLDataBase;Version=3;";
            try
            {
                dataBaseConnection = new SQLiteConnection(connectionText);
                
                //MessageBox.Show("Baglanti Basari ile Kuruldu.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baglanti Kurulamadi !!!!!!!!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UyeEkle_Click(object sender, EventArgs e)
        {
            UyeEklemeForm Form = new UyeEklemeForm();
            Form.Show();
        }

        private void KitapEkleBtn_Click(object sender, EventArgs e)
        {
            KitapEklemeForm form = new KitapEklemeForm();
            form.Show();
        }

        private void EmanetEkleBtn_Click(object sender, EventArgs e)
        {
            EmanetIslemleriForm form = new EmanetIslemleriForm();
            form.Show();
        }


    }
}
