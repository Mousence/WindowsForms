using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WindowsForms
{
	public partial class FormAlarm : Form
	{
		string[] SoundsList;
		int index;
		// <DateTime, SoundPlayer> Mapped List
		// Load DateTime, SoundPlayer to List, and the add to 
		// if(DateTime.Now.ToString("hh:mm:ss tt") == List -> alarm.ToString("hh:mm:ss tt")) ALARM. Deleting map by DateTime
		//

		//Timer timer01 = new Timer();
		DateTime alarm;
		public DateTime Alarm { get { return alarm; } }
		SoundPlayer sp = new SoundPlayer("..\\Sounds\\alarm-clock-01.wav");
		public SoundPlayer Sp { get { return sp; } }
		public bool B { get { return b; } set { b = false; } }
		public System.Windows.Forms.MaskedTextBox MaskedTextBox1 { get { return maskedTextBox1; } }
		bool b = false;
		public FormAlarm()
		{
			InitializeComponent();
			Directory.SetCurrentDirectory("..\\Sounds");
			SoundsList = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.wav", SearchOption.AllDirectories);
			foreach (string i in SoundsList)
			{
				cbSounds.Items.Add(i.Split('\\').Last());
			}
			maskedTextBox1.Text = DateTime.Now.ToString("hh:mm:ss tt");
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
			if (DateTime.Now.ToString("hh:mm:ss tt") == alarm.ToString("hh:mm:ss tt"))
			{
				sp.Play();
				b = false;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			alarm = DateTime.Parse(maskedTextBox1.Text);
			
			b = !b;
			maskedTextBox1.Enabled = !b;
			buttonAlarm.Text = b ? "Остановить будильник" : "Запустить будильник";
			//timer01.Stop();
			//else timer01.Start();
		}

		private void cbSounds_SelectedIndexChanged(object sender, EventArgs e)
		{
			sp.SoundLocation = SoundsList[cbSounds.SelectedIndex];
		}
	}
}
