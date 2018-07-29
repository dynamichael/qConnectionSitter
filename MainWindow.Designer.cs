namespace qConnectionSitter {
	partial class MainWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.btnEnable = new System.Windows.Forms.Button();
			this.lblConnectionsText = new System.Windows.Forms.Label();
			this.lsvConnections = new System.Windows.Forms.ListView();
			this.clhConnectionsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhConnectionsStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.lblExecutableText = new System.Windows.Forms.Label();
			this.txtExecutable = new System.Windows.Forms.TextBox();
			this.btnExecutableBrowse = new System.Windows.Forms.Button();
			this.nicTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.SuspendLayout();
			// 
			// btnEnable
			// 
			this.btnEnable.Enabled = false;
			this.btnEnable.Location = new System.Drawing.Point(12, 12);
			this.btnEnable.Name = "btnEnable";
			this.btnEnable.Size = new System.Drawing.Size(379, 23);
			this.btnEnable.TabIndex = 0;
			this.btnEnable.Text = "Enable";
			this.btnEnable.UseVisualStyleBackColor = true;
			this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
			// 
			// lblConnectionsText
			// 
			this.lblConnectionsText.AutoSize = true;
			this.lblConnectionsText.Location = new System.Drawing.Point(12, 49);
			this.lblConnectionsText.Name = "lblConnectionsText";
			this.lblConnectionsText.Size = new System.Drawing.Size(119, 13);
			this.lblConnectionsText.TabIndex = 1;
			this.lblConnectionsText.Text = "Monitored Connections:";
			// 
			// lsvConnections
			// 
			this.lsvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhConnectionsName,
            this.clhConnectionsStatus});
			this.lsvConnections.FullRowSelect = true;
			this.lsvConnections.HideSelection = false;
			this.lsvConnections.Location = new System.Drawing.Point(15, 65);
			this.lsvConnections.Name = "lsvConnections";
			this.lsvConnections.Size = new System.Drawing.Size(376, 115);
			this.lsvConnections.TabIndex = 2;
			this.lsvConnections.UseCompatibleStateImageBehavior = false;
			this.lsvConnections.View = System.Windows.Forms.View.Details;
			this.lsvConnections.SelectedIndexChanged += new System.EventHandler(this.lsvConnections_SelectedIndexChanged);
			// 
			// clhConnectionsName
			// 
			this.clhConnectionsName.Text = "Name";
			this.clhConnectionsName.Width = 291;
			// 
			// clhConnectionsStatus
			// 
			this.clhConnectionsStatus.Text = "Status";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(15, 186);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add...";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Enabled = false;
			this.btnRemove.Location = new System.Drawing.Point(96, 186);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 4;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// lblExecutableText
			// 
			this.lblExecutableText.AutoSize = true;
			this.lblExecutableText.Location = new System.Drawing.Point(12, 221);
			this.lblExecutableText.Name = "lblExecutableText";
			this.lblExecutableText.Size = new System.Drawing.Size(88, 13);
			this.lblExecutableText.TabIndex = 5;
			this.lblExecutableText.Text = "Executable Path:";
			// 
			// txtExecutable
			// 
			this.txtExecutable.Location = new System.Drawing.Point(15, 237);
			this.txtExecutable.Name = "txtExecutable";
			this.txtExecutable.ReadOnly = true;
			this.txtExecutable.Size = new System.Drawing.Size(295, 20);
			this.txtExecutable.TabIndex = 6;
			// 
			// btnExecutableBrowse
			// 
			this.btnExecutableBrowse.Location = new System.Drawing.Point(316, 235);
			this.btnExecutableBrowse.Name = "btnExecutableBrowse";
			this.btnExecutableBrowse.Size = new System.Drawing.Size(75, 24);
			this.btnExecutableBrowse.TabIndex = 7;
			this.btnExecutableBrowse.Text = "Browse...";
			this.btnExecutableBrowse.UseVisualStyleBackColor = true;
			this.btnExecutableBrowse.Click += new System.EventHandler(this.btnExecutableBrowse_Click);
			// 
			// nicTray
			// 
			this.nicTray.Text = "qConnecttionSitter (Disabled)";
			this.nicTray.Visible = true;
			this.nicTray.Click += new System.EventHandler(this.nicTray_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 272);
			this.Controls.Add(this.btnExecutableBrowse);
			this.Controls.Add(this.txtExecutable);
			this.Controls.Add(this.lblExecutableText);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lsvConnections);
			this.Controls.Add(this.lblConnectionsText);
			this.Controls.Add(this.btnEnable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.Text = "qConnectionSitter";
			this.Resize += new System.EventHandler(this.MainWindow_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEnable;
		private System.Windows.Forms.Label lblConnectionsText;
		private System.Windows.Forms.ListView lsvConnections;
		private System.Windows.Forms.ColumnHeader clhConnectionsName;
		private System.Windows.Forms.ColumnHeader clhConnectionsStatus;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Label lblExecutableText;
		private System.Windows.Forms.TextBox txtExecutable;
		private System.Windows.Forms.Button btnExecutableBrowse;
		private System.Windows.Forms.NotifyIcon nicTray;
	}
}