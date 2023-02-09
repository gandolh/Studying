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
    public partial class Pontaj : Form
    {
        int usr_type;
        public Pontaj()
        {
            InitializeComponent();
        }

        private void search_angajat_Click(object sender, EventArgs e)
        {

             this.Hide();
             salarizare_angajati sal = new salarizare_angajati();
            sal.session_data(usr_type, this);
            sal.Show(); 

        }
        public void session_data(int usr_type_param)
        {
            usr_type = usr_type_param;
            //MessageBox.Show(usr_type.ToString());
        }
        public void receive_id(string id)
        {
            //MessageBox.Show(id);
            int integer_id = Int32.Parse(id);
            string querry = $"select max(id) from salarizare" +
                $" where id_angajat={id}";
            SqlCommand cmd = new SqlCommand(querry, Globals.con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            maskedTextBox2.Text = dt.Rows[0][0].ToString(); //id salarizare
        }

        private void Pontaj_Load(object sender, EventArgs e)
        {
            textBox1.Text = "01";
            maskedTextBox1.Text = "01";
            SqlCommand cmd = new SqlCommand($"select max(luna),max(anul)" +
               "from salarizare", Globals.con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            textBox1.Text = dt.Rows[0][0].ToString();
            maskedTextBox1.Text= dt.Rows[0][1].ToString();
            int luna = Int32.Parse(textBox1.Text);
            int an = Int32.Parse(maskedTextBox1.Text);
             cmd = new SqlCommand($"select [dbo].[ZileLucratoareInLuna]" +
                $"({an},{luna})", Globals.con);
            sda = new SqlDataAdapter(cmd);
           dt = new DataTable();
            sda.Fill(dt);
            string zileLuc = dt.Rows[0][0].ToString();
            maskedTextBox3.Text = zileLuc;
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            Biblioteca bi = new Biblioteca();
            bi.session_data(usr_type);
            bi.Show();
        }

        private void Adauga_pontaj(object sender, EventArgs e)
        {
           try
            { //ordinea
                string querry = "INSERT INTO [dbo].pontaj values(" +
                    $"{Int32.Parse(maskedTextBox2.Text)}, " +
                    $"{Int32.Parse(maskedTextBox3.Text)}, " +
                    $"{Int32.Parse(maskedTextBox4.Text)}, " +
                    $"{Int32.Parse(maskedTextBox5.Text)}, " +
                    $"{Int32.Parse(maskedTextBox6.Text)}, " +
                    $"{Int32.Parse(maskedTextBox7.Text)}, " +
                    $"{Int32.Parse(maskedTextBox8.Text)} " +
                    ")";
                SqlCommand cmd = new SqlCommand(querry, Globals.con);
            Globals.con.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.InsertCommand = cmd ;
                cmd.ExecuteNonQuery();
            Globals.con.Close();
                MessageBox.Show("adaugat cu succes");
            }
             catch (Exception)
             {
                 MessageBox.Show("Completeaza toate datele");
             }
        }
    }
}
