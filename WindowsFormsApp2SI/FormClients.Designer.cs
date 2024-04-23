namespace WindowsFormsApp2SI
{
    partial class FormClients
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
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.Nom = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonFermer = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.ItemHeight = 16;
            this.listBoxClients.Location = new System.Drawing.Point(12, 18);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(163, 292);
            this.listBoxClients.TabIndex = 1;
            this.listBoxClients.SelectedIndexChanged += new System.EventHandler(this.listBoxClients_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nom.Location = new System.Drawing.Point(200, 18);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(71, 31);
            this.Nom.TabIndex = 2;
            this.Nom.Text = "Nom";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(325, 18);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(262, 34);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdresse.Location = new System.Drawing.Point(325, 73);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(262, 34);
            this.textBoxAdresse.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(200, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mail";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.Location = new System.Drawing.Point(325, 130);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(262, 34);
            this.textBoxMail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(200, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresse";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTel.Location = new System.Drawing.Point(325, 192);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(262, 34);
            this.textBoxTel.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label3.Location = new System.Drawing.Point(200, 195);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 31);
            label3.TabIndex = 8;
            label3.Text = "Tel";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAjouter.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAjouter.Location = new System.Drawing.Point(623, 18);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(243, 49);
            this.buttonAjouter.TabIndex = 10;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.Location = new System.Drawing.Point(623, 96);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(243, 50);
            this.buttonModifier.TabIndex = 11;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSupprimer.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSupprimer.Location = new System.Drawing.Point(623, 168);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(243, 50);
            this.buttonSupprimer.TabIndex = 12;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonFermer
            // 
            this.buttonFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFermer.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFermer.Location = new System.Drawing.Point(623, 247);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(243, 50);
            this.buttonFermer.TabIndex = 13;
            this.buttonFermer.Text = "Quitter";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click_1);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.CancelButton = this.buttonFermer;
            this.ClientSize = new System.Drawing.Size(878, 322);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.listBoxClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Clients";
            this.Load += new System.EventHandler(this.FormClients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonFermer;
    }
}