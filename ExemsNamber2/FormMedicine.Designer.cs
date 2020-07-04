namespace ExemsNamber2
{
    partial class FormMedicine
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listViewAdvvv = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxQvoliti = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxExpirationDate = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.labeName = new System.Windows.Forms.Label();
            this.lableQvoliti = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labelRepliseForm = new System.Windows.Forms.Label();
            this.comboBoxRepliseForm = new System.Windows.Forms.ComboBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(348, 297);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 37);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(443, 297);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 37);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(540, 297);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(89, 37);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listViewAdvvv
            // 
            this.listViewAdvvv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewAdvvv.FullRowSelect = true;
            this.listViewAdvvv.GridLines = true;
            this.listViewAdvvv.HideSelection = false;
            this.listViewAdvvv.Location = new System.Drawing.Point(139, 15);
            this.listViewAdvvv.MultiSelect = false;
            this.listViewAdvvv.Name = "listViewAdvvv";
            this.listViewAdvvv.Size = new System.Drawing.Size(517, 276);
            this.listViewAdvvv.TabIndex = 48;
            this.listViewAdvvv.UseCompatibleStateImageBehavior = false;
            this.listViewAdvvv.View = System.Windows.Forms.View.Details;
            this.listViewAdvvv.SelectedIndexChanged += new System.EventHandler(this.listViewAdvvv_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            this.columnHeader6.Width = 24;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дозировка";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Производитель";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Срок годности";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Форма выпуска";
            this.columnHeader5.Width = 111;
            // 
            // textBoxQvoliti
            // 
            this.textBoxQvoliti.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQvoliti.Location = new System.Drawing.Point(12, 110);
            this.textBoxQvoliti.Name = "textBoxQvoliti";
            this.textBoxQvoliti.Size = new System.Drawing.Size(100, 23);
            this.textBoxQvoliti.TabIndex = 55;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(12, 66);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 54;
            // 
            // textBoxExpirationDate
            // 
            this.textBoxExpirationDate.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExpirationDate.Location = new System.Drawing.Point(12, 225);
            this.textBoxExpirationDate.Name = "textBoxExpirationDate";
            this.textBoxExpirationDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxExpirationDate.TabIndex = 59;
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxManufacturer.Location = new System.Drawing.Point(12, 162);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(100, 23);
            this.textBoxManufacturer.TabIndex = 58;
            // 
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeName.Location = new System.Drawing.Point(9, 48);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(65, 15);
            this.labeName.TabIndex = 60;
            this.labeName.Text = "Название";
            // 
            // lableQvoliti
            // 
            this.lableQvoliti.AutoSize = true;
            this.lableQvoliti.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableQvoliti.Location = new System.Drawing.Point(12, 92);
            this.lableQvoliti.Name = "lableQvoliti";
            this.lableQvoliti.Size = new System.Drawing.Size(72, 15);
            this.lableQvoliti.TabIndex = 64;
            this.lableQvoliti.Text = "Дозировка";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManufacturer.Location = new System.Drawing.Point(9, 144);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(98, 15);
            this.labelManufacturer.TabIndex = 65;
            this.labelManufacturer.Text = "Производитель";
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExpirationDate.Location = new System.Drawing.Point(13, 207);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(92, 15);
            this.labelExpirationDate.TabIndex = 66;
            this.labelExpirationDate.Text = "Срок годности";
            // 
            // labelRepliseForm
            // 
            this.labelRepliseForm.AutoSize = true;
            this.labelRepliseForm.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRepliseForm.Location = new System.Drawing.Point(12, 263);
            this.labelRepliseForm.Name = "labelRepliseForm";
            this.labelRepliseForm.Size = new System.Drawing.Size(102, 15);
            this.labelRepliseForm.TabIndex = 67;
            this.labelRepliseForm.Text = "Форма выпуска";
            // 
            // comboBoxRepliseForm
            // 
            this.comboBoxRepliseForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRepliseForm.FormattingEnabled = true;
            this.comboBoxRepliseForm.Items.AddRange(new object[] {
            "Капсула",
            "Таблетка",
            "Ампула",
            "Сироп",
            "Крем"});
            this.comboBoxRepliseForm.Location = new System.Drawing.Point(12, 281);
            this.comboBoxRepliseForm.Name = "comboBoxRepliseForm";
            this.comboBoxRepliseForm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRepliseForm.TabIndex = 68;
            this.comboBoxRepliseForm.SelectedIndexChanged += new System.EventHandler(this.comboBoxRepliseForm_SelectedIndexChanged);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(253, 297);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(89, 37);
            this.buttonMenu.TabIndex = 69;
            this.buttonMenu.Text = "Возврат в меню";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // FormMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 350);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.comboBoxRepliseForm);
            this.Controls.Add(this.labelRepliseForm);
            this.Controls.Add(this.labelExpirationDate);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.lableQvoliti);
            this.Controls.Add(this.labeName);
            this.Controls.Add(this.textBoxExpirationDate);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.textBoxQvoliti);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listViewAdvvv);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormMedicine";
            this.Text = "Лекарства";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMedicine_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListView listViewAdvvv;
        private System.Windows.Forms.TextBox textBoxQvoliti;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxExpirationDate;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Label labeName;
        private System.Windows.Forms.Label lableQvoliti;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.Label labelRepliseForm;
        private System.Windows.Forms.ComboBox comboBoxRepliseForm;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonMenu;
    }
}