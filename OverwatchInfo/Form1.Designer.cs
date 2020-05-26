namespace OverwatchInfo
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.createTournamentBox = new System.Windows.Forms.GroupBox();
			this.dataButton = new System.Windows.Forms.Button();
			this.amountStagesTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.startButton = new System.Windows.Forms.Button();
			this.tournamentBox = new System.Windows.Forms.GroupBox();
			this.stageListBox = new System.Windows.Forms.ListBox();
			this.addStageButton = new System.Windows.Forms.Button();
			this.addMatchesCountBox = new System.Windows.Forms.GroupBox();
			this.setCountButton = new System.Windows.Forms.Button();
			this.matchCountTextBox = new System.Windows.Forms.TextBox();
			this.stageBox = new System.Windows.Forms.GroupBox();
			this.matchesListBox = new System.Windows.Forms.ListBox();
			this.teamsBox = new System.Windows.Forms.GroupBox();
			this.teamsListBox = new System.Windows.Forms.ListBox();
			this.addTeamButton = new System.Windows.Forms.Button();
			this.addTeamNameBox = new System.Windows.Forms.GroupBox();
			this.setTeamNameButton = new System.Windows.Forms.Button();
			this.teamNameTextBox = new System.Windows.Forms.TextBox();
			this.playersBox = new System.Windows.Forms.GroupBox();
			this.playersListBox = new System.Windows.Forms.ListBox();
			this.addPlayerButton = new System.Windows.Forms.Button();
			this.addNickBox = new System.Windows.Forms.GroupBox();
			this.setNickButton = new System.Windows.Forms.Button();
			this.nickTextBox = new System.Windows.Forms.TextBox();
			this.startTournamentBox = new System.Windows.Forms.GroupBox();
			this.startTournamentButton = new System.Windows.Forms.Button();
			this.matchBox = new System.Windows.Forms.GroupBox();
			this.gamesListBox = new System.Windows.Forms.ListBox();
			this.createTournamentBox.SuspendLayout();
			this.tournamentBox.SuspendLayout();
			this.addMatchesCountBox.SuspendLayout();
			this.stageBox.SuspendLayout();
			this.teamsBox.SuspendLayout();
			this.addTeamNameBox.SuspendLayout();
			this.playersBox.SuspendLayout();
			this.addNickBox.SuspendLayout();
			this.startTournamentBox.SuspendLayout();
			this.matchBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// createTournamentBox
			// 
			this.createTournamentBox.Controls.Add(this.dataButton);
			this.createTournamentBox.Controls.Add(this.amountStagesTextBox);
			this.createTournamentBox.Controls.Add(this.label1);
			this.createTournamentBox.Controls.Add(this.startButton);
			this.createTournamentBox.Location = new System.Drawing.Point(218, 155);
			this.createTournamentBox.Name = "createTournamentBox";
			this.createTournamentBox.Size = new System.Drawing.Size(217, 133);
			this.createTournamentBox.TabIndex = 4;
			this.createTournamentBox.TabStop = false;
			this.createTournamentBox.Text = "Tournament";
			// 
			// dataButton
			// 
			this.dataButton.Location = new System.Drawing.Point(162, 84);
			this.dataButton.Name = "dataButton";
			this.dataButton.Size = new System.Drawing.Size(49, 43);
			this.dataButton.TabIndex = 5;
			this.dataButton.Text = "Data";
			this.dataButton.UseVisualStyleBackColor = true;
			this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
			// 
			// amountStagesTextBox
			// 
			this.amountStagesTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.amountStagesTextBox.Location = new System.Drawing.Point(6, 58);
			this.amountStagesTextBox.Name = "amountStagesTextBox";
			this.amountStagesTextBox.Size = new System.Drawing.Size(205, 20);
			this.amountStagesTextBox.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Enter the amount of stages in tournament";
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(6, 84);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(150, 43);
			this.startButton.TabIndex = 2;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// tournamentBox
			// 
			this.tournamentBox.Controls.Add(this.stageListBox);
			this.tournamentBox.Controls.Add(this.addStageButton);
			this.tournamentBox.Location = new System.Drawing.Point(489, 12);
			this.tournamentBox.Name = "tournamentBox";
			this.tournamentBox.Size = new System.Drawing.Size(153, 149);
			this.tournamentBox.TabIndex = 5;
			this.tournamentBox.TabStop = false;
			this.tournamentBox.Text = "Tournament";
			this.tournamentBox.Visible = false;
			// 
			// stageListBox
			// 
			this.stageListBox.FormattingEnabled = true;
			this.stageListBox.Location = new System.Drawing.Point(6, 19);
			this.stageListBox.Name = "stageListBox";
			this.stageListBox.Size = new System.Drawing.Size(141, 95);
			this.stageListBox.TabIndex = 6;
			this.stageListBox.SelectedIndexChanged += new System.EventHandler(this.stageListBox_SelectedIndexChanged);
			// 
			// addStageButton
			// 
			this.addStageButton.Location = new System.Drawing.Point(6, 120);
			this.addStageButton.Name = "addStageButton";
			this.addStageButton.Size = new System.Drawing.Size(141, 23);
			this.addStageButton.TabIndex = 1;
			this.addStageButton.Text = "Add new stage\r\n";
			this.addStageButton.UseVisualStyleBackColor = true;
			this.addStageButton.Click += new System.EventHandler(this.addStageButton_Click);
			// 
			// addMatchesCountBox
			// 
			this.addMatchesCountBox.Controls.Add(this.setCountButton);
			this.addMatchesCountBox.Controls.Add(this.matchCountTextBox);
			this.addMatchesCountBox.Location = new System.Drawing.Point(489, 412);
			this.addMatchesCountBox.Name = "addMatchesCountBox";
			this.addMatchesCountBox.Size = new System.Drawing.Size(153, 74);
			this.addMatchesCountBox.TabIndex = 6;
			this.addMatchesCountBox.TabStop = false;
			this.addMatchesCountBox.Text = "Set count of matches";
			this.addMatchesCountBox.Visible = false;
			// 
			// setCountButton
			// 
			this.setCountButton.Location = new System.Drawing.Point(6, 45);
			this.setCountButton.Name = "setCountButton";
			this.setCountButton.Size = new System.Drawing.Size(141, 23);
			this.setCountButton.TabIndex = 1;
			this.setCountButton.Text = "Set count";
			this.setCountButton.UseVisualStyleBackColor = true;
			this.setCountButton.Click += new System.EventHandler(this.setCountButton_Click);
			// 
			// matchCountTextBox
			// 
			this.matchCountTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.matchCountTextBox.Location = new System.Drawing.Point(6, 19);
			this.matchCountTextBox.Name = "matchCountTextBox";
			this.matchCountTextBox.Size = new System.Drawing.Size(141, 20);
			this.matchCountTextBox.TabIndex = 0;
			// 
			// stageBox
			// 
			this.stageBox.Controls.Add(this.matchesListBox);
			this.stageBox.Location = new System.Drawing.Point(489, 167);
			this.stageBox.Name = "stageBox";
			this.stageBox.Size = new System.Drawing.Size(153, 239);
			this.stageBox.TabIndex = 7;
			this.stageBox.TabStop = false;
			this.stageBox.Text = "Stage";
			this.stageBox.Visible = false;
			// 
			// matchesListBox
			// 
			this.matchesListBox.FormattingEnabled = true;
			this.matchesListBox.Location = new System.Drawing.Point(6, 19);
			this.matchesListBox.Name = "matchesListBox";
			this.matchesListBox.Size = new System.Drawing.Size(141, 212);
			this.matchesListBox.TabIndex = 2;
			this.matchesListBox.SelectedIndexChanged += new System.EventHandler(this.matchesListBox_SelectedIndexChanged);
			// 
			// teamsBox
			// 
			this.teamsBox.Controls.Add(this.teamsListBox);
			this.teamsBox.Controls.Add(this.addTeamButton);
			this.teamsBox.Location = new System.Drawing.Point(12, 167);
			this.teamsBox.Name = "teamsBox";
			this.teamsBox.Size = new System.Drawing.Size(153, 239);
			this.teamsBox.TabIndex = 8;
			this.teamsBox.TabStop = false;
			this.teamsBox.Text = "Teams";
			this.teamsBox.Visible = false;
			// 
			// teamsListBox
			// 
			this.teamsListBox.FormattingEnabled = true;
			this.teamsListBox.Location = new System.Drawing.Point(6, 19);
			this.teamsListBox.Name = "teamsListBox";
			this.teamsListBox.Size = new System.Drawing.Size(141, 186);
			this.teamsListBox.TabIndex = 6;
			this.teamsListBox.SelectedIndexChanged += new System.EventHandler(this.teamsListBox_SelectedIndexChanged);
			// 
			// addTeamButton
			// 
			this.addTeamButton.Location = new System.Drawing.Point(6, 211);
			this.addTeamButton.Name = "addTeamButton";
			this.addTeamButton.Size = new System.Drawing.Size(141, 23);
			this.addTeamButton.TabIndex = 1;
			this.addTeamButton.Text = "Add new team";
			this.addTeamButton.UseVisualStyleBackColor = true;
			this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
			// 
			// addTeamNameBox
			// 
			this.addTeamNameBox.Controls.Add(this.setTeamNameButton);
			this.addTeamNameBox.Controls.Add(this.teamNameTextBox);
			this.addTeamNameBox.Location = new System.Drawing.Point(12, 412);
			this.addTeamNameBox.Name = "addTeamNameBox";
			this.addTeamNameBox.Size = new System.Drawing.Size(153, 74);
			this.addTeamNameBox.TabIndex = 9;
			this.addTeamNameBox.TabStop = false;
			this.addTeamNameBox.Text = "Add name to new team";
			this.addTeamNameBox.Visible = false;
			// 
			// setTeamNameButton
			// 
			this.setTeamNameButton.Location = new System.Drawing.Point(6, 45);
			this.setTeamNameButton.Name = "setTeamNameButton";
			this.setTeamNameButton.Size = new System.Drawing.Size(141, 23);
			this.setTeamNameButton.TabIndex = 1;
			this.setTeamNameButton.Text = "Set name";
			this.setTeamNameButton.UseVisualStyleBackColor = true;
			this.setTeamNameButton.Click += new System.EventHandler(this.setNameButton_Click);
			// 
			// teamNameTextBox
			// 
			this.teamNameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.teamNameTextBox.Location = new System.Drawing.Point(6, 19);
			this.teamNameTextBox.Name = "teamNameTextBox";
			this.teamNameTextBox.Size = new System.Drawing.Size(141, 20);
			this.teamNameTextBox.TabIndex = 0;
			// 
			// playersBox
			// 
			this.playersBox.Controls.Add(this.playersListBox);
			this.playersBox.Controls.Add(this.addPlayerButton);
			this.playersBox.Location = new System.Drawing.Point(171, 167);
			this.playersBox.Name = "playersBox";
			this.playersBox.Size = new System.Drawing.Size(153, 239);
			this.playersBox.TabIndex = 9;
			this.playersBox.TabStop = false;
			this.playersBox.Text = "Players";
			this.playersBox.Visible = false;
			// 
			// playersListBox
			// 
			this.playersListBox.FormattingEnabled = true;
			this.playersListBox.Location = new System.Drawing.Point(6, 19);
			this.playersListBox.Name = "playersListBox";
			this.playersListBox.Size = new System.Drawing.Size(141, 186);
			this.playersListBox.TabIndex = 6;
			this.playersListBox.SelectedIndexChanged += new System.EventHandler(this.playersListBox_SelectedIndexChanged);
			// 
			// addPlayerButton
			// 
			this.addPlayerButton.Location = new System.Drawing.Point(6, 210);
			this.addPlayerButton.Name = "addPlayerButton";
			this.addPlayerButton.Size = new System.Drawing.Size(141, 23);
			this.addPlayerButton.TabIndex = 1;
			this.addPlayerButton.Text = "Add new player";
			this.addPlayerButton.UseVisualStyleBackColor = true;
			this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
			// 
			// addNickBox
			// 
			this.addNickBox.Controls.Add(this.setNickButton);
			this.addNickBox.Controls.Add(this.nickTextBox);
			this.addNickBox.Location = new System.Drawing.Point(171, 412);
			this.addNickBox.Name = "addNickBox";
			this.addNickBox.Size = new System.Drawing.Size(153, 74);
			this.addNickBox.TabIndex = 10;
			this.addNickBox.TabStop = false;
			this.addNickBox.Text = "Add nick to new player";
			this.addNickBox.Visible = false;
			// 
			// setNickButton
			// 
			this.setNickButton.Location = new System.Drawing.Point(6, 45);
			this.setNickButton.Name = "setNickButton";
			this.setNickButton.Size = new System.Drawing.Size(141, 23);
			this.setNickButton.TabIndex = 1;
			this.setNickButton.Text = "Set nick";
			this.setNickButton.UseVisualStyleBackColor = true;
			this.setNickButton.Click += new System.EventHandler(this.setNickButton_Click);
			// 
			// nickTextBox
			// 
			this.nickTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.nickTextBox.Location = new System.Drawing.Point(6, 19);
			this.nickTextBox.Name = "nickTextBox";
			this.nickTextBox.Size = new System.Drawing.Size(141, 20);
			this.nickTextBox.TabIndex = 0;
			// 
			// startTournamentBox
			// 
			this.startTournamentBox.Controls.Add(this.startTournamentButton);
			this.startTournamentBox.Location = new System.Drawing.Point(330, 412);
			this.startTournamentBox.Name = "startTournamentBox";
			this.startTournamentBox.Size = new System.Drawing.Size(153, 74);
			this.startTournamentBox.TabIndex = 5;
			this.startTournamentBox.TabStop = false;
			this.startTournamentBox.Text = "Start tournament";
			this.startTournamentBox.Visible = false;
			// 
			// startTournamentButton
			// 
			this.startTournamentButton.Location = new System.Drawing.Point(6, 19);
			this.startTournamentButton.Name = "startTournamentButton";
			this.startTournamentButton.Size = new System.Drawing.Size(141, 49);
			this.startTournamentButton.TabIndex = 2;
			this.startTournamentButton.Text = "Start tournament with existing teams";
			this.startTournamentButton.UseVisualStyleBackColor = true;
			this.startTournamentButton.Click += new System.EventHandler(this.startTournamentButton_Click);
			// 
			// matchBox
			// 
			this.matchBox.Controls.Add(this.gamesListBox);
			this.matchBox.Location = new System.Drawing.Point(12, 12);
			this.matchBox.Name = "matchBox";
			this.matchBox.Size = new System.Drawing.Size(153, 149);
			this.matchBox.TabIndex = 7;
			this.matchBox.TabStop = false;
			this.matchBox.Text = "Match";
			this.matchBox.Visible = false;
			// 
			// gamesListBox
			// 
			this.gamesListBox.FormattingEnabled = true;
			this.gamesListBox.Location = new System.Drawing.Point(6, 19);
			this.gamesListBox.Name = "gamesListBox";
			this.gamesListBox.Size = new System.Drawing.Size(141, 121);
			this.gamesListBox.TabIndex = 6;
			this.gamesListBox.SelectedIndexChanged += new System.EventHandler(this.gamesListBox_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(654, 495);
			this.Controls.Add(this.matchBox);
			this.Controls.Add(this.startTournamentBox);
			this.Controls.Add(this.addNickBox);
			this.Controls.Add(this.playersBox);
			this.Controls.Add(this.addTeamNameBox);
			this.Controls.Add(this.teamsBox);
			this.Controls.Add(this.stageBox);
			this.Controls.Add(this.addMatchesCountBox);
			this.Controls.Add(this.tournamentBox);
			this.Controls.Add(this.createTournamentBox);
			this.Name = "Form1";
			this.Text = " ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.createTournamentBox.ResumeLayout(false);
			this.createTournamentBox.PerformLayout();
			this.tournamentBox.ResumeLayout(false);
			this.addMatchesCountBox.ResumeLayout(false);
			this.addMatchesCountBox.PerformLayout();
			this.stageBox.ResumeLayout(false);
			this.teamsBox.ResumeLayout(false);
			this.addTeamNameBox.ResumeLayout(false);
			this.addTeamNameBox.PerformLayout();
			this.playersBox.ResumeLayout(false);
			this.addNickBox.ResumeLayout(false);
			this.addNickBox.PerformLayout();
			this.startTournamentBox.ResumeLayout(false);
			this.matchBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox createTournamentBox;
		private System.Windows.Forms.TextBox amountStagesTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.GroupBox tournamentBox;
		private System.Windows.Forms.ListBox stageListBox;
		private System.Windows.Forms.Button addStageButton;
		private System.Windows.Forms.GroupBox addMatchesCountBox;
		private System.Windows.Forms.Button setCountButton;
		private System.Windows.Forms.TextBox matchCountTextBox;
		private System.Windows.Forms.GroupBox stageBox;
		private System.Windows.Forms.ListBox matchesListBox;
		private System.Windows.Forms.GroupBox teamsBox;
		private System.Windows.Forms.ListBox teamsListBox;
		private System.Windows.Forms.Button addTeamButton;
		private System.Windows.Forms.GroupBox addTeamNameBox;
		private System.Windows.Forms.Button setTeamNameButton;
		private System.Windows.Forms.TextBox teamNameTextBox;
		private System.Windows.Forms.GroupBox playersBox;
		private System.Windows.Forms.ListBox playersListBox;
		private System.Windows.Forms.Button addPlayerButton;
		private System.Windows.Forms.GroupBox addNickBox;
		private System.Windows.Forms.Button setNickButton;
		private System.Windows.Forms.TextBox nickTextBox;
		private System.Windows.Forms.GroupBox startTournamentBox;
		private System.Windows.Forms.Button startTournamentButton;
		private System.Windows.Forms.GroupBox matchBox;
		private System.Windows.Forms.ListBox gamesListBox;
		private System.Windows.Forms.Button dataButton;
	}
}

