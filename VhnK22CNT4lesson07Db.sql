USE [VhnK22CNT4lesson07Db]
GO
/****** Object:  Table [dbo].[vhnKhoa]    Script Date: 12/06/2024 2:43:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vhnKhoa](
	[VhnMaKH] [nchar](10) NOT NULL PRIMARY KEY,
	[VhnTenKH] [nvarchar](50) NULL,
	[VhnTrangThai] [bit] NULL)
 CONSTRAINT [PK_vhnKhoa] PRIMARY KEY CLUSTERED 
(
	[VhnMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vhnSinhVien]    Script Date: 12/06/2024 2:43:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vhnSinhVien](
	[VhnMaSV] [nvarchar](50) NOT NULL PRIMARY KEY,
	[VhnHoSV] [nvarchar](50) NULL,
	[VhnTenSV] [nvarchar](50) NULL,
	[VhnNgaySinh] [date] NULL,
	[VhnPhai] [bit] NULL,
	[VhnPhone] [nchar](10) NULL,
	[VhnEmail] [nvarchar](50) NULL,
	[VhnMaKH] [nchar](10) NULL)
 CONSTRAINT [PK_vhnSinhVien] PRIMARY KEY CLUSTERED 
(
	[VhnMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[vhnKhoa] ([VhnMaKH], [VhnTenKH], [VhnTrangThai]) VALUES (N'K22CNT3   ', N'K22CNT2', 1)
GO
INSERT [dbo].[vhnSinhVien] ([VhnMaSV], [VhnHoSV], [VhnTenSV], [VhnNgaySinh], [VhnPhai], [VhnPhone], [VhnEmail], [VhnMaKH]) VALUES (N'2210900050', N'Vu Hoai', N'Nam', CAST(N'2004-08-18' AS Date), 1, N'0326630444', N'hoainem266@gmail.com', N'K22CNT3   ')
GO
