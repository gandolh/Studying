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
    public partial class Carti : Form
    {
        int usr_type;
        public Carti()
        {
            InitializeComponent();
        }
        public void session_data(int usr_type_param)
        {
            usr_type = usr_type_param;
        }

        private void Search(object sender, EventArgs e)
        {
            string titlu = textBox2.Text;
            string autor= textBox3.Text;
            DateTime data_publicare;
            try { data_publicare = Convert.ToDateTime(maskedTextBox1.Text); }
            catch (Exception) { data_publicare = Convert.ToDateTime("01.01.2000"); }
            int id,nr_exemplare, pret, stare;
            try { nr_exemplare = Int32.Parse(textBox5.Text); }
            catch (Exception) { nr_exemplare = -1; }
            try { pret = Int32.Parse(textBox6.Text); }
            catch (Exception) { pret = -1; }
            try { stare = Int32.Parse(textBox7.Text); }
            catch (Exception) { stare = -1; }
            try { id = Int32.Parse(textBox1.Text); }
            catch (Exception) { id = -1; }

            string querry = $"SELECT * FROM [dbo].[carti] WHERE ";
            bool query_before = false;
            if (id != -1)
            {
                querry += $"id={id} "; query_before = true;
            }
            if (titlu != "")
            {
                if (query_before) querry += $"and titlu='{titlu}' ";
                else querry += $"titlu='{titlu}' ";
                query_before = true;
            }
            if (autor != "")
            {
                if (query_before) querry += $"and autor='{autor}' ";
                else querry += $"autor='{autor}' ";
                query_before = true;
            }
            if (data_publicare != Convert.ToDateTime("01.01.2000"))
            {
                if (query_before) querry += $"and data_publicare='{data_publicare}' ";
                else querry += $"data_publicare='{data_publicare}' ";
                query_before = true;
            }
            if (nr_exemplare != -1)
            {
                if (query_before) querry += $"and nr_exemplare='{nr_exemplare}' ";
                else querry += $"nr_exemplare='{nr_exemplare}' ";
                query_before = true;
            }
            if (pret != -1)
            {
                if (query_before) querry += $"and pret='{pret}' ";
                else querry += $"pret='{pret}' ";
                query_before = true;
            }
            if (stare != -1)
            {
                if (query_before) querry += $"and stare='{stare}' ";
                else querry += $"stare='{stare}' ";
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
            string titlu = textBox2.Text;
            string autor = textBox3.Text;
            DateTime data_publicare;
            try { data_publicare = Convert.ToDateTime(maskedTextBox1.Text); }
            catch (Exception) { data_publicare = Convert.ToDateTime("01.01.2000"); }
            int id, nr_exemplare, pret, stare;
            try { nr_exemplare = Int32.Parse(textBox5.Text); }
            catch (Exception) { nr_exemplare = -1; }
            try { pret = Int32.Parse(textBox6.Text); }
            catch (Exception) { pret = -1; }
            try { stare = Int32.Parse(textBox7.Text); }
            catch (Exception) { stare = -1; }
            try { id = Int32.Parse(textBox1.Text); }
            catch (Exception) { id = -1; }
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("" +
                $"insert into [dbo].[carti] values('{titlu}','{autor}'," +
                $"'{data_publicare}',{nr_exemplare},{pret},{stare})", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted!");
        }

        private void Delete(object sender, EventArgs e)
        {
            if (usr_type == 1)
            {
                string titlu = textBox2.Text;
                string autor = textBox3.Text;
                DateTime data_publicare;
                try { data_publicare = Convert.ToDateTime(maskedTextBox1.Text); }
                catch (Exception) { data_publicare = Convert.ToDateTime("01.01.2000"); }
                int id, nr_exemplare, pret, stare;
                try { nr_exemplare = Int32.Parse(textBox5.Text); }
                catch (Exception) { nr_exemplare = -1; }
                try { pret = Int32.Parse(textBox6.Text); }
                catch (Exception) { pret = -1; }
                try { stare = Int32.Parse(textBox7.Text); }
                catch (Exception) { stare = -1; }
                try { id = Int32.Parse(textBox1.Text); }
                catch (Exception) { id = -1; }

                string querry = $"DELETE FROM [dbo].[carti] WHERE ";
                bool query_before = false;
                if (id != -1)
                {
                    querry += $"id={id} "; query_before = true;
                }
                if (titlu != "")
                {
                    if (query_before) querry += $"and titlu='{titlu}' ";
                    else querry += $"titlu='{titlu}' ";
                    query_before = true;
                }
                if (autor != "")
                {
                    if (query_before) querry += $"and autor='{autor}' ";
                    else querry += $"autor='{autor}' ";
                    query_before = true;
                }
                if (data_publicare != Convert.ToDateTime("01.01.2000"))
                {
                    if (query_before) querry += $"and data_publicare='{data_publicare}' ";
                    else querry += $"data_publicare='{data_publicare}' ";
                    query_before = true;
                }
                if (nr_exemplare != -1)
                {
                    if (query_before) querry += $"and nr_exemplare='{nr_exemplare}' ";
                    else querry += $"nr_exemplare='{nr_exemplare}' ";
                    query_before = true;
                }
                if (pret != -1)
                {
                    if (query_before) querry += $"and pret='{pret}' ";
                    else querry += $"pret='{pret}' ";
                    query_before = true;
                }
                if (stare != -1)
                {
                    if (query_before) querry += $"and stare='{stare}' ";
                    else querry += $"stare='{stare}' ";
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

        private void Back_To_menu(object sender, EventArgs e)
        {
            this.Close();
            Biblioteca bi = new Biblioteca();
            bi.session_data(usr_type);
            bi.Show();
        }
        public void retrieve_data_from_angajati_search(
            string id,
            string titlu,string autor,string data_publicare,string nr_exemplare,
            string pret,string stare)
        {
            textBox1.Text = id;
            textBox2.Text = titlu;
            textBox3.Text = autor;
            maskedTextBox1.Text = data_publicare;
            textBox5.Text = nr_exemplare;
            textBox6.Text = pret;
            textBox7.Text = stare;
        }
    }
}
