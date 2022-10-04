
namespace Ex2b
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCanada = new System.Windows.Forms.TextBox();
            this.txtUK = new System.Windows.Forms.TextBox();
            this.txtJapan = new System.Windows.Forms.TextBox();
            this.txtEurope = new System.Windows.Forms.TextBox();
            this.txtRateCanada = new System.Windows.Forms.TextBox();
            this.txtRateUK = new System.Windows.Forms.TextBox();
            this.txtRateJapan = new System.Windows.Forms.TextBox();
            this.txtRateEurope = new System.Windows.Forms.TextBox();
            this.txtConvert1 = new System.Windows.Forms.TextBox();
            this.txtConvert2 = new System.Windows.Forms.TextBox();
            this.txtConvert3 = new System.Windows.Forms.TextBox();
            this.txtConvert4 = new System.Windows.Forms.TextBox();
            this.txtTotalUS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCanada = new System.Windows.Forms.Button();
            this.btnUK = new System.Windows.Forms.Button();
            this.btnJapan = new System.Windows.Forms.Button();
            this.btnEurope = new System.Windows.Forms.Button();
            this.btnUS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "$US";
            // 
            // txtCanada
            // 
            this.txtCanada.Location = new System.Drawing.Point(167, 151);
            this.txtCanada.Name = "txtCanada";
            this.txtCanada.Size = new System.Drawing.Size(100, 23);
            this.txtCanada.TabIndex = 3;
            this.txtCanada.Text = "0.00";
            this.txtCanada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCanada.TextChanged += new System.EventHandler(this.txtCanada_TextChanged);
            // 
            // txtUK
            // 
            this.txtUK.Location = new System.Drawing.Point(283, 151);
            this.txtUK.Name = "txtUK";
            this.txtUK.Size = new System.Drawing.Size(100, 23);
            this.txtUK.TabIndex = 4;
            this.txtUK.Text = "0.00";
            this.txtUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUK.TextChanged += new System.EventHandler(this.txtUK_TextChanged);
            // 
            // txtJapan
            // 
            this.txtJapan.Location = new System.Drawing.Point(401, 151);
            this.txtJapan.Name = "txtJapan";
            this.txtJapan.Size = new System.Drawing.Size(100, 23);
            this.txtJapan.TabIndex = 5;
            this.txtJapan.Text = "0.00";
            this.txtJapan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJapan.TextChanged += new System.EventHandler(this.txtJapan_TextChanged);
            // 
            // txtEurope
            // 
            this.txtEurope.Location = new System.Drawing.Point(517, 151);
            this.txtEurope.Name = "txtEurope";
            this.txtEurope.Size = new System.Drawing.Size(100, 23);
            this.txtEurope.TabIndex = 6;
            this.txtEurope.Text = "0.00";
            this.txtEurope.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEurope.TextChanged += new System.EventHandler(this.txtEurope_TextChanged);
            // 
            // txtRateCanada
            // 
            this.txtRateCanada.Location = new System.Drawing.Point(167, 206);
            this.txtRateCanada.Name = "txtRateCanada";
            this.txtRateCanada.Size = new System.Drawing.Size(100, 23);
            this.txtRateCanada.TabIndex = 7;
            this.txtRateCanada.Text = "0.76140989";
            this.txtRateCanada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateUK
            // 
            this.txtRateUK.Location = new System.Drawing.Point(283, 206);
            this.txtRateUK.Name = "txtRateUK";
            this.txtRateUK.Size = new System.Drawing.Size(100, 23);
            this.txtRateUK.TabIndex = 8;
            this.txtRateUK.Text = "1.1511001";
            this.txtRateUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateJapan
            // 
            this.txtRateJapan.Location = new System.Drawing.Point(401, 206);
            this.txtRateJapan.Name = "txtRateJapan";
            this.txtRateJapan.Size = new System.Drawing.Size(100, 23);
            this.txtRateJapan.TabIndex = 9;
            this.txtRateJapan.Text = "0.007131922";
            this.txtRateJapan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateEurope
            // 
            this.txtRateEurope.Location = new System.Drawing.Point(517, 206);
            this.txtRateEurope.Name = "txtRateEurope";
            this.txtRateEurope.Size = new System.Drawing.Size(100, 23);
            this.txtRateEurope.TabIndex = 10;
            this.txtRateEurope.Text = "0.99535511";
            this.txtRateEurope.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConvert1
            // 
            this.txtConvert1.Location = new System.Drawing.Point(167, 267);
            this.txtConvert1.Name = "txtConvert1";
            this.txtConvert1.Size = new System.Drawing.Size(100, 23);
            this.txtConvert1.TabIndex = 11;
            this.txtConvert1.Text = "0.00";
            this.txtConvert1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConvert2
            // 
            this.txtConvert2.Location = new System.Drawing.Point(283, 267);
            this.txtConvert2.Name = "txtConvert2";
            this.txtConvert2.Size = new System.Drawing.Size(100, 23);
            this.txtConvert2.TabIndex = 12;
            this.txtConvert2.Text = "0.00";
            this.txtConvert2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConvert3
            // 
            this.txtConvert3.Location = new System.Drawing.Point(401, 267);
            this.txtConvert3.Name = "txtConvert3";
            this.txtConvert3.Size = new System.Drawing.Size(100, 23);
            this.txtConvert3.TabIndex = 13;
            this.txtConvert3.Text = "0.00";
            this.txtConvert3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConvert4
            // 
            this.txtConvert4.Location = new System.Drawing.Point(517, 267);
            this.txtConvert4.Name = "txtConvert4";
            this.txtConvert4.Size = new System.Drawing.Size(100, 23);
            this.txtConvert4.TabIndex = 14;
            this.txtConvert4.Text = "0.00";
            this.txtConvert4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalUS
            // 
            this.txtTotalUS.Location = new System.Drawing.Point(675, 267);
            this.txtTotalUS.Name = "txtTotalUS";
            this.txtTotalUS.Size = new System.Drawing.Size(100, 23);
            this.txtTotalUS.TabIndex = 15;
            this.txtTotalUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalUS.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "=";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(283, 340);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(426, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCanada
            // 
            this.btnCanada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCanada.BackgroundImage")));
            this.btnCanada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCanada.Location = new System.Drawing.Point(167, 23);
            this.btnCanada.Name = "btnCanada";
            this.btnCanada.Size = new System.Drawing.Size(100, 76);
            this.btnCanada.TabIndex = 19;
            this.btnCanada.Text = "Canadian Dollar";
            this.btnCanada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCanada.UseVisualStyleBackColor = true;
            // 
            // btnUK
            // 
            this.btnUK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUK.BackgroundImage")));
            this.btnUK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUK.Location = new System.Drawing.Point(283, 23);
            this.btnUK.Name = "btnUK";
            this.btnUK.Size = new System.Drawing.Size(100, 76);
            this.btnUK.TabIndex = 20;
            this.btnUK.Text = "Pound";
            this.btnUK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUK.UseVisualStyleBackColor = true;
            // 
            // btnJapan
            // 
            this.btnJapan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJapan.BackgroundImage")));
            this.btnJapan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJapan.Location = new System.Drawing.Point(401, 23);
            this.btnJapan.Name = "btnJapan";
            this.btnJapan.Size = new System.Drawing.Size(100, 76);
            this.btnJapan.TabIndex = 21;
            this.btnJapan.Text = "Yen";
            this.btnJapan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJapan.UseVisualStyleBackColor = true;
            // 
            // btnEurope
            // 
            this.btnEurope.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEurope.BackgroundImage")));
            this.btnEurope.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEurope.Location = new System.Drawing.Point(517, 23);
            this.btnEurope.Name = "btnEurope";
            this.btnEurope.Size = new System.Drawing.Size(100, 76);
            this.btnEurope.TabIndex = 22;
            this.btnEurope.Text = "Euro";
            this.btnEurope.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEurope.UseVisualStyleBackColor = true;
            // 
            // btnUS
            // 
            this.btnUS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUS.BackgroundImage")));
            this.btnUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUS.Location = new System.Drawing.Point(639, 90);
            this.btnUS.Name = "btnUS";
            this.btnUS.Size = new System.Drawing.Size(158, 139);
            this.btnUS.TabIndex = 23;
            this.btnUS.Text = "US";
            this.btnUS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUS);
            this.Controls.Add(this.btnEurope);
            this.Controls.Add(this.btnJapan);
            this.Controls.Add(this.btnUK);
            this.Controls.Add(this.btnCanada);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalUS);
            this.Controls.Add(this.txtConvert4);
            this.Controls.Add(this.txtConvert3);
            this.Controls.Add(this.txtConvert2);
            this.Controls.Add(this.txtConvert1);
            this.Controls.Add(this.txtRateEurope);
            this.Controls.Add(this.txtRateJapan);
            this.Controls.Add(this.txtRateUK);
            this.Controls.Add(this.txtRateCanada);
            this.Controls.Add(this.txtEurope);
            this.Controls.Add(this.txtJapan);
            this.Controls.Add(this.txtUK);
            this.Controls.Add(this.txtCanada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCanada;
        private System.Windows.Forms.TextBox txtUK;
        private System.Windows.Forms.TextBox txtJapan;
        private System.Windows.Forms.TextBox txtEurope;
        private System.Windows.Forms.TextBox txtRateCanada;
        private System.Windows.Forms.TextBox txtRateUK;
        private System.Windows.Forms.TextBox txtRateJapan;
        private System.Windows.Forms.TextBox txtRateEurope;
        private System.Windows.Forms.TextBox txtConvert1;
        private System.Windows.Forms.TextBox txtConvert2;
        private System.Windows.Forms.TextBox txtConvert3;
        private System.Windows.Forms.TextBox txtConvert4;
        private System.Windows.Forms.TextBox txtTotalUS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCanada;
        private System.Windows.Forms.Button btnUK;
        private System.Windows.Forms.Button btnJapan;
        private System.Windows.Forms.Button btnEurope;
        private System.Windows.Forms.Button btnUS;
    }
}

