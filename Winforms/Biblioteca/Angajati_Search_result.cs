using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Angajati_Search_result : Form
    {
        int usr_type;
        Form prev_window;
        public Angajati_Search_result()
        {
            InitializeComponent();
        }
        public void populate_dataGridView(DataTable tabel)
        {
            dataGridView1.DataSource = tabel;
        }


        private void inapoi_la_angajati(object sender, EventArgs e)
        {
            this.Close();
            //Angajati an = new Angajati();
            //an.session_data(usr_type);
            prev_window.Show();
        }
        public void session_data(int usr_type_param,Form prev_window_param)
        {
            usr_type = usr_type_param;
            prev_window = prev_window_param;
            //MessageBox.Show(usr_type.ToString());
   

        }

        private void cell_clicked(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            //Angajati an = new Angajati();
            //an.session_data(usr_type);
            if (prev_window is salarizare_angajati)
            {
                salarizare_angajati an = (salarizare_angajati)prev_window;
                var i = e.RowIndex;
                DataGridViewRow rand = dataGridView1.Rows[i];
                an.retrieve_data_from_angajati_search(
                    rand.Cells[0].Value.ToString(),
                    rand.Cells[1].Value.ToString(),
                    rand.Cells[2].Value.ToString(),
                    rand.Cells[3].Value.ToString(),
                    rand.Cells[4].Value.ToString(),
                    rand.Cells[5].Value.ToString(),
                    rand.Cells[6].Value.ToString()
                    );

            }
            else if (prev_window is Angajati)
            {
                Angajati an = (Angajati)prev_window;
                var i = e.RowIndex;
                DataGridViewRow rand = dataGridView1.Rows[i];
                an.retrieve_data_from_angajati_search(
                    rand.Cells[0].Value.ToString(),
                    rand.Cells[1].Value.ToString(),
                    rand.Cells[2].Value.ToString(),
                    rand.Cells[3].Value.ToString(),
                    rand.Cells[4].Value.ToString()
                    );

            }
            else if (prev_window is Abonati)
            {
                Abonati ab = (Abonati)prev_window;

                var i = e.RowIndex;
                DataGridViewRow rand = dataGridView1.Rows[i];
                ab.retrieve_data_from_angajati_search(
                    rand.Cells[0].Value.ToString(),
                    rand.Cells[1].Value.ToString(),
                    rand.Cells[2].Value.ToString(),
                    rand.Cells[3].Value.ToString(),
                    rand.Cells[4].Value.ToString(),
                     rand.Cells[5].Value.ToString(),
                     rand.Cells[6].Value.ToString(),
                     rand.Cells[7].Value.ToString(),
                     rand.Cells[8].Value.ToString(),
                     rand.Cells[9].Value.ToString(),
                     rand.Cells[10].Value.ToString(),
                     rand.Cells[11].Value.ToString(),
                     rand.Cells[12].Value.ToString(),
                     rand.Cells[13].Value.ToString(),
                     rand.Cells[14].Value.ToString()
                    );

            }
            else if (prev_window is Carti)
            {
                Carti ca = (Carti)prev_window;
                var i = e.RowIndex;
                DataGridViewRow rand = dataGridView1.Rows[i];
                ca.retrieve_data_from_angajati_search(
                    rand.Cells[0].Value.ToString(),
                    rand.Cells[1].Value.ToString(),
                    rand.Cells[2].Value.ToString(),
                    rand.Cells[3].Value.ToString(),
                    rand.Cells[4].Value.ToString(),
                    rand.Cells[5].Value.ToString(),
                    rand.Cells[6].Value.ToString()
                    );

            }
            else if(prev_window is nom_retineri)
            {
                nom_retineri nomRetineri = (nom_retineri)prev_window;
                var i = e.RowIndex;
                DataGridViewRow rand = dataGridView1.Rows[i];
                nomRetineri.retrieve_data_from_angajati_search(
                    rand.Cells[0].Value.ToString(),
                    rand.Cells[1].Value.ToString(),
                    rand.Cells[2].Value.ToString(),
                    rand.Cells[3].Value.ToString()
                    );

            }
            else
            {
                nomSporuri nom_spor = (nomSporuri)prev_window;
                var i = e.RowIndex;
                DataGridViewRow rand = dataGridView1.Rows[i];
                nom_spor.retrieve_data_from_angajati_search(
                    rand.Cells[0].Value.ToString(),
                    rand.Cells[1].Value.ToString(),
                    rand.Cells[2].Value.ToString(),
                    rand.Cells[3].Value.ToString(),
                    rand.Cells[4].Value.ToString()
                    );
            }

            prev_window.Show();
            this.Close();
        }
    }
}
