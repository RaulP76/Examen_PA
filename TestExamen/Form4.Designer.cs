
namespace TestExamen
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.radioBtnPlata1 = new System.Windows.Forms.RadioButton();
            this.radioBtnPlata2 = new System.Windows.Forms.RadioButton();
            this.lbPlata = new System.Windows.Forms.Label();
            this.pictureBoxFinal = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalveaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveaza.Location = new System.Drawing.Point(419, 381);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(346, 40);
            this.btnSalveaza.TabIndex = 0;
            this.btnSalveaza.Text = "Salveaza si inchide";
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrint.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(625, 35);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 126);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Printeaza";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // radioBtnPlata1
            // 
            this.radioBtnPlata1.AutoSize = true;
            this.radioBtnPlata1.Location = new System.Drawing.Point(27, 33);
            this.radioBtnPlata1.Name = "radioBtnPlata1";
            this.radioBtnPlata1.Size = new System.Drawing.Size(76, 24);
            this.radioBtnPlata1.TabIndex = 2;
            this.radioBtnPlata1.TabStop = true;
            this.radioBtnPlata1.Text = "Avans";
            this.radioBtnPlata1.UseVisualStyleBackColor = true;
            // 
            // radioBtnPlata2
            // 
            this.radioBtnPlata2.AutoSize = true;
            this.radioBtnPlata2.Location = new System.Drawing.Point(27, 60);
            this.radioBtnPlata2.Name = "radioBtnPlata2";
            this.radioBtnPlata2.Size = new System.Drawing.Size(85, 24);
            this.radioBtnPlata2.TabIndex = 3;
            this.radioBtnPlata2.TabStop = true;
            this.radioBtnPlata2.Text = "Integral";
            this.radioBtnPlata2.UseVisualStyleBackColor = true;
            // 
            // lbPlata
            // 
            this.lbPlata.AutoSize = true;
            this.lbPlata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlata.Location = new System.Drawing.Point(60, 35);
            this.lbPlata.Name = "lbPlata";
            this.lbPlata.Size = new System.Drawing.Size(56, 25);
            this.lbPlata.TabIndex = 4;
            this.lbPlata.Text = "Plata";
            // 
            // pictureBoxFinal
            // 
            this.pictureBoxFinal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFinal.BackgroundImage")));
            this.pictureBoxFinal.Location = new System.Drawing.Point(247, 65);
            this.pictureBoxFinal.Name = "pictureBoxFinal";
            this.pictureBoxFinal.Size = new System.Drawing.Size(372, 232);
            this.pictureBoxFinal.TabIndex = 5;
            this.pictureBoxFinal.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnPlata2);
            this.groupBox1.Controls.Add(this.radioBtnPlata1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Achitat";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 111);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facturat";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nu";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Da";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxFinal);
            this.Controls.Add(this.lbPlata);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSalveaza);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizare";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton radioBtnPlata1;
        private System.Windows.Forms.RadioButton radioBtnPlata2;
        private System.Windows.Forms.Label lbPlata;
        private System.Windows.Forms.PictureBox pictureBoxFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}