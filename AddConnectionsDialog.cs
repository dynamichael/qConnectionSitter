using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Windows.Forms;


namespace qConnectionSitter {

	public partial class AddConnectionsDialog : Form {
		private Parameters _parameters;

		private AddConnectionsDialog(Parameters parameters) {
			InitializeComponent();
			_parameters = parameters;
			_RefreshConnections();
		}

		private void btnRefresh_Click(object sender, EventArgs e) => _RefreshConnections();

		private void btnOk_Click(object sender, EventArgs e) {
			_parameters.Connections.Clear();
			foreach(ListViewItem _ in lsvConnections.SelectedItems) _parameters.Connections.Add(new Parameters.Connection((string)_.Tag, _.Text));
		}

		private void lsvConnections_SelectedIndexChanged(object sender, EventArgs e) {
			btnOk.Enabled = (lsvConnections.SelectedItems.Count != 0);
		}

		private void _RefreshConnections() {
			var interfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach(var _ in interfaces) {
				var item_ = new ListViewItem(_.Name);
				item_.SubItems.Add(_.OperationalStatus.ToString());
				item_.Tag = _.Id;
				lsvConnections.Items.Add(item_);
			}
		}

		public static DialogResult ShowNewDialog(IWin32Window owner, Parameters parameters) {
			using(var dialog = new AddConnectionsDialog(parameters)) return dialog.ShowDialog(owner);
		}


		public class Parameters {
			public List<Connection> Connections { get; private set; } = new List<Connection>();

			public struct Connection {
				public string Id         ;
				public string Description;

				public Connection(string id, string description) {
					Id          = id         ;
					Description = description;
				}
			}

		}

	}

}
