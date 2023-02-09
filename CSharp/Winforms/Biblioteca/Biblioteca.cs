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
    public partial class Biblioteca : Form
    {
        int usr_type;
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {

        }

        private void Angajati_click(object sender, EventArgs e)
        {
            this.Close();
            Angajati ang = new Angajati();
            ang.session_data(usr_type);
            ang.Show();
            
        }
        public void session_data(int usr_type_param)
        {
            usr_type = usr_type_param;
            //MessageBox.Show(usr_type.ToString());
        }

        private void Delogare(object sender, EventArgs e)
        {
            this.Close();
            login log = new login();
            log.Show();
        }

        private void Salarizare_click(object sender, EventArgs e)
        {
            this.Close();
            salarizare sal = new salarizare();
            sal.session_data(usr_type);
            sal.Show();
        }

        private void Pontaj_click(object sender, EventArgs e)
        {
            this.Close();
            Pontaj pon = new Pontaj();
            pon.session_data(usr_type);
            pon.Show();
        }

        private void click_abonati(object sender, EventArgs e)
        {
            this.Close();
            Abonati ab = new Abonati();
            ab.session_data(usr_type);
            ab.Show();
        }

        private void Click_carti(object sender, EventArgs e)
        {
            this.Close();
            Carti ca = new Carti();
            ca.session_data(usr_type);
            ca.Show();
        }

        private void retineri_click(object sender, EventArgs e)
        {
            this.Close();
            nom_retineri nomRetineri = new nom_retineri();
            nomRetineri.session_data(usr_type);
            nomRetineri.Show();


        }

        private void nom_sporuri(object sender, EventArgs e)
        {
            this.Close();
            nomSporuri nomSpor = new nomSporuri();
            nomSpor.session_data(usr_type);
            nomSpor.Show();

        }


        private void Calcul_salarii(object sender, EventArgs e)
        {
            this.Close();
            calcul_salarii calc_sal = new calcul_salarii();
            calc_sal.session_data(usr_type);
            calc_sal.Show();
        }
    }
}
