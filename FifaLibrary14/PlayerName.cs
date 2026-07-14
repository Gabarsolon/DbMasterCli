using System;

namespace FifaLibrary
{
	// Token: 0x02000026 RID: 38
	public class PlayerName : IdObject
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000295 RID: 661 RVA: 0x000132A8 File Offset: 0x000114A8
		// (set) Token: 0x06000296 RID: 662 RVA: 0x000132B0 File Offset: 0x000114B0
		public string Text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				this.m_Text = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000132B9 File Offset: 0x000114B9
		// (set) Token: 0x06000298 RID: 664 RVA: 0x000132C1 File Offset: 0x000114C1
		public bool IsUsed
		{
			get
			{
				return this.m_IsUsed;
			}
			set
			{
				this.m_IsUsed = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000132CA File Offset: 0x000114CA
		// (set) Token: 0x0600029A RID: 666 RVA: 0x000132D2 File Offset: 0x000114D2
		public int CommentaryId
		{
			get
			{
				return this.m_CommentaryId;
			}
			set
			{
				this.m_CommentaryId = value;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000132DB File Offset: 0x000114DB
		public PlayerName(Record r)
			: base(r.IntField[FI.playernames_nameid])
		{
			this.Load(r);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000132F6 File Offset: 0x000114F6
		public PlayerName(int id, string text, bool isUsed)
		{
			base.Id = id;
			this.m_Text = text;
			this.m_IsUsed = isUsed;
			this.m_CommentaryId = 900000;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001331E File Offset: 0x0001151E
		public void Load(Record r)
		{
			this.m_Text = r.CompressedString[FI.playernames_name];
			this.m_IsUsed = false;
			this.m_CommentaryId = r.IntField[FI.playernames_commentaryid];
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001334B File Offset: 0x0001154B
		public void SavePlayerName(Record r)
		{
			r.IntField[FI.playernames_nameid] = base.Id;
			r.CompressedString[FI.playernames_name] = this.Text;
			r.IntField[FI.playernames_commentaryid] = this.m_CommentaryId;
		}

		// Token: 0x0400013D RID: 317
		private string m_Text;

		// Token: 0x0400013E RID: 318
		private bool m_IsUsed;

		// Token: 0x0400013F RID: 319
		private int m_CommentaryId;
	}
}
