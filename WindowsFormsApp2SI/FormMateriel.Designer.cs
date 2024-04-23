namespace WindowsFormsApp2SI
{
    partial class FormMateriel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMateriel));
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.listBoxMatos = new System.Windows.Forms.ListBox();
            this.dateTimePickerInstall = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownMTBF = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMarque = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMTBF)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFermer
            // 
            this.buttonFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFermer.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFermer.Location = new System.Drawing.Point(697, 260);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(243, 50);
            this.buttonFermer.TabIndex = 11;
            this.buttonFermer.Text = "Quitter";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSupprimer.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSupprimer.Location = new System.Drawing.Point(697, 181);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(243, 50);
            this.buttonSupprimer.TabIndex = 10;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.Location = new System.Drawing.Point(697, 109);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(243, 50);
            this.buttonModifier.TabIndex = 9;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAjouter.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAjouter.Location = new System.Drawing.Point(697, 31);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(243, 49);
            this.buttonAjouter.TabIndex = 8;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(212, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "MTBF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(212, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "NoSerie";
            // 
            // textBoxSerie
            // 
            this.textBoxSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSerie.Location = new System.Drawing.Point(374, 87);
            this.textBoxSerie.Name = "textBoxSerie";
            this.textBoxSerie.Size = new System.Drawing.Size(262, 34);
            this.textBoxSerie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(212, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date Install";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(374, 31);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(262, 34);
            this.textBoxNom.TabIndex = 1;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nom.Location = new System.Drawing.Point(212, 32);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(71, 31);
            this.Nom.TabIndex = 15;
            this.Nom.Text = "Nom";
            // 
            // listBoxMatos
            // 
            this.listBoxMatos.FormattingEnabled = true;
            this.listBoxMatos.ItemHeight = 16;
            this.listBoxMatos.Location = new System.Drawing.Point(12, 32);
            this.listBoxMatos.Name = "listBoxMatos";
            this.listBoxMatos.Size = new System.Drawing.Size(163, 388);
            this.listBoxMatos.TabIndex = 0;
            this.listBoxMatos.SelectedIndexChanged += new System.EventHandler(this.listBoxMatos_SelectedIndexChanged);
            // 
            // dateTimePickerInstall
            // 
            this.dateTimePickerInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInstall.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInstall.Location = new System.Drawing.Point(374, 145);
            this.dateTimePickerInstall.Name = "dateTimePickerInstall";
            this.dateTimePickerInstall.Size = new System.Drawing.Size(262, 30);
            this.dateTimePickerInstall.TabIndex = 3;
            // 
            // numericUpDownMTBF
            // 
            this.numericUpDownMTBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMTBF.Location = new System.Drawing.Point(374, 201);
            this.numericUpDownMTBF.Name = "numericUpDownMTBF";
            this.numericUpDownMTBF.Size = new System.Drawing.Size(262, 30);
            this.numericUpDownMTBF.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(212, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "Marque";
            // 
            // textBoxMarque
            // 
            this.textBoxMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarque.Location = new System.Drawing.Point(374, 309);
            this.textBoxMarque.Name = "textBoxMarque";
            this.textBoxMarque.Size = new System.Drawing.Size(262, 34);
            this.textBoxMarque.TabIndex = 6;
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxType.Location = new System.Drawing.Point(374, 251);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(262, 34);
            this.textBoxType.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(212, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 31);
            this.label5.TabIndex = 29;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(212, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 31);
            this.label6.TabIndex = 33;
            this.label6.Text = "Client";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(374, 365);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(262, 33);
            this.comboBoxClient.TabIndex = 7;
            // 
            // FormMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.CancelButton = this.buttonFermer;
            this.ClientSize = new System.Drawing.Size(969, 443);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMarque);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownMTBF);
            this.Controls.Add(this.dateTimePickerInstall);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSerie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.listBoxMatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMateriel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Materiel";
            this.Load += new System.EventHandler(this.FormMateriel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMTBF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.ListBox listBoxMatos;
        private System.Windows.Forms.DateTimePicker dateTimePickerInstall;
        private System.Windows.Forms.NumericUpDown numericUpDownMTBF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMarque;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxClient;
    }
}