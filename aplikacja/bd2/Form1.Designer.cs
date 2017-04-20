namespace bd2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
        {
            this.imie = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.dowod = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.dodaj_klienta = new System.Windows.Forms.Button();
            this.hotel = new System.Windows.Forms.ComboBox();
            this.pokoj_rodzaj = new System.Windows.Forms.ComboBox();
            this.pokoj_rodzaj1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.usluga = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datap = new System.Windows.Forms.TextBox();
            this.datao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.posilek = new System.Windows.Forms.ComboBox();
            this.produkt = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.zamowienie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(80, 12);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(163, 20);
            this.imie.TabIndex = 0;
            this.imie.TextChanged += new System.EventHandler(this.imie_TextChanged);
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(80, 64);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(163, 20);
            this.telefon.TabIndex = 2;
            this.telefon.TextChanged += new System.EventHandler(this.telefon_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(80, 90);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(163, 20);
            this.email.TabIndex = 3;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // dowod
            // 
            this.dowod.Location = new System.Drawing.Point(80, 116);
            this.dowod.Name = "dowod";
            this.dowod.Size = new System.Drawing.Size(163, 20);
            this.dowod.TabIndex = 4;
            this.dowod.TextChanged += new System.EventHandler(this.dowod_TextChanged);
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(80, 37);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(163, 20);
            this.nazwisko.TabIndex = 5;
            this.nazwisko.TextChanged += new System.EventHandler(this.nazwisko_TextChanged);
            // 
            // dodaj_klienta
            // 
            this.dodaj_klienta.Location = new System.Drawing.Point(261, 12);
            this.dodaj_klienta.Name = "dodaj_klienta";
            this.dodaj_klienta.Size = new System.Drawing.Size(189, 124);
            this.dodaj_klienta.TabIndex = 6;
            this.dodaj_klienta.Text = "Dodaj klienta";
            this.dodaj_klienta.UseVisualStyleBackColor = true;
            this.dodaj_klienta.Click += new System.EventHandler(this.dodaj_klienta_Click);
            // 
            // hotel
            // 
            this.hotel.FormattingEnabled = true;
            this.hotel.Location = new System.Drawing.Point(619, 12);
            this.hotel.Name = "hotel";
            this.hotel.Size = new System.Drawing.Size(248, 21);
            this.hotel.TabIndex = 7;
            this.hotel.SelectedIndexChanged += new System.EventHandler(this.hotel_SelectedIndexChanged);
            // 
            // pokoj_rodzaj
            // 
            this.pokoj_rodzaj.FormattingEnabled = true;
            this.pokoj_rodzaj.Location = new System.Drawing.Point(619, 65);
            this.pokoj_rodzaj.Name = "pokoj_rodzaj";
            this.pokoj_rodzaj.Size = new System.Drawing.Size(248, 21);
            this.pokoj_rodzaj.TabIndex = 8;
            this.pokoj_rodzaj.SelectedIndexChanged += new System.EventHandler(this.pokoj_rodzaj_SelectedIndexChanged);
            // 
            // pokoj_rodzaj1
            // 
            this.pokoj_rodzaj1.FormattingEnabled = true;
            this.pokoj_rodzaj1.Location = new System.Drawing.Point(619, 38);
            this.pokoj_rodzaj1.Name = "pokoj_rodzaj1";
            this.pokoj_rodzaj1.Size = new System.Drawing.Size(248, 21);
            this.pokoj_rodzaj1.TabIndex = 9;
            this.pokoj_rodzaj1.SelectedIndexChanged += new System.EventHandler(this.pokoj_rodzaj1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "nazwisko: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "email: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "nr dowodu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "hotel: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "rodzaj pokoju: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "nr pokoju:";
            // 
            // usluga
            // 
            this.usluga.FormattingEnabled = true;
            this.usluga.Location = new System.Drawing.Point(619, 97);
            this.usluga.Name = "usluga";
            this.usluga.Size = new System.Drawing.Size(248, 21);
            this.usluga.TabIndex = 18;
            this.usluga.SelectedIndexChanged += new System.EventHandler(this.usluga_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "usługa: ";
            // 
            // datap
            // 
            this.datap.Location = new System.Drawing.Point(619, 124);
            this.datap.Name = "datap";
            this.datap.Size = new System.Drawing.Size(248, 20);
            this.datap.TabIndex = 20;
            this.datap.TextChanged += new System.EventHandler(this.datap_TextChanged);
            // 
            // datao
            // 
            this.datao.Location = new System.Drawing.Point(619, 150);
            this.datao.Name = "datao";
            this.datao.Size = new System.Drawing.Size(248, 20);
            this.datao.TabIndex = 21;
            this.datao.TextChanged += new System.EventHandler(this.datao_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "data przyjazdu:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(530, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "data odjazdu:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 111);
            this.button1.TabIndex = 24;
            this.button1.Text = "Dodaj rezerwację";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // posilek
            // 
            this.posilek.FormattingEnabled = true;
            this.posilek.Location = new System.Drawing.Point(619, 176);
            this.posilek.Name = "posilek";
            this.posilek.Size = new System.Drawing.Size(248, 21);
            this.posilek.TabIndex = 25;
            this.posilek.SelectedIndexChanged += new System.EventHandler(this.posilek_SelectedIndexChanged);
            // 
            // produkt
            // 
            this.produkt.FormattingEnabled = true;
            this.produkt.Location = new System.Drawing.Point(619, 203);
            this.produkt.Name = "produkt";
            this.produkt.Size = new System.Drawing.Size(248, 21);
            this.produkt.TabIndex = 26;
            this.produkt.SelectedIndexChanged += new System.EventHandler(this.produkt_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(530, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "posiłek:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(530, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "rodzaj:";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(15, 183);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(509, 251);
            this.lista.TabIndex = 29;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // zamowienie
            // 
            this.zamowienie.Location = new System.Drawing.Point(15, 440);
            this.zamowienie.Name = "zamowienie";
            this.zamowienie.Size = new System.Drawing.Size(509, 20);
            this.zamowienie.TabIndex = 30;
            this.zamowienie.TextChanged += new System.EventHandler(this.zamowienie_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 471);
            this.Controls.Add(this.zamowienie);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.produkt);
            this.Controls.Add(this.posilek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.datao);
            this.Controls.Add(this.datap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.usluga);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pokoj_rodzaj1);
            this.Controls.Add(this.pokoj_rodzaj);
            this.Controls.Add(this.hotel);
            this.Controls.Add(this.dodaj_klienta);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.dowod);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.imie);
            this.Name = "Form1";
            this.Text = "Program pracowniczy do obsługi rezerwacji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox dowod;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.Button dodaj_klienta;
        private System.Windows.Forms.ComboBox hotel;
        private System.Windows.Forms.ComboBox pokoj_rodzaj;
        private System.Windows.Forms.ComboBox pokoj_rodzaj1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox usluga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox datap;
        private System.Windows.Forms.TextBox datao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox posilek;
        private System.Windows.Forms.ComboBox produkt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox zamowienie;
    }
}

