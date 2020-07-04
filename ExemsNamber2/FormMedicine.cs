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
    public partial class FormMedicine : Form
    {
        public FormMedicine()
        {
            InitializeComponent();
            ShowMedicine();
        }
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8 || sym == 127)
            {
                e.Handled = true;
            }
        }
        void ShowMedicine()
        {
            listViewAdvvv.Items.Clear();
            foreach (Medicine medicine in Program.hes.Medicine)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                    medicine.Id.ToString(),
                    medicine.Name,
                    medicine.Quantity,
                    medicine.Manufacturer,
                    medicine.ExpirationDate,
                    medicine.ReleaseForm
                    });
                item.Tag = medicine;
                listViewAdvvv.Items.Add(item);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.Name = textBoxName.Text;
            medicine.Quantity = textBoxQvoliti.Text;
            medicine.Manufacturer = textBoxManufacturer.Text;
            medicine.ExpirationDate = textBoxExpirationDate.Text;
            medicine.ReleaseForm = comboBoxRepliseForm.Text;
            Program.hes.Medicine.Add(medicine);
            Program.hes.SaveChanges();
            ShowMedicine();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Medicine medicine = listViewAdvvv.SelectedItems[0].Tag as Medicine;
            medicine.Name = textBoxName.Text;
            medicine.Quantity = textBoxQvoliti.Text;
            medicine.ExpirationDate = textBoxExpirationDate.Text;
            medicine.Manufacturer = textBoxManufacturer.Text;
            medicine.ReleaseForm = comboBoxRepliseForm.SelectedItem.ToString();
            Program.hes.SaveChanges();
            ShowMedicine();
        }

        private void buttonDel_Click(object sender, EventArgs e)
          {
            try

            {
                if (listViewAdvvv.SelectedItems.Count == 1)
                {
                    Medicine medicine = listViewAdvvv.SelectedItems[0].Tag as Medicine;
                    Program.hes.Medicine.Remove(medicine);
                    Program.hes.SaveChanges();

                }
                textBoxName.Text = "";
                textBoxQvoliti.Text = "";
                textBoxManufacturer.Text = "";
                comboBoxRepliseForm.Text = "";
                textBoxExpirationDate.Text= "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowMedicine();

        }

        private void listViewAdvvv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAdvvv.SelectedItems.Count == 1)
            {
                Medicine medicine = listViewAdvvv.SelectedItems[0].Tag as Medicine;
                medicine.Name = textBoxName.Text;
                medicine.Quantity = textBoxQvoliti.Text;
                medicine.Manufacturer = textBoxManufacturer.Text;
                medicine.ExpirationDate = textBoxExpirationDate.Text;
                medicine.ReleaseForm = comboBoxRepliseForm.Text;
            }
            else 
            {
                textBoxName.Text = "";
                textBoxQvoliti.Text = "";
                textBoxManufacturer.Text = "";
                comboBoxRepliseForm.Text = "";
            }
        }

        private void FormMedicine_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxRepliseForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Form Menu = new FormMenu();
            Menu.Show();
            this.Hide();
        }
    }

}
