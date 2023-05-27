
namespace Mediatek86.Vue
{
    partial class ModifAbs
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
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonEnregsitrer = new System.Windows.Forms.Button();
            this.comboBoxMotif = new System.Windows.Forms.ComboBox();
            this.comboBoxPersonnel = new System.Windows.Forms.ComboBox();
            this.textBoxPageTitle = new System.Windows.Forms.TextBox();
            this.textBoxMainTitle = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateFin = new System.Windows.Forms.DateTimePicker();
            this.labelPersonnel = new System.Windows.Forms.Label();
            this.labelMotif = new System.Windows.Forms.Label();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(435, 328);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 31);
            this.buttonAnnuler.TabIndex = 25;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonEnregsitrer
            // 
            this.buttonEnregsitrer.Location = new System.Drawing.Point(344, 328);
            this.buttonEnregsitrer.Name = "buttonEnregsitrer";
            this.buttonEnregsitrer.Size = new System.Drawing.Size(85, 31);
            this.buttonEnregsitrer.TabIndex = 24;
            this.buttonEnregsitrer.Text = "Enregistrer";
            this.buttonEnregsitrer.UseVisualStyleBackColor = true;
            // 
            // comboBoxMotif
            // 
            this.comboBoxMotif.FormattingEnabled = true;
            this.comboBoxMotif.Location = new System.Drawing.Point(280, 168);
            this.comboBoxMotif.Name = "comboBoxMotif";
            this.comboBoxMotif.Size = new System.Drawing.Size(230, 24);
            this.comboBoxMotif.TabIndex = 21;
            this.comboBoxMotif.Text = "Vacances";
            // 
            // comboBoxPersonnel
            // 
            this.comboBoxPersonnel.FormattingEnabled = true;
            this.comboBoxPersonnel.Location = new System.Drawing.Point(280, 113);
            this.comboBoxPersonnel.Name = "comboBoxPersonnel";
            this.comboBoxPersonnel.Size = new System.Drawing.Size(230, 24);
            this.comboBoxPersonnel.TabIndex = 19;
            this.comboBoxPersonnel.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxPageTitle
            // 
            this.textBoxPageTitle.Location = new System.Drawing.Point(0, 62);
            this.textBoxPageTitle.Name = "textBoxPageTitle";
            this.textBoxPageTitle.Size = new System.Drawing.Size(800, 22);
            this.textBoxPageTitle.TabIndex = 17;
            this.textBoxPageTitle.Text = "Modifier une absence";
            this.textBoxPageTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.textBoxMainTitle.TabIndex = 16;
            this.textBoxMainTitle.Text = "MEDIATEK86";
            this.textBoxMainTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerDateDebut
            // 
            this.dateTimePickerDateDebut.CalendarFont = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateDebut.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePickerDateDebut.Location = new System.Drawing.Point(280, 226);
            this.dateTimePickerDateDebut.Name = "dateTimePickerDateDebut";
            this.dateTimePickerDateDebut.Size = new System.Drawing.Size(230, 22);
            this.dateTimePickerDateDebut.TabIndex = 26;
            // 
            // dateTimePickerDateFin
            // 
            this.dateTimePickerDateFin.CalendarFont = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateFin.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePickerDateFin.Location = new System.Drawing.Point(280, 284);
            this.dateTimePickerDateFin.Name = "dateTimePickerDateFin";
            this.dateTimePickerDateFin.Size = new System.Drawing.Size(230, 22);
            this.dateTimePickerDateFin.TabIndex = 27;
            // 
            // labelPersonnel
            // 
            this.labelPersonnel.AutoSize = true;
            this.labelPersonnel.Location = new System.Drawing.Point(277, 94);
            this.labelPersonnel.Name = "labelPersonnel";
            this.labelPersonnel.Size = new System.Drawing.Size(69, 16);
            this.labelPersonnel.TabIndex = 28;
            this.labelPersonnel.Text = "Personnel";
            // 
            // labelMotif
            // 
            this.labelMotif.AutoSize = true;
            this.labelMotif.Location = new System.Drawing.Point(277, 149);
            this.labelMotif.Name = "labelMotif";
            this.labelMotif.Size = new System.Drawing.Size(36, 16);
            this.labelMotif.TabIndex = 29;
            this.labelMotif.Text = "Motif";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Location = new System.Drawing.Point(277, 207);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(74, 16);
            this.labelDateDebut.TabIndex = 30;
            this.labelDateDebut.Text = "Date début";
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Location = new System.Drawing.Point(277, 265);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(72, 16);
            this.labelDateFin.TabIndex = 31;
            this.labelDateFin.Text = "Date de fin";
            // 
            // ModifAbs
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
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonEnregsitrer);
            this.Controls.Add(this.comboBoxMotif);
            this.Controls.Add(this.comboBoxPersonnel);
            this.Controls.Add(this.textBoxPageTitle);
            this.Controls.Add(this.textBoxMainTitle);
            this.Name = "ModifAbs";
            this.Text = "ModifAbs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonEnregsitrer;
        private System.Windows.Forms.ComboBox comboBoxMotif;
        private System.Windows.Forms.ComboBox comboBoxPersonnel;
        private System.Windows.Forms.TextBox textBoxPageTitle;
        private System.Windows.Forms.TextBox textBoxMainTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFin;
        private System.Windows.Forms.Label labelPersonnel;
        private System.Windows.Forms.Label labelMotif;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.Label labelDateFin;
    }
}