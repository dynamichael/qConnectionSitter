namespace qConnectionSitter {
	partial class AddConnectionsDialog {
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
			this.lsvConnections = new System.Windows.Forms.ListView();
			this.clhConnectionsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clhConnectionsStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lsvConnections
			// 
			this.lsvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhConnectionsName,
            this.clhConnectionsStatus});
			this.lsvConnections.FullRowSelect = true;
			this.lsvConnections.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lsvConnections.Location = new System.Drawing.Point(12, 12);
			this.lsvConnections.Name = "lsvConnections";
			this.lsvConnections.Size = new System.Drawing.Size(380, 217);
			this.lsvConnections.TabIndex = 3;
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
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(317, 237);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Enabled = false;
			this.btnOk.Location = new System.Drawing.Point(236, 237);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 5;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(12, 237);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 6;
			this.btnRefresh.Text = "&Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// AddConnectionsDialog
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(404, 272);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.lsvConnections);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddConnectionsDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Connection";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lsvConnections;
		private System.Windows.Forms.ColumnHeader clhConnectionsName;
		private System.Windows.Forms.ColumnHeader clhConnectionsStatus;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnRefresh;
	}
}