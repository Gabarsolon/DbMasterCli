using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200003F RID: 63
	public class Compobj : IdObject
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x00023E2E File Offset: 0x0002202E
		public override string ToString()
		{
			return this.m_TypeString;
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00023E36 File Offset: 0x00022036
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00023E3E File Offset: 0x0002203E
		public Compobj ParentObj
		{
			get
			{
				return this.m_ParentObj;
			}
			set
			{
				this.m_ParentObj = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00023E47 File Offset: 0x00022047
		public ConfederationList Confederations
		{
			get
			{
				return this.m_Confederations;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00023E4F File Offset: 0x0002204F
		public NationList Nations
		{
			get
			{
				return this.m_Nations;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00023E57 File Offset: 0x00022057
		public TrophyList Trophies
		{
			get
			{
				return this.m_Trophies;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00023E5F File Offset: 0x0002205F
		public StageList Stages
		{
			get
			{
				return this.m_Stages;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00023E67 File Offset: 0x00022067
		public GroupList Groups
		{
			get
			{
				return this.m_Groups;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x00023E6F File Offset: 0x0002206F
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00023E77 File Offset: 0x00022077
		public int TypeNumber
		{
			get
			{
				return this.m_TypeNumber;
			}
			set
			{
				this.m_TypeNumber = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00023E80 File Offset: 0x00022080
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00023E88 File Offset: 0x00022088
		public string TypeString
		{
			get
			{
				return this.m_TypeString;
			}
			set
			{
				this.m_TypeString = value;
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00023E91 File Offset: 0x00022091
		public bool IsWorld()
		{
			return this.m_TypeNumber == 0;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00023E9C File Offset: 0x0002209C
		public bool IsConfederation()
		{
			return this.m_TypeNumber == 1;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00023EA7 File Offset: 0x000220A7
		public bool IsNation()
		{
			return this.m_TypeNumber == 2;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00023EB2 File Offset: 0x000220B2
		public bool IsTrophy()
		{
			return this.m_TypeNumber == 3;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00023EBD File Offset: 0x000220BD
		public bool IsStage()
		{
			return this.m_TypeNumber == 4;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00023EC8 File Offset: 0x000220C8
		public bool IsGroup()
		{
			return this.m_TypeNumber == 5;
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00023ED3 File Offset: 0x000220D3
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00023EDB File Offset: 0x000220DB
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00023EE4 File Offset: 0x000220E4
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00023EEC File Offset: 0x000220EC
		public CompetitionSettings Settings
		{
			get
			{
				return this.m_CompetitionSettings;
			}
			set
			{
				this.m_CompetitionSettings = value;
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00023EF5 File Offset: 0x000220F5
		public Compobj(int id, int typeNumber, string typeString, string description, Compobj parentObj)
			: base(id)
		{
			this.m_TypeString = typeString;
			this.m_TypeNumber = typeNumber;
			this.m_Description = description;
			this.m_ParentObj = parentObj;
			this.m_CompetitionSettings = new CompetitionSettings(this);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00023F28 File Offset: 0x00022128
		public bool AddChild(Compobj childObject)
		{
			switch (childObject.TypeNumber)
			{
			case 1:
				this.m_Confederations.InsertId(childObject);
				break;
			case 2:
				this.m_Nations.InsertId(childObject);
				break;
			case 3:
				this.m_Trophies.InsertId(childObject);
				break;
			case 4:
				this.m_Stages.InsertId(childObject);
				break;
			case 5:
				this.m_Groups.InsertId(childObject);
				break;
			}
			return true;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00023FA6 File Offset: 0x000221A6
		public void SetProperty(string property, string val)
		{
			this.m_CompetitionSettings.LoadProperty(property, val);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00023FB8 File Offset: 0x000221B8
		public int Renumber(int id)
		{
			base.Id = id;
			id++;
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						id = trophy.Renumber(id);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					Confederation confederation = (Confederation)obj2;
					id = confederation.Renumber(id);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					Nation nation = (Nation)obj3;
					id = nation.Renumber(id);
					nation.Settings.m_rule_suspension = nation.Id;
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					Stage stage = (Stage)obj4;
					id = stage.Renumber(id);
					stage.Settings.UpdateIdUsingStageReference();
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					Group group = (Group)obj5;
					id = group.Renumber(id);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						id = trophy2.Renumber(id);
					}
				}
			}
			return id;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0002423C File Offset: 0x0002243C
		public bool SaveToCompobj(StreamWriter w)
		{
			int num = ((this.ParentObj != null) ? this.ParentObj.Id : (-1));
			string text = string.Concat(new object[]
			{
				base.Id.ToString(),
				",",
				this.m_TypeNumber,
				",",
				this.m_TypeString,
				",",
				this.m_Description,
				",",
				num
			});
			w.WriteLine(text);
			return true;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000242D4 File Offset: 0x000224D4
		public bool SaveRecursivelyToCompobj(StreamWriter w)
		{
			this.SaveToCompobj(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToCompobj(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					Confederation confederation = (Confederation)obj2;
					confederation.SaveRecursivelyToCompobj(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					Nation nation = (Nation)obj3;
					nation.SaveRecursivelyToCompobj(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					Stage stage = (Stage)obj4;
					stage.SaveRecursivelyToCompobj(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					Group group = (Group)obj5;
					group.SaveRecursivelyToCompobj(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToCompobj(w);
					}
				}
			}
			return true;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00024534 File Offset: 0x00022734
		public virtual bool SaveToCompids(StreamWriter w)
		{
			return false;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00024538 File Offset: 0x00022738
		public bool SaveRecursivelyToCompids(StreamWriter w)
		{
			this.SaveToCompids(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToCompids(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					Confederation confederation = (Confederation)obj2;
					confederation.SaveRecursivelyToCompids(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					Nation nation = (Nation)obj3;
					nation.SaveRecursivelyToCompids(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj4 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj4;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToCompids(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x000246E0 File Offset: 0x000228E0
		public bool SaveToSettings(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			this.m_CompetitionSettings.SaveToSettings(base.Id, w);
			return true;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000246FC File Offset: 0x000228FC
		public bool SaveRecursivelyToSettings(StreamWriter w)
		{
			this.SaveToSettings(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToSettings(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					Confederation confederation = (Confederation)obj2;
					confederation.SaveRecursivelyToSettings(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					Nation nation = (Nation)obj3;
					nation.SaveRecursivelyToSettings(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					Stage stage = (Stage)obj4;
					stage.SaveRecursivelyToSettings(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					Group group = (Group)obj5;
					group.SaveRecursivelyToSettings(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToSettings(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0002495C File Offset: 0x00022B5C
		public virtual bool SaveToStandings(StreamWriter w)
		{
			return false;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00024960 File Offset: 0x00022B60
		public bool SaveRecursivelyToStandings(StreamWriter w)
		{
			this.SaveToStandings(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToStandings(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					Confederation confederation = (Confederation)obj2;
					confederation.SaveRecursivelyToStandings(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					Nation nation = (Nation)obj3;
					nation.SaveRecursivelyToStandings(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					Stage stage = (Stage)obj4;
					stage.SaveRecursivelyToStandings(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					Group group = (Group)obj5;
					group.SaveRecursivelyToStandings(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToStandings(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00024BC0 File Offset: 0x00022DC0
		public virtual bool SaveToTasks(StreamWriter w)
		{
			return false;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00024BC4 File Offset: 0x00022DC4
		public bool SaveRecursivelyToTasks(StreamWriter w)
		{
			this.SaveToTasks(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToTasks(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					Confederation confederation = (Confederation)obj2;
					confederation.SaveRecursivelyToTasks(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					Nation nation = (Nation)obj3;
					nation.SaveRecursivelyToTasks(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					Stage stage = (Stage)obj4;
					stage.SaveRecursivelyToTasks(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					Group group = (Group)obj5;
					group.SaveRecursivelyToTasks(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToTasks(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00024E24 File Offset: 0x00023024
		public virtual bool SaveToAdvancement(StreamWriter w)
		{
			return false;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00024E28 File Offset: 0x00023028
		public bool SaveRecursivelyToAdvancement(StreamWriter w)
		{
			this.SaveToAdvancement(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToAdvancement(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					Confederation confederation = (Confederation)obj2;
					confederation.SaveRecursivelyToAdvancement(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					Nation nation = (Nation)obj3;
					nation.SaveRecursivelyToAdvancement(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					Stage stage = (Stage)obj4;
					stage.SaveRecursivelyToAdvancement(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					Group group = (Group)obj5;
					group.SaveRecursivelyToAdvancement(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToAdvancement(w);
					}
				}
			}
			return true;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00025088 File Offset: 0x00023288
		public virtual bool SaveToSchedule(StreamWriter w)
		{
			return false;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0002508C File Offset: 0x0002328C
		public bool SaveRecursivelyToSchedule(StreamWriter w)
		{
			this.SaveToSchedule(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToSchedule(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					Confederation confederation = (Confederation)obj2;
					confederation.SaveRecursivelyToSchedule(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					Nation nation = (Nation)obj3;
					nation.SaveRecursivelyToSchedule(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					Stage stage = (Stage)obj4;
					stage.SaveRecursivelyToSchedule(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					Group group = (Group)obj5;
					group.SaveRecursivelyToSchedule(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToSchedule(w);
					}
				}
			}
			return true;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x000252EC File Offset: 0x000234EC
		public virtual bool SaveToWeather(StreamWriter w)
		{
			return false;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000252F0 File Offset: 0x000234F0
		public bool SaveRecursivelyToWeather(StreamWriter w)
		{
			this.SaveToWeather(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToWeather(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					Confederation confederation = (Confederation)obj2;
					confederation.SaveRecursivelyToWeather(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					Nation nation = (Nation)obj3;
					nation.SaveRecursivelyToWeather(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					Stage stage = (Stage)obj4;
					stage.SaveRecursivelyToWeather(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					Group group = (Group)obj5;
					group.SaveRecursivelyToWeather(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToWeather(w);
					}
				}
			}
			return true;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00025550 File Offset: 0x00023750
		public virtual bool SaveToInitteams(StreamWriter w)
		{
			return false;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00025554 File Offset: 0x00023754
		public bool SaveRecursivelyToInitteams(StreamWriter w)
		{
			this.SaveToInitteams(w);
			if (this.m_Trophies != null)
			{
				foreach (object obj in this.m_Trophies)
				{
					Trophy trophy = (Trophy)obj;
					if (!trophy.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy.SaveRecursivelyToInitteams(w);
					}
				}
			}
			if (this.m_Confederations != null)
			{
				foreach (object obj2 in this.m_Confederations)
				{
					Confederation confederation = (Confederation)obj2;
					confederation.SaveRecursivelyToInitteams(w);
				}
			}
			if (this.m_Nations != null)
			{
				foreach (object obj3 in this.m_Nations)
				{
					Nation nation = (Nation)obj3;
					nation.SaveRecursivelyToInitteams(w);
				}
			}
			if (this.m_Stages != null)
			{
				foreach (object obj4 in this.m_Stages)
				{
					Stage stage = (Stage)obj4;
					stage.SaveRecursivelyToInitteams(w);
				}
			}
			if (this.m_Groups != null)
			{
				foreach (object obj5 in this.m_Groups)
				{
					Group group = (Group)obj5;
					group.SaveRecursivelyToInitteams(w);
				}
			}
			if (this.m_Trophies != null)
			{
				foreach (object obj6 in this.m_Trophies)
				{
					Trophy trophy2 = (Trophy)obj6;
					if (trophy2.Settings.m_comp_type.Contains("FRIENDLY"))
					{
						trophy2.SaveRecursivelyToInitteams(w);
					}
				}
			}
			return true;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000257B4 File Offset: 0x000239B4
		public virtual bool FillFromLanguage()
		{
			return false;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000257B7 File Offset: 0x000239B7
		public virtual bool SaveToLanguage()
		{
			return false;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000257BA File Offset: 0x000239BA
		public virtual void LinkLeague(LeagueList leagueList)
		{
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x000257BC File Offset: 0x000239BC
		public virtual void LinkTeam(TeamList teamList)
		{
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000257BE File Offset: 0x000239BE
		public virtual void LinkCountry(CountryList countryList)
		{
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x000257C0 File Offset: 0x000239C0
		public virtual void LinkStadium(StadiumList countryList)
		{
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000257C2 File Offset: 0x000239C2
		public virtual void LinkCompetitions()
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x000257C4 File Offset: 0x000239C4
		public virtual void Normalize()
		{
		}

		// Token: 0x04000271 RID: 625
		private Compobj m_ParentObj;

		// Token: 0x04000272 RID: 626
		protected ConfederationList m_Confederations;

		// Token: 0x04000273 RID: 627
		protected NationList m_Nations;

		// Token: 0x04000274 RID: 628
		protected TrophyList m_Trophies;

		// Token: 0x04000275 RID: 629
		protected StageList m_Stages;

		// Token: 0x04000276 RID: 630
		protected GroupList m_Groups;

		// Token: 0x04000277 RID: 631
		private int m_TypeNumber;

		// Token: 0x04000278 RID: 632
		private string m_TypeString;

		// Token: 0x04000279 RID: 633
		private string m_Description;

		// Token: 0x0400027A RID: 634
		private CompetitionSettings m_CompetitionSettings;
	}
}
