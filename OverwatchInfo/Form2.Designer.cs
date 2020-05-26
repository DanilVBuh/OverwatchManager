namespace OverwatchInfo
{
	partial class Form2
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
			this.homeTeamBox = new System.Windows.Forms.GroupBox();
			this.homeWinButton = new System.Windows.Forms.Button();
			this.homeTeamListBox = new System.Windows.Forms.ListBox();
			this.visitingTeamBox = new System.Windows.Forms.GroupBox();
			this.visitingWinButton = new System.Windows.Forms.Button();
			this.visitingTeamListBox = new System.Windows.Forms.ListBox();
			this.heroesBox = new System.Windows.Forms.GroupBox();
			this.pickVisitButton = new System.Windows.Forms.Button();
			this.pickHomeButton = new System.Windows.Forms.Button();
			this.heroesListBox = new System.Windows.Forms.ListBox();
			this.eventsBox = new System.Windows.Forms.GroupBox();
			this.eventsListBox = new System.Windows.Forms.ListBox();
			this.addEventButton = new System.Windows.Forms.Button();
			this.setEventBox = new System.Windows.Forms.GroupBox();
			this.actListBox = new System.Windows.Forms.ListBox();
			this.actLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timeTextBox = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.visitButton = new System.Windows.Forms.Button();
			this.homeButton = new System.Windows.Forms.Button();
			this.toLabel = new System.Windows.Forms.Label();
			this.fromLabel = new System.Windows.Forms.Label();
			this.homeTeamBox.SuspendLayout();
			this.visitingTeamBox.SuspendLayout();
			this.heroesBox.SuspendLayout();
			this.eventsBox.SuspendLayout();
			this.setEventBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// homeTeamBox
			// 
			this.homeTeamBox.Controls.Add(this.homeWinButton);
			this.homeTeamBox.Controls.Add(this.homeTeamListBox);
			this.homeTeamBox.Location = new System.Drawing.Point(12, 12);
			this.homeTeamBox.Name = "homeTeamBox";
			this.homeTeamBox.Size = new System.Drawing.Size(153, 121);
			this.homeTeamBox.TabIndex = 10;
			this.homeTeamBox.TabStop = false;
			this.homeTeamBox.Text = "Players";
			// 
			// homeWinButton
			// 
			this.homeWinButton.Location = new System.Drawing.Point(112, 0);
			this.homeWinButton.Name = "homeWinButton";
			this.homeWinButton.Size = new System.Drawing.Size(35, 19);
			this.homeWinButton.TabIndex = 11;
			this.homeWinButton.Text = "Win";
			this.homeWinButton.UseVisualStyleBackColor = true;
			this.homeWinButton.Visible = false;
			this.homeWinButton.Click += new System.EventHandler(this.homeWinButton_Click);
			// 
			// homeTeamListBox
			// 
			this.homeTeamListBox.FormattingEnabled = true;
			this.homeTeamListBox.Location = new System.Drawing.Point(6, 19);
			this.homeTeamListBox.Name = "homeTeamListBox";
			this.homeTeamListBox.Size = new System.Drawing.Size(141, 95);
			this.homeTeamListBox.TabIndex = 6;
			this.homeTeamListBox.SelectedIndexChanged += new System.EventHandler(this.homeTeamListBox_SelectedIndexChanged);
			// 
			// visitingTeamBox
			// 
			this.visitingTeamBox.Controls.Add(this.visitingWinButton);
			this.visitingTeamBox.Controls.Add(this.visitingTeamListBox);
			this.visitingTeamBox.Location = new System.Drawing.Point(427, 12);
			this.visitingTeamBox.Name = "visitingTeamBox";
			this.visitingTeamBox.Size = new System.Drawing.Size(153, 121);
			this.visitingTeamBox.TabIndex = 10;
			this.visitingTeamBox.TabStop = false;
			this.visitingTeamBox.Text = "Players";
			// 
			// visitingWinButton
			// 
			this.visitingWinButton.Location = new System.Drawing.Point(112, 0);
			this.visitingWinButton.Name = "visitingWinButton";
			this.visitingWinButton.Size = new System.Drawing.Size(35, 19);
			this.visitingWinButton.TabIndex = 12;
			this.visitingWinButton.Text = "Win";
			this.visitingWinButton.UseVisualStyleBackColor = true;
			this.visitingWinButton.Visible = false;
			this.visitingWinButton.Click += new System.EventHandler(this.visitingWinButton_Click);
			// 
			// visitingTeamListBox
			// 
			this.visitingTeamListBox.FormattingEnabled = true;
			this.visitingTeamListBox.Location = new System.Drawing.Point(6, 19);
			this.visitingTeamListBox.Name = "visitingTeamListBox";
			this.visitingTeamListBox.Size = new System.Drawing.Size(141, 95);
			this.visitingTeamListBox.TabIndex = 6;
			this.visitingTeamListBox.SelectedIndexChanged += new System.EventHandler(this.visitingTeamListBox_SelectedIndexChanged);
			// 
			// heroesBox
			// 
			this.heroesBox.Controls.Add(this.pickVisitButton);
			this.heroesBox.Controls.Add(this.pickHomeButton);
			this.heroesBox.Controls.Add(this.heroesListBox);
			this.heroesBox.Location = new System.Drawing.Point(171, 12);
			this.heroesBox.Name = "heroesBox";
			this.heroesBox.Size = new System.Drawing.Size(250, 121);
			this.heroesBox.TabIndex = 12;
			this.heroesBox.TabStop = false;
			this.heroesBox.Text = "Heroes";
			this.heroesBox.Visible = false;
			// 
			// pickVisitButton
			// 
			this.pickVisitButton.Location = new System.Drawing.Point(202, 19);
			this.pickVisitButton.Name = "pickVisitButton";
			this.pickVisitButton.Size = new System.Drawing.Size(42, 95);
			this.pickVisitButton.TabIndex = 8;
			this.pickVisitButton.Text = "pick for visit team";
			this.pickVisitButton.UseVisualStyleBackColor = true;
			this.pickVisitButton.Click += new System.EventHandler(this.pickVisitButton_Click);
			// 
			// pickHomeButton
			// 
			this.pickHomeButton.Location = new System.Drawing.Point(6, 19);
			this.pickHomeButton.Name = "pickHomeButton";
			this.pickHomeButton.Size = new System.Drawing.Size(42, 95);
			this.pickHomeButton.TabIndex = 7;
			this.pickHomeButton.Text = "pick for home team";
			this.pickHomeButton.UseVisualStyleBackColor = true;
			this.pickHomeButton.Click += new System.EventHandler(this.pickHomeButton_Click);
			// 
			// heroesListBox
			// 
			this.heroesListBox.FormattingEnabled = true;
			this.heroesListBox.Location = new System.Drawing.Point(55, 19);
			this.heroesListBox.Name = "heroesListBox";
			this.heroesListBox.Size = new System.Drawing.Size(141, 95);
			this.heroesListBox.TabIndex = 6;
			this.heroesListBox.SelectedIndexChanged += new System.EventHandler(this.heroesListBox_SelectedIndexChanged);
			// 
			// eventsBox
			// 
			this.eventsBox.Controls.Add(this.eventsListBox);
			this.eventsBox.Location = new System.Drawing.Point(12, 139);
			this.eventsBox.Name = "eventsBox";
			this.eventsBox.Size = new System.Drawing.Size(568, 121);
			this.eventsBox.TabIndex = 13;
			this.eventsBox.TabStop = false;
			this.eventsBox.Text = "Events";
			this.eventsBox.Visible = false;
			// 
			// eventsListBox
			// 
			this.eventsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.eventsListBox.FormattingEnabled = true;
			this.eventsListBox.Location = new System.Drawing.Point(3, 16);
			this.eventsListBox.Name = "eventsListBox";
			this.eventsListBox.Size = new System.Drawing.Size(562, 102);
			this.eventsListBox.TabIndex = 6;
			// 
			// addEventButton
			// 
			this.addEventButton.Location = new System.Drawing.Point(226, 20);
			this.addEventButton.Name = "addEventButton";
			this.addEventButton.Size = new System.Drawing.Size(141, 28);
			this.addEventButton.TabIndex = 14;
			this.addEventButton.Text = "Add Event";
			this.addEventButton.UseVisualStyleBackColor = true;
			this.addEventButton.Visible = false;
			this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
			// 
			// setEventBox
			// 
			this.setEventBox.Controls.Add(this.actListBox);
			this.setEventBox.Controls.Add(this.actLabel);
			this.setEventBox.Controls.Add(this.label4);
			this.setEventBox.Controls.Add(this.label3);
			this.setEventBox.Controls.Add(this.timeTextBox);
			this.setEventBox.Controls.Add(this.addButton);
			this.setEventBox.Controls.Add(this.label2);
			this.setEventBox.Controls.Add(this.label1);
			this.setEventBox.Controls.Add(this.visitButton);
			this.setEventBox.Controls.Add(this.homeButton);
			this.setEventBox.Controls.Add(this.toLabel);
			this.setEventBox.Controls.Add(this.fromLabel);
			this.setEventBox.Location = new System.Drawing.Point(171, 12);
			this.setEventBox.Name = "setEventBox";
			this.setEventBox.Size = new System.Drawing.Size(250, 121);
			this.setEventBox.TabIndex = 15;
			this.setEventBox.TabStop = false;
			this.setEventBox.Text = "Event settings";
			this.setEventBox.Visible = false;
			// 
			// actListBox
			// 
			this.actListBox.FormattingEnabled = true;
			this.actListBox.Items.AddRange(new object[] {
            "primary fire",
            "secondary fire",
            "first ability",
            "second ability",
            "ultimate"});
			this.actListBox.Location = new System.Drawing.Point(169, 11);
			this.actListBox.Name = "actListBox";
			this.actListBox.Size = new System.Drawing.Size(75, 69);
			this.actListBox.TabIndex = 13;
			this.actListBox.SelectedIndexChanged += new System.EventHandler(this.actListBox_SelectedIndexChanged);
			// 
			// actLabel
			// 
			this.actLabel.AutoSize = true;
			this.actLabel.Location = new System.Drawing.Point(35, 46);
			this.actLabel.Name = "actLabel";
			this.actLabel.Size = new System.Drawing.Size(13, 13);
			this.actLabel.TabIndex = 10;
			this.actLabel.Text = "3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 46);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Act:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Time:";
			// 
			// timeTextBox
			// 
			this.timeTextBox.Location = new System.Drawing.Point(39, 60);
			this.timeTextBox.Name = "timeTextBox";
			this.timeTextBox.Size = new System.Drawing.Size(124, 20);
			this.timeTextBox.TabIndex = 7;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(87, 83);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(76, 23);
			this.addButton.TabIndex = 6;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Visible = false;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "To:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "From:";
			// 
			// visitButton
			// 
			this.visitButton.Location = new System.Drawing.Point(169, 83);
			this.visitButton.Name = "visitButton";
			this.visitButton.Size = new System.Drawing.Size(75, 23);
			this.visitButton.TabIndex = 3;
			this.visitButton.Text = "from visit";
			this.visitButton.UseVisualStyleBackColor = true;
			this.visitButton.Click += new System.EventHandler(this.visitButton_Click);
			// 
			// homeButton
			// 
			this.homeButton.Location = new System.Drawing.Point(6, 83);
			this.homeButton.Name = "homeButton";
			this.homeButton.Size = new System.Drawing.Size(75, 23);
			this.homeButton.TabIndex = 2;
			this.homeButton.Text = "from home";
			this.homeButton.UseVisualStyleBackColor = true;
			this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
			// 
			// toLabel
			// 
			this.toLabel.AutoSize = true;
			this.toLabel.Location = new System.Drawing.Point(36, 33);
			this.toLabel.Name = "toLabel";
			this.toLabel.Size = new System.Drawing.Size(13, 13);
			this.toLabel.TabIndex = 1;
			this.toLabel.Text = "2";
			// 
			// fromLabel
			// 
			this.fromLabel.AutoSize = true;
			this.fromLabel.Location = new System.Drawing.Point(36, 20);
			this.fromLabel.Name = "fromLabel";
			this.fromLabel.Size = new System.Drawing.Size(13, 13);
			this.fromLabel.TabIndex = 0;
			this.fromLabel.Text = "1";
			this.fromLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(592, 263);
			this.Controls.Add(this.setEventBox);
			this.Controls.Add(this.eventsBox);
			this.Controls.Add(this.heroesBox);
			this.Controls.Add(this.visitingTeamBox);
			this.Controls.Add(this.homeTeamBox);
			this.Controls.Add(this.addEventButton);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.homeTeamBox.ResumeLayout(false);
			this.visitingTeamBox.ResumeLayout(false);
			this.heroesBox.ResumeLayout(false);
			this.eventsBox.ResumeLayout(false);
			this.setEventBox.ResumeLayout(false);
			this.setEventBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox homeTeamBox;
		private System.Windows.Forms.ListBox homeTeamListBox;
		private System.Windows.Forms.GroupBox visitingTeamBox;
		private System.Windows.Forms.ListBox visitingTeamListBox;
		private System.Windows.Forms.Button homeWinButton;
		private System.Windows.Forms.Button visitingWinButton;
		private System.Windows.Forms.GroupBox heroesBox;
		private System.Windows.Forms.ListBox heroesListBox;
		private System.Windows.Forms.Button pickVisitButton;
		private System.Windows.Forms.Button pickHomeButton;
		private System.Windows.Forms.GroupBox eventsBox;
		private System.Windows.Forms.ListBox eventsListBox;
		private System.Windows.Forms.Button addEventButton;
		private System.Windows.Forms.GroupBox setEventBox;
		private System.Windows.Forms.Label fromLabel;
		private System.Windows.Forms.Label toLabel;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button visitButton;
		private System.Windows.Forms.Button homeButton;
		private System.Windows.Forms.Label actLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox timeTextBox;
		private System.Windows.Forms.ListBox actListBox;
	}
}