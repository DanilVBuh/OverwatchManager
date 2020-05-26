using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverwatchInfo
{
	public partial class Form1 : Form
	{
		Tournament main { get; set; }
		Stage stage;
		Match match;
		Game game;
		Team team;

		public void Init()
		{
			this.main.AddTeam("Sparks");
			this.main.AddTeam("Titans");
			this.main.AddTeam("Dragons");
			this.main.SetStagesCount(4);
			foreach (Team t in this.main.Teams)
			{
				if (t.Name == "Sparks")
				{
					team = t;
					t.AddPlayer("German");
					t.AddPlayer("Denis");
					t.AddPlayer("Gosha");
				}
				if (t.Name == "Titans")
				{
					t.AddPlayer("Dasha");
					t.AddPlayer("Ilya");
					t.AddPlayer("Cross");
				}
				if (t.Name == "Dragons")
				{
					t.AddPlayer("Max");
					t.AddPlayer("Danil");
					t.AddPlayer("Tanya");
				}
			}
			this.main.AddStage(5);
		}

		public Form1()
		{
			InitializeComponent();
			main = new Tournament();
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			string s = amountStagesTextBox.Text;
			if (s != "" && s.All(char.IsDigit))
			{
				int n = Convert.ToInt32(s);
				this.main.SetStagesCount(n);
				tournamentBox.Text = "Tournament: 0/" + n + " stages";
				teamsBox.Visible = true;
				createTournamentBox.Visible = false;
			}
			else
			{
				Show("You enter something wrong");
			}
		}
		public void Show(string text)
		{
			MessageBox.Show(text);
		}

		private void stageListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			stageBox.Visible = true;
			if (stageListBox.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = stageListBox.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = stageListBox.Items[intselectedindex].ToString();
				foreach (Stage s in this.main.Stages)
				{
					if (s.Name == text)
					{
						this.stage = s;
						matchesListBox.Items.Clear();
						stageBox.Text = text;
						foreach (Match m in this.stage.Matches)
						{
							matchesListBox.Items.Add(m.HomeTeam.Name + " VS " + m.VisitingTeam.Name + " ( " + m.Score.HomeTeamWins.ToString() + " : " + m.Score.VisitingTeamWins.ToString() + " )");
						}
					}
				}
			}
		}

		private void addStageButton_Click(object sender, EventArgs e)
		{
			addMatchesCountBox.Visible = true;
		}

		private void setCountButton_Click(object sender, EventArgs e)
		{
			string s = matchCountTextBox.Text;
			if (main.Stages.Count < main.StagesCount)
			{
				int n = Convert.ToInt32(s);
				if (this.main.Stages.Count < this.main.StagesCount)
				{
					this.main.AddStage(n);
					stageListBox.Items.Add("Stage " + main.Stages.Count);
					if (this.main.Stages.Count == this.main.StagesCount)
						addStageButton.Visible = false;
					tournamentBox.Text = "Tournament: " + this.main.Stages.Count.ToString() + "/" + this.main.StagesCount.ToString() + " stages";
					addMatchesCountBox.Visible = false;
				}
				else
				{

				}
			}
		}

		private void addTeamButton_Click(object sender, EventArgs e)
		{
			addTeamNameBox.Visible = true;
		}

		private void setNameButton_Click(object sender, EventArgs e)
		{
			string s = teamNameTextBox.Text;
			teamNameTextBox.Text = "";
			this.main.AddTeam(s);
			teamsListBox.Items.Add(s);
			teamsBox.Text = "Teams: " + this.main.Teams.Count.ToString();
			addTeamNameBox.Visible = false;
		}

		private void teamsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			playersBox.Visible = true;
			if (teamsListBox.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = teamsListBox.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = teamsListBox.Items[intselectedindex].ToString();
				foreach (Team t in this.main.Teams)
				{
					if (t.Name == text || t.Name + " [ " + t.TotalScore.wins.ToString() + " - " + t.TotalScore.loses.ToString() + " ]" == text)
					{
						this.team = t;
						playersListBox.Items.Clear();
						playersBox.Text = text;
						foreach (Player p in team.Players)
						{
							playersListBox.Items.Add(p.Nick);
						}
					}
				}
			}
		}

		private void addPlayerButton_Click(object sender, EventArgs e)
		{
			addNickBox.Visible = true;
		}

		private void setNickButton_Click(object sender, EventArgs e)
		{
			string s = nickTextBox.Text;
			nickTextBox.Text = "";
			this.team.AddPlayer(s);
			playersListBox.Items.Add(s);
			teamsBox.Text = "Teams: " + this.main.Teams.Count.ToString();
			addNickBox.Visible = false;
			if (this.main.Teams.Count >= 2)
			{
				bool b = true;
				foreach (Team t in this.main.Teams)
					if (t.Players.Count < 3)
						b = false;
				if (b)
					startTournamentBox.Visible = true;
			}
		}

		private void startTournamentButton_Click(object sender, EventArgs e)
		{
			addNickBox.Visible = false;
			addTeamNameBox.Visible = false;
			addTeamButton.Visible = false;
			addPlayerButton.Visible = false;
			startTournamentBox.Visible = false;
			tournamentBox.Visible = true;
		}

		private void refresh()
		{
			playersListBox.Items.Clear();
			playersBox.Text = team.Name;
			foreach (Player p in team.Players)
			{
				playersListBox.Items.Add(p.Nick);
			}
			teamsListBox.Items.Clear();
			foreach (Team t in this.main.Teams)
			{
				teamsListBox.Items.Add(t.Name + " [ " + t.TotalScore.wins.ToString() + " - " + t.TotalScore.loses.ToString() + " ]");
			}
		}

		private void matchesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			refresh();
			matchBox.Visible = true;
			if (matchesListBox.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = matchesListBox.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = matchesListBox.Items[intselectedindex].ToString();
				foreach (Match m in this.stage.Matches)
				{
					if (m.HomeTeam.Name + " VS " + m.VisitingTeam.Name + " ( " + m.Score.HomeTeamWins.ToString() + " : " + m.Score.VisitingTeamWins.ToString() + " )" == text)
					{
						this.match = m;
						gamesListBox.Items.Clear();
						matchBox.Text = m.HomeTeam.Name + " VS " + m.VisitingTeam.Name;
						foreach (Game g in match.Games)
						{
							gamesListBox.Items.Add(g.Number.ToString() + ") " + g.Type + " ( " + g.Score.HomeTeamWins.ToString() + " : " + g.Score.VisitingTeamWins.ToString() + " )");
						}
					}
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void dataButton_Click(object sender, EventArgs e)
		{
			Init();
			refresh();
			teamsBox.Visible = true;
			createTournamentBox.Visible = false;
			addNickBox.Visible = false;
			addTeamNameBox.Visible = false;
			addTeamButton.Visible = false;
			addPlayerButton.Visible = false;
			startTournamentBox.Visible = false;
			tournamentBox.Visible = true;
			foreach (Stage s in main.Stages)
			{
				stageListBox.Items.Add("Stage " + s.Number);
			}
			tournamentBox.Text = "Tournament: " + this.main.Stages.Count.ToString() + "/" + this.main.StagesCount.ToString() + " stages";
			if (this.main.Stages.Count == this.main.StagesCount)
				addStageButton.Visible = false;
		}

		private void gamesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (gamesListBox.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = gamesListBox.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = gamesListBox.Items[intselectedindex].ToString();
				foreach (Game g in this.match.Games)
				{
					if (g.Number.ToString() == text.Substring(0, 1))
					{
						this.game = g;
						Form2 frm = new Form2(this.game, this);
						frm.Show();
					}
				}
			}
		}

		public void OnGameFormClosed()
		{
			matchesListBox.Items.Clear();
			foreach (Match m in this.stage.Matches)
			{
				matchesListBox.Items.Add(m.HomeTeam.Name + " VS " + m.VisitingTeam.Name + " ( " + m.Score.HomeTeamWins.ToString() + " : " + m.Score.VisitingTeamWins.ToString() + " )");
			}
			if (this.match.Score.IsEqual())
			{
				this.match.AddControlGame();
			}
			gamesListBox.Items.Clear();
			foreach (Game g in this.match.Games)
			{
				gamesListBox.Items.Add(g.Number.ToString() + ") " + g.Type + " ( " + g.Score.HomeTeamWins.ToString() + " : " + g.Score.VisitingTeamWins.ToString() + " )");
			}
			playersListBox.Items.Clear();
			foreach (Player p in team.Players)
			{
				playersListBox.Items.Add(p.Nick);
			}
			teamsListBox.Items.Clear();
			foreach (Team t in this.main.Teams)
			{
				teamsListBox.Items.Add(t.Name + " [ " + t.TotalScore.wins.ToString() + " - " + t.TotalScore.loses.ToString() + " ]");
			}
		}


		private void addExtraGameButton_Click(object sender, EventArgs e)
		{

		}

		private void playersListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (playersListBox.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = playersListBox.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = playersListBox.Items[intselectedindex].ToString();
				foreach (Player p in this.team.Players)
				{
					if (p.Nick == text)
					{
						if (stage != null)
						{
							PlayerForm frm = new PlayerForm(p, this, stage);
							frm.Show();
						}
					}
				}
			}
		}
	}
}
