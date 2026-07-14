using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200008F RID: 143
	public class Rx3RawData
	{
		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0004A475 File Offset: 0x00048675
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0004A47D File Offset: 0x0004867D
		public bool IsFifa14
		{
			get
			{
				return this.m_IsFifa14;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0004A485 File Offset: 0x00048685
		public byte[][] RawData
		{
			get
			{
				return this.m_RawData;
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0004A48D File Offset: 0x0004868D
		public Rx3RawData(string fileName)
		{
			this.m_FileName = fileName;
			this.Load(fileName);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0004A4A4 File Offset: 0x000486A4
		public bool Load(string fileName)
		{
			if (!File.Exists(fileName))
			{
				return false;
			}
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			bool flag = this.Load(binaryReader);
			fileStream.Close();
			binaryReader.Close();
			this.m_FileName = fileName;
			return flag;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0004A4EC File Offset: 0x000486EC
		public bool Load(BinaryReader r)
		{
			string text = new string(r.ReadChars(4));
			if (text == "Rx3l")
			{
				r.BaseStream.Seek(0L, SeekOrigin.Begin);
				this.m_IsFifa12 = true;
				this.m_Rx3bPosition = 0;
				this.m_SwapEndian = false;
				this.m_IsFifa14 = true;
			}
			else if (text != "RX3b")
			{
				r.BaseStream.Seek(0L, SeekOrigin.Begin);
				this.m_IsFifa12 = true;
				this.m_Rx3bPosition = 0;
				this.m_SwapEndian = true;
				this.m_IsFifa14 = false;
			}
			else
			{
				this.m_IsFifa12 = false;
				r.BaseStream.Position = 68L;
				this.m_Rx3bPosition = FifaUtil.SwapEndian(r.ReadInt32());
				r.BaseStream.Seek(0L, SeekOrigin.Begin);
				this.m_Preface = r.ReadBytes(this.m_Rx3bPosition);
				this.m_SwapEndian = true;
				this.m_IsFifa14 = false;
			}
			this.m_Rx3Header = new Rx3Header(r, this.m_SwapEndian);
			if (this.m_Rx3Header.NFiles == 0)
			{
				return false;
			}
			this.m_Rx3FileDescriptors = new Rx3FileDescriptor[this.m_Rx3Header.NFiles];
			for (int i = 0; i < this.m_Rx3Header.NFiles; i++)
			{
				this.m_Rx3FileDescriptors[i] = new Rx3FileDescriptor(r, this.m_SwapEndian);
			}
			this.m_RawData = new byte[this.m_Rx3Header.NFiles][];
			for (int j = 0; j < this.m_Rx3Header.NFiles; j++)
			{
				this.m_RawData[j] = r.ReadBytes(this.m_Rx3FileDescriptors[j].Size);
			}
			return true;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0004A67C File Offset: 0x0004887C
		public bool SetRawData(int index, byte[] rawData)
		{
			int num = rawData.Length;
			int size = this.m_Rx3FileDescriptors[index].Size;
			this.m_Rx3FileDescriptors[index].Size = num;
			int num2 = num - size;
			for (int i = index + 1; i < this.m_Rx3FileDescriptors.Length; i++)
			{
				this.m_Rx3FileDescriptors[i].Offset += num2;
			}
			this.m_RawData[index] = rawData;
			this.m_Rx3Header.SizeOf_ += num2;
			return true;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0004A6F4 File Offset: 0x000488F4
		public bool Save(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			bool flag = this.Save(binaryWriter);
			fileStream.Close();
			binaryWriter.Close();
			this.m_FileName = fileName;
			return flag;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0004A730 File Offset: 0x00048930
		public virtual bool Save(BinaryWriter w)
		{
			this.m_Rx3Header.Save(w);
			for (int i = 0; i < this.m_Rx3Header.NFiles; i++)
			{
				this.m_Rx3FileDescriptors[i].Save(w);
			}
			for (int j = 0; j < this.m_Rx3Header.NFiles; j++)
			{
				w.Write(this.m_RawData[j]);
			}
			return true;
		}

		// Token: 0x04000F9E RID: 3998
		private string m_FileName;

		// Token: 0x04000F9F RID: 3999
		private bool m_IsFifa12;

		// Token: 0x04000FA0 RID: 4000
		private bool m_IsFifa14;

		// Token: 0x04000FA1 RID: 4001
		private int m_Rx3bPosition;

		// Token: 0x04000FA2 RID: 4002
		private byte[] m_Preface;

		// Token: 0x04000FA3 RID: 4003
		private byte[][] m_RawData;

		// Token: 0x04000FA4 RID: 4004
		private Rx3Header m_Rx3Header;

		// Token: 0x04000FA5 RID: 4005
		private bool m_SwapEndian;

		// Token: 0x04000FA6 RID: 4006
		private Rx3FileDescriptor[] m_Rx3FileDescriptors;
	}
}
