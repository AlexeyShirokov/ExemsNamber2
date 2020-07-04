using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemsNamber2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            if (Personal.Type == "Doctor")
            {
                labelStart.Text = "Вы вошли как фармацевт";
                buttonMedicineUser.Location = new Point(800, 140);
                buttonOpenMedicine.Location = new Point(0, 140);
            }
            else 
            {
                labelStart.Text = "Вы вошли как пользователь";
              
                buttonMedicineUser.Location = new Point(0, 140);
                buttonOpenMedicine.Location = new Point(800, 140);
            }
        }

        private void buttonOpenMedicine_Click(object sender, EventArgs e)
        {
            Form bayer = new FormMedicine();
            bayer.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form drugs = new FormDrugs();
            drugs.Show();
            this.Hide();
        }
    }
}
