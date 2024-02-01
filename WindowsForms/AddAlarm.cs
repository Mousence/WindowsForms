using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsForms
{
	public partial class AddAlarm : Form
	{
		public Alarm Alarm { get; set; }
		public AddAlarm()
		{
			InitializeComponent();
			dateTimePicker1.CustomFormat = "hh:mm:ss";
			dateTimePicker1.ShowUpDown = true;
		}
		public byte GetBitSet() {
			byte days = 0;
			for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++) {
				byte day = (byte)Math.Pow(2, checkedListBox1.CheckedIndices[i]);
				days += day;
			}
			return days;
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
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//AllocConsole();
			Console.Write($"Days:\t");
			for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
			{
				Console.Write(checkedListBox1.CheckedItems[i]+ "\t");
			}
            Console.WriteLine();
            Console.Write($"Days:\t");
			for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
			{
				Console.Write(checkedListBox1.CheckedIndices[i] + "\t");
			}
			Console.WriteLine("\n----------------------------------\n");
			lblBitSet.Text = $"BitSet: {GetBitSet()}";
        }
	}
}
