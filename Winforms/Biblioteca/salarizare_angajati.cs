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
    public partial class salarizare_angajati : Form
    {
        int usr_type;
        Form prev_window;
        public salarizare_angajati()
        {
            InitializeComponent();
        }

        private void Confirm(object sender, EventArgs e)
        {
            if( prev_window is salarizare)
            ((salarizare)prev_window).receive_data(textBox1.Text,
                textBox6.Text,
                textBox7.Text);
            else if(prev_window is Pontaj)
                ((Pontaj)prev_window).receive_id(textBox1.Text);
            this.Close();
            prev_window.Show();

        }
        private void Search(object sender, EventArgs e)
        {
            int id, marca, cnp;
            try
            {
                id = Int32.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                id = -1;
            }
            try
            {
                marca = Int32.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                marca = -1;
            }
            string nume = textBox3.Text;
            string prenume = textBox5.Text;
            string locMunca = textBox6.Text;
            string Functia = textBox7.Text;
            try
            {
                cnp = Int32.Parse(textBox4.Text);
            }
            catch (Exception)
            {
                cnp = -1;
            }
            DataTable tabel = new DataTable();
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            string querry = $"SELECT * FROM [dbo].[ANGAJATI] WHERE ";
            bool query_before = false;
            if (id != -1)
            {
                querry += $"id={id} "; query_before = true;
            }
            if (marca != -1)
            {
                if (query_before) querry += $"and marca='{marca}' ";
                else querry += $"marca='{marca}' ";
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
            if (locMunca != "")
            {
                if (query_before) querry += $"and locMunca='{locMunca}' ";
                else querry += $"locMunca='{locMunca}' ";
                query_before = true;
            }
            if (Functia != "")
            {
                if (query_before) querry += $"and Functia='{Functia}' ";
                else querry += $"Functia='{Functia}' ";
                query_before = true;
            }
            sqda.SelectCommand = new SqlCommand(querry, con);
            sqda.Fill(tabel);
            this.Hide();
            Angajati_Search_result asr = new Angajati_Search_result();
            asr.populate_dataGridView(tabel);
            asr.session_data(usr_type,this);
            asr.Show();
        }
        private int get_id()
        {
            DataTable tabel = new DataTable();
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            sqda.SelectCommand = new SqlCommand(
                $"SELECT * FROM [dbo].[ANGAJATI]"
                , con);
            sqda.Fill(tabel);
            return tabel.Rows.Count + 1;
        }
          public void session_data(int usr_type_param, Form prev_window_param)
        {
            usr_type = usr_type_param;
            prev_window = prev_window_param;
            //MessageBox.Show(usr_type.ToString());
        }
        public void retrieve_data_from_angajati_search(
            string id,string marca,string nume,string prenume,string cnp,
        string locMunca, string Functia)
        {
            textBox1.Text = id;
            textBox2.Text = marca;
            textBox3.Text = nume;
            textBox4.Text = cnp;
            textBox5.Text = prenume;
            textBox6.Text = locMunca;
            textBox7.Text = Functia;
        }
    }
}
