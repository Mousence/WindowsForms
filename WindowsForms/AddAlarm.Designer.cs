namespace WindowsForms
{
	partial class AddAlarm
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.lblFileName = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.lblBitSet = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(113, 20);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker2.Location = new System.Drawing.Point(131, 12);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(113, 20);
			this.dateTimePicker2.TabIndex = 1;
			// 
			// lblFileName
			// 
			this.lblFileName.AutoSize = true;
			this.lblFileName.Location = new System.Drawing.Point(9, 44);
			this.lblFileName.Name = "lblFileName";
			this.lblFileName.Size = new System.Drawing.Size(73, 13);
			this.lblFileName.TabIndex = 2;
			this.lblFileName.Text = "labelFileName";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(12, 119);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "Choose File";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.ColumnWidth = 48;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun"});
			this.checkedListBox1.Location = new System.Drawing.Point(131, 44);
			this.checkedListBox1.MultiColumn = true;
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(113, 64);
			this.checkedListBox1.TabIndex = 4;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			// 
			// lblBitSet
			// 
			this.lblBitSet.AutoSize = true;
			this.lblBitSet.Location = new System.Drawing.Point(12, 76);
			this.lblBitSet.Name = "lblBitSet";
			this.lblBitSet.Size = new System.Drawing.Size(57, 13);
			this.lblBitSet.TabIndex = 5;
			this.lblBitSet.Text = "labelBitSet";
			// 
			// AddAlarm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 154);
			this.Controls.Add(this.lblBitSet);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.lblFileName);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Name = "AddAlarm";
			this.Text = "AddAlarm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label lblFileName;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label lblBitSet;
	}
}