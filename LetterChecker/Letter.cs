using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterChecker
{
	public partial class Letter : UserControl
	{
		private bool _used = false;
		public bool Used
		{
			get
			{
				return _used;
			}
			set
			{
				_used = value;
				if (value)
				{
					Color_Border_Current = Color_Border_Used;
					Color_BG_Current = Color_BG_Used;
					tbLetter.ForeColor = Color_Text_Used;
					tbLetter.BackColor = Color_BG_Used;
				}
				else
				{
					Color_Border_Current = Color_Border_Unused;
					Color_BG_Current = Color_BG_Unused;
					tbLetter.ForeColor = Color_Text_Unused;
					tbLetter.BackColor = Color_BG_Unused;
				}
				panelBG.Invalidate();
			}
		}
		public int BorderWidth { get; set; } = 5;
		
		public Color Color_Border_Used { get; set; } = Color.Green;
		public Color Color_Border_Unused { get; set; } = Color.Gray;
		private Color Color_Border_Current { get; set; }
		public Color Color_Text_Used { get; set; } = Color.DarkGreen;
		public Color Color_Text_Unused { get; set; } = Color.Gray;
		public Color Color_BG_Used { get; set; } = Color.LightGreen;
		public Color Color_BG_Unused { get; set; } = Color.LightGray;
		private Color Color_BG_Current { get; set; }
		public char Character
		{
			get
			{
				return tbLetter.Text.First();
			}
			set
			{
				tbLetter.Text = value.ToString();
			}
		}


		public Letter()
		{
			InitializeComponent();
		}

		private void panelBG_Paint(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder(
				e.Graphics, panelBG.ClientRectangle,
				Color_Border_Current, BorderWidth, ButtonBorderStyle.Solid,
				Color_Border_Current, BorderWidth, ButtonBorderStyle.Solid,
				Color_Border_Current, BorderWidth, ButtonBorderStyle.Solid,
				Color_Border_Current, BorderWidth, ButtonBorderStyle.Solid);

			BackColor = Color_BG_Current;
		}

		private void panelBG_SizeChanged(object sender, EventArgs e)
		{
			var newLoc = new Point();
			newLoc.X = (Width - tbLetter.Width) / 2;
			newLoc.Y = (Height - tbLetter.Height) / 2;
			tbLetter.Location = newLoc;
		}

		private void Letter_Load(object sender, EventArgs e)
		{
			Used = false;
		}
	}
}
