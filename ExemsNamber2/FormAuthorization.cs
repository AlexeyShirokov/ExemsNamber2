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
    public partial class FormAuthorization : Form
    {
        public bool checkText = true;
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonAut_Click(object sender, EventArgs e)
        {
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (textBoxLoginAut.Text == "" && textBoxPasswordAut.Text == "")
                    {
                        MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bool key = false;
                        foreach (Doctor user in Program.hes.Doctor)
                        {
                            if (textBoxLoginAut.Text == user.Login && textBoxPasswordAut.Text == user.Password)
                            {
                                key = true;
                                user.Login = user.Login;
                                user.Password = user.Password;

                            }
                        }
                        if (!key)
                        {
                            MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Form formMenu = new FormMenu();
                            formMenu.Show();
                            this.Hide();
                            Personal.Type = "Doctor";
                        }
                    }
                }
                if (comboBoxType.SelectedIndex == 1)
                {
                    if (textBoxLoginAut.Text == "" && textBoxPasswordAut.Text == "")
                    {
                        MessageBox.Show("Введите данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bool key = false;
                        foreach (Bayer user in Program.hes.Bayer)
                        {
                            if (textBoxLoginAut.Text == user.Login && textBoxPasswordAut.Text == user.Password)
                            {
                                key = true;
                                user.Login = user.Login;
                                user.Password = user.Password;

                            }
                        }
                        if (!key)
                        {
                            MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Form formMenu = new FormMenu();
                            formMenu.Show();
                            this.Hide();
                            Personal.Type = "user";
                        }
                    }
                }

            }
        }
        public bool cekreg = true; 
        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (cekreg)
            {
                panelAut.Enabled = false;
                panelReg.Location = new Point(14, 92);
                cekreg = !cekreg;
            }
            else
            {
                panelAut.Enabled = true;
                panelReg.Location = new Point(414, 92);
                cekreg = !cekreg;
            }
        }

        private void buttonZareg_Click(object sender, EventArgs e)
        {
            Bayer user = new Bayer();
            user.FirstName = textBoxFairstNameReg.Text;
            user.LastName = textBoxLAsrtNAmereg.Text;
            user.MiddleName = textBoxMiddleNameReg.Text;
            user.Phone = textBoxPhone.Text;
            user.Emil = textBoxEmail.Text;
            user.Login = textBoxloginreg.Text;
            user.Password = textBoxpasswordreg.Text;
            Program.hes.Bayer.Add(user);
            Program.hes.SaveChanges();
            panelAut.Enabled = true;
            panelReg.Location = new Point(414, 92);
          
        }
    }
}
