namespace winbench
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBaseScore = new System.Windows.Forms.Panel();
            this.panelBSHighlight = new System.Windows.Forms.Panel();
            this.tbBaseScore = new System.Windows.Forms.TextBox();
            this.panelSubScores = new System.Windows.Forms.Panel();
            this.lbDisk = new System.Windows.Forms.Label();
            this.lbGaming = new System.Windows.Forms.Label();
            this.lbGraphics = new System.Windows.Forms.Label();
            this.lbRam = new System.Windows.Forms.Label();
            this.lbProcessor = new System.Windows.Forms.Label();
            this.panelRatingDes = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelComponent = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.btnRunBench = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parsedXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winSATInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbAssessmentFiles = new System.Windows.Forms.ToolStripComboBox();
            this.reloadAssessmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panelBaseScore.SuspendLayout();
            this.panelBSHighlight.SuspendLayout();
            this.panelSubScores.SuspendLayout();
            this.panelRatingDes.SuspendLayout();
            this.panelComponent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panelBaseScore);
            this.panel1.Controls.Add(this.panelSubScores);
            this.panel1.Controls.Add(this.panelRatingDes);
            this.panel1.Controls.Add(this.panelComponent);
            this.panel1.Location = new System.Drawing.Point(29, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 319);
            this.panel1.TabIndex = 0;
            // 
            // panelBaseScore
            // 
            this.panelBaseScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelBaseScore.Controls.Add(this.panelBSHighlight);
            this.panelBaseScore.Location = new System.Drawing.Point(730, 34);
            this.panelBaseScore.Margin = new System.Windows.Forms.Padding(2);
            this.panelBaseScore.Name = "panelBaseScore";
            this.panelBaseScore.Size = new System.Drawing.Size(169, 251);
            this.panelBaseScore.TabIndex = 4;
            // 
            // panelBSHighlight
            // 
            this.panelBSHighlight.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelBSHighlight.Controls.Add(this.tbBaseScore);
            this.panelBSHighlight.Location = new System.Drawing.Point(13, 62);
            this.panelBSHighlight.Margin = new System.Windows.Forms.Padding(2);
            this.panelBSHighlight.Name = "panelBSHighlight";
            this.panelBSHighlight.Size = new System.Drawing.Size(145, 128);
            this.panelBSHighlight.TabIndex = 8;
            this.panelBSHighlight.TabStop = true;
            // 
            // tbBaseScore
            // 
            this.tbBaseScore.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbBaseScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBaseScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBaseScore.ForeColor = System.Drawing.SystemColors.Info;
            this.tbBaseScore.Location = new System.Drawing.Point(40, 41);
            this.tbBaseScore.Margin = new System.Windows.Forms.Padding(2);
            this.tbBaseScore.Name = "tbBaseScore";
            this.tbBaseScore.ReadOnly = true;
            this.tbBaseScore.Size = new System.Drawing.Size(67, 37);
            this.tbBaseScore.TabIndex = 1;
            this.tbBaseScore.Text = "0.0";
            this.tbBaseScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelSubScores
            // 
            this.panelSubScores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSubScores.Controls.Add(this.lbDisk);
            this.panelSubScores.Controls.Add(this.lbGaming);
            this.panelSubScores.Controls.Add(this.lbGraphics);
            this.panelSubScores.Controls.Add(this.lbRam);
            this.panelSubScores.Controls.Add(this.lbProcessor);
            this.panelSubScores.Location = new System.Drawing.Point(607, 34);
            this.panelSubScores.Margin = new System.Windows.Forms.Padding(2);
            this.panelSubScores.Name = "panelSubScores";
            this.panelSubScores.Size = new System.Drawing.Size(125, 251);
            this.panelSubScores.TabIndex = 3;
            // 
            // lblSubScoreDisk
            // 
            this.lbDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisk.Location = new System.Drawing.Point(0, 207);
            this.lbDisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDisk.Name = "lblSubScoreDisk";
            this.lbDisk.Size = new System.Drawing.Size(123, 26);
            this.lbDisk.TabIndex = 8;
            this.lbDisk.Text = "0.0";
            this.lbDisk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubScoreGaming
            // 
            this.lbGaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGaming.Location = new System.Drawing.Point(0, 159);
            this.lbGaming.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGaming.Name = "lblSubScoreGaming";
            this.lbGaming.Size = new System.Drawing.Size(123, 26);
            this.lbGaming.TabIndex = 7;
            this.lbGaming.Text = "0.0";
            this.lbGaming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubScoreGraphics
            // 
            this.lbGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGraphics.Location = new System.Drawing.Point(0, 114);
            this.lbGraphics.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGraphics.Name = "lblSubScoreGraphics";
            this.lbGraphics.Size = new System.Drawing.Size(123, 26);
            this.lbGraphics.TabIndex = 6;
            this.lbGraphics.Text = "0.0";
            this.lbGraphics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubScoreMemory
            // 
            this.lbRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRam.Location = new System.Drawing.Point(0, 69);
            this.lbRam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRam.Name = "lblSubScoreMemory";
            this.lbRam.Size = new System.Drawing.Size(123, 26);
            this.lbRam.TabIndex = 5;
            this.lbRam.Text = "0.0";
            this.lbRam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubScoreProcessor
            // 
            this.lbProcessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessor.Location = new System.Drawing.Point(0, 26);
            this.lbProcessor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessor.Name = "lblSubScoreProcessor";
            this.lbProcessor.Size = new System.Drawing.Size(123, 26);
            this.lbProcessor.TabIndex = 4;
            this.lbProcessor.Text = "0.0";
            this.lbProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRatingDes
            // 
            this.panelRatingDes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelRatingDes.Controls.Add(this.label15);
            this.panelRatingDes.Controls.Add(this.label14);
            this.panelRatingDes.Controls.Add(this.label13);
            this.panelRatingDes.Controls.Add(this.label12);
            this.panelRatingDes.Controls.Add(this.label11);
            this.panelRatingDes.Location = new System.Drawing.Point(270, 34);
            this.panelRatingDes.Margin = new System.Windows.Forms.Padding(2);
            this.panelRatingDes.Name = "panelRatingDes";
            this.panelRatingDes.Size = new System.Drawing.Size(337, 251);
            this.panelRatingDes.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 207);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Data transfer rate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 159);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(248, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "3D gaming graphics performance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 114);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Desktop graphics performance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Memory operations per second";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Calculations per second";
            // 
            // panelComponent
            // 
            this.panelComponent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelComponent.Controls.Add(this.label10);
            this.panelComponent.Controls.Add(this.label9);
            this.panelComponent.Controls.Add(this.label8);
            this.panelComponent.Controls.Add(this.label7);
            this.panelComponent.Controls.Add(this.label6);
            this.panelComponent.Location = new System.Drawing.Point(13, 34);
            this.panelComponent.Margin = new System.Windows.Forms.Padding(2);
            this.panelComponent.Name = "panelComponent";
            this.panelComponent.Size = new System.Drawing.Size(257, 251);
            this.panelComponent.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 207);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Primary Disk";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Gaming";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Graphics";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Memory (RAM)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Processor";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(605, 444);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.ExitBtn);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Update:";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdate.Location = new System.Drawing.Point(401, 15);
            this.lblLastUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(90, 24);
            this.lblLastUpdate.TabIndex = 7;
            this.lblLastUpdate.Text = "Unknown";
            this.lblLastUpdate.Click += new System.EventHandler(this.lblLastUpdate_Click);
            // 
            // btnGetBenchMark
            // 
            this.btnRunBench.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunBench.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunBench.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunBench.Location = new System.Drawing.Point(313, 444);
            this.btnRunBench.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunBench.Name = "btnGetBenchMark";
            this.btnRunBench.Size = new System.Drawing.Size(237, 41);
            this.btnRunBench.TabIndex = 8;
            this.btnRunBench.Text = "Run Bench";
            this.btnRunBench.UseVisualStyleBackColor = true;
            this.btnRunBench.Click += new System.EventHandler(this.btnGetBenchMark_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openToolStripMenuItem.Text = "&Open XML Source File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parsedXmlToolStripMenuItem,
            this.winSATInfoToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.reloadAssessmentsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // parsedXmlToolStripMenuItem
            // 
            this.parsedXmlToolStripMenuItem.Name = "parsedXmlToolStripMenuItem";
            this.parsedXmlToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            // 
            // winSATInfoToolStripMenuItem
            // 
            this.winSATInfoToolStripMenuItem.Name = "winSATInfoToolStripMenuItem";
            this.winSATInfoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbAssessmentFiles});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.historyToolStripMenuItem.Text = "Assessment &History";
            // 
            // tscbAssessmentFiles
            // 
            this.tscbAssessmentFiles.AutoSize = false;
            this.tscbAssessmentFiles.Name = "tscbAssessmentFiles";
            this.tscbAssessmentFiles.Size = new System.Drawing.Size(700, 23);
            this.tscbAssessmentFiles.SelectedIndexChanged += new System.EventHandler(this.tscbAssessmentFiles_SelectedIndexChanged);
            // 
            // reloadAssessmentsToolStripMenuItem
            // 
            this.reloadAssessmentsToolStripMenuItem.Name = "reloadAssessmentsToolStripMenuItem";
            this.reloadAssessmentsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.reloadAssessmentsToolStripMenuItem.Text = "&Reload History";
            this.reloadAssessmentsToolStripMenuItem.Click += new System.EventHandler(this.reloadAssessmentsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(999, 518);
            this.Controls.Add(this.btnRunBench);
            this.Controls.Add(this.lblLastUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1015, 557);
            this.MinimumSize = new System.Drawing.Size(1015, 557);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win Bench";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelBaseScore.ResumeLayout(false);
            this.panelBSHighlight.ResumeLayout(false);
            this.panelBSHighlight.PerformLayout();
            this.panelSubScores.ResumeLayout(false);
            this.panelRatingDes.ResumeLayout(false);
            this.panelRatingDes.PerformLayout();
            this.panelComponent.ResumeLayout(false);
            this.panelComponent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBaseScore;
        private System.Windows.Forms.Panel panelBSHighlight;
        private System.Windows.Forms.TextBox tbBaseScore;
        private System.Windows.Forms.Panel panelSubScores;
        private System.Windows.Forms.Panel panelRatingDes;
        private System.Windows.Forms.Panel panelComponent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Button btnRunBench;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDisk;
        private System.Windows.Forms.Label lbGaming;
        private System.Windows.Forms.Label lbGraphics;
        private System.Windows.Forms.Label lbRam;
        private System.Windows.Forms.Label lbProcessor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parsedXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winSATInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscbAssessmentFiles;
        private System.Windows.Forms.ToolStripMenuItem reloadAssessmentsToolStripMenuItem;
    }
}

