namespace WindowsFormsApplication1
{
    partial class Izbornik
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
            this.btnVidi = new System.Windows.Forms.Button();
            this.btnNovi = new System.Windows.Forms.Button();
            this.cmbPoduzece = new System.Windows.Forms.ComboBox();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAktiva = new System.Windows.Forms.RadioButton();
            this.rbNT = new System.Windows.Forms.RadioButton();
            this.rbRDG = new System.Windows.Forms.RadioButton();
            this.rbPasiva = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnVidi
            // 
            this.btnVidi.Location = new System.Drawing.Point(73, 234);
            this.btnVidi.Name = "btnVidi";
            this.btnVidi.Size = new System.Drawing.Size(130, 45);
            this.btnVidi.TabIndex = 0;
            this.btnVidi.Text = "Vidi zapis o odabranom";
            this.btnVidi.UseVisualStyleBackColor = true;
            this.btnVidi.Click += new System.EventHandler(this.btnVidi_Click);
            // 
            // btnNovi
            // 
            this.btnNovi.Location = new System.Drawing.Point(209, 234);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(102, 45);
            this.btnNovi.TabIndex = 1;
            this.btnNovi.Text = "Dodaj novi";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // cmbPoduzece
            // 
            this.cmbPoduzece.FormattingEnabled = true;
            this.cmbPoduzece.Location = new System.Drawing.Point(87, 57);
            this.cmbPoduzece.Name = "cmbPoduzece";
            this.cmbPoduzece.Size = new System.Drawing.Size(121, 21);
            this.cmbPoduzece.TabIndex = 4;
            // 
            // cmbGodina
            // 
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(87, 84);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(121, 21);
            this.cmbGodina.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Poduzeće:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Godina:";
            // 
            // rbAktiva
            // 
            this.rbAktiva.AutoSize = true;
            this.rbAktiva.Location = new System.Drawing.Point(41, 127);
            this.rbAktiva.Name = "rbAktiva";
            this.rbAktiva.Size = new System.Drawing.Size(55, 17);
            this.rbAktiva.TabIndex = 9;
            this.rbAktiva.TabStop = true;
            this.rbAktiva.Text = "Aktiva";
            this.rbAktiva.UseVisualStyleBackColor = true;
            // 
            // rbNT
            // 
            this.rbNT.AutoSize = true;
            this.rbNT.Location = new System.Drawing.Point(41, 196);
            this.rbNT.Name = "rbNT";
            this.rbNT.Size = new System.Drawing.Size(153, 17);
            this.rbNT.TabIndex = 10;
            this.rbNT.TabStop = true;
            this.rbNT.Text = "Izvještaj o novčanom tijeku";
            this.rbNT.UseVisualStyleBackColor = true;
            // 
            // rbRDG
            // 
            this.rbRDG.AutoSize = true;
            this.rbRDG.Location = new System.Drawing.Point(41, 173);
            this.rbRDG.Name = "rbRDG";
            this.rbRDG.Size = new System.Drawing.Size(128, 17);
            this.rbRDG.TabIndex = 11;
            this.rbRDG.TabStop = true;
            this.rbRDG.Text = "Racun dobiti i gubitka";
            this.rbRDG.UseVisualStyleBackColor = true;
            // 
            // rbPasiva
            // 
            this.rbPasiva.AutoSize = true;
            this.rbPasiva.Location = new System.Drawing.Point(41, 150);
            this.rbPasiva.Name = "rbPasiva";
            this.rbPasiva.Size = new System.Drawing.Size(57, 17);
            this.rbPasiva.TabIndex = 12;
            this.rbPasiva.TabStop = true;
            this.rbPasiva.Text = "Pasiva";
            this.rbPasiva.UseVisualStyleBackColor = true;
            // 
            // Izbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 350);
            this.Controls.Add(this.rbPasiva);
            this.Controls.Add(this.rbRDG);
            this.Controls.Add(this.rbNT);
            this.Controls.Add(this.rbAktiva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGodina);
            this.Controls.Add(this.cmbPoduzece);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.btnVidi);
            this.Name = "Izbornik";
            this.Text = "Izbornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVidi;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.ComboBox cmbPoduzece;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbAktiva;
        private System.Windows.Forms.RadioButton rbNT;
        private System.Windows.Forms.RadioButton rbRDG;
        private System.Windows.Forms.RadioButton rbPasiva;
    }
}