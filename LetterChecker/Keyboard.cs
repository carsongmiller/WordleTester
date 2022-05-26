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
	public partial class Keyboard : UserControl
	{
		Dictionary<Char, Letter> KeyDict = new Dictionary<char, Letter>();
		public Keyboard()
		{
			InitializeComponent();
			foreach (var c in Controls)
			{
				if (c.GetType() == typeof(Letter))
				{
					var thisKey = (Letter)c;
					KeyDict.Add(thisKey.Character, thisKey);
				}
			}
		}

		private void Keyboard_Load(object sender, EventArgs e)
		{
			
		}

		public void Key_Press(char c)
		{
			KeyDict[c.ToString().ToUpper().First()].Used = true;
		}

		public void Key_Release(char c)
		{
			KeyDict[c.ToString().ToUpper().First()].Used = false;
		}
	}
}
