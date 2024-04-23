namespace WindowsFormsApp2SI
{
    partial class Form2SI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2SI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parametresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matérielsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCI = new System.Windows.Forms.Button();
            this.comboBoxMatos = new System.Windows.Forms.ComboBox();
            this.textBoxTech = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDI = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewListI = new System.Windows.Forms.ListView();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadermatos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAffInter = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeb = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.interventionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // parametresToolStripMenuItem
            // 
            this.parametresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.matérielsToolStripMenuItem,
            this.interventionsToolStripMenuItem});
            this.parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            this.parametresToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.parametresToolStripMenuItem.Text = "Menu";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // matérielsToolStripMenuItem
            // 
            this.matérielsToolStripMenuItem.Name = "matérielsToolStripMenuItem";
            this.matérielsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.matérielsToolStripMenuItem.Text = "Matériels";
            this.matérielsToolStripMenuItem.Click += new System.EventHandler(this.matérielsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCI);
            this.groupBox1.Controls.Add(this.comboBoxMatos);
            this.groupBox1.Controls.Add(this.textBoxTech);
            this.groupBox1.Controls.Add(this.textBoxComment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerDI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 273);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Création d\'une intervention";
            // 
            // buttonCI
            // 
            this.buttonCI.Location = new System.Drawing.Point(22, 220);
            this.buttonCI.Name = "buttonCI";
            this.buttonCI.Size = new System.Drawing.Size(303, 41);
            this.buttonCI.TabIndex = 8;
            this.buttonCI.Text = "Créer";
            this.buttonCI.UseVisualStyleBackColor = true;
            this.buttonCI.Click += new System.EventHandler(this.buttonCI_Click);
            // 
            // comboBoxMatos
            // 
            this.comboBoxMatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatos.FormattingEnabled = true;
            this.comboBoxMatos.Location = new System.Drawing.Point(125, 190);
            this.comboBoxMatos.Name = "comboBoxMatos";
            this.comboBoxMatos.Size = new System.Drawing.Size(200, 24);
            this.comboBoxMatos.TabIndex = 7;
            // 
            // textBoxTech
            // 
            this.textBoxTech.Location = new System.Drawing.Point(125, 139);
            this.textBoxTech.Name = "textBoxTech";
            this.textBoxTech.Size = new System.Drawing.Size(200, 22);
            this.textBoxTech.TabIndex = 6;
            this.textBoxTech.TextChanged += new System.EventHandler(this.textBoxTech_TextChanged);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(125, 78);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(200, 50);
            this.textBoxComment.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Matériel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Technicien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Commentaire";
            // 
            // dateTimePickerDI
            // 
            this.dateTimePickerDI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDI.Location = new System.Drawing.Point(125, 36);
            this.dateTimePickerDI.Name = "dateTimePickerDI";
            this.dateTimePickerDI.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewListI);
            this.groupBox2.Controls.Add(this.buttonAffInter);
            this.groupBox2.Controls.Add(this.dateTimePickerEnd);
            this.groupBox2.Controls.Add(this.dateTimePickerDeb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(393, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 273);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des interventions";
            // 
            // listViewListI
            // 
            this.listViewListI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderComment,
            this.columnHeaderTech,
            this.columnHeadermatos});
            this.listViewListI.HideSelection = false;
            this.listViewListI.Location = new System.Drawing.Point(20, 85);
            this.listViewListI.Name = "listViewListI";
            this.listViewListI.Size = new System.Drawing.Size(700, 176);
            this.listViewListI.TabIndex = 10;
            this.listViewListI.UseCompatibleStateImageBehavior = false;
            this.listViewListI.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 80;
            // 
            // columnHeaderComment
            // 
            this.columnHeaderComment.Text = "Commentaire";
            this.columnHeaderComment.Width = 260;
            // 
            // columnHeaderTech
            // 
            this.columnHeaderTech.Text = "Technicien";
            this.columnHeaderTech.Width = 80;
            // 
            // columnHeadermatos
            // 
            this.columnHeadermatos.Text = "Matériel";
            this.columnHeadermatos.Width = 140;
            // 
            // buttonAffInter
            // 
            this.buttonAffInter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAffInter.Location = new System.Drawing.Point(514, 29);
            this.buttonAffInter.Name = "buttonAffInter";
            this.buttonAffInter.Size = new System.Drawing.Size(206, 41);
            this.buttonAffInter.TabIndex = 9;
            this.buttonAffInter.Text = "Afficher les interventions";
            this.buttonAffInter.UseVisualStyleBackColor = true;
            this.buttonAffInter.Click += new System.EventHandler(this.buttonAffInter_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(274, 29);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(123, 22);
            this.dateTimePickerEnd.TabIndex = 3;
            // 
            // dateTimePickerDeb
            // 
            this.dateTimePickerDeb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDeb.Location = new System.Drawing.Point(78, 29);
            this.dateTimePickerDeb.Name = "dateTimePickerDeb";
            this.dateTimePickerDeb.Size = new System.Drawing.Size(130, 22);
            this.dateTimePickerDeb.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(17, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Debut";
            // 
            // interventionsToolStripMenuItem
            // 
            this.interventionsToolStripMenuItem.Name = "interventionsToolStripMenuItem";
            this.interventionsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.interventionsToolStripMenuItem.Text = "Interventions";
            this.interventionsToolStripMenuItem.Click += new System.EventHandler(this.interventionsToolStripMenuItem_Click);
            // 
            // Form2SI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1184, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2SI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Gestion Matos";
            this.Load += new System.EventHandler(this.Form2SI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parametresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matérielsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTech;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCI;
        private System.Windows.Forms.ComboBox comboBoxMatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAffInter;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewListI;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderComment;
        private System.Windows.Forms.ColumnHeader columnHeaderTech;
        private System.Windows.Forms.ColumnHeader columnHeadermatos;
        private System.Windows.Forms.ToolStripMenuItem interventionsToolStripMenuItem;
    }
}

