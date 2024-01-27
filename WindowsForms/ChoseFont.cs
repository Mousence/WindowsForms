﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace WindowsForms
{
	public partial class ChooseFont : Form
	{
		public int Index { get { return index; } set { index = value; } }
		public string[] AllFonts { get { return allFonts; } }
		int index;
		string[] allFonts;
		public System.Drawing.Font NewFont { get; set; }
		public System.Windows.Forms.Label LblExample { get; }
		public ChooseFont()
		{
			InitializeComponent();
			if (allFonts == null) allFonts = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.?tf", SearchOption.AllDirectories);
			foreach (string i in allFonts)
			{
				cbFonts.Items.Add(i.Split('\\').Last());
			}

		}
		public ChooseFont(string fontFile) : this()
		{
			SetActualFont(fontFile);
		}
		//public ChooseFont(int fontIndex) : this()
		//{
		//	//SetActualFont(fontIndex);
		//    cbFonts.SelectedIndex = fontIndex;
		//	this.Index = fontIndex;
		//	NewFont = (Font);
		//}

		public void SetActualFont(string fontFile)
		{
			index = cbFonts.SelectedIndex = Array.IndexOf(allFonts, fontFile);
			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile(allFonts[cbFonts.SelectedIndex]);
			lblExample.Font = new Font(pfc.Families[0], 48);
		}
		public void SetActualFont(int index)
		{
			this.index = index;
			cbFonts.SelectedIndex = index;
			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile(allFonts[index]);
			lblExample.Font = new Font(pfc.Families[0], 48);
			NewFont = lblExample.Font;
			lblFullName.Text = allFonts[index];
		}


		private void btnCancel_Click(object sender, EventArgs e)
		{
			cbFonts.SelectedIndex = index;
			lblExample.Font = (Font)NewFont.Clone();
			this.Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			//string currentDirectory = Directory.GetCurrentDirectory();
			//MessageBox.Show(this, currentDirectory);
			this.Index = cbFonts.SelectedIndex;
			NewFont = lblExample.Font;
			this.Close();
		}

		private void cbFonts_SelectedIndexChanged(object sender, EventArgs e)
		{
			#region FirstWayToChooseFont
			//lblFullName.Text = allFonts[cbFonts.SelectedIndex];
			//PrivateFontCollection pfc = new PrivateFontCollection();
			////pfc.AddFontFile(cbFonts.SelectedItem.ToString());
			//pfc.AddFontFile(allFonts[cbFonts.SelectedIndex]);
			///*NewFont = new Font(pfc.Families[0], 48);
			//lblExample.Font = NewFont;*/
			//lblExample.Font = new Font(pfc.Families[0], 48);
			//index = cbFonts.SelectedIndex; 
			#endregion
			SetActualFont(cbFonts.SelectedIndex);
			//lblFullName.Text = allFonts[index];
		}
	}
}
