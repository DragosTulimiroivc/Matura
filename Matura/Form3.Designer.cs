namespace Matura
{
    partial class Stručni
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Dalje2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite struku";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Poljoprivreda, proizvodnja i prerada hrane",
            "Šumarstvo i obrada drveta",
            "Geologija, rudarstvo i metalurgija",
            "Mašinstvo i obrada metala",
            "Elektrotehnika",
            "Hemija, nemetali i grafičarstvo",
            "Tekstilstvo i kožarstvo",
            "Geodezija i građevinarstvo",
            "Saobraćaj",
            "Trgovina, ugostiteljstvo i turizam",
            "Ekonomija, pravo i administracija",
            "Zdravstvo i socijalna zaštita",
            "Lične usluge"});
            this.comboBox1.Location = new System.Drawing.Point(206, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Dalje2
            // 
            this.Dalje2.Location = new System.Drawing.Point(594, 171);
            this.Dalje2.Name = "Dalje2";
            this.Dalje2.Size = new System.Drawing.Size(75, 23);
            this.Dalje2.TabIndex = 3;
            this.Dalje2.Text = "Dalje";
            this.Dalje2.UseVisualStyleBackColor = true;
            this.Dalje2.Click += new System.EventHandler(this.Dalje2_Click);
            // 
            // Stručni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 210);
            this.Controls.Add(this.Dalje2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Stručni";
            this.Text = "Stručni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Dalje2;
    }
}