namespace Mitarbeiterverwaltung
{
    partial class frm_Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_Login = new System.Windows.Forms.Label();
            this.tbx_bName = new System.Windows.Forms.TextBox();
            this.tbx_bPasswort = new System.Windows.Forms.TextBox();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.btn_Anmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Login.Location = new System.Drawing.Point(12, 16);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(53, 17);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login:";
            // 
            // tbx_bName
            // 
            this.tbx_bName.Location = new System.Drawing.Point(12, 45);
            this.tbx_bName.Name = "tbx_bName";
            this.tbx_bName.Size = new System.Drawing.Size(291, 20);
            this.tbx_bName.TabIndex = 1;
            this.tbx_bName.Text = "(Benutzername)";
            this.tbx_bName.TextChanged += new System.EventHandler(this.tbx_bName_TextChanged);
            // 
            // tbx_bPasswort
            // 
            this.tbx_bPasswort.Location = new System.Drawing.Point(12, 71);
            this.tbx_bPasswort.Name = "tbx_bPasswort";
            this.tbx_bPasswort.Size = new System.Drawing.Size(291, 20);
            this.tbx_bPasswort.TabIndex = 2;
            this.tbx_bPasswort.Text = "(Passwort)";
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(12, 97);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(141, 25);
            this.btn_Abbrechen.TabIndex = 4;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // btn_Anmelden
            // 
            this.btn_Anmelden.Location = new System.Drawing.Point(162, 97);
            this.btn_Anmelden.Name = "btn_Anmelden";
            this.btn_Anmelden.Size = new System.Drawing.Size(141, 25);
            this.btn_Anmelden.TabIndex = 3;
            this.btn_Anmelden.Text = "Anmelden";
            this.btn_Anmelden.UseVisualStyleBackColor = true;
            this.btn_Anmelden.Click += new System.EventHandler(this.btn_Anmelden_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 134);
            this.Controls.Add(this.btn_Anmelden);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.tbx_bPasswort);
            this.Controls.Add(this.tbx_bName);
            this.Controls.Add(this.lbl_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.Text = "Mitarbeiterverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox tbx_bName;
        private System.Windows.Forms.TextBox tbx_bPasswort;
        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.Button btn_Anmelden;
    }
}

