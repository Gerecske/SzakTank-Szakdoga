namespace SzakTank2._0
{
    partial class UCLogin
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
            this.btnBackL = new System.Windows.Forms.Button();
            this.btnLoginL = new System.Windows.Forms.Button();
            this.tBLUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBLPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackL
            // 
            this.btnBackL.Location = new System.Drawing.Point(459, 252);
            this.btnBackL.Name = "btnBackL";
            this.btnBackL.Size = new System.Drawing.Size(54, 23);
            this.btnBackL.TabIndex = 7;
            this.btnBackL.Text = "Vissza";
            this.btnBackL.UseVisualStyleBackColor = true;
            this.btnBackL.Click += new System.EventHandler(this.btnBackL_Click);
            // 
            // btnLoginL
            // 
            this.btnLoginL.Location = new System.Drawing.Point(264, 239);
            this.btnLoginL.Name = "btnLoginL";
            this.btnLoginL.Size = new System.Drawing.Size(75, 23);
            this.btnLoginL.TabIndex = 6;
            this.btnLoginL.Text = "Bejelentkezés";
            this.btnLoginL.UseVisualStyleBackColor = true;
            this.btnLoginL.Click += new System.EventHandler(this.btnLoginL_Click);
            // 
            // tBLUser
            // 
            this.tBLUser.Location = new System.Drawing.Point(360, 162);
            this.tBLUser.Name = "tBLUser";
            this.tBLUser.Size = new System.Drawing.Size(100, 23);
            this.tBLUser.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Felhasználónév:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Jelszó:";
            // 
            // tBLPass
            // 
            this.tBLPass.Location = new System.Drawing.Point(360, 200);
            this.tBLPass.Name = "tBLPass";
            this.tBLPass.PasswordChar = '*';
            this.tBLPass.Size = new System.Drawing.Size(100, 23);
            this.tBLPass.TabIndex = 4;
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBackL);
            this.Controls.Add(this.btnLoginL);
            this.Controls.Add(this.tBLUser);
            this.Controls.Add(this.tBLPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(720, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBackL;
        private Button btnLoginL;
        private TextBox tBLUser;
        private Label label5;
        private Label label6;
        private TextBox tBLPass;
    }
}
