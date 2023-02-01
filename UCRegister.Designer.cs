namespace SzakTank2._0
{
    partial class UCRegister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBackR = new System.Windows.Forms.Button();
            this.btnRegR = new System.Windows.Forms.Button();
            this.tBRPassA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBRUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBRPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBYellow = new System.Windows.Forms.RadioButton();
            this.rBBlue = new System.Windows.Forms.RadioButton();
            this.rBRed = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackR
            // 
            this.btnBackR.Location = new System.Drawing.Point(390, 267);
            this.btnBackR.Name = "btnBackR";
            this.btnBackR.Size = new System.Drawing.Size(54, 23);
            this.btnBackR.TabIndex = 8;
            this.btnBackR.Text = "Vissza";
            this.btnBackR.UseVisualStyleBackColor = true;
            this.btnBackR.Click += new System.EventHandler(this.btnBackR_Click);
            // 
            // btnRegR
            // 
            this.btnRegR.Location = new System.Drawing.Point(248, 267);
            this.btnRegR.Name = "btnRegR";
            this.btnRegR.Size = new System.Drawing.Size(83, 23);
            this.btnRegR.TabIndex = 8;
            this.btnRegR.Text = "Regisztrálás";
            this.btnRegR.UseVisualStyleBackColor = true;
            this.btnRegR.Click += new System.EventHandler(this.btnRegR_Click);
            // 
            // tBRPassA
            // 
            this.tBRPassA.Location = new System.Drawing.Point(344, 197);
            this.tBRPassA.Name = "tBRPassA";
            this.tBRPassA.PasswordChar = '*';
            this.tBRPassA.Size = new System.Drawing.Size(100, 23);
            this.tBRPassA.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jelszó ismét:";
            // 
            // tBRUser
            // 
            this.tBRUser.Location = new System.Drawing.Point(344, 123);
            this.tBRUser.Name = "tBRUser";
            this.tBRUser.Size = new System.Drawing.Size(100, 23);
            this.tBRUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jelszó:";
            // 
            // tBRPass
            // 
            this.tBRPass.Location = new System.Drawing.Point(344, 161);
            this.tBRPass.Name = "tBRPass";
            this.tBRPass.PasswordChar = '*';
            this.tBRPass.Size = new System.Drawing.Size(100, 23);
            this.tBRPass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Szín:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBYellow);
            this.panel1.Controls.Add(this.rBBlue);
            this.panel1.Controls.Add(this.rBRed);
            this.panel1.Location = new System.Drawing.Point(285, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 39);
            this.panel1.TabIndex = 10;
            // 
            // rBYellow
            // 
            this.rBYellow.AutoSize = true;
            this.rBYellow.Location = new System.Drawing.Point(104, 11);
            this.rBYellow.Name = "rBYellow";
            this.rBYellow.Size = new System.Drawing.Size(54, 19);
            this.rBYellow.TabIndex = 2;
            this.rBYellow.Text = "Sárga";
            this.rBYellow.UseVisualStyleBackColor = true;
            // 
            // rBBlue
            // 
            this.rBBlue.AutoSize = true;
            this.rBBlue.Location = new System.Drawing.Point(54, 10);
            this.rBBlue.Name = "rBBlue";
            this.rBBlue.Size = new System.Drawing.Size(44, 19);
            this.rBBlue.TabIndex = 1;
            this.rBBlue.Text = "Kék";
            this.rBBlue.UseVisualStyleBackColor = true;
            // 
            // rBRed
            // 
            this.rBRed.AutoSize = true;
            this.rBRed.Checked = true;
            this.rBRed.Location = new System.Drawing.Point(3, 11);
            this.rBRed.Name = "rBRed";
            this.rBRed.Size = new System.Drawing.Size(51, 19);
            this.rBRed.TabIndex = 0;
            this.rBRed.TabStop = true;
            this.rBRed.Text = "Piros";
            this.rBRed.UseVisualStyleBackColor = true;
            // 
            // UCRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBackR);
            this.Controls.Add(this.btnRegR);
            this.Controls.Add(this.tBRPassA);
            this.Controls.Add(this.tBRPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBRUser);
            this.Controls.Add(this.label1);
            this.Name = "UCRegister";
            this.Size = new System.Drawing.Size(720, 480);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBackR;
        private Button btnRegR;
        private TextBox tBRPassA;
        private Label label3;
        private TextBox tBRUser;
        private Label label1;
        private Label label2;
        private TextBox tBRPass;
        private Label label4;
        private Panel panel1;
        private RadioButton rBYellow;
        private RadioButton rBBlue;
        private RadioButton rBRed;
    }
}
