using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemsNamber2
{
    public partial class FormDrugs : Form
    {
        public void ShowList()
        {
            listViewDrugs.Items.Clear();
            foreach (Medicine med in Program.hes.Medicine)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    med.Id.ToString(),
                    med.Name,
                    med.ReleaseForm,
                    med.Quantity,
                    med.Manufacturer,
                    med.ExpirationDate
                });
                item.Tag = med;
                listViewDrugs.Items.Add(item);
            }
        }
        public FormDrugs()
        {
            InitializeComponent();
            ShowList();
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            Form Menu = new FormMenu();
            Menu.Show();
            this.Hide();
        }
        private void Alex_veSmallDick_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
