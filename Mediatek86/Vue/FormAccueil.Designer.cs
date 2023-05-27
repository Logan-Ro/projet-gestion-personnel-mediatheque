
namespace Mediatek86.Vue
{
    partial class FormAccueil
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
            this.buttonAjoutPers = new System.Windows.Forms.Button();
            this.buttonAjoutAbs = new System.Windows.Forms.Button();
            this.dataGridViewAbsences = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsences)).BeginInit();
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
            this.textBoxMainTitle.Location = new System.Drawing.Point(0, 15);
            this.textBoxMainTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMainTitle.Name = "textBoxMainTitle";
            this.textBoxMainTitle.ReadOnly = true;
            this.textBoxMainTitle.ShortcutsEnabled = false;
            this.textBoxMainTitle.Size = new System.Drawing.Size(220, 25);
            this.textBoxMainTitle.TabIndex = 1;
            this.textBoxMainTitle.Text = "MEDIATEK86";
            this.textBoxMainTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMainTitle.TextChanged += new System.EventHandler(this.textBoxMainTitle_TextChanged);
            // 
            // buttonAjoutPers
            // 
            this.buttonAjoutPers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAjoutPers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjoutPers.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutPers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonAjoutPers.Location = new System.Drawing.Point(949, 15);
            this.buttonAjoutPers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAjoutPers.Name = "buttonAjoutPers";
            this.buttonAjoutPers.Size = new System.Drawing.Size(193, 31);
            this.buttonAjoutPers.TabIndex = 7;
            this.buttonAjoutPers.Text = "Ajouter un personnel";
            this.buttonAjoutPers.UseVisualStyleBackColor = false;
            this.buttonAjoutPers.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonAjoutAbs
            // 
            this.buttonAjoutAbs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAjoutAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjoutAbs.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutAbs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buttonAjoutAbs.Location = new System.Drawing.Point(1187, 15);
            this.buttonAjoutAbs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAjoutAbs.Name = "buttonAjoutAbs";
            this.buttonAjoutAbs.Size = new System.Drawing.Size(193, 31);
            this.buttonAjoutAbs.TabIndex = 8;
            this.buttonAjoutAbs.Text = "Ajouter une absence";
            this.buttonAjoutAbs.UseVisualStyleBackColor = false;
            this.buttonAjoutAbs.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewAbsences
            // 
            this.dataGridViewAbsences.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAbsences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbsences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.prenom});
            this.dataGridViewAbsences.Location = new System.Drawing.Point(13, 54);
            this.dataGridViewAbsences.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAbsences.Name = "dataGridViewAbsences";
            this.dataGridViewAbsences.Size = new System.Drawing.Size(1312, 794);
            this.dataGridViewAbsences.TabIndex = 9;
            this.dataGridViewAbsences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1396, 906);
            this.Controls.Add(this.dataGridViewAbsences);
            this.Controls.Add(this.buttonAjoutAbs);
            this.Controls.Add(this.buttonAjoutPers);
            this.Controls.Add(this.textBoxMainTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAccueil";
            this.Text = "FormAccueil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMainTitle;
        private System.Windows.Forms.Button buttonAjoutPers;
        private System.Windows.Forms.Button buttonAjoutAbs;
        private System.Windows.Forms.DataGridView dataGridViewAbsences;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
    }
}