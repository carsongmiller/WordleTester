
namespace LetterChecker
{
	partial class WordleTester
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.keyboard1 = new LetterChecker.Keyboard();
			this.tbWords = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// keyboard1
			// 
			this.keyboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.keyboard1.BackColor = System.Drawing.Color.Transparent;
			this.keyboard1.Location = new System.Drawing.Point(189, 0);
			this.keyboard1.Name = "keyboard1";
			this.keyboard1.Size = new System.Drawing.Size(810, 243);
			this.keyboard1.TabIndex = 3;
			// 
			// tbWords
			// 
			this.tbWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbWords.Location = new System.Drawing.Point(3, 3);
			this.tbWords.Multiline = true;
			this.tbWords.Name = "tbWords";
			this.tbWords.Size = new System.Drawing.Size(180, 238);
			this.tbWords.TabIndex = 2;
			this.tbWords.TextChanged += new System.EventHandler(this.tbWords_TextChanged);
			// 
			// WordleTester
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.keyboard1);
			this.Controls.Add(this.tbWords);
			this.Name = "WordleTester";
			this.Size = new System.Drawing.Size(1002, 244);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Keyboard keyboard1;
		private System.Windows.Forms.TextBox tbWords;
	}
}
