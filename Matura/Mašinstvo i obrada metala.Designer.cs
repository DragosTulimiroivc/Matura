﻿namespace Matura
{
    partial class Mašinstvo_i_obrada_metala
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Dalje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mašinstvo i obrada meatala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Predmet";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Brodomašinski tehničar",
            "Mašinski tehničar za kompjutersko konstruisanje",
            "Mašinski tehničar merne i regulacione tehnike",
            "Mašinski tehničar motornih vozila",
            "Tehničar grejanja i klimatizacije",
            "Tehničar za kompjutersko upravljanje (CNC) mašina",
            "Tehničar za robotiku",
            "Tehničar mašinske energetike",
            "Tehničar optike"});
            this.comboBox1.Location = new System.Drawing.Point(82, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Dalje
            // 
            this.Dalje.Location = new System.Drawing.Point(368, 299);
            this.Dalje.Name = "Dalje";
            this.Dalje.Size = new System.Drawing.Size(75, 23);
            this.Dalje.TabIndex = 12;
            this.Dalje.Text = "Dalje";
            this.Dalje.UseVisualStyleBackColor = true;
            this.Dalje.Click += new System.EventHandler(this.Dalje_Click);
            // 
            // Mašinstvo_i_obrada_metala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 334);
            this.Controls.Add(this.Dalje);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mašinstvo_i_obrada_metala";
            this.Text = "Mašinstvo_i_obrada_metala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Dalje;
    }
}