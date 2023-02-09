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
    public partial class Angajati : Form
    {
        int usr_type;
        public Angajati()
        {
            InitializeComponent();
           
        }

        private void Back_to_menu(object sender, EventArgs e)
        {
            this.Close();
            Biblioteca bi = new Biblioteca();
            bi.session_data(usr_type);
            bi.Show();
        }

        private void Search(object sender, EventArgs e)
        {
            int id, marca, cnp;
            try { 
                id = Int32.Parse(textBox1.Text); 
            }
            catch (Exception) { 
                id = -1; 
            }
            try { 
                marca = Int32.Parse(textBox2.Text);
            }
            catch (Exception) {
                marca = -1; 
            }
            string nume = textBox3.Text;
            string prenume = textBox5.Text;
            try {
                cnp = Int32.Parse(textBox4.Text); 
            }
            catch (Exception) { 
                cnp = -1;
            }
            DataTable tabel = new DataTable();
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            string querry = $"SELECT * FROM [dbo].[ANGAJATI] WHERE ";
            bool query_before=false;
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

            sqda.SelectCommand = new SqlCommand( querry  , con);
            sqda.Fill(tabel);
            this.Hide();
            Angajati_Search_result asr = new Angajati_Search_result();
            asr.populate_dataGridView(tabel);
            asr.session_data(usr_type, this);
            asr.Show();
        }

        private void insert_into_db(object sender, EventArgs e)
        {
            int id, marca, cnp;
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
            try
            {
                cnp = Int32.Parse(textBox4.Text);
            }
            catch (Exception)
            {
                cnp = -1;
            }
            id = get_id();
            textBox1.Text = id.ToString();
            Label label1 = new Label()
            {
                Text = "Inserted Succesfully!",
                Location = new Point(250, 165),
                TabIndex = 10,
                ForeColor = Color.DarkGreen
        };
            groupBox1.Controls.Add(label1);
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("" +
                $"insert into [dbo].angajati values({id},{marca},'{nume}'," +
                $"'{prenume}',{cnp})", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

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
            return tabel.Rows.Count+1;
        }

        private void Delete(object sender, EventArgs e)
        {
            if (usr_type == 1)
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
                try
                {
                    cnp = Int32.Parse(textBox4.Text);
                }
                catch (Exception)
                {
                    cnp = -1;
                }
                SqlConnection con = new SqlConnection(Globals.connectionString);
                string querry = $"DELETE FROM [dbo].[ABONATI] WHERE ";
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
                SqlCommand cmd = new SqlCommand(querry,con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Label label1 = new Label()
                {
                    Text = "Deleted Succesfully!",
                    Location = new Point(250, 165),
                    TabIndex = 10,
                    ForeColor = Color.DarkRed
                };
                groupBox1.Controls.Add(label1);
            }
            else
            {
                MessageBox.Show("NU ESTI ADMINISTRATOR!");
            }
        }
        public void session_data(int usr_type_param)
        {
            usr_type = usr_type_param;
            //MessageBox.Show(usr_type.ToString());
        }
        public void retrieve_data_from_angajati_search(string id,string marca,string nume,string prenume,string cnp)
        {
            textBox1.Text = id;
            textBox2.Text = marca;
            textBox3.Text = nume;
            textBox4.Text = cnp;
            textBox5.Text = prenume;
        }
    }
}
