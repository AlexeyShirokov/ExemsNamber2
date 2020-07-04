namespace ExemsNamber2
{
    partial class FormAuthorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAut = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.panelAut = new System.Windows.Forms.Panel();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelLoginAut = new System.Windows.Forms.Label();
            this.labelPasswordAut = new System.Windows.Forms.Label();
            this.textBoxPasswordAut = new System.Windows.Forms.TextBox();
            this.textBoxLoginAut = new System.Windows.Forms.TextBox();
            this.labelReg = new System.Windows.Forms.Label();
            this.panelReg = new System.Windows.Forms.Panel();
            this.buttonZareg = new System.Windows.Forms.Button();
            this.labelMiddleNAmeReg = new System.Windows.Forms.Label();
            this.textBoxMiddleNameReg = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelloginreg = new System.Windows.Forms.Label();
            this.labelpasswordreg = new System.Windows.Forms.Label();
            this.textBoxpasswordreg = new System.Windows.Forms.TextBox();
            this.textBoxloginreg = new System.Windows.Forms.TextBox();
            this.labelFirstNAmeReg = new System.Windows.Forms.Label();
            this.labelLastNamereg = new System.Windows.Forms.Label();
            this.textBoxLAsrtNAmereg = new System.Windows.Forms.TextBox();
            this.textBoxFairstNameReg = new System.Windows.Forms.TextBox();
            this.panelAut.SuspendLayout();
            this.panelReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAut
            // 
            this.buttonAut.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAut.Location = new System.Drawing.Point(84, 401);
            this.buttonAut.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAut.Name = "buttonAut";
            this.buttonAut.Size = new System.Drawing.Size(158, 46);
            this.buttonAut.TabIndex = 0;
            this.buttonAut.Text = "Войти";
            this.buttonAut.UseVisualStyleBackColor = false;
            this.buttonAut.Click += new System.EventHandler(this.buttonAut_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReg.Location = new System.Drawing.Point(98, 578);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(5);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(158, 49);
            this.buttonReg.TabIndex = 1;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // panelAut
            // 
            this.panelAut.Controls.Add(this.labelType);
            this.panelAut.Controls.Add(this.comboBoxType);
            this.panelAut.Controls.Add(this.labelLoginAut);
            this.panelAut.Controls.Add(this.labelPasswordAut);
            this.panelAut.Controls.Add(this.buttonAut);
            this.panelAut.Controls.Add(this.textBoxPasswordAut);
            this.panelAut.Controls.Add(this.textBoxLoginAut);
            this.panelAut.Location = new System.Drawing.Point(14, 76);
            this.panelAut.Margin = new System.Windows.Forms.Padding(5);
            this.panelAut.Name = "panelAut";
            this.panelAut.Size = new System.Drawing.Size(326, 470);
            this.panelAut.TabIndex = 2;
            // 
            // labelType
            // 
            this.labelType.Location = new System.Drawing.Point(77, 50);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(173, 23);
            this.labelType.TabIndex = 6;
            this.labelType.Text = "Кто вы?";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Фармацевт",
            "Покупатель"});
            this.comboBoxType.Location = new System.Drawing.Point(77, 76);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(173, 31);
            this.comboBoxType.TabIndex = 5;
            // 
            // labelLoginAut
            // 
            this.labelLoginAut.Location = new System.Drawing.Point(77, 169);
            this.labelLoginAut.Name = "labelLoginAut";
            this.labelLoginAut.Size = new System.Drawing.Size(173, 23);
            this.labelLoginAut.TabIndex = 4;
            this.labelLoginAut.Text = "Логин";
            this.labelLoginAut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPasswordAut
            // 
            this.labelPasswordAut.Location = new System.Drawing.Point(77, 229);
            this.labelPasswordAut.Name = "labelPasswordAut";
            this.labelPasswordAut.Size = new System.Drawing.Size(173, 23);
            this.labelPasswordAut.TabIndex = 3;
            this.labelPasswordAut.Text = "Пароль";
            this.labelPasswordAut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPasswordAut
            // 
            this.textBoxPasswordAut.Location = new System.Drawing.Point(77, 255);
            this.textBoxPasswordAut.Name = "textBoxPasswordAut";
            this.textBoxPasswordAut.Size = new System.Drawing.Size(173, 31);
            this.textBoxPasswordAut.TabIndex = 1;
            this.textBoxPasswordAut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLoginAut
            // 
            this.textBoxLoginAut.Location = new System.Drawing.Point(77, 195);
            this.textBoxLoginAut.Name = "textBoxLoginAut";
            this.textBoxLoginAut.Size = new System.Drawing.Size(173, 31);
            this.textBoxLoginAut.TabIndex = 0;
            this.textBoxLoginAut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelReg
            // 
            this.labelReg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReg.Location = new System.Drawing.Point(14, 9);
            this.labelReg.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(326, 62);
            this.labelReg.TabIndex = 3;
            this.labelReg.Text = "Авторизация";
            this.labelReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelReg
            // 
            this.panelReg.Controls.Add(this.buttonZareg);
            this.panelReg.Controls.Add(this.labelMiddleNAmeReg);
            this.panelReg.Controls.Add(this.textBoxMiddleNameReg);
            this.panelReg.Controls.Add(this.labelPhone);
            this.panelReg.Controls.Add(this.labelEmail);
            this.panelReg.Controls.Add(this.textBoxEmail);
            this.panelReg.Controls.Add(this.textBoxPhone);
            this.panelReg.Controls.Add(this.labelloginreg);
            this.panelReg.Controls.Add(this.labelpasswordreg);
            this.panelReg.Controls.Add(this.textBoxpasswordreg);
            this.panelReg.Controls.Add(this.textBoxloginreg);
            this.panelReg.Controls.Add(this.labelFirstNAmeReg);
            this.panelReg.Controls.Add(this.labelLastNamereg);
            this.panelReg.Controls.Add(this.textBoxLAsrtNAmereg);
            this.panelReg.Controls.Add(this.textBoxFairstNameReg);
            this.panelReg.Location = new System.Drawing.Point(389, 76);
            this.panelReg.Margin = new System.Windows.Forms.Padding(5);
            this.panelReg.Name = "panelReg";
            this.panelReg.Size = new System.Drawing.Size(326, 470);
            this.panelReg.TabIndex = 7;
            // 
            // buttonZareg
            // 
            this.buttonZareg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonZareg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZareg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonZareg.Location = new System.Drawing.Point(65, 429);
            this.buttonZareg.Margin = new System.Windows.Forms.Padding(5);
            this.buttonZareg.Name = "buttonZareg";
            this.buttonZareg.Size = new System.Drawing.Size(197, 31);
            this.buttonZareg.TabIndex = 8;
            this.buttonZareg.Text = "Зарегистрироваться";
            this.buttonZareg.UseVisualStyleBackColor = false;
            this.buttonZareg.Click += new System.EventHandler(this.buttonZareg_Click);
            // 
            // labelMiddleNAmeReg
            // 
            this.labelMiddleNAmeReg.Location = new System.Drawing.Point(77, 244);
            this.labelMiddleNAmeReg.Name = "labelMiddleNAmeReg";
            this.labelMiddleNAmeReg.Size = new System.Drawing.Size(173, 23);
            this.labelMiddleNAmeReg.TabIndex = 14;
            this.labelMiddleNAmeReg.Text = "Отчество";
            this.labelMiddleNAmeReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMiddleNameReg
            // 
            this.textBoxMiddleNameReg.Location = new System.Drawing.Point(77, 270);
            this.textBoxMiddleNameReg.Name = "textBoxMiddleNameReg";
            this.textBoxMiddleNameReg.Size = new System.Drawing.Size(173, 31);
            this.textBoxMiddleNameReg.TabIndex = 13;
            this.textBoxMiddleNameReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPhone
            // 
            this.labelPhone.Location = new System.Drawing.Point(77, 304);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(173, 23);
            this.labelPhone.TabIndex = 12;
            this.labelPhone.Text = "Телефон";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(77, 364);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(173, 23);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Эл. почта";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(77, 390);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(173, 31);
            this.textBoxEmail.TabIndex = 10;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(77, 330);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(173, 31);
            this.textBoxPhone.TabIndex = 9;
            this.textBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelloginreg
            // 
            this.labelloginreg.Location = new System.Drawing.Point(77, 4);
            this.labelloginreg.Name = "labelloginreg";
            this.labelloginreg.Size = new System.Drawing.Size(173, 23);
            this.labelloginreg.TabIndex = 8;
            this.labelloginreg.Text = "Логин";
            this.labelloginreg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelpasswordreg
            // 
            this.labelpasswordreg.Location = new System.Drawing.Point(77, 64);
            this.labelpasswordreg.Name = "labelpasswordreg";
            this.labelpasswordreg.Size = new System.Drawing.Size(173, 23);
            this.labelpasswordreg.TabIndex = 7;
            this.labelpasswordreg.Text = "Пароль";
            this.labelpasswordreg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxpasswordreg
            // 
            this.textBoxpasswordreg.Location = new System.Drawing.Point(77, 90);
            this.textBoxpasswordreg.Name = "textBoxpasswordreg";
            this.textBoxpasswordreg.Size = new System.Drawing.Size(173, 31);
            this.textBoxpasswordreg.TabIndex = 6;
            this.textBoxpasswordreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxloginreg
            // 
            this.textBoxloginreg.Location = new System.Drawing.Point(77, 30);
            this.textBoxloginreg.Name = "textBoxloginreg";
            this.textBoxloginreg.Size = new System.Drawing.Size(173, 31);
            this.textBoxloginreg.TabIndex = 5;
            this.textBoxloginreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFirstNAmeReg
            // 
            this.labelFirstNAmeReg.Location = new System.Drawing.Point(77, 124);
            this.labelFirstNAmeReg.Name = "labelFirstNAmeReg";
            this.labelFirstNAmeReg.Size = new System.Drawing.Size(173, 23);
            this.labelFirstNAmeReg.TabIndex = 4;
            this.labelFirstNAmeReg.Text = "Имя";
            this.labelFirstNAmeReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLastNamereg
            // 
            this.labelLastNamereg.Location = new System.Drawing.Point(77, 184);
            this.labelLastNamereg.Name = "labelLastNamereg";
            this.labelLastNamereg.Size = new System.Drawing.Size(173, 23);
            this.labelLastNamereg.TabIndex = 3;
            this.labelLastNamereg.Text = "Фамилия";
            this.labelLastNamereg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLAsrtNAmereg
            // 
            this.textBoxLAsrtNAmereg.Location = new System.Drawing.Point(77, 210);
            this.textBoxLAsrtNAmereg.Name = "textBoxLAsrtNAmereg";
            this.textBoxLAsrtNAmereg.Size = new System.Drawing.Size(173, 31);
            this.textBoxLAsrtNAmereg.TabIndex = 1;
            this.textBoxLAsrtNAmereg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFairstNameReg
            // 
            this.textBoxFairstNameReg.Location = new System.Drawing.Point(77, 150);
            this.textBoxFairstNameReg.Name = "textBoxFairstNameReg";
            this.textBoxFairstNameReg.Size = new System.Drawing.Size(173, 31);
            this.textBoxFairstNameReg.TabIndex = 0;
            this.textBoxFairstNameReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(354, 661);
            this.Controls.Add(this.panelReg);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.panelAut);
            this.Controls.Add(this.buttonReg);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(370, 700);
            this.MinimumSize = new System.Drawing.Size(370, 700);
            this.Name = "FormAuthorization";
            this.Text = "FormAut";
            this.panelAut.ResumeLayout(false);
            this.panelAut.PerformLayout();
            this.panelReg.ResumeLayout(false);
            this.panelReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAut;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Panel panelAut;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Label labelLoginAut;
        private System.Windows.Forms.Label labelPasswordAut;
        private System.Windows.Forms.TextBox textBoxPasswordAut;
        private System.Windows.Forms.TextBox textBoxLoginAut;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Panel panelReg;
        private System.Windows.Forms.Label labelMiddleNAmeReg;
        private System.Windows.Forms.TextBox textBoxMiddleNameReg;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelloginreg;
        private System.Windows.Forms.Label labelpasswordreg;
        private System.Windows.Forms.TextBox textBoxpasswordreg;
        private System.Windows.Forms.TextBox textBoxloginreg;
        private System.Windows.Forms.Label labelFirstNAmeReg;
        private System.Windows.Forms.Label labelLastNamereg;
        private System.Windows.Forms.TextBox textBoxLAsrtNAmereg;
        private System.Windows.Forms.TextBox textBoxFairstNameReg;
        private System.Windows.Forms.Button buttonZareg;
    }
}