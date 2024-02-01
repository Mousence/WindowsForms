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
using System.Net;
using WMPLib;
using System.Security.Claims;

namespace WindowsForms
{
    public partial class FormAlarm : Form
    {
        string[] SoundsList;
        int index;

		DateTime alarm;
		SortedDictionary<DateTime, SoundPlayer> SoundList = new SortedDictionary<DateTime, SoundPlayer>();
        List<SortedDictionary<DateTime, SoundPlayer>> AlarmList = new List<SortedDictionary<DateTime, SoundPlayer>>();
		// <DateTime, SoundPlayer> Mapped List
		// Load DateTime, SoundPlayer to List, and the add to ListView1
		// if(DateTime.Now.ToString("hh:mm:ss tt") == List -> alarm.ToString("hh:mm:ss tt")) ALARM.
        // Deleting map asigned by DateTime in Mapped list. Refresh ListView1

		//Timer timer01 = new Timer();

		SoundPlayer sp = new SoundPlayer("..\\Sounds\\alarm-clock-01.wav");
        public SoundPlayer Sp { get { return sp; } }
        public bool B { get { return b; } }
        public System.Windows.Forms.MaskedTextBox MaskedTextBox1 { get {return maskedTextBox1; } }
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
            cbSounds.SelectedIndex = 0;
            axWindowsMediaPlayer1.URL = sp.SoundLocation.Split('\\').Last();
        }
		private string GetAlarmText(DateTime alarmTime, SoundPlayer soundPlayer)
		{
			return $"{alarmTime.ToString()} - {soundPlayer.SoundLocation.Split('\\').Last()}";
		}
		private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
			foreach (var AlarmEntry in AlarmList.ToList())
			{
				foreach (var alarmTime in AlarmEntry.Keys.ToList())
				{
					if (DateTime.Now.ToString("hh:mm:ss tt") == alarmTime.ToString("hh:mm:ss tt"))
					{
						SoundPlayer soundPlayer = AlarmEntry[alarmTime];
						soundPlayer.Play();
                        AlarmList.Remove(AlarmEntry);
                        lstBoxSound.Items.RemoveAt(0);
					}
				}
			}
		}

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			alarm = DateTime.Parse(maskedTextBox1.Text);

			maskedTextBox1.Enabled = !maskedTextBox1.Enabled; b = !b;
            if (!b) button1.Text = "Остановить будильник";
            else {
                if (!SoundList.ContainsKey(alarm)) {
					SoundList.Add(alarm, sp);
                    AlarmList.Add(SoundList);
                    lstBoxSound.Items.Add(GetAlarmText(alarm, sp));
                }
                button1.Text = "Запустить будильник";
            }
        }

        private void cbSounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSoundFile.Text = cbSounds.Text;
            sp.SoundLocation = SoundsList[cbSounds.SelectedIndex];
        }

		private void btnSelectSound_Click(object sender, EventArgs e)
		{
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            DialogResult result = openFileDialog.ShowDialog();
            lblSoundFile.Text = openFileDialog.SafeFileName;
            lblCurrentDirectory.Text = Directory.GetCurrentDirectory();
            Stream file = openFileDialog.OpenFile();
            //WMPLib.WMPCore wmp = new WMPLib.WMPCore();

            axWindowsMediaPlayer1.URL = openFileDialog.FileName;
            axWindowsMediaPlayer1.Ctlcontrols.play();
		}

		private void btnAlarm_Click(object sender, EventArgs e)
		{
            AddAlarm addAlarm = new AddAlarm();
            DialogResult result = addAlarm.ShowDialog(this);
            if (result == DialogResult.OK) {
				lstBoxSound.Items.Add(addAlarm.Alarm.ToString());
            }
		}
	}
}

