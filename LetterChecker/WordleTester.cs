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
	public partial class WordleTester : UserControl
	{
		public WordleTester()
		{
			InitializeComponent();
		}

		private void tbWords_TextChanged(object sender, EventArgs e)
		{
			var unpressedKeys = new List<Char>(){
				'a', 'b', 'c', 'd', 'e', 'f', 'g',
				'h', 'i', 'j', 'k', 'l', 'm', 'n',
				'o', 'p', 'q', 'r', 's', 't', 'u',
				'v', 'w', 'x', 'y', 'z'};

			foreach (char c in tbWords.Text.ToLower())
			{
				if (Char.IsLetter(c))
				{
					if (unpressedKeys.Contains(c))
					{
						unpressedKeys.Remove(c);
					}

					keyboard1.Key_Press(c);
				}
			}
			foreach (char c in unpressedKeys)
			{
				keyboard1.Key_Release(c);
			}
		}
	}
}
