using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FifaControls;
using FifaLibrary;

namespace DbMaster
{
	// Token: 0x02000014 RID: 20
	public partial class DbMaster : Form
	{
		// Token: 0x0600025D RID: 605 RVA: 0x00008DE0 File Offset: 0x00006FE0
		public DbMaster()
		{
			this.InitializeComponent();
			this.m_LaunchDir = Environment.CurrentDirectory;
			this.m_SaveFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\FM_temp";
			if (!Directory.Exists(this.m_SaveFolder))
			{
				Directory.CreateDirectory(this.m_SaveFolder);
			}
			this.m_LatestGame = RegistryInfo.GetLatestFifaInstalled();
			if (this.m_LatestGame != null)
			{
				this.m_InstallDir = RegistryInfo.GetInstallDir(this.m_LatestGame);
				this.extractFromBigToolStripMenuItem.Enabled = true;
			}
			else
			{
				this.m_InstallDir = this.m_SaveFolder;
				this.extractFromBigToolStripMenuItem.Enabled = false;
			}
			this.EnableMenus(false);
			string text = this.m_LaunchDir + "\\FIFA.XML";
			if (File.Exists(text))
			{
				this.LoadXmlIntelliEdit(text);
			}
			this.m_AboutForm = new AboutForm();
			this.m_AboutForm.labelProduct.Text = "DB MASTER";
			this.m_AboutForm.labelRelease.Text = "Version 14.0";
			this.m_Localizer = new Localization();
			this.m_Localizer.LocalizeControl(this);
			this.m_Localizer.LocalizeMenu(this.mainMenu);
			this.m_Localizer.LocalizeToolStrip(this.toolStrip);
			this.statusLabel.Text = this.m_Localizer.GetString("Ready");
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00008F54 File Offset: 0x00007154
		private void EnableMenus(bool enable)
		{
			this.menuSave.Enabled = enable;
			this.menuClose.Enabled = enable;
			this.menuTable.Enabled = enable;
			this.menuRecord.Enabled = enable;
			this.menuTools.Enabled = enable;
			this.buttonSave.Enabled = enable;
			this.buttonClose.Enabled = enable;
			this.buttonImportSingle.Enabled = enable;
			this.buttonImportMulti.Enabled = enable;
			this.buttonExportSingle.Enabled = enable;
			this.buttonExportMulti.Enabled = enable;
			this.buttonIntelliEdit.Enabled = enable;
			this.buttonRecordCopy.Enabled = enable;
			this.buttonRecordcCount.Enabled = enable;
			this.buttonRecordcDelete.Enabled = enable;
			this.buttonRecordcInsert.Enabled = enable;
			this.buttonRecordcReplace.Enabled = enable;
			this.buttonFind.Enabled = enable;
			this.buttonFindExactly.Enabled = enable;
			this.textSearch.Enabled = enable;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00009051 File Offset: 0x00007251
		private void EnablePanels(bool enable)
		{
			this.panelTop.Enabled = enable;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00009060 File Offset: 0x00007260
		private bool BrowseDB()
		{
			this.openFileDialog.InitialDirectory = this.m_InstallDir + "\\Game\\data\\db\\";
			this.openFileDialog.Filter = "db files (*.db)|*.db";
			this.openFileDialog.FilterIndex = 1;
			this.openFileDialog.Title = "Open Database File";
			bool flag = false;
			if (this.openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.m_FifaDbFileName = this.openFileDialog.FileName;
				flag = true;
			}
			return flag;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000090D8 File Offset: 0x000072D8
		private bool BrowseXml()
		{
			this.openFileDialog.InitialDirectory = this.m_InstallDir + "\\Game\\data\\db\\";
			this.openFileDialog.Filter = "xml files (*.xml)|*.xml";
			this.openFileDialog.FilterIndex = 1;
			this.openFileDialog.Title = "Open XML Descriptor File";
			bool flag = false;
			if (this.openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.m_XmlFileName = this.openFileDialog.FileName;
				flag = true;
			}
			return flag;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00009150 File Offset: 0x00007350
		private void InitializeListBoxTables()
		{
			this.listBoxTables.Items.Clear();
			for (int i = 0; i < this.m_DataSet.Tables.Count; i++)
			{
				this.listBoxTables.Items.Add(this.m_DataSet.Tables[i].TableName);
			}
			this.m_ChangeColumnSema = false;
			this.listBoxTables.SelectedIndex = 0;
			this.m_ChangeColumnSema = true;
			this.m_IsDbFileOpen = true;
			this.EnableMenus(true);
			this.EnablePanels(true);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000091E0 File Offset: 0x000073E0
		private void mDataSet_ColumnChanging(object sender, DataColumnChangeEventArgs e)
		{
			if (this.m_ImportingTableSema)
			{
				return;
			}
			if (this.m_IsIntegerColumn)
			{
				int num = (int)this.numericMin.Value;
				int num2 = (int)this.numericMax.Value;
				int num3 = num;
				string text = e.ProposedValue.ToString();
				if (string.Empty != text)
				{
					num3 = Convert.ToInt32(e.ProposedValue);
				}
				if (num == 0 && num2 == -1)
				{
					return;
				}
				if (num2 == -1)
				{
					if (num3 < num)
					{
						e.ProposedValue = num.ToString();
						return;
					}
				}
				else
				{
					if (num3 < num)
					{
						e.ProposedValue = num.ToString();
					}
					if (num3 > num2)
					{
						e.ProposedValue = num2.ToString();
					}
				}
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000928C File Offset: 0x0000748C
		private void OpenXmlAndDb()
		{
			if (this.m_IsDbFileOpen && this.AskAndSave())
			{
				this.CloseDb();
			}
			if (!this.BrowseXml())
			{
				return;
			}
			if (!this.BrowseDB())
			{
				return;
			}
			this.statusLabel.Text = this.m_Localizer.GetString("Loading Database ...");
			this.Cursor = Cursors.WaitCursor;
			this.Refresh();
			this.m_FifaDbFile = new DbFile(this.m_FifaDbFileName, this.m_XmlFileName, this.progressBar);
			this.Refresh();
			this.statusLabel.Text = this.m_Localizer.GetString("Rendering Tables ...");
			this.statusStrip.Refresh();
			this.m_DataSet = this.m_FifaDbFile.ConvertToDataSet();
			for (int i = 0; i < this.m_DataSet.Tables.Count; i++)
			{
				this.m_DataSet.Tables[i].ColumnChanging += this.mDataSet_ColumnChanging;
			}
			this.dataGridView.DataSource = this.m_DataSet;
			this.dataGridView.DataMember = this.m_DataSet.Tables[0].TableName;
			this.InitializeListBoxTables();
			this.listBoxTables.Refresh();
			this.statusLabel.Text = this.m_Localizer.GetString("Loading Intelli-Edit ...");
			this.statusStrip.Refresh();
			this.PrepareIntelliEdit();
			this.Cursor = Cursors.Default;
			this.progressBar.Value = 0;
			this.statusLabel.Text = this.m_Localizer.GetString("Ready");
			this.statusStrip.Refresh();
			this.Text = Path.GetFileName(this.m_FifaDbFileName) + " - DB Master";
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000944B File Offset: 0x0000764B
		private void menuOpen_Click(object sender, EventArgs e)
		{
			this.OpenXmlAndDb();
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00009453 File Offset: 0x00007653
		private void menuSave_Click(object sender, EventArgs e)
		{
			if (this.m_IsDbFileOpen)
			{
				this.SaveDb();
				this.SaveXml();
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00009469 File Offset: 0x00007669
		private void SaveXml()
		{
			this.m_FifaDbFile.SaveXml(this.m_XmlFileName);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00009480 File Offset: 0x00007680
		private void SaveDb()
		{
			this.statusLabel.Text = this.m_Localizer.GetString("Saving");
			this.Cursor = Cursors.WaitCursor;
			this.Refresh();
			this.m_FifaDbFile.ConvertFromDataSet(this.m_DataSet);
			File.Copy(this.m_FifaDbFile.FileName, this.m_FifaDbFile.FileName + ".bak", true);
			this.m_FifaDbFile.SaveDb(this.m_FifaDbFile.FileName);
			this.Cursor = Cursors.Default;
			this.progressBar.Value = 0;
			this.statusLabel.Text = this.m_Localizer.GetString("Ready");
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00009539 File Offset: 0x00007739
		private void menuExit_Click(object sender, EventArgs e)
		{
			if (this.m_IsDbFileOpen)
			{
				if (this.AskAndSave())
				{
					Application.Exit();
					return;
				}
			}
			else
			{
				Application.Exit();
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00009558 File Offset: 0x00007758
		private bool AskAndSave()
		{
			DialogResult dialogResult = this.m_UserMessage.ShowMessage(1);
			if (dialogResult == DialogResult.Yes)
			{
				this.SaveDb();
				this.SaveXml();
				return true;
			}
			return dialogResult == DialogResult.No || dialogResult == DialogResult.OK;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000958F File Offset: 0x0000778F
		private void menuClose_Click(object sender, EventArgs e)
		{
			if (this.AskAndSave())
			{
				this.CloseDb();
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000095A0 File Offset: 0x000077A0
		private void CloseDb()
		{
			this.m_IsDbFileOpen = false;
			this.EnableMenus(false);
			this.EnablePanels(false);
			this.listBoxTables.Items.Clear();
			this.dataGridView.DataSource = null;
			this.comboIntelli.Text = string.Empty;
			this.comboSearch.Text = string.Empty;
			this.textSearch.Text = string.Empty;
			this.Text = " DB Master";
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000961C File Offset: 0x0000781C
		private void listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.listBoxTables.SelectedIndex;
			this.listBoxTables.Cursor = Cursors.WaitCursor;
			this.m_CurrentTable = this.m_DataSet.Tables[selectedIndex];
			this.dataGridView.DataMember = this.m_CurrentTable.TableName;
			this.SetDisplayIndex();
			this.UpdateComboSearch();
			this.comboIntelli.Visible = false;
			this.dateIntelli.Visible = false;
			this.comboIntelli.Text = "";
			this.listBoxTables.Cursor = Cursors.Default;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000096B8 File Offset: 0x000078B8
		private void SetDisplayIndex()
		{
			int i = 0;
			try
			{
				if (!(this.m_CurrentTable.TableName == string.Empty))
				{
					if (this.m_CurrentTable.TableName == "physio")
					{
						this.SetNextFieldInGridView("physioid", ref i);
						this.SetNextFieldInGridView("firstname", ref i);
						this.SetNextFieldInGridView("surname", ref i);
						this.SetNextFieldInGridView("birthdate", ref i);
						this.SetNextFieldInGridView("headtypecode", ref i);
						this.SetNextFieldInGridView("headclasscode", ref i);
						this.SetNextFieldInGridView("skintonecode", ref i);
						this.SetNextFieldInGridView("facialhairtypecode", ref i);
						this.SetNextFieldInGridView("facialhaircolorcode", ref i);
						this.SetNextFieldInGridView("hairtypecode", ref i);
						this.SetNextFieldInGridView("haircolorcode", ref i);
						this.SetNextFieldInGridView("eyecolorcode", ref i);
						this.SetNextFieldInGridView("eyebrowcode", ref i);
					}
					else if (this.m_CurrentTable.TableName == "nations")
					{
						this.SetNextFieldInGridView("nationid", ref i);
						this.SetNextFieldInGridView("nationname", ref i);
						this.SetNextFieldInGridView("confederation", ref i);
						this.SetNextFieldInGridView("teamid", ref i);
						this.SetNextFieldInGridView("nationstartingfirstletter", ref i);
					}
					else if (this.m_CurrentTable.TableName == "mm_rtsg")
					{
						this.SetNextFieldInGridView("rtsg", ref i);
						this.SetNextFieldInGridView("tournament_type", ref i);
						this.SetNextFieldInGridView("appears_in_career", ref i);
						this.SetNextFieldInGridView("appears_in_tournament", ref i);
						this.SetNextFieldInGridView("asset_id", ref i);
						this.SetNextFieldInGridView("is_play_off_tournament", ref i);
						this.SetNextFieldInGridView("qualify_from_this_year", ref i);
						this.SetNextFieldInGridView("start_week", ref i);
						this.SetNextFieldInGridView("start_month", ref i);
						this.SetNextFieldInGridView("start_next_year", ref i);
						this.SetNextFieldInGridView("end_week", ref i);
						this.SetNextFieldInGridView("end_month", ref i);
						this.SetNextFieldInGridView("end_next_year", ref i);
						this.SetNextFieldInGridView("country_id", ref i);
						this.SetNextFieldInGridView("num_games_per_team", ref i);
						this.SetNextFieldInGridView("monday", ref i);
						this.SetNextFieldInGridView("tuesday", ref i);
						this.SetNextFieldInGridView("wednesday", ref i);
						this.SetNextFieldInGridView("thursday", ref i);
						this.SetNextFieldInGridView("friday", ref i);
						this.SetNextFieldInGridView("saturday", ref i);
						this.SetNextFieldInGridView("sunday", ref i);
						this.SetNextFieldInGridView("use_away_goal_rule", ref i);
						this.SetNextFieldInGridView("stage_tournament_index", ref i);
						this.SetNextFieldInGridView("num_subs", ref i);
						this.SetNextFieldInGridView("num_yellows_for_red", ref i);
					}
					else if (this.m_CurrentTable.TableName == "mm_team_lookup")
					{
						this.SetNextFieldInGridView("rtsgt", ref i);
						this.SetNextFieldInGridView("move_to_rtsgt", ref i);
						this.SetNextFieldInGridView("move_from_rtsgt", ref i);
						this.SetNextFieldInGridView("qualify_from_rtsgt", ref i);
						this.SetNextFieldInGridView("team_id", ref i);
						this.SetNextFieldInGridView("num_wins", ref i);
						this.SetNextFieldInGridView("qualify_from_this_year", ref i);
						this.SetNextFieldInGridView("num_losses", ref i);
						this.SetNextFieldInGridView("num_draws", ref i);
						this.SetNextFieldInGridView("position", ref i);
					}
					else if (this.m_CurrentTable.TableName == "sponsors")
					{
						this.SetNextFieldInGridView("id", ref i);
						this.SetNextFieldInGridView("assetid", ref i);
						this.SetNextFieldInGridView("domestic", ref i);
						this.SetNextFieldInGridView("annual", ref i);
						this.SetNextFieldInGridView("resign", ref i);
						this.SetNextFieldInGridView("league", ref i);
						this.SetNextFieldInGridView("extra", ref i);
						this.SetNextFieldInGridView("country", ref i);
						this.SetNextFieldInGridView("resigncondition", ref i);
						this.SetNextFieldInGridView("teamprestige", ref i);
						this.SetNextFieldInGridView("extracondition", ref i);
					}
					else if (this.m_CurrentTable.TableName == "stadiumassignments")
					{
						this.SetNextFieldInGridView("teamid", ref i);
						this.SetNextFieldInGridView("stadiumcustomname", ref i);
					}
					else if (this.m_CurrentTable.TableName == "standing_variations")
					{
						this.SetNextFieldInGridView("teamid", ref i);
						this.SetNextFieldInGridView("previous_pos", ref i);
						this.SetNextFieldInGridView("current_pos", ref i);
					}
					else if (this.m_CurrentTable.TableName == "fanshopitems")
					{
						this.SetNextFieldInGridView("fanshopid", ref i);
						this.SetNextFieldInGridView("itemid", ref i);
						this.SetNextFieldInGridView("cost", ref i);
						this.SetNextFieldInGridView("fanshopcategoryid", ref i);
						this.SetNextFieldInGridView("categoryid", ref i);
					}
					else if (this.m_CurrentTable.TableName == "manager")
					{
						this.SetNextFieldInGridView("teamid", ref i);
						this.SetNextFieldInGridView("firstname", ref i);
						this.SetNextFieldInGridView("surname", ref i);
					}
					else if (this.m_CurrentTable.TableName == "MatchIntensity")
					{
						this.SetNextFieldInGridView("ScoreDiff", ref i);
						this.SetNextFieldInGridView("time15", ref i);
						this.SetNextFieldInGridView("time30", ref i);
						this.SetNextFieldInGridView("time45", ref i);
						this.SetNextFieldInGridView("time60", ref i);
						this.SetNextFieldInGridView("time75", ref i);
						this.SetNextFieldInGridView("time90", ref i);
						this.SetNextFieldInGridView("time120", ref i);
					}
					else if (this.m_CurrentTable.TableName == "commentarynames")
					{
						this.SetNextFieldInGridView("commentaryid", ref i);
						this.SetNextFieldInGridView("commentarystring", ref i);
						this.SetNextFieldInGridView("commentarypreview", ref i);
						this.SetNextFieldInGridView("commentarystartingletter", ref i);
					}
					else if (this.m_CurrentTable.TableName == "BigAttendance" || this.m_CurrentTable.TableName == "NoAttendance")
					{
						this.SetNextFieldInGridView("Emotion", ref i);
						this.SetNextFieldInGridView("Min", ref i);
						this.SetNextFieldInGridView("Max", ref i);
					}
					else if (this.m_CurrentTable.TableName == "teams")
					{
						this.SetNextFieldInGridView("teamid", ref i);
						this.SetNextFieldInGridView("teamname", ref i);
						this.SetNextFieldInGridView("transferbudget", ref i);
						this.SetNextFieldInGridView("domesticprestige", ref i);
						this.SetNextFieldInGridView("internationalprestige", ref i);
						this.SetNextFieldInGridView("rivalteam", ref i);
						this.SetNextFieldInGridView("captainid", ref i);
						this.SetNextFieldInGridView("penaltytakerid", ref i);
						this.SetNextFieldInGridView("freekicktakerid", ref i);
						this.SetNextFieldInGridView("longkicktakerid", ref i);
						this.SetNextFieldInGridView("leftcornerkicktakerid", ref i);
						this.SetNextFieldInGridView("rightcornerkicktakerid", ref i);
						this.SetNextFieldInGridView("assetid", ref i);
						this.SetNextFieldInGridView("adboardid", ref i);
						this.SetNextFieldInGridView("balltype", ref i);
						this.SetNextFieldInGridView("genericbanner", ref i);
						this.SetNextFieldInGridView("jerseytype", ref i);
						this.SetNextFieldInGridView("busbuildupspeed", ref i);
						this.SetNextFieldInGridView("buspassing", ref i);
						this.SetNextFieldInGridView("buspositioning", ref i);
						this.SetNextFieldInGridView("cccrossing", ref i);
						this.SetNextFieldInGridView("ccpassing", ref i);
						this.SetNextFieldInGridView("ccpositioning", ref i);
						this.SetNextFieldInGridView("ccshooting", ref i);
						this.SetNextFieldInGridView("defaggression", ref i);
						this.SetNextFieldInGridView("defdefenderline", ref i);
						this.SetNextFieldInGridView("defmentality", ref i);
						this.SetNextFieldInGridView("defteamwidth", ref i);
						this.SetNextFieldInGridView("fancrowdhairskintexturecode", ref i);
						this.SetNextFieldInGridView("stafftracksuitcolorcode", ref i);
						this.SetNextFieldInGridView("physioid_primary", ref i);
						this.SetNextFieldInGridView("physioid_secondary", ref i);
						this.SetNextFieldInGridView("teamcolor1r", ref i);
						this.SetNextFieldInGridView("teamcolor1g", ref i);
						this.SetNextFieldInGridView("teamcolor1b", ref i);
						this.SetNextFieldInGridView("teamcolor2r", ref i);
						this.SetNextFieldInGridView("teamcolor2g", ref i);
						this.SetNextFieldInGridView("teamcolor2b", ref i);
						this.SetNextFieldInGridView("teamcolor3r", ref i);
						this.SetNextFieldInGridView("teamcolor3g", ref i);
						this.SetNextFieldInGridView("teamcolor3b", ref i);
						this.SetNextFieldInGridView("form", ref i);
						this.SetNextFieldInGridView("numtransfersin", ref i);
					}
					else if (this.m_CurrentTable.TableName == "teamplayerlinks" || this.m_CurrentTable.TableName == "trainingteamplayerlinks")
					{
						this.SetNextFieldInGridView("artificialkey", ref i);
						this.SetNextFieldInGridView("teamid", ref i);
						this.SetNextFieldInGridView("playerid", ref i);
						this.SetNextFieldInGridView("position", ref i);
						this.SetNextFieldInGridView("jerseynumber", ref i);
					}
					else if (this.m_CurrentTable.TableName == "teamkits")
					{
						this.SetNextFieldInGridView("teamkitid", ref i);
						this.SetNextFieldInGridView("teamtechid", ref i);
						this.SetNextFieldInGridView("teamkittypetechid", ref i);
						this.SetNextFieldInGridView("hasadvertisingkit", ref i);
						this.SetNextFieldInGridView("isinheritbasedetailmap", ref i);
						this.SetNextFieldInGridView("jerseyshapestyle", ref i);
						this.SetNextFieldInGridView("jerseycollargeometrytype", ref i);
						this.SetNextFieldInGridView("jerseybacknamefontcase", ref i);
						this.SetNextFieldInGridView("jerseybacknameplacementcode", ref i);
						this.SetNextFieldInGridView("jerseynamecolorr", ref i);
						this.SetNextFieldInGridView("jerseynamecolorg", ref i);
						this.SetNextFieldInGridView("jerseynamecolorb", ref i);
						this.SetNextFieldInGridView("jerseynamefonttype", ref i);
						this.SetNextFieldInGridView("jerseynamelayouttype", ref i);
						this.SetNextFieldInGridView("jerseyfrontnumberplacementcode", ref i);
						this.SetNextFieldInGridView("numberfonttype", ref i);
						this.SetNextFieldInGridView("numbercolor", ref i);
						this.SetNextFieldInGridView("jerseyrenderingdetailmaptype", ref i);
						this.SetNextFieldInGridView("renderingmaterialtype", ref i);
						this.SetNextFieldInGridView("shortsnumberplacementcode", ref i);
						this.SetNextFieldInGridView("shortsnumberfonttype", ref i);
						this.SetNextFieldInGridView("shortsnumbercolor", ref i);
						this.SetNextFieldInGridView("shortsrenderingdetailmaptype", ref i);
						this.SetNextFieldInGridView("teamcolorprimr", ref i);
						this.SetNextFieldInGridView("teamcolorprimg", ref i);
						this.SetNextFieldInGridView("teamcolorprimb", ref i);
						this.SetNextFieldInGridView("teamcolorsecr", ref i);
						this.SetNextFieldInGridView("teamcolorsecg", ref i);
						this.SetNextFieldInGridView("teamcolorsecb", ref i);
						this.SetNextFieldInGridView("teamcolortertr", ref i);
						this.SetNextFieldInGridView("teamcolortertg", ref i);
						this.SetNextFieldInGridView("teamcolortertb", ref i);
						this.SetNextFieldInGridView("dlc", ref i);
						this.SetNextFieldInGridView("year", ref i);
					}
					else if (this.m_CurrentTable.TableName == "teamstadiumlinks")
					{
						this.SetNextFieldInGridView("teamid", ref i);
						this.SetNextFieldInGridView("stadiumid", ref i);
					}
					else if (this.m_CurrentTable.TableName == "stadiums")
					{
						this.SetNextFieldInGridView("stadiumid", ref i);
						this.SetNextFieldInGridView("name", ref i);
						this.SetNextFieldInGridView("countrycode", ref i);
						this.SetNextFieldInGridView("hometeamid", ref i);
						this.SetNextFieldInGridView("capacity", ref i);
						this.SetNextFieldInGridView("policetypecode", ref i);
						this.SetNextFieldInGridView("seatcolor", ref i);
						this.SetNextFieldInGridView("sectionfacedbydefault", ref i);
						this.SetNextFieldInGridView("stadiumgoalnetstyle", ref i);
						this.SetNextFieldInGridView("stadiumgloalnetdepth", ref i);
						this.SetNextFieldInGridView("stadiumgoalnetlength", ref i);
						this.SetNextFieldInGridView("stadiumgoalnetwidth", ref i);
						this.SetNextFieldInGridView("stadiummowpattern_code", ref i);
						this.SetNextFieldInGridView("stadiumpitchlength", ref i);
						this.SetNextFieldInGridView("stadiumpitchwidth", ref i);
						this.SetNextFieldInGridView("adboardendlinedistance", ref i);
						this.SetNextFieldInGridView("adboardsidelinedistance", ref i);
						this.SetNextFieldInGridView("stadiumtype", ref i);
						this.SetNextFieldInGridView("timeofday1", ref i);
						this.SetNextFieldInGridView("timeofday2", ref i);
						this.SetNextFieldInGridView("timeofday3", ref i);
						this.SetNextFieldInGridView("timeofday4", ref i);
						this.SetNextFieldInGridView("tod1weather", ref i);
						this.SetNextFieldInGridView("tod2weather", ref i);
						this.SetNextFieldInGridView("tod3weather", ref i);
						this.SetNextFieldInGridView("tod4weather", ref i);
						this.SetNextFieldInGridView("yearbuilt", ref i);
						this.SetNextFieldInGridView("dlc", ref i);
					}
					else if (this.m_CurrentTable.TableName == "referee")
					{
						this.SetNextFieldInGridView("refereeid", ref i);
						this.SetNextFieldInGridView("firstname", ref i);
						this.SetNextFieldInGridView("surname", ref i);
						this.SetNextFieldInGridView("birthdate", ref i);
						this.SetNextFieldInGridView("nationalitycode", ref i);
						this.SetNextFieldInGridView("leagueid", ref i);
						this.SetNextFieldInGridView("cardstrictness", ref i);
						this.SetNextFieldInGridView("foulstrictness", ref i);
						this.SetNextFieldInGridView("stylecode", ref i);
						this.SetNextFieldInGridView("homecitycode", ref i);
						this.SetNextFieldInGridView("height", ref i);
						this.SetNextFieldInGridView("weight", ref i);
						this.SetNextFieldInGridView("bodytypecode", ref i);
						this.SetNextFieldInGridView("shoetypecode", ref i);
						this.SetNextFieldInGridView("shoedesigncode", ref i);
						this.SetNextFieldInGridView("shoecolorcode1", ref i);
						this.SetNextFieldInGridView("shoecolorcode2", ref i);
						this.SetNextFieldInGridView("sockheightcode", ref i);
						this.SetNextFieldInGridView("jerseysleevelengthcode", ref i);
						this.SetNextFieldInGridView("eyebrowcode", ref i);
						this.SetNextFieldInGridView("eyecolorcode", ref i);
						this.SetNextFieldInGridView("facialhaircolorcode", ref i);
						this.SetNextFieldInGridView("facialhairtypecode", ref i);
						this.SetNextFieldInGridView("haircolorcode", ref i);
						this.SetNextFieldInGridView("haireffecttypecode", ref i);
						this.SetNextFieldInGridView("hairlinecode", ref i);
						this.SetNextFieldInGridView("hairpartcode", ref i);
						this.SetNextFieldInGridView("hairstateid", ref i);
						this.SetNextFieldInGridView("hairtypecode", ref i);
						this.SetNextFieldInGridView("hairvariationid", ref i);
						this.SetNextFieldInGridView("headclasscode", ref i);
						this.SetNextFieldInGridView("headtypecode", ref i);
						this.SetNextFieldInGridView("proxyhaircolorid", ref i);
						this.SetNextFieldInGridView("proxyheadclass", ref i);
						this.SetNextFieldInGridView("sideburnscode", ref i);
						this.SetNextFieldInGridView("skintonecode", ref i);
						this.SetNextFieldInGridView("skintypecode", ref i);
						this.SetNextFieldInGridView("sweatid", ref i);
						this.SetNextFieldInGridView("wrinkleid", ref i);
					}
					else if (this.m_CurrentTable.TableName == "players" || this.m_CurrentTable.TableName == "temp_arenaplayer" || this.m_CurrentTable.TableName == "trainingteamplayers")
					{
						this.SetNextFieldInGridView("playerid", ref i);
						this.SetNextFieldInGridView("playerid", ref i);
						this.SetNextFieldInGridView("firstnameid", ref i);
						this.SetNextFieldInGridView("lastnameid", ref i);
						this.SetNextFieldInGridView("commonnameid", ref i);
						this.SetNextFieldInGridView("playerjerseynameid", ref i);
						this.SetNextFieldInGridView("birthdate", ref i);
						this.SetNextFieldInGridView("nationality", ref i);
						this.SetNextFieldInGridView("height", ref i);
						this.SetNextFieldInGridView("weight", ref i);
						this.SetNextFieldInGridView("shoetypecode", ref i);
						this.SetNextFieldInGridView("shoedesigncode", ref i);
						this.SetNextFieldInGridView("shoecolorcode1", ref i);
						this.SetNextFieldInGridView("shoecolorcode2", ref i);
						this.SetNextFieldInGridView("jerseystylecode", ref i);
						this.SetNextFieldInGridView("jerseyfit", ref i);
						this.SetNextFieldInGridView("jerseysleevelengthcode", ref i);
						this.SetNextFieldInGridView("shortstyle", ref i);
						this.SetNextFieldInGridView("socklengthcode", ref i);
						this.SetNextFieldInGridView("hasseasonaljersey", ref i);
						this.SetNextFieldInGridView("accessorycode1", ref i);
						this.SetNextFieldInGridView("accessorycolourcode1", ref i);
						this.SetNextFieldInGridView("accessorycode2", ref i);
						this.SetNextFieldInGridView("accessorycolourcode2", ref i);
						this.SetNextFieldInGridView("accessorycode3", ref i);
						this.SetNextFieldInGridView("accessorycolourcode3", ref i);
						this.SetNextFieldInGridView("accessorycode4", ref i);
						this.SetNextFieldInGridView("accessorycolourcode4", ref i);
						this.SetNextFieldInGridView("animfreekickstartposcode", ref i);
						this.SetNextFieldInGridView("animpenaltieskickstylecode", ref i);
						this.SetNextFieldInGridView("animpenaltiesmotionstylecode", ref i);
						this.SetNextFieldInGridView("animpenaltiesstartposcode", ref i);
						this.SetNextFieldInGridView("runningcode1", ref i);
						this.SetNextFieldInGridView("runningcode2", ref i);
						this.SetNextFieldInGridView("playerjointeamdate", ref i);
						this.SetNextFieldInGridView("contractvaliduntil", ref i);
						this.SetNextFieldInGridView("bodytypecode", ref i);
						this.SetNextFieldInGridView("headtypecode", ref i);
						this.SetNextFieldInGridView("hashighqualityhead", ref i);
						this.SetNextFieldInGridView("headclasscode", ref i);
						this.SetNextFieldInGridView("faceposercode", ref i);
						this.SetNextFieldInGridView("skintonecode", ref i);
						this.SetNextFieldInGridView("skintypecode", ref i);
						this.SetNextFieldInGridView("facialhairtypecode", ref i);
						this.SetNextFieldInGridView("facialhaircolorcode", ref i);
						this.SetNextFieldInGridView("hairtypecode", ref i);
						this.SetNextFieldInGridView("haircolorcode", ref i);
						this.SetNextFieldInGridView("sideburnscode", ref i);
						this.SetNextFieldInGridView("eyecolorcode", ref i);
						this.SetNextFieldInGridView("eyebrowcode", ref i);
						this.SetNextFieldInGridView("preferredposition1", ref i);
						this.SetNextFieldInGridView("preferredposition2", ref i);
						this.SetNextFieldInGridView("preferredposition3", ref i);
						this.SetNextFieldInGridView("preferredposition4", ref i);
						this.SetNextFieldInGridView("attackingworkrate", ref i);
						this.SetNextFieldInGridView("defensiveworkrate", ref i);
						this.SetNextFieldInGridView("weakfootabilitytypecode", ref i);
						this.SetNextFieldInGridView("internationalrep", ref i);
						this.SetNextFieldInGridView("isretiring", ref i);
						this.SetNextFieldInGridView("overallrating", ref i);
						this.SetNextFieldInGridView("acceleration", ref i);
						this.SetNextFieldInGridView("aggression", ref i);
						this.SetNextFieldInGridView("agility", ref i);
						this.SetNextFieldInGridView("balance", ref i);
						this.SetNextFieldInGridView("ballcontrol", ref i);
						this.SetNextFieldInGridView("crossing", ref i);
						this.SetNextFieldInGridView("curve", ref i);
						this.SetNextFieldInGridView("dribbling", ref i);
						this.SetNextFieldInGridView("finishing", ref i);
						this.SetNextFieldInGridView("finishingcode1", ref i);
						this.SetNextFieldInGridView("finishingcode2", ref i);
						this.SetNextFieldInGridView("freekickaccuracy", ref i);
						this.SetNextFieldInGridView("gkdiving", ref i);
						this.SetNextFieldInGridView("gkglovetypecode", ref i);
						this.SetNextFieldInGridView("gkhandling", ref i);
						this.SetNextFieldInGridView("gkkicking", ref i);
						this.SetNextFieldInGridView("gkkickstyle", ref i);
						this.SetNextFieldInGridView("gkpositioning", ref i);
						this.SetNextFieldInGridView("gkreflexes", ref i);
						this.SetNextFieldInGridView("headingaccuracy", ref i);
						this.SetNextFieldInGridView("interceptions", ref i);
						this.SetNextFieldInGridView("jumping", ref i);
						this.SetNextFieldInGridView("longpassing", ref i);
						this.SetNextFieldInGridView("longshots", ref i);
						this.SetNextFieldInGridView("marking", ref i);
						this.SetNextFieldInGridView("penalties", ref i);
						this.SetNextFieldInGridView("positioning", ref i);
						this.SetNextFieldInGridView("potential", ref i);
						this.SetNextFieldInGridView("preferredfoot", ref i);
						this.SetNextFieldInGridView("reactions", ref i);
						this.SetNextFieldInGridView("shortpassing", ref i);
						this.SetNextFieldInGridView("shotpower", ref i);
						this.SetNextFieldInGridView("skillmoves", ref i);
						this.SetNextFieldInGridView("slidingtackle", ref i);
						this.SetNextFieldInGridView("sprintspeed", ref i);
						this.SetNextFieldInGridView("stamina", ref i);
						this.SetNextFieldInGridView("standingtackle", ref i);
						this.SetNextFieldInGridView("strength", ref i);
						this.SetNextFieldInGridView("vision", ref i);
						this.SetNextFieldInGridView("volleys", ref i);
						this.SetNextFieldInGridView("trait1", ref i);
						this.SetNextFieldInGridView("trait2", ref i);
						this.SetNextFieldInGridView("usercaneditname", ref i);
					}
					else if (this.m_CurrentTable.TableName == "player_grudgelove")
					{
						this.SetNextFieldInGridView("playerid", ref i);
						this.SetNextFieldInGridView("emotional_teamid", ref i);
						this.SetNextFieldInGridView("level_of_emotion", ref i);
					}
					else if (this.m_CurrentTable.TableName == "managerhistory")
					{
						this.SetNextFieldInGridView("managerid", ref i);
						this.SetNextFieldInGridView("previousteamid", ref i);
						this.SetNextFieldInGridView("datestart", ref i);
						this.SetNextFieldInGridView("dateend", ref i);
					}
					else if (this.m_CurrentTable.TableName == "playernames" || this.m_CurrentTable.TableName == "trainingteamplayernames")
					{
						this.SetNextFieldInGridView("nameid", ref i);
						this.SetNextFieldInGridView("name", ref i);
						this.SetNextFieldInGridView("commentaryid", ref i);
					}
					else if (this.m_CurrentTable.TableName == "leagueteamlinks")
					{
						this.SetNextFieldInGridView("artificialkey", ref i);
						this.SetNextFieldInGridView("leagueid", ref i);
						this.SetNextFieldInGridView("teamid", ref i);
					}
					else if (this.m_CurrentTable.TableName == "editedplayernames")
					{
						this.SetNextFieldInGridView("playerid", ref i);
						this.SetNextFieldInGridView("firstname", ref i);
						this.SetNextFieldInGridView("surname", ref i);
						this.SetNextFieldInGridView("playerjerseyname", ref i);
						this.SetNextFieldInGridView("commonname", ref i);
					}
					else if (this.m_CurrentTable.TableName == "audionation")
					{
						this.SetNextFieldInGridView("nationid", ref i);
						this.SetNextFieldInGridView("ChantRegionIndex", ref i);
					}
					else if (this.m_CurrentTable.TableName == "videos")
					{
						this.SetNextFieldInGridView("artificialkey", ref i);
						this.SetNextFieldInGridView("videoid", ref i);
					}
					else if (this.m_CurrentTable.TableName == "scout_costs")
					{
						this.SetNextFieldInGridView("id", ref i);
					}
					else if (this.m_CurrentTable.TableName == "fieldpositionboundingboxes")
					{
						this.SetNextFieldInGridView("positionid", ref i);
						this.SetNextFieldInGridView("pointx0", ref i);
						this.SetNextFieldInGridView("pointy0", ref i);
						this.SetNextFieldInGridView("pointx1", ref i);
						this.SetNextFieldInGridView("pointy1", ref i);
						this.SetNextFieldInGridView("pointx2", ref i);
						this.SetNextFieldInGridView("pointy2", ref i);
						this.SetNextFieldInGridView("pointx3", ref i);
						this.SetNextFieldInGridView("pointy3", ref i);
					}
					else if (this.m_CurrentTable.TableName == "formations")
					{
						this.SetNextFieldInGridView("formationid", ref i);
						this.SetNextFieldInGridView("teamid", ref i);
						this.SetNextFieldInGridView("formationname", ref i);
						this.SetNextFieldInGridView("relativeformationid", ref i);
						this.SetNextFieldInGridView("issweeper", ref i);
						this.SetNextFieldInGridView("offensiverating", ref i);
						this.SetNextFieldInGridView("position0", ref i);
						this.SetNextFieldInGridView("position1", ref i);
						this.SetNextFieldInGridView("position2", ref i);
						this.SetNextFieldInGridView("position3", ref i);
						this.SetNextFieldInGridView("position4", ref i);
						this.SetNextFieldInGridView("position5", ref i);
						this.SetNextFieldInGridView("position6", ref i);
						this.SetNextFieldInGridView("position7", ref i);
						this.SetNextFieldInGridView("position8", ref i);
						this.SetNextFieldInGridView("position9", ref i);
						this.SetNextFieldInGridView("position10", ref i);
						this.SetNextFieldInGridView("attackingdirection_0", ref i);
						this.SetNextFieldInGridView("attackingdirection_1", ref i);
						this.SetNextFieldInGridView("attackingdirection_2", ref i);
						this.SetNextFieldInGridView("attackingdirection_3", ref i);
						this.SetNextFieldInGridView("attackingdirection_4", ref i);
						this.SetNextFieldInGridView("attackingdirection_5", ref i);
						this.SetNextFieldInGridView("attackingdirection_6", ref i);
						this.SetNextFieldInGridView("attackingdirection_7", ref i);
						this.SetNextFieldInGridView("attackingdirection_8", ref i);
						this.SetNextFieldInGridView("attackingdirection_9", ref i);
						this.SetNextFieldInGridView("attackingdirection_10", ref i);
						this.SetNextFieldInGridView("defensivedirection_0", ref i);
						this.SetNextFieldInGridView("defensivedirection_1", ref i);
						this.SetNextFieldInGridView("defensivedirection_2", ref i);
						this.SetNextFieldInGridView("defensivedirection_3", ref i);
						this.SetNextFieldInGridView("defensivedirection_4", ref i);
						this.SetNextFieldInGridView("defensivedirection_5", ref i);
						this.SetNextFieldInGridView("defensivedirection_6", ref i);
						this.SetNextFieldInGridView("defensivedirection_7", ref i);
						this.SetNextFieldInGridView("defensivedirection_8", ref i);
						this.SetNextFieldInGridView("defensivedirection_9", ref i);
						this.SetNextFieldInGridView("defensivedirection_10", ref i);
						this.SetNextFieldInGridView("attackingrole_0", ref i);
						this.SetNextFieldInGridView("attackingrole_1", ref i);
						this.SetNextFieldInGridView("attackingrole_2", ref i);
						this.SetNextFieldInGridView("attackingrole_3", ref i);
						this.SetNextFieldInGridView("attackingrole_4", ref i);
						this.SetNextFieldInGridView("attackingrole_5", ref i);
						this.SetNextFieldInGridView("attackingrole_6", ref i);
						this.SetNextFieldInGridView("attackingrole_7", ref i);
						this.SetNextFieldInGridView("attackingrole_8", ref i);
						this.SetNextFieldInGridView("attackingrole_9", ref i);
						this.SetNextFieldInGridView("attackingrole_10", ref i);
						this.SetNextFieldInGridView("defensiverole_0", ref i);
						this.SetNextFieldInGridView("defensiverole_1", ref i);
						this.SetNextFieldInGridView("defensiverole_2", ref i);
						this.SetNextFieldInGridView("defensiverole_3", ref i);
						this.SetNextFieldInGridView("defensiverole_4", ref i);
						this.SetNextFieldInGridView("defensiverole_5", ref i);
						this.SetNextFieldInGridView("defensiverole_6", ref i);
						this.SetNextFieldInGridView("defensiverole_7", ref i);
						this.SetNextFieldInGridView("defensiverole_8", ref i);
						this.SetNextFieldInGridView("defensiverole_9", ref i);
						this.SetNextFieldInGridView("defensiverole_10", ref i);
						this.SetNextFieldInGridView("offset0x", ref i);
						this.SetNextFieldInGridView("offset0y", ref i);
						this.SetNextFieldInGridView("offset1x", ref i);
						this.SetNextFieldInGridView("offset1y", ref i);
						this.SetNextFieldInGridView("offset2x", ref i);
						this.SetNextFieldInGridView("offset2y", ref i);
						this.SetNextFieldInGridView("offset3x", ref i);
						this.SetNextFieldInGridView("offset3y", ref i);
						this.SetNextFieldInGridView("offset4x", ref i);
						this.SetNextFieldInGridView("offset4y", ref i);
						this.SetNextFieldInGridView("offset5x", ref i);
						this.SetNextFieldInGridView("offset5y", ref i);
						this.SetNextFieldInGridView("offset6x", ref i);
						this.SetNextFieldInGridView("offset6y", ref i);
						this.SetNextFieldInGridView("offset7x", ref i);
						this.SetNextFieldInGridView("offset7y", ref i);
						this.SetNextFieldInGridView("offset8x", ref i);
						this.SetNextFieldInGridView("offset8y", ref i);
						this.SetNextFieldInGridView("offset9x", ref i);
						this.SetNextFieldInGridView("offset9y", ref i);
						this.SetNextFieldInGridView("offset10x", ref i);
						this.SetNextFieldInGridView("offset10y", ref i);
					}
					else if (this.m_CurrentTable.TableName == "formupdate")
					{
						this.SetNextFieldInGridView("playerid", ref i);
						this.SetNextFieldInGridView("teamid", ref i);
						this.SetNextFieldInGridView("form", ref i);
						this.SetNextFieldInGridView("prevform", ref i);
						this.SetNextFieldInGridView("formaudio", ref i);
						this.SetNextFieldInGridView("leagueid", ref i);
						this.SetNextFieldInGridView("position", ref i);
						this.SetNextFieldInGridView("overallrating", ref i);
					}
					else if (this.m_CurrentTable.TableName == "leagues")
					{
						this.SetNextFieldInGridView("leagueid", ref i);
						this.SetNextFieldInGridView("leaguename", ref i);
						this.SetNextFieldInGridView("countryid", ref i);
						this.SetNextFieldInGridView("level", ref i);
					}
					else
					{
						bool[] array = new bool[this.dataGridView.Columns.Count];
						for (int j = 0; j < this.dataGridView.Columns.Count; j++)
						{
							array[j] = false;
						}
						Table table = this.m_FifaDbFile.GetTable(this.m_CurrentTable.TableName);
						i = 0;
						for (int k = 0; k < table.TableDescriptor.NKeyFields; k++)
						{
							int num = table.TableDescriptor.KeyIndex[k];
							foreach (FieldDescriptor fieldDescriptor in table.TableDescriptor.FieldDescriptors)
							{
								if (fieldDescriptor.FieldType == FieldDescriptor.EFieldTypes.Integer && fieldDescriptor.TypeIndex == num)
								{
									this.dataGridView.Columns[fieldDescriptor.FieldName].DisplayIndex = i++;
									array[this.dataGridView.Columns[fieldDescriptor.FieldName].Index] = true;
									break;
								}
							}
						}
						foreach (FieldDescriptor fieldDescriptor2 in table.TableDescriptor.FieldDescriptors)
						{
							if (fieldDescriptor2.FieldType == FieldDescriptor.EFieldTypes.String || fieldDescriptor2.FieldType == FieldDescriptor.EFieldTypes.ShortCompressedString || fieldDescriptor2.FieldType == FieldDescriptor.EFieldTypes.LongCompressedString)
							{
								this.dataGridView.Columns[fieldDescriptor2.FieldName].DisplayIndex = i++;
								array[this.dataGridView.Columns[fieldDescriptor2.FieldName].Index] = true;
							}
						}
						while (i < table.TableDescriptor.FieldDescriptors.Length)
						{
							string text = "zzzz";
							foreach (FieldDescriptor fieldDescriptor3 in table.TableDescriptor.FieldDescriptors)
							{
								if (!array[this.dataGridView.Columns[fieldDescriptor3.FieldName].Index] && fieldDescriptor3.FieldName.CompareTo(text) < 0)
								{
									text = fieldDescriptor3.FieldName;
								}
							}
							this.dataGridView.Columns[text].DisplayIndex = i++;
							array[this.dataGridView.Columns[text].Index] = true;
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000B544 File Offset: 0x00009744
		private void SetNextFieldInGridView(string fieldName, ref int currentDisplayIndex)
		{
			if (this.dataGridView.Columns[fieldName] != null)
			{
				this.dataGridView.Columns[fieldName].DisplayIndex = currentDisplayIndex;
				currentDisplayIndex++;
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000B578 File Offset: 0x00009778
		private void UpdateComboSearch()
		{
			this.comboSearch.Items.Clear();
			int count = this.m_CurrentTable.Columns.Count;
			if (count > 0)
			{
				for (int i = 0; i < count; i++)
				{
					this.comboSearch.Items.Add(this.m_CurrentTable.Columns[i].ToString());
				}
				this.comboSearch.SelectedIndex = 0;
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000B5EC File Offset: 0x000097EC
		private void PrepareIntelliEdit()
		{
			if (this.m_IntelliEdit == null)
			{
				return;
			}
			string[] array = null;
			string[] array2 = null;
			string text = null;
			for (int i = 0; i < this.m_IntelliEdit.Length; i++)
			{
				if (this.m_IntelliEdit[i].IntermediateTableName != null && text == this.m_IntelliEdit[i].RelatedTableName)
				{
					this.m_IntelliEdit[i].RelatedKey = array;
					this.m_IntelliEdit[i].RelatedDisplay = array2;
					this.m_IntelliEdit[i].IsValid = true;
				}
				else
				{
					this.m_IntelliEdit[i].Apply(this.m_DataSet);
				}
				text = this.m_IntelliEdit[i].RelatedTableName;
				array = this.m_IntelliEdit[i].RelatedKey;
				array2 = this.m_IntelliEdit[i].RelatedDisplay;
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000B6B0 File Offset: 0x000098B0
		private void NavigateIntelliEdit()
		{
			if (this.m_IntelliEdit == null)
			{
				this.comboIntelli.Visible = false;
				this.dateIntelli.Visible = false;
				this.comboIntelli.Text = "";
				return;
			}
			if (this.dataGridView.CurrentCell == null)
			{
				return;
			}
			if (this.listBoxTables.SelectedIndex < 0)
			{
				return;
			}
			int columnIndex = this.dataGridView.CurrentCell.ColumnIndex;
			int rowIndex = this.dataGridView.CurrentCell.RowIndex;
			string tableName = this.m_DataSet.Tables[this.listBoxTables.SelectedIndex].TableName;
			string columnName = this.m_DataSet.Tables[this.listBoxTables.SelectedIndex].Columns[columnIndex].ColumnName;
			if (this.m_CurrentIntelliEdit != null && !this.m_CurrentIntelliEdit.AreYou(tableName, columnName))
			{
				this.m_CurrentIntelliEdit = null;
			}
			if (this.m_CurrentIntelliEdit == null)
			{
				for (int i = 0; i < this.m_IntelliEdit.Length; i++)
				{
					if (this.m_IntelliEdit[i].AreYou(tableName, columnName))
					{
						this.m_CurrentIntelliEdit = this.m_IntelliEdit[i];
						this.m_CurrentIntelliEdit.InitShow(this.comboIntelli, this.dateIntelli);
						break;
					}
				}
			}
			if (this.m_CurrentIntelliEdit != null)
			{
				if (this.m_ChangeValueSema)
				{
					this.m_ChangeValueSema = false;
					if (rowIndex < this.m_CurrentTable.Rows.Count)
					{
						string text = this.dataGridView.CurrentCell.Value.ToString();
						if (this.m_IsIntegerColumn)
						{
							this.m_CurrentIntelliEdit.Show(this.comboIntelli, this.dateIntelli, text, (int)this.numericMin.Value);
						}
						else
						{
							this.m_CurrentIntelliEdit.Show(this.comboIntelli, this.dateIntelli, text);
						}
					}
					else
					{
						this.comboIntelli.Text = "";
					}
					this.m_ChangeValueSema = true;
					return;
				}
			}
			else
			{
				this.comboIntelli.Visible = false;
				this.dateIntelli.Visible = false;
				this.comboIntelli.Text = "";
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.comboSearch.SelectedIndex;
			if (selectedIndex < 0)
			{
				return;
			}
			if (selectedIndex >= this.m_CurrentTable.Columns.Count)
			{
				return;
			}
			int selectedIndex2 = this.listBoxTables.SelectedIndex;
			this.UpdateColumnInfo(selectedIndex2, selectedIndex);
			if (this.m_ChangeColumnSema)
			{
				this.m_ChangeColumnSema = false;
				if (this.dataGridView.CurrentCell != null)
				{
					this.dataGridView.CurrentCell = this.dataGridView[selectedIndex, this.dataGridView.CurrentCell.RowIndex];
				}
				this.m_ChangeColumnSema = true;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000B958 File Offset: 0x00009B58
		private void UpdateColumnInfo(int tableIndex, int columnIndex)
		{
			if (tableIndex < 0)
			{
				return;
			}
			TableDescriptor tableDescriptor = this.m_FifaDbFile.Table[tableIndex].TableDescriptor;
			FieldDescriptor fieldDescriptor = tableDescriptor.FieldDescriptors[columnIndex];
			FieldDescriptor.EFieldTypes fieldType = fieldDescriptor.FieldType;
			switch (fieldType)
			{
			case FieldDescriptor.EFieldTypes.String:
				this.textType.Text = "String";
				this.m_IsIntegerColumn = false;
				break;
			case (FieldDescriptor.EFieldTypes)1:
			case (FieldDescriptor.EFieldTypes)2:
				break;
			case FieldDescriptor.EFieldTypes.Integer:
			{
				this.textType.Text = "Integer";
				this.m_IsIntegerColumn = true;
				int rangeLow = fieldDescriptor.RangeLow;
				int rangeHigh = fieldDescriptor.RangeHigh;
				int num = rangeHigh;
				int num2 = rangeHigh;
				if (rangeHigh > rangeLow)
				{
					uint num3 = (uint)(rangeHigh - rangeLow);
					int num4 = FifaUtil.ComputeBitUsed(num3);
					if (num3 < (uint)Math.Pow(2.0, (double)num4))
					{
						num3 = (uint)Math.Pow(2.0, (double)num4);
						num = (int)((long)rangeLow + (long)((ulong)num3) - 1L);
						num2 = (int)((long)rangeLow + (long)((ulong)(num3 / 2U)));
					}
				}
				this.numericMin.Minimum = rangeLow;
				this.numericMin.Maximum = rangeLow;
				this.numericMin.Value = rangeLow;
				this.numericMax.Minimum = num2;
				this.numericMax.Maximum = num;
				this.numericMax.Value = rangeHigh;
				break;
			}
			case FieldDescriptor.EFieldTypes.Float:
				this.textType.Text = "Decimal";
				this.m_IsIntegerColumn = false;
				break;
			default:
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.ShortCompressedString:
					this.textType.Text = "String";
					this.m_IsIntegerColumn = false;
					break;
				case FieldDescriptor.EFieldTypes.LongCompressedString:
					this.textType.Text = "String";
					this.m_IsIntegerColumn = false;
					break;
				}
				break;
			}
			this.labelMin.Visible = this.m_IsIntegerColumn;
			this.labelMax.Visible = this.m_IsIntegerColumn;
			this.numericMin.Visible = this.m_IsIntegerColumn;
			this.numericMax.Visible = this.m_IsIntegerColumn;
			this.buttonComputeHash.Visible = fieldDescriptor.FieldName == "hashid";
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000BB6C File Offset: 0x00009D6C
		private void dataGridView_CurrentCellChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentTable == null)
			{
				return;
			}
			if (this.m_ChangeColumnSema)
			{
				this.m_ChangeColumnSema = false;
				if (this.dataGridView.CurrentCell != null)
				{
					this.comboSearch.Text = this.m_CurrentTable.Columns[this.dataGridView.CurrentCell.ColumnIndex].ColumnName;
				}
				this.m_ChangeColumnSema = true;
			}
			this.NavigateIntelliEdit();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000BBDC File Offset: 0x00009DDC
		private void dataGridView_Enter(object sender, EventArgs e)
		{
			if (this.dataGridView.CurrentCell != null)
			{
				this.comboSearch.Text = this.m_CurrentTable.Columns[this.dataGridView.CurrentCell.ColumnIndex].ColumnName;
			}
			this.NavigateIntelliEdit();
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000BC2C File Offset: 0x00009E2C
		private void menuLoadIntelli_Click(object sender, EventArgs e)
		{
			this.LoadIntelliEdit();
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000BC34 File Offset: 0x00009E34
		private void LoadIntelliEdit()
		{
			this.openFileDialog.InitialDirectory = this.m_LaunchDir;
			this.openFileDialog.FileName = "FIFA.xml";
			this.openFileDialog.Filter = "xml files (*.xml)|*.xml";
			this.openFileDialog.FilterIndex = 1;
			this.openFileDialog.Title = "Open Intelli-Edit Schema";
			string text = null;
			if (this.openFileDialog.ShowDialog() == DialogResult.OK)
			{
				text = this.openFileDialog.FileName;
			}
			if (text != null)
			{
				this.statusLabel.Text = this.m_Localizer.GetString("Loading Intelli-Edit ...");
				this.Refresh();
				this.LoadXmlIntelliEdit(text);
				this.PrepareIntelliEdit();
				this.statusLabel.Text = this.m_Localizer.GetString("Ready");
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000BCF8 File Offset: 0x00009EF8
		private void LoadXmlIntelliEdit(string fileName)
		{
			this.m_IntelliEditSet = new DataSet();
			this.m_IntelliEditSet.ReadXmlSchema(this.m_LaunchDir + "\\IntelliEdit.xsd");
			this.m_IntelliEditSet.ReadXml(fileName);
			int count = this.m_IntelliEditSet.Tables["CrossTable"].Rows.Count;
			int count2 = this.m_IntelliEditSet.Tables["UseDomain"].Rows.Count;
			int count3 = this.m_IntelliEditSet.Tables["DomainList"].Rows.Count;
			int count4 = this.m_IntelliEditSet.Tables["DoubleCrossTable"].Rows.Count;
			string[] array = null;
			this.m_IntelliEdit = new IntelliEdit[count + count2 + count4];
			for (int i = 0; i < count; i++)
			{
				DataRow dataRow = this.m_IntelliEditSet.Tables["CrossTable"].Rows[i];
				this.m_IntelliEdit[i] = new IntelliEdit(dataRow.ItemArray[0].ToString(), dataRow.ItemArray[1].ToString(), dataRow.ItemArray[2].ToString(), dataRow.ItemArray[3].ToString(), dataRow.ItemArray[4].ToString());
			}
			for (int j = 0; j < count2; j++)
			{
				DataRow dataRow2 = this.m_IntelliEditSet.Tables["UseDomain"].Rows[j];
				string text = dataRow2.ItemArray[2].ToString();
				for (int k = 0; k < count3; k++)
				{
					DataRow dataRow3 = this.m_IntelliEditSet.Tables["DomainList"].Rows[k];
					if ((string)dataRow3.ItemArray[0] == text)
					{
						int num = (int)dataRow3.ItemArray[1];
						array = new string[num];
						for (int l = 0; l < num; l++)
						{
							array[l] = dataRow3.ItemArray[l + 2].ToString();
						}
						break;
					}
				}
				this.m_IntelliEdit[count + j] = new IntelliEdit(dataRow2.ItemArray[0].ToString(), dataRow2.ItemArray[1].ToString(), array);
			}
			for (int m = 0; m < count4; m++)
			{
				DataRow dataRow4 = this.m_IntelliEditSet.Tables["DoubleCrossTable"].Rows[m];
				this.m_IntelliEdit[count + count2 + m] = new IntelliEdit(dataRow4.ItemArray[0].ToString(), dataRow4.ItemArray[1].ToString(), dataRow4.ItemArray[2].ToString(), dataRow4.ItemArray[3].ToString(), dataRow4.ItemArray[4].ToString(), dataRow4.ItemArray[5].ToString(), dataRow4.ItemArray[6].ToString(), dataRow4.ItemArray[7].ToString());
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000C019 File Offset: 0x0000A219
		private void menuEnableAllMessages_Click(object sender, EventArgs e)
		{
			this.m_UserMessage.EnableMessages(true);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000C027 File Offset: 0x0000A227
		private void numericMax_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000C029 File Offset: 0x0000A229
		private void comboIntelli_SelectionChangeCommitted(object sender, EventArgs e)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000C02C File Offset: 0x0000A22C
		private void comboIntelli_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboIntelli.SelectedIndex < 0)
			{
				return;
			}
			if (this.m_CurrentIntelliEdit == null)
			{
				return;
			}
			if (!this.m_ChangeValueSema)
			{
				return;
			}
			this.m_ChangeValueSema = false;
			object obj;
			if (this.m_IsIntegerColumn)
			{
				obj = this.m_CurrentIntelliEdit.GetRelatedKey(this.comboIntelli.SelectedIndex, (int)this.numericMin.Value);
			}
			else
			{
				obj = this.m_CurrentIntelliEdit.GetRelatedKey(this.comboIntelli.SelectedIndex);
			}
			if (obj != null)
			{
				this.dataGridView.CurrentCell.Value = obj;
			}
			this.m_ChangeValueSema = true;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
		private void dateIntelli_ValueChanged(object sender, EventArgs e)
		{
			if (this.m_CurrentIntelliEdit == null)
			{
				return;
			}
			if (!this.m_ChangeValueSema)
			{
				return;
			}
			this.m_ChangeValueSema = false;
			DateTime value = this.dateIntelli.Value;
			this.dataGridView.CurrentCell.Value = FifaUtil.ConvertFromDate(value);
			this.m_ChangeValueSema = true;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000C11C File Offset: 0x0000A31C
		private void menuExportCsv_Click(object sender, EventArgs e)
		{
			DataTable currentTable = this.m_CurrentTable;
			this.saveFileDialog.InitialDirectory = this.m_SaveFolder;
			this.saveFileDialog.Filter = "Text Unicode files (*.txt)|*.txt";
			this.saveFileDialog.FilterIndex = 1;
			this.saveFileDialog.Title = "Export table as a Text Unicode file";
			this.saveFileDialog.FileName = currentTable.TableName;
			if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = this.saveFileDialog.FileName;
				this.m_SaveFolder = Path.GetDirectoryName(fileName);
				this.statusLabel.Text = this.m_Localizer.GetString("Exporting ") + currentTable.TableName;
				this.Cursor = Cursors.WaitCursor;
				this.Refresh();
				this.ExportTable(currentTable, fileName);
				this.Cursor = Cursors.Default;
				this.progressBar.Value = 0;
				this.statusLabel.Text = this.m_Localizer.GetString("Ready");
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000C21C File Offset: 0x0000A41C
		private void ExportTable(DataTable t, string fileName)
		{
			StreamWriter streamWriter = new StreamWriter(fileName, false, this.m_Encoder);
			if (streamWriter == null)
			{
				return;
			}
			for (int i = 0; i < t.Columns.Count; i++)
			{
				string text = t.Columns[i].ToString();
				streamWriter.Write(text);
				if (i == t.Columns.Count - 1)
				{
					streamWriter.Write("\r\n");
				}
				else
				{
					streamWriter.Write("\t");
				}
			}
			for (int j = 0; j < t.Rows.Count; j++)
			{
				for (int k = 0; k < t.Columns.Count; k++)
				{
					string text2 = t.Rows[j].ItemArray[k].ToString();
					text2 = text2.Replace("\n", "\\n");
					text2 = text2.Replace("\r", "\\r");
					text2 = text2.Replace("\t", "\\t");
					streamWriter.Write(text2);
					if (k == t.Columns.Count - 1)
					{
						streamWriter.Write("\r\n");
					}
					else
					{
						streamWriter.Write("\t");
					}
				}
			}
			streamWriter.Close();
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000C35C File Offset: 0x0000A55C
		private void menuImportCsv_Click(object sender, EventArgs e)
		{
			DataTable currentTable = this.m_CurrentTable;
			this.openFileDialog.InitialDirectory = this.m_SaveFolder;
			this.openFileDialog.FileName = currentTable.TableName;
			this.openFileDialog.Filter = "Text Unicode files (*.txt)|*.txt";
			this.openFileDialog.FilterIndex = 1;
			this.openFileDialog.Title = "Import";
			if (this.openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string fileName = this.openFileDialog.FileName;
			this.m_SaveFolder = Path.GetDirectoryName(fileName);
			this.statusLabel.Text = this.m_Localizer.GetString("Importing ") + fileName;
			this.Cursor = Cursors.WaitCursor;
			this.Refresh();
			if (!this.ImportTable(currentTable, fileName))
			{
				string text = "Cannot import " + Path.GetFileName(fileName) + " as " + currentTable.TableName;
				this.m_UserMessage.ShowMessage(5044, text);
			}
			this.Cursor = Cursors.Default;
			this.progressBar.Value = 0;
			this.statusLabel.Text = this.m_Localizer.GetString("Ready");
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000C484 File Offset: 0x0000A684
		private bool ImportTable(DataTable t, string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName, this.m_Encoder);
			string text = streamReader.ReadLine();
			if (text == null)
			{
				return false;
			}
			int num = 1;
			for (int i = 0; i < text.Length; i++)
			{
				if (text.Substring(i, 1) == "\t")
				{
					num++;
				}
			}
			if (num != t.Columns.Count)
			{
				streamReader.Close();
				return false;
			}
			string[] array = this.ReadCsv(text, num);
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j] != t.Columns[j].ColumnName)
				{
					streamReader.Close();
					return false;
				}
			}
			t.Clear();
			t.BeginLoadData();
			this.m_ImportingTableSema = true;
			while (streamReader.Peek() != -1)
			{
				text = streamReader.ReadLine();
				string[] array2 = this.ReadCsv(text, num);
				DataRow dataRow = t.NewRow();
				dataRow.ItemArray = array2;
				t.Rows.Add(dataRow);
			}
			t.EndLoadData();
			this.m_ImportingTableSema = false;
			streamReader.Close();
			return true;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000C590 File Offset: 0x0000A790
		private string[] ReadCsv(string line, int nTokens)
		{
			string[] array = new string[nTokens];
			int num = 0;
			string text;
			for (int i = 0; i < nTokens - 1; i++)
			{
				int num2 = line.IndexOf("\t", num);
				int num3 = num2 - num;
				text = line.Substring(num, num3);
				num = num2 + 1;
				text = text.Replace("\\n", "\n");
				text = text.Replace("\\r", "\r");
				text = text.Replace("\\t", "\t");
				array[i] = text;
			}
			text = line.Substring(num);
			text = text.Replace("\\n", "\n");
			text = text.Replace("\\r", "\r");
			text = text.Replace("\\t", "\t");
			array[nTokens - 1] = text;
			return array;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000C654 File Offset: 0x0000A854
		private void menuExportAll_Click(object sender, EventArgs e)
		{
			this.folderBrowser.SelectedPath = this.m_SaveFolder;
			this.folderBrowser.ShowNewFolderButton = true;
			this.folderBrowser.Description = "Select the folder where to export";
			DialogResult dialogResult = this.folderBrowser.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			this.m_SaveFolder = this.folderBrowser.SelectedPath;
			this.progressBar.Maximum = this.m_DataSet.Tables.Count;
			for (int i = 0; i < this.m_DataSet.Tables.Count; i++)
			{
				this.progressBar.Value = i;
				this.statusLabel.Text = this.m_Localizer.GetString("Exporting ") + this.m_DataSet.Tables[i].TableName;
				this.Cursor = Cursors.WaitCursor;
				this.Refresh();
				string text = this.m_SaveFolder + "\\" + this.m_DataSet.Tables[i].TableName + ".txt";
				this.ExportTable(this.m_DataSet.Tables[i], text);
			}
			this.Cursor = Cursors.Default;
			this.progressBar.Value = 0;
			this.statusLabel.Text = this.m_Localizer.GetString("Ready");
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
		private void menuImportAll_Click(object sender, EventArgs e)
		{
			this.folderBrowser.ShowNewFolderButton = true;
			this.folderBrowser.SelectedPath = this.m_SaveFolder;
			this.folderBrowser.Description = "Select the folder from which to import";
			DialogResult dialogResult = this.folderBrowser.ShowDialog(this);
			if (dialogResult != DialogResult.OK)
			{
				return;
			}
			this.m_SaveFolder = this.folderBrowser.SelectedPath;
			string[] files = Directory.GetFiles(this.m_SaveFolder, "*.txt");
			this.progressBar.Maximum = files.Length;
			for (int i = 0; i < files.Length; i++)
			{
				this.progressBar.Value = i;
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(files[i]);
				DataTable dataTable = this.m_DataSet.Tables[fileNameWithoutExtension];
				if (dataTable != null)
				{
					this.statusLabel.Text = this.m_Localizer.GetString("Importing ") + fileNameWithoutExtension;
					this.Cursor = Cursors.WaitCursor;
					this.Refresh();
					this.ImportTable(dataTable, files[i]);
				}
				else
				{
					this.statusLabel.Text = this.m_Localizer.GetString("Cannot Import ") + fileNameWithoutExtension;
				}
			}
			this.Cursor = Cursors.Default;
			this.progressBar.Value = 0;
			this.statusLabel.Text = this.m_Localizer.GetString("Ready");
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000C90A File Offset: 0x0000AB0A
		private void DbMaster_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000C90C File Offset: 0x0000AB0C
		private void menuCopy_Click(object sender, EventArgs e)
		{
			DataGridView dataGridView = this.dataGridView;
			DataTable currentTable = this.m_CurrentTable;
			if (dataGridView.SelectedRows.Count <= 0)
			{
				this.m_UserMessage.ShowMessage(5048);
				return;
			}
			this.m_CopiedTableName = currentTable.TableName;
			this.m_CopiedRecords = new DataRow[dataGridView.SelectedRows.Count];
			this.m_ImportingTableSema = true;
			for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
			{
				DataGridViewRow dataGridViewRow = dataGridView.SelectedRows[i];
				DataRow dataRow = currentTable.NewRow();
				for (int j = 0; j < dataGridViewRow.Cells.Count; j++)
				{
					dataRow[j] = dataGridViewRow.Cells[j].Value;
				}
				this.m_CopiedRecords[i] = dataRow;
			}
			this.m_ImportingTableSema = false;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000C9E5 File Offset: 0x0000ABE5
		private void menuPaste_Click(object sender, EventArgs e)
		{
			if (this.CanPaste())
			{
				this.PasteRecords();
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		private bool CanPaste()
		{
			if (this.m_CopiedRecords == null || this.m_CopiedRecords.Length == 0)
			{
				this.m_UserMessage.ShowMessage(5046);
				return false;
			}
			if (this.m_CopiedTableName != this.m_CurrentTable.TableName)
			{
				this.m_UserMessage.ShowMessage(5047);
				return false;
			}
			return true;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000CA56 File Offset: 0x0000AC56
		private bool CanDelete()
		{
			if (this.dataGridView.SelectedRows.Count <= 0)
			{
				this.m_UserMessage.ShowMessage(5045);
				return false;
			}
			return true;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000CA80 File Offset: 0x0000AC80
		private void PasteRecords()
		{
			this.m_ImportingTableSema = true;
			for (int i = 0; i < this.m_CopiedRecords.Length; i++)
			{
				DataRow dataRow = this.m_CurrentTable.NewRow();
				dataRow.ItemArray = this.m_CopiedRecords[i].ItemArray;
				this.m_CurrentTable.Rows.Add(dataRow);
			}
			this.m_ImportingTableSema = false;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		private void DeleteRecords()
		{
			this.m_ImportingTableSema = true;
			foreach (object obj in this.dataGridView.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				this.dataGridView.Rows.Remove(dataGridViewRow);
			}
			this.m_ImportingTableSema = false;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000CB58 File Offset: 0x0000AD58
		private void menuReplace_Click(object sender, EventArgs e)
		{
			if (this.CanPaste() && this.CanDelete())
			{
				this.DeleteRecords();
				this.PasteRecords();
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000CB76 File Offset: 0x0000AD76
		private void menuDelete_Click(object sender, EventArgs e)
		{
			if (this.CanDelete())
			{
				this.DeleteRecords();
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000CB88 File Offset: 0x0000AD88
		private void menuCount_Click(object sender, EventArgs e)
		{
			string text = "Record counter = " + this.m_CurrentTable.Rows.Count.ToString();
			this.m_UserMessage.ShowMessage(20000, text);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000CBCA File Offset: 0x0000ADCA
		private void menuFind_Click(object sender, EventArgs e)
		{
			this.FindNext(false);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000CBD3 File Offset: 0x0000ADD3
		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.FindNext(false);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000CBDC File Offset: 0x0000ADDC
		private void buttonFindExactly_Click(object sender, EventArgs e)
		{
			this.FindNext(true);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		private void FindNext(bool checkExactly)
		{
			if (this.textSearch.Text == "" || this.comboSearch.SelectedIndex < 0)
			{
				this.m_UserMessage.ShowMessage(1013);
				return;
			}
			string text = this.textSearch.Text.ToString();
			string text2 = text.ToLower();
			int selectedIndex = this.comboSearch.SelectedIndex;
			int count = this.m_CurrentTable.Rows.Count;
			if (count == 0)
			{
				this.m_UserMessage.ShowMessage(20000, "No record available in this table");
				return;
			}
			int index = this.dataGridView.CurrentRow.Index;
			int num = index + 1;
			if (num == count)
			{
				num = 0;
			}
			bool flag = false;
			for (;;)
			{
				this.m_CurrentTable.Rows[num].ItemArray[selectedIndex].ToString();
				string text3 = this.dataGridView[selectedIndex, num].Value.ToString();
				string text4 = text3.ToLower();
				if (text4 == text2 || (text4.IndexOf(text2) >= 0 && !checkExactly))
				{
					break;
				}
				if (num == index)
				{
					goto IL_013D;
				}
				num++;
				if (num == count)
				{
					num = 0;
				}
			}
			this.dataGridView.CurrentCell = this.dataGridView[selectedIndex, num];
			flag = true;
			IL_013D:
			if (!flag)
			{
				this.m_UserMessage.ShowMessage(20000, "Not found");
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		private void textSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 13)
			{
				this.buttonFind.PerformClick();
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000CD64 File Offset: 0x0000AF64
		private void menuSort_Click(object sender, EventArgs e)
		{
			this.menuSort.Checked = !this.menuSort.Checked;
			if (this.menuSort.Checked)
			{
				using (IEnumerator enumerator = this.dataGridView.Columns.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
						dataGridViewColumn.SortMode = DataGridViewColumnSortMode.Automatic;
					}
					return;
				}
			}
			foreach (object obj2 in this.dataGridView.Columns)
			{
				DataGridViewColumn dataGridViewColumn2 = (DataGridViewColumn)obj2;
				dataGridViewColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000CE3C File Offset: 0x0000B03C
		private void buttonExportSingle_Click(object sender, EventArgs e)
		{
			this.menuExportCsv_Click(null, null);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000CE46 File Offset: 0x0000B046
		private void buttonExportMulti_Click(object sender, EventArgs e)
		{
			this.menuExportAll_Click(null, null);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000CE50 File Offset: 0x0000B050
		private void buttonImportSingle_Click(object sender, EventArgs e)
		{
			this.menuImportCsv_Click(null, null);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000CE5A File Offset: 0x0000B05A
		private void buttonImportMulti_Click(object sender, EventArgs e)
		{
			this.menuImportAll_Click(null, null);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000CE64 File Offset: 0x0000B064
		private void buttonRecordCopy_Click(object sender, EventArgs e)
		{
			this.menuCopy_Click(null, null);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000CE6E File Offset: 0x0000B06E
		private void buttonRecordcInsert_Click(object sender, EventArgs e)
		{
			this.menuPaste_Click(null, null);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000CE78 File Offset: 0x0000B078
		private void buttonRecordcReplace_Click(object sender, EventArgs e)
		{
			this.menuReplace_Click(null, null);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000CE82 File Offset: 0x0000B082
		private void buttonRecordcDelete_Click(object sender, EventArgs e)
		{
			this.menuDelete_Click(null, null);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000CE8C File Offset: 0x0000B08C
		private void buttonRecordcCount_Click(object sender, EventArgs e)
		{
			this.menuCount_Click(null, null);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000CE98 File Offset: 0x0000B098
		private void menuHelpFile_Click(object sender, EventArgs e)
		{
			string text = this.m_LaunchDir + "\\DbMaster.htm";
			if (File.Exists(text))
			{
				Help.ShowHelp(this, text);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000CEC5 File Offset: 0x0000B0C5
		private void menuAbout_Click(object sender, EventArgs e)
		{
			this.m_AboutForm.ShowDialog();
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000CED3 File Offset: 0x0000B0D3
		private void buttonOpen_Click(object sender, EventArgs e)
		{
			this.OpenXmlAndDb();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000CEDB File Offset: 0x0000B0DB
		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (this.m_IsDbFileOpen)
			{
				this.SaveDb();
				this.SaveXml();
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000CEF1 File Offset: 0x0000B0F1
		private void buttonClose_Click(object sender, EventArgs e)
		{
			if (this.AskAndSave())
			{
				this.CloseDb();
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000CF01 File Offset: 0x0000B101
		private void buttonIntelliEdit_Click(object sender, EventArgs e)
		{
			this.LoadIntelliEdit();
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000CF0C File Offset: 0x0000B10C
		private void expandFifadbToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.m_FifaDbFile.Expand();
			this.m_UserMessage.ShowMessage(flag ? 1010 : 1011);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000CF40 File Offset: 0x0000B140
		private void diagnosticToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000CF42 File Offset: 0x0000B142
		private void mainDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ExtractMainDbFromBig("\\Game\\patch.big", "\\Game\\patch.bh"))
			{
				this.HideMainDbInBig("\\Game\\data0.big", "\\Game\\data0.bh");
				return;
			}
			this.ExtractMainDbFromBig("\\Game\\data0.big", "\\Game\\data0.bh");
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000CF7C File Offset: 0x0000B17C
		private bool ExtractMainDbFromBig(string bigFileName, string bhFileName)
		{
			string text = this.m_InstallDir + "\\Game";
			BhFile bhFile = new BhFile(bhFileName);
			if (bhFile == null)
			{
				return false;
			}
			string text2 = "data/db/fifa_ng_db.db";
			int archivedFileIndex = bhFile.GetArchivedFileIndex(text2);
			string text3 = "data/db/fifa_ng_db-meta.xml";
			int archivedFileIndex2 = bhFile.GetArchivedFileIndex(text3);
			if (archivedFileIndex == -1 && archivedFileIndex2 == -1)
			{
				this.statusLabel.Text = this.m_Localizer.GetString("Database not present in the BIG File.");
				return false;
			}
			FifaBigFile fifaBigFile = new FifaBigFile(bigFileName);
			if (fifaBigFile == null)
			{
				return false;
			}
			if (archivedFileIndex != -1)
			{
				fifaBigFile.Export(text2, text);
				bhFile.Hide(archivedFileIndex);
			}
			if (archivedFileIndex2 != -1)
			{
				fifaBigFile.Export(text3, text);
				bhFile.Hide(archivedFileIndex2);
			}
			bhFile.Save();
			this.statusLabel.Text = this.m_Localizer.GetString("Database extracted and hidden in the BIG File.");
			return true;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000D04C File Offset: 0x0000B24C
		private bool HideMainDbInBig(string bigFileName, string bhFileName)
		{
			this.m_InstallDir + "\\Game";
			BhFile bhFile = new BhFile(bhFileName);
			if (bhFile == null)
			{
				return false;
			}
			string text = "data/db/fifa_ng_db.db";
			int archivedFileIndex = bhFile.GetArchivedFileIndex(text);
			string text2 = "data/db/fifa_ng_db-meta.xml";
			int archivedFileIndex2 = bhFile.GetArchivedFileIndex(text2);
			if (archivedFileIndex == -1 && archivedFileIndex2 == -1)
			{
				return false;
			}
			if (new FifaBigFile(bigFileName) == null)
			{
				return false;
			}
			if (archivedFileIndex != -1)
			{
				bhFile.Hide(archivedFileIndex);
			}
			if (archivedFileIndex2 != -1)
			{
				bhFile.Hide(archivedFileIndex2);
			}
			bhFile.Save();
			return true;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
		private void localDatabasesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = this.m_InstallDir + "\\Game\\data\\loc\\locale.big";
			string text2 = this.m_InstallDir + "\\Game";
			FifaBigFile fifaBigFile = new FifaBigFile(text);
			string[] archivedFileNames = fifaBigFile.GetArchivedFileNames("*.db", true);
			string[] archivedFileNames2 = fifaBigFile.GetArchivedFileNames("*.xml", true);
			bool flag = fifaBigFile.Export(archivedFileNames, text2);
			if (flag)
			{
				fifaBigFile.Delete(archivedFileNames);
			}
			bool flag2 = fifaBigFile.Export(archivedFileNames2, text2);
			if (flag2)
			{
				fifaBigFile.Delete(archivedFileNames2);
			}
			if (flag || flag2)
			{
				fifaBigFile.Save();
				this.statusLabel.Text = this.m_Localizer.GetString("Database extracted and hidden in the BIG File.");
				return;
			}
			this.statusLabel.Text = this.m_Localizer.GetString("Database not present in the BIG File.");
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000D194 File Offset: 0x0000B394
		private void buttonComputeHash_Click(object sender, EventArgs e)
		{
			this.CalculateAllHash();
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000D19C File Offset: 0x0000B39C
		private void calculateHashidToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.CalculateAllHash();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
		private void CalculateAllHash()
		{
			if (this.m_CurrentTable.Columns[1].ColumnName == "hashid" && this.m_CurrentTable.Columns[2].ColumnName == "stringid")
			{
				this.Cursor = Cursors.WaitCursor;
				for (int i = 0; i < this.m_CurrentTable.Rows.Count; i++)
				{
					string text = (string)this.dataGridView.Rows[i].Cells[2].Value;
					uint num = FifaUtil.ComputeLanguageHash(text);
					int num2 = (int)num;
					this.dataGridView.Rows[i].Cells[1].Value = num2;
				}
				this.Cursor = Cursors.Default;
			}
		}

		// Token: 0x04000081 RID: 129
		public int g_CellCounter;

		// Token: 0x04000082 RID: 130
		public string m_InstallDir;

		// Token: 0x04000083 RID: 131
		public string m_LaunchDir;

		// Token: 0x04000084 RID: 132
		public string m_SaveFolder;

		// Token: 0x04000085 RID: 133
		private string m_FifaDbFileName;

		// Token: 0x04000086 RID: 134
		private DbFile m_FifaDbFile;

		// Token: 0x04000087 RID: 135
		private string m_XmlFileName;

		// Token: 0x04000088 RID: 136
		private DataSet m_DataSet;

		// Token: 0x04000089 RID: 137
		private DataTable m_CurrentTable;

		// Token: 0x0400008A RID: 138
		private UnicodeEncoding m_Encoder = new UnicodeEncoding();

		// Token: 0x0400008B RID: 139
		private string m_CopiedTableName;

		// Token: 0x0400008C RID: 140
		private DataRow[] m_CopiedRecords;

		// Token: 0x0400008D RID: 141
		private IntelliEdit[] m_IntelliEdit;

		// Token: 0x0400008E RID: 142
		private DataSet m_IntelliEditSet;

		// Token: 0x0400008F RID: 143
		private IntelliEdit m_CurrentIntelliEdit;

		// Token: 0x04000090 RID: 144
		private bool m_IsIntegerColumn;

		// Token: 0x04000091 RID: 145
		private bool m_ChangeColumnSema = true;

		// Token: 0x04000092 RID: 146
		private bool m_ChangeValueSema = true;

		// Token: 0x04000093 RID: 147
		private bool m_ImportingTableSema;

		// Token: 0x04000094 RID: 148
		private UserMessage m_UserMessage = new UserMessage();

		// Token: 0x04000095 RID: 149
		private bool m_IsDbFileOpen;

		// Token: 0x04000096 RID: 150
		private AboutForm m_AboutForm;

		// Token: 0x04000097 RID: 151
		private string m_LatestGame;

		// Token: 0x04000098 RID: 152
		private Localization m_Localizer;
	}
}
