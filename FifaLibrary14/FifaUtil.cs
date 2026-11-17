using System;
using System.IO;
using System.Text;

namespace FifaLibrary
{
	// Token: 0x0200003E RID: 62
	public class FifaUtil
	{
		// Token: 0x060005E6 RID: 1510 RVA: 0x000227CC File Offset: 0x000209CC
		public static short SwapEndian(short x)
		{
			byte b = (byte)(x & 255);
			byte b2 = (byte)(((int)x & 65280) >> 8);
			return (short)((int)b2 + (int)b * 256);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000227FC File Offset: 0x000209FC
		public static ushort SwapEndian(ushort x)
		{
			byte b = (byte)(x & 255);
			byte b2 = (byte)((x & 65280) >> 8);
			return (ushort)((int)b2 + (int)b * 256);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0002282C File Offset: 0x00020A2C
		public static int SwapEndian(int x)
		{
			int num = x & 255;
			x >>= 8;
			num = num * 256 + (x & 255);
			x >>= 8;
			num = num * 256 + (x & 255);
			x >>= 8;
			return num * 256 + (x & 255);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00022884 File Offset: 0x00020A84
		public static uint SwapEndian(uint x)
		{
			uint num = x & 255U;
			x >>= 8;
			num = num * 256U + (x & 255U);
			x >>= 8;
			num = num * 256U + (x & 255U);
			x >>= 8;
			return num * 256U + (x & 255U);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000228DC File Offset: 0x00020ADC
		public static long SwapEndian(long x)
		{
			long num = x & 255L;
			x >>= 8;
			num = num * 256L + (x & 255L);
			x >>= 8;
			num = num * 256L + (x & 255L);
			x >>= 8;
			num = num * 256L + (x & 255L);
			x >>= 8;
			num = num * 256L + (x & 255L);
			x >>= 8;
			num = num * 256L + (x & 255L);
			x >>= 8;
			num = num * 256L + (x & 255L);
			x >>= 8;
			return num * 256L + (x & 255L);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00022998 File Offset: 0x00020B98
		public static ulong SwapEndian(ulong x)
		{
			ulong num = x & 255UL;
			x >>= 8;
			num = num * 256UL + (x & 255UL);
			x >>= 8;
			num = num * 256UL + (x & 255UL);
			x >>= 8;
			num = num * 256UL + (x & 255UL);
			x >>= 8;
			num = num * 256UL + (x & 255UL);
			x >>= 8;
			num = num * 256UL + (x & 255UL);
			x >>= 8;
			num = num * 256UL + (x & 255UL);
			x >>= 8;
			return num * 256UL + (x & 255UL);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00022A54 File Offset: 0x00020C54
		public static string ReadNullTerminatedString(BinaryReader r)
		{
			char[] array = new char[256];
			int num = 0;
			byte b;
			while ((b = r.ReadByte()) != 0 && r.PeekChar() != -1)
			{
				array[num] = (char)b;
				num++;
				if (num == 256)
				{
					return null;
				}
			}
			return new string(array, 0, num);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00022AA0 File Offset: 0x00020CA0
		public static string ReadNullTerminatedByteArray(BinaryReader r, int length)
		{
			char[] array = new char[length];
			int num = 0;
			for (int i = 0; i < length; i++)
			{
				if (r.PeekChar() == -1)
				{
					num = i;
					break;
				}
				byte b;
				if ((b = r.ReadByte()) == 0 && num == 0)
				{
					num = i;
				}
				array[i] = (char)b;
			}
			return new string(array, 0, num);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00022AEC File Offset: 0x00020CEC
		public static string ReadNullTerminatedString(BinaryReader r, int padding)
		{
			string text = FifaUtil.ReadNullTerminatedString(r);
			int num = (text.Length + 1) % padding;
			if (num != 0)
			{
				r.ReadBytes(padding - num);
			}
			return text;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00022B1C File Offset: 0x00020D1C
		public static string ReadNullPaddedString(BinaryReader r, int length)
		{
			byte[] array = r.ReadBytes(length);
			int num = 0;
			while (num < length && array[num] != 0)
			{
				num++;
			}
			if (num == 0)
			{
				return string.Empty;
			}
			return FifaUtil.ue.GetString(array, 0, num);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00022B5C File Offset: 0x00020D5C
		public static void WriteNullPaddedString(BinaryWriter w, string str, int length)
		{
			if (str == null)
			{
				str = string.Empty;
			}
			byte[] bytes = FifaUtil.ue.GetBytes(str);
			if (bytes.Length > length)
			{
				w.Write(bytes, 0, length);
				return;
			}
			w.Write(bytes);
			for (int i = bytes.Length; i < length; i++)
			{
				w.Write((byte)0);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00022BAC File Offset: 0x00020DAC
		public static int ComputeAlignement(int v)
		{
			int num = 1;
			if (v == 0)
			{
				return 1;
			}
			for (int i = 0; i < 31; i++)
			{
				if ((v & num) != 0)
				{
					return (num + 1) / 2;
				}
				num = num * 2 + 1;
			}
			return 0;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00022BE0 File Offset: 0x00020DE0
		public static void WriteNullTerminatedString(BinaryWriter w, string s)
		{
			char[] array = s.ToCharArray(0, s.Length);
			for (int i = 0; i < array.Length; i++)
			{
				w.Write((byte)array[i]);
			}
			w.Write(0);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00022C1C File Offset: 0x00020E1C
		public static void WriteNullTerminatedByteArray(BinaryWriter w, string s, int nBytes)
		{
			char[] array = s.ToCharArray(0, s.Length);
			for (int i = 0; i < nBytes; i++)
			{
				if (i < array.Length)
				{
					w.Write((byte)array[i]);
				}
				else
				{
					w.Write(0);
				}
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00022C5C File Offset: 0x00020E5C
		public static int ComputeHash(string fileName)
		{
			int num = 4700322;
			char[] array = fileName.ToCharArray(0, fileName.Length);
			int num2 = array.Length;
			for (int i = 0; i < num2; i++)
			{
				num += (int)array[i];
				num *= 33;
			}
			return num;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00022C9C File Offset: 0x00020E9C
		public static int ComputeBucket(int hash, string extension)
		{
			extension.ToLower();
			int num;
			if (extension.Equals(".fsh"))
			{
				num = 0;
			}
			else if (extension.Equals(".jdi"))
			{
				num = 32;
			}
			else if (extension.Equals(".ini"))
			{
				num = 32;
			}
			else if (extension.Equals(".tvb"))
			{
				num = 64;
			}
			else if (extension.Equals(".irr"))
			{
				num = 64;
			}
			else if (extension.Equals(".loc"))
			{
				num = 96;
			}
			else if (extension.Equals(".cs"))
			{
				num = 96;
			}
			else if (extension.Equals(".shd"))
			{
				num = 128;
			}
			else if (extension.Equals(".txt"))
			{
				num = 128;
			}
			else if (extension.Equals(".dat"))
			{
				num = 128;
			}
			else if (extension.Equals(".hud"))
			{
				num = 128;
			}
			else if (extension.Equals(".ttf"))
			{
				num = 192;
			}
			else if (extension.Equals(".bin"))
			{
				num = 192;
			}
			else if (extension.Equals(".skn"))
			{
				num = 192;
			}
			else if (extension.Equals(".o"))
			{
				num = 224;
			}
			else if (extension.Equals(".big"))
			{
				num = 224;
			}
			else
			{
				if (!extension.Equals(".ebo"))
				{
					return 0;
				}
				num = 224;
			}
			return ((33 * hash + num) % 256) & 255;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00022E38 File Offset: 0x00021038
		public static ulong ComputeBhHash(byte[] name, int length)
		{
			ulong num = 5381UL;
			for (int i = 0; i < length; i++)
			{
				int num2 = (int)name[i];
				num = (num << 5) + num + (ulong)num2;
			}
			return num;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00022E68 File Offset: 0x00021068
		public static ulong ComputeBhHash(string name)
		{
			ulong num = 5381UL;
			foreach (int num2 in name)
			{
				num = (num << 5) + num + (ulong)num2;
			}
			return num;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00022EA0 File Offset: 0x000210A0
		public static int ComputeCrcDb11(byte[] bytes)
		{
			int num = -1;
			uint num2 = 0U;
			while ((ulong)num2 < (ulong)((long)bytes.Length))
			{
				int num3 = 7;
				num ^= (int)bytes[(int)((UIntPtr)num2)] << 24;
				do
				{
					if (num >= 0)
					{
						num *= 2;
					}
					else
					{
						num *= 2;
						num ^= 79764919;
					}
					num3--;
				}
				while (num3 >= 0);
				num2 += 1U;
			}
			return num;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00022EEA File Offset: 0x000210EA
		public static int ComputeCrcDb11(string text)
		{
			return FifaUtil.ComputeCrcDb11(FifaUtil.ue.GetBytes(text));
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00022EFC File Offset: 0x000210FC
		public static uint ComputeLanguageHash(string name)
		{
			byte[] bytes = FifaUtil.ue.GetBytes(name);
			return FifaUtil.EAHash(bytes, bytes.Length);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00022F20 File Offset: 0x00021120
		public static bool TryAllaCrc32(byte[] bytes, uint expected)
		{
			int num = bytes.Length;
			uint num2 = FifaUtil.SwapEndian(expected);
			uint num3 = FifaUtil.sdbm(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.RSHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.JSHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.PJWHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.ELFHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.BKDRHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.SDBMHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.DJBHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.DEKHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.BPHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.FNVHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.APHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.adler32(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.fletcher32(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = FifaUtil.jenkins_one_at_a_time_hash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = (uint)FifaUtil.ComputeBhHash(bytes, num);
			if (num3 == expected || num3 == num2)
			{
				return true;
			}
			num3 = (uint)FifaUtil.ComputeCrcDb11(bytes);
			return num3 == expected || num3 == num2;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0002306C File Offset: 0x0002126C
		private static uint sdbm(byte[] str, int length)
		{
			uint num = 0U;
			for (int i = 0; i < length; i++)
			{
				uint num2 = (uint)str[i];
				uint num3 = num << 6;
				num3 += num << 16;
				num3 -= num;
				num = num2 + num3;
			}
			return num;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000230A0 File Offset: 0x000212A0
		private static uint fletcher32(byte[] str, int len)
		{
			uint num = 0U;
			uint num2 = 0U;
			for (int i = 0; i < len; i++)
			{
				num += (uint)str[i];
				if (num >= 65535U)
				{
					num -= 65535U;
				}
				num2 += num;
				if (num2 >= 65535U)
				{
					num2 -= 65535U;
				}
			}
			return (num2 << 16) | num;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000230F0 File Offset: 0x000212F0
		private static uint EAHash(byte[] str, int length)
		{
			uint num = 0U;
			for (int i = 0; i < length; i++)
			{
				uint num2 = (uint)str[i];
				num2 &= 223U;
				num2 ^= num;
				num2 &= 255U;
				num >>= 8;
				num ^= FifaUtil.c_LanguageHashtable[(int)((UIntPtr)num2)];
			}
			return num ^ 2147483648U;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0002313C File Offset: 0x0002133C
		private static uint RSHash(byte[] str, int length)
		{
			uint num = 378551U;
			uint num2 = 63689U;
			uint num3 = 0U;
			for (int i = 0; i < length; i++)
			{
				num3 = num3 * num2 + (uint)str[i];
				num2 *= num;
			}
			return num3;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00023170 File Offset: 0x00021370
		private static uint JSHash(byte[] str, int length)
		{
			uint num = 1315423911U;
			for (int i = 0; i < length; i++)
			{
				num ^= (num << 5) + (uint)str[i] + (num >> 2);
			}
			return num;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x000231A0 File Offset: 0x000213A0
		private static uint PJWHash(byte[] str, int length)
		{
			uint num = 32U;
			uint num2 = num * 3U / 4U;
			uint num3 = num / 8U;
			uint num4 = uint.MaxValue << (int)(num - num3);
			uint num5 = 0U;
			for (int i = 0; i < length; i++)
			{
				num5 = (num5 << (int)num3) + (uint)str[i];
				uint num6;
				if ((num6 = num5 & num4) != 0U)
				{
					num5 = (num5 ^ (num6 >> (int)num2)) & ~num4;
				}
			}
			return num5;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00023204 File Offset: 0x00021404
		private static uint ELFHash(byte[] str, int length)
		{
			uint num = 0U;
			for (int i = 0; i < length; i++)
			{
				num = (num << 4) + (uint)str[i];
				uint num2;
				if ((num2 = num & 4026531840U) != 0U)
				{
					num ^= num2 >> 24;
				}
				num &= ~num2;
			}
			return num;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00023244 File Offset: 0x00021444
		private static uint BKDRHash(byte[] str, int length)
		{
			uint num = 131U;
			uint num2 = 0U;
			for (int i = 0; i < length; i++)
			{
				num2 = num2 * num + (uint)str[i];
			}
			return num2;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00023270 File Offset: 0x00021470
		private static uint SDBMHash(byte[] str, int length)
		{
			uint num = 0U;
			for (int i = 0; i < length; i++)
			{
				num = (uint)str[i] + (num << 6) + (num << 16) - num;
			}
			return num;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0002329C File Offset: 0x0002149C
		private static uint DJBHash(byte[] str, int length)
		{
			uint num = 5381U;
			for (int i = 0; i < length; i++)
			{
				num = (num << 5) + num + (uint)str[i];
			}
			return num;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000232C8 File Offset: 0x000214C8
		private static uint DEKHash(byte[] str, int length)
		{
			uint num = (uint)length;
			for (int i = 0; i < length; i++)
			{
				num = (num << 5) ^ (num >> 27) ^ (uint)str[i];
			}
			return num;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000232F4 File Offset: 0x000214F4
		private static uint BPHash(byte[] str, int length)
		{
			uint num = 0U;
			for (int i = 0; i < length; i++)
			{
				num = (num << 7) ^ (uint)str[i];
			}
			return num;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00023318 File Offset: 0x00021518
		private static uint FNVHash(byte[] str, int length)
		{
			uint num = 2166136261U;
			for (int i = 0; i < length; i++)
			{
				byte b = str[i];
				if (b >= 65 && b <= 90)
				{
					b += 32;
				}
				num ^= (uint)b;
				num *= 16777619U;
			}
			return num;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0002335C File Offset: 0x0002155C
		private static uint APHash(byte[] str, int length)
		{
			uint num = 2863311530U;
			for (int i = 0; i < length; i++)
			{
				num ^= (((i & 1) == 0) ? ((num << 7) ^ ((uint)str[i] * (num >> 3))) : (~((num << 11) + ((uint)str[i] ^ (num >> 5)))));
			}
			return num;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x000233A0 File Offset: 0x000215A0
		private static uint adler32(byte[] str, int length)
		{
			ulong num = 1UL;
			ulong num2 = 0UL;
			for (int i = 0; i < length; i++)
			{
				num = (num + (ulong)str[i]) % 65521UL;
				num2 = (num2 + num) % 65521UL;
			}
			return (uint)((num2 << 16) | num);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000233E0 File Offset: 0x000215E0
		private static uint jenkins_one_at_a_time_hash(byte[] str, int length)
		{
			uint num2;
			uint num = (num2 = 0U);
			while ((ulong)num < (ulong)((long)length))
			{
				num2 += (uint)str[(int)((UIntPtr)num)];
				num2 += num2 << 10;
				num2 ^= num2 >> 6;
				num += 1U;
			}
			num2 += num2 << 3;
			num2 ^= num2 >> 11;
			return num2 + (num2 << 15);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00023428 File Offset: 0x00021628
		private static uint MurmurHash2(byte[] str, int length)
		{
			uint num = (uint)length;
			int num2 = 0;
			while (length >= 4)
			{
				uint num3 = (uint)str[num2];
				num3 = num3 * 256U + (uint)str[num2 + 1];
				num3 = num3 * 256U + (uint)str[num2 + 2];
				num3 = num3 * 256U + (uint)str[num2 + 3];
				num3 *= 1540483477U;
				num3 ^= num3 >> 24;
				num3 *= 1540483477U;
				num *= 1540483477U;
				num ^= num3;
				num2 += 4;
				length -= 4;
			}
			if (length == 3)
			{
				num ^= (uint)((uint)str[num2 + 2] << 16);
			}
			if (length >= 2)
			{
				num ^= (uint)((uint)str[num2 + 1] << 8);
			}
			num ^= (uint)str[num2];
			num *= 1540483477U;
			num ^= num >> 13;
			num *= 1540483477U;
			return num ^ (num >> 15);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000234DC File Offset: 0x000216DC
		public static string ReadString(BinaryReader r, int offset)
		{
			long position = r.BaseStream.Position;
			r.BaseStream.Position = (long)offset;
			int num = (int)r.ReadInt16();
			string @string = FifaUtil.ue.GetString(r.ReadBytes(num));
			r.BaseStream.Position = position;
			return @string;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00023528 File Offset: 0x00021728
		public static string ConvertBytesToString(byte[] bytes)
		{
			return FifaUtil.ue.GetString(bytes);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00023535 File Offset: 0x00021735
		public static byte[] ConvertStringToBytes(string str)
		{
			return FifaUtil.ue.GetBytes(str);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00023544 File Offset: 0x00021744
		public static string ReadString(BinaryReader r, long offset, int length)
		{
			long position = r.BaseStream.Position;
			r.BaseStream.Position = offset;
			string @string = FifaUtil.ue.GetString(r.ReadBytes(length));
			r.BaseStream.Position = position;
			return @string;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00023588 File Offset: 0x00021788
		public static int WriteString(BinaryWriter w, int offset, string s)
		{
			long position = w.BaseStream.Position;
			w.BaseStream.Position = (long)offset;
			if (s == null)
			{
				s = " ";
			}
			short num = (short)FifaUtil.ue.GetByteCount(s);
			int num2 = (int)(num + 2);
			w.Write(num);
			w.Write(FifaUtil.ue.GetBytes(s));
			if ((num2 & 3) != 0)
			{
				int num3 = 4 - (num2 & 3);
				for (int i = 0; i < num3; i++)
				{
					w.Write(0);
				}
			}
			int num4 = (int)w.BaseStream.Position;
			w.BaseStream.Position = position;
			return num4;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00023620 File Offset: 0x00021820
		public static int StringSize(string s)
		{
			int num = (int)((short)FifaUtil.ue.GetByteCount(s));
			return FifaUtil.RoundUp4(num + 2);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00023644 File Offset: 0x00021844
		public static int ComputeBitUsed(uint range)
		{
			if (range == 0U)
			{
				return 1;
			}
			for (int i = 32; i > 0; i--)
			{
				uint num = 1U << i - 1;
				if ((range & num) != 0U)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00023674 File Offset: 0x00021874
		public static int RoundUp4(int v)
		{
			return (v + 3) & -4;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0002367C File Offset: 0x0002187C
		public static int RoundUp(int v, int align)
		{
			return (v + (align - 1)) & ~(align - 1);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00023688 File Offset: 0x00021888
		public static long RoundUp(long v, int align)
		{
			return (v + (long)(align - 1)) & (long)(~(long)(align - 1));
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00023698 File Offset: 0x00021898
		public static bool CompareWildcardString(string pattern, string target)
		{
			int num = 0;
			int num2 = 0;
			pattern = pattern.ToLower();
			target = target.ToLower();
			int num3 = 0;
			while (num3 < target.Length && num < pattern.Length)
			{
				char c = pattern[num];
				if (c <= '/')
				{
					if (c != '*')
					{
						if (c != '/')
						{
							goto IL_009F;
						}
						goto IL_0060;
					}
					else
					{
						if (num == pattern.Length - 1)
						{
							return true;
						}
						num++;
						num2 = 1;
					}
				}
				else if (c != '?')
				{
					if (c != '\\')
					{
						goto IL_009F;
					}
					goto IL_0060;
				}
				else
				{
					num++;
				}
				IL_00D0:
				num3++;
				continue;
				IL_0060:
				if (num2 == 0)
				{
					if ('\\' != target[num3] && '/' != target[num3])
					{
						return false;
					}
					num++;
					goto IL_00D0;
				}
				else
				{
					if ('\\' == target[num3] || '/' == target[num3])
					{
						num2 = 0;
						num++;
						goto IL_00D0;
					}
					goto IL_00D0;
				}
				IL_009F:
				if (num2 == 0)
				{
					if (pattern[num] != target[num3])
					{
						return false;
					}
					num++;
					goto IL_00D0;
				}
				else
				{
					if (pattern[num] == target[num3])
					{
						num2 = 0;
						num++;
						goto IL_00D0;
					}
					goto IL_00D0;
				}
			}
			return num3 == target.Length && num == pattern.Length;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000237A4 File Offset: 0x000219A4
		public static DateTime ConvertToDate(int gregorian)
		{
			DateTime dateTime = new DateTime(1582, 10, 14, 12, 0, 0);
			if (gregorian < 0)
			{
				return dateTime;
			}
			return dateTime.AddDays((double)gregorian);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000237D4 File Offset: 0x000219D4
		public static int ConvertFromDate(DateTime date)
		{
			DateTime dateTime = new DateTime(1582, 10, 14, 0, 0, 0);
			return (date - dateTime).Days;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00023804 File Offset: 0x00021A04
		public static string PadBlanks(string s, int len)
		{
			if (len > s.Length)
			{
				int num = len - s.Length;
				for (int i = 0; i < num; i++)
				{
					s = " " + s;
				}
			}
			return s;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0002383D File Offset: 0x00021A3D
		public static int Limit(int val, int min, int max)
		{
			if (val < min)
			{
				return min;
			}
			if (val > max)
			{
				return max;
			}
			return val;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0002384C File Offset: 0x00021A4C
		public static float ConvertToFloat(short float16Bit)
		{
			int num = ((((int)float16Bit & 32768) == 0) ? 1 : (-1));
			int num2 = (float16Bit & 31744) >> 10;
			int num3 = (int)((float16Bit & 1023) + 1024);
			if (num2 == 0 && num3 == 0)
			{
				return 0f;
			}
			if (num2 == 31)
			{
				return float.NaN;
			}
			num2 -= 15;
			float num4 = (float)Math.Pow(2.0, (double)num2);
			return (float)(num * num3) / 1024f * num4;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000238C0 File Offset: 0x00021AC0
		public static ushort ConvertFloat16ToShort(float f)
		{
			if (f == 0f)
			{
				return 0;
			}
			int num = 1;
			if (f < 0f)
			{
				f = -f;
				num = -1;
			}
			float num2 = f * 32768f;
			int num3 = 0;
			while ((double)num2 >= 2.0)
			{
				num2 /= 2f;
				num3++;
			}
			ushort num4 = 0;
			if (num < 0)
			{
				num4 = 32768;
			}
			if (num3 > 31)
			{
				num3 = 31;
			}
			num4 = (ushort)((int)num4 | (num3 << 10));
			ushort num5;
			if (num2 >= 1f)
			{
				num5 = Convert.ToUInt16((double)(num2 - 1f) * 1024.0);
			}
			else
			{
				num5 = 1;
			}
			return (ushort)(num4 | num5);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00023958 File Offset: 0x00021B58
		public static float SwapAndConvertToFloat(BinaryReader r)
		{
			byte[] array = new byte[]
			{
				0,
				0,
				0,
				r.ReadByte()
			};
			array[2] = r.ReadByte();
			array[1] = r.ReadByte();
			array[0] = r.ReadByte();
			MemoryStream memoryStream = new MemoryStream(array);
			BinaryReader binaryReader = new BinaryReader(memoryStream);
			float num = binaryReader.ReadSingle();
			memoryStream.Close();
			return num;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000239AC File Offset: 0x00021BAC
		public static void SwapAndWriteFloat(BinaryWriter w, float f)
		{
			byte[] array = new byte[4];
			MemoryStream memoryStream = new MemoryStream(array);
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			binaryWriter.Write(f);
			memoryStream.Close();
			w.Write(array[3]);
			w.Write(array[2]);
			w.Write(array[1]);
			w.Write(array[0]);
		}

		// Token: 0x0400026F RID: 623
		private static uint[] c_LanguageHashtable = new uint[]
		{
			0U, 1996959894U, 3993919788U, 2567524794U, 124634137U, 1886057615U, 3915621685U, 2657392035U, 249268274U, 2044508324U,
			3772115230U, 2547177864U, 162941995U, 2125561021U, 3887607047U, 2428444049U, 498536548U, 1789927666U, 4089016648U, 2227061214U,
			450548861U, 1843258603U, 4107580753U, 2211677639U, 325883990U, 1684777152U, 4251122042U, 2321926636U, 335633487U, 1661365465U,
			4195302755U, 2366115317U, 997073096U, 1281953886U, 3579855332U, 2724688242U, 1006888145U, 1258607687U, 3524101629U, 2768942443U,
			901097722U, 1119000684U, 3686517206U, 2898065728U, 853044451U, 1172266101U, 3705015759U, 2882616665U, 651767980U, 1373503546U,
			3369554304U, 3218104598U, 565507253U, 1454621731U, 3485111705U, 3099436303U, 671266974U, 1594198024U, 3322730930U, 2970347812U,
			795835527U, 1483230225U, 3244367275U, 3060149565U, 1994146192U, 31158534U, 2563907772U, 4023717930U, 1907459465U, 112637215U,
			2680153253U, 3904427059U, 2013776290U, 251722036U, 2517215374U, 3775830040U, 2137656763U, 141376813U, 2439277719U, 3865271297U,
			1802195444U, 476864866U, 2238001368U, 4066508878U, 1812370925U, 453092731U, 2181625025U, 4111451223U, 1706088902U, 314042704U,
			2344532202U, 4240017532U, 1658658271U, 366619977U, 2362670323U, 4224994405U, 1303535960U, 984961486U, 2747007092U, 3569037538U,
			1256170817U, 1037604311U, 2765210733U, 3554079995U, 1131014506U, 879679996U, 2909243462U, 3663771856U, 1141124467U, 855842277U,
			2852801631U, 3708648649U, 1342533948U, 654459306U, 3188396048U, 3373015174U, 1466479909U, 544179635U, 3110523913U, 3462522015U,
			1591671054U, 702138776U, 2966460450U, 3352799412U, 1504918807U, 783551873U, 3082640443U, 3233442989U, 3988292384U, 2596254646U,
			62317068U, 1957810842U, 3939845945U, 2647816111U, 81470997U, 1943803523U, 3814918930U, 2489596804U, 225274430U, 2053790376U,
			3826175755U, 2466906013U, 167816743U, 2097651377U, 4027552580U, 2265490386U, 503444072U, 1762050814U, 4150417245U, 2154129355U,
			426522225U, 1852507879U, 4275313526U, 2312317920U, 282753626U, 1742555852U, 4189708143U, 2394877945U, 397917763U, 1622183637U,
			3604390888U, 2714866558U, 953729732U, 1340076626U, 3518719985U, 2797360999U, 1068828381U, 1219638859U, 3624741850U, 2936675148U,
			906185462U, 1090812512U, 3747672003U, 2825379669U, 829329135U, 1181335161U, 3412177804U, 3160834842U, 628085408U, 1382605366U,
			3423369109U, 3138078467U, 570562233U, 1426400815U, 3317316542U, 2998733608U, 733239954U, 1555261956U, 3268935591U, 3050360625U,
			752459403U, 1541320221U, 2607071920U, 3965973030U, 1969922972U, 40735498U, 2617837225U, 3943577151U, 1913087877U, 83908371U,
			2512341634U, 3803740692U, 2075208622U, 213261112U, 2463272603U, 3855990285U, 2094854071U, 198958881U, 2262029012U, 4057260610U,
			1759359992U, 534414190U, 2176718541U, 4139329115U, 1873836001U, 414664567U, 2282248934U, 4279200368U, 1711684554U, 285281116U,
			2405801727U, 4167216745U, 1634467795U, 376229701U, 2685067896U, 3608007406U, 1308918612U, 956543938U, 2808555105U, 3495958263U,
			1231636301U, 1047427035U, 2932959818U, 3654703836U, 1088359270U, 936918000U, 2847714899U, 3736837829U, 1202900863U, 817233897U,
			3183342108U, 3401237130U, 1404277552U, 615818150U, 3134207493U, 3453421203U, 1423857449U, 601450431U, 3009837614U, 3294710456U,
			1567103746U, 711928724U, 3020668471U, 3272380065U, 1510334235U, 755167117U
		};

		// Token: 0x04000270 RID: 624
		private static UTF8Encoding ue = new UTF8Encoding();
	}
}
