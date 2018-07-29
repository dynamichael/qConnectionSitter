using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;


namespace qConnectionSitter {

	public partial class MainWindow : Form {
		private Dictionary<string, string> _monitored  = new Dictionary<string, string>();
		private string                     _executable = null                            ;
		private bool                       _enabled    = false                           ;
		private bool                       _awaiting   = false                           ;
		private bool                       _up         = false                           ;
		private Timer                      _timer      = new Timer()                     ;
		private OpenFileDialog             _openDialog = new OpenFileDialog()            ;

		private static Icon __enabledIcon ;
		private static Icon __disabledIcon;

		public MainWindow() {
			InitializeComponent();
			_openDialog.ShowReadOnly     = false                                                               ;
			_openDialog.CheckFileExists  = true                                                                ;
			_openDialog.Title            = "Select Executable File"                                            ;
			_openDialog.Filter           = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*"                ;
			_openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
			var paths = new string[] { @"C:\Program Files (x86)\qBittorrent\qbittorrent.exe", @"C:\Program Files\qBittorrent\qbittorrent.exe" };
			foreach(var _ in paths) {
				if(File.Exists(_)) {
					_executable = _;
					txtExecutable.Text = _executable;
					break;
				}
			}
			nicTray.Icon = __disabledIcon;
			_timer.Tick     += _timer_Tick;
			_timer.Interval  = 500        ;
			_timer.Enabled   = true       ;
		}

		private void _timer_Tick(object sender, EventArgs e) {
			_timer.Enabled = false;
			_RefreshStatus();
			if(_enabled) {
				if(_awaiting && _up) {
					try {
						var processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(_executable));
						foreach(var _ in processes) {
							_.Kill       ();
							_.WaitForExit();
						}
					} catch { }
					Process.Start(_executable);
					_awaiting = false;
				} else if(!(_awaiting || _up)) {
					_awaiting = true;
				}
			}
			_timer.Enabled = true;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			var parameters = new AddConnectionsDialog.Parameters();
			if(AddConnectionsDialog.ShowNewDialog(this, parameters) == DialogResult.OK) 	{
				foreach(var _ in parameters.Connections) _monitored[_.Id] = _.Description;
				lsvConnections.Items.Clear();
				var items = _monitored.OrderBy(_ => _.Value);
				foreach(var _ in items) {
					var item_ = lsvConnections.Items.Add(_.Key, _.Value, -1);
					item_.Tag = _.Key;
					item_.SubItems.Add("");
				}
				_RefreshStatus();
				_RefreshInterface();
			}
		}

		private void _RefreshStatus() {
			_up = false;
			var interfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach(var _ in interfaces) {
				if(lsvConnections.Items.ContainsKey(_.Id)) {
					var item_ = lsvConnections.Items[_.Id];
					if(item_.SubItems[1].Text != _.OperationalStatus.ToString()) item_.SubItems[1].Text = _.OperationalStatus.ToString();
					if(_.OperationalStatus == OperationalStatus.Up) _up = true;
				}
			}
		}

		private void _RefreshInterface() {
			btnEnable.Enabled = ((_executable != null) && (_monitored.Count != 0));
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			var remove = new List<string>();
			foreach(ListViewItem _ in lsvConnections.SelectedItems) remove.Add((string)_.Tag);
			foreach(var _ in remove) {
				_monitored.Remove(_);
				lsvConnections.Items.RemoveByKey(_);
			}
			btnRemove.Enabled = false;
			_RefreshInterface();
		}

		private void lsvConnections_SelectedIndexChanged(object sender, EventArgs e) {
			btnRemove.Enabled = (lsvConnections.SelectedItems.Count != 0);
		}

		private void btnExecutableBrowse_Click(object sender, EventArgs e) {
			if(_executable != null) {
				_openDialog.InitialDirectory = Path.GetDirectoryName(_executable);
				_openDialog.FileName = Path.GetFileName(_executable);
			}
			if(_openDialog.ShowDialog(this) == DialogResult.OK) {
				_executable = _openDialog.FileName;
				txtExecutable.Text = _executable;
				_RefreshInterface();
			}
		}

		private void MainWindow_Resize(object sender, EventArgs e) {
			Visible = (WindowState != FormWindowState.Minimized);
		}

		private void nicTray_Click(object sender, EventArgs e) {
			if(WindowState == FormWindowState.Minimized) {
				Visible = true;
				WindowState = FormWindowState.Normal;
				Activate();
			} else {
				WindowState = FormWindowState.Minimized;
			}
		}

		private void btnEnable_Click(object sender, EventArgs e) {
			foreach(Control _ in Controls) {
				if(!(_ == btnEnable)) _.Enabled = _enabled;
			}
			if(_enabled) {
				_enabled = false;
				_awaiting = false;
				btnEnable.Text = "Enable";
				nicTray.Text = (Application.ProductName + " (Disabled)");
				nicTray.Icon = __disabledIcon;
			} else {
				_awaiting = !_up;
				_enabled = true;
				btnEnable.Text = "Disable";
				nicTray.Text = (Application.ProductName + " (Enabled)");
				nicTray.Icon = __enabledIcon;
			}
		}

		static MainWindow() {
			using(var bitmap = new Bitmap(16, 16, PixelFormat.Format32bppArgb)) {
				using(var graphics = Graphics.FromImage(bitmap)) {
					graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
					graphics.SmoothingMode = SmoothingMode.HighQuality;
					graphics.FillRectangle(Brushes.Green, 0, 0, 16, 16);
					graphics.DrawRectangle(Pens.White, 0, 0, 16, 16);
					graphics.DrawString("q", SystemFonts.MenuFont, Brushes.White, 3, -3);
				}
				__enabledIcon = Icon.FromHandle(bitmap.GetHicon());
			}
			using(var bitmap = new Bitmap(16, 16, PixelFormat.Format32bppArgb)) {
				using(var graphics = Graphics.FromImage(bitmap)) {
					graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
					graphics.SmoothingMode = SmoothingMode.HighQuality;
					graphics.FillRectangle(Brushes.DarkRed, 0, 0, 16, 16);
					graphics.DrawRectangle(Pens.White, 0, 0, 16, 16);
					graphics.DrawString("q", SystemFonts.MenuFont, Brushes.White, 3, -3);
				}
				__disabledIcon = Icon.FromHandle(bitmap.GetHicon());
			}
		}
	}

}
