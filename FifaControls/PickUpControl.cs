using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000004 RID: 4
	public class PickUpControl : UserControl
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002C10 File Offset: 0x00000E10
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002C18 File Offset: 0x00000E18
		[Description("Array List to show")]
		[Category("User")]
		public IdArrayList ObjectList
		{
			get
			{
				return this.m_ObjectList;
			}
			set
			{
				object selectedItem = this.combo.SelectedItem;
				this.m_ObjectList = value;
				if (this.m_ObjectList == null)
				{
					this.combo.Items.Clear();
					return;
				}
				this.combo.BeginUpdate();
				this.combo.Items.Clear();
				this.combo.Items.AddRange(this.m_ObjectList.ToArray());
				this.combo.EndUpdate();
				if (selectedItem == null && this.combo.Items.Count > 0)
				{
					this.combo.SelectedIndex = 0;
					return;
				}
				this.combo.SelectedItem = selectedItem;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002CC1 File Offset: 0x00000EC1
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002CC9 File Offset: 0x00000EC9
		[Category("User")]
		[Description("Enable the main selection combo box")]
		public bool MainSelectionEnabled
		{
			get
			{
				return this.m_MainSelectionEnabled;
			}
			set
			{
				this.m_MainSelectionEnabled = value;
				this.combo.Visible = value;
				this.separatorBegin.Visible = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002CEA File Offset: 0x00000EEA
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002CF4 File Offset: 0x00000EF4
		[Description("Enable the filter tools")]
		[Category("User")]
		public bool FilterEnabled
		{
			get
			{
				return this.m_FilterEnabled;
			}
			set
			{
				this.m_FilterEnabled = value;
				this.labelFilter.Visible = value;
				this.comboFilterBy.Visible = value;
				this.comboFilterValue.Visible = value;
				this.separatorFilter.Visible = value;
				this.buttonYoungPlayer.Visible = this.m_FilterEnabled && this.m_YoungPlayersEnabled;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002D54 File Offset: 0x00000F54
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Description("Enable the Young Players chack")]
		[Category("User")]
		public bool YoungPlayersEnabled
		{
			get
			{
				return this.m_YoungPlayersEnabled;
			}
			set
			{
				this.m_YoungPlayersEnabled = value;
				this.buttonYoungPlayer.Visible = this.m_FilterEnabled && this.m_YoungPlayersEnabled;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002D81 File Offset: 0x00000F81
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Description("Enable the search tools")]
		[Category("User")]
		public bool SearchEnabled
		{
			get
			{
				return this.m_SearchEnabled;
			}
			set
			{
				this.m_SearchEnabled = value;
				this.buttonSearchContain.Visible = value;
				this.buttonSearchExactly.Visible = value;
				this.buttonSearchStart.Visible = value;
				this.textSearch.Visible = value;
				this.buttonCaseSensitive.Visible = value;
				this.separatorSearch.Visible = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002DE8 File Offset: 0x00000FE8
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Category("User")]
		[Description("Enable the create button")]
		public bool CreateButtonEnabled
		{
			get
			{
				return this.m_CreateButtonEnabled;
			}
			set
			{
				this.m_CreateButtonEnabled = value;
				this.buttonNew.Visible = value;
				this.separatorButtons.Visible = this.m_CreateButtonEnabled || this.m_RemoveButtonEnabled || this.m_CloneButtonEnabled;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002E29 File Offset: 0x00001029
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002E31 File Offset: 0x00001031
		[Category("User")]
		[Description("Enable the create button")]
		public bool RemoveButtonEnabled
		{
			get
			{
				return this.m_RemoveButtonEnabled;
			}
			set
			{
				this.m_RemoveButtonEnabled = value;
				this.buttonRemove.Visible = value;
				this.separatorButtons.Visible = this.m_CreateButtonEnabled || this.m_RemoveButtonEnabled || this.m_CloneButtonEnabled;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002E6A File Offset: 0x0000106A
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002E72 File Offset: 0x00001072
		[Category("User")]
		[Description("Enable the create button")]
		public bool CloneButtonEnabled
		{
			get
			{
				return this.m_CloneButtonEnabled;
			}
			set
			{
				this.m_CloneButtonEnabled = value;
				this.buttonClone.Visible = value;
				this.separatorButtons.Visible = this.m_CreateButtonEnabled || this.m_RemoveButtonEnabled || this.m_CloneButtonEnabled;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002EAB File Offset: 0x000010AB
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002EB3 File Offset: 0x000010B3
		[Description("Enable the refresh button")]
		[Category("User")]
		public bool RefreshButtonEnabled
		{
			get
			{
				return this.m_RefreshButtonEnabled;
			}
			set
			{
				this.m_RefreshButtonEnabled = value;
				this.buttonRefresh.Visible = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002EC8 File Offset: 0x000010C8
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002ED0 File Offset: 0x000010D0
		[Category("User")]
		[Description("Enable the wizard button")]
		public bool WizardButtonEnabled
		{
			get
			{
				return this.m_WizardButtonEnabled;
			}
			set
			{
				this.m_WizardButtonEnabled = value;
				this.buttonWizard.Visible = value;
				this.separatorButtons.Visible = this.m_CreateButtonEnabled || this.m_RemoveButtonEnabled || this.m_CloneButtonEnabled;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002F09 File Offset: 0x00001109
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002F14 File Offset: 0x00001114
		[Category("User")]
		[Description("Filter by list")]
		public string[] FilterByList
		{
			get
			{
				return this.m_FilterByList;
			}
			set
			{
				this.m_FilterByList = value;
				this.comboFilterBy.Items.Clear();
				if (this.m_FilterByList != null)
				{
					this.comboFilterBy.Items.AddRange(this.m_FilterByList);
					this.comboFilterBy.SelectedIndex = 0;
					this.m_FilterIndex = new int[this.m_FilterByList.Length];
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002F75 File Offset: 0x00001175
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002F7D File Offset: 0x0000117D
		[Category("User")]
		[Description("Filter values")]
		public IdArrayList[] FilterValues
		{
			get
			{
				return this.m_FilterValues;
			}
			set
			{
				this.m_FilterValues = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002F86 File Offset: 0x00001186
		public object FoundObject
		{
			get
			{
				return this.m_FoundObject;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002F8E File Offset: 0x0000118E
		public bool HasFound
		{
			get
			{
				return this.m_HasFound;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002F96 File Offset: 0x00001196
		public bool IsCaseSensitive
		{
			get
			{
				return this.m_CaseSensitive;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002F9E File Offset: 0x0000119E
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002FA6 File Offset: 0x000011A6
		public int CurrentIndex
		{
			get
			{
				return this.m_CurrentSearchIndex;
			}
			set
			{
				this.m_CurrentSearchIndex = value;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002FB0 File Offset: 0x000011B0
		public PickUpControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003008 File Offset: 0x00001208
		public void SwitchObject(IdObject idObject)
		{
			this.m_SwitchSema = true;
			int num = this.combo.Items.IndexOf(idObject);
			if (num >= 0)
			{
				this.combo.Items.RemoveAt(num);
				this.combo.Items.Insert(num, idObject);
				this.combo.SelectedItem = idObject;
			}
			this.m_SwitchSema = false;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003068 File Offset: 0x00001268
		private void combo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_SwitchSema)
			{
				return;
			}
			this.m_CurrentObject = this.combo.SelectedIndex;
			if (this.SelectObject != null && this.combo.SelectedItem != null)
			{
				this.Refresh();
				Cursor.Current = Cursors.WaitCursor;
				this.SelectObject(sender, this.combo.SelectedItem);
				Cursor.Current = Cursors.Default;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000030D8 File Offset: 0x000012D8
		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (this.CreateObject != null)
			{
				IdObject idObject = this.CreateObject(sender, e);
				if (idObject != null)
				{
					this.combo.Items.Add(idObject);
					this.combo.SelectedItem = idObject;
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000311C File Offset: 0x0000131C
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			IdObject idObject = (IdObject)this.combo.SelectedItem;
			if (idObject != null)
			{
				if (this.DeleteObject != null)
				{
					this.DeleteObject(sender, idObject);
				}
				int num = this.combo.Items.IndexOf(idObject);
				this.combo.Items.RemoveAt(num);
				if (num < this.combo.Items.Count)
				{
					this.combo.SelectedIndex = num;
					return;
				}
				if (this.combo.Items.Count > 0)
				{
					this.combo.SelectedIndex = this.combo.Items.Count - 1;
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000031CC File Offset: 0x000013CC
		private void buttonClone_Click(object sender, EventArgs e)
		{
			if (this.CloneObject != null)
			{
				IdObject idObject = (IdObject)this.combo.SelectedItem;
				if (idObject != null)
				{
					IdObject idObject2 = this.CloneObject(sender, idObject);
					if (idObject2 != null)
					{
						this.combo.Items.Add(idObject2);
						this.combo.SelectedItem = idObject2;
					}
				}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003224 File Offset: 0x00001424
		private void buttonCaseSensitive_Click(object sender, EventArgs e)
		{
			this.m_CaseSensitive = this.buttonCaseSensitive.Checked;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003237 File Offset: 0x00001437
		private void textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 13)
			{
				this.Search();
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000324A File Offset: 0x0000144A
		private void buttonSearchExact_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = PickUpControl.SearchMode.SearchExact;
			this.Search();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000325A File Offset: 0x0000145A
		private void buttonSearchStart_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = PickUpControl.SearchMode.SearchStarting;
			this.Search();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000326A File Offset: 0x0000146A
		private void buttonSearchContain_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = PickUpControl.SearchMode.SearchContaining;
			this.Search();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000327C File Offset: 0x0000147C
		public bool Search()
		{
			this.m_Pattern = this.textSearch.Text;
			if (!this.IsCaseSensitive)
			{
				this.m_Pattern = this.m_Pattern.ToLower();
			}
			int num = this.m_CurrentSearchIndex;
			num++;
			if (num == this.m_ObjectList.Count)
			{
				num = 0;
			}
			for (;;)
			{
				string text = this.m_ObjectList[num].ToString();
				if (!this.IsCaseSensitive)
				{
					text = text.ToLower();
				}
				switch (this.m_SearchMode)
				{
				case PickUpControl.SearchMode.SearchExact:
					this.m_HasFound = text.ToString().Equals(this.m_Pattern);
					break;
				case PickUpControl.SearchMode.SearchStarting:
					this.m_HasFound = text.ToString().StartsWith(this.m_Pattern);
					break;
				case PickUpControl.SearchMode.SearchContaining:
					this.m_HasFound = text.Contains(this.m_Pattern);
					break;
				}
				if (this.m_HasFound)
				{
					break;
				}
				if (num == this.m_CurrentSearchIndex)
				{
					goto IL_011E;
				}
				num++;
				if (num == this.m_ObjectList.Count)
				{
					num = 0;
				}
			}
			this.m_FoundObject = this.m_ObjectList[num];
			this.m_CurrentSearchIndex = num;
			this.combo.SelectedItem = this.m_FoundObject;
			return true;
			IL_011E:
			this.m_FoundObject = null;
			return false;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000033B0 File Offset: 0x000015B0
		private void comboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboFilterBy.SelectedIndex < 0)
			{
				return;
			}
			if (this.comboFilterBy.SelectedIndex == 0)
			{
				this.comboFilterValue.Items.Clear();
				this.comboFilterValue.Enabled = false;
				this.combo.Items.Clear();
				if (this.FilterChanged != null)
				{
					this.FilterChanged(sender, null);
				}
				this.FilterObjects();
				this.m_CurrentFilterBy = 0;
				return;
			}
			int selectedIndex = this.comboFilterBy.SelectedIndex;
			this.comboFilterValue.Items.Clear();
			this.comboFilterValue.Items.AddRange(this.m_FilterValues[selectedIndex].ToArray());
			this.comboFilterValue.Enabled = true;
			if (this.m_FilterIndex[selectedIndex] < this.comboFilterValue.Items.Count)
			{
				this.comboFilterValue.SelectedIndex = this.m_FilterIndex[selectedIndex];
			}
			else
			{
				this.m_FilterIndex[selectedIndex] = 0;
				this.comboFilterValue.SelectedIndex = this.m_FilterIndex[selectedIndex];
			}
			if (this.FilterChanged != null)
			{
				this.FilterChanged(sender, this.comboFilterValue.SelectedItem);
			}
			this.m_CurrentFilterBy = this.comboFilterBy.SelectedIndex;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000034EC File Offset: 0x000016EC
		private void comboFilterValue_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.comboFilterBy.SelectedIndex;
			if (selectedIndex == this.m_CurrentFilterBy && (this.comboFilterValue.SelectedIndex < 0 || this.comboFilterValue.SelectedIndex == this.m_FilterIndex[selectedIndex]))
			{
				return;
			}
			this.m_FilterIndex[selectedIndex] = this.comboFilterValue.SelectedIndex;
			if (this.FilterChanged != null)
			{
				this.FilterChanged(sender, this.comboFilterValue.SelectedItem);
			}
			this.FilterObjects();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000356C File Offset: 0x0000176C
		private void FilterObjects()
		{
			if (this.m_ObjectList != null)
			{
				IdArrayList idArrayList;
				if (this.buttonYoungPlayer.Visible)
				{
					idArrayList = this.m_ObjectList.Filter((IdObject)this.comboFilterValue.SelectedItem, this.buttonYoungPlayer.Checked);
				}
				else
				{
					idArrayList = this.m_ObjectList.Filter((IdObject)this.comboFilterValue.SelectedItem);
				}
				this.combo.Items.Clear();
				this.combo.Items.AddRange(idArrayList.ToArray());
				if (this.combo.Items.Count != 0)
				{
					this.combo.SelectedIndex = 0;
					return;
				}
				this.combo.Text = string.Empty;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000362C File Offset: 0x0000182C
		private void buttonWizard_Click(object sender, EventArgs e)
		{
			if (this.WizardObject != null)
			{
				IdObject idObject = this.WizardObject(sender, e);
				if (idObject != null)
				{
					this.combo.Items.Add(idObject);
					this.combo.SelectedItem = idObject;
				}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003670 File Offset: 0x00001870
		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			if (this.RefreshObject != null)
			{
				this.RefreshObject(sender, e);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003688 File Offset: 0x00001888
		private void buttonYoungPlayer_CheckedChanged(object sender, EventArgs e)
		{
			this.FilterObjects();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003690 File Offset: 0x00001890
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000036B0 File Offset: 0x000018B0
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PickUpControl));
			this.toolStrip = new ToolStrip();
			this.separatorBegin = new ToolStripSeparator();
			this.combo = new ToolStripComboBox();
			this.buttonRefresh = new ToolStripButton();
			this.separatorSearch = new ToolStripSeparator();
			this.buttonCaseSensitive = new ToolStripButton();
			this.textSearch = new ToolStripTextBox();
			this.buttonSearchExactly = new ToolStripButton();
			this.buttonSearchStart = new ToolStripButton();
			this.buttonSearchContain = new ToolStripButton();
			this.separatorButtons = new ToolStripSeparator();
			this.buttonNew = new ToolStripButton();
			this.buttonRemove = new ToolStripButton();
			this.buttonClone = new ToolStripButton();
			this.buttonWizard = new ToolStripButton();
			this.separatorFilter = new ToolStripSeparator();
			this.labelFilter = new ToolStripLabel();
			this.comboFilterBy = new ToolStripComboBox();
			this.comboFilterValue = new ToolStripComboBox();
			this.buttonYoungPlayer = new ToolStripButton();
			this.toolStrip.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip.AllowItemReorder = true;
			this.toolStrip.BackColor = SystemColors.Control;
			this.toolStrip.BackgroundImage = (Image)componentResourceManager.GetObject("toolStrip.BackgroundImage");
			this.toolStrip.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new ToolStripItem[]
			{
				this.separatorBegin, this.combo, this.buttonRefresh, this.separatorSearch, this.buttonCaseSensitive, this.textSearch, this.buttonSearchExactly, this.buttonSearchStart, this.buttonSearchContain, this.separatorButtons,
				this.buttonNew, this.buttonRemove, this.buttonClone, this.buttonWizard, this.separatorFilter, this.labelFilter, this.comboFilterBy, this.comboFilterValue, this.buttonYoungPlayer
			});
			this.toolStrip.Location = new Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new Size(920, 25);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip";
			this.separatorBegin.Name = "separatorBegin";
			this.separatorBegin.Size = new Size(6, 25);
			this.combo.DropDownHeight = 256;
			this.combo.IntegralHeight = false;
			this.combo.MaxDropDownItems = 16;
			this.combo.Name = "combo";
			this.combo.Size = new Size(200, 25);
			this.combo.Sorted = true;
			this.combo.SelectedIndexChanged += this.combo_SelectedIndexChanged;
			this.buttonRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonRefresh.Image = (Image)componentResourceManager.GetObject("buttonRefresh.Image");
			this.buttonRefresh.ImageTransparentColor = Color.Magenta;
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new Size(23, 22);
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.Click += this.buttonRefresh_Click;
			this.separatorSearch.Name = "separatorSearch";
			this.separatorSearch.Size = new Size(6, 25);
			this.buttonCaseSensitive.CheckOnClick = true;
			this.buttonCaseSensitive.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonCaseSensitive.Image = (Image)componentResourceManager.GetObject("buttonCaseSensitive.Image");
			this.buttonCaseSensitive.ImageTransparentColor = Color.Magenta;
			this.buttonCaseSensitive.Name = "buttonCaseSensitive";
			this.buttonCaseSensitive.Size = new Size(23, 22);
			this.buttonCaseSensitive.Text = "Case sensitive";
			this.buttonCaseSensitive.Click += this.buttonCaseSensitive_Click;
			this.textSearch.Name = "textSearch";
			this.textSearch.Size = new Size(150, 25);
			this.textSearch.KeyDown += this.textBox_KeyDown;
			this.buttonSearchExactly.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchExactly.Image = (Image)componentResourceManager.GetObject("buttonSearchExactly.Image");
			this.buttonSearchExactly.ImageTransparentColor = Color.Magenta;
			this.buttonSearchExactly.Name = "buttonSearchExactly";
			this.buttonSearchExactly.Size = new Size(23, 22);
			this.buttonSearchExactly.Text = "Search Exactly";
			this.buttonSearchExactly.Click += this.buttonSearchExact_Click;
			this.buttonSearchStart.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchStart.Image = (Image)componentResourceManager.GetObject("buttonSearchStart.Image");
			this.buttonSearchStart.ImageTransparentColor = Color.Magenta;
			this.buttonSearchStart.Name = "buttonSearchStart";
			this.buttonSearchStart.Size = new Size(23, 22);
			this.buttonSearchStart.Text = "Search if starts";
			this.buttonSearchStart.Click += this.buttonSearchStart_Click;
			this.buttonSearchContain.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchContain.Image = (Image)componentResourceManager.GetObject("buttonSearchContain.Image");
			this.buttonSearchContain.ImageTransparentColor = Color.Magenta;
			this.buttonSearchContain.Name = "buttonSearchContain";
			this.buttonSearchContain.Size = new Size(23, 22);
			this.buttonSearchContain.Text = "Search if contains";
			this.buttonSearchContain.Click += this.buttonSearchContain_Click;
			this.separatorButtons.Name = "separatorButtons";
			this.separatorButtons.Size = new Size(6, 25);
			this.buttonNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonNew.Image = (Image)componentResourceManager.GetObject("buttonNew.Image");
			this.buttonNew.ImageTransparentColor = Color.Magenta;
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new Size(23, 22);
			this.buttonNew.Text = "Create";
			this.buttonNew.Click += this.buttonNew_Click;
			this.buttonRemove.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonRemove.Image = (Image)componentResourceManager.GetObject("buttonRemove.Image");
			this.buttonRemove.ImageTransparentColor = Color.Magenta;
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new Size(23, 22);
			this.buttonRemove.Text = "Remove";
			this.buttonRemove.Click += this.buttonDelete_Click;
			this.buttonClone.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonClone.Image = (Image)componentResourceManager.GetObject("buttonClone.Image");
			this.buttonClone.ImageTransparentColor = Color.Magenta;
			this.buttonClone.Name = "buttonClone";
			this.buttonClone.Size = new Size(23, 22);
			this.buttonClone.Text = "Clone";
			this.buttonClone.Click += this.buttonClone_Click;
			this.buttonWizard.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonWizard.Image = (Image)componentResourceManager.GetObject("buttonWizard.Image");
			this.buttonWizard.ImageTransparentColor = Color.Magenta;
			this.buttonWizard.Name = "buttonWizard";
			this.buttonWizard.Size = new Size(23, 22);
			this.buttonWizard.Text = "Wizard";
			this.buttonWizard.Visible = false;
			this.buttonWizard.Click += this.buttonWizard_Click;
			this.separatorFilter.Name = "separatorFilter";
			this.separatorFilter.Size = new Size(6, 25);
			this.separatorFilter.Visible = false;
			this.labelFilter.Name = "labelFilter";
			this.labelFilter.Size = new Size(33, 22);
			this.labelFilter.Text = "Filter";
			this.labelFilter.Visible = false;
			this.comboFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboFilterBy.Name = "comboFilterBy";
			this.comboFilterBy.Size = new Size(80, 25);
			this.comboFilterBy.Visible = false;
			this.comboFilterBy.SelectedIndexChanged += this.comboFilterBy_SelectedIndexChanged;
			this.comboFilterValue.Name = "comboFilterValue";
			this.comboFilterValue.Size = new Size(160, 25);
			this.comboFilterValue.Sorted = true;
			this.comboFilterValue.Visible = false;
			this.comboFilterValue.SelectedIndexChanged += this.comboFilterValue_SelectedIndexChanged;
			this.buttonYoungPlayer.CheckOnClick = true;
			this.buttonYoungPlayer.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.buttonYoungPlayer.Image = (Image)componentResourceManager.GetObject("buttonYoungPlayer.Image");
			this.buttonYoungPlayer.ImageTransparentColor = Color.Magenta;
			this.buttonYoungPlayer.Name = "buttonYoungPlayer";
			this.buttonYoungPlayer.Size = new Size(86, 22);
			this.buttonYoungPlayer.Text = "Young Players";
			this.buttonYoungPlayer.CheckedChanged += this.buttonYoungPlayer_CheckedChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.Controls.Add(this.toolStrip);
			base.Name = "PickUpControl";
			base.Size = new Size(920, 25);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000011 RID: 17
		private IdArrayList m_ObjectList;

		// Token: 0x04000012 RID: 18
		private bool m_MainSelectionEnabled = true;

		// Token: 0x04000013 RID: 19
		private bool m_FilterEnabled;

		// Token: 0x04000014 RID: 20
		private bool m_YoungPlayersEnabled;

		// Token: 0x04000015 RID: 21
		private bool m_SearchEnabled = true;

		// Token: 0x04000016 RID: 22
		private bool m_CreateButtonEnabled = true;

		// Token: 0x04000017 RID: 23
		private bool m_RemoveButtonEnabled = true;

		// Token: 0x04000018 RID: 24
		private bool m_CloneButtonEnabled = true;

		// Token: 0x04000019 RID: 25
		private bool m_RefreshButtonEnabled = true;

		// Token: 0x0400001A RID: 26
		private bool m_WizardButtonEnabled;

		// Token: 0x0400001B RID: 27
		private string[] m_FilterByList;

		// Token: 0x0400001C RID: 28
		private IdArrayList[] m_FilterValues;

		// Token: 0x0400001D RID: 29
		private int[] m_FilterIndex;

		// Token: 0x0400001E RID: 30
		[Description("Handle selected object change.")]
		[Category("User")]
		public PickUpControl.PickUpCallback SelectObject;

		// Token: 0x0400001F RID: 31
		public PickUpControl.PickUpCallback CreateObject;

		// Token: 0x04000020 RID: 32
		public PickUpControl.PickUpCallback DeleteObject;

		// Token: 0x04000021 RID: 33
		public PickUpControl.PickUpCallback CloneObject;

		// Token: 0x04000022 RID: 34
		public PickUpControl.PickUpCallback FilterChanged;

		// Token: 0x04000023 RID: 35
		public PickUpControl.PickUpCallback WizardObject;

		// Token: 0x04000024 RID: 36
		public PickUpControl.PickUpCallback RefreshObject;

		// Token: 0x04000025 RID: 37
		private bool m_SwitchSema;

		// Token: 0x04000026 RID: 38
		private int m_CurrentObject = -1;

		// Token: 0x04000027 RID: 39
		private int m_CurrentFilterBy = -1;

		// Token: 0x04000028 RID: 40
		private object m_FoundObject;

		// Token: 0x04000029 RID: 41
		private bool m_HasFound;

		// Token: 0x0400002A RID: 42
		private bool m_CaseSensitive;

		// Token: 0x0400002B RID: 43
		private int m_CurrentSearchIndex;

		// Token: 0x0400002C RID: 44
		private string m_Pattern;

		// Token: 0x0400002D RID: 45
		private PickUpControl.SearchMode m_SearchMode = PickUpControl.SearchMode.SearchContaining;

		// Token: 0x0400002E RID: 46
		private IContainer components;

		// Token: 0x0400002F RID: 47
		private ToolStrip toolStrip;

		// Token: 0x04000030 RID: 48
		private ToolStripSeparator separatorBegin;

		// Token: 0x04000031 RID: 49
		private ToolStripSeparator separatorSearch;

		// Token: 0x04000032 RID: 50
		private ToolStripSeparator separatorButtons;

		// Token: 0x04000033 RID: 51
		public ToolStripComboBox combo;

		// Token: 0x04000034 RID: 52
		public ToolStripButton buttonCaseSensitive;

		// Token: 0x04000035 RID: 53
		public ToolStripTextBox textSearch;

		// Token: 0x04000036 RID: 54
		public ToolStripButton buttonSearchContain;

		// Token: 0x04000037 RID: 55
		public ToolStripButton buttonSearchExactly;

		// Token: 0x04000038 RID: 56
		public ToolStripButton buttonSearchStart;

		// Token: 0x04000039 RID: 57
		public ToolStripButton buttonNew;

		// Token: 0x0400003A RID: 58
		public ToolStripButton buttonRemove;

		// Token: 0x0400003B RID: 59
		public ToolStripButton buttonClone;

		// Token: 0x0400003C RID: 60
		public ToolStripLabel labelFilter;

		// Token: 0x0400003D RID: 61
		public ToolStripComboBox comboFilterBy;

		// Token: 0x0400003E RID: 62
		public ToolStripComboBox comboFilterValue;

		// Token: 0x0400003F RID: 63
		public ToolStripSeparator separatorFilter;

		// Token: 0x04000040 RID: 64
		private ToolStripButton buttonWizard;

		// Token: 0x04000041 RID: 65
		private ToolStripButton buttonRefresh;

		// Token: 0x04000042 RID: 66
		public ToolStripButton buttonYoungPlayer;

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000041 RID: 65
		public delegate IdObject PickUpCallback(object sender, object obj);

		// Token: 0x02000006 RID: 6
		private enum SearchMode
		{
			// Token: 0x04000044 RID: 68
			SearchExact,
			// Token: 0x04000045 RID: 69
			SearchStarting,
			// Token: 0x04000046 RID: 70
			SearchContaining
		}
	}
}
