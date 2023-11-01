namespace Week4ChallengeLab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.retxtNet = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.retxtSur = new System.Windows.Forms.TextBox();
            this.retxtAmt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblSur = new System.Windows.Forms.Label();
            this.lblAmt2 = new System.Windows.Forms.Label();
            this.lblNoSur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRedo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblexit = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(506, 368);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(100, 20);
            this.txtUnits.TabIndex = 0;
            this.txtUnits.TextChanged += new System.EventHandler(this.txtUnits_TextChanged);
            this.txtUnits.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnits_Validating);
            // 
            // retxtNet
            // 
            this.retxtNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retxtNet.ForeColor = System.Drawing.Color.Red;
            this.retxtNet.Location = new System.Drawing.Point(153, 164);
            this.retxtNet.Name = "retxtNet";
            this.retxtNet.ReadOnly = true;
            this.retxtNet.Size = new System.Drawing.Size(100, 26);
            this.retxtNet.TabIndex = 1;
            this.retxtNet.TextChanged += new System.EventHandler(this.retxtNet_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(519, 404);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate!";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // retxtSur
            // 
            this.retxtSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retxtSur.Location = new System.Drawing.Point(153, 132);
            this.retxtSur.Name = "retxtSur";
            this.retxtSur.ReadOnly = true;
            this.retxtSur.Size = new System.Drawing.Size(100, 26);
            this.retxtSur.TabIndex = 3;
            this.retxtSur.TextChanged += new System.EventHandler(this.retxtSur_TextChanged);
            this.retxtSur.Validating += new System.ComponentModel.CancelEventHandler(this.retxtSur_Validating);
            // 
            // retxtAmt
            // 
            this.retxtAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retxtAmt.Location = new System.Drawing.Point(153, 100);
            this.retxtAmt.Name = "retxtAmt";
            this.retxtAmt.ReadOnly = true;
            this.retxtAmt.Size = new System.Drawing.Size(100, 26);
            this.retxtAmt.TabIndex = 4;
            this.retxtAmt.TextChanged += new System.EventHandler(this.retxtAmt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblNoSur);
            this.groupBox1.Controls.Add(this.lblAmt2);
            this.groupBox1.Controls.Add(this.lblSur);
            this.groupBox1.Controls.Add(this.lblNet);
            this.groupBox1.Controls.Add(this.retxtAmt);
            this.groupBox1.Controls.Add(this.retxtSur);
            this.groupBox1.Controls.Add(this.retxtNet);
            this.groupBox1.Location = new System.Drawing.Point(258, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 278);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseCompatibleTextRendering = true;
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(890, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 47.99999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(45, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1049, 77);
            this.label1.TabIndex = 9;
            this.label1.Text = "PAY YOUR ELECTRIC BILL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(355, 113);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(398, 224);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 10;
            this.pb1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(483, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "kW⋅h Consumed:";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.ForeColor = System.Drawing.Color.White;
            this.lblNet.Location = new System.Drawing.Point(6, 169);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(141, 16);
            this.lblNet.TabIndex = 5;
            this.lblNet.Text = "Net amount to be paid:";
            this.lblNet.Click += new System.EventHandler(this.lblNet_Click);
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSur.ForeColor = System.Drawing.Color.White;
            this.lblSur.Location = new System.Drawing.Point(75, 138);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(72, 16);
            this.lblSur.TabIndex = 6;
            this.lblSur.Text = "Surcharge:";
            this.lblSur.Click += new System.EventHandler(this.lblSur_Click);
            // 
            // lblAmt2
            // 
            this.lblAmt2.AutoSize = true;
            this.lblAmt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmt2.ForeColor = System.Drawing.Color.White;
            this.lblAmt2.Location = new System.Drawing.Point(38, 106);
            this.lblAmt2.Name = "lblAmt2";
            this.lblAmt2.Size = new System.Drawing.Size(109, 16);
            this.lblAmt2.TabIndex = 7;
            this.lblAmt2.Text = "Amount Charges:";
            // 
            // lblNoSur
            // 
            this.lblNoSur.AutoSize = true;
            this.lblNoSur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblNoSur.ForeColor = System.Drawing.Color.White;
            this.lblNoSur.Location = new System.Drawing.Point(6, 221);
            this.lblNoSur.Name = "lblNoSur";
            this.lblNoSur.Size = new System.Drawing.Size(370, 18);
            this.lblNoSur.TabIndex = 8;
            this.lblNoSur.Text = "Congrats! You don\'t have to pay a surcharge...this time.";
            this.lblNoSur.Click += new System.EventHandler(this.lblNoSur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 11);
            this.label3.TabIndex = 9;
            this.label3.Text = "WARNING: NONPAYMENT RESULTS IN IMMEDIATE POWER REMOVAL!";
            // 
            // btnRedo
            // 
            this.btnRedo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.Location = new System.Drawing.Point(938, 545);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(142, 37);
            this.btnRedo.TabIndex = 12;
            this.btnRedo.Text = "RE-CALCULATE!";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(901, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "Make an Error?\r\nPress Here to Re-Calculate.\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblexit
            // 
            this.lblexit.AutoSize = true;
            this.lblexit.BackColor = System.Drawing.Color.Transparent;
            this.lblexit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexit.ForeColor = System.Drawing.Color.White;
            this.lblexit.Location = new System.Drawing.Point(12, 458);
            this.lblexit.Name = "lblexit";
            this.lblexit.Size = new System.Drawing.Size(228, 84);
            this.lblexit.TabIndex = 14;
            this.lblexit.Text = "Have a suggestion?\r\nWant to leave a review?\r\nPress Here to pull up our \r\ncustomer" +
    " satisfaction survey!";
            this.lblexit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(58, 545);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(135, 37);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "Leave a Review";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 658);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblexit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.TextBox retxtNet;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox retxtSur;
        private System.Windows.Forms.TextBox retxtAmt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmt2;
        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblNoSur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblexit;
        private System.Windows.Forms.Button btnexit;
    }
}

