using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200005B RID: 91
	public class DbReader : BinaryReader
	{
		// Token: 0x060007DB RID: 2011 RVA: 0x0002FB6F File Offset: 0x0002DD6F
		public DbReader(Stream stream, FifaPlatform platform)
			: base(stream)
		{
			this.m_Platform = platform;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0002FB7F File Offset: 0x0002DD7F
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x0002FB87 File Offset: 0x0002DD87
		public FifaPlatform Platform
		{
			get
			{
				return this.m_Platform;
			}
			set
			{
				this.m_Platform = value;
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0002FB90 File Offset: 0x0002DD90
		public override short ReadInt16()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(2);
				Array.Reverse(array);
				return BitConverter.ToInt16(array, 0);
			}
			return base.ReadInt16();
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0002FBC4 File Offset: 0x0002DDC4
		public override ushort ReadUInt16()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(2);
				Array.Reverse(array);
				return BitConverter.ToUInt16(array, 0);
			}
			return base.ReadUInt16();
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0002FBF8 File Offset: 0x0002DDF8
		public override int ReadInt32()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(4);
				Array.Reverse(array);
				return BitConverter.ToInt32(array, 0);
			}
			return base.ReadInt32();
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0002FC2C File Offset: 0x0002DE2C
		public override uint ReadUInt32()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(4);
				Array.Reverse(array);
				return BitConverter.ToUInt32(array, 0);
			}
			return base.ReadUInt32();
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0002FC60 File Offset: 0x0002DE60
		public override long ReadInt64()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(8);
				Array.Reverse(array);
				return BitConverter.ToInt64(array, 0);
			}
			return base.ReadInt64();
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0002FC94 File Offset: 0x0002DE94
		public override ulong ReadUInt64()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(8);
				Array.Reverse(array);
				return BitConverter.ToUInt64(array, 0);
			}
			return base.ReadUInt64();
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0002FCC8 File Offset: 0x0002DEC8
		public override float ReadSingle()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(4);
				Array.Reverse(array);
				return BitConverter.ToSingle(array, 0);
			}
			return base.ReadSingle();
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0002FCFC File Offset: 0x0002DEFC
		public override double ReadDouble()
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] array = base.ReadBytes(8);
				Array.Reverse(array);
				return BitConverter.ToDouble(array, 0);
			}
			return base.ReadDouble();
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0002FD2E File Offset: 0x0002DF2E
		public int PopInteger(FieldDescriptor fieldDescriptor)
		{
			if (this.m_Platform == FifaPlatform.PC)
			{
				return this.PopIntegerPc(fieldDescriptor);
			}
			return this.PopIntegerXbox(fieldDescriptor);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0002FD48 File Offset: 0x0002DF48
		private int PopIntegerXbox(FieldDescriptor fieldDescriptor)
		{
			int num = (int)this.ReadByte();
			int num2 = fieldDescriptor.BitOffset % 8;
			int num3 = 0;
			for (int i = fieldDescriptor.Depth - 1; i >= 0; i--)
			{
				int num4 = (((num & (128 >> num2)) == 0) ? 0 : 1);
				num3 += num4 << i;
				num2++;
				if (num2 == 8)
				{
					num = (int)this.ReadByte();
					num2 = 0;
				}
			}
			return num3 + fieldDescriptor.RangeLow;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0002FDB4 File Offset: 0x0002DFB4
		private int PopIntegerPc(FieldDescriptor fieldDescriptor)
		{
			int num = 0;
			int depth = fieldDescriptor.Depth;
			int i = 0;
			if (this.m_CurrentBitPosition != 0)
			{
				i = 8 - this.m_CurrentBitPosition;
				num = this.m_CurrentByte >> this.m_CurrentBitPosition;
			}
			while (i < depth)
			{
				this.m_CurrentByte = (int)this.ReadByte();
				num += this.m_CurrentByte << i;
				i += 8;
			}
			this.m_CurrentBitPosition = (depth + 8 - i) & 7;
			int num2 = (int)((1L << depth) - 1L);
			num &= num2;
			return num + fieldDescriptor.RangeLow;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0002FE39 File Offset: 0x0002E039
		public void Align(long position)
		{
			this.BaseStream.Position = position;
			this.m_CurrentBitPosition = 0;
			this.m_CurrentByte = 0;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0002FE55 File Offset: 0x0002E055
		public void AlignToByte()
		{
			if (this.m_CurrentBitPosition != 0)
			{
				this.m_CurrentBitPosition = 0;
				this.m_CurrentByte = 0;
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0002FE70 File Offset: 0x0002E070
		public void AlignTo32Bit()
		{
			int num = (int)(this.BaseStream.Position & 3L);
			if (num != 0)
			{
				this.BaseStream.Position += (long)(4 - num);
			}
			this.m_CurrentBitPosition = 0;
		}

		// Token: 0x0400033E RID: 830
		private int m_CurrentByte;

		// Token: 0x0400033F RID: 831
		private int m_CurrentBitPosition;

		// Token: 0x04000340 RID: 832
		private FifaPlatform m_Platform;
	}
}
