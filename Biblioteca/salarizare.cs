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
    public partial class salarizare : Form
    {
        int usr_type;
        public salarizare()
        {
            InitializeComponent();
        }

        private void Cauta_angajati_click(object sender, EventArgs e)
        {
            this.Hide();
            salarizare_angajati sal = new salarizare_angajati();
            sal.session_data(usr_type,this);
            sal.Show();
        }
        public void session_data(int usr_type_param)
        {
            usr_type = usr_type_param;
            //MessageBox.Show(usr_type.ToString());
        }
        public void receive_data(string id,string locMunca,string Functia)
        {
            textBox4.Text = id;
            textBox3.Text = Functia;
            textBox6.Text = locMunca;
            DataTable tabel = new DataTable();
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            sqda.SelectCommand= new SqlCommand("select * from salarizare where " +
                $"id_angajat={id}", con);
            sqda.Fill(tabel);
            //tabel.rows[0][1]
            IEnumerable<TextBox> textBoxes=groupBox1.Controls.OfType<TextBox>();
            List<TextBox> list = textBoxes.ToList();
            list.Sort(
                delegate(TextBox x, TextBox y)
                {
                    if (x.Name.Length < y.Name.Length) return -1;
                    if (x.Name.Length > y.Name.Length) return 1;
                    if (x.Name.CompareTo(y.Name) < 0) return -1;
                    else return 1;
                }

                );
            for(int i=0;i<list.Count;i++)
            {
                list[i].Text = tabel.Rows[0][i+1].ToString();
            }
        }
        private void Adaugare_salarizare(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Globals.connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("InitLuna",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Luna", SqlDbType.Decimal).Value = textBox1.Text;
            cmd.Parameters.Add("@Anul", SqlDbType.Decimal).Value = textBox2.Text;

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("salarizare initializata pe luna aceasta");
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            Biblioteca bi = new Biblioteca();
            bi.session_data(usr_type);
            bi.Show();
        }

        private void Aplica_modificari(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            sqda.SelectCommand = new SqlCommand(
                "select id from salarizare where " +
                $"id_angajat={textBox3.Text} and " +
                $"luna={textBox1.Text} and anul={textBox2.Text}", con);
            DataTable tabel = new DataTable();
            sqda.Fill(tabel);
            int salarizare_id = Int32.Parse( tabel.Rows[0][0].ToString());
            string querry = $"update [dbo].salarizare " +
                $"set salbaza={textBox6.Text.Replace(',','.')}, " +
                $"salefectiv={textBox7.Text.Replace(',', '.')}, " +
                $"salbrut={textBox8.Text.Replace(',', '.')}, " +
                $"venitnet={textBox9.Text.Replace(',', '.')}, " +
                $"salariunet={textBox10.Text.Replace(',', '.')}, " +
                $"restplata={textBox11.Text.Replace(',', '.')}, " +
                $"restcard={textBox12.Text.Replace(',', '.')}" +
                $"where id={salarizare_id}";
            SqlCommand sqcmd = new SqlCommand(querry,con);
            con.Open();
            sqcmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("au fost aplicate modificarile");
        }

        private void on_load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            textBox1.Text = dt.Month.ToString();
            textBox2.Text = dt.Year.ToString();

        }

        private void Aplica_retineri(object sender, EventArgs e)
        {
            DataTable tabel = new DataTable();
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            sqda.SelectCommand = new SqlCommand(
                "select * from nomretineri",con);
            sqda.Fill(tabel);
            this.Hide();
            nomenclaturi_search asr = new nomenclaturi_search();
            asr.populate_dataGridView(tabel);
            asr.session_data(usr_type, this,1);
            asr.Show();
        }
        public void retrieve_data_for_retineri(
            int id_retinere,string denumire,int procent
         )
        {
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            sqda.SelectCommand = new SqlCommand(
                "select id from salarizare where " +
                $"id_angajat={textBox3.Text} and " +
                $"luna={textBox1.Text} and anul={textBox2.Text}", con);
            DataTable tabel = new DataTable();
            sqda.Fill(tabel);
            int salarizare_id = Int32.Parse(tabel.Rows[0][0].ToString());

            sqda.SelectCommand = new SqlCommand(
            "select ZL_IN_LUNA, ZEF_LUCRATE from pontaj where " +
            $"ID_SALARIZARE={salarizare_id}", con);
            DataTable tabel2 = new DataTable();
            sqda.Fill(tabel2);
            int nr_zile_lucrate = int.Parse(tabel2.Rows[0][1].ToString())
                , zile_lucratoare = int.Parse(tabel2.Rows[0][0].ToString());
            decimal valoare_calculata = decimal.Parse(textBox6.Text);
            valoare_calculata = valoare_calculata*procent/100;
            valoare_calculata = valoare_calculata / zile_lucratoare * nr_zile_lucrate;
            valoare_calculata = Math.Round(valoare_calculata,0);
            /*
             * nr_zile_lucrate din pontaj
             * valoare calculata/zile_lucratoare * nr_zile_lucrate
             * val_calculata/21*20 de exemplu
             */
            SqlCommand sqcmd = new SqlCommand("" +
                $"INSERT INTO VALRETINERI(ID_RETINERI," +
                $"VALOARE_CALCULATA,ID_SALARIZARE) VALUES({id_retinere}," +
                $"{valoare_calculata},{salarizare_id})", con);
            con.Open();
            sqcmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserat cu succes");
        }
        private void Aplica_sporuri(object sender, EventArgs e)
        {
            DataTable tabel = new DataTable();
            SqlConnection con = new SqlConnection(Globals.connectionString);
            SqlDataAdapter sqda = new SqlDataAdapter();
            sqda.SelectCommand = new SqlCommand(
                "select * from nomsporuri", con);
            sqda.Fill(tabel);
            this.Hide();
            nomenclaturi_search asr = new nomenclaturi_search();
            asr.populate_dataGridView(tabel);
            asr.session_data(usr_type, this, 2);
            asr.Show();
        }
        public void retrieve_data_for_sporuri(
    string cod_retinere, string denumire, int cota, int procent
 )
        {
            MessageBox.Show($"{cod_retinere},{denumire},{procent}");

        }
    }
}
