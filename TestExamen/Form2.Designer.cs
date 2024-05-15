
namespace TestExamen
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnInainteF2 = new System.Windows.Forms.Button();
            this.btnInapoiF2 = new System.Windows.Forms.Button();
            this.pictureBoxProiecte = new System.Windows.Forms.PictureBox();
            this.chekLiBoxProiecte = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProiecte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInainteF2
            // 
            this.btnInainteF2.Location = new System.Drawing.Point(680, 402);
            this.btnInainteF2.Name = "btnInainteF2";
            this.btnInainteF2.Size = new System.Drawing.Size(75, 23);
            this.btnInainteF2.TabIndex = 1;
            this.btnInainteF2.Text = "Inainte";
            this.btnInainteF2.UseVisualStyleBackColor = true;
            this.btnInainteF2.Click += new System.EventHandler(this.btnInainteF2_Click);
            // 
            // btnInapoiF2
            // 
            this.btnInapoiF2.Location = new System.Drawing.Point(539, 402);
            this.btnInapoiF2.Name = "btnInapoiF2";
            this.btnInapoiF2.Size = new System.Drawing.Size(75, 23);
            this.btnInapoiF2.TabIndex = 2;
            this.btnInapoiF2.Text = "Inapoi";
            this.btnInapoiF2.UseVisualStyleBackColor = true;
            this.btnInapoiF2.Click += new System.EventHandler(this.btnInapoiF2_Click);
            // 
            // pictureBoxProiecte
            // 
            this.pictureBoxProiecte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProiecte.BackgroundImage")));
            this.pictureBoxProiecte.Location = new System.Drawing.Point(329, 24);
            this.pictureBoxProiecte.Name = "pictureBoxProiecte";
            this.pictureBoxProiecte.Size = new System.Drawing.Size(426, 308);
            this.pictureBoxProiecte.TabIndex = 3;
            this.pictureBoxProiecte.TabStop = false;
            // 
            // chekLiBoxProiecte
            // 
            this.chekLiBoxProiecte.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chekLiBoxProiecte.CheckOnClick = true;
            this.chekLiBoxProiecte.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chekLiBoxProiecte.FormattingEnabled = true;
            this.chekLiBoxProiecte.Items.AddRange(new object[] {
            "Instalare panouri fotovoltaice",
            "Instalare pompe solare",
            "Instalare invertoare",
            "Mentenanta"});
            this.chekLiBoxProiecte.Location = new System.Drawing.Point(12, 24);
            this.chekLiBoxProiecte.Name = "chekLiBoxProiecte";
            this.chekLiBoxProiecte.Size = new System.Drawing.Size(311, 265);
            this.chekLiBoxProiecte.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 310);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chekLiBoxProiecte);
            this.Controls.Add(this.pictureBoxProiecte);
            this.Controls.Add(this.btnInapoiF2);
            this.Controls.Add(this.btnInainteF2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proiecte";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProiecte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInainteF2;
        private System.Windows.Forms.Button btnInapoiF2;
        private System.Windows.Forms.PictureBox pictureBoxProiecte;
        private System.Windows.Forms.CheckedListBox chekLiBoxProiecte;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}