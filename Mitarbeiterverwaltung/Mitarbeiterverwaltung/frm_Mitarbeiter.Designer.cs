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
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_kn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_uebest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_gk = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_bv = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(24, 37);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(151, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Vor- und Nachname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kontonummer:";
            // 
            // lbl_kn
            // 
            this.lbl_kn.AutoSize = true;
            this.lbl_kn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kn.Location = new System.Drawing.Point(22, 98);
            this.lbl_kn.Name = "lbl_kn";
            this.lbl_kn.Size = new System.Drawing.Size(29, 18);
            this.lbl_kn.TabIndex = 2;
            this.lbl_kn.Text = "KN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Überweisungsbestätigung:";
            // 
            // lbl_uebest
            // 
            this.lbl_uebest.AutoSize = true;
            this.lbl_uebest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uebest.Location = new System.Drawing.Point(22, 148);
            this.lbl_uebest.Name = "lbl_uebest";
            this.lbl_uebest.Size = new System.Drawing.Size(197, 18);
            this.lbl_uebest.TabIndex = 4;
            this.lbl_uebest.Text = "nicht überwiesen/überwiesen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gehaltsklasse:";
            // 
            // lbl_gk
            // 
            this.lbl_gk.AutoSize = true;
            this.lbl_gk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gk.Location = new System.Drawing.Point(22, 199);
            this.lbl_gk.Name = "lbl_gk";
            this.lbl_gk.Size = new System.Drawing.Size(114, 18);
            this.lbl_gk.TabIndex = 6;
            this.lbl_gk.Text = "P1/X1/X2/X3/X4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bisheriger Verdienst:";
            // 
            // lbl_bv
            // 
            this.lbl_bv.AutoSize = true;
            this.lbl_bv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bv.Location = new System.Drawing.Point(22, 249);
            this.lbl_bv.Name = "lbl_bv";
            this.lbl_bv.Size = new System.Drawing.Size(60, 18);
            this.lbl_bv.TabIndex = 8;
            this.lbl_bv.Text = "100.000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Schließen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_Mitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(258, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_bv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_gk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_uebest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_kn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_Mitarbeiter";
            this.Text = "Mitarbeiterverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_kn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_uebest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_gk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_bv;
        private System.Windows.Forms.Button button1;
    }
}