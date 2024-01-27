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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (b) button1.Text = "Остановить будильник";
            if (label1.Text == MaskedTextBox1.Text) sp.Play();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Enabled = !maskedTextBox1.Enabled; b = !b;
            if (!b)
            {
                button1.Text = "Запустить будильник";
                //timer01.Stop();
            }
            //else timer01.Start();
        }

        private void cbSounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            sp.SoundLocation = SoundsList[cbSounds.SelectedIndex];
        }
    }
}
