using System;
using Microsoft.Win32;

namespace FifaLibrary
{
	// Token: 0x02000016 RID: 22
	public class RegistryInfo
	{
		// Token: 0x0600016D RID: 365 RVA: 0x0000DF08 File Offset: 0x0000C108
		private static string GetString(string year, string key)
		{
			string text = null;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(year);
			if (registryKey != null)
			{
				text = (string)registryKey.GetValue(key);
				if (text.EndsWith("\\"))
				{
					text = text.Substring(0, text.Length - 1);
				}
				registryKey.Close();
			}
			return text;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000DF58 File Offset: 0x0000C158
		public static string GetLatestFifaInstalled()
		{
			for (int i = 20; i >= 10; i--)
			{
				string text = "SOFTWARE\\EA SPORTS\\FIFA " + i.ToString();
				if (RegistryInfo.GetString(text, "Install Dir") != null)
				{
					return text;
				}
				text = "SOFTWARE\\Wow6432Node\\EA SPORTS\\FIFA " + i.ToString();
				if (RegistryInfo.GetString(text, "Install Dir") != null)
				{
					return text;
				}
			}
			return null;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		public static string[] GetAllFifaInstalled()
		{
			int num = 0;
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\EA SPORTS");
			string[] subKeyNames = registryKey.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				if (!subKeyNames[i].StartsWith("FIFA"))
				{
					subKeyNames[i] = null;
				}
				else
				{
					num++;
				}
			}
			if (num == 0)
			{
				return null;
			}
			string[] array = new string[num];
			num = 0;
			for (int j = 0; j < subKeyNames.Length; j++)
			{
				if (subKeyNames[j] != null)
				{
					array[num++] = subKeyNames[j];
				}
			}
			return array;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000E03A File Offset: 0x0000C23A
		public static string GetFifaKey(int year)
		{
			return "SOFTWARE\\EA SPORTS\\FIFA " + year.ToString();
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000E04D File Offset: 0x0000C24D
		public static bool IsFifaInstalled(string game)
		{
			return RegistryInfo.GetString(game, "Install Dir") != null;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000E060 File Offset: 0x0000C260
		public static string GetInstallDir(string game)
		{
			string text = RegistryInfo.GetString(game, "Install Dir");
			if (text != null && text.EndsWith("\\"))
			{
				text = text.Substring(0, text.Length - 1);
			}
			return text;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000E09C File Offset: 0x0000C29C
		public static string GetDbFilename(string game)
		{
			string @string = RegistryInfo.GetString(game, "Install Dir");
			return @string + "\\Game\\data\\db\\fifa_ng_db.db";
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
		public static string GetDbXmlFilename(string game)
		{
			string @string = RegistryInfo.GetString(game, "Install Dir");
			return @string + "\\Game\\data\\db\\fifa_ng_db-meta.xml";
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000E0EC File Offset: 0x0000C2EC
		public static string GetLanguageDbFilename(string game)
		{
			string text = RegistryInfo.GetString(game, "Install Dir");
			string @string = RegistryInfo.GetString(game, "Locale");
			text += "\\Game\\data\\loc\\";
			return text + RegistryInfo.ConvertLanguageToFileName(@string) + ".db";
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000E130 File Offset: 0x0000C330
		public static string GetLanguageXmlFilename(string game)
		{
			string text = RegistryInfo.GetString(game, "Install Dir");
			string @string = RegistryInfo.GetString(game, "Locale");
			text += "\\Game\\data\\loc\\";
			return text + RegistryInfo.ConvertLanguageToFileName(@string) + "-meta.xml";
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000E174 File Offset: 0x0000C374
		public static string GetEnglishFilename(string game)
		{
			string @string = RegistryInfo.GetString(game, "Install Dir");
			return @string + "\\data\\loc\\eng_us.db";
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000E19C File Offset: 0x0000C39C
		public static string GetEnglishXmlFilename(string game)
		{
			string @string = RegistryInfo.GetString(game, "Install Dir");
			return @string + "\\data\\loc\\eng_us-meta.xml";
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000E1C2 File Offset: 0x0000C3C2
		public static string GetFolder(string game)
		{
			return RegistryInfo.GetString(game, "Folder");
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000E1CF File Offset: 0x0000C3CF
		public static string GetLocale(string game)
		{
			return RegistryInfo.GetString(game, "Locale");
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000E1DC File Offset: 0x0000C3DC
		private static string ConvertLanguageToFileName(string locale)
		{
			string text = "eng_us";
			if (locale != null && locale != string.Empty)
			{
				if (locale.StartsWith("it"))
				{
					text = "ita_it";
				}
				else if (locale.StartsWith("sa"))
				{
					text = "ara_sa";
				}
				else if (locale.StartsWith("cz"))
				{
					text = "cze_cz";
				}
				else if (locale.StartsWith("dk"))
				{
					text = "dan_dk";
				}
				else if (locale.StartsWith("nl"))
				{
					text = "dut_nl";
				}
				else if (locale.StartsWith("en"))
				{
					text = "eng_us";
				}
				else if (locale.StartsWith("fr"))
				{
					text = "fre_fr";
				}
				else if (locale.StartsWith("de"))
				{
					text = "ger_de";
				}
				else if (locale.StartsWith("hu"))
				{
					text = "hun_hu";
				}
				else if (locale.StartsWith("jp"))
				{
					text = "jpn_jp";
				}
				else if (locale.StartsWith("kr"))
				{
					text = "kor_kr";
				}
				else if (locale.StartsWith("no"))
				{
					text = "nor_no";
				}
				else if (locale.StartsWith("pl"))
				{
					text = "pol_pl";
				}
				else if (locale.StartsWith("pt"))
				{
					text = "por_pt";
				}
				else if (locale.StartsWith("br"))
				{
					text = "por_br";
				}
				else if (locale.StartsWith("ru"))
				{
					text = "rus_ru";
				}
				else if (locale.StartsWith("es"))
				{
					text = "spa_es";
				}
				else if (locale.StartsWith("mx"))
				{
					text = "spa_mx";
				}
				else if (locale.StartsWith("se"))
				{
					text = "swe_se";
				}
				else
				{
					text = "eng_us";
				}
			}
			return text;
		}
	}
}
