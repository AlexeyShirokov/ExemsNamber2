namespace ExemsNamber2
{
    partial class FormDrugs
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
            this.listViewDrugs = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameDrugs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dosage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Man = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateRel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormRel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewDrugs
            // 
            this.listViewDrugs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NameDrugs,
            this.Dosage,
            this.Man,
            this.DateRel,
            this.FormRel});
            this.listViewDrugs.Font = new System.Drawing.Font("Calibri", 12F);
            this.listViewDrugs.FullRowSelect = true;
            this.listViewDrugs.GridLines = true;
            this.listViewDrugs.HideSelection = false;
            this.listViewDrugs.Location = new System.Drawing.Point(12, 101);
            this.listViewDrugs.MultiSelect = false;
            this.listViewDrugs.Name = "listViewDrugs";
            this.listViewDrugs.Size = new System.Drawing.Size(960, 247);
            this.listViewDrugs.TabIndex = 0;
            this.listViewDrugs.UseCompatibleStateImageBehavior = false;
            this.listViewDrugs.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 50;
            // 
            // NameDrugs
            // 
            this.NameDrugs.Text = "Название лекарства";
            this.NameDrugs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameDrugs.Width = 250;
            // 
            // Dosage
            // 
            this.Dosage.Text = "Дозировка";
            this.Dosage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dosage.Width = 100;
            // 
            // Man
            // 
            this.Man.Text = "Производитель";
            this.Man.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Man.Width = 200;
            // 
            // DateRel
            // 
            this.DateRel.Text = "Срок годности";
            this.DateRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateRel.Width = 156;
            // 
            // FormRel
            // 
            this.FormRel.Text = "Форма выпуска";
            this.FormRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FormRel.Width = 200;
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.Location = new System.Drawing.Point(841, 12);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(131, 55);
            this.buttonBackToMenu.TabIndex = 1;
            this.buttonBackToMenu.Text = "Вернуться в меню";
            this.buttonBackToMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonBackToMenu_Click);
            // 
            // FormDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 361);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.listViewDrugs);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormDrugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alex_veSmallDick";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Alex_veSmallDick_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDrugs;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader NameDrugs;
        private System.Windows.Forms.ColumnHeader Dosage;
        private System.Windows.Forms.ColumnHeader Man;
        private System.Windows.Forms.ColumnHeader DateRel;
        private System.Windows.Forms.ColumnHeader FormRel;
        private System.Windows.Forms.Button buttonBackToMenu;
    }



}