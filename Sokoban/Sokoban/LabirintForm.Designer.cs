namespace Sokoban
{
    partial class LabirintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabirintForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolPrevLevel = new System.Windows.Forms.ToolStripButton();
            this.toolNextLevel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLevelText = new System.Windows.Forms.ToolStripLabel();
            this.toolLevel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStatText = new System.Windows.Forms.ToolStripLabel();
            this.toolStat = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDone = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRestart = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPrevLevel,
            this.toolNextLevel,
            this.toolStripSeparator3,
            this.toolLevelText,
            this.toolLevel,
            this.toolStripSeparator1,
            this.toolStatText,
            this.toolStat,
            this.toolStripSeparator2,
            this.toolDone,
            this.toolStripSeparator4,
            this.toolRestart});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1002, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolPrevLevel
            // 
            this.toolPrevLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrevLevel.Image = global::Sokoban.Properties.Resources.prev;
            this.toolPrevLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrevLevel.Name = "toolPrevLevel";
            this.toolPrevLevel.Size = new System.Drawing.Size(23, 22);
            this.toolPrevLevel.Text = "Прошлий уровень";
            this.toolPrevLevel.Click += new System.EventHandler(this.toolPrevLevel_Click);
            // 
            // toolNextLevel
            // 
            this.toolNextLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNextLevel.Image = global::Sokoban.Properties.Resources.next;
            this.toolNextLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNextLevel.Name = "toolNextLevel";
            this.toolNextLevel.Size = new System.Drawing.Size(23, 22);
            this.toolNextLevel.Text = "Наступний уровень";
            this.toolNextLevel.Click += new System.EventHandler(this.toolNextLevel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolLevelText
            // 
            this.toolLevelText.Name = "toolLevelText";
            this.toolLevelText.Size = new System.Drawing.Size(69, 22);
            this.toolLevelText.Text = "Уровень №";
            // 
            // toolLevel
            // 
            this.toolLevel.Name = "toolLevel";
            this.toolLevel.Size = new System.Drawing.Size(13, 22);
            this.toolLevel.Text = "1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStatText
            // 
            this.toolStatText.Name = "toolStatText";
            this.toolStatText.Size = new System.Drawing.Size(110, 22);
            this.toolStatText.Text = "Розміщено ящіків:";
            // 
            // toolStat
            // 
            this.toolStat.Name = "toolStat";
            this.toolStat.Size = new System.Drawing.Size(30, 22);
            this.toolStat.Text = "0 з 5";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolDone
            // 
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(117, 22);
            this.toolDone.Text = "Уровень пройдений";
            this.toolDone.Visible = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolRestart
            // 
            this.toolRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRestart.Image = global::Sokoban.Properties.Resources.restart;
            this.toolRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRestart.Name = "toolRestart";
            this.toolRestart.Size = new System.Drawing.Size(23, 22);
            this.toolRestart.Text = "Перезагрузити уровень";
            this.toolRestart.Click += new System.EventHandler(this.toolRestart_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1002, 532);
            this.panel.TabIndex = 1;
            this.panel.Resize += new System.EventHandler(this.panel_Resize);
            // 
            // LabirintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 557);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LabirintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LabirintForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LabirintForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolPrevLevel;
        private System.Windows.Forms.ToolStripButton toolNextLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolLevelText;
        private System.Windows.Forms.ToolStripLabel toolLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStatText;
        private System.Windows.Forms.ToolStripLabel toolStat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolDone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolRestart;
        private System.Windows.Forms.Panel panel;
    }
}