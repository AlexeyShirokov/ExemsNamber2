namespace ExemsNamber2
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenMedicine = new System.Windows.Forms.Button();
            this.buttonMedicineUser = new System.Windows.Forms.Button();
            this.labelStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenMedicine
            // 
            this.buttonOpenMedicine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenMedicine.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenMedicine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOpenMedicine.Location = new System.Drawing.Point(0, 152);
            this.buttonOpenMedicine.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenMedicine.Name = "buttonOpenMedicine";
            this.buttonOpenMedicine.Size = new System.Drawing.Size(290, 50);
            this.buttonOpenMedicine.TabIndex = 14;
            this.buttonOpenMedicine.Text = "Редактировать лекарства ";
            this.buttonOpenMedicine.UseVisualStyleBackColor = false;
            this.buttonOpenMedicine.Click += new System.EventHandler(this.buttonOpenMedicine_Click);
            // 
            // buttonMedicineUser
            // 
            this.buttonMedicineUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonMedicineUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedicineUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMedicineUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMedicineUser.Location = new System.Drawing.Point(0, 152);
            this.buttonMedicineUser.Margin = new System.Windows.Forms.Padding(15);
            this.buttonMedicineUser.Name = "buttonMedicineUser";
            this.buttonMedicineUser.Size = new System.Drawing.Size(290, 50);
            this.buttonMedicineUser.TabIndex = 15;
            this.buttonMedicineUser.Text = "Посмореть лекарства";
            this.buttonMedicineUser.UseVisualStyleBackColor = false;
            this.buttonMedicineUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelStart
            // 
            this.labelStart.Location = new System.Drawing.Point(58, 24);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(174, 43);
            this.labelStart.TabIndex = 16;
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(291, 205);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.buttonMedicineUser);
            this.Controls.Add(this.buttonOpenMedicine);
            this.Name = "FormMenu";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenMedicine;
        private System.Windows.Forms.Button buttonMedicineUser;
        private System.Windows.Forms.Label labelStart;
    }
}

