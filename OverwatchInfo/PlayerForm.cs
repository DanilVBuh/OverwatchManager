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
	public partial class PlayerForm : Form
	{
		Player player;
		Form1 form;
		Stage stage;
		Match match;
		Game game;
		Team team;
		int eleminations = 0;
		int deaths = 0;
		int maxPick = 0;
		string heroName = "noone";
		public Dictionary<string, int> picks = new Dictionary<string, int> { };
		public PlayerForm(Player p, Form1 f, Stage s)
		{
			player = p;
			form = f;
			team = p.Team;
			stage = s;
			InitializeComponent();
		}

		private void PlayerForm_Load(object sender, EventArgs e)
		{
			teamText.Text = player.Team.Name;
			foreach (Match m in this.stage.Matches)
			{
				foreach (Game g in m.Games)
				{
					foreach (Event ev in g.Events)
					{
						if (ev.FromPick.Player == player)
						{
							eleminations++;
						}
					}
				}
			}
			eleminationsText.Text = eleminations.ToString();
			foreach (Match m in this.stage.Matches)
			{
				foreach (Game g in m.Games)
				{
					foreach (Event ev in g.Events)
					{
						if (ev.ToPick.Player == player)
						{
							deaths++;
						}
					}
					game = g;
				}
			}
			deathsText.Text = deaths.ToString();
			foreach (string s in game.Heroes.Keys)
			{
				foreach (Hero h in game.Heroes[s])
				{
					picks.Add(h.Name, 0);
				}
			}
			foreach (Match m in this.stage.Matches)
			{
				foreach (Game g in m.Games)
				{
					foreach (string s in g.HomePick.Keys)
					{
						foreach (Pick p in g.HomePick[s])
						{
							if (p.Player == player)
							{
								picks[p.Hero.Name]++;
							}
						}
					}
					foreach (string s in g.VisitingPick.Keys)
					{
						foreach (Pick p in g.VisitingPick[s])
						{
							if (p.Player == player)
							{
								picks[p.Hero.Name]++;
							}
						}
					}
				}
			}
			foreach (string s in picks.Keys)
			{
				if (picks[s] > maxPick)
				{
					maxPick = picks[s];
					heroName = s;
				}
			}
			mainHeroText.Text = heroName;

		}
	}
}
