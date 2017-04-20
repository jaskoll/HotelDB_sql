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
        string a;
        int c;
        MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            show_hotel();
            wyswietlusluge();
            wybierz_produkt();
        }

        void connectToDB()
        {

            string server = "localhost";
            string database = "bd";
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
                try {
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
                catch (MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show("Duplikujacy sie nr_dowodu!");
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
        class Rezerwacja
        {
            public string idKlient;
            public string idHotel;
            public string idPokoj;
            public string data_przyjazdu;
            public string data_odjazdu;
            public string rachunek;
            public Rezerwacja()
            {

            }

        }
        void wybierzposilek(string selected, string selected1)
        {



        }

        void wybierzprodukt(string selected)
        {



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
            string query = "SELECT pokoj.idPokoj FROM pokoj INNER JOIN pokoj_rodzaj ON pokoj_rodzaj.idPokoj_rodzaj = pokoj.idPokoj_rodzaj INNER JOIN hotel ON hotel.idHotel=pokoj.idHotel WHERE hotel.nazwa= " + "'" + selected + "'" + " AND pokoj.idPokoj_rodzaj= " + "'" + selected1 + "';";
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
        void wybierz_posilek(string selected)
        {
            connectToDB();
            string query = "SELECT posilek.Typ FROM posilek INNER JOIN produkt ON posilek.idProdukt = produkt.idProdukt WHERE produkt.nazwa= " + "'" + selected + "';";
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
                    int ord = dataReader.GetOrdinal("Typ");
                    hotel3.rodzaj1 = dataReader.GetString(ord);

                    myList1.Add(hotel3.rodzaj1);






                }
                produkt.DataSource = myList1;
                dataReader.Close();

                //close Connection
                CloseConnection();


            }



        }
        void wybierz_produkt()
        {
            connectToDB();
            string query = "SELECT nazwa FROM produkt";
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
                    hotel3.rodzaj1 = dataReader.GetString(ord);

                    myList1.Add(hotel3.rodzaj1);






                }
                posilek.DataSource = myList1;
                dataReader.Close();

                //close Connection
                CloseConnection();


            }

        }
        void dodaj_rezerwacje(string idu, string idp, string idpos, string idkl, string idho, string datap, string datao)
        {

            connectToDB();
            try
            {



                string query = "INSERT INTO rezerwacja (idUslugi, idPokoj, idPosilek, idKlient, idHotel, data_przyjazdu, data_odjazdu) VALUES('" + idu + "', '" + idp + "', '" + idpos + "', '" + idkl + "', '" + idho + "', '" + datap + "', '" + datao + "');";

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
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Pokoj zajety!");
            }


        }

        string pobierzidklienta()
        {

            connectToDB();
            string selected = dowod.Text;
            string query = "SELECT idKlient FROM klient WHERE nr_dowodu= " + "'" + selected + "';";
            //open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {

                    int ord = dataReader.GetOrdinal("idKlient");
                    a = dataReader.GetString(ord);








                }

                dataReader.Close();

                //close Connection
                CloseConnection();


            }
            return a;
        }

        string pobierziduslugi()
        {

            connectToDB();
            string selected = usluga.Text;
            string query = "SELECT idUslugi FROM uslugi WHERE nazwa= " + "'" + selected + "';";
            //open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {

                    int ord = dataReader.GetOrdinal("idUslugi");
                    a = dataReader.GetString(ord);








                }

                dataReader.Close();

                //close Connection
                CloseConnection();


            }
            return a;
        }

        string pobierzidposilku()
        {

            connectToDB();
            string selected = posilek.Text;
            string query = "SELECT posilek.idPosilek FROM posilek INNER JOIN produkt ON produkt.idProdukt = produkt.idProdukt WHERE produkt.nazwa= " + "'" + selected + "';";
            //open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {

                    int ord = dataReader.GetOrdinal("idPosilek");
                    a = dataReader.GetString(ord);








                }

                dataReader.Close();

                //close Connection
                CloseConnection();


            }
            return a;
        }

        string pobierzidhotelu()
        {

            connectToDB();
            string selected = hotel.Text;
            string query = "SELECT hotel.idHotel FROM hotel WHERE hotel.nazwa= " + "'" + selected + "';";
            //open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {

                    int ord = dataReader.GetOrdinal("idHotel");
                    a = dataReader.GetString(ord);








                }

                dataReader.Close();

                //close Connection
                CloseConnection();


            }
            return a;
        }
        


        void szukaj_zamowienia(string nr)
        {

            
            connectToDB();
          
            string query1 = "SELECT DAY(rezerwacja.data_odjazdu)-DAY(rezerwacja.data_przyjazdu ) FROM rezerwacja WHERE rezerwacja.idRezerwacja = "+ "'" + nr +"';";
            string query = "SELECT DISTINCT rezerwacja.idKlient, rezerwacja.idHotel, rezerwacja.idPokoj, rezerwacja.data_przyjazdu, rezerwacja.data_odjazdu, pokoj.cena, uslugi.cena, produkt.cena FROM rezerwacja INNER JOIN pokoj ON pokoj.idPokoj = rezerwacja.idPokoj INNER JOIN uslugi ON uslugi.idUslugi = rezerwacja.idUslugi INNER JOIN posilek ON posilek.idPosilek = rezerwacja.idPosilek INNER JOIN produkt ON produkt.idProdukt = posilek.idProdukt WHERE rezerwacja.idRezerwacja= " + "'" + nr + "';";
            //open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query1, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<string> myList = new List<string>();
                Rezerwacja rez = new Rezerwacja();
                while (dataReader.Read())
                {
                    c = dataReader.GetInt32(0);


                }
                
                    dataReader.Close();
            }
            CloseConnection();



            connectToDB();
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<string> myList = new List<string>();
                Rezerwacja rez = new Rezerwacja();


                while (dataReader.Read())
                {


                    rez.idKlient = dataReader.GetString(0);
                    myList.Add("id_Klient: " + rez.idKlient);

                    rez.idHotel = dataReader.GetString(1);
                    myList.Add("id_Hotel: " + rez.idHotel);

                    rez.idPokoj = dataReader.GetString(2);
                    myList.Add("id_Pokoj: " + rez.idPokoj);

                    rez.data_przyjazdu = dataReader.GetString(3);
                    myList.Add("data_przyjazdu: " + rez.data_przyjazdu);

                    rez.data_odjazdu = dataReader.GetString(4);
                    myList.Add("data_odjazdu: " + rez.data_odjazdu);

                    int cena = dataReader.GetInt32(5);
                    int us = dataReader.GetInt32(6);
                    int pos = dataReader.GetInt32(7);

                    TimeSpan d = dataReader.GetDateTime(4) - dataReader.GetDateTime(3);

                    int suma = (int)d.TotalDays * cena + us + pos;

                    myList.Add("Rachunek: " + suma.ToString() + " PLN");







                }
               lista.DataSource = myList;
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

        void usluga_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void datap_TextChanged(object sender, EventArgs e)
        {

        }

        private void datao_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idu = pobierziduslugi(); ;
            string idp = pokoj_rodzaj.Text;
            string idpos = pobierzidposilku();
            string idkl = pobierzidklienta();
            string idho = pobierzidhotelu();
            string datapr = datap.Text;
            string dataod = datao.Text;

            
            dodaj_rezerwacje(idu, idp, idpos, idkl, idho, datapr, dataod);
            
        }

        private void produkt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void posilek_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = posilek.GetItemText(posilek.SelectedItem);

            wybierz_posilek(selected);
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void zamowienie_TextChanged(object sender, EventArgs e)
        {
            string nr = zamowienie.Text;
            szukaj_zamowienia(nr);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
