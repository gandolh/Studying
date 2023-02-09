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
    public partial class nomenclaturi_search : Form
    {
        int usr_type;
        Form prev_window;
        int request_type;
        public nomenclaturi_search()
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
        public void session_data(int usr_type_param, Form prev_window_param,int req_type_param)
        {
            usr_type = usr_type_param;
            prev_window = prev_window_param;
            request_type = req_type_param;
            //MessageBox.Show(usr_type.ToString());


        }

        private void cell_clicked(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            //Angajati an = new Angajati();
            //an.session_data(usr_type);
            if (request_type == 1) //retinere
            {
                salarizare nom_ret = (salarizare)prev_window;
                var i = e.RowIndex;
                DataGridViewRow rand = dataGridView1.Rows[i];
                nom_ret.retrieve_data_for_retineri(
                   Int32.Parse( rand.Cells[0].Value.ToString()),
                    rand.Cells[2].Value.ToString(),
                    Int32.Parse(rand.Cells[3].Value.ToString())
                    );
            }
            else //spor
            {
                salarizare nom_ret = (salarizare)prev_window;
                var i = e.RowIndex;
                DataGridViewRow rand = dataGridView1.Rows[i];
                nom_ret.retrieve_data_for_sporuri(
                    rand.Cells[1].Value.ToString(),
                    rand.Cells[2].Value.ToString(),
                    Int32.Parse(rand.Cells[3].Value.ToString()),
                    Int32.Parse(rand.Cells[4].Value.ToString())
                    );
            }



            prev_window.Show();
            this.Close();
        }
    }
}
