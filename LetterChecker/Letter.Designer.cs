
namespace LetterChecker
{
	partial class Letter
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
			this.panelBG = new System.Windows.Forms.Panel();
			this.tbLetter = new System.Windows.Forms.TextBox();
			this.panelBG.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBG
			// 
			this.panelBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBG.Controls.Add(this.tbLetter);
			this.panelBG.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBG.Location = new System.Drawing.Point(0, 0);
			this.panelBG.Name = "panelBG";
			this.panelBG.Size = new System.Drawing.Size(75, 75);
			this.panelBG.TabIndex = 0;
			this.panelBG.SizeChanged += new System.EventHandler(this.panelBG_SizeChanged);
			this.panelBG.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBG_Paint);
			// 
			// tbLetter
			// 
			this.tbLetter.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbLetter.Location = new System.Drawing.Point(12, 9);
			this.tbLetter.MaxLength = 1;
			this.tbLetter.Name = "tbLetter";
			this.tbLetter.Size = new System.Drawing.Size(48, 55);
			this.tbLetter.TabIndex = 2;
			this.tbLetter.Text = "A";
			this.tbLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Letter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelBG);
			this.Name = "Letter";
			this.Size = new System.Drawing.Size(75, 75);
			this.Load += new System.EventHandler(this.Letter_Load);
			this.panelBG.ResumeLayout(false);
			this.panelBG.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBG;
		private System.Windows.Forms.TextBox tbLetter;
	}
}
