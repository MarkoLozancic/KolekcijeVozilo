namespace KolekcijeVozilo
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
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnispis = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.txtboxModel = new System.Windows.Forms.TextBox();
            this.txtboxGodProizvodnje = new System.Windows.Forms.TextBox();
            this.txtboxBrojKotaca = new System.Windows.Forms.TextBox();
            this.txtboxIspisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnObradi
            // 
            this.btnObradi.BackColor = System.Drawing.Color.Navy;
            this.btnObradi.Location = new System.Drawing.Point(202, 28);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(157, 76);
            this.btnObradi.TabIndex = 0;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = false;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnispis
            // 
            this.btnispis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnispis.Location = new System.Drawing.Point(645, 66);
            this.btnispis.Name = "btnispis";
            this.btnispis.Size = new System.Drawing.Size(143, 69);
            this.btnispis.TabIndex = 1;
            this.btnispis.Text = "Ispiši";
            this.btnispis.UseVisualStyleBackColor = false;
            this.btnispis.Click += new System.EventHandler(this.btnispis_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.Navy;
            this.btnUnesi.Location = new System.Drawing.Point(31, 281);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(123, 72);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtboxModel
            // 
            this.txtboxModel.Location = new System.Drawing.Point(33, 66);
            this.txtboxModel.Name = "txtboxModel";
            this.txtboxModel.Size = new System.Drawing.Size(100, 20);
            this.txtboxModel.TabIndex = 3;
            // 
            // txtboxGodProizvodnje
            // 
            this.txtboxGodProizvodnje.Location = new System.Drawing.Point(31, 141);
            this.txtboxGodProizvodnje.Name = "txtboxGodProizvodnje";
            this.txtboxGodProizvodnje.Size = new System.Drawing.Size(100, 20);
            this.txtboxGodProizvodnje.TabIndex = 4;
            // 
            // txtboxBrojKotaca
            // 
            this.txtboxBrojKotaca.Location = new System.Drawing.Point(33, 215);
            this.txtboxBrojKotaca.Name = "txtboxBrojKotaca";
            this.txtboxBrojKotaca.Size = new System.Drawing.Size(100, 20);
            this.txtboxBrojKotaca.TabIndex = 5;
            // 
            // txtboxIspisi
            // 
            this.txtboxIspisi.Location = new System.Drawing.Point(202, 141);
            this.txtboxIspisi.Multiline = true;
            this.txtboxIspisi.Name = "txtboxIspisi";
            this.txtboxIspisi.Size = new System.Drawing.Size(555, 279);
            this.txtboxIspisi.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Model vozila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Godina proizvodnje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Broj kotaca:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxIspisi);
            this.Controls.Add(this.txtboxBrojKotaca);
            this.Controls.Add(this.txtboxGodProizvodnje);
            this.Controls.Add(this.txtboxModel);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnispis);
            this.Controls.Add(this.btnObradi);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "ListaVozila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnispis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox txtboxModel;
        private System.Windows.Forms.TextBox txtboxGodProizvodnje;
        private System.Windows.Forms.TextBox txtboxBrojKotaca;
        private System.Windows.Forms.TextBox txtboxIspisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

