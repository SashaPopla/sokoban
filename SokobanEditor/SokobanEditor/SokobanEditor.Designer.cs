namespace SokobanEditor
{
    partial class SokobanEditor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SokobanEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolWall = new System.Windows.Forms.ToolStripButton();
            this.toolAbox = new System.Windows.Forms.ToolStripButton();
            this.toolHere = new System.Windows.Forms.ToolStripButton();
            this.toolDone = new System.Windows.Forms.ToolStripButton();
            this.toolNone = new System.Windows.Forms.ToolStripButton();
            this.toolUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolPrev = new System.Windows.Forms.ToolStripButton();
            this.toolNext = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxLabirintSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSetSize = new System.Windows.Forms.ToolStripButton();
            this.statAbox = new System.Windows.Forms.ToolStripLabel();
            this.statHere = new System.Windows.Forms.ToolStripLabel();
            this.statDone = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolWall,
            this.statAbox,
            this.toolAbox,
            this.statHere,
            this.toolHere,
            this.statDone,
            this.toolDone,
            this.toolNone,
            this.toolUser,
            this.toolStripSeparator1,
            this.toolSave,
            this.toolPrev,
            this.toolNext,
            this.toolStripLabel1,
            this.toolStripTextBoxLabirintSize,
            this.toolStripButtonSetSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(671, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolWall
            // 
            this.toolWall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolWall.Image = global::SokobanEditor.Properties.Resources.wall;
            this.toolWall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolWall.Name = "toolWall";
            this.toolWall.Size = new System.Drawing.Size(23, 22);
            this.toolWall.Text = "Додати стіну";
            this.toolWall.Click += new System.EventHandler(this.toolWall_Click);
            // 
            // toolAbox
            // 
            this.toolAbox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAbox.Image = global::SokobanEditor.Properties.Resources.abox;
            this.toolAbox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAbox.Name = "toolAbox";
            this.toolAbox.Size = new System.Drawing.Size(23, 22);
            this.toolAbox.Text = "Додати ящик";
            this.toolAbox.Click += new System.EventHandler(this.toolAbox_Click);
            // 
            // toolHere
            // 
            this.toolHere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHere.Image = global::SokobanEditor.Properties.Resources.here;
            this.toolHere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolHere.Name = "toolHere";
            this.toolHere.Size = new System.Drawing.Size(23, 22);
            this.toolHere.Text = "Доадти точку куди потрібно ящик";
            this.toolHere.Click += new System.EventHandler(this.toolHere_Click);
            // 
            // toolDone
            // 
            this.toolDone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDone.Image = global::SokobanEditor.Properties.Resources.done;
            this.toolDone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(23, 22);
            this.toolDone.Text = "Додати \"ящик на місці\"";
            this.toolDone.Click += new System.EventHandler(this.toolDone_Click);
            // 
            // toolNone
            // 
            this.toolNone.Checked = true;
            this.toolNone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNone.Image = global::SokobanEditor.Properties.Resources.none;
            this.toolNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNone.Name = "toolNone";
            this.toolNone.Size = new System.Drawing.Size(23, 22);
            this.toolNone.Text = "Додати пустоту";
            this.toolNone.Click += new System.EventHandler(this.toolNone_Click);
            // 
            // toolUser
            // 
            this.toolUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUser.Image = global::SokobanEditor.Properties.Resources.user;
            this.toolUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUser.Name = "toolUser";
            this.toolUser.Size = new System.Drawing.Size(23, 22);
            this.toolUser.Text = "Додати юзера";
            this.toolUser.Click += new System.EventHandler(this.toolUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = global::SokobanEditor.Properties.Resources.save;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(23, 22);
            this.toolSave.Text = "Зберегти";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolPrev
            // 
            this.toolPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrev.Image = global::SokobanEditor.Properties.Resources.prev;
            this.toolPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrev.Name = "toolPrev";
            this.toolPrev.Size = new System.Drawing.Size(23, 22);
            this.toolPrev.Text = "Попередній уровень";
            this.toolPrev.Click += new System.EventHandler(this.toolPrev_Click);
            // 
            // toolNext
            // 
            this.toolNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNext.Image = global::SokobanEditor.Properties.Resources.next;
            this.toolNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNext.Name = "toolNext";
            this.toolNext.Size = new System.Drawing.Size(23, 22);
            this.toolNext.Text = "Наступний уровень";
            this.toolNext.Click += new System.EventHandler(this.toolNext_Click);
            // 
            // panel
            // 
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(671, 462);
            this.panel.TabIndex = 1;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Розмір";
            // 
            // toolStripTextBoxLabirintSize
            // 
            this.toolStripTextBoxLabirintSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxLabirintSize.Name = "toolStripTextBoxLabirintSize";
            this.toolStripTextBoxLabirintSize.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxLabirintSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxLabirintSize_KeyDown);
            // 
            // toolStripButtonSetSize
            // 
            this.toolStripButtonSetSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSetSize.Image = global::SokobanEditor.Properties.Resources.grid;
            this.toolStripButtonSetSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetSize.Name = "toolStripButtonSetSize";
            this.toolStripButtonSetSize.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSetSize.Text = "Задати розмір";
            this.toolStripButtonSetSize.Click += new System.EventHandler(this.toolStripButtonSetSize_Click);
            // 
            // statAbox
            // 
            this.statAbox.Name = "statAbox";
            this.statAbox.Size = new System.Drawing.Size(19, 22);
            this.statAbox.Text = "0х";
            // 
            // statHere
            // 
            this.statHere.Name = "statHere";
            this.statHere.Size = new System.Drawing.Size(19, 22);
            this.statHere.Text = "0х";
            // 
            // statDone
            // 
            this.statDone.Name = "statDone";
            this.statDone.Size = new System.Drawing.Size(19, 22);
            this.statDone.Text = "0x";
            // 
            // SokobanEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 487);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SokobanEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор уровней";
            this.Load += new System.EventHandler(this.SokobanEditor_Load);
            this.Resize += new System.EventHandler(this.SokobanEditor_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolWall;
        private System.Windows.Forms.ToolStripButton toolAbox;
        private System.Windows.Forms.ToolStripButton toolHere;
        private System.Windows.Forms.ToolStripButton toolDone;
        private System.Windows.Forms.ToolStripButton toolNone;
        private System.Windows.Forms.ToolStripButton toolUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolPrev;
        private System.Windows.Forms.ToolStripButton toolNext;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxLabirintSize;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetSize;
        private System.Windows.Forms.ToolStripLabel statAbox;
        private System.Windows.Forms.ToolStripLabel statHere;
        private System.Windows.Forms.ToolStripLabel statDone;
    }
}

