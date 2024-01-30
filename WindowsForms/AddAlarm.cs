using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class AddAlarm : Form
	{
		public Alarm Alarm { get; set; }
		public AddAlarm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string filename = "";
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Multiselect = false;

			DialogResult result = openFile.ShowDialog();
			if (result == DialogResult.OK) {
				filename = openFile.SafeFileName;
				Alarm = new Alarm(dateTimePicker1.Value, filename);
			}
			lblFileName.Text = Alarm.ToString();
		}
	}
}
