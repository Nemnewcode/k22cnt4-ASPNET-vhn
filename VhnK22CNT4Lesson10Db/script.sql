USE [VhnCNT4Lesson10Db]
GO
/****** Object:  Table [dbo].[VhnAccount]    Script Date: 03/07/2024 2:03:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VhnAccount](
	[VhnID] [int] NOT NULL,
	[VhnUserName] [nvarchar](50) NULL,
	[VhnPassword] [nvarchar](50) NULL,
	[VhnFullName] [nvarchar](50) NULL,
	[VhnEmail] [nvarchar](50) NULL,
	[VhnPhone] [nvarchar](50) NULL,
	[VhnActive] [bit] NULL,
 CONSTRAINT [PK_VhnAccount] PRIMARY KEY CLUSTERED 
(
	[VhnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[VhnAccount] ([VhnID], [VhnUserName], [VhnPassword], [VhnFullName], [VhnEmail], [VhnPhone], [VhnActive]) VALUES (1, N'Nam', N'hoainam04', N'Vũ Hoài Nam', N'mrhien19792017@gmail.com', N'0326630444', NULL)
GO
