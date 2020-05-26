namespace OverwatchInfo
{
	partial class PlayerForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.eleminationsText = new System.Windows.Forms.Label();
			this.deathsText = new System.Windows.Forms.Label();
			this.mainHeroText = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.teamText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Eleminations: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Deaths: ";
			// 
			// eleminationsText
			// 
			this.eleminationsText.AutoSize = true;
			this.eleminationsText.Location = new System.Drawing.Point(90, 31);
			this.eleminationsText.Name = "eleminationsText";
			this.eleminationsText.Size = new System.Drawing.Size(15, 13);
			this.eleminationsText.TabIndex = 2;
			this.eleminationsText.Text = "el";
			// 
			// deathsText
			// 
			this.deathsText.AutoSize = true;
			this.deathsText.Location = new System.Drawing.Point(90, 53);
			this.deathsText.Name = "deathsText";
			this.deathsText.Size = new System.Drawing.Size(19, 13);
			this.deathsText.TabIndex = 3;
			this.deathsText.Text = "de";
			// 
			// mainHeroText
			// 
			this.mainHeroText.AutoSize = true;
			this.mainHeroText.Location = new System.Drawing.Point(90, 75);
			this.mainHeroText.Name = "mainHeroText";
			this.mainHeroText.Size = new System.Drawing.Size(19, 13);
			this.mainHeroText.TabIndex = 5;
			this.mainHeroText.Text = "he";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Main hero: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Team:";
			// 
			// teamText
			// 
			this.teamText.AutoSize = true;
			this.teamText.Location = new System.Drawing.Point(90, 9);
			this.teamText.Name = "teamText";
			this.teamText.Size = new System.Drawing.Size(16, 13);
			this.teamText.TabIndex = 7;
			this.teamText.Text = "te";
			// 
			// PlayerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGreen;
			this.ClientSize = new System.Drawing.Size(255, 103);
			this.Controls.Add(this.teamText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.mainHeroText);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.deathsText);
			this.Controls.Add(this.eleminationsText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "PlayerForm";
			this.Text = "PlayerForm";
			this.Load += new System.EventHandler(this.PlayerForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label eleminationsText;
		private System.Windows.Forms.Label deathsText;
		private System.Windows.Forms.Label mainHeroText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label teamText;
	}
}