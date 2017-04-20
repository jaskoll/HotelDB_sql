using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace bd2
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            show_hotel();
            wyswietlusluge();
        }

        void connectToDB()
        {

            string server = "localhost";
            string database = "bd1";
            string port = "3306";
            string uid = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";";

            connection = new MySqlConnection(connectionString);


        }
        bool OpenConnection()
        {


            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        bool CloseConnection()
        {

            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        void add_client(string n, string s, string t, string em, string nr)
        {
            connectToDB();

            if (t.Length != 9 || nr.Length != 9)
            {
                System.Windows.Forms.MessageBox.Show("Wprowadz poprawna ilosc znakow!");

            }

            else
            {
                string query = "INSERT INTO Klient (imie, nazwisko, telefon, email, nr_dowodu) VALUES('" + n + "', '" + s + "', '" + t + "', '" + em + "', '" + nr + "');";

                //open connection
                if (OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();

                }
            }


        }

        class Hotel
        {
            public string nazwa;
            public string rodzaj;
            public string rodzaj1;
            public string usluga1;
            public Hotel()
            {

            }

        }
        void wyswietlusluge()
        {
            connectToDB();
            string query = "SELECT nazwa FROM uslugi";
            //open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<string> myList1 = new List<string>();

                while (dataReader.Read())
                {
                    Hotel hotel3 = new Hotel();
                    int ord = dataReader.GetOrdinal("nazwa");
                    hotel3.usluga1 = dataReader.GetString(ord);

                    myList1.Add(hotel3.usluga1);






                }
                usluga.DataSource = myList1;
                dataReader.Close();

                //close Connection
                CloseConnection();


            }

        }

        void wybierzrodzaj(string selected)
        {
            connectToDB();
            string query = "SELECT DISTINCT pokoj.idPokoj_rodzaj FROM pokoj JOIN hotel ON pokoj.idHotel = hotel.idHotel WHERE hotel.nazwa= " + "'" + selected + "';";
            //open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<string> myList1 = new List<string>();

                while (dataReader.Read())
                {
                    Hotel hotel3 = new Hotel();
                    int ord = dataReader.GetOrdinal("idPokoj_rodzaj");
                    hotel3.rodzaj1 = dataReader.GetString(ord);

                    myList1.Add(hotel3.rodzaj1);






                }
                pokoj_rodzaj1.DataSource = myList1;
                dataReader.Close();

                //close Connection
                CloseConnection();


            }

        }

        void wybierzpokoj(string selected, string selected1)
        {




            connectToDB();
            string query = "SELECT pokoj.idPokoj FROM pokoj INNER JOIN pokoj_rodzaj ON pokoj_rodzaj.idPokoj_rodzaj = pokoj.idPokoj_rodzaj INNER JOIN hotel ON hotel.idHotel=pokoj.idHotel WHERE hotel.nazwa= " + "'"+ selected + "'" + " AND pokoj.idPokoj_rodzaj= " + "'" + selected1 + "';";
            //open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<string> myList1 = new List<string>();

                while (dataReader.Read())
                {
                    Hotel hotel2 = new Hotel();
                    int ord = dataReader.GetOrdinal("idPokoj");
                    hotel2.rodzaj = dataReader.GetString(ord);

                    myList1.Add(hotel2.rodzaj);






                }
                pokoj_rodzaj.DataSource = myList1;
                dataReader.Close();

                //close Connection
                CloseConnection();


            }



        }


        void show_hotel()
        {
            
            connectToDB();

          
            string query = "SELECT nazwa FROM hotel";
                //open connection
                if (OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                List<string> myList = new List<string>();

                while (dataReader.Read())
                    {
                    Hotel hotel1 = new Hotel();
                        int ord = dataReader.GetOrdinal("nazwa");
                        hotel1.nazwa = dataReader.GetString(ord);

                        myList.Add(hotel1.nazwa);






                }
                hotel.DataSource = myList;
                dataReader.Close();
                
                //close Connection
                CloseConnection();


            }



        }


      

        private void imie_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void dowod_TextChanged(object sender, EventArgs e)
        {

        }

        private void nazwisko_TextChanged(object sender, EventArgs e)
        {

        }

        private void dodaj_klienta_Click(object sender, EventArgs e)
        {
            string n = imie.Text;
            string s = nazwisko.Text;
            string t = telefon.Text;
            string em = email.Text;
            string nr = dowod.Text;
            add_client(n, s, t, em, nr);
        }


        private void hotel_SelectedIndexChanged(object sender, EventArgs e)
        {



            string selected = hotel.GetItemText(hotel.SelectedItem);

            wybierzrodzaj(selected);
            
        }

        private void pokoj_rodzaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pokoj_rodzaj1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = hotel.GetItemText(hotel.SelectedItem);
            string selected1 = pokoj_rodzaj1.GetItemText(pokoj_rodzaj1.SelectedItem);
            wybierzpokoj(selected, selected1);
        }

        private void usluga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datap_TextChanged(object sender, EventArgs e)
        {

        }

        private void datao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
