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
	public partial class Form2 : Form
	{
		Game game;
		Team homeTeam;
		Team visitingTeam;
		Form1 form;
		Player homePlayer;
		Player visitingPlayer;
		Pick homePick;
		Pick visitingPick;
		Hero hero;
		string act;
		bool isFromHome = true;
		int picks = 0;
		public Form2(Game g, Form1 f)
		{
			game = g;
			homeTeam = g.HomeTeam;
			visitingTeam = g.VisitingTeam;
			form = f;
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			Text = game.Number.ToString() + ") " + game.Map.Name;
			homeTeamBox.Text = game.HomeTeam.Name;
			visitingTeamBox.Text = game.VisitingTeam.Name;
			Reload();
		}

		//long
		private void Reload()
		{
			////visitingWinButton.Visible = true;
			////homeWinButton.Visible = true;

			homeTeamListBox.Items.Clear();
			foreach (string k in game.HomePick.Keys)
			{
				picks += game.HomePick[k].Count;
			}
			visitingTeamListBox.Items.Clear();
			foreach (string k in game.VisitingPick.Keys)
			{
				picks += game.VisitingPick[k].Count;
			}
			if (picks < 6)
			{
				heroesBox.Visible = true;
				heroesListBox.Items.Clear();
				foreach (string s in this.game.Heroes.Keys)
					foreach (Hero h in this.game.Heroes[s])
					{
						heroesListBox.Items.Add(h.Name + " (" + h.Role + ")");
					}
				foreach (Player p in this.homeTeam.Players)
				{
					homeTeamListBox.Items.Add(p.Nick);
				}
				visitingTeamListBox.Items.Clear();
				foreach (Player p in this.visitingTeam.Players)
				{
					visitingTeamListBox.Items.Add(p.Nick);
				}
			}
			else
			{
				if (!this.game.IsOvered)
				{
					visitingWinButton.Visible = true;
					homeWinButton.Visible = true;
					addEventButton.Visible = true;
				}
				eventsBox.Visible = true;
				heroesBox.Visible = false;
				homeTeamListBox.Visible = true;
				visitingTeamListBox.Visible = true;
				homeTeamListBox.Items.Clear();
				foreach (string s in this.game.HomePick.Keys)
					foreach (Pick p in this.game.HomePick[s])
					{
						homeTeamListBox.Items.Add(p.Player.Nick + " (" + p.Hero.Name + ")");
					}
				visitingTeamListBox.Items.Clear();
				foreach (string s in this.game.VisitingPick.Keys)
					foreach (Pick p in this.game.VisitingPick[s])
					{
						visitingTeamListBox.Items.Add(p.Player.Nick + " (" + p.Hero.Name + ")");
					}
				RefreshEvent();
			}
		}

		private void homeWinButton_Click(object sender, EventArgs e)
		{
			this.homeTeam.TotalScore.AddWin();
			this.visitingTeam.TotalScore.AddLose();
			this.game.Match.Score.AddWinHome();
			this.game.Score.SetScore(1, 0);
			OnClose();
			Close();
		}

		private void visitingWinButton_Click(object sender, EventArgs e)
		{
			this.visitingTeam.TotalScore.AddWin();
			this.homeTeam.TotalScore.AddLose();
			this.game.Match.Score.AddWinVisiting();
			this.game.Score.SetScore(0, 1);
			OnClose();
			Close();
		}

		public void OnClose()
		{
			this.game.IsOvered = true;
			this.form.OnGameFormClosed();
		}

		private void homeTeamListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (homeTeamListBox.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = homeTeamListBox.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = homeTeamListBox.Items[intselectedindex].ToString();
				if (picks < 6)
				{
					foreach (Player p in this.homeTeam.Players)
					{
						if (p.Nick == text)
						{
							this.homePlayer = p;
						}
					}
				}
				else
				{
					foreach (string s in this.game.HomePick.Keys)
						foreach (Pick p in this.game.HomePick[s])
						{
							if (p.Player.Nick + " (" + p.Hero.Name + ")" == text)
							{
								this.homePick = p;
								if (isFromHome)
								{
									fromLabel.Text = text;
								}
								else
								{
									toLabel.Text = text;
								}
							}
						}
				}
			}
		}

		private void visitingTeamListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (visitingTeamListBox.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = visitingTeamListBox.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = visitingTeamListBox.Items[intselectedindex].ToString();
				if (picks < 6)
				{
					foreach (Player p in this.visitingTeam.Players)
					{
						if (p.Nick == text)
						{
							this.visitingPlayer = p;
						}
					}
				}
				else
				{
					foreach (string s in this.game.VisitingPick.Keys)
						foreach (Pick p in this.game.VisitingPick[s])
						{
							if (p.Player.Nick + " (" + p.Hero.Name + ")" == text)
							{
								this.visitingPick = p;
								if (isFromHome)
								{
									toLabel.Text = text;
								}
								else
								{
									fromLabel.Text = text;
								}
							}
						}
				}
			}
		}

		private void heroesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (heroesListBox.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = heroesListBox.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = heroesListBox.Items[intselectedindex].ToString();
				foreach (string s in this.game.Heroes.Keys)
					foreach (Hero h in this.game.Heroes[s])
					{
						if (h.Name + " (" + h.Role + ")" == text)
						{
							this.hero = h;
						}
					}

			}
		}

		private void pickHomeButton_Click(object sender, EventArgs e)
		{
			int intselectedindex = homeTeamListBox.SelectedIndices[0];
			homeTeamListBox.Items.RemoveAt(intselectedindex);
			this.game.HomePick[hero.Role].Add(new Pick(homePlayer, hero));
			int ph = 0;
			foreach (string k in game.HomePick.Keys)
			{
				ph += game.HomePick[k].Count;
			}
			if (ph == 3)
			{
				pickHomeButton.Visible = false;
				if (pickVisitButton.Visible == false)
					Reload();
			}
		}

		private void pickVisitButton_Click(object sender, EventArgs e)
		{
			int intselectedindex = visitingTeamListBox.SelectedIndices[0];
			visitingTeamListBox.Items.RemoveAt(intselectedindex);
			this.game.VisitingPick[hero.Role].Add(new Pick(visitingPlayer, hero));
			int ph = 0;
			foreach (string k in game.VisitingPick.Keys)
			{
				ph += game.VisitingPick[k].Count;
			}
			if (ph == 3)
			{
				pickVisitButton.Visible = false;
				if (pickHomeButton.Visible == false)
					Reload();
			}
		}

		private void addEventButton_Click(object sender, EventArgs e)
		{
			setEventBox.Visible = true;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void homeButton_Click(object sender, EventArgs e)
		{
			isFromHome = true;
			homeButton.Visible = false;
			visitButton.Visible = false;
			addButton.Visible = true;
		}

		private void visitButton_Click(object sender, EventArgs e)
		{
			isFromHome = false;
			homeButton.Visible = false;
			visitButton.Visible = false;
			addButton.Visible = true;
		}

		private void actListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (actListBox.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = actListBox.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				act = actListBox.Items[intselectedindex].ToString();
				actLabel.Text = act;
			}
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			Pick from;
			Pick to;
			if (isFromHome)
			{
				from = homePick;
				to = visitingPick;
			}
			else
			{
				to = homePick;
				from = visitingPick;
			}
			string time = timeTextBox.Text;
			this.game.Events.Add(new Event(from, to, act, time, this.game));
			homeButton.Visible = true;
			visitButton.Visible = true;
			addButton.Visible = false;
			setEventBox.Visible = false;
			RefreshEvent();
		}

		public void RefreshEvent()
		{
			eventsListBox.Items.Clear();
			foreach (Event e in this.game.Events)
			{
				eventsListBox.Items.Add(e.FromPick.Player.Nick + "(" + e.FromPick.Hero.Name + ") [" + e.FromPick.Hero.Skill[e.Act] + "]=> " + e.ToPick.Player.Nick + "(" + e.ToPick.Hero.Name + ") [" + e.Time + "]");
			}
		}
	}
}

