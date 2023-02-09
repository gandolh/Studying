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
    public partial class nom_retineri : Form
    {
        int usr_type;
        public nom_retineri()
        {
            InitializeComponent();
        }

        private void Search(object sender, EventArgs e)
        {
            int id,procent;
            string cod_retinere, denumire;
            try { id = Int32.Parse(textBox1.Text); }
            catch (Exception) { id = -1; }
            try { procent = Int32.Parse(textBox4.Text); }
            catch (Exception) { procent = -1; }
            cod_retinere = textBox2.Text;
            denumire = textBox3.Text;

            string querry = $"SELECT * FROM [dbo].[NOMRETINERI] WHERE ";
            bool query_before = false;
            if (id != -1)
            {
                querry += $"id={id} "; query_before = true;
            }
            if (cod_retinere != "")
            {
                if (query_before) querry += $"and cod_retinere='{cod_retinere}' ";
                else querry += $"cod_retinere='{cod_retinere}' ";
                query_before = true;
            }
            if (denumire != "")
            {
                if (query_before) querry += $"and denumire='{denumire}' ";
                else querry += $"denumire='{denumire}' ";
                query_before = true;
            }
            if (procent !=-1)
            {
                if (query_before) querry += $"and procent='{procent}' ";
                else querry += $"procent='{procent}' ";
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
            int id, procent;
            string cod_retinere, denumire;
            try { id = Int32.Parse(textBox1.Text); }
            catch (Exception) { id = -1; }
            try { procent = Int32.Parse(textBox4.Text); }
            catch (Exception) { procent = -1; }
            cod_retinere = textBox2.Text;
            denumire = textBox3.Text;
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("" +
                $"insert into [dbo].[NOMRETINERI] values('{cod_retinere}','{denumire}',{procent})", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted!");
        }

        private void Delete(object sender, EventArgs e)
        {
            if (usr_type == 1)
            {
                int id, procent;
                string cod_retinere, denumire;
                try { id = Int32.Parse(textBox1.Text); }
                catch (Exception) { id = -1; }
                try { procent = Int32.Parse(textBox4.Text); }
                catch (Exception) { procent = -1; }
                cod_retinere = textBox2.Text;
                denumire = textBox3.Text;

                string querry = $"DELETE FROM [dbo].[NOMRETINERI] WHERE ";
                bool query_before = false;
                if (id != -1)
                {
                    querry += $"id={id} "; query_before = true;
                }
                if (cod_retinere != "")
                {
                    if (query_before) querry += $"and cod_retinere='{cod_retinere}' ";
                    else querry += $"cod_retinere='{cod_retinere}' ";
                    query_before = true;
                }
                if (denumire != "")
                {
                    if (query_before) querry += $"and denumire='{denumire}' ";
                    else querry += $"denumire='{denumire}' ";
                    query_before = true;
                }
                if (procent != -1)
                {
                    if (query_before) querry += $"and procent='{procent}' ";
                    else querry += $"procent='{procent}' ";
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
        public void session_data(int usr_type_param)
        {
            usr_type = usr_type_param;
        }
        public void retrieve_data_from_angajati_search(
        string id,string cod_retinere,string denumire,string procent)
        {
            textBox1.Text = id;
            textBox2.Text = cod_retinere;
            textBox3.Text = denumire;
            textBox4.Text = procent;
        }
    }
}
