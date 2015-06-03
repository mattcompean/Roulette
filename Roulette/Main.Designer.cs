namespace Roulette
{
    partial class Main
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
            this.numSeeds = new System.Windows.Forms.NumericUpDown();
            this.seedLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numSeeds)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numSeeds
            // 
            this.numSeeds.Location = new System.Drawing.Point(12, 31);
            this.numSeeds.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSeeds.Name = "numSeeds";
            this.numSeeds.Size = new System.Drawing.Size(120, 20);
            this.numSeeds.TabIndex = 0;
            this.numSeeds.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(138, 33);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(89, 13);
            this.seedLabel.TabIndex = 1;
            this.seedLabel.Text = "Number of Seeds";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 73);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(795, 614);
            this.outputBox.TabIndex = 2;
            this.outputBox.Text = "";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(712, 33);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(95, 23);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Create Brackets";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadRosterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadRosterToolStripMenuItem
            // 
            this.loadRosterToolStripMenuItem.Name = "loadRosterToolStripMenuItem";
            this.loadRosterToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.loadRosterToolStripMenuItem.Text = "Load Roster";
            this.loadRosterToolStripMenuItem.Click += new System.EventHandler(this.loadRosterToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 699);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.numSeeds);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(835, 737);
            this.MinimumSize = new System.Drawing.Size(835, 737);
            this.Name = "Main";
            this.Text = "Round Robin Roulette";
            ((System.ComponentModel.ISupportInitialize)(this.numSeeds)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSeeds;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadRosterToolStripMenuItem;
    }
}

