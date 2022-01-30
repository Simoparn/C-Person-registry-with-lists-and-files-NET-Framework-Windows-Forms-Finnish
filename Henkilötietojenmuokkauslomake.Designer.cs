namespace Graafinen_henkilörekisteri_listoilla_Forms
{
    partial class Henkilötietojenmuokkauslomake
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
            this.muokattavasyntymavuosikentta = new System.Windows.Forms.TextBox();
            this.muokattavasyntymakuukausikentta = new System.Windows.Forms.TextBox();
            this.muokkauslomakeilmoitustietopalkki = new System.Windows.Forms.TextBox();
            this.vahvistamuokkauksetpainike = new System.Windows.Forms.Button();
            this.postitoimipaikkalabel = new System.Windows.Forms.Label();
            this.postinumerolabel = new System.Windows.Forms.Label();
            this.osoitelabel = new System.Windows.Forms.Label();
            this.sukupuolilabel = new System.Windows.Forms.Label();
            this.syntymaaikalabel = new System.Windows.Forms.Label();
            this.sukunimilabel = new System.Windows.Forms.Label();
            this.etunimilabel = new System.Windows.Forms.Label();
            this.henkilotunnuslabel = new System.Windows.Forms.Label();
            this.muokattavapostitoimipaikkakentta = new System.Windows.Forms.TextBox();
            this.muokattavapostinumerokentta = new System.Windows.Forms.TextBox();
            this.muokattavaosoitekentta = new System.Windows.Forms.TextBox();
            this.muokattavasukupuolikentta = new System.Windows.Forms.TextBox();
            this.muokattavasyntymapaivakentta = new System.Windows.Forms.TextBox();
            this.muokattavasukunimikentta = new System.Windows.Forms.TextBox();
            this.muokattavaetunimikentta = new System.Windows.Forms.TextBox();
            this.muokattavatunnuskentta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // muokattavasyntymavuosikentta
            // 
            this.muokattavasyntymavuosikentta.Location = new System.Drawing.Point(739, 154);
            this.muokattavasyntymavuosikentta.Name = "muokattavasyntymavuosikentta";
            this.muokattavasyntymavuosikentta.Size = new System.Drawing.Size(106, 22);
            this.muokattavasyntymavuosikentta.TabIndex = 41;
            // 
            // muokattavasyntymakuukausikentta
            // 
            this.muokattavasyntymakuukausikentta.Location = new System.Drawing.Point(597, 154);
            this.muokattavasyntymakuukausikentta.Name = "muokattavasyntymakuukausikentta";
            this.muokattavasyntymakuukausikentta.Size = new System.Drawing.Size(115, 22);
            this.muokattavasyntymakuukausikentta.TabIndex = 40;
            // 
            // muokkauslomakeilmoitustietopalkki
            // 
            this.muokkauslomakeilmoitustietopalkki.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.muokkauslomakeilmoitustietopalkki.Location = new System.Drawing.Point(51, 14);
            this.muokkauslomakeilmoitustietopalkki.Name = "muokkauslomakeilmoitustietopalkki";
            this.muokkauslomakeilmoitustietopalkki.ReadOnly = true;
            this.muokkauslomakeilmoitustietopalkki.Size = new System.Drawing.Size(674, 22);
            this.muokkauslomakeilmoitustietopalkki.TabIndex = 39;
            this.muokkauslomakeilmoitustietopalkki.Text = "Muokkaa tietoja alla";
            // 
            // vahvistamuokkauksetpainike
            // 
            this.vahvistamuokkauksetpainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vahvistamuokkauksetpainike.Location = new System.Drawing.Point(304, 347);
            this.vahvistamuokkauksetpainike.Name = "vahvistamuokkauksetpainike";
            this.vahvistamuokkauksetpainike.Size = new System.Drawing.Size(213, 66);
            this.vahvistamuokkauksetpainike.TabIndex = 23;
            this.vahvistamuokkauksetpainike.Text = "Vahvista henkilötietojen muokkaukset";
            this.vahvistamuokkauksetpainike.UseVisualStyleBackColor = true;
            this.vahvistamuokkauksetpainike.Click += new System.EventHandler(this.Vahvistamuokkauksetpainike_Click);
            // 
            // postitoimipaikkalabel
            // 
            this.postitoimipaikkalabel.AutoSize = true;
            this.postitoimipaikkalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postitoimipaikkalabel.Location = new System.Drawing.Point(41, 267);
            this.postitoimipaikkalabel.Name = "postitoimipaikkalabel";
            this.postitoimipaikkalabel.Size = new System.Drawing.Size(99, 13);
            this.postitoimipaikkalabel.TabIndex = 38;
            this.postitoimipaikkalabel.Text = "Postitoimipaikka";
            // 
            // postinumerolabel
            // 
            this.postinumerolabel.AutoSize = true;
            this.postinumerolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postinumerolabel.Location = new System.Drawing.Point(40, 239);
            this.postinumerolabel.Name = "postinumerolabel";
            this.postinumerolabel.Size = new System.Drawing.Size(76, 13);
            this.postinumerolabel.TabIndex = 37;
            this.postinumerolabel.Text = "Postinumero";
            // 
            // osoitelabel
            // 
            this.osoitelabel.AutoSize = true;
            this.osoitelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osoitelabel.Location = new System.Drawing.Point(41, 210);
            this.osoitelabel.Name = "osoitelabel";
            this.osoitelabel.Size = new System.Drawing.Size(43, 13);
            this.osoitelabel.TabIndex = 36;
            this.osoitelabel.Text = "Osoite";
            // 
            // sukupuolilabel
            // 
            this.sukupuolilabel.AutoSize = true;
            this.sukupuolilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukupuolilabel.Location = new System.Drawing.Point(41, 182);
            this.sukupuolilabel.Name = "sukupuolilabel";
            this.sukupuolilabel.Size = new System.Drawing.Size(63, 13);
            this.sukupuolilabel.TabIndex = 35;
            this.sukupuolilabel.Text = "Sukupuoli";
            // 
            // syntymaaikalabel
            // 
            this.syntymaaikalabel.AutoSize = true;
            this.syntymaaikalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syntymaaikalabel.Location = new System.Drawing.Point(42, 155);
            this.syntymaaikalabel.Name = "syntymaaikalabel";
            this.syntymaaikalabel.Size = new System.Drawing.Size(345, 13);
            this.syntymaaikalabel.TabIndex = 34;
            this.syntymaaikalabel.Text = "Syntymäaika (PP/KK/VVVV), ei nollia kuukausiin tai vuosiin";
            // 
            // sukunimilabel
            // 
            this.sukunimilabel.AutoSize = true;
            this.sukunimilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukunimilabel.Location = new System.Drawing.Point(44, 127);
            this.sukunimilabel.Name = "sukunimilabel";
            this.sukunimilabel.Size = new System.Drawing.Size(58, 13);
            this.sukunimilabel.TabIndex = 33;
            this.sukunimilabel.Text = "Sukunimi";
            // 
            // etunimilabel
            // 
            this.etunimilabel.AutoSize = true;
            this.etunimilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etunimilabel.Location = new System.Drawing.Point(45, 101);
            this.etunimilabel.Name = "etunimilabel";
            this.etunimilabel.Size = new System.Drawing.Size(48, 13);
            this.etunimilabel.TabIndex = 32;
            this.etunimilabel.Text = "Etunimi";
            // 
            // henkilotunnuslabel
            // 
            this.henkilotunnuslabel.AutoSize = true;
            this.henkilotunnuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.henkilotunnuslabel.Location = new System.Drawing.Point(45, 75);
            this.henkilotunnuslabel.Name = "henkilotunnuslabel";
            this.henkilotunnuslabel.Size = new System.Drawing.Size(88, 13);
            this.henkilotunnuslabel.TabIndex = 31;
            this.henkilotunnuslabel.Text = "Henkilötunnus";
            // 
            // muokattavapostitoimipaikkakentta
            // 
            this.muokattavapostitoimipaikkakentta.Location = new System.Drawing.Point(455, 266);
            this.muokattavapostitoimipaikkakentta.Name = "muokattavapostitoimipaikkakentta";
            this.muokattavapostitoimipaikkakentta.Size = new System.Drawing.Size(389, 22);
            this.muokattavapostitoimipaikkakentta.TabIndex = 30;
            // 
            // muokattavapostinumerokentta
            // 
            this.muokattavapostinumerokentta.Location = new System.Drawing.Point(455, 238);
            this.muokattavapostinumerokentta.Name = "muokattavapostinumerokentta";
            this.muokattavapostinumerokentta.Size = new System.Drawing.Size(389, 22);
            this.muokattavapostinumerokentta.TabIndex = 29;
            // 
            // muokattavaosoitekentta
            // 
            this.muokattavaosoitekentta.Location = new System.Drawing.Point(455, 210);
            this.muokattavaosoitekentta.Name = "muokattavaosoitekentta";
            this.muokattavaosoitekentta.Size = new System.Drawing.Size(390, 22);
            this.muokattavaosoitekentta.TabIndex = 28;
            // 
            // muokattavasukupuolikentta
            // 
            this.muokattavasukupuolikentta.Location = new System.Drawing.Point(455, 182);
            this.muokattavasukupuolikentta.Name = "muokattavasukupuolikentta";
            this.muokattavasukupuolikentta.Size = new System.Drawing.Size(389, 22);
            this.muokattavasukupuolikentta.TabIndex = 27;
            // 
            // muokattavasyntymapaivakentta
            // 
            this.muokattavasyntymapaivakentta.Location = new System.Drawing.Point(455, 154);
            this.muokattavasyntymapaivakentta.Name = "muokattavasyntymapaivakentta";
            this.muokattavasyntymapaivakentta.Size = new System.Drawing.Size(113, 22);
            this.muokattavasyntymapaivakentta.TabIndex = 26;
            // 
            // muokattavasukunimikentta
            // 
            this.muokattavasukunimikentta.Location = new System.Drawing.Point(455, 126);
            this.muokattavasukunimikentta.Name = "muokattavasukunimikentta";
            this.muokattavasukunimikentta.Size = new System.Drawing.Size(390, 22);
            this.muokattavasukunimikentta.TabIndex = 25;
            // 
            // muokattavaetunimikentta
            // 
            this.muokattavaetunimikentta.Location = new System.Drawing.Point(455, 98);
            this.muokattavaetunimikentta.Name = "muokattavaetunimikentta";
            this.muokattavaetunimikentta.Size = new System.Drawing.Size(390, 22);
            this.muokattavaetunimikentta.TabIndex = 24;
            // 
            // muokattavatunnuskentta
            // 
            this.muokattavatunnuskentta.Location = new System.Drawing.Point(455, 68);
            this.muokattavatunnuskentta.Name = "muokattavatunnuskentta";
            this.muokattavatunnuskentta.Size = new System.Drawing.Size(389, 22);
            this.muokattavatunnuskentta.TabIndex = 22;
            // 
            // Henkilötietojenmuokkauslomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.muokattavasyntymavuosikentta);
            this.Controls.Add(this.muokattavasyntymakuukausikentta);
            this.Controls.Add(this.muokkauslomakeilmoitustietopalkki);
            this.Controls.Add(this.vahvistamuokkauksetpainike);
            this.Controls.Add(this.postitoimipaikkalabel);
            this.Controls.Add(this.postinumerolabel);
            this.Controls.Add(this.osoitelabel);
            this.Controls.Add(this.sukupuolilabel);
            this.Controls.Add(this.syntymaaikalabel);
            this.Controls.Add(this.sukunimilabel);
            this.Controls.Add(this.etunimilabel);
            this.Controls.Add(this.henkilotunnuslabel);
            this.Controls.Add(this.muokattavapostitoimipaikkakentta);
            this.Controls.Add(this.muokattavapostinumerokentta);
            this.Controls.Add(this.muokattavaosoitekentta);
            this.Controls.Add(this.muokattavasukupuolikentta);
            this.Controls.Add(this.muokattavasyntymapaivakentta);
            this.Controls.Add(this.muokattavasukunimikentta);
            this.Controls.Add(this.muokattavaetunimikentta);
            this.Controls.Add(this.muokattavatunnuskentta);
            this.Name = "Henkilötietojenmuokkauslomake";
            this.Text = "Henkilötietojen muokkauslomake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox muokattavasyntymavuosikentta;
        private System.Windows.Forms.TextBox muokattavasyntymakuukausikentta;
        private System.Windows.Forms.TextBox muokkauslomakeilmoitustietopalkki;
        private System.Windows.Forms.Button vahvistamuokkauksetpainike;
        private System.Windows.Forms.Label postitoimipaikkalabel;
        private System.Windows.Forms.Label postinumerolabel;
        private System.Windows.Forms.Label osoitelabel;
        private System.Windows.Forms.Label sukupuolilabel;
        private System.Windows.Forms.Label syntymaaikalabel;
        private System.Windows.Forms.Label sukunimilabel;
        private System.Windows.Forms.Label etunimilabel;
        private System.Windows.Forms.Label henkilotunnuslabel;
        private System.Windows.Forms.TextBox muokattavapostitoimipaikkakentta;
        private System.Windows.Forms.TextBox muokattavapostinumerokentta;
        private System.Windows.Forms.TextBox muokattavaosoitekentta;
        private System.Windows.Forms.TextBox muokattavasukupuolikentta;
        private System.Windows.Forms.TextBox muokattavasyntymapaivakentta;
        private System.Windows.Forms.TextBox muokattavasukunimikentta;
        private System.Windows.Forms.TextBox muokattavaetunimikentta;
        private System.Windows.Forms.TextBox muokattavatunnuskentta;
    }
}