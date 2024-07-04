USE [VhnK22CNT4Lesson11Db]
GO
/****** Object:  Table [dbo].[VhnCategory]    Script Date: 04/07/2024 9:58:39 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VhnCategory](
	[VhnID] [int] NOT NULL,
	[VhnCateName] [nvarchar](50) NULL,
	[VhnStatus] [bit] NULL,
 CONSTRAINT [PK_VhnCategory] PRIMARY KEY CLUSTERED 
(
	[VhnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VhnProduct]    Script Date: 04/07/2024 9:58:39 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VhnProduct](
	[VhnID2210900050] [nvarchar](50) NOT NULL,
	[VhnProName] [nvarchar](50) NULL,
	[VhnQty] [int] NULL,
	[VhnPrice] [float] NULL,
	[VhnCateid] [int] NULL,
	[VhnActive] [bit] NULL,
 CONSTRAINT [PK_VhnProduct] PRIMARY KEY CLUSTERED 
(
	[VhnID2210900050] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[VhnCategory] ([VhnID], [VhnCateName], [VhnStatus]) VALUES (1, N'2210900050', NULL)
INSERT [dbo].[VhnCategory] ([VhnID], [VhnCateName], [VhnStatus]) VALUES (2, N'Iphone', NULL)
GO
INSERT [dbo].[VhnProduct] ([VhnID2210900050], [VhnProName], [VhnQty], [VhnPrice], [VhnCateid], [VhnActive]) VALUES (N'2210900050', N'Vũ Hoài Nam', 10, 1000, 1, NULL)
INSERT [dbo].[VhnProduct] ([VhnID2210900050], [VhnProName], [VhnQty], [VhnPrice], [VhnCateid], [VhnActive]) VALUES (N'P001', N'iphone 15', 1, 2000, 1, NULL)
GO
