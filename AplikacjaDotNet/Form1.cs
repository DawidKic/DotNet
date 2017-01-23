using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaDotNet
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='D:\\GIT PLIKI\\Dotnet\\AplikacjaDotNet-20170122T093055Z\\AplikacjaDotNet\\AplikacjaDotNet\\Database1.mdf';Integrated Security=True");
        
        

        public Form1()
        {
            InitializeComponent();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM Produkty";

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            adapter.Fill(ds);
            dataGridViewProdukty.DataSource = ds.Tables[0];

            command.CommandText = "SELECT * FROM Klienci";

            SqlDataAdapter adapter2 = new SqlDataAdapter(command);

            DataSet ds2 = new DataSet();

            adapter2.Fill(ds2);
            dataGridViewKlienci.DataSource = ds2.Tables[0];

            command.CommandText = "SELECT * FROM Zamowienia";

            SqlDataAdapter adapter3 = new SqlDataAdapter(command);

            DataSet ds3 = new DataSet();

            adapter3.Fill(ds3);
            dataGridViewZamowienia.DataSource = ds3.Tables[0];
        }

        private void buttonAddProdukt_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Produkty VALUES(@nazwa, @producent, @rok, @ilosc)";

            command.Parameters.AddWithValue("nazwa", textBoxNazwa.Text);
            command.Parameters.AddWithValue("producent", textBoxProducent.Text);
            command.Parameters.Add("rok", SqlDbType.Date).Value = dateTimePickerRok.Value.Date;
            command.Parameters.AddWithValue("ilosc", numericUpDownIlosc.Value);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            command.CommandText = "SELECT * FROM Produkty";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
 
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewProdukty.DataSource = ds.Tables[0];

        }

        private void buttonAddKlient_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Klienci VALUES(@imie, @nazwisko, @miasto)";

            command.Parameters.AddWithValue("imie", textBoxImie.Text);
            command.Parameters.AddWithValue("nazwisko", textBoxNazwisko.Text);
            command.Parameters.AddWithValue("miasto", textBoxMiasto.Text);


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            command.CommandText = "SELECT * FROM Klienci";

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewKlienci.DataSource = ds.Tables[0];

        }

        private void buttonAddZamowienia_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            int selectedrowindexProdukty = dataGridViewProdukty.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowProdukty = dataGridViewProdukty.Rows[selectedrowindexProdukty];
            int Produkty_ID = Convert.ToInt32(selectedRowProdukty.Cells["Produkty_ID"].Value);

            int selectedrowindexKlienci = dataGridViewKlienci.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowKlienci = dataGridViewKlienci.Rows[selectedrowindexKlienci];
            int Klienci_ID = Convert.ToInt32(selectedRowKlienci.Cells["Klienci_ID"].Value);
            command.CommandText = "INSERT INTO Zamowienia VALUES(@Klienci_ID, @Produkty_ID)";


            command.Parameters.AddWithValue("Klienci_ID", Klienci_ID);
            command.Parameters.AddWithValue("Produkty_ID", Produkty_ID);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            command.CommandText = "SELECT Z.Zamowienia_ID, P.nazwa as Produkt, CONCAT(K.imie,' ', K.nazwisko) as Klient FROM Zamowienia as Z, Klienci as K, Produkty as P WHERE K.Klienci_ID = Z.Klienci_ID AND P.Produkty_ID = Z.Produkty_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewZamowienia.DataSource = ds.Tables[0];

        }

        private void deleteProdukty_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            int selectedrowindexProdukty = dataGridViewProdukty.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowProdukty = dataGridViewProdukty.Rows[selectedrowindexProdukty];
            int Produkty_ID = Convert.ToInt32(selectedRowProdukty.Cells["Produkty_ID"].Value);

            command.CommandText = "DELETE FROM Zamowienia WHERE Produkty_ID = @produkty; DELETE FROM Produkty WHERE Produkty_ID = @produkty";

            command.Parameters.AddWithValue("produkty", Produkty_ID);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            command.CommandText = "SELECT * FROM Produkty";

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewProdukty.DataSource = ds.Tables[0];

            command.CommandText = "SELECT Z.Zamowienia_ID, P.nazwa as Produkt, CONCAT(K.imie,' ', K.nazwisko) as Klient FROM Zamowienia as Z, Klienci as K, Produkty as P WHERE K.Klienci_ID = Z.Klienci_ID AND P.Produkty_ID = Z.Produkty_ID";

            SqlDataAdapter adapter2 = new SqlDataAdapter(command);

            DataSet ds2 = new DataSet();
            adapter.Fill(ds2);
            dataGridViewZamowienia.DataSource = ds2.Tables[0];

        }

        private void deleteKlienci_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            int selectedrowindexKlienci = dataGridViewKlienci.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowKlienci = dataGridViewKlienci.Rows[selectedrowindexKlienci];
            int Klienci_ID = Convert.ToInt32(selectedRowKlienci.Cells["Klienci_ID"].Value);

            command.CommandText = "DELETE FROM Zamowienia WHERE Klienci_ID = @klienci; DELETE FROM Klienci WHERE Klienci_ID = @klienci";

            command.Parameters.AddWithValue("klienci", Klienci_ID);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            command.CommandText = "SELECT * FROM Klienci";

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewKlienci.DataSource = ds.Tables[0];

            command.CommandText = "SELECT Z.Zamowienia_ID, P.nazwa as Produkt, CONCAT(K.imie,' ', K.nazwisko) as Klient FROM Zamowienia as Z, Klienci as K, Produkty as P WHERE K.Klienci_ID = Z.Klienci_ID AND P.Produkty_ID = Z.Produkty_ID";

            SqlDataAdapter adapter2 = new SqlDataAdapter(command);

            DataSet ds2 = new DataSet();
            adapter.Fill(ds2);
            dataGridViewZamowienia.DataSource = ds2.Tables[0];

        }

        private void buttonAddKlient_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Klienci VALUES(@imie, @nazwisko, @miasto)";

            command.Parameters.AddWithValue("imie", textBoxImie.Text);
            command.Parameters.AddWithValue("nazwisko", textBoxNazwisko.Text);
            command.Parameters.AddWithValue("miasto", textBoxMiasto.Text);


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            command.CommandText = "SELECT * FROM Klienci";

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridViewKlienci.DataSource = ds.Tables[0];

        }

        private void deleteZamowienia_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;

            int selectedrowindexZamowienia = dataGridViewZamowienia.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRowZamowienia = dataGridViewZamowienia.Rows[selectedrowindexZamowienia];
            int Zamowienia_ID = Convert.ToInt32(selectedRowZamowienia.Cells["Zamowienia_ID"].Value);

            command.CommandText = "DELETE FROM Zamowienia WHERE Zamowienia_ID = @zamowienia";

            command.Parameters.AddWithValue("zamowienia", Zamowienia_ID);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            
            command.CommandText = "SELECT Z.Zamowienia_ID, P.nazwa as Produkt, CONCAT(K.imie,' ', K.nazwisko) as Klient FROM Zamowienia as Z, Klienci as K, Produkty as P WHERE K.Klienci_ID = Z.Klienci_ID AND P.Produkty_ID = Z.Produkty_ID";

            SqlDataAdapter adapter2 = new SqlDataAdapter(command);

            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2);
            dataGridViewZamowienia.DataSource = ds2.Tables[0];

        }
    }
}
