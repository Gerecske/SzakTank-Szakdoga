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
            this.lblLUser = new System.Windows.Forms.Label();
            this.lblLPass = new System.Windows.Forms.Label();
            this.tBLPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackL
            // 
            this.btnBackL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackL.Location = new System.Drawing.Point(630, 430);
            this.btnBackL.Name = "btnBackL";
            this.btnBackL.Size = new System.Drawing.Size(90, 50);
            this.btnBackL.TabIndex = 7;
            this.btnBackL.Text = "Vissza";
            this.btnBackL.UseVisualStyleBackColor = true;
            this.btnBackL.Click += new System.EventHandler(this.btnBackL_Click);
            // 
            // btnLoginL
            // 
            this.btnLoginL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoginL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginL.Location = new System.Drawing.Point(0, 430);
            this.btnLoginL.Name = "btnLoginL";
            this.btnLoginL.Size = new System.Drawing.Size(90, 50);
            this.btnLoginL.TabIndex = 6;
            this.btnLoginL.Text = "Bejelentkezés";
            this.btnLoginL.UseVisualStyleBackColor = true;
            this.btnLoginL.Click += new System.EventHandler(this.btnLoginL_Click);
            // 
            // tBLUser
            // 
            this.tBLUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBLUser.Location = new System.Drawing.Point(360, 139);
            this.tBLUser.Name = "tBLUser";
            this.tBLUser.Size = new System.Drawing.Size(157, 39);
            this.tBLUser.TabIndex = 2;
            // 
            // lblLUser
            // 
            this.lblLUser.AutoSize = true;
            this.lblLUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLUser.Location = new System.Drawing.Point(172, 139);
            this.lblLUser.Name = "lblLUser";
            this.lblLUser.Size = new System.Drawing.Size(182, 32);
            this.lblLUser.TabIndex = 3;
            this.lblLUser.Text = "Felhasználónév:";
            // 
            // lblLPass
            // 
            this.lblLPass.AutoSize = true;
            this.lblLPass.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLPass.Location = new System.Drawing.Point(272, 186);
            this.lblLPass.Name = "lblLPass";
            this.lblLPass.Size = new System.Drawing.Size(82, 32);
            this.lblLPass.TabIndex = 5;
            this.lblLPass.Text = "Jelszó:";
            // 
            // tBLPass
            // 
            this.tBLPass.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBLPass.Location = new System.Drawing.Point(360, 186);
            this.tBLPass.Name = "tBLPass";
            this.tBLPass.PasswordChar = '*';
            this.tBLPass.Size = new System.Drawing.Size(157, 39);
            this.tBLPass.TabIndex = 4;
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btnBackL);
            this.Controls.Add(this.btnLoginL);
            this.Controls.Add(this.tBLUser);
            this.Controls.Add(this.tBLPass);
            this.Controls.Add(this.lblLUser);
            this.Controls.Add(this.lblLPass);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(720, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBackL;
        private Button btnLoginL;
        private TextBox tBLUser;
        private Label lblLUser;
        private Label lblLPass;
        private TextBox tBLPass;
    }
}
