
namespace Mediatek86.Vue
{
    partial class ModifPers
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
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.textBoxPageTitle = new System.Windows.Forms.TextBox();
            this.textBoxMainTitle = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(428, 354);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 31);
            this.buttonAnnuler.TabIndex = 31;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(337, 354);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(85, 31);
            this.buttonEnregistrer.TabIndex = 30;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(273, 317);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(230, 22);
            this.textBoxMail.TabIndex = 28;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(273, 266);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(230, 22);
            this.textBoxTel.TabIndex = 26;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(273, 212);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(230, 22);
            this.textBoxPrenom.TabIndex = 24;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(273, 160);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(230, 22);
            this.textBoxNom.TabIndex = 22;
            this.textBoxNom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(273, 109);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(230, 24);
            this.comboBoxService.TabIndex = 21;
            this.comboBoxService.SelectedIndexChanged += new System.EventHandler(this.comboBoxService_SelectedIndexChanged);
            // 
            // textBoxPageTitle
            // 
            this.textBoxPageTitle.Location = new System.Drawing.Point(1, 62);
            this.textBoxPageTitle.Name = "textBoxPageTitle";
            this.textBoxPageTitle.ReadOnly = true;
            this.textBoxPageTitle.Size = new System.Drawing.Size(800, 22);
            this.textBoxPageTitle.TabIndex = 19;
            this.textBoxPageTitle.Text = "Modifier un nouveau personnel";
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
            this.textBoxMainTitle.TabIndex = 18;
            this.textBoxMainTitle.Text = "MEDIATEK86";
            this.textBoxMainTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(270, 301);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(33, 16);
            this.labelMail.TabIndex = 36;
            this.labelMail.Text = "Mail";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(270, 250);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(74, 16);
            this.labelTel.TabIndex = 35;
            this.labelTel.Text = "Téléphone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Prénom";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(270, 144);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 16);
            this.labelNom.TabIndex = 33;
            this.labelNom.Text = "Nom";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(270, 90);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(54, 16);
            this.labelService.TabIndex = 32;
            this.labelService.Text = "Service";
            // 
            // ModifPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.textBoxPageTitle);
            this.Controls.Add(this.textBoxMainTitle);
            this.Name = "ModifPers";
            this.Text = "ModifPers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.TextBox textBoxPageTitle;
        private System.Windows.Forms.TextBox textBoxMainTitle;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelService;
    }
}