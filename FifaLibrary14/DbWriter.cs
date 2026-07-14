using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200005C RID: 92
	public class DbWriter : BinaryWriter
	{
		// Token: 0x060007EC RID: 2028 RVA: 0x0002FEAD File Offset: 0x0002E0AD
		public DbWriter(Stream stream, FifaPlatform platform)
			: base(stream)
		{
			this.m_Platform = platform;
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x0002FEBD File Offset: 0x0002E0BD
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x0002FEC5 File Offset: 0x0002E0C5
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

		// Token: 0x060007EF RID: 2031 RVA: 0x0002FED0 File Offset: 0x0002E0D0
		public override void Write(short value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0002FF04 File Offset: 0x0002E104
		public override void Write(ushort value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0002FF38 File Offset: 0x0002E138
		public override void Write(int value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0002FF6C File Offset: 0x0002E16C
		public override void Write(uint value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0002FFA0 File Offset: 0x0002E1A0
		public override void Write(long value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0002FFD4 File Offset: 0x0002E1D4
		public override void Write(ulong value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00030008 File Offset: 0x0002E208
		public override void Write(float value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0003003C File Offset: 0x0002E23C
		public override void Write(double value)
		{
			if (this.m_Platform == FifaPlatform.XBox)
			{
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				base.Write(bytes);
				return;
			}
			base.Write(value);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0003006E File Offset: 0x0002E26E
		public void PushInteger(int value, FieldDescriptor fieldDescriptor)
		{
			if (this.m_Platform == FifaPlatform.PC)
			{
				this.PushIntegerPc(value, fieldDescriptor);
				return;
			}
			this.PushIntegerXbox(value, fieldDescriptor);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0003008C File Offset: 0x0002E28C
		private void PushIntegerXbox(int value, FieldDescriptor fieldDescriptor)
		{
			BinaryReader binaryReader = new BinaryReader(this.BaseStream);
			int num = 0;
			if (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
			{
				num = (int)binaryReader.ReadByte();
				binaryReader.BaseStream.Position -= 1L;
			}
			int num2 = fieldDescriptor.BitOffset % 8;
			int num3 = value - fieldDescriptor.RangeLow;
			for (int i = fieldDescriptor.Depth - 1; i >= 0; i--)
			{
				int num4 = num3 & (1 << i);
				int num5 = 128 >> num2;
				if (num4 == 0)
				{
					num &= ~num5;
				}
				else
				{
					num |= num5;
				}
				num2++;
				if (num2 == 8)
				{
					byte b = (byte)num;
					this.Write(b);
					num2 = 0;
					num = 0;
					if (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
					{
						num = (int)binaryReader.ReadByte();
						binaryReader.BaseStream.Position -= 1L;
					}
				}
			}
			if (num2 != 0)
			{
				byte b2 = (byte)num;
				this.Write(b2);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00030188 File Offset: 0x0002E388
		private void PushIntegerPc(int value, FieldDescriptor fieldDescriptor)
		{
			int num = fieldDescriptor.Depth;
			bool flag = false;
			int num2 = value - fieldDescriptor.RangeLow;
			do
			{
				if (this.m_CurrentBitPosition + num > 8)
				{
					int num3 = 8 - this.m_CurrentBitPosition;
					int num4 = (1 << num3) - 1;
					int num5 = num2 & num4;
					this.m_CurrentByte += num5 << this.m_CurrentBitPosition;
					this.Write((byte)this.m_CurrentByte);
					num2 >>= num3;
					this.m_CurrentByte = 0;
					this.m_CurrentBitPosition = 0;
					num -= num3;
				}
				else if (this.m_CurrentBitPosition + num < 8)
				{
					this.m_CurrentByte += num2 << this.m_CurrentBitPosition;
					this.m_CurrentBitPosition += num;
					flag = true;
				}
				else
				{
					this.m_CurrentByte += num2 << this.m_CurrentBitPosition;
					this.Write((byte)this.m_CurrentByte);
					this.m_CurrentByte = 0;
					this.m_CurrentBitPosition = 0;
					flag = true;
				}
			}
			while (!flag);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0003027C File Offset: 0x0002E47C
		public void WritePendingByte()
		{
			if (this.m_CurrentBitPosition != 0)
			{
				this.Write((byte)this.m_CurrentByte);
				this.m_CurrentBitPosition = 0;
				this.m_CurrentByte = 0;
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000302A1 File Offset: 0x0002E4A1
		public void Align(long position)
		{
			this.BaseStream.Position = position;
			this.m_CurrentBitPosition = 0;
			this.m_CurrentByte = 0;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x000302BD File Offset: 0x0002E4BD
		public void AlignToByte()
		{
			if (this.m_CurrentBitPosition != 0)
			{
				this.Write(this.m_CurrentByte);
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000302D4 File Offset: 0x0002E4D4
		public void AlignTo32Bit()
		{
			if (this.m_CurrentBitPosition != 0)
			{
				this.Write(this.m_CurrentByte);
			}
			int i = (int)(this.BaseStream.Position & 3L);
			if (i != 0)
			{
				while (i < 4)
				{
					this.Write(0);
					i++;
				}
			}
		}

		// Token: 0x04000341 RID: 833
		private int m_CurrentByte;

		// Token: 0x04000342 RID: 834
		private int m_CurrentBitPosition;

		// Token: 0x04000343 RID: 835
		private FifaPlatform m_Platform;
	}
}
