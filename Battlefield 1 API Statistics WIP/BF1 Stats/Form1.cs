using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;

namespace BF1_Stats
{
    //https://dotnetrix.co.uk/tabcontrol.htm#tip2
    //https://www.youtube.com/watch?v=6ua-IegyKB4
    //https://www.youtube.com/watch?v=vfWnb6zGXLI

    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPlayerName.Text) && txtPlayerName.Text != "Enter Player Name To Search")
            {
                //SOLVE ISSUES WITH PLAYER STATS NOT WORKING IF WEBSITE DOESNT WORK
                Platform platform = new Platform(cbxPlatform.SelectedIndex + 1);
                string link = "Stats/detailedStats?platform=" + platform.GetPlatformID() + "&displayName=" + txtPlayerName.Text;
                //https://battlefieldtracker.com/bf1/profile/pc/Norey/matches
                var baseAddress = new Uri("https://battlefieldtracker.com/bf1/api/");
                var result = new System.Net.WebClient().DownloadString("https://battlefieldtracker.com/bf1/profile/" + platform.GetPlatformString() + "/" + txtPlayerName.Text + "/matches");
                txtResults.Text = result;
                if (txtResults.Text.Contains("PleaseSupportSite.onDetected(adBlockDetected);"))
                    {
                    int index1 = txtResults.Text.IndexOf("PleaseSupportSite.onDetected(adBlockDetected);");
                    }
                using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                {
                
                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("trn-api-key", "c8dfbf65-8572-4733-adf8-ca6977cbaa6f");
                    using (var response = await httpClient.GetAsync(link))
                    {
                
                        string responseData = await response.Content.ReadAsStringAsync();
                        determineGeneralStats(ref responseData, platform.GetPlatformID());
                        //txtResults.Text = responseData;
                    }
                }
                tabControlMain.SelectedIndex = 1;
                //listPanel[0].SendToBack();
                //listPanel[0].Visible = false;
                //listPanel[1].BringToFront();
                //listPanel[1].Visible = true;
                txtPlayerName.Text = "";
                txtPlayerName_CheckText();
            }
        }

        public void determineGeneralStats(ref string playerStats, int platform) // Goes through the player stats. Sets relevant data to be displayed on GeneralStatsPanel
        {
            if (playerStats.Contains("\"successful\": true"))
            {
                int index = 0;
                int offset = 0;

                index = playerStats.IndexOf("\"flagsCaptured");
                offset = 17;
                int playerCaps = Convert.ToInt32(playerStats.Substring(index+offset, (playerStats.IndexOf(",",index) - (index+offset))));
                lblCaptures.Text = playerCaps.ToString();

                index = playerStats.IndexOf("\"flagsDefended");
                int playerDefends = Convert.ToInt32(playerStats.Substring(index+offset, (playerStats.IndexOf(",", index) - (index + offset))));
                lblDefends.Text = playerDefends.ToString();

                index = playerStats.IndexOf("\"kills");
                offset = 9;
                int playerKills = Convert.ToInt32(playerStats.Substring(index + offset, (playerStats.IndexOf(",", index) - (index + offset))));
                lblKills.Text = playerKills.ToString();

                index = playerStats.IndexOf("\"wins");
                offset = 8;
                int playerWins = Convert.ToInt32(playerStats.Substring(index + offset, (playerStats.IndexOf(",", index) - (index + offset))));
                lblWins.Text = playerWins.ToString();

                index = playerStats.IndexOf("\"losses");
                offset = 10;
                int playerLosses = Convert.ToInt32(playerStats.Substring(index + offset, (playerStats.IndexOf(",", index) - (index + offset))));
                lblLosses.Text = playerLosses.ToString();
                //int playerMVP; // would have to find via internet

                index = playerStats.IndexOf("\"deaths");
                offset = 10;
                int playerDeaths = Convert.ToInt32(playerStats.Substring(index + offset, (playerStats.IndexOf(",", index) - (index + offset))));
                lblDeaths.Text = playerDeaths.ToString();

                double playerKD = Math.Round((double)playerKills/(double)playerDeaths, 2);
                lblKD.Text = playerKD.ToString();

                double playerWL = Math.Round(((double)playerWins / ((double)(playerWins + playerLosses)) * 100),2);
                lblWL.Text = playerWL.ToString()+"%";

                index = playerStats.IndexOf("\"spm");
                offset = 7;
                double playerSPM = Math.Round(Convert.ToDouble(playerStats.Substring(index + offset, (playerStats.IndexOf(",", index) - (index + offset)))), 2);
                lblSPM.Text = playerSPM.ToString();

                index = playerStats.IndexOf("\"kpm");
                offset = 7;
                double playerKPM = Math.Round(Convert.ToDouble(playerStats.Substring(index + offset, (playerStats.IndexOf(",", index) - (index + offset)))), 2);
                lblKPM.Text = playerKPM.ToString();

                index = playerStats.IndexOf("\"skill");
                offset = 9;
                double playerSkill = Convert.ToDouble(playerStats.Substring(index + offset, (playerStats.IndexOf(",", index) - (index + offset))));
                lblSkill.Text = playerSkill.ToString();

                index = playerStats.IndexOf("\"accuracyRatio");
                offset = 17;
                double playerAccuracy = (Math.Round(Convert.ToDouble(playerStats.Substring(index + offset, (playerStats.IndexOf(",", index) - (index + offset)))), 2)*100);
                lblAccuracy.Text = playerAccuracy.ToString()+ "%";

                index = playerStats.IndexOf("\"favoriteClass");
                offset = 18;
                string playerClass = playerStats.Substring(index + offset, ((playerStats.IndexOf(",", index)-1) - (index + offset)));
                lblBestClass.Text = playerClass;

                index = playerStats.IndexOf("\"displayName");
                offset = 16;
                string playerName = playerStats.Substring(index + offset, ((playerStats.IndexOf(",", index)-1) - (index + offset)));
                lblNameSTATIC.Text = playerName;
                lblNameSTATIC.Location = new System.Drawing.Point((tabControlMain.Width/2)-(lblNameSTATIC.Width/2), 40-(lblNameSTATIC.Height/2));

                index = playerStats.IndexOf("\"gameModeStats");
                string subString = playerStats.Substring(index, (playerStats.IndexOf("\"headShots")-index));
                //txtResults.Text = subString;

                index = subString.IndexOf("\"WAR PIGEONS");
                offset = 10;
                int warPigeonsLosses = Convert.ToInt32(subString.Substring(subString.IndexOf("\"losses", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"losses", index)) - (subString.IndexOf("\"losses", index) + offset))));
                index = subString.IndexOf("\"CONQUEST");
                int conquestLosses = Convert.ToInt32(subString.Substring(subString.IndexOf("\"losses", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"losses", index)) - (subString.IndexOf("\"losses", index) + offset))));
                index = subString.IndexOf("\"TEAM DEATHMATCH");
                int tdmLosses = Convert.ToInt32(subString.Substring(subString.IndexOf("\"losses", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"losses", index)) - (subString.IndexOf("\"losses", index) + offset))));
                index = subString.IndexOf("\"DOMINATION");
                int dominationLosses = Convert.ToInt32(subString.Substring(subString.IndexOf("\"losses", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"losses", index)) - (subString.IndexOf("\"losses", index) + offset))));
                index = subString.IndexOf("\"RUSH");
                int rushLosses = Convert.ToInt32(subString.Substring(subString.IndexOf("\"losses", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"losses", index)) - (subString.IndexOf("\"losses", index) + offset))));
                index = subString.IndexOf("\"OPERATIONS SMALL");
                int operationsLosses = Convert.ToInt32(subString.Substring(subString.IndexOf("\"losses", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"losses", index)) - (subString.IndexOf("\"losses", index) + offset))));

                index = subString.IndexOf("\"WAR PIGEONS");
                offset = 8;
                int warPigeonsWins = Convert.ToInt32(subString.Substring(subString.IndexOf("\"wins", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"wins", index)) - (subString.IndexOf("\"wins", index) + offset))));
                index = subString.IndexOf("\"CONQUEST");
                int conquestWins = Convert.ToInt32(subString.Substring(subString.IndexOf("\"wins", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"wins", index)) - (subString.IndexOf("\"wins", index) + offset))));
                index = subString.IndexOf("\"TEAM DEATHMATCH");
                int tdmWins = Convert.ToInt32(subString.Substring(subString.IndexOf("\"wins", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"wins", index)) - (subString.IndexOf("\"wins", index) + offset))));
                index = subString.IndexOf("\"DOMINATION");
                int dominationWins = Convert.ToInt32(subString.Substring(subString.IndexOf("\"wins", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"wins", index)) - (subString.IndexOf("\"wins", index) + offset))));
                index = subString.IndexOf("\"RUSH");
                int rushWins = Convert.ToInt32(subString.Substring(subString.IndexOf("\"wins", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"wins", index)) - (subString.IndexOf("\"wins", index) + offset))));
                index = subString.IndexOf("\"OPERATIONS SMALL");
                int operationsWins = Convert.ToInt32(subString.Substring(subString.IndexOf("\"wins", index) + offset, (subString.IndexOf(",", subString.IndexOf("\"wins", index)) - (subString.IndexOf("\"wins", index) + offset))));

                DrawPieChart(warPigeonsLosses+warPigeonsWins, conquestLosses+conquestWins, tdmLosses+tdmWins, dominationLosses+dominationWins, rushLosses+rushWins, operationsLosses+operationsWins);

                try
                {
                    // Check if the player file already exists. If yes, check the retrieved stats against previous stats. If no, create the file and populate data.
                    if (File.Exists(playerName + platform + ".txt"))
                    {
                        //check stats vs old stats
                        //rewrite over them
                        //add last play time?
                        using (StreamReader sr = File.OpenText(playerName + platform + ".txt"))
                        {
                            double val;
                            if (Double.TryParse(File.ReadLines(playerName + platform + ".txt").Skip(0).Take(1).First(), out val))
                            {
                                if (val<playerKD)
                                {
                                    pbxKD.Visible = true; 
                                    pbxKD.Image = Image.FromFile("GreenArrow.png");
                                }
                                else if(val == playerKD)
                                {
                                    pbxKD.Visible = false;
                                }
                                else
                                {
                                    pbxKD.Visible = true;
                                    pbxKD.Image = Image.FromFile("RedArrow.png");
                                }
                            }
                            if (Double.TryParse(File.ReadLines(playerName + platform + ".txt").Skip(1).Take(1).First(), out val))
                            {
                                if (val < playerWL)
                                {
                                    pbxWL.Visible = true;
                                    pbxWL.Image = Image.FromFile("GreenArrow.png");
                                }
                                else if (val == playerWL)
                                {
                                    pbxWL.Visible = false;
                                }
                                else
                                {
                                    pbxWL.Visible = true;
                                    pbxWL.Image = Image.FromFile("RedArrow.png");
                                }
                            }
                            if (Double.TryParse(File.ReadLines(playerName + platform + ".txt").Skip(2).Take(1).First(), out val))
                            {
                                if (val < playerSPM)
                                {
                                    pbxSPM.Visible = true;
                                    pbxSPM.Image = Image.FromFile("GreenArrow.png");
                                }
                                else if (val == playerSPM)
                                {
                                    pbxSPM.Visible = false;
                                }
                                else
                                {
                                    pbxSPM.Visible = true;
                                    pbxSPM.Image = Image.FromFile("RedArrow.png");
                                }
                            }
                            if (Double.TryParse(File.ReadLines(playerName + platform + ".txt").Skip(3).Take(1).First(), out val))
                            {
                                if (val < playerKPM)
                                {
                                    pbxKPM.Visible = true;
                                    pbxKPM.Image = Image.FromFile("GreenArrow.png");
                                }
                                else if (val == playerKPM)
                                {
                                    pbxKPM.Visible = false;
                                }
                                else
                                {
                                    pbxKPM.Visible = true;
                                    pbxKPM.Image = Image.FromFile("RedArrow.png");
                                }
                            }
                            if (Double.TryParse(File.ReadLines(playerName + platform + ".txt").Skip(4).Take(1).First(), out val))
                            {
                                if (val < playerSkill)
                                {
                                    pbxSkill.Visible = true; 
                                    pbxSkill.Image = Image.FromFile("GreenArrow.png");
                                }
                                else if (val == playerSkill)
                                {
                                    pbxSkill.Visible = false;
                                }
                                else
                                {
                                    pbxSkill.Visible = true;
                                    pbxSkill.Image = Image.FromFile("RedArrow.png");
                                }
                            }
                        }
                        using (StreamWriter sw = File.CreateText(playerName + platform + ".txt"))
                        {
                            sw.WriteLine(playerKD);
                            sw.WriteLine(playerWL);
                            sw.WriteLine(playerSPM);
                            sw.WriteLine(playerKPM);
                            sw.WriteLine(playerSkill);
                            sw.Close();
                        }
                    }
                    else
                    {
                        //create text file and write stats
                        using (StreamWriter sw = File.CreateText(playerName + platform + ".txt"))
                        {
                            sw.WriteLine(playerKD);
                            sw.WriteLine(playerWL);
                            sw.WriteLine(playerSPM);
                            sw.WriteLine(playerKPM);
                            sw.WriteLine(playerSkill);
                            sw.Close();
                        }
                    }


                    // Open the stream and read it back.
                    //using (StreamReader sr = File.OpenText(playerName))
                    //{
                    //    string s = "";
                    //    while ((s = sr.ReadLine()) != null)
                    //    {
                    //        Console.WriteLine(s);
                    //    }
                    //}
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.ToString());
                }
            }
            else
            {
                //txtResults.Text = "No Data";
            }

        }

        private void DrawPieChart(int warPigeonsPlayed, int conquestPlayed, int tdmPlayed, int dominationPlayed, int rushPlayed, int operationsPlayed)
        {
            //reset your chart series and legends
            chartModesWins.Series.Clear();
            chartModesWins.Legends.Clear();

            //Add a new Legend(if needed) and do some formating
            chartModesWins.Legends.Add("Legend");
            chartModesWins.Legends[0].LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Table;
            chartModesWins.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            chartModesWins.Legends[0].Alignment = StringAlignment.Center;
            chartModesWins.Legends[0].Title = "MyTitle";
            chartModesWins.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "MySeriesName";
            chartModesWins.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chartModesWins.Series[seriesname].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            //Add some datapoints so the series. in this case you can pass the values to this method
            chartModesWins.Series[seriesname].Points.AddXY("War Pigeons", warPigeonsPlayed);
            chartModesWins.Series[seriesname].Points.AddXY("Conquest", conquestPlayed);
            chartModesWins.Series[seriesname].Points.AddXY("TDM", tdmPlayed);
            chartModesWins.Series[seriesname].Points.AddXY("Domination", dominationPlayed);
            chartModesWins.Series[seriesname].Points.AddXY("Rush", rushPlayed);
            chartModesWins.Series[seriesname].Points.AddXY("Operations", operationsPlayed);
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e) // unneeded
        {

        }



        private void panelSearch_VisibleChanged(object sender, EventArgs e) // Might be unneeded
        {
            if (panelSearch.Visible == true)
            {
                cbxPlatform.SelectedIndex = 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e) //On load of the program, set the default platform, add the various panels and make sure the search panel is first
        {
            cbxPlatform.SelectedIndex = 2;
            listPanel.Add(panelSearch);
            listPanel.Add(panelPlayerStats);
            //foreach (Panel element in listPanel)
            //{
            //    //element.SendToBack();
            //    //element.Visible = false;
            //}
            //listPanel[0].BringToFront();
            //listPanel[0].Visible = true;
        }

        private void txtPlayerName_Leave(object sender, EventArgs e) // Used when the user clicks off the search text
        {
            txtPlayerName_CheckText();
        }

        private void txtPlayerName_Enter(object sender, EventArgs e) // Upon clicking the search text, if the default message is there, clear the text to allow user input
        {
            if (txtPlayerName.Text == "Enter Player Name To Search")
            {
                txtPlayerName.Text = "";
                txtPlayerName.ForeColor = Color.Black;
            }
        }

        private void txtPlayerName_CheckText() // This function check to see if the text entered in the search bar was left empty or full of white space characters. Sets text to the default message
        {
            if (string.IsNullOrWhiteSpace(txtPlayerName.Text))
            {
                txtPlayerName.ForeColor = Color.DimGray;
                txtPlayerName.Text = "Enter Player Name To Search";
            }
        }

        private void btnBackToSearch_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
            pbxKD.Visible = false;
            pbxKPM.Visible = false;
            pbxSkill.Visible = false;
            pbxSPM.Visible = false;
            pbxWL.Visible = false;
        }
    }
}
