using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUL6
{
	public partial class DevUL6Challenge : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				//string[,,] spies = new string[0,0,0];
				//ViewState.Add("spies", spies);
				string[] assets = new string[0];
				int[] elections = new int[0];
				int[] acts = new int[0];
				ViewState.Add("Assets", assets);
				ViewState.Add("Elections", elections);
				ViewState.Add("Acts", acts);
			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			/*
			string[] spies = (string[])ViewState["spies"];
			Array.Resize(ref spies, spies.Length + 1);
			int newestItem = spies.GetUpperBound(0);
			spies[newestItem] = spiesTextBox1.Text;
			ViewState["spies"] = spies;
			resultLabel.Text=String.Format("Total elections rigged: {0} <br/> average acts of subterfuge: {2}<br/> last asset added: {3}",
			hours
			*/
			string[] assets = (string[])ViewState["Assets"];
			int[] elections = (int[])ViewState["Elections"];
			int[] acts = (int[])ViewState["Acts"];

			int newLength = assets.Length + 1;

			Array.Resize(ref assets, newLength);
			Array.Resize(ref elections, newLength);
			Array.Resize(ref acts, newLength);

			int newIndex = assets.GetUpperBound(0);

			assets[newIndex] = spiesTextBox1.Text;
			elections[newIndex] = int.Parse(spiesTextBox2.Text);
			acts[newIndex] = int.Parse(spiesTextBox3.Text);

			ViewState["Assets"] = assets;
			ViewState["Elections"] = elections;
			ViewState["Acts"] = acts;

			resultLabel.Text = String.Format("Total elections rigged: {0}<br/> Average acts of subterfuge performed: {1:N2} <br/> Last asset added: {2}",
				elections.Sum(),
				acts.Average(),
				assets[newIndex]);
			
			spiesTextBox1.Text = "";
			spiesTextBox2.Text = "";
			spiesTextBox3.Text = "";
			
		}
	}
}