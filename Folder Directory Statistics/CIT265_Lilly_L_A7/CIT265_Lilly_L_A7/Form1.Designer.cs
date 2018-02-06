namespace CIT265_Lilly_L_A7
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
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtBoxDirectory = new System.Windows.Forms.TextBox();
            this.chkBoxDirectory = new System.Windows.Forms.CheckBox();
            this.lblCheckBoxDesc = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.txtBoxStats = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(504, 57);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "Browse";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtBoxDirectory
            // 
            this.txtBoxDirectory.Location = new System.Drawing.Point(74, 58);
            this.txtBoxDirectory.Name = "txtBoxDirectory";
            this.txtBoxDirectory.Size = new System.Drawing.Size(424, 22);
            this.txtBoxDirectory.TabIndex = 1;
            this.txtBoxDirectory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxDirectory_KeyDown);
            // 
            // chkBoxDirectory
            // 
            this.chkBoxDirectory.AutoSize = true;
            this.chkBoxDirectory.Location = new System.Drawing.Point(561, 91);
            this.chkBoxDirectory.Name = "chkBoxDirectory";
            this.chkBoxDirectory.Size = new System.Drawing.Size(18, 17);
            this.chkBoxDirectory.TabIndex = 2;
            this.chkBoxDirectory.UseVisualStyleBackColor = true;
            // 
            // lblCheckBoxDesc
            // 
            this.lblCheckBoxDesc.AutoSize = true;
            this.lblCheckBoxDesc.Location = new System.Drawing.Point(308, 91);
            this.lblCheckBoxDesc.Name = "lblCheckBoxDesc";
            this.lblCheckBoxDesc.Size = new System.Drawing.Size(247, 17);
            this.lblCheckBoxDesc.TabIndex = 3;
            this.lblCheckBoxDesc.Text = "Include Files/Folders in Subdirectories";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(240, 135);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(148, 20);
            this.lblStats.TabIndex = 4;
            this.lblStats.Text = "Folder Statistics";
            // 
            // txtBoxStats
            // 
            this.txtBoxStats.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxStats.Location = new System.Drawing.Point(74, 158);
            this.txtBoxStats.MinimumSize = new System.Drawing.Size(505, 227);
            this.txtBoxStats.Multiline = true;
            this.txtBoxStats.Name = "txtBoxStats";
            this.txtBoxStats.ReadOnly = true;
            this.txtBoxStats.Size = new System.Drawing.Size(505, 227);
            this.txtBoxStats.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(645, 396);
            this.Controls.Add(this.txtBoxStats);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblCheckBoxDesc);
            this.Controls.Add(this.chkBoxDirectory);
            this.Controls.Add(this.txtBoxDirectory);
            this.Controls.Add(this.btnBrowser);
            this.Name = "Form1";
            this.Text = "Directory Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtBoxDirectory;
        private System.Windows.Forms.CheckBox chkBoxDirectory;
        private System.Windows.Forms.Label lblCheckBoxDesc;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.TextBox txtBoxStats;
        
    }
}

