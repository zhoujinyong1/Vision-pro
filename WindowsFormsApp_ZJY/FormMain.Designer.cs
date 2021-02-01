
namespace WindowsFormsApp_ZJY
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jobManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobZJYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cogJobManagerEdit1 = new Cognex.VisionPro.QuickBuild.CogJobManagerEdit();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDanCi = new System.Windows.Forms.Button();
            this.buttonLianXu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobManagerToolStripMenuItem,
            this.用户ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.文件位置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1167, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jobManagerToolStripMenuItem
            // 
            this.jobManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobZJYToolStripMenuItem,
            this.jobSelectToolStripMenuItem});
            this.jobManagerToolStripMenuItem.Name = "jobManagerToolStripMenuItem";
            this.jobManagerToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.jobManagerToolStripMenuItem.Text = "JobManager";
            // 
            // jobZJYToolStripMenuItem
            // 
            this.jobZJYToolStripMenuItem.Name = "jobZJYToolStripMenuItem";
            this.jobZJYToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.jobZJYToolStripMenuItem.Text = "Job_ZJY";
            this.jobZJYToolStripMenuItem.Click += new System.EventHandler(this.jobZJYToolStripMenuItem_Click);
            // 
            // jobSelectToolStripMenuItem
            // 
            this.jobSelectToolStripMenuItem.Name = "jobSelectToolStripMenuItem";
            this.jobSelectToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.jobSelectToolStripMenuItem.Text = "JobSelect";
            this.jobSelectToolStripMenuItem.Click += new System.EventHandler(this.jobSelectToolStripMenuItem_Click);
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.用户ToolStripMenuItem.Text = "用户";
            this.用户ToolStripMenuItem.Click += new System.EventHandler(this.用户ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 文件位置ToolStripMenuItem
            // 
            this.文件位置ToolStripMenuItem.Name = "文件位置ToolStripMenuItem";
            this.文件位置ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.文件位置ToolStripMenuItem.Text = "文件位置";
            this.文件位置ToolStripMenuItem.Click += new System.EventHandler(this.文件位置ToolStripMenuItem_Click);
            // 
            // cogJobManagerEdit1
            // 
            this.cogJobManagerEdit1.Location = new System.Drawing.Point(0, 31);
            this.cogJobManagerEdit1.Name = "cogJobManagerEdit1";
            this.cogJobManagerEdit1.ShowLocalizationTab = false;
            this.cogJobManagerEdit1.Size = new System.Drawing.Size(1167, 656);
            this.cogJobManagerEdit1.Subject = null;
            this.cogJobManagerEdit1.TabIndex = 1;
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(3, 3);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(933, 600);
            this.cogRecordDisplay1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cogRecordDisplay1);
            this.panel1.Location = new System.Drawing.Point(227, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 599);
            this.panel1.TabIndex = 5;
            // 
            // buttonDanCi
            // 
            this.buttonDanCi.Location = new System.Drawing.Point(31, 470);
            this.buttonDanCi.Name = "buttonDanCi";
            this.buttonDanCi.Size = new System.Drawing.Size(75, 23);
            this.buttonDanCi.TabIndex = 6;
            this.buttonDanCi.Text = "单次触发";
            this.buttonDanCi.UseVisualStyleBackColor = true;
            this.buttonDanCi.Click += new System.EventHandler(this.buttonDanCi_Click);
            // 
            // buttonLianXu
            // 
            this.buttonLianXu.Location = new System.Drawing.Point(31, 515);
            this.buttonLianXu.Name = "buttonLianXu";
            this.buttonLianXu.Size = new System.Drawing.Size(75, 23);
            this.buttonLianXu.TabIndex = 7;
            this.buttonLianXu.Text = "连续触发";
            this.buttonLianXu.UseVisualStyleBackColor = true;
            this.buttonLianXu.Click += new System.EventHandler(this.buttonLianXu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 295);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(162, 150);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 688);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonLianXu);
            this.Controls.Add(this.buttonDanCi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cogJobManagerEdit1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jobManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobZJYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobSelectToolStripMenuItem;
        private Cognex.VisionPro.QuickBuild.CogJobManagerEdit cogJobManagerEdit1;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 文件位置ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.Button buttonDanCi;
        private System.Windows.Forms.Button buttonLianXu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}

