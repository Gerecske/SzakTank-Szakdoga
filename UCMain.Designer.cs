namespace SzakTank2._0
{
    partial class UCMain
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
            this.tLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.fLPMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnRunCode = new System.Windows.Forms.Button();
            this.lblCodeHeader = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tLP = new System.Windows.Forms.TableLayoutPanel();
            this.tLPStats = new System.Windows.Forms.TableLayoutPanel();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.tLPMain.SuspendLayout();
            this.tLP.SuspendLayout();
            this.tLPStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPMain
            // 
            this.tLPMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLPMain.ColumnCount = 2;
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tLPMain.Location = new System.Drawing.Point(0, 0);
            this.tLPMain.Name = "tLPMain";
            this.tLPMain.RowCount = 2;
            this.tLPMain.Size = new System.Drawing.Size(200, 100);
            this.tLPMain.TabIndex = 0;
            // 
            // fLPMain
            // 
            this.fLPMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fLPMain.Location = new System.Drawing.Point(291, 46);
            this.fLPMain.Name = "fLPMain";
            this.fLPMain.Size = new System.Drawing.Size(426, 387);
            this.fLPMain.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(291, 436);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 3;
            // 
            // btnRunCode
            // 
            this.btnRunCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunCode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRunCode.Location = new System.Drawing.Point(3, 439);
            this.btnRunCode.Name = "btnRunCode";
            this.btnRunCode.Size = new System.Drawing.Size(282, 38);
            this.btnRunCode.TabIndex = 2;
            this.btnRunCode.Text = "Futtatás";
            this.btnRunCode.UseVisualStyleBackColor = true;
            this.btnRunCode.Click += new System.EventHandler(this.btnRunCodeClick);
            // 
            // lblCodeHeader
            // 
            this.lblCodeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodeHeader.AutoSize = true;
            this.lblCodeHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodeHeader.Location = new System.Drawing.Point(3, 0);
            this.lblCodeHeader.Name = "lblCodeHeader";
            this.lblCodeHeader.Size = new System.Drawing.Size(282, 43);
            this.lblCodeHeader.TabIndex = 1;
            this.lblCodeHeader.Text = "Kód:";
            // 
            // tbCode
            // 
            this.tbCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCode.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbCode.ForeColor = System.Drawing.Color.Black;
            this.tbCode.Location = new System.Drawing.Point(3, 46);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(282, 387);
            this.tbCode.TabIndex = 0;
            // 
            // tLP
            // 
            this.tLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tLP.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tLP.ColumnCount = 2;
            this.tLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tLP.Controls.Add(this.tbCode, 0, 1);
            this.tLP.Controls.Add(this.lblCodeHeader, 0, 0);
            this.tLP.Controls.Add(this.lblError, 1, 2);
            this.tLP.Controls.Add(this.fLPMain, 1, 1);
            this.tLP.Controls.Add(this.tLPStats, 1, 0);
            this.tLP.Controls.Add(this.btnRunCode, 0, 2);
            this.tLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP.Location = new System.Drawing.Point(0, 0);
            this.tLP.Name = "tLP";
            this.tLP.RowCount = 3;
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP.Size = new System.Drawing.Size(720, 480);
            this.tLP.TabIndex = 2;
            // 
            // tLPStats
            // 
            this.tLPStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLPStats.ColumnCount = 2;
            this.tLPStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPStats.Controls.Add(this.lblPoints, 0, 0);
            this.tLPStats.Controls.Add(this.lblMoves, 1, 0);
            this.tLPStats.Location = new System.Drawing.Point(291, 3);
            this.tLPStats.Name = "tLPStats";
            this.tLPStats.RowCount = 1;
            this.tLPStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPStats.Size = new System.Drawing.Size(426, 37);
            this.tLPStats.TabIndex = 5;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPoints.Location = new System.Drawing.Point(3, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(93, 32);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "Pontok:";
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoves.Location = new System.Drawing.Point(216, 0);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(105, 32);
            this.lblMoves.TabIndex = 6;
            this.lblMoves.Text = "Lépések:";
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tLP);
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(720, 480);
            this.tLPMain.ResumeLayout(false);
            this.tLPMain.PerformLayout();
            this.tLP.ResumeLayout(false);
            this.tLP.PerformLayout();
            this.tLPStats.ResumeLayout(false);
            this.tLPStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tLPMain;
        private FlowLayoutPanel fLPMain;
        private Label lblError;
        private Button btnRunCode;
        private Label lblCodeHeader;
        private TextBox tbCode;
        private TableLayoutPanel tLP;
        private Label lblPoints;
        private TableLayoutPanel tLPStats;
        private Label lblMoves;
    }
}
