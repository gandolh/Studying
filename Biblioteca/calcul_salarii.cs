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
    public partial class calcul_salarii : Form
    {
        int usr_type;
        public calcul_salarii()
        {
            InitializeComponent();
        }
        public void session_data(int usr_type_param)
        {
            usr_type = usr_type_param;
        }

        private void incarcare(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"select max(luna),max(anul)" +
               "from salarizare", Globals.con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int luna = Int32.Parse(dt.Rows[0][0].ToString());
            int anul = Int32.Parse(dt.Rows[0][1].ToString());
            DataTable tabel = new DataTable();
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            sqda.SelectCommand = new SqlCommand(
               "select id from salarizare where " +
               $"luna={luna} and anul={anul}", con);
            sqda.Fill(tabel);
            int numar_salarizare = tabel.Rows.Count;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = numar_salarizare-1;
            SqlCommand cmd2 = new SqlCommand("calculSalarii",con);
            cmd2.CommandType = CommandType.StoredProcedure;
  
            for(int i=0;i< numar_salarizare; i++)
            {
                progressBar1.Value = i;
                cmd2.Parameters.Add(
                    new SqlParameter("@id_salarizare",tabel.Rows[i][0])
                    );
                int foo = int.Parse( tabel.Rows[i][0].ToString());
                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();
                cmd2.Parameters.Clear();
               
            }
            MessageBox.Show("Salariile s-au calculat");
            Biblioteca bi = new Biblioteca();
            bi.Show();
            bi.session_data(usr_type);
            this.Close();
        }
    }
}
