namespace Mitarbeiterverwaltung
{
    partial class frm_Mitarbeiter
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
            this.lbl_KNr = new System.Windows.Forms.Label();
            this.lbl_UeBest = new System.Windows.Forms.Label();
            this.lbl_GKlasse = new System.Windows.Forms.Label();
            this.lbl_Verd = new System.Windows.Forms.Label();
            this.btn_Schliessen = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tbx_KNr = new System.Windows.Forms.TextBox();
            this.tbx_UeBest = new System.Windows.Forms.TextBox();
            this.tbx_GKlasse = new System.Windows.Forms.TextBox();
            this.tbx_Verd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_KNr
            // 
            this.lbl_KNr.AutoSize = true;
            this.lbl_KNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KNr.Location = new System.Drawing.Point(12, 55);
            this.lbl_KNr.Name = "lbl_KNr";
            this.lbl_KNr.Size = new System.Drawing.Size(107, 18);
            this.lbl_KNr.TabIndex = 1;
            this.lbl_KNr.Text = "Kontonummer:";
            // 
            // lbl_UeBest
            // 
            this.lbl_UeBest.AutoSize = true;
            this.lbl_UeBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UeBest.Location = new System.Drawing.Point(12, 110);
            this.lbl_UeBest.Name = "lbl_UeBest";
            this.lbl_UeBest.Size = new System.Drawing.Size(181, 18);
            this.lbl_UeBest.TabIndex = 3;
            this.lbl_UeBest.Text = "Überweisungsbestätigung:";
            // 
            // lbl_GKlasse
            // 
            this.lbl_GKlasse.AutoSize = true;
            this.lbl_GKlasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GKlasse.Location = new System.Drawing.Point(9, 165);
            this.lbl_GKlasse.Name = "lbl_GKlasse";
            this.lbl_GKlasse.Size = new System.Drawing.Size(106, 18);
            this.lbl_GKlasse.TabIndex = 5;
            this.lbl_GKlasse.Text = "Gehaltsklasse:";
            // 
            // lbl_Verd
            // 
            this.lbl_Verd.AutoSize = true;
            this.lbl_Verd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Verd.Location = new System.Drawing.Point(9, 220);
            this.lbl_Verd.Name = "lbl_Verd";
            this.lbl_Verd.Size = new System.Drawing.Size(143, 18);
            this.lbl_Verd.TabIndex = 7;
            this.lbl_Verd.Text = "Bisheriger Verdienst:";
            // 
            // btn_Schliessen
            // 
            this.btn_Schliessen.Location = new System.Drawing.Point(162, 267);
            this.btn_Schliessen.Name = "btn_Schliessen";
            this.btn_Schliessen.Size = new System.Drawing.Size(141, 25);
            this.btn_Schliessen.TabIndex = 9;
            this.btn_Schliessen.Text = "Schließen";
            this.btn_Schliessen.UseVisualStyleBackColor = true;
            this.btn_Schliessen.Click += new System.EventHandler(this.btn_Schliessen_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.Location = new System.Drawing.Point(12, 16);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(55, 20);
            this.lbl_Name.TabIndex = 10;
            this.lbl_Name.Text = "Name";
            // 
            // tbx_KNr
            // 
            this.tbx_KNr.Enabled = false;
            this.tbx_KNr.Location = new System.Drawing.Point(12, 76);
            this.tbx_KNr.Name = "tbx_KNr";
            this.tbx_KNr.Size = new System.Drawing.Size(291, 20);
            this.tbx_KNr.TabIndex = 11;
            // 
            // tbx_UeBest
            // 
            this.tbx_UeBest.Enabled = false;
            this.tbx_UeBest.Location = new System.Drawing.Point(12, 131);
            this.tbx_UeBest.Name = "tbx_UeBest";
            this.tbx_UeBest.Size = new System.Drawing.Size(291, 20);
            this.tbx_UeBest.TabIndex = 12;
            // 
            // tbx_GKlasse
            // 
            this.tbx_GKlasse.Enabled = false;
            this.tbx_GKlasse.Location = new System.Drawing.Point(12, 186);
            this.tbx_GKlasse.Name = "tbx_GKlasse";
            this.tbx_GKlasse.Size = new System.Drawing.Size(291, 20);
            this.tbx_GKlasse.TabIndex = 12;
            // 
            // tbx_Verd
            // 
            this.tbx_Verd.Enabled = false;
            this.tbx_Verd.Location = new System.Drawing.Point(12, 241);
            this.tbx_Verd.Name = "tbx_Verd";
            this.tbx_Verd.Size = new System.Drawing.Size(291, 20);
            this.tbx_Verd.TabIndex = 12;
            // 
            // frm_Mitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(315, 304);
            this.Controls.Add(this.tbx_Verd);
            this.Controls.Add(this.tbx_GKlasse);
            this.Controls.Add(this.tbx_UeBest);
            this.Controls.Add(this.tbx_KNr);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Schliessen);
            this.Controls.Add(this.lbl_Verd);
            this.Controls.Add(this.lbl_GKlasse);
            this.Controls.Add(this.lbl_UeBest);
            this.Controls.Add(this.lbl_KNr);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_Mitarbeiter";
            this.Text = "Mitarbeiterverwaltung";
            this.Load += new System.EventHandler(this.frm_Mitarbeiter_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_KNr;
        private System.Windows.Forms.Label lbl_UeBest;
        private System.Windows.Forms.Label lbl_GKlasse;
        private System.Windows.Forms.Label lbl_Verd;
        private System.Windows.Forms.Button btn_Schliessen;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tbx_KNr;
        private System.Windows.Forms.TextBox tbx_UeBest;
        private System.Windows.Forms.TextBox tbx_GKlasse;
        private System.Windows.Forms.TextBox tbx_Verd;
    }
}