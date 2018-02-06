namespace BF1_Stats
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
        /// this.txtPlayerName.AutoSize = false;
        /// this.txtPlayerName.Size = new System.Drawing.Size(281, 21);
        /// 
        ///         private void InitializeComponent()
        /// {
        /// this.tabControlMain = new BF1_Stats.TabControlCustom();
        /// this.tabPage1 = new System.Windows.Forms.TabPage();
        /// this.panelSearch = new System.Windows.Forms.Panel();
        /// this.cbxPlatform = new System.Windows.Forms.ComboBox();
        /// this.txtResults = new System.Windows.Forms.TextBox();
        /// this.txtPlayerName = new System.Windows.Forms.TextBox();
        /// this.btnSubmit = new System.Windows.Forms.Button();
        /// this.tabPage2 = new System.Windows.Forms.TabPage();
        /// this.panelPlayerStats = new System.Windows.Forms.Panel();
        /// this.pbxSkill = new System.Windows.Forms.PictureBox();
        /// this.pbxWL = new System.Windows.Forms.PictureBox();
        /// this.pbxKPM = new System.Windows.Forms.PictureBox();
        /// this.pbxSPM = new System.Windows.Forms.PictureBox();
        /// this.pbxKD = new System.Windows.Forms.PictureBox();
        /// this.lblLossesSTATIC = new System.Windows.Forms.Label();
        /// this.lblWinsSTATIC = new System.Windows.Forms.Label();
        /// this.lblDefendsSTATIC = new System.Windows.Forms.Label();
        /// this.lblCapturesSTATIC = new System.Windows.Forms.Label();
        /// this.lblAccuracySTATIC = new System.Windows.Forms.Label();
        /// this.lblSkillSTATIC = new System.Windows.Forms.Label();
        /// this.lblWLSTATIC = new System.Windows.Forms.Label();
        /// this.lblKPMSTATIC = new System.Windows.Forms.Label();
        /// this.lblSPMSTATIC = new System.Windows.Forms.Label();
        /// this.lblKDSTATIC = new System.Windows.Forms.Label();
        /// this.lblDeathsSTATIC = new System.Windows.Forms.Label();
        /// this.lblKillsSTATIC = new System.Windows.Forms.Label();
        /// this.lblAccuracy = new System.Windows.Forms.Label();
        /// this.lblSkill = new System.Windows.Forms.Label();
        /// this.lblWL = new System.Windows.Forms.Label();
        /// this.lblLosses = new System.Windows.Forms.Label();
        /// this.lblWins = new System.Windows.Forms.Label();
        /// this.lblDefends = new System.Windows.Forms.Label();
        /// this.lblCaptures = new System.Windows.Forms.Label();
        /// this.lblKPM = new System.Windows.Forms.Label();
        /// this.lblSPM = new System.Windows.Forms.Label();
        /// this.lblBestClass = new System.Windows.Forms.Label();
        /// this.lblBestClassSTATIC = new System.Windows.Forms.Label();
        /// this.lblKD = new System.Windows.Forms.Label();
        /// this.lblDeaths = new System.Windows.Forms.Label();
        /// this.lblKills = new System.Windows.Forms.Label();
        /// this.lblNameSTATIC = new System.Windows.Forms.Label();
        /// this.btnBackToSearch = new System.Windows.Forms.Button();
        /// this.tabControlMain.SuspendLayout();
        /// this.tabPage1.SuspendLayout();
        /// this.panelSearch.SuspendLayout();
        /// this.tabPage2.SuspendLayout();
        /// this.panelPlayerStats.SuspendLayout();
        /// ((System.ComponentModel.ISupportInitialize)(this.pbxSkill)).BeginInit();
        /// ((System.ComponentModel.ISupportInitialize)(this.pbxWL)).BeginInit();
        /// ((System.ComponentModel.ISupportInitialize)(this.pbxKPM)).BeginInit();
        /// ((System.ComponentModel.ISupportInitialize)(this.pbxSPM)).BeginInit();
        /// ((System.ComponentModel.ISupportInitialize)(this.pbxKD)).BeginInit();
        /// this.SuspendLayout();
        /// // 
        /// // tabControlMain
        /// // 
        /// this.tabControlMain.Controls.Add(this.tabPage1);
        /// this.tabControlMain.Controls.Add(this.tabPage2);
        /// this.tabControlMain.Location = new System.Drawing.Point(9, 2);
        /// this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
        /// this.tabControlMain.Name = "tabControlMain";
        /// this.tabControlMain.SelectedIndex = 0;
        /// this.tabControlMain.Size = new System.Drawing.Size(568, 447);
        /// this.tabControlMain.TabIndex = 5;
        /// // 
        /// // tabPage1
        /// // 
        /// this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
        /// this.tabPage1.Controls.Add(this.panelSearch);
        /// this.tabPage1.Location = new System.Drawing.Point(4, 22);
        /// this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
        /// this.tabPage1.Name = "tabPage1";
        /// this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
        /// this.tabPage1.Size = new System.Drawing.Size(560, 421);
        /// this.tabPage1.TabIndex = 0;
        /// this.tabPage1.Text = "tabPage1";
        /// this.tabPage1.UseVisualStyleBackColor = true;
        /// // 
        /// // panelSearch
        /// // 
        /// this.panelSearch.Controls.Add(this.cbxPlatform);
        /// this.panelSearch.Controls.Add(this.txtResults);
        /// this.panelSearch.Controls.Add(this.txtPlayerName);
        /// this.panelSearch.Controls.Add(this.btnSubmit);
        /// this.panelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
        /// this.panelSearch.Location = new System.Drawing.Point(-8, 0);
        /// this.panelSearch.Name = "panelSearch";
        /// this.panelSearch.Size = new System.Drawing.Size(590, 427);
        /// this.panelSearch.TabIndex = 4;
        /// this.panelSearch.VisibleChanged += new System.EventHandler(this.panelSearch_VisibleChanged);
        /// // 
        /// // cbxPlatform
        /// // 
        /// this.cbxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        /// this.cbxPlatform.FormattingEnabled = true;
        /// this.cbxPlatform.Items.AddRange(new object[] {
        /// "Xbox",
        /// "Playstation",
        /// "PC"});
        /// this.cbxPlatform.Location = new System.Drawing.Point(383, 103);
        /// this.cbxPlatform.Margin = new System.Windows.Forms.Padding(2);
        /// this.cbxPlatform.Name = "cbxPlatform";
        /// this.cbxPlatform.Size = new System.Drawing.Size(92, 21);
        /// this.cbxPlatform.TabIndex = 2;
        /// // 
        /// // txtResults
        /// // 
        /// this.txtResults.Location = new System.Drawing.Point(53, 183);
        /// this.txtResults.Margin = new System.Windows.Forms.Padding(2);
        /// this.txtResults.Multiline = true;
        /// this.txtResults.Name = "txtResults";
        /// this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        /// this.txtResults.Size = new System.Drawing.Size(469, 201);
        /// this.txtResults.TabIndex = 3;
        /// // 
        /// // txtPlayerName
        /// // 
        /// this.txtPlayerName.BackColor = System.Drawing.SystemColors.InactiveCaption;
        /// this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
        /// this.txtPlayerName.ForeColor = System.Drawing.Color.DimGray;
        /// this.txtPlayerName.Location = new System.Drawing.Point(98, 103);
        /// this.txtPlayerName.Margin = new System.Windows.Forms.Padding(2);
        /// this.txtPlayerName.MinimumSize = new System.Drawing.Size(281, 25);
        /// this.txtPlayerName.Name = "txtPlayerName";
        /// this.txtPlayerName.Size = new System.Drawing.Size(281, 13);
        /// this.txtPlayerName.TabIndex = 1;
        /// this.txtPlayerName.Text = "Enter Player Name To Search";
        /// this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        /// this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
        /// this.txtPlayerName.Enter += new System.EventHandler(this.txtPlayerName_Enter);
        /// this.txtPlayerName.Leave += new System.EventHandler(this.txtPlayerName_Leave);
        /// // 
        /// // btnSubmit
        /// // 
        /// this.btnSubmit.Location = new System.Drawing.Point(419, 128);
        /// this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
        /// this.btnSubmit.Name = "btnSubmit";
        /// this.btnSubmit.Size = new System.Drawing.Size(56, 19);
        /// this.btnSubmit.TabIndex = 0;
        /// this.btnSubmit.Text = "Submit";
        /// this.btnSubmit.UseVisualStyleBackColor = true;
        /// this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
        ///
        /// // 
        /// // tabPage2
        /// // 
        /// this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
        /// this.tabPage2.Controls.Add(this.panelPlayerStats);
        /// this.tabPage2.Location = new System.Drawing.Point(4, 22);
        /// this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
        /// this.tabPage2.Name = "tabPage2";
        /// this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
        /// this.tabPage2.Size = new System.Drawing.Size(560, 421);
        /// this.tabPage2.TabIndex = 1;
        /// this.tabPage2.Text = "tabPage2";
        /// this.tabPage2.UseVisualStyleBackColor = true;
        /// this.tabPage2.AutoScroll = true;
        /// // 
        /// // panelPlayerStats
        /// // 
        /// this.panelPlayerStats.Controls.Add(this.pbxSkill);
        /// this.panelPlayerStats.Controls.Add(this.pbxWL);
        /// this.panelPlayerStats.Controls.Add(this.pbxKPM);
        /// this.panelPlayerStats.Controls.Add(this.pbxSPM);
        /// this.panelPlayerStats.Controls.Add(this.pbxKD);
        /// this.panelPlayerStats.Controls.Add(this.lblLossesSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblWinsSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblDefendsSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblCapturesSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblAccuracySTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblSkillSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblWLSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblKPMSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblSPMSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblKDSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblDeathsSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblKillsSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblAccuracy);
        /// this.panelPlayerStats.Controls.Add(this.lblSkill);
        /// this.panelPlayerStats.Controls.Add(this.lblWL);
        /// this.panelPlayerStats.Controls.Add(this.lblLosses);
        /// this.panelPlayerStats.Controls.Add(this.lblWins);
        /// this.panelPlayerStats.Controls.Add(this.lblDefends);
        /// this.panelPlayerStats.Controls.Add(this.lblCaptures);
        /// this.panelPlayerStats.Controls.Add(this.lblKPM);
        /// this.panelPlayerStats.Controls.Add(this.lblSPM);
        /// this.panelPlayerStats.Controls.Add(this.lblBestClass);
        /// this.panelPlayerStats.Controls.Add(this.lblBestClassSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.lblKD);
        /// this.panelPlayerStats.Controls.Add(this.lblDeaths);
        /// this.panelPlayerStats.Controls.Add(this.lblKills);
        /// this.panelPlayerStats.Controls.Add(this.lblNameSTATIC);
        /// this.panelPlayerStats.Controls.Add(this.btnBackToSearch);
        /// this.panelPlayerStats.Location = new System.Drawing.Point(-8, -11);
        /// this.panelPlayerStats.Name = "panelPlayerStats";
        /// this.panelPlayerStats.Size = new System.Drawing.Size(584, 446);
        /// this.panelPlayerStats.TabIndex = 4;
        /// // 
        /// // pbxSkill
        /// // 
        /// this.pbxSkill.Location = new System.Drawing.Point(274, 117);
        /// this.pbxSkill.Name = "pbxSkill";
        /// this.pbxSkill.Size = new System.Drawing.Size(28, 25);
        /// this.pbxSkill.TabIndex = 32;
        /// this.pbxSkill.TabStop = false;
        /// // 
        /// // pbxWL
        /// // 
        /// this.pbxWL.Location = new System.Drawing.Point(113, 267);
        /// this.pbxWL.Name = "pbxWL";
        /// this.pbxWL.Size = new System.Drawing.Size(28, 25);
        /// this.pbxWL.TabIndex = 31;
        /// this.pbxWL.TabStop = false;
        /// // 
        /// // pbxKPM
        /// // 
        /// this.pbxKPM.Location = new System.Drawing.Point(113, 226);
        /// this.pbxKPM.Name = "pbxKPM";
        /// this.pbxKPM.Size = new System.Drawing.Size(28, 25);
        /// this.pbxKPM.TabIndex = 30;
        /// this.pbxKPM.TabStop = false;
        /// // 
        /// // pbxSPM
        /// // 
        /// this.pbxSPM.Location = new System.Drawing.Point(113, 185);
        /// this.pbxSPM.Name = "pbxSPM";
        /// this.pbxSPM.Size = new System.Drawing.Size(28, 25);
        /// this.pbxSPM.TabIndex = 29;
        /// this.pbxSPM.TabStop = false;
        /// // 
        /// // pbxKD
        /// // 
        /// this.pbxKD.Location = new System.Drawing.Point(113, 145);
        /// this.pbxKD.Name = "pbxKD";
        /// this.pbxKD.Size = new System.Drawing.Size(28, 25);
        /// this.pbxKD.TabIndex = 28;
        /// this.pbxKD.TabStop = false;
        /// // 
        /// // lblLossesSTATIC
        /// // 
        /// this.lblLossesSTATIC.AutoSize = true;
        /// this.lblLossesSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblLossesSTATIC.Location = new System.Drawing.Point(371, 251);
        /// this.lblLossesSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblLossesSTATIC.Name = "lblLossesSTATIC";
        /// this.lblLossesSTATIC.Size = new System.Drawing.Size(40, 13);
        /// this.lblLossesSTATIC.TabIndex = 27;
        /// this.lblLossesSTATIC.Text = "Losses";
        /// // 
        /// // lblWinsSTATIC
        /// // 
        /// this.lblWinsSTATIC.AutoSize = true;
        /// this.lblWinsSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblWinsSTATIC.Location = new System.Drawing.Point(371, 217);
        /// this.lblWinsSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblWinsSTATIC.Name = "lblWinsSTATIC";
        /// this.lblWinsSTATIC.Size = new System.Drawing.Size(31, 13);
        /// this.lblWinsSTATIC.TabIndex = 26;
        /// this.lblWinsSTATIC.Text = "Wins";
        /// // 
        /// // lblDefendsSTATIC
        /// // 
        /// this.lblDefendsSTATIC.AutoSize = true;
        /// this.lblDefendsSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblDefendsSTATIC.Location = new System.Drawing.Point(371, 184);
        /// this.lblDefendsSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblDefendsSTATIC.Name = "lblDefendsSTATIC";
        /// this.lblDefendsSTATIC.Size = new System.Drawing.Size(70, 13);
        /// this.lblDefendsSTATIC.TabIndex = 25;
        /// this.lblDefendsSTATIC.Text = "Flag Defends";
        /// // 
        /// // lblCapturesSTATIC
        /// // 
        /// this.lblCapturesSTATIC.AutoSize = true;
        /// this.lblCapturesSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblCapturesSTATIC.Location = new System.Drawing.Point(371, 145);
        /// this.lblCapturesSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblCapturesSTATIC.Name = "lblCapturesSTATIC";
        /// this.lblCapturesSTATIC.Size = new System.Drawing.Size(72, 13);
        /// this.lblCapturesSTATIC.TabIndex = 24;
        /// this.lblCapturesSTATIC.Text = "Flag Captures";
        /// // 
        /// // lblAccuracySTATIC
        /// // 
        /// this.lblAccuracySTATIC.AutoSize = true;
        /// this.lblAccuracySTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblAccuracySTATIC.Location = new System.Drawing.Point(206, 184);
        /// this.lblAccuracySTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblAccuracySTATIC.Name = "lblAccuracySTATIC";
        /// this.lblAccuracySTATIC.Size = new System.Drawing.Size(52, 13);
        /// this.lblAccuracySTATIC.TabIndex = 23;
        /// this.lblAccuracySTATIC.Text = "Accuracy";
        /// // 
        /// // lblSkillSTATIC
        /// // 
        /// this.lblSkillSTATIC.AutoSize = true;
        /// this.lblSkillSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblSkillSTATIC.Location = new System.Drawing.Point(206, 117);
        /// this.lblSkillSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblSkillSTATIC.Name = "lblSkillSTATIC";
        /// this.lblSkillSTATIC.Size = new System.Drawing.Size(26, 13);
        /// this.lblSkillSTATIC.TabIndex = 22;
        /// this.lblSkillSTATIC.Text = "Skill";
        /// // 
        /// // lblWLSTATIC
        /// // 
        /// this.lblWLSTATIC.AutoSize = true;
        /// this.lblWLSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblWLSTATIC.Location = new System.Drawing.Point(53, 265);
        /// this.lblWLSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblWLSTATIC.Name = "lblWLSTATIC";
        /// this.lblWLSTATIC.Size = new System.Drawing.Size(57, 13);
        /// this.lblWLSTATIC.TabIndex = 21;
        /// this.lblWLSTATIC.Text = "W/L Ratio";
        /// // 
        /// // lblKPMSTATIC
        /// // 
        /// this.lblKPMSTATIC.AutoSize = true;
        /// this.lblKPMSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblKPMSTATIC.Location = new System.Drawing.Point(53, 224);
        /// this.lblKPMSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblKPMSTATIC.Name = "lblKPMSTATIC";
        /// this.lblKPMSTATIC.Size = new System.Drawing.Size(30, 13);
        /// this.lblKPMSTATIC.TabIndex = 20;
        /// this.lblKPMSTATIC.Text = "KPM";
        /// // 
        /// // lblSPMSTATIC
        /// // 
        /// this.lblSPMSTATIC.AutoSize = true;
        /// this.lblSPMSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblSPMSTATIC.Location = new System.Drawing.Point(53, 184);
        /// this.lblSPMSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblSPMSTATIC.Name = "lblSPMSTATIC";
        /// this.lblSPMSTATIC.Size = new System.Drawing.Size(30, 13);
        /// this.lblSPMSTATIC.TabIndex = 19;
        /// this.lblSPMSTATIC.Text = "SPM";
        /// // 
        /// // lblKDSTATIC
        /// // 
        /// this.lblKDSTATIC.AutoSize = true;
        /// this.lblKDSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblKDSTATIC.Location = new System.Drawing.Point(53, 145);
        /// this.lblKDSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblKDSTATIC.Name = "lblKDSTATIC";
        /// this.lblKDSTATIC.Size = new System.Drawing.Size(27, 13);
        /// this.lblKDSTATIC.TabIndex = 18;
        /// this.lblKDSTATIC.Text = "K/D";
        /// // 
        /// // lblDeathsSTATIC
        /// // 
        /// this.lblDeathsSTATIC.AutoSize = true;
        /// this.lblDeathsSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblDeathsSTATIC.Location = new System.Drawing.Point(53, 105);
        /// this.lblDeathsSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblDeathsSTATIC.Name = "lblDeathsSTATIC";
        /// this.lblDeathsSTATIC.Size = new System.Drawing.Size(41, 13);
        /// this.lblDeathsSTATIC.TabIndex = 17;
        /// this.lblDeathsSTATIC.Text = "Deaths";
        /// // 
        /// // lblKillsSTATIC
        /// // 
        /// this.lblKillsSTATIC.AutoSize = true;
        /// this.lblKillsSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
        /// this.lblKillsSTATIC.Location = new System.Drawing.Point(53, 66);
        /// this.lblKillsSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblKillsSTATIC.Name = "lblKillsSTATIC";
        /// this.lblKillsSTATIC.Size = new System.Drawing.Size(25, 13);
        /// this.lblKillsSTATIC.TabIndex = 16;
        /// this.lblKillsSTATIC.Text = "Kills";
        /// // 
        /// // lblAccuracy
        /// // 
        /// this.lblAccuracy.AutoSize = true;
        /// this.lblAccuracy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblAccuracy.Location = new System.Drawing.Point(206, 197);
        /// this.lblAccuracy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblAccuracy.Name = "lblAccuracy";
        /// this.lblAccuracy.Size = new System.Drawing.Size(84, 13);
        /// this.lblAccuracy.TabIndex = 15;
        /// this.lblAccuracy.Text = "Player Accuracy";
        /// // 
        /// // lblSkill
        /// // 
        /// this.lblSkill.AutoSize = true;
        /// this.lblSkill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblSkill.Location = new System.Drawing.Point(206, 131);
        /// this.lblSkill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblSkill.Name = "lblSkill";
        /// this.lblSkill.Size = new System.Drawing.Size(58, 13);
        /// this.lblSkill.TabIndex = 14;
        /// this.lblSkill.Text = "Player Skill";
        /// // 
        /// // lblWL
        /// // 
        /// this.lblWL.AutoSize = true;
        /// this.lblWL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblWL.Location = new System.Drawing.Point(53, 279);
        /// this.lblWL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblWL.Name = "lblWL";
        /// this.lblWL.Size = new System.Drawing.Size(61, 13);
        /// this.lblWL.TabIndex = 13;
        /// this.lblWL.Text = "Player W/L";
        /// // 
        /// // lblLosses
        /// // 
        /// this.lblLosses.AutoSize = true;
        /// this.lblLosses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblLosses.Location = new System.Drawing.Point(371, 265);
        /// this.lblLosses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblLosses.Name = "lblLosses";
        /// this.lblLosses.Size = new System.Drawing.Size(72, 13);
        /// this.lblLosses.TabIndex = 12;
        /// this.lblLosses.Text = "Player Losses";
        /// // 
        /// // lblWins
        /// // 
        /// this.lblWins.AutoSize = true;
        /// this.lblWins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblWins.Location = new System.Drawing.Point(371, 231);
        /// this.lblWins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblWins.Name = "lblWins";
        /// this.lblWins.Size = new System.Drawing.Size(63, 13);
        /// this.lblWins.TabIndex = 11;
        /// this.lblWins.Text = "Player Wins";
        /// // 
        /// // lblDefends
        /// // 
        /// this.lblDefends.AutoSize = true;
        /// this.lblDefends.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblDefends.Location = new System.Drawing.Point(371, 197);
        /// this.lblDefends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblDefends.Name = "lblDefends";
        /// this.lblDefends.Size = new System.Drawing.Size(79, 13);
        /// this.lblDefends.TabIndex = 10;
        /// this.lblDefends.Text = "Player Defends";
        /// // 
        /// // lblCaptures
        /// // 
        /// this.lblCaptures.AutoSize = true;
        /// this.lblCaptures.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblCaptures.Location = new System.Drawing.Point(371, 158);
        /// this.lblCaptures.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblCaptures.Name = "lblCaptures";
        /// this.lblCaptures.Size = new System.Drawing.Size(81, 13);
        /// this.lblCaptures.TabIndex = 9;
        /// this.lblCaptures.Text = "Player Captures";
        /// // 
        /// // lblKPM
        /// // 
        /// this.lblKPM.AutoSize = true;
        /// this.lblKPM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblKPM.Location = new System.Drawing.Point(53, 238);
        /// this.lblKPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblKPM.Name = "lblKPM";
        /// this.lblKPM.Size = new System.Drawing.Size(62, 13);
        /// this.lblKPM.TabIndex = 8;
        /// this.lblKPM.Text = "Player KPM";
        /// // 
        /// // lblSPM
        /// // 
        /// this.lblSPM.AutoSize = true;
        /// this.lblSPM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblSPM.Location = new System.Drawing.Point(51, 197);
        /// this.lblSPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblSPM.Name = "lblSPM";
        /// this.lblSPM.Size = new System.Drawing.Size(62, 13);
        /// this.lblSPM.TabIndex = 7;
        /// this.lblSPM.Text = "Player SPM";
        /// // 
        /// // lblBestClass
        /// // 
        /// this.lblBestClass.AutoSize = true;
        /// this.lblBestClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblBestClass.Location = new System.Drawing.Point(371, 124);
        /// this.lblBestClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblBestClass.Name = "lblBestClass";
        /// this.lblBestClass.Size = new System.Drawing.Size(56, 13);
        /// this.lblBestClass.TabIndex = 6;
        /// this.lblBestClass.Text = "Best Class";
        /// // 
        /// // lblBestClassSTATIC
        /// // 
        /// this.lblBestClassSTATIC.AutoSize = true;
        /// this.lblBestClassSTATIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        /// this.lblBestClassSTATIC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblBestClassSTATIC.Location = new System.Drawing.Point(350, 82);
        /// this.lblBestClassSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblBestClassSTATIC.Name = "lblBestClassSTATIC";
        /// this.lblBestClassSTATIC.Size = new System.Drawing.Size(117, 26);
        /// this.lblBestClassSTATIC.TabIndex = 5;
        /// this.lblBestClassSTATIC.Text = "Best Class";
        /// // 
        /// // lblKD
        /// // 
        /// this.lblKD.AutoSize = true;
        /// this.lblKD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblKD.Location = new System.Drawing.Point(53, 158);
        /// this.lblKD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblKD.Name = "lblKD";
        /// this.lblKD.Size = new System.Drawing.Size(54, 13);
        /// this.lblKD.TabIndex = 4;
        /// this.lblKD.Text = "Player KD";
        /// // 
        /// // lblDeaths
        /// // 
        /// this.lblDeaths.AutoSize = true;
        /// this.lblDeaths.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblDeaths.Location = new System.Drawing.Point(53, 119);
        /// this.lblDeaths.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblDeaths.Name = "lblDeaths";
        /// this.lblDeaths.Size = new System.Drawing.Size(73, 13);
        /// this.lblDeaths.TabIndex = 3;
        /// this.lblDeaths.Text = "Player Deaths";
        /// // 
        /// // lblKills
        /// // 
        /// this.lblKills.AutoSize = true;
        /// this.lblKills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblKills.Location = new System.Drawing.Point(53, 82);
        /// this.lblKills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblKills.Name = "lblKills";
        /// this.lblKills.Size = new System.Drawing.Size(57, 13);
        /// this.lblKills.TabIndex = 2;
        /// this.lblKills.Text = "Player Kills";
        /// // 
        /// // lblNameSTATIC
        /// // 
        /// this.lblNameSTATIC.AutoSize = true;
        /// this.lblNameSTATIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        /// this.lblNameSTATIC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        /// this.lblNameSTATIC.Location = new System.Drawing.Point(190, 28);
        /// this.lblNameSTATIC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        /// this.lblNameSTATIC.Name = "lblNameSTATIC";
        /// this.lblNameSTATIC.Size = new System.Drawing.Size(170, 31);
        /// this.lblNameSTATIC.TabIndex = 1;
        /// this.lblNameSTATIC.Text = "Player Name";
        /// this.lblNameSTATIC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        /// // 
        /// // btnBackToSearch
        /// // 
        /// this.btnBackToSearch.Location = new System.Drawing.Point(227, 328);
        /// this.btnBackToSearch.Name = "btnBackToSearch";
        /// this.btnBackToSearch.Size = new System.Drawing.Size(75, 23);
        /// this.btnBackToSearch.TabIndex = 0;
        /// this.btnBackToSearch.Text = "Back";
        /// this.btnBackToSearch.UseVisualStyleBackColor = true;
        /// this.btnBackToSearch.Click += new System.EventHandler(this.btnBackToSearch_Click);
        /// // 
        /// // Form1
        /// // 
        /// this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        /// this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        /// this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
        /// this.ClientSize = new System.Drawing.Size(586, 458);
        /// this.Controls.Add(this.tabControlMain);
        /// this.Margin = new System.Windows.Forms.Padding(2);
        /// this.Name = "Form1";
        /// this.Text = "Battlefield 1 Stats";
        /// this.Load += new System.EventHandler(this.Form1_Load);
        /// this.tabControlMain.ResumeLayout(false);
        /// this.tabPage1.ResumeLayout(false);
        /// this.panelSearch.ResumeLayout(false);
        /// this.panelSearch.PerformLayout();
        /// this.tabPage2.ResumeLayout(false);
        /// this.panelPlayerStats.ResumeLayout(false);
        /// this.panelPlayerStats.PerformLayout();
        /// ((System.ComponentModel.ISupportInitialize)(this.pbxSkill)).EndInit();
        /// ((System.ComponentModel.ISupportInitialize)(this.pbxWL)).EndInit();
        /// ((System.ComponentModel.ISupportInitialize)(this.pbxKPM)).EndInit();
        /// ((System.ComponentModel.ISupportInitialize)(this.pbxSPM)).EndInit();
        /// ((System.ComponentModel.ISupportInitialize)(this.pbxKD)).EndInit();
        /// this.ResumeLayout(false);
      
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlMain = new BF1_Stats.TabControlCustom();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.cbxPlatform = new System.Windows.Forms.ComboBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelPlayerStats = new System.Windows.Forms.Panel();
            this.pbxSkill = new System.Windows.Forms.PictureBox();
            this.pbxWL = new System.Windows.Forms.PictureBox();
            this.pbxKPM = new System.Windows.Forms.PictureBox();
            this.pbxSPM = new System.Windows.Forms.PictureBox();
            this.pbxKD = new System.Windows.Forms.PictureBox();
            this.lblLossesSTATIC = new System.Windows.Forms.Label();
            this.lblWinsSTATIC = new System.Windows.Forms.Label();
            this.lblDefendsSTATIC = new System.Windows.Forms.Label();
            this.lblCapturesSTATIC = new System.Windows.Forms.Label();
            this.lblAccuracySTATIC = new System.Windows.Forms.Label();
            this.lblSkillSTATIC = new System.Windows.Forms.Label();
            this.lblWLSTATIC = new System.Windows.Forms.Label();
            this.lblKPMSTATIC = new System.Windows.Forms.Label();
            this.lblSPMSTATIC = new System.Windows.Forms.Label();
            this.lblKDSTATIC = new System.Windows.Forms.Label();
            this.lblDeathsSTATIC = new System.Windows.Forms.Label();
            this.lblKillsSTATIC = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblSkill = new System.Windows.Forms.Label();
            this.lblWL = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblDefends = new System.Windows.Forms.Label();
            this.lblCaptures = new System.Windows.Forms.Label();
            this.lblKPM = new System.Windows.Forms.Label();
            this.lblSPM = new System.Windows.Forms.Label();
            this.lblBestClass = new System.Windows.Forms.Label();
            this.lblBestClassSTATIC = new System.Windows.Forms.Label();
            this.lblKD = new System.Windows.Forms.Label();
            this.lblDeaths = new System.Windows.Forms.Label();
            this.lblKills = new System.Windows.Forms.Label();
            this.lblNameSTATIC = new System.Windows.Forms.Label();
            this.btnBackToSearch = new System.Windows.Forms.Button();
            this.chartModesWins = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartModesLosses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelPlayerStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModesWins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModesLosses)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.HideTabs = true;
            this.tabControlMain.Location = new System.Drawing.Point(1, 2);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1608, 921);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.panelSearch);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1608, 921);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.cbxPlatform);
            this.panelSearch.Controls.Add(this.txtResults);
            this.panelSearch.Controls.Add(this.txtPlayerName);
            this.panelSearch.Controls.Add(this.btnSubmit);
            this.panelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSearch.Location = new System.Drawing.Point(-11, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1619, 917);
            this.panelSearch.TabIndex = 4;
            this.panelSearch.VisibleChanged += new System.EventHandler(this.panelSearch_VisibleChanged);
            // 
            // cbxPlatform
            // 
            this.cbxPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPlatform.FormattingEnabled = true;
            this.cbxPlatform.Items.AddRange(new object[] {
            "Xbox",
            "Playstation",
            "PC"});
            this.cbxPlatform.Location = new System.Drawing.Point(935, 277);
            this.cbxPlatform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPlatform.Name = "cbxPlatform";
            this.cbxPlatform.Size = new System.Drawing.Size(121, 24);
            this.cbxPlatform.TabIndex = 2;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(495, 434);
            this.txtResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(624, 246);
            this.txtResults.TabIndex = 3;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.ForeColor = System.Drawing.Color.DimGray;
            this.txtPlayerName.Location = new System.Drawing.Point(555, 277);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlayerName.MinimumSize = new System.Drawing.Size(375, 25);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(375, 24);
            this.txtPlayerName.TabIndex = 1;
            this.txtPlayerName.Text = "Enter Player Name To Search";
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            this.txtPlayerName.Enter += new System.EventHandler(this.txtPlayerName_Enter);
            this.txtPlayerName.Leave += new System.EventHandler(this.txtPlayerName_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(983, 308);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.panelPlayerStats);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1608, 921);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // panelPlayerStats
            // 
            this.panelPlayerStats.Controls.Add(this.chartModesLosses);
            this.panelPlayerStats.Controls.Add(this.chartModesWins);
            this.panelPlayerStats.Controls.Add(this.pbxSkill);
            this.panelPlayerStats.Controls.Add(this.pbxWL);
            this.panelPlayerStats.Controls.Add(this.pbxKPM);
            this.panelPlayerStats.Controls.Add(this.pbxSPM);
            this.panelPlayerStats.Controls.Add(this.pbxKD);
            this.panelPlayerStats.Controls.Add(this.lblLossesSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblWinsSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblDefendsSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblCapturesSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblAccuracySTATIC);
            this.panelPlayerStats.Controls.Add(this.lblSkillSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblWLSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblKPMSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblSPMSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblKDSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblDeathsSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblKillsSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblAccuracy);
            this.panelPlayerStats.Controls.Add(this.lblSkill);
            this.panelPlayerStats.Controls.Add(this.lblWL);
            this.panelPlayerStats.Controls.Add(this.lblLosses);
            this.panelPlayerStats.Controls.Add(this.lblWins);
            this.panelPlayerStats.Controls.Add(this.lblDefends);
            this.panelPlayerStats.Controls.Add(this.lblCaptures);
            this.panelPlayerStats.Controls.Add(this.lblKPM);
            this.panelPlayerStats.Controls.Add(this.lblSPM);
            this.panelPlayerStats.Controls.Add(this.lblBestClass);
            this.panelPlayerStats.Controls.Add(this.lblBestClassSTATIC);
            this.panelPlayerStats.Controls.Add(this.lblKD);
            this.panelPlayerStats.Controls.Add(this.lblDeaths);
            this.panelPlayerStats.Controls.Add(this.lblKills);
            this.panelPlayerStats.Controls.Add(this.lblNameSTATIC);
            this.panelPlayerStats.Controls.Add(this.btnBackToSearch);
            this.panelPlayerStats.Location = new System.Drawing.Point(0, 0);
            this.panelPlayerStats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPlayerStats.Name = "panelPlayerStats";
            this.panelPlayerStats.Size = new System.Drawing.Size(1580, 1051);
            this.panelPlayerStats.TabIndex = 4;
            // 
            // pbxSkill
            // 
            this.pbxSkill.Location = new System.Drawing.Point(365, 144);
            this.pbxSkill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxSkill.Name = "pbxSkill";
            this.pbxSkill.Size = new System.Drawing.Size(37, 31);
            this.pbxSkill.TabIndex = 32;
            this.pbxSkill.TabStop = false;
            // 
            // pbxWL
            // 
            this.pbxWL.Location = new System.Drawing.Point(151, 329);
            this.pbxWL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxWL.Name = "pbxWL";
            this.pbxWL.Size = new System.Drawing.Size(37, 31);
            this.pbxWL.TabIndex = 31;
            this.pbxWL.TabStop = false;
            // 
            // pbxKPM
            // 
            this.pbxKPM.Location = new System.Drawing.Point(151, 278);
            this.pbxKPM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxKPM.Name = "pbxKPM";
            this.pbxKPM.Size = new System.Drawing.Size(37, 31);
            this.pbxKPM.TabIndex = 30;
            this.pbxKPM.TabStop = false;
            // 
            // pbxSPM
            // 
            this.pbxSPM.Location = new System.Drawing.Point(151, 228);
            this.pbxSPM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxSPM.Name = "pbxSPM";
            this.pbxSPM.Size = new System.Drawing.Size(37, 31);
            this.pbxSPM.TabIndex = 29;
            this.pbxSPM.TabStop = false;
            // 
            // pbxKD
            // 
            this.pbxKD.Location = new System.Drawing.Point(151, 178);
            this.pbxKD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxKD.Name = "pbxKD";
            this.pbxKD.Size = new System.Drawing.Size(37, 31);
            this.pbxKD.TabIndex = 28;
            this.pbxKD.TabStop = false;
            // 
            // lblLossesSTATIC
            // 
            this.lblLossesSTATIC.AutoSize = true;
            this.lblLossesSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblLossesSTATIC.Location = new System.Drawing.Point(495, 309);
            this.lblLossesSTATIC.Name = "lblLossesSTATIC";
            this.lblLossesSTATIC.Size = new System.Drawing.Size(53, 17);
            this.lblLossesSTATIC.TabIndex = 27;
            this.lblLossesSTATIC.Text = "Losses";
            // 
            // lblWinsSTATIC
            // 
            this.lblWinsSTATIC.AutoSize = true;
            this.lblWinsSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblWinsSTATIC.Location = new System.Drawing.Point(495, 267);
            this.lblWinsSTATIC.Name = "lblWinsSTATIC";
            this.lblWinsSTATIC.Size = new System.Drawing.Size(39, 17);
            this.lblWinsSTATIC.TabIndex = 26;
            this.lblWinsSTATIC.Text = "Wins";
            // 
            // lblDefendsSTATIC
            // 
            this.lblDefendsSTATIC.AutoSize = true;
            this.lblDefendsSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDefendsSTATIC.Location = new System.Drawing.Point(495, 226);
            this.lblDefendsSTATIC.Name = "lblDefendsSTATIC";
            this.lblDefendsSTATIC.Size = new System.Drawing.Size(92, 17);
            this.lblDefendsSTATIC.TabIndex = 25;
            this.lblDefendsSTATIC.Text = "Flag Defends";
            // 
            // lblCapturesSTATIC
            // 
            this.lblCapturesSTATIC.AutoSize = true;
            this.lblCapturesSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCapturesSTATIC.Location = new System.Drawing.Point(495, 178);
            this.lblCapturesSTATIC.Name = "lblCapturesSTATIC";
            this.lblCapturesSTATIC.Size = new System.Drawing.Size(96, 17);
            this.lblCapturesSTATIC.TabIndex = 24;
            this.lblCapturesSTATIC.Text = "Flag Captures";
            // 
            // lblAccuracySTATIC
            // 
            this.lblAccuracySTATIC.AutoSize = true;
            this.lblAccuracySTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAccuracySTATIC.Location = new System.Drawing.Point(275, 226);
            this.lblAccuracySTATIC.Name = "lblAccuracySTATIC";
            this.lblAccuracySTATIC.Size = new System.Drawing.Size(66, 17);
            this.lblAccuracySTATIC.TabIndex = 23;
            this.lblAccuracySTATIC.Text = "Accuracy";
            // 
            // lblSkillSTATIC
            // 
            this.lblSkillSTATIC.AutoSize = true;
            this.lblSkillSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSkillSTATIC.Location = new System.Drawing.Point(275, 144);
            this.lblSkillSTATIC.Name = "lblSkillSTATIC";
            this.lblSkillSTATIC.Size = new System.Drawing.Size(33, 17);
            this.lblSkillSTATIC.TabIndex = 22;
            this.lblSkillSTATIC.Text = "Skill";
            // 
            // lblWLSTATIC
            // 
            this.lblWLSTATIC.AutoSize = true;
            this.lblWLSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblWLSTATIC.Location = new System.Drawing.Point(71, 326);
            this.lblWLSTATIC.Name = "lblWLSTATIC";
            this.lblWLSTATIC.Size = new System.Drawing.Size(70, 17);
            this.lblWLSTATIC.TabIndex = 21;
            this.lblWLSTATIC.Text = "W/L Ratio";
            // 
            // lblKPMSTATIC
            // 
            this.lblKPMSTATIC.AutoSize = true;
            this.lblKPMSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblKPMSTATIC.Location = new System.Drawing.Point(71, 276);
            this.lblKPMSTATIC.Name = "lblKPMSTATIC";
            this.lblKPMSTATIC.Size = new System.Drawing.Size(37, 17);
            this.lblKPMSTATIC.TabIndex = 20;
            this.lblKPMSTATIC.Text = "KPM";
            // 
            // lblSPMSTATIC
            // 
            this.lblSPMSTATIC.AutoSize = true;
            this.lblSPMSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSPMSTATIC.Location = new System.Drawing.Point(71, 226);
            this.lblSPMSTATIC.Name = "lblSPMSTATIC";
            this.lblSPMSTATIC.Size = new System.Drawing.Size(37, 17);
            this.lblSPMSTATIC.TabIndex = 19;
            this.lblSPMSTATIC.Text = "SPM";
            // 
            // lblKDSTATIC
            // 
            this.lblKDSTATIC.AutoSize = true;
            this.lblKDSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblKDSTATIC.Location = new System.Drawing.Point(71, 178);
            this.lblKDSTATIC.Name = "lblKDSTATIC";
            this.lblKDSTATIC.Size = new System.Drawing.Size(31, 17);
            this.lblKDSTATIC.TabIndex = 18;
            this.lblKDSTATIC.Text = "K/D";
            // 
            // lblDeathsSTATIC
            // 
            this.lblDeathsSTATIC.AutoSize = true;
            this.lblDeathsSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDeathsSTATIC.Location = new System.Drawing.Point(71, 129);
            this.lblDeathsSTATIC.Name = "lblDeathsSTATIC";
            this.lblDeathsSTATIC.Size = new System.Drawing.Size(53, 17);
            this.lblDeathsSTATIC.TabIndex = 17;
            this.lblDeathsSTATIC.Text = "Deaths";
            // 
            // lblKillsSTATIC
            // 
            this.lblKillsSTATIC.AutoSize = true;
            this.lblKillsSTATIC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblKillsSTATIC.Location = new System.Drawing.Point(71, 81);
            this.lblKillsSTATIC.Name = "lblKillsSTATIC";
            this.lblKillsSTATIC.Size = new System.Drawing.Size(33, 17);
            this.lblKillsSTATIC.TabIndex = 16;
            this.lblKillsSTATIC.Text = "Kills";
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccuracy.Location = new System.Drawing.Point(275, 242);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(110, 17);
            this.lblAccuracy.TabIndex = 15;
            this.lblAccuracy.Text = "Player Accuracy";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSkill.Location = new System.Drawing.Point(275, 161);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(77, 17);
            this.lblSkill.TabIndex = 14;
            this.lblSkill.Text = "Player Skill";
            // 
            // lblWL
            // 
            this.lblWL.AutoSize = true;
            this.lblWL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWL.Location = new System.Drawing.Point(71, 343);
            this.lblWL.Name = "lblWL";
            this.lblWL.Size = new System.Drawing.Size(77, 17);
            this.lblWL.TabIndex = 13;
            this.lblWL.Text = "Player W/L";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLosses.Location = new System.Drawing.Point(495, 326);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(97, 17);
            this.lblLosses.TabIndex = 12;
            this.lblLosses.Text = "Player Losses";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWins.Location = new System.Drawing.Point(495, 284);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(83, 17);
            this.lblWins.TabIndex = 11;
            this.lblWins.Text = "Player Wins";
            // 
            // lblDefends
            // 
            this.lblDefends.AutoSize = true;
            this.lblDefends.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDefends.Location = new System.Drawing.Point(495, 242);
            this.lblDefends.Name = "lblDefends";
            this.lblDefends.Size = new System.Drawing.Size(105, 17);
            this.lblDefends.TabIndex = 10;
            this.lblDefends.Text = "Player Defends";
            // 
            // lblCaptures
            // 
            this.lblCaptures.AutoSize = true;
            this.lblCaptures.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCaptures.Location = new System.Drawing.Point(495, 194);
            this.lblCaptures.Name = "lblCaptures";
            this.lblCaptures.Size = new System.Drawing.Size(109, 17);
            this.lblCaptures.TabIndex = 9;
            this.lblCaptures.Text = "Player Captures";
            // 
            // lblKPM
            // 
            this.lblKPM.AutoSize = true;
            this.lblKPM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKPM.Location = new System.Drawing.Point(71, 293);
            this.lblKPM.Name = "lblKPM";
            this.lblKPM.Size = new System.Drawing.Size(81, 17);
            this.lblKPM.TabIndex = 8;
            this.lblKPM.Text = "Player KPM";
            // 
            // lblSPM
            // 
            this.lblSPM.AutoSize = true;
            this.lblSPM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSPM.Location = new System.Drawing.Point(68, 242);
            this.lblSPM.Name = "lblSPM";
            this.lblSPM.Size = new System.Drawing.Size(81, 17);
            this.lblSPM.TabIndex = 7;
            this.lblSPM.Text = "Player SPM";
            // 
            // lblBestClass
            // 
            this.lblBestClass.AutoSize = true;
            this.lblBestClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBestClass.Location = new System.Drawing.Point(495, 153);
            this.lblBestClass.Name = "lblBestClass";
            this.lblBestClass.Size = new System.Drawing.Size(74, 17);
            this.lblBestClass.TabIndex = 6;
            this.lblBestClass.Text = "Best Class";
            // 
            // lblBestClassSTATIC
            // 
            this.lblBestClassSTATIC.AutoSize = true;
            this.lblBestClassSTATIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestClassSTATIC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBestClassSTATIC.Location = new System.Drawing.Point(467, 101);
            this.lblBestClassSTATIC.Name = "lblBestClassSTATIC";
            this.lblBestClassSTATIC.Size = new System.Drawing.Size(145, 31);
            this.lblBestClassSTATIC.TabIndex = 5;
            this.lblBestClassSTATIC.Text = "Best Class";
            // 
            // lblKD
            // 
            this.lblKD.AutoSize = true;
            this.lblKD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKD.Location = new System.Drawing.Point(71, 194);
            this.lblKD.Name = "lblKD";
            this.lblKD.Size = new System.Drawing.Size(71, 17);
            this.lblKD.TabIndex = 4;
            this.lblKD.Text = "Player KD";
            // 
            // lblDeaths
            // 
            this.lblDeaths.AutoSize = true;
            this.lblDeaths.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeaths.Location = new System.Drawing.Point(71, 146);
            this.lblDeaths.Name = "lblDeaths";
            this.lblDeaths.Size = new System.Drawing.Size(97, 17);
            this.lblDeaths.TabIndex = 3;
            this.lblDeaths.Text = "Player Deaths";
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKills.Location = new System.Drawing.Point(71, 101);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(77, 17);
            this.lblKills.TabIndex = 2;
            this.lblKills.Text = "Player Kills";
            // 
            // lblNameSTATIC
            // 
            this.lblNameSTATIC.AutoSize = true;
            this.lblNameSTATIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSTATIC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameSTATIC.Location = new System.Drawing.Point(676, 34);
            this.lblNameSTATIC.Name = "lblNameSTATIC";
            this.lblNameSTATIC.Size = new System.Drawing.Size(214, 39);
            this.lblNameSTATIC.TabIndex = 1;
            this.lblNameSTATIC.Text = "Player Name";
            this.lblNameSTATIC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackToSearch
            // 
            this.btnBackToSearch.Location = new System.Drawing.Point(303, 404);
            this.btnBackToSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToSearch.Name = "btnBackToSearch";
            this.btnBackToSearch.Size = new System.Drawing.Size(100, 28);
            this.btnBackToSearch.TabIndex = 0;
            this.btnBackToSearch.Text = "Back";
            this.btnBackToSearch.UseVisualStyleBackColor = true;
            this.btnBackToSearch.Click += new System.EventHandler(this.btnBackToSearch_Click);
            // 
            // chartModesWins
            // 
            chartArea2.Name = "ChartArea1";
            this.chartModesWins.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartModesWins.Legends.Add(legend2);
            this.chartModesWins.Location = new System.Drawing.Point(183, 475);
            this.chartModesWins.Name = "chartModesWins";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartModesWins.Series.Add(series2);
            this.chartModesWins.Size = new System.Drawing.Size(300, 300);
            this.chartModesWins.TabIndex = 33;
            this.chartModesWins.Text = "chart1";
            // 
            // chartModesLosses
            // 
            chartArea1.Name = "ChartArea1";
            this.chartModesLosses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartModesLosses.Legends.Add(legend1);
            this.chartModesLosses.Location = new System.Drawing.Point(606, 475);
            this.chartModesLosses.Name = "chartModesLosses";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartModesLosses.Series.Add(series1);
            this.chartModesLosses.Size = new System.Drawing.Size(300, 300);
            this.chartModesLosses.TabIndex = 34;
            this.chartModesLosses.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1609, 922);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Battlefield 1 Stats";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelPlayerStats.ResumeLayout(false);
            this.panelPlayerStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModesWins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModesLosses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPlayerStats;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.Label lblWL;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblDefends;
        private System.Windows.Forms.Label lblCaptures;
        private System.Windows.Forms.Label lblKPM;
        private System.Windows.Forms.Label lblSPM;
        private System.Windows.Forms.Label lblBestClass;
        private System.Windows.Forms.Label lblBestClassSTATIC;
        private System.Windows.Forms.Label lblKD;
        private System.Windows.Forms.Label lblDeaths;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.Label lblNameSTATIC;
        private System.Windows.Forms.Button btnBackToSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.ComboBox cbxPlatform;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnSubmit;
        private TabControlCustom tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblLossesSTATIC;
        private System.Windows.Forms.Label lblWinsSTATIC;
        private System.Windows.Forms.Label lblDefendsSTATIC;
        private System.Windows.Forms.Label lblCapturesSTATIC;
        private System.Windows.Forms.Label lblAccuracySTATIC;
        private System.Windows.Forms.Label lblSkillSTATIC;
        private System.Windows.Forms.Label lblWLSTATIC;
        private System.Windows.Forms.Label lblKPMSTATIC;
        private System.Windows.Forms.Label lblSPMSTATIC;
        private System.Windows.Forms.Label lblKDSTATIC;
        private System.Windows.Forms.Label lblDeathsSTATIC;
        private System.Windows.Forms.Label lblKillsSTATIC;
        private System.Windows.Forms.PictureBox pbxSkill;
        private System.Windows.Forms.PictureBox pbxWL;
        private System.Windows.Forms.PictureBox pbxKPM;
        private System.Windows.Forms.PictureBox pbxSPM;
        private System.Windows.Forms.PictureBox pbxKD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartModesWins;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartModesLosses;
    }
}

