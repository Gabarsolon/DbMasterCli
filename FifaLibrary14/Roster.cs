using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x020000B0 RID: 176
	public class Roster : ArrayList
	{
		// Token: 0x06000DE4 RID: 3556 RVA: 0x00054A9D File Offset: 0x00052C9D
		public Roster(int capacity)
		{
			this.Capacity = capacity;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00054AAC File Offset: 0x00052CAC
		public Player SearchPlayer(int playerid)
		{
			for (int i = 0; i < this.Count; i++)
			{
				if (playerid == ((TeamPlayer)this[i]).Player.Id)
				{
					return ((TeamPlayer)this[i]).Player;
				}
			}
			return null;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00054AF8 File Offset: 0x00052CF8
		public TeamPlayer SearchTeamPlayer(Player player)
		{
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				if (player == teamPlayer.Player)
				{
					return teamPlayer;
				}
			}
			return null;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00054B58 File Offset: 0x00052D58
		public int GetTeamPosition(Player player)
		{
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				if (player == teamPlayer.Player)
				{
					return teamPlayer.position;
				}
			}
			return 29;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00054BBC File Offset: 0x00052DBC
		public int GetTeamPosition(int playerId)
		{
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				if (playerId == teamPlayer.Player.Id)
				{
					return teamPlayer.position;
				}
			}
			return 29;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00054C24 File Offset: 0x00052E24
		public TeamPlayer SearchTeamPlayer(Role role)
		{
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				if (role.Id == teamPlayer.position)
				{
					return teamPlayer;
				}
			}
			return null;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00054C88 File Offset: 0x00052E88
		public TeamPlayer GetRoleBestPlayer(ERole requestedRole)
		{
			TeamPlayer teamPlayer = null;
			int num = -1;
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2 != null)
				{
					int rolePerformance = teamPlayer2.Player.GetRolePerformance(requestedRole);
					if (rolePerformance > num)
					{
						num = rolePerformance;
						teamPlayer = teamPlayer2;
					}
				}
			}
			return teamPlayer;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00054CFC File Offset: 0x00052EFC
		public TeamPlayer GetRoleBestTitolar(ERole requestedRole)
		{
			TeamPlayer teamPlayer = null;
			int num = -1;
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2 != null && teamPlayer2.position < 28)
				{
					int rolePerformance = teamPlayer2.Player.GetRolePerformance(requestedRole);
					if (rolePerformance > num)
					{
						num = rolePerformance;
						teamPlayer = teamPlayer2;
					}
				}
			}
			return teamPlayer;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00054D78 File Offset: 0x00052F78
		public TeamPlayer GetBestTitolar()
		{
			TeamPlayer teamPlayer = null;
			int num = -1;
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2 != null && teamPlayer2.position < 28)
				{
					int overallrating = teamPlayer2.Player.overallrating;
					if (overallrating > num)
					{
						num = overallrating;
						teamPlayer = teamPlayer2;
					}
				}
			}
			return teamPlayer;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00054DF4 File Offset: 0x00052FF4
		public TeamPlayer GetBestPlayer()
		{
			TeamPlayer teamPlayer = null;
			int num = -1;
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2 != null)
				{
					int averageRoleAttribute = teamPlayer2.Player.GetAverageRoleAttribute();
					if (averageRoleAttribute > num)
					{
						num = averageRoleAttribute;
						teamPlayer = teamPlayer2;
					}
				}
			}
			return teamPlayer;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00054E64 File Offset: 0x00053064
		public bool IsNumberFree(int n)
		{
			if (n < 1 || n > 99)
			{
				return false;
			}
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				if (teamPlayer.m_jerseynumber == n)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00054ECC File Offset: 0x000530CC
		public int GetFreeNumber()
		{
			for (int i = 1; i < 99; i++)
			{
				if (this.IsNumberFree(i))
				{
					return i;
				}
			}
			return 99;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00054EF4 File Offset: 0x000530F4
		public string[] GetFreeNumbers()
		{
			string[] array = new string[99];
			int num = 0;
			for (int i = 1; i < 100; i++)
			{
				if (this.IsNumberFree(i))
				{
					array[num] = i.ToString();
					num++;
				}
			}
			Array.Resize<string>(ref array, num);
			return array;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00054F38 File Offset: 0x00053138
		public void ChangeRole(Role oldRole, Role newRole)
		{
			TeamPlayer teamPlayer = this.SearchTeamPlayer(oldRole);
			if (teamPlayer != null)
			{
				teamPlayer.position = newRole.Id;
			}
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00054F5C File Offset: 0x0005315C
		public int EstimateOverall()
		{
			int[] array = new int[17];
			int num = 0;
			for (int i = 0; i < 16; i++)
			{
				array[i] = 0;
			}
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				int overallrating = teamPlayer.Player.overallrating;
				int j = 0;
				while (j < 16)
				{
					if (overallrating > array[j])
					{
						for (int k = num; k > j; k--)
						{
							array[k] = array[k - 1];
						}
						array[j] = overallrating;
						if (num < 16)
						{
							num++;
							break;
						}
						break;
					}
					else
					{
						j++;
					}
				}
			}
			int num2 = 0;
			for (int l = 0; l < num; l++)
			{
				num2 += array[l];
			}
			if (num != 0)
			{
				num2 /= num;
			}
			else
			{
				num2 = 50;
			}
			return num2;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0005504C File Offset: 0x0005324C
		public void ResetToEmpty()
		{
			foreach (object obj in this)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				teamPlayer.Player.NotPlayFor(teamPlayer.Team);
			}
			this.Clear();
		}
	}
}
