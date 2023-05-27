
namespace Mediatek86.Vue
{
    partial class AjoutAbs
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
            this.textBoxMainTitle = new System.Windows.Forms.TextBox();
            this.textBoxPageTitle = new System.Windows.Forms.TextBox();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.labelMotif = new System.Windows.Forms.Label();
            this.labelPersonnel = new System.Windows.Forms.Label();
            this.dateTimePickerDateFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateDebut = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.comboBoxPersonnel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxMainTitle
            // 
            this.textBoxMainTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMainTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMainTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMainTitle.Font = new System.Drawing.Font("Liberation Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMainTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxMainTitle.Location = new System.Drawing.Point(13, 13);
            this.textBoxMainTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMainTitle.Name = "textBoxMainTitle";
            this.textBoxMainTitle.ReadOnly = true;
            this.textBoxMainTitle.ShortcutsEnabled = false;
            this.textBoxMainTitle.Size = new System.Drawing.Size(220, 25);
            this.textBoxMainTitle.TabIndex = 2;
            this.textBoxMainTitle.Text = "MEDIATEK86";
            this.textBoxMainTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPageTitle
            // 
            this.textBoxPageTitle.Location = new System.Drawing.Point(0, 62);
            this.textBoxPageTitle.Name = "textBoxPageTitle";
            this.textBoxPageTitle.Size = new System.Drawing.Size(800, 22);
            this.textBoxPageTitle.TabIndex = 3;
            this.textBoxPageTitle.Text = "Ajouter une absence";
            this.textBoxPageTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(344, 328);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(85, 31);
            this.buttonEnregistrer.TabIndex = 12;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(435, 328);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 31);
            this.buttonAnnuler.TabIndex = 13;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Location = new System.Drawing.Point(277, 267);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(72, 16);
            this.labelDateFin.TabIndex = 41;
            this.labelDateFin.Text = "Date de fin";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Location = new System.Drawing.Point(277, 209);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(74, 16);
            this.labelDateDebut.TabIndex = 40;
            this.labelDateDebut.Text = "Date début";
            // 
            // labelMotif
            // 
            this.labelMotif.AutoSize = true;
            this.labelMotif.Location = new System.Drawing.Point(277, 151);
            this.labelMotif.Name = "labelMotif";
            this.labelMotif.Size = new System.Drawing.Size(36, 16);
            this.labelMotif.TabIndex = 39;
            this.labelMotif.Text = "Motif";
            // 
            // labelPersonnel
            // 
            this.labelPersonnel.AutoSize = true;
            this.labelPersonnel.Location = new System.Drawing.Point(277, 96);
            this.labelPersonnel.Name = "labelPersonnel";
            this.labelPersonnel.Size = new System.Drawing.Size(69, 16);
            this.labelPersonnel.TabIndex = 38;
            this.labelPersonnel.Text = "Personnel";
            // 
            // dateTimePickerDateFin
            // 
            this.dateTimePickerDateFin.CalendarFont = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateFin.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePickerDateFin.Location = new System.Drawing.Point(280, 286);
            this.dateTimePickerDateFin.Name = "dateTimePickerDateFin";
            this.dateTimePickerDateFin.Size = new System.Drawing.Size(230, 22);
            this.dateTimePickerDateFin.TabIndex = 37;
            // 
            // dateTimePickerDateDebut
            // 
            this.dateTimePickerDateDebut.CalendarFont = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateDebut.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePickerDateDebut.Location = new System.Drawing.Point(280, 228);
            this.dateTimePickerDateDebut.Name = "dateTimePickerDateDebut";
            this.dateTimePickerDateDebut.Size = new System.Drawing.Size(230, 22);
            this.dateTimePickerDateDebut.TabIndex = 36;
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(280, 170);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(230, 24);
            this.comboBoxMotif.TabIndex = 33;
            this.comboBoxMotif.Text = "Vacances";
            // 
            // comboBoxPersonnel
            // 
            this.comboBoxPersonnel.FormattingEnabled = true;
            this.comboBoxPersonnel.Location = new System.Drawing.Point(280, 115);
            this.comboBoxPersonnel.Name = "comboBoxPersonnel";
            this.comboBoxPersonnel.Size = new System.Drawing.Size(230, 24);
            this.comboBoxPersonnel.TabIndex = 32;
            // 
            // AjoutAbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDateFin);
            this.Controls.Add(this.labelDateDebut);
            this.Controls.Add(this.labelMotif);
            this.Controls.Add(this.labelPersonnel);
            this.Controls.Add(this.dateTimePickerDateFin);
            this.Controls.Add(this.dateTimePickerDateDebut);
            this.Controls.Add(this.comboBoxMotif);
            this.Controls.Add(this.comboBoxPersonnel);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.textBoxPageTitle);
            this.Controls.Add(this.textBoxMainTitle);
            this.Name = "AjoutAbs";
            this.Text = "AjoutAbs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMainTitle;
        private System.Windows.Forms.TextBox textBoxPageTitle;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.Label labelMotif;
        private System.Windows.Forms.Label labelPersonnel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDebut;
        private System.Windows.Forms.ComboBox comboBoxMotif;
        private System.Windows.Forms.ComboBox comboBoxPersonnel;
    }
}