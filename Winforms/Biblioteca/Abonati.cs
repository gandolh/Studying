using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Biblioteca
{
    public partial class Abonati : Form
    {
        public int usr_type;
        public Abonati()
        {
            InitializeComponent();
        }
        public void session_data(int usr_type_param)
        {
            usr_type = usr_type_param;
        }

        private void Search(object sender, EventArgs e)
        {
            int id,id_carti, cnp, nr_ci, numar_returnare,
                cota_penalizare, valoare_de_restituit;
            try { id = Int32.Parse(textBox1.Text); }
            catch (Exception) { id = -1; }
            try { id_carti = Int32.Parse(textBox2.Text);}
            catch (Exception){ id_carti = -1;}
            try{ cnp = Int32.Parse(textBox5.Text);}
            catch (Exception){ cnp = -1; }
            try { nr_ci = Int32.Parse(textBox8.Text); }
            catch (Exception) { nr_ci = -1; }
            try { numar_returnare = Int32.Parse(textBox12.Text); }
            catch (Exception) { numar_returnare = -1; }
            try { cota_penalizare = Int32.Parse(textBox14.Text); }
            catch (Exception) { cota_penalizare = -1; }
            try { valoare_de_restituit = Int32.Parse(textBox15.Text); }
            catch (Exception) { valoare_de_restituit = -1; }
            DateTime data_imprumut, data_returnare, termen_restituire;
            try { data_imprumut = Convert.ToDateTime(maskedTextBox1.Text); }
            catch (Exception) { data_imprumut = Convert.ToDateTime("01.01.2000"); }
            try { data_returnare = Convert.ToDateTime(maskedTextBox2.Text); }
            catch (Exception) { data_returnare = Convert.ToDateTime("01.01.2000"); }
            try { termen_restituire = Convert.ToDateTime(maskedTextBox3.Text); }
            catch (Exception) { termen_restituire = Convert.ToDateTime("01.01.2000"); }
            string nume = textBox3.Text;
            string prenume = textBox4.Text;
            string adresa = textBox6.Text;
            string serie_ci = textBox7.Text;
            string motiv = textBox13.Text;
            string querry = $"SELECT * FROM [dbo].[ABONATI] WHERE ";
            bool query_before = false;
            if (id != -1)
            {
                querry += $"id={id} "; query_before = true;
            }
            if (id_carti != -1)
            {
                if (query_before) querry += $"and id_carti='{id_carti}' ";
               else querry += $"id_carti='{id_carti}' ";
                query_before = true;
            }
            if (nume != "")
            {
                if (query_before) querry += $"and nume='{nume}' ";
                else querry += $"nume='{nume}' ";
                query_before = true;
            }
            if (prenume != "")
            {
                if (query_before) querry += $"and prenume='{prenume}' ";
                else querry += $"prenume='{prenume}' ";
                query_before = true;
            }
            if (cnp != -1)
            {
                if (query_before) querry += $"and cnp='{cnp}' ";
                else querry += $"cnp='{cnp}' ";
                query_before = true;
            }
            if (adresa != "")
            {
                if (query_before) querry += $"and adresa='{adresa}' ";
                else querry += $"adresa='{adresa}' ";
                query_before = true;
            }
            if (serie_ci != "")
            {
                if (query_before) querry += $"and serie_ci='{serie_ci}' ";
                else querry += $"serie_ci='{serie_ci}' ";
                query_before = true;
            }
            if (nr_ci != -1)
            {
                if (query_before) querry += $"and nr_ci='{nr_ci}' ";
                else querry += $"nr_ci='{nr_ci}' ";
                query_before = true;
            }
            if (data_imprumut != Convert.ToDateTime("01.01.2000"))
            {
                if (query_before) querry += $"and data_imprumut='{data_imprumut}' ";
                else querry += $"data_imprumut='{data_imprumut}' ";
                query_before = true;
            }
            if (data_returnare != Convert.ToDateTime("01.01.2000"))
            {
                if (query_before) querry += $"and data_returnare='{data_returnare}' ";
                else querry += $"data_returnare='{data_returnare}' ";
                query_before = true;
            }
            if (termen_restituire != Convert.ToDateTime("01.01.2000"))
            {
                if (query_before) querry += $"and termen_restituire='{termen_restituire}' ";
                else querry += $"termen_restituire='{termen_restituire}' ";
                query_before = true;
            }
            if (motiv != "")
            {
                if (query_before) querry += $"and motiv='{motiv}' ";
                else querry += $"motiv='{motiv}' ";
                query_before = true;
            }
            if (cota_penalizare != -1)
            {
                if (query_before) querry += $"and cota_penalizare='{cota_penalizare}' ";
                else querry += $"cota_penalizare='{cota_penalizare}' ";
                query_before = true;
            }
            if (valoare_de_restituit != -1)
            {
                if (query_before) querry += $"and valoare_de_restituit='{valoare_de_restituit}' ";
                else querry += $"valoare_de_restituit='{valoare_de_restituit}' ";
                query_before = true;
            }
            DataTable tabel = new DataTable();
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            sqda.SelectCommand = new SqlCommand(querry, con);
            sqda.Fill(tabel);
            this.Hide();
            Angajati_Search_result asr = new Angajati_Search_result();
            asr.populate_dataGridView(tabel);
            asr.session_data(usr_type, this);
            asr.Show();
        }

        private void Insert(object sender, EventArgs e)
        {
            int id, id_carti, cnp, nr_ci, numar_returnare,
                cota_penalizare, valoare_de_restituit;
            try { id = Int32.Parse(textBox1.Text); }
            catch (Exception) { id = -1; }
            try { id_carti = Int32.Parse(textBox2.Text); }
            catch (Exception) { id_carti = -1; }
            try { cnp = Int32.Parse(textBox5.Text); }
            catch (Exception) { cnp = -1; }
            try { nr_ci = Int32.Parse(textBox8.Text); }
            catch (Exception) { nr_ci = -1; }
            try { numar_returnare = Int32.Parse(textBox12.Text); }
            catch (Exception) { numar_returnare = -1; }
            try { cota_penalizare = Int32.Parse(textBox14.Text); }
            catch (Exception) { cota_penalizare = -1; }
            try { valoare_de_restituit = Int32.Parse(textBox15.Text); }
            catch (Exception) { valoare_de_restituit = -1; }
            DateTime data_imprumut, data_returnare, termen_restituire;
            try { data_imprumut = Convert.ToDateTime(maskedTextBox1.Text); }
            catch (Exception) { data_imprumut = Convert.ToDateTime("01.01.2000"); }
            try { data_returnare = Convert.ToDateTime(maskedTextBox2.Text); }
            catch (Exception) { data_returnare = Convert.ToDateTime("01.01.2000"); }
            try { termen_restituire = Convert.ToDateTime(maskedTextBox3.Text); }
            catch (Exception) { termen_restituire = Convert.ToDateTime("01.01.2000"); }
            string nume = textBox3.Text;
            string prenume = textBox4.Text;
            string adresa = textBox6.Text;
            string serie_ci = textBox7.Text;
            string motiv = textBox13.Text;


            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("" +
                $"insert into [dbo].[abonati] values({id_carti},'{nume}'," +
                $"'{prenume}',{cnp},'{adresa}','{serie_ci}',{nr_ci}," +
                $"'{data_imprumut}','{data_returnare}','{termen_restituire}'," +
                $"{numar_returnare},'{motiv}',{cota_penalizare}," +
                $"{valoare_de_restituit})", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close(); 
            MessageBox.Show("inserted!");

        }

        private void Delete(object sender, EventArgs e)
        {
            if (usr_type == 1)
            {
                int id, id_carti, cnp, nr_ci, numar_returnare,
    cota_penalizare, valoare_de_restituit;
                try { id = Int32.Parse(textBox1.Text); }
                catch (Exception) { id = -1; }
                try { id_carti = Int32.Parse(textBox2.Text); }
                catch (Exception) { id_carti = -1; }
                try { cnp = Int32.Parse(textBox5.Text); }
                catch (Exception) { cnp = -1; }
                try { nr_ci = Int32.Parse(textBox8.Text); }
                catch (Exception) { nr_ci = -1; }
                try { numar_returnare = Int32.Parse(textBox12.Text); }
                catch (Exception) { numar_returnare = -1; }
                try { cota_penalizare = Int32.Parse(textBox14.Text); }
                catch (Exception) { cota_penalizare = -1; }
                try { valoare_de_restituit = Int32.Parse(textBox15.Text); }
                catch (Exception) { valoare_de_restituit = -1; }
                DateTime data_imprumut, data_returnare, termen_restituire;
                try { data_imprumut = Convert.ToDateTime(maskedTextBox1.Text); }
                catch (Exception) { data_imprumut = Convert.ToDateTime("01.01.2000"); }
                try { data_returnare = Convert.ToDateTime(maskedTextBox2.Text); }
                catch (Exception) { data_returnare = Convert.ToDateTime("01.01.2000"); }
                try { termen_restituire = Convert.ToDateTime(maskedTextBox3.Text); }
                catch (Exception) { termen_restituire = Convert.ToDateTime("01.01.2000"); }
                string nume = textBox3.Text;
                string prenume = textBox4.Text;
                string adresa = textBox6.Text;
                string serie_ci = textBox7.Text;
                string motiv = textBox13.Text;
                string querry = $"DELETE FROM [dbo].[ABONATI] WHERE ";
                bool query_before = false;
                if (id != -1)
                {
                    querry += $"id={id} "; query_before = true;
                }
                if (id_carti != -1)
                {
                    if (query_before) querry += $"and id_carti='{id_carti}' ";
                    else querry += $"id_carti='{id_carti}' ";
                    query_before = true;
                }
                if (nume != "")
                {
                    if (query_before) querry += $"and nume='{nume}' ";
                    else querry += $"nume='{nume}' ";
                    query_before = true;
                }
                if (prenume != "")
                {
                    if (query_before) querry += $"and prenume='{prenume}' ";
                    else querry += $"prenume='{prenume}' ";
                    query_before = true;
                }
                if (cnp != -1)
                {
                    if (query_before) querry += $"and cnp='{cnp}' ";
                    else querry += $"cnp='{cnp}' ";
                    query_before = true;
                }
                if (adresa != "")
                {
                    if (query_before) querry += $"and adresa='{adresa}' ";
                    else querry += $"adresa='{adresa}' ";
                    query_before = true;
                }
                if (serie_ci != "")
                {
                    if (query_before) querry += $"and serie_ci='{serie_ci}' ";
                    else querry += $"serie_ci='{serie_ci}' ";
                    query_before = true;
                }
                if (nr_ci != -1)
                {
                    if (query_before) querry += $"and nr_ci='{nr_ci}' ";
                    else querry += $"nr_ci='{nr_ci}' ";
                    query_before = true;
                }
                if (data_imprumut != Convert.ToDateTime("01.01.2000"))
                {
                    if (query_before) querry += $"and data_imprumut='{data_imprumut}' ";
                    else querry += $"data_imprumut='{data_imprumut}' ";
                    query_before = true;
                }
                if (data_returnare != Convert.ToDateTime("01.01.2000"))
                {
                    if (query_before) querry += $"and data_returnare='{data_returnare}' ";
                    else querry += $"data_returnare='{data_returnare}' ";
                    query_before = true;
                }
                if (termen_restituire != Convert.ToDateTime("01.01.2000"))
                {
                    if (query_before) querry += $"and termen_restituire='{termen_restituire}' ";
                    else querry += $"termen_restituire='{termen_restituire}' ";
                    query_before = true;
                }
                if (motiv != "")
                {
                    if (query_before) querry += $"and motiv='{motiv}' ";
                    else querry += $"motiv='{motiv}' ";
                    query_before = true;
                }
                if (cota_penalizare != -1)
                {
                    if (query_before) querry += $"and cota_penalizare='{cota_penalizare}' ";
                    else querry += $"cota_penalizare='{cota_penalizare}' ";
                    query_before = true;
                }
                if (valoare_de_restituit != -1)
                {
                    if (query_before) querry += $"and valoare_de_restituit='{valoare_de_restituit}' ";
                    else querry += $"valoare_de_restituit='{valoare_de_restituit}' ";
                    query_before = true;
                }
                SqlConnection con = new SqlConnection(Globals.connectionString);
                SqlCommand cmd = new SqlCommand(querry, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Nu esti administrator!");

            }

        }

        private void Back_to_menu(object sender, EventArgs e)
        {
            this.Close();
            Biblioteca bi = new Biblioteca();
            bi.session_data(usr_type);
            bi.Show();
        }
        public void retrieve_data_from_angajati_search(
            string id,string id_carti,string nume,string prenume, string cnp, string adresa,
            string serie_ci, string nr_ci, string data_imprumut, string data_returnare,
            string Termen_restituire, string numar_returnate, string motiv,string cota_penalizare,
            string valoare_de_restituit
            )
        {
            textBox1.Text = id;
            textBox2.Text = id_carti;
            textBox3.Text = nume;
            textBox4.Text = prenume;
            textBox5.Text = cnp;
            textBox6.Text = adresa;
            textBox7.Text = serie_ci;
            textBox8.Text = nr_ci;
            maskedTextBox1.Text = data_imprumut;
            maskedTextBox2.Text = data_returnare;
            maskedTextBox3.Text = Termen_restituire;
            textBox12.Text = numar_returnate;
            textBox13.Text = motiv;
            textBox14.Text = cota_penalizare;
            textBox15.Text = valoare_de_restituit;
        }

    }
}
