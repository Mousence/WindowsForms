namespace WindowsForms
{
    partial class FormAlarm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlarm));
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.cbSounds = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lblSoundFile = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.btnSelectSound = new System.Windows.Forms.Button();
			this.lblCurrentDirectory = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.listView1 = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.maskedTextBox1.Location = new System.Drawing.Point(404, 110);
			this.maskedTextBox1.Mask = " 00:00:00";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(166, 49);
			this.maskedTextBox1.TabIndex = 0;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(406, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "00:00:00";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbSounds
			// 
			this.cbSounds.FormattingEnabled = true;
			this.cbSounds.Location = new System.Drawing.Point(449, 12);
			this.cbSounds.Name = "cbSounds";
			this.cbSounds.Size = new System.Drawing.Size(121, 21);
			this.cbSounds.TabIndex = 2;
			this.cbSounds.SelectedIndexChanged += new System.EventHandler(this.cbSounds_SelectedIndexChanged);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOK.Location = new System.Drawing.Point(404, 326);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(80, 29);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(192, 326);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 29);
			this.button1.TabIndex = 4;
			this.button1.Text = "Запустить будильник";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 13);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 5;
			// 
			// lblSoundFile
			// 
			this.lblSoundFile.AutoSize = true;
			this.lblSoundFile.Location = new System.Drawing.Point(12, 52);
			this.lblSoundFile.Name = "lblSoundFile";
			this.lblSoundFile.Size = new System.Drawing.Size(58, 13);
			this.lblSoundFile.TabIndex = 6;
			this.lblSoundFile.Text = "Sound FIle";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(490, 326);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 29);
			this.button2.TabIndex = 7;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnSelectSound
			// 
			this.btnSelectSound.Location = new System.Drawing.Point(12, 98);
			this.btnSelectSound.Name = "btnSelectSound";
			this.btnSelectSound.Size = new System.Drawing.Size(116, 23);
			this.btnSelectSound.TabIndex = 8;
			this.btnSelectSound.Text = "Select sound";
			this.btnSelectSound.UseVisualStyleBackColor = true;
			this.btnSelectSound.Click += new System.EventHandler(this.btnSelectSound_Click);
			// 
			// lblCurrentDirectory
			// 
			this.lblCurrentDirectory.AutoSize = true;
			this.lblCurrentDirectory.Location = new System.Drawing.Point(12, 76);
			this.lblCurrentDirectory.Name = "lblCurrentDirectory";
			this.lblCurrentDirectory.Size = new System.Drawing.Size(84, 13);
			this.lblCurrentDirectory.TabIndex = 9;
			this.lblCurrentDirectory.Text = "Current directory";
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 127);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(362, 160);
			this.listView1.TabIndex = 10;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// FormAlarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 367);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.lblCurrentDirectory);
			this.Controls.Add(this.btnSelectSound);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.lblSoundFile);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.cbSounds);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.maskedTextBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormAlarm";
			this.Text = "FormAlarm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSounds;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label lblSoundFile;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnSelectSound;
		private System.Windows.Forms.Label lblCurrentDirectory;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ListView listView1;
	}
}