namespace SetYourProxy
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnStart = new System.Windows.Forms.Button();
			this.cmbProxyList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnStop = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblRunningStatus = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showMainFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(47, 96);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(105, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start Auto Setting";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// cmbProxyList
			// 
			this.cmbProxyList.FormattingEnabled = true;
			this.cmbProxyList.Location = new System.Drawing.Point(124, 52);
			this.cmbProxyList.Name = "cmbProxyList";
			this.cmbProxyList.Size = new System.Drawing.Size(121, 21);
			this.cmbProxyList.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select Pac URL:";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 166);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(322, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 17);
			// 
			// timer1
			// 
			this.timer1.Interval = 300000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnStop
			// 
			this.btnStop.Enabled = false;
			this.btnStop.Location = new System.Drawing.Point(168, 96);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(105, 23);
			this.btnStop.TabIndex = 0;
			this.btnStop.Text = "Stop Auto Setting";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Running Status:";
			// 
			// lblRunningStatus
			// 
			this.lblRunningStatus.AutoSize = true;
			this.lblRunningStatus.Location = new System.Drawing.Point(128, 25);
			this.lblRunningStatus.Name = "lblRunningStatus";
			this.lblRunningStatus.Size = new System.Drawing.Size(47, 13);
			this.lblRunningStatus.TabIndex = 7;
			this.lblRunningStatus.Text = "Stopped";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipText = "ChooseYourProxy";
			this.notifyIcon1.BalloonTipTitle = "ChooseYourProxy";
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "ChooseYourProxy";
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMainFormToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(165, 48);
			// 
			// showMainFormToolStripMenuItem
			// 
			this.showMainFormToolStripMenuItem.Name = "showMainFormToolStripMenuItem";
			this.showMainFormToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.showMainFormToolStripMenuItem.Text = "Show Main Form";
			this.showMainFormToolStripMenuItem.Click += new System.EventHandler(this.showMainFormToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 188);
			this.Controls.Add(this.lblRunningStatus);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbProxyList);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "ChooseYourProxy";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ComboBox cmbProxyList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblRunningStatus;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem showMainFormToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

