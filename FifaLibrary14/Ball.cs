using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000079 RID: 121
	public class Ball : IdObject
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00045D18 File Offset: 0x00043F18
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00045D20 File Offset: 0x00043F20
		public bool IsLicensed
		{
			get
			{
				return this.m_IsLicensed;
			}
			set
			{
				this.m_IsLicensed = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00045D29 File Offset: 0x00043F29
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00045D31 File Offset: 0x00043F31
		public bool IsAvailable
		{
			get
			{
				return this.m_IsAvailable;
			}
			set
			{
				this.m_IsAvailable = value;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00045D3A File Offset: 0x00043F3A
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x00045D42 File Offset: 0x00043F42
		public bool IsEmbargoed
		{
			get
			{
				return this.m_IsEmbargoed;
			}
			set
			{
				this.m_IsEmbargoed = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00045D4B File Offset: 0x00043F4B
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00045D53 File Offset: 0x00043F53
		public int powid
		{
			get
			{
				return this.m_powid;
			}
			set
			{
				this.m_powid = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00045D5C File Offset: 0x00043F5C
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00045D64 File Offset: 0x00043F64
		public string Name
		{
			get
			{
				return this.m_LanguageName;
			}
			set
			{
				this.m_LanguageName = value;
				FifaEnvironment.Language.SetBallName(base.Id, this.m_LanguageName, this.m_IsGeneric);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00045D89 File Offset: 0x00043F89
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00045D91 File Offset: 0x00043F91
		public bool IsGeneric
		{
			get
			{
				return this.m_IsGeneric;
			}
			set
			{
				if (value != this.m_IsGeneric)
				{
					FifaEnvironment.Language.RemoveBallName(base.Id);
					FifaEnvironment.Language.SetBallName(base.Id, this.m_LanguageName, value);
				}
				this.m_IsGeneric = value;
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00045DCC File Offset: 0x00043FCC
		public Ball(int ballId)
			: base(ballId)
		{
			this.m_LanguageName = FifaEnvironment.Language.GetBallName(base.Id, out this.m_IsGeneric);
			if (this.m_LanguageName == null)
			{
				this.m_LanguageName = "Ball n." + base.Id.ToString();
				this.m_IsGeneric = false;
				FifaEnvironment.Language.SetBallName(base.Id, this.m_LanguageName, this.m_IsGeneric);
			}
			this.m_IsLicensed = false;
			this.m_IsAvailable = true;
			this.m_IsEmbargoed = false;
			this.m_powid = -1;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00045E64 File Offset: 0x00044064
		public Ball(Record r)
			: base(r.IntField[FI.teamballs_ballid])
		{
			this.m_LanguageName = FifaEnvironment.Language.GetBallName(base.Id, out this.m_IsGeneric);
			if (this.m_LanguageName == null)
			{
				this.m_LanguageName = "Ball n." + base.Id.ToString();
				this.m_IsGeneric = false;
				FifaEnvironment.Language.SetBallName(base.Id, this.m_LanguageName, this.m_IsGeneric);
			}
			this.m_IsLicensed = r.GetAndCheckIntField(FI.teamballs_islicensed) != 0;
			this.m_IsAvailable = r.GetAndCheckIntField(FI.teamballs_isavailableinstore) != 0;
			this.m_IsEmbargoed = r.GetAndCheckIntField(FI.teamballs_isembargoed) != 0;
			this.m_powid = r.GetAndCheckIntField(FI.teamballs_powid);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00045F40 File Offset: 0x00044140
		public void SaveBall(Record r)
		{
			r.IntField[FI.teamballs_ballid] = base.Id;
			r.IntField[FI.teamballs_islicensed] = (this.m_IsLicensed ? 1 : 0);
			r.IntField[FI.teamballs_isavailableinstore] = (this.m_IsAvailable ? 1 : 0);
			r.IntField[FI.teamballs_isembargoed] = 0;
			r.IntField[FI.teamballs_powid] = -1;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00045FA9 File Offset: 0x000441A9
		public override string ToString()
		{
			return this.m_LanguageName;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00045FB1 File Offset: 0x000441B1
		public static string BallTextureFileName(int ballId)
		{
			return "data/sceneassets/ball/ball_" + ballId.ToString() + "_textures.rx3";
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00045FC9 File Offset: 0x000441C9
		public string BallTextureFileName()
		{
			return Ball.BallTextureFileName(base.Id);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00045FD8 File Offset: 0x000441D8
		public static Bitmap GetBallTexture(int ballId)
		{
			string text = Ball.BallTextureFileName(ballId);
			return FifaEnvironment.GetBmpFromRx3(text, 0);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00045FF3 File Offset: 0x000441F3
		public Bitmap GetBallTexture()
		{
			return Ball.GetBallTexture(base.Id);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00046000 File Offset: 0x00044200
		public static Bitmap[] GetBallTextures(int ballId)
		{
			string text = Ball.BallTextureFileName(ballId);
			return FifaEnvironment.GetBmpsFromRx3(text);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0004601A File Offset: 0x0004421A
		public Bitmap[] GetBallTextures()
		{
			return Ball.GetBallTextures(base.Id);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00046027 File Offset: 0x00044227
		public static bool SetBallTextures(int ballId, Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data\\sceneassets\\ball\\ball_#_textures.rx3", ballId, bitmaps, ECompressionMode.Chunkzip);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00046036 File Offset: 0x00044236
		public bool SetBallTextures(Bitmap[] bitmaps)
		{
			return Ball.SetBallTextures(base.Id, bitmaps);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00046044 File Offset: 0x00044244
		public static bool SetBallTextures(int ballId, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, Ball.BallTextureFileName(ballId), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00046063 File Offset: 0x00044263
		public bool SetBallTextures(string srcFileName)
		{
			return Ball.SetBallTextures(base.Id, srcFileName);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00046074 File Offset: 0x00044274
		public bool DeleteBallTextures()
		{
			string text = this.BallTextureFileName();
			return FifaEnvironment.DeleteFromZdata(text);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0004608E File Offset: 0x0004428E
		public static string BallPictureTemplateBigFileName()
		{
			return "data/ui/artassets/settingsimg/ball_#.big";
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00046095 File Offset: 0x00044295
		public static string BallPictureTemplateDdsName()
		{
			return "2";
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0004609C File Offset: 0x0004429C
		public static string BallPictureBigFileName(int ballId)
		{
			return "data/ui/artassets/settingsimg/ball_" + ballId.ToString() + ".big";
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000460B4 File Offset: 0x000442B4
		public string BallPictureBigFileName()
		{
			return Ball.BallPictureBigFileName(base.Id);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000460C4 File Offset: 0x000442C4
		public static Bitmap GetBallPicture(int ballId)
		{
			string text = Ball.BallPictureBigFileName(ballId);
			return FifaEnvironment.GetArtasset(text);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000460DE File Offset: 0x000442DE
		public Bitmap GetBallPicture()
		{
			return Ball.GetBallPicture(base.Id);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000460EC File Offset: 0x000442EC
		public bool DeleteBallPicture()
		{
			string text = this.BallPictureBigFileName();
			return FifaEnvironment.DeleteFromZdata(text);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00046106 File Offset: 0x00044306
		public static bool SetBallPicture(int ballId, Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(Ball.BallPictureTemplateBigFileName(), Ball.BallPictureTemplateDdsName(), ballId, bitmap);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00046119 File Offset: 0x00044319
		public bool SetBallPicture(Bitmap bitmap)
		{
			return Ball.SetBallPicture(base.Id, bitmap);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00046127 File Offset: 0x00044327
		public static string BallModelFileName(int ballId)
		{
			return "data/sceneassets/ball/ball_" + ballId.ToString() + ".rx3";
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0004613F File Offset: 0x0004433F
		public string BallModelFileName()
		{
			return Ball.BallModelFileName(base.Id);
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0004614C File Offset: 0x0004434C
		public static string BallModelTemplateFileName()
		{
			return "data/sceneassets/ball/ball_#.rx3";
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00046154 File Offset: 0x00044354
		public static Rx3File GetBallModel(int ballId)
		{
			string text = Ball.BallModelFileName(ballId);
			return FifaEnvironment.GetRx3FromZdata(text);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0004616E File Offset: 0x0004436E
		public Rx3File GetBallModel()
		{
			return Ball.GetBallModel(base.Id);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0004617C File Offset: 0x0004437C
		public static bool SetBallModel(int ballId, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, Ball.BallModelFileName(ballId), false, ECompressionMode.Chunkzip, null);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0004619C File Offset: 0x0004439C
		public bool SetBallModel(string srcFileName)
		{
			return Ball.SetBallModel(base.Id, srcFileName);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000461AC File Offset: 0x000443AC
		public bool DeleteBallModel()
		{
			string text = this.BallModelFileName();
			return FifaEnvironment.DeleteFromZdata(text);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x000461C6 File Offset: 0x000443C6
		public bool DeleteBall()
		{
			this.DeleteBallTextures();
			this.DeleteBallModel();
			this.DeleteBallPicture();
			return true;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x000461E0 File Offset: 0x000443E0
		public override IdObject Clone(int newId)
		{
			Ball ball = (Ball)base.Clone(newId);
			if (ball != null)
			{
				ball.Name = "Ball n." + newId.ToString();
				FifaEnvironment.CloneIntoZdata(Ball.BallTextureFileName(base.Id), Ball.BallTextureFileName(newId));
				FifaEnvironment.CloneIntoZdata(Ball.BallModelFileName(base.Id), Ball.BallModelFileName(newId));
				FifaEnvironment.CloneIntoZdata(Ball.BallPictureBigFileName(base.Id), Ball.BallPictureBigFileName(newId));
			}
			return ball;
		}

		// Token: 0x04000F54 RID: 3924
		private bool m_IsLicensed;

		// Token: 0x04000F55 RID: 3925
		private bool m_IsAvailable;

		// Token: 0x04000F56 RID: 3926
		private bool m_IsEmbargoed;

		// Token: 0x04000F57 RID: 3927
		private int m_powid;

		// Token: 0x04000F58 RID: 3928
		private string m_LanguageName;

		// Token: 0x04000F59 RID: 3929
		private bool m_IsGeneric;
	}
}
