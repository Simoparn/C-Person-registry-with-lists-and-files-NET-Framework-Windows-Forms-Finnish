namespace Graafinen_henkilörekisteri_listoilla_Forms
{
    partial class Form1
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
            this.kaikkitiedotpainike = new System.Windows.Forms.Button();
            this.uusihenkilopainike = new System.Windows.Forms.Button();
            this.poistahenkilopainike = new System.Windows.Forms.Button();
            this.lopetaohjelmapainike = new System.Windows.Forms.Button();
            this.ilmoitustietopalkki = new System.Windows.Forms.TextBox();
            this.henkilotietopalkki = new System.Windows.Forms.TextBox();
            this.syottopalkki = new System.Windows.Forms.TextBox();
            this.muokkaahenkiloapainike = new System.Windows.Forms.Button();
            this.naytahenkilopainike = new System.Windows.Forms.Button();
            this.Form1_painikepaneeli = new System.Windows.Forms.Panel();
            this.Form1_painikepaneeli.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaikkitiedotpainike
            // 
            this.kaikkitiedotpainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaikkitiedotpainike.Location = new System.Drawing.Point(-1, 64);
            this.kaikkitiedotpainike.Name = "kaikkitiedotpainike";
            this.kaikkitiedotpainike.Size = new System.Drawing.Size(297, 36);
            this.kaikkitiedotpainike.TabIndex = 1;
            this.kaikkitiedotpainike.Text = "Näytä kaikkien henkilöiden tiedot";
            this.kaikkitiedotpainike.UseVisualStyleBackColor = true;
            this.kaikkitiedotpainike.Click += new System.EventHandler(this.Kaikkitiedotpainike_Click);
            // 
            // uusihenkilopainike
            // 
            this.uusihenkilopainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uusihenkilopainike.Location = new System.Drawing.Point(0, 111);
            this.uusihenkilopainike.Name = "uusihenkilopainike";
            this.uusihenkilopainike.Size = new System.Drawing.Size(297, 43);
            this.uusihenkilopainike.TabIndex = 2;
            this.uusihenkilopainike.Text = "Syötä uusi henkilö";
            this.uusihenkilopainike.UseVisualStyleBackColor = true;
            this.uusihenkilopainike.Click += new System.EventHandler(this.Uusihenkilopainike_Click);
            // 
            // poistahenkilopainike
            // 
            this.poistahenkilopainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistahenkilopainike.Location = new System.Drawing.Point(0, 219);
            this.poistahenkilopainike.Name = "poistahenkilopainike";
            this.poistahenkilopainike.Size = new System.Drawing.Size(297, 39);
            this.poistahenkilopainike.TabIndex = 3;
            this.poistahenkilopainike.Text = "Poista henkilön tiedot";
            this.poistahenkilopainike.UseVisualStyleBackColor = true;
            this.poistahenkilopainike.Click += new System.EventHandler(this.Poistahenkilopainike_Click);
            // 
            // lopetaohjelmapainike
            // 
            this.lopetaohjelmapainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopetaohjelmapainike.Location = new System.Drawing.Point(0, 269);
            this.lopetaohjelmapainike.Name = "lopetaohjelmapainike";
            this.lopetaohjelmapainike.Size = new System.Drawing.Size(296, 35);
            this.lopetaohjelmapainike.TabIndex = 4;
            this.lopetaohjelmapainike.Text = "Lopeta ohjelma";
            this.lopetaohjelmapainike.UseVisualStyleBackColor = true;
            this.lopetaohjelmapainike.Click += new System.EventHandler(this.Lopetaohjelmapainike_Click);
            // 
            // ilmoitustietopalkki
            // 
            this.ilmoitustietopalkki.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ilmoitustietopalkki.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ilmoitustietopalkki.Location = new System.Drawing.Point(25, 23);
            this.ilmoitustietopalkki.Multiline = true;
            this.ilmoitustietopalkki.Name = "ilmoitustietopalkki";
            this.ilmoitustietopalkki.ReadOnly = true;
            this.ilmoitustietopalkki.Size = new System.Drawing.Size(1285, 48);
            this.ilmoitustietopalkki.TabIndex = 5;
            this.ilmoitustietopalkki.Text = "Ilmoitustietopalkki";
            // 
            // henkilotietopalkki
            // 
            this.henkilotietopalkki.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.henkilotietopalkki.Location = new System.Drawing.Point(25, 119);
            this.henkilotietopalkki.Multiline = true;
            this.henkilotietopalkki.Name = "henkilotietopalkki";
            this.henkilotietopalkki.ReadOnly = true;
            this.henkilotietopalkki.Size = new System.Drawing.Size(1285, 302);
            this.henkilotietopalkki.TabIndex = 6;
            this.henkilotietopalkki.Text = "Henkilötiedot";
            // 
            // syottopalkki
            // 
            this.syottopalkki.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.syottopalkki.Location = new System.Drawing.Point(25, 86);
            this.syottopalkki.Name = "syottopalkki";
            this.syottopalkki.Size = new System.Drawing.Size(1285, 22);
            this.syottopalkki.TabIndex = 7;
            this.syottopalkki.Text = "Syötä pyydetyt tiedot tähän.";
            this.syottopalkki.Click += new System.EventHandler(this.Syottopalkki_Click);
            // 
            // muokkaahenkiloapainike
            // 
            this.muokkaahenkiloapainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaahenkiloapainike.Location = new System.Drawing.Point(0, 166);
            this.muokkaahenkiloapainike.Name = "muokkaahenkiloapainike";
            this.muokkaahenkiloapainike.Size = new System.Drawing.Size(298, 41);
            this.muokkaahenkiloapainike.TabIndex = 8;
            this.muokkaahenkiloapainike.Text = "Muokkaa henkilön tietoja";
            this.muokkaahenkiloapainike.UseVisualStyleBackColor = true;
            this.muokkaahenkiloapainike.Click += new System.EventHandler(this.Muokkaahenkiloapainike_Click);
            // 
            // naytahenkilopainike
            // 
            this.naytahenkilopainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naytahenkilopainike.Location = new System.Drawing.Point(-1, 11);
            this.naytahenkilopainike.Name = "naytahenkilopainike";
            this.naytahenkilopainike.Size = new System.Drawing.Size(298, 42);
            this.naytahenkilopainike.TabIndex = 0;
            this.naytahenkilopainike.Text = "Näytä henkilön tiedot";
            this.naytahenkilopainike.UseVisualStyleBackColor = true;
            this.naytahenkilopainike.Click += new System.EventHandler(this.Naytahenkilopainike_Click);
            // 
            // Form1_painikepaneeli
            // 
            this.Form1_painikepaneeli.Controls.Add(this.naytahenkilopainike);
            this.Form1_painikepaneeli.Controls.Add(this.muokkaahenkiloapainike);
            this.Form1_painikepaneeli.Controls.Add(this.kaikkitiedotpainike);
            this.Form1_painikepaneeli.Controls.Add(this.uusihenkilopainike);
            this.Form1_painikepaneeli.Controls.Add(this.lopetaohjelmapainike);
            this.Form1_painikepaneeli.Controls.Add(this.poistahenkilopainike);
            this.Form1_painikepaneeli.Location = new System.Drawing.Point(1326, 65);
            this.Form1_painikepaneeli.Name = "Form1_painikepaneeli";
            this.Form1_painikepaneeli.Size = new System.Drawing.Size(297, 318);
            this.Form1_painikepaneeli.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 450);
            this.Controls.Add(this.Form1_painikepaneeli);
            this.Controls.Add(this.syottopalkki);
            this.Controls.Add(this.henkilotietopalkki);
            this.Controls.Add(this.ilmoitustietopalkki);
            this.Name = "Form1";
            this.Text = "Graafinen henkilörekisteri tekstitiedostoilla, Forms";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Form1_painikepaneeli.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kaikkitiedotpainike;
        private System.Windows.Forms.Button uusihenkilopainike;
        private System.Windows.Forms.Button poistahenkilopainike;
        private System.Windows.Forms.Button lopetaohjelmapainike;
        private System.Windows.Forms.TextBox ilmoitustietopalkki;
        private System.Windows.Forms.TextBox henkilotietopalkki;
        private System.Windows.Forms.TextBox syottopalkki;
        private System.Windows.Forms.Button muokkaahenkiloapainike;
        private System.Windows.Forms.Button naytahenkilopainike;
        private System.Windows.Forms.Panel Form1_painikepaneeli;
    }
}

