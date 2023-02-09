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
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            string parola = textBox2.Text;
            DataTable tabel = new DataTable();
            SqlConnection con = new SqlConnection(Globals.connectionString);
                SqlDataAdapter sqda = new SqlDataAdapter();
            sqda.SelectCommand = new SqlCommand(
                "select * from usr where nume_utilizator=" + "'" + nume + "'" + "and parola='" + parola + "'", con);
            sqda.Fill(tabel);
            if (tabel.Rows.Count > 0) 
            {
                this.Hide();
                Biblioteca bi = new Biblioteca();
                 bi.session_data(Int32.Parse(tabel.Rows[0][2].ToString()));
                 bi.Show();
            }
            else
            {
                MessageBox.Show("Nu");
            }
        }

    }
}
