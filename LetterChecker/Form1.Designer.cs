
namespace LetterChecker
{
	partial class Form1
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
			this.wordleTester1 = new LetterChecker.WordleTester();
			this.wordleTester2 = new LetterChecker.WordleTester();
			this.wordleTester3 = new LetterChecker.WordleTester();
			this.SuspendLayout();
			// 
			// wordleTester1
			// 
			this.wordleTester1.Location = new System.Drawing.Point(12, 12);
			this.wordleTester1.Name = "wordleTester1";
			this.wordleTester1.Size = new System.Drawing.Size(1002, 244);
			this.wordleTester1.TabIndex = 0;
			// 
			// wordleTester2
			// 
			this.wordleTester2.Location = new System.Drawing.Point(12, 262);
			this.wordleTester2.Name = "wordleTester2";
			this.wordleTester2.Size = new System.Drawing.Size(1002, 244);
			this.wordleTester2.TabIndex = 1;
			// 
			// wordleTester3
			// 
			this.wordleTester3.Location = new System.Drawing.Point(12, 512);
			this.wordleTester3.Name = "wordleTester3";
			this.wordleTester3.Size = new System.Drawing.Size(1002, 244);
			this.wordleTester3.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1027, 768);
			this.Controls.Add(this.wordleTester3);
			this.Controls.Add(this.wordleTester2);
			this.Controls.Add(this.wordleTester1);
			this.Name = "Form1";
			this.Text = "Letter Checker";
			this.ResumeLayout(false);

		}

		#endregion

		private WordleTester wordleTester1;
		private WordleTester wordleTester2;
		private WordleTester wordleTester3;
	}
}

