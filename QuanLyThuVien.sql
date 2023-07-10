CREATE DATABASE [QuanLyThuVien]
USE [master]
GO
CREATE LOGIN [Hoang] WITH PASSWORD=N'12345', DEFAULT_DATABASE=[QuanLyThuVien], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
CREATE LOGIN [Huy] WITH PASSWORD=N'12345', DEFAULT_DATABASE=[QuanLyThuVien], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
CREATE LOGIN [Kien] WITH PASSWORD=N'12345', DEFAULT_DATABASE=[QuanLyThuVien], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
CREATE LOGIN [thinh] WITH PASSWORD=N'12345', DEFAULT_DATABASE=[QuanLyThuVien], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
CREATE LOGIN [ThuThu] WITH PASSWORD=N'12345', DEFAULT_DATABASE=[QuanLyThuVien], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [ThuThu]
GO
ALTER SERVER ROLE [diskadmin] ADD MEMBER [ThuThu]
GO
ALTER SERVER ROLE [dbcreator] ADD MEMBER [ThuThu]
GO
USE [QuanLyThuVien]
GO
/****** Object:  User [1]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE USER [1] FOR LOGIN [Kien] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [2]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE USER [2] FOR LOGIN [thinh] WITH DEFAULT_SCHEMA=[2]
GO
/****** Object:  User [3]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE USER [3] FOR LOGIN [Hoang] WITH DEFAULT_SCHEMA=[3]
GO
/****** Object:  User [7]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE USER [7] FOR LOGIN [Huy] WITH DEFAULT_SCHEMA=[7]
GO
/****** Object:  User [TT]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE USER [TT] FOR LOGIN [ThuThu] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [DocGia]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE ROLE [DocGia]
GO

/****** Object:  DatabaseRole [ThuThu]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE ROLE [ThuThu]
GO
ALTER ROLE [DocGia] ADD MEMBER [1]
GO
ALTER ROLE [DocGia] ADD MEMBER [2]
GO
ALTER ROLE [DocGia] ADD MEMBER [3]
GO
ALTER ROLE [DocGia] ADD MEMBER [7]
GO
ALTER ROLE [ThuThu] ADD MEMBER [TT]
GO
ALTER ROLE [db_datareader] ADD MEMBER [DocGia]
GO
ALTER ROLE [db_owner] ADD MEMBER [ThuThu]
GO
/****** Object:  Schema [2]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE SCHEMA [2]
GO
/****** Object:  Schema [3]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE SCHEMA [3]
GO
/****** Object:  Schema [7]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE SCHEMA [7]
GO
/****** Object:  UserDefinedTableType [dbo].[TYPE_CTSach]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE TYPE [dbo].[TYPE_CTSach] AS TABLE(
	[MaTacGia] [nchar](10) NULL,
	[IDTuaSach] [int] NULL
)
GO
/****** Object:  Table [dbo].[CTMuonSach]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTMuonSach](
	[SoThe] [int] NOT NULL,
	[IDCuonSach] [int] NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[NgayTra] [date] NULL,
 CONSTRAINT [PK_CTMuonSach] PRIMARY KEY CLUSTERED 
(
	[SoThe] ASC,
	[IDCuonSach] ASC,
	[NgayMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuonSach]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuonSach](
	[IDCuonSach] [int] IDENTITY(1,1) NOT NULL,
	[STT] [int] NOT NULL,
	[IDLXB] [int] NOT NULL,
	[TinhTrang] [nchar](10) NOT NULL,
 CONSTRAINT [PK_CuonSach] PRIMARY KEY CLUSTERED 
(
	[IDCuonSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_SACH_CO_THE_MUON]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_SACH_CO_THE_MUON]
AS
SELECT IDCUONSACH, STT, TinhTrang, IDLXB
FROM CuonSach
WHERE CuonSach.IDCuonSach IN (SELECT IDCuonSach FROM CTMuonSach WHERE NgayTra IS NOT NULL)




GO
/****** Object:  Table [dbo].[CTSach]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTSach](
	[MaTacGia] [nchar](10) NOT NULL,
	[IDTuaSach] [int] NOT NULL,
 CONSTRAINT [PK_CTSach] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC,
	[IDTuaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LanXuatBan]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LanXuatBan](
	[IDLXB] [int] IDENTITY(1,1) NOT NULL,
	[LanXB] [int] NOT NULL,
	[IDTuaSach] [int] NOT NULL,
	[NamXB] [date] NOT NULL,
	[KhoGiay] [nchar](10) NOT NULL,
	[SoTrang] [int] NOT NULL,
	[NhaXB] [nvarchar](50) NOT NULL,
	[Gia] [float] NOT NULL,
	[DiaCD] [bit] NULL,
 CONSTRAINT [PK_LanXuatBan] PRIMARY KEY CLUSTERED 
(
	[IDLXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [nchar](10) NOT NULL,
	[TenTacGia] [nvarchar](50) NOT NULL,
	[NamSinh] [date] NOT NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TuaSach]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuaSach](
	[IDTuaSach] [int] IDENTITY(1,1) NOT NULL,
	[TenTuaSach] [nvarchar](50) NOT NULL,
	[MaTaiLieu] [nchar](10) NOT NULL,
 CONSTRAINT [PK_TuaSach] PRIMARY KEY CLUSTERED 
(
	[IDTuaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[V_CT_SACH_CO_THE_MUON]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_CT_SACH_CO_THE_MUON]
AS
SELECT TenTuaSach, LanXB, NamXB, NhaXB, DiaCD, TenTacGia, VSCTM.IDLXB  FROM TuaSach TS
LEFT JOIN LanXuatBan LXB ON LXB.IDTuaSach = TS.IDTuaSach
LEFT JOIN CTSach ON TS.IDTuaSach=CTSach.IDTuaSach
LEFT JOIN TacGia TG ON TG.MaTacGia=CTSach.MaTacGia
LEFT JOIN (SELECT IDCUONSACH, STT, TinhTrang, IDLXB
FROM CuonSach
WHERE CuonSach.IDCuonSach IN (SELECT IDCuonSach FROM CTMuonSach WHERE NgayTra IS NOT NULL)) VSCTM ON VSCTM.IDLXB = LXB.IDLXB
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[SoThe] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[NgheNghiep] [nvarchar](50) NOT NULL,
	[Phai] [bit] NOT NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[SoThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[GET_NO_ACCOUNTS_READER]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GET_NO_ACCOUNTS_READER]
AS
SELECT SoThe,Ten
FROM  DocGia
WHERE     (NOT EXISTS
                             (SELECT        name
                               FROM            sys.sysusers
                               WHERE        (name = CAST(SoThe AS NVARCHAR))))
GO
/****** Object:  View [dbo].[GET_ACCOUNTS_READER]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GET_ACCOUNTS_READER]
AS
SELECT SoThe,Ten
FROM  DocGia
WHERE     (EXISTS
                             (SELECT        name
                               FROM            sys.sysusers
                               WHERE        (name = CAST(SoThe AS NVARCHAR))))
GO
/****** Object:  View [dbo].[GET_TEN_SACH]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GET_TEN_SACH]
AS
SELECT IDCuonSach,TenTuaSach FROM CuonSach,LanXuatBan,TuaSach
WHERE CuonSach.IDLXB=LanXuatBan.IDLXB AND CuonSach.IDCuonSach=TuaSach.IDTuaSach
GO
/****** Object:  Table [dbo].[KyXuatBan]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyXuatBan](
	[IDKyXuatBan] [int] IDENTITY(1,1) NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[SoLuongTon] [int] NOT NULL,
	[IDBTC] [int] NOT NULL,
	[LanXB] [int] NOT NULL,
 CONSTRAINT [PK_KyXuatBan] PRIMARY KEY CLUSTERED 
(
	[IDKyXuatBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[RestrictedKyXuatBan]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[RestrictedKyXuatBan]
AS
	SELECT IDKyXuatBan, LanXB, IDBTC
	FROM KyXuatBan
GO
/****** Object:  Table [dbo].[BaoTapChi]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoTapChi](
	[IDBTC] [int] IDENTITY(1,1) NOT NULL,
	[NamPhatHanh] [date] NOT NULL,
	[DinhKy] [nchar](10) NOT NULL,
	[NhaXB] [nvarchar](50) NOT NULL,
	[MaTaiLieu] [nchar](10) NOT NULL,
 CONSTRAINT [PK_BaoTapChi] PRIMARY KEY CLUSTERED 
(
	[IDBTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTMuonBaoTapChi]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTMuonBaoTapChi](
	[SoThe] [int] NOT NULL,
	[IDKyXB] [int] NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[NgayTra] [date] NULL,
 CONSTRAINT [PK_CTMuonBaoTapChi] PRIMARY KEY CLUSTERED 
(
	[SoThe] ASC,
	[IDKyXB] ASC,
	[NgayMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiLieu]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiLieu](
	[MaTaiLieu] [nchar](10) NOT NULL,
	[TenTaiLieu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TaiLieu] PRIMARY KEY CLUSTERED 
(
	[MaTaiLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BaoTapChi] ON 
GO
INSERT [dbo].[BaoTapChi] ([IDBTC], [NamPhatHanh], [DinhKy], [NhaXB], [MaTaiLieu]) VALUES (2, CAST(N'1975-04-30' AS Date), N'Nam       ', N'Quan Doi Giai Phong', N'B         ')
GO
INSERT [dbo].[BaoTapChi] ([IDBTC], [NamPhatHanh], [DinhKy], [NhaXB], [MaTaiLieu]) VALUES (3, CAST(N'2023-05-25' AS Date), N'Thang     ', N'Giao Duc', N'B         ')
GO
INSERT [dbo].[BaoTapChi] ([IDBTC], [NamPhatHanh], [DinhKy], [NhaXB], [MaTaiLieu]) VALUES (4, CAST(N'2023-05-25' AS Date), N'Ngay      ', N'Kim Dong', N'B         ')
GO
INSERT [dbo].[BaoTapChi] ([IDBTC], [NamPhatHanh], [DinhKy], [NhaXB], [MaTaiLieu]) VALUES (5, CAST(N'2023-05-25' AS Date), N'Giay      ', N'Nhi Dong 2', N'B         ')
GO
INSERT [dbo].[BaoTapChi] ([IDBTC], [NamPhatHanh], [DinhKy], [NhaXB], [MaTaiLieu]) VALUES (6, CAST(N'2023-01-06' AS Date), N'Nam       ', N'Thieu Nhi', N'B         ')
GO
INSERT [dbo].[BaoTapChi] ([IDBTC], [NamPhatHanh], [DinhKy], [NhaXB], [MaTaiLieu]) VALUES (8, CAST(N'2023-06-07' AS Date), N'Tuan      ', N'Buu dien', N'B         ')
GO
SET IDENTITY_INSERT [dbo].[BaoTapChi] OFF
GO
INSERT [dbo].[CTMuonBaoTapChi] ([SoThe], [IDKyXB], [NgayMuon], [NgayTra]) VALUES (1, 1, CAST(N'2023-06-07' AS Date), CAST(N'2023-06-07' AS Date))
GO
INSERT [dbo].[CTMuonBaoTapChi] ([SoThe], [IDKyXB], [NgayMuon], [NgayTra]) VALUES (1, 2, CAST(N'2023-06-07' AS Date), NULL)
GO
INSERT [dbo].[CTMuonBaoTapChi] ([SoThe], [IDKyXB], [NgayMuon], [NgayTra]) VALUES (1, 5, CAST(N'2023-06-07' AS Date), CAST(N'2023-06-07' AS Date))
GO
INSERT [dbo].[CTMuonBaoTapChi] ([SoThe], [IDKyXB], [NgayMuon], [NgayTra]) VALUES (1, 6, CAST(N'2023-06-07' AS Date), CAST(N'2023-06-07' AS Date))
GO
INSERT [dbo].[CTMuonBaoTapChi] ([SoThe], [IDKyXB], [NgayMuon], [NgayTra]) VALUES (1, 8, CAST(N'2023-06-07' AS Date), CAST(N'2023-06-07' AS Date))
GO
INSERT [dbo].[CTMuonBaoTapChi] ([SoThe], [IDKyXB], [NgayMuon], [NgayTra]) VALUES (1, 9, CAST(N'2023-06-07' AS Date), CAST(N'2023-06-07' AS Date))
GO
INSERT [dbo].[CTMuonBaoTapChi] ([SoThe], [IDKyXB], [NgayMuon], [NgayTra]) VALUES (3, 1, CAST(N'2023-06-07' AS Date), NULL)
GO
INSERT [dbo].[CTMuonBaoTapChi] ([SoThe], [IDKyXB], [NgayMuon], [NgayTra]) VALUES (3, 3, CAST(N'2023-06-07' AS Date), NULL)
GO
INSERT [dbo].[CTMuonBaoTapChi] ([SoThe], [IDKyXB], [NgayMuon], [NgayTra]) VALUES (3, 7, CAST(N'2023-06-07' AS Date), CAST(N'2023-06-07' AS Date))
GO
INSERT [dbo].[CTMuonBaoTapChi] ([SoThe], [IDKyXB], [NgayMuon], [NgayTra]) VALUES (3, 11, CAST(N'2023-06-07' AS Date), NULL)
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (1, 1, CAST(N'2023-05-19' AS Date), CAST(N'2023-05-25' AS Date))
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (1, 3, CAST(N'2023-06-06' AS Date), CAST(N'2023-06-07' AS Date))
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (1, 3, CAST(N'2023-06-07' AS Date), NULL)
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (1, 6, CAST(N'2023-06-06' AS Date), CAST(N'2023-06-07' AS Date))
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (1, 8, CAST(N'2023-06-06' AS Date), NULL)
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (1, 9, CAST(N'2023-01-06' AS Date), CAST(N'2023-06-07' AS Date))
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (2, 2, CAST(N'2023-05-19' AS Date), CAST(N'2023-06-07' AS Date))
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (2, 5, CAST(N'2023-05-25' AS Date), NULL)
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (3, 1, CAST(N'2023-06-03' AS Date), CAST(N'2023-06-03' AS Date))
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (3, 1, CAST(N'2023-06-07' AS Date), NULL)
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (3, 2, CAST(N'2023-06-07' AS Date), NULL)
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (3, 3, CAST(N'2023-06-03' AS Date), CAST(N'2023-06-03' AS Date))
GO
INSERT [dbo].[CTMuonSach] ([SoThe], [IDCuonSach], [NgayMuon], [NgayTra]) VALUES (3, 9, CAST(N'2023-06-07' AS Date), NULL)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'HTT       ', 2)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'HTT       ', 4)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'HTT       ', 5)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'HTT       ', 9)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'HTTam     ', 2)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'HTTam     ', 8)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'HTTam     ', 9)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'HTTam     ', 11)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'LNKT      ', 2)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'LNKT      ', 6)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'LNKT      ', 7)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'LNKT      ', 9)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'NXH       ', 3)
GO
INSERT [dbo].[CTSach] ([MaTacGia], [IDTuaSach]) VALUES (N'NXH       ', 11)
GO
SET IDENTITY_INSERT [dbo].[CuonSach] ON 
GO
INSERT [dbo].[CuonSach] ([IDCuonSach], [STT], [IDLXB], [TinhTrang]) VALUES (1, 1, 1, N'Hong      ')
GO
INSERT [dbo].[CuonSach] ([IDCuonSach], [STT], [IDLXB], [TinhTrang]) VALUES (2, 2, 2, N'Hong      ')
GO
INSERT [dbo].[CuonSach] ([IDCuonSach], [STT], [IDLXB], [TinhTrang]) VALUES (3, 3, 1, N'Tot       ')
GO
INSERT [dbo].[CuonSach] ([IDCuonSach], [STT], [IDLXB], [TinhTrang]) VALUES (5, 1, 2, N'Hong      ')
GO
INSERT [dbo].[CuonSach] ([IDCuonSach], [STT], [IDLXB], [TinhTrang]) VALUES (6, 2, 2, N'Tot       ')
GO
INSERT [dbo].[CuonSach] ([IDCuonSach], [STT], [IDLXB], [TinhTrang]) VALUES (8, 2, 3, N'Xau       ')
GO
INSERT [dbo].[CuonSach] ([IDCuonSach], [STT], [IDLXB], [TinhTrang]) VALUES (9, 1, 4, N'Tot       ')
GO
INSERT [dbo].[CuonSach] ([IDCuonSach], [STT], [IDLXB], [TinhTrang]) VALUES (25, 1, 5, N'Moi       ')
GO
SET IDENTITY_INSERT [dbo].[CuonSach] OFF
GO
SET IDENTITY_INSERT [dbo].[DocGia] ON 
GO
INSERT [dbo].[DocGia] ([SoThe], [Ten], [NgheNghiep], [Phai]) VALUES (1, N'Kien', N'CEO', 1)
GO
INSERT [dbo].[DocGia] ([SoThe], [Ten], [NgheNghiep], [Phai]) VALUES (2, N'Thinh', N'Administrator', 1)
GO
INSERT [dbo].[DocGia] ([SoThe], [Ten], [NgheNghiep], [Phai]) VALUES (3, N'Hoang', N'Boss', 1)
GO
INSERT [dbo].[DocGia] ([SoThe], [Ten], [NgheNghiep], [Phai]) VALUES (4, N' Kong', N' Lao công', 0)
GO
INSERT [dbo].[DocGia] ([SoThe], [Ten], [NgheNghiep], [Phai]) VALUES (7, N' Huy', N' AD', 1)
GO
SET IDENTITY_INSERT [dbo].[DocGia] OFF
GO
SET IDENTITY_INSERT [dbo].[KyXuatBan] ON 
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (1, 9, 8, 2, 1)
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (2, 9, 8, 3, 1)
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (3, 9, 9, 4, 1)
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (4, 9, 9, 5, 2)
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (5, 9, 9, 6, 1)
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (6, 9, 9, 2, 2)
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (7, 9, 8, 2, 3)
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (8, 17, 16, 2, 4)
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (9, 98, 97, 2, 5)
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (10, 12, 12, 2, 6)
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (11, 12, 12, 8, 12)
GO
INSERT [dbo].[KyXuatBan] ([IDKyXuatBan], [SoLuongNhap], [SoLuongTon], [IDBTC], [LanXB]) VALUES (12, 9, 9, 2, 7)
GO
SET IDENTITY_INSERT [dbo].[KyXuatBan] OFF
GO
SET IDENTITY_INSERT [dbo].[LanXuatBan] ON 
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (1, 1, 2, CAST(N'2023-06-06' AS Date), N'A4        ', 299, N'HVCS', 90000, 0)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (2, 2, 2, CAST(N'2023-01-06' AS Date), N'A4        ', 199, N'HVCS', 90000, 0)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (3, 1, 3, CAST(N'2023-01-06' AS Date), N'A4        ', 199, N'HVCS', 90000, 1)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (4, 2, 3, CAST(N'2023-01-06' AS Date), N'A4        ', 199, N'HVCS', 90000, 1)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (5, 5, 2, CAST(N'2023-01-06' AS Date), N'A4        ', 199, N'HVCS', 90000, 1)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (6, 1, 4, CAST(N'2023-01-06' AS Date), N'A4        ', 199, N'HVCS', 90000, 1)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (7, 3, 3, CAST(N'2023-06-06' AS Date), N'A4        ', 77, N'HVCS', 7700, 0)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (8, 2, 4, CAST(N'2023-06-06' AS Date), N'A4        ', 77, N'HVS', 70000, 1)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (9, 2, 4, CAST(N'2023-06-06' AS Date), N'A4        ', 99, N'HVCS', 70000, 1)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (10, 4, 2, CAST(N'2023-06-06' AS Date), N'A4        ', 89, N'HVCS', 87000, 1)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (11, 3, 2, CAST(N'2023-06-06' AS Date), N'A4        ', 79, N'HVCS', 79000, 0)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (12, 12, 11, CAST(N'2023-06-07' AS Date), N'A   1     ', 12, N'Ki', 12, 1)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (13, 6, 2, CAST(N'2023-06-07' AS Date), N'A4        ', 89, N'HVCS', 90.5, 0)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (14, 7, 2, CAST(N'2023-06-07' AS Date), N'A4        ', 199, N'HVCS', 25000, 0)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (15, 11, 11, CAST(N'2023-06-07' AS Date), N'A 1       ', 12, N'a', 12, 0)
GO
INSERT [dbo].[LanXuatBan] ([IDLXB], [LanXB], [IDTuaSach], [NamXB], [KhoGiay], [SoTrang], [NhaXB], [Gia], [DiaCD]) VALUES (16, 1, 9, CAST(N'2023-06-07' AS Date), N'A4        ', 189, N'hv', 25000, 0)
GO
SET IDENTITY_INSERT [dbo].[LanXuatBan] OFF
GO
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh]) VALUES (N'HTT       ', N'Huynh Trong Thưa', CAST(N'2008-07-29' AS Date))
GO
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh]) VALUES (N'HTTam     ', N'Huynh Thanh Tam', CAST(N'1990-01-01' AS Date))
GO
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh]) VALUES (N'LNKT      ', N'Luu Nguyen Ky Thu', CAST(N'1970-01-01' AS Date))
GO
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh]) VALUES (N'NXH       ', N'Nguyen Xuan Hai', CAST(N'1980-01-01' AS Date))
GO
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu]) VALUES (N'B         ', N'BaoTapChi')
GO
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu]) VALUES (N'S         ', N'Sach')
GO
SET IDENTITY_INSERT [dbo].[TuaSach] ON 
GO
INSERT [dbo].[TuaSach] ([IDTuaSach], [TenTuaSach], [MaTaiLieu]) VALUES (2, N'Giai Tich 1', N'S         ')
GO
INSERT [dbo].[TuaSach] ([IDTuaSach], [TenTuaSach], [MaTaiLieu]) VALUES (3, N'Dai So Tuyen Tinh', N'S         ')
GO
INSERT [dbo].[TuaSach] ([IDTuaSach], [TenTuaSach], [MaTaiLieu]) VALUES (4, N'Toan Roi Rac 1', N'S         ')
GO
INSERT [dbo].[TuaSach] ([IDTuaSach], [TenTuaSach], [MaTaiLieu]) VALUES (5, N'Toan Roi Rac 2', N'S         ')
GO
INSERT [dbo].[TuaSach] ([IDTuaSach], [TenTuaSach], [MaTaiLieu]) VALUES (6, N'Cau Truc Du Lieu Giai Thuat', N'S         ')
GO
INSERT [dbo].[TuaSach] ([IDTuaSach], [TenTuaSach], [MaTaiLieu]) VALUES (7, N'Co So Du Lieu', N'S         ')
GO
INSERT [dbo].[TuaSach] ([IDTuaSach], [TenTuaSach], [MaTaiLieu]) VALUES (8, N'Co So Bao Mat', N'S         ')
GO
INSERT [dbo].[TuaSach] ([IDTuaSach], [TenTuaSach], [MaTaiLieu]) VALUES (9, N'Bao Mat He Thong', N'S         ')
GO
INSERT [dbo].[TuaSach] ([IDTuaSach], [TenTuaSach], [MaTaiLieu]) VALUES (11, N'Nhung thu khong duoc day o Hvard', N'S         ')
GO
SET IDENTITY_INSERT [dbo].[TuaSach] OFF
GO
/****** Object:  Index [IX_NgayMuon]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_NgayMuon] ON [dbo].[CTMuonBaoTapChi]
(
	[NgayMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_NgayMuon]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_NgayMuon] ON [dbo].[CTMuonSach]
(
	[NgayMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_STT_IDLXB]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE NONCLUSTERED INDEX [IX_STT_IDLXB] ON [dbo].[CuonSach]
(
	[STT] ASC,
	[IDLXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_LanXB]    Script Date: 7/10/2023 4:55:20 PM ******/
ALTER TABLE [dbo].[KyXuatBan] ADD  CONSTRAINT [UK_LanXB] UNIQUE NONCLUSTERED 
(
	[IDBTC] ASC,
	[LanXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_LanXB_TuaSach]    Script Date: 7/10/2023 4:55:20 PM ******/
CREATE NONCLUSTERED INDEX [UK_LanXB_TuaSach] ON [dbo].[LanXuatBan]
(
	[LanXB] ASC,
	[IDTuaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LanXuatBan] ADD  CONSTRAINT [DF_LanXuatBan_DiaCD]  DEFAULT ((0)) FOR [DiaCD]
GO
ALTER TABLE [dbo].[BaoTapChi]  WITH CHECK ADD  CONSTRAINT [FK_BaoTapChi_TaiLieu] FOREIGN KEY([MaTaiLieu])
REFERENCES [dbo].[TaiLieu] ([MaTaiLieu])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BaoTapChi] CHECK CONSTRAINT [FK_BaoTapChi_TaiLieu]
GO
ALTER TABLE [dbo].[CTMuonBaoTapChi]  WITH CHECK ADD  CONSTRAINT [FK_MuonBaoTapChi_DocGia] FOREIGN KEY([SoThe])
REFERENCES [dbo].[DocGia] ([SoThe])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTMuonBaoTapChi] CHECK CONSTRAINT [FK_MuonBaoTapChi_DocGia]
GO
ALTER TABLE [dbo].[CTMuonBaoTapChi]  WITH CHECK ADD  CONSTRAINT [FK_MuonBaoTapChi_KyXuatBan] FOREIGN KEY([IDKyXB])
REFERENCES [dbo].[KyXuatBan] ([IDKyXuatBan])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTMuonBaoTapChi] CHECK CONSTRAINT [FK_MuonBaoTapChi_KyXuatBan]
GO
ALTER TABLE [dbo].[CTMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_CTMuonSach_CuonSach] FOREIGN KEY([IDCuonSach])
REFERENCES [dbo].[CuonSach] ([IDCuonSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTMuonSach] CHECK CONSTRAINT [FK_CTMuonSach_CuonSach]
GO
ALTER TABLE [dbo].[CTMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_MuonSach_DocGia] FOREIGN KEY([SoThe])
REFERENCES [dbo].[DocGia] ([SoThe])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTMuonSach] CHECK CONSTRAINT [FK_MuonSach_DocGia]
GO
ALTER TABLE [dbo].[CTSach]  WITH CHECK ADD  CONSTRAINT [FK_CTSach_TacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTSach] CHECK CONSTRAINT [FK_CTSach_TacGia]
GO
ALTER TABLE [dbo].[CTSach]  WITH CHECK ADD  CONSTRAINT [FK_CTSach_TuaSach] FOREIGN KEY([IDTuaSach])
REFERENCES [dbo].[TuaSach] ([IDTuaSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CTSach] CHECK CONSTRAINT [FK_CTSach_TuaSach]
GO
ALTER TABLE [dbo].[CuonSach]  WITH CHECK ADD  CONSTRAINT [FK_CuonSach_LanXuatBan] FOREIGN KEY([IDLXB])
REFERENCES [dbo].[LanXuatBan] ([IDLXB])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CuonSach] CHECK CONSTRAINT [FK_CuonSach_LanXuatBan]
GO
ALTER TABLE [dbo].[KyXuatBan]  WITH CHECK ADD  CONSTRAINT [FK_KyXuatBan_BaoTapChi] FOREIGN KEY([IDBTC])
REFERENCES [dbo].[BaoTapChi] ([IDBTC])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KyXuatBan] CHECK CONSTRAINT [FK_KyXuatBan_BaoTapChi]
GO
ALTER TABLE [dbo].[LanXuatBan]  WITH CHECK ADD  CONSTRAINT [FK_LanXuatBan_TuaSach] FOREIGN KEY([IDTuaSach])
REFERENCES [dbo].[TuaSach] ([IDTuaSach])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LanXuatBan] CHECK CONSTRAINT [FK_LanXuatBan_TuaSach]
GO
ALTER TABLE [dbo].[TuaSach]  WITH CHECK ADD  CONSTRAINT [FK_TuaSach_TaiLieu] FOREIGN KEY([MaTaiLieu])
REFERENCES [dbo].[TaiLieu] ([MaTaiLieu])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TuaSach] CHECK CONSTRAINT [FK_TuaSach_TaiLieu]
GO
/****** Object:  StoredProcedure [dbo].[Backup_QLTV]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Backup_QLTV]
@path nvarchar(100)
AS
BEGIN
	IF EXISTS (SELECT * FROM sys.backup_devices WHERE [name] = 'Backup_QuanLyThuVien')
	BEGIN
		EXEC sp_dropdevice 'Backup_QuanLyThuVien', 'delfile'
	END
	EXEC sp_addumpdevice 'disk', 'Backup_QuanLyThuVien', @path

	BACKUP DATABASE QuanLyThuVien TO Backup_QuanLyThuVien
END
GO
/****** Object:  StoredProcedure [dbo].[BaoTapChiDangChoMuon]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BaoTapChiDangChoMuon]
AS
BEGIN
	SELECT NhaXB, NamPhatHanh, DinhKy, LanXB, DocGia = DG.Ten, NgayMuon
	FROM BaoTapChi AS BTC INNER JOIN (SELECT IDKyXuatBan, IDBTC, LanXB FROM KyXuatBan) AS KXB ON BTC.IDBTC = KXB.IDBTC
		INNER JOIN (SELECT SoThe, IDKyXB, NgayMuon FROM CTMuonBaoTapChi WITH(INDEX(IX_NgayMuon)) WHERE NgayTra IS NULL) AS CT ON CT.IDKyXB = KXB.IDKyXuatBan
		INNER JOIN DocGia AS DG ON CT.SoThe = DG.SoThe
END
GO
/****** Object:  StoredProcedure [dbo].[Check_ADD_IDBTC_LanXB]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Check_ADD_IDBTC_LanXB]
@idbtc int,
@lxb int
AS
BEGIN
	if EXISTS (SELECT IDKyXuatBan FROM KyXuatBan WHERE IDBTC = @idbtc AND LanXB = @lxb)
	BEGIN
		RETURN 1
	END
	ELSE
		RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[Check_ADD_IDTS_LanXB_Sach]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Check_ADD_IDTS_LanXB_Sach]
@idts int,
@lxb int
AS
BEGIN
	if EXISTS (SELECT IDLXB FROM LanXuatBan WHERE IDTuaSach = @idts AND LanXB = @lxb)
	BEGIN
		RETURN 1
	END
	ELSE
		RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[Check_IDBTC_LanXB]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Check_IDBTC_LanXB]
@idkxb int,
@idbtc int,
@lxb int
AS
BEGIN
	if EXISTS (SELECT IDKyXuatBan FROM KyXuatBan WHERE IDBTC = @idbtc AND LanXB = @lxb AND IDKyXuatBan <> @idkxb)
	BEGIN
		RETURN 1
	END
	ELSE
		RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[Check_IDBTC_LanXB_Sach]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Check_IDBTC_LanXB_Sach]
@idLXB int,
@idts int,
@lxb int
AS
BEGIN
	if EXISTS (SELECT IDLXB FROM LanXuatBan WHERE IDTuaSach = @idts AND LanXB = @lxb AND IDLXB <> @idLXB)
	BEGIN
		RETURN 1
	END
	ELSE
		RETURN 0
END
GO
/****** Object:  StoredProcedure [dbo].[DocGiaMuonBTCQuaHan]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DocGiaMuonBTCQuaHan]
AS
BEGIN
	SELECT DocGia = DG.Ten, NhaXB, NamPhatHanh, DinhKy, LanXB, NgayMuon, SoNgayTreHan = DATEDIFF(DAY, NgayMuon, CAST(GETDATE() AS DATE))
	FROM BaoTapChi AS BTC INNER JOIN (SELECT IDKyXuatBan, IDBTC, LanXB FROM KyXuatBan) AS KXB ON BTC.IDBTC = KXB.IDBTC
		INNER JOIN (SELECT SoThe, IDKyXB, NgayMuon FROM CTMuonBaoTapChi WITH(INDEX(IX_NgayMuon)) WHERE NgayTra IS NULL) AS CT ON CT.IDKyXB = KXB.IDKyXuatBan
		INNER JOIN DocGia AS DG ON CT.SoThe = DG.SoThe
END
GO
/****** Object:  StoredProcedure [dbo].[DocGiaMuonQuanHan]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DocGiaMuonQuanHan]
AS
BEGIN
	SELECT DocGia = Ten, TenTuaSach, STT, LanXB, KhoGiay, SoTrang, NhaXB, Gia, DiaCD, NgayMuon, SoNgayTreHan = DATEDIFF(DAY, NgayMuon, CAST(GETDATE() AS DATE))
	FROM TuaSach AS TS INNER JOIN LanXuatBan AS LXB ON TS.IDTuaSach = LXB.IDTuaSach
		 INNER JOIN CuonSach AS CS ON CS.IDLXB = LXB.IDLXB
		 INNER JOIN (SELECT IDCuonSach, SoThe, NgayMuon FROM CTMuonSach WITH(INDEX(IX_NgayMuon)) WHERE NgayTra IS NULL) AS CTM 
					ON CS.IDCuonSach = CTM.IDCuonSach
		 INNER JOIN DocGia AS DG ON CTM.SoThe = DG.SoThe
END
GO
/****** Object:  StoredProcedure [dbo].[HieuChinhBTC]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HieuChinhBTC]
@idkxb int,
@idbtc int,
@lanXB int,
@SoLuongNhap int
AS
BEGIN
	
	DECLARE @SoLuongMuon INT
	SELECT @SoLuongMuon = (SELECT COUNT(IDKyXB) FROM CTMuonBaoTapChi WHERE IDKyXB = @idkxb)

	IF(@SoLuongNhap < @SoLuongMuon)
	BEGIN
		RETURN 0
	END
	ELSE
	BEGIN
		UPDATE KyXuatBan
		SET SoLuongNhap = @SoLuongNhap,
			SoLuongTon = @SoLuongNhap - @SoLuongMuon,
			LanXB = @lanXB
		WHERE IDKyXuatBan = @idkxb
			
		RETURN 1
	END
END
GO
/****** Object:  StoredProcedure [dbo].[HieuChinhLanXB]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HieuChinhLanXB]
@idLXB int,
@lxb int,
@namXB date,
@khoGiay nchar(10),
@soTrang int,
@nhaXB nvarchar(50),
@gia float,
@diaCD int
AS
BEGIN
	UPDATE LanXuatBan
	SET  LanXB = @lxb, NamXB = @namXB, KhoGiay = @khoGiay, SoTrang = @soTrang, NhaXB = @nhaXB, Gia = @gia, DiaCD = @diaCD
	WHERE IDLXB = @idLXB
END
GO
/****** Object:  StoredProcedure [dbo].[SachDangChoMuon]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SachDangChoMuon]
AS
BEGIN
	SELECT TenTuaSach, STT, LanXB, KhoGiay, SoTrang, NhaXB, Gia, DiaCD, NguoiMuon = Ten, NgayMuon
	FROM TuaSach AS TS INNER JOIN LanXuatBan AS LXB ON TS.IDTuaSach = LXB.IDTuaSach
		 INNER JOIN CuonSach AS CS ON CS.IDLXB = LXB.IDLXB
		 INNER JOIN (SELECT IDCuonSach, SoThe, NgayMuon FROM CTMuonSach WITH(INDEX(IX_NgayMuon)) WHERE NgayTra IS NULL) AS CTM ON CS.IDCuonSach = CTM.IDCuonSach
		 INNER JOIN DocGia AS DG ON CTM.SoThe = DG.SoThe
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_BTC]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHECK_BTC] @IDBTC INT
AS
SELECT RESULT = 1 
WHERE EXISTS(SELECT IDBTC FROM BaoTapChi WHERE IDBTC=@IDBTC)
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_CUON_SACH]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHECK_CUON_SACH] @IDSACH INT
AS
SELECT RESULT = 1 
WHERE EXISTS(SELECT IDCuonSach FROM CuonSach WHERE IDCuonSach=@IDSACH)
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_MA_TAI_LIEU]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHECK_MA_TAI_LIEU] @MATL varchar
AS
SELECT RESULT = 1 
WHERE EXISTS(SELECT MaTaiLieu FROM TaiLieu WHERE MaTaiLieu=@MATL)
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECK_SO_THE]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHECK_SO_THE] @SOTHE INT
AS
SELECT RESULT = 1 
WHERE EXISTS(SELECT SoThe FROM DocGia WHERE SoThe=@SOTHE)
GO
/****** Object:  StoredProcedure [dbo].[SP_CREATE_ACCOUNT]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CREATE_ACCOUNT] 
@LOGINNAME VARCHAR(50), @PASSWORD VARCHAR(50), 
@USERNAME VARCHAR(50)
AS

	DECLARE @RESULT INT
	EXEC @RESULT = sp_addlogin @LOGINNAME, @PASSWORD, 'QuanLyThuVien'
	IF (@RESULT = 1)
	BEGIN
		RAISERROR(N'Tên đăng nhập đã tồn tại!', 16, 1)
		RETURN
	END

	EXEC @RESULT = sp_grantdbaccess @LOGINNAME, @USERNAME

	EXEC sp_addrolemember 'DocGia', @USERNAME
GO
/****** Object:  StoredProcedure [dbo].[SP_CTSach]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CTSach] @CTSach TYPE_CTSach READONLY
AS
BEGIN

	MERGE INTO CTSach AS TAR
	USING (SELECT MaTacGia, IDTuaSach FROM @CTSach) AS SOURC
	ON TAR.MaTacGia = SOURC.MaTacGia AND TAR.IDTuaSach = SOURC.IDTuaSach
	WHEN NOT MATCHED THEN
		INSERT (MaTacGia, IDTuaSach)
			VALUES (SOURC.MaTacGia, SOURC.IDTuaSach);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_BAO_CO_THE_MUON]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_BAO_CO_THE_MUON]
@SOTHE int=0
AS
BEGIN
	SELECT KyXuatBan.IDKyXuatBan, NamPhatHanh, DinhKy, NhaXB, LanXB 
	FROM BaoTapChi, KyXuatBan
	WHERE BaoTapChi.IDBTC=KyXuatBan.IDBTC AND KyXuatBan.SoLuongTon>0 AND KyXuatBan.IDKyXuatBan NOT IN 
	(SELECT IDKyXB FROM CTMuonBaoTapChi WHERE SoThe = @SOTHE AND NgayTra IS NULL)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_CTMUONBAO]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_GET_CTMUONBAO]
@MATHE int = 0
AS
BEGIN
	SELECT * FROM CTMuonBaoTapChi WHERE @MATHE=0 OR @MATHE=CTMuonBaoTapChi.SoThe
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_CTMUONSACH]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_CTMUONSACH]
@MATHE int = 0
AS
BEGIN
	SELECT * FROM CTMuonSach WHERE @MATHE=0 OR @MATHE=CTMuonSach.SoThe
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_READER]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_READER]
AS
SELECT TEN FROM DocGia
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_READER_INFO]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GET_READER_INFO] 
@TENLOGIN NVARCHAR (50)
AS
BEGIN
	DECLARE @TENUSER NVARCHAR(50)
	DECLARE @TENNHOM NVARCHAR(50)
	SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
	 
	SELECT @TENNHOM= NAME
	   FROM sys.sysusers 
	   WHERE UID = (SELECT GROUPUID 
					 FROM SYS.SYSMEMBERS 
					   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
										  WHERE NAME=@TENUSER))
	SELECT @TENUSER, TEN=(CASE WHEN @TENNHOM like'DocGia' 
	THEN (SELECT TEN FROM DocGia  WHERE SOTHE = @TENUSER ) ELSE @TENLOGIN END),
	@TENNHOM
END
GO
/****** Object:  StoredProcedure [dbo].[SP_REMOVE_ACCOUNT]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REMOVE_ACCOUNT] @LOGIN_NAME VARCHAR(50), @USER_NAME VARCHAR(50)
AS
	IF (NOT EXISTS(SELECT 1 FROM sys.sysusers WHERE sid = SUSER_SID(@LOGIN_NAME) AND name = @USER_NAME))
	BEGIN
		RAISERROR(N'Tài khoản không tồn tại!', 16, 1)
		RETURN
	END

	DECLARE @RESULT INT
	EXEC @RESULT = sp_droplogin @LOGIN_NAME
	IF(@RESULT = 1)
	BEGIN
		DECLARE @ERROR NVARCHAR(2000)
		SELECT @ERROR = N'Lỗi thực thi: ' + ERROR_MESSAGE()
		RAISERROR(@ERROR, 16, 1)
		RETURN
	END

	EXEC sp_dropuser @USER_NAME
GO
/****** Object:  StoredProcedure [dbo].[SP_THEM_MUON_SACH]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THEM_MUON_SACH]
@SOTHE int,
@IDCUONSACH int,
@NGAYMUON Date
AS
BEGIN
	MERGE CTMuonSach 
	USING (VALUES (@SOTHE, @IDCUONSACH, @NGAYMUON)) AS s(sothe, idcuonsach, ngaymuon)
	ON s.sothe=CTMuonSach.SoThe AND s.idcuonsach= CTMuonSach.IDCuonSach AND s.ngaymuon = CTMuonSach.NgayMuon
	WHEN MATCHED THEN UPDATE SET NgayTra=GETDATE()
	WHEN NOT MATCHED THEN
		INSERT (SoThe, IDCuonSach, NgayMuon) 
		VALUES (@SOTHE, @IDCUONSACH, @NGAYMUON);
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TOP10_MuonBTC]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TOP10_MuonBTC]
@DATEFROM DATETIME,
@DATETO DATETIME
AS
BEGIN
	SELECT DISTINCT TOP 10  BTC.IDBTC,BTC.NamPhatHanh,BTC.NhaXB, COUNT(CTMuonBTC.IDKyXB) SOLUONG
	FROM 
	(SELECT DiSTINCT BaoTapChi.IDBTC,NamPhatHanh,BaoTapChi.NhaXB FROM KyXuatBan,BaoTapChi WHERE KyXuatBan.IDBTC=BaoTapChi.IDBTC) BTC,
	(SELECT IDBTC,IDKyXuatBan FROM KyXuatBan,CTMuonBaoTapChi WHERE KyXuatBan.IDKyXuatBan=CTMuonBaoTapChi.IDKyXB) IDLanXuatBan,
	(Select IDKyXB from CTMuonBaoTapChi WHERE NgayMuon BETWEEN @DATEFROM AND @DATETO) CTMuonBTC
	WHERE CTMuonBTC.IDKyXB=IDLanXuatBan.IDKyXuatBan and BTC.IDBTC=IDLanXuatBan.IDBTC
	GROUP BY BTC.IDBTC,BTC.NamPhatHanh,BTC.NhaXB
	order by SOLUONG
END
GO
/****** Object:  StoredProcedure [dbo].[SP_TOP10_MuonSach]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TOP10_MuonSach]
@DATEFROM DATETIME,
@DATETO DATETIME
AS
BEGIN
	SELECT DISTINCT TOP 10 TenSach.TenTuaSach, COUNT(CTMuonSach.IDCuonSach) SOLUONG
	FROM 
	(SELECT DiSTINCT LanXuatBan.IDTuaSach,TenTuaSach,IDLXB FROM TuaSach, LanXuatBan WHERE LanXuatBan.IDTuaSach=TuaSach.IDTuaSach) TenSach,
	(SELECT IDCuonSach,IDLXB FROM CuonSach) IDLanXuatBan,
	(Select IDCuonSach from CTMuonSach WHERE NgayMuon BETWEEN @DATEFROM AND @DATETO) CTMuonSach
	WHERE CTMuonSach.IDCuonSach=IDLanXuatBan.IDCuonSach and TenSach.IDLXB=IDLanXuatBan.IDLXB
	GROUP BY TenSach.TenTuaSach
	order by SOLUONG
END
GO
/****** Object:  StoredProcedure [dbo].[Them_Cuon_Sach]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Them_Cuon_Sach]
@idLXB int,
@tinhTrang nchar(10)
AS
BEGIN
	DECLARE @stt int
	IF EXISTS (SELECT STT FROM CuonSach WHERE IDLXB = @idLXB)
	BEGIN
		SELECT @stt = (SELECT MAX(STT) FROM CuonSach WHERE IDLXB = @idLXB)
	END
	ELSE
	BEGIN
		SELECT @stt = 0
	END

	INSERT INTO CuonSach(STT, IDLXB, TinhTrang)
	VALUES(@stt + 1, @idLXB, @tinhTrang)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemKyXuatBan]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemKyXuatBan]
@idbtc int,
@lxb int,
@SoLuongNhap int
AS
BEGIN
	--DECLARE @lxb int
	DECLARE @SoLuongTon int
	SELECT @SoLuongTon = @SoLuongNhap
	--IF NOT EXISTS (SELECT LanXB FROM KyXuatBan WHERE IDBTC = @idbtc)
	--BEGIN
	--	SELECT @lxb = 1
	--END
	--ELSE
	--BEGIN
	--	SELECT @lxb = (SELECT MAX(LanXB) + 1 FROM KyXuatBan WHERE IDBTC = @idbtc)
	--END
	
	INSERT INTO KyXuatBan(SoLuongNhap, SoLuongTon, IDBTC, LanXB)
	VALUES(@SoLuongNhap, @SoLuongTon, @idbtc, @lxb)
END
GO
/****** Object:  StoredProcedure [dbo].[ThemLanXuatBan]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemLanXuatBan]
@lxb int,
@IDTuaSach int,
@NamXB date,
@KhoGiay nchar(10),
@SoTrang int,
@NhaXB nvarchar(50),
@Gia float,
@DiaCD bit
AS
BEGIN	
	--DECLARE @lxb int
	--IF EXISTS (SELECT LanXB FROM LanXuatBan WHERE IDTuaSach = @IDTuaSach)
	--BEGIN
	--	SELECT @lxb = (SELECT MAX(LanXB) FROM LanXuatBan WHERE IDTuaSach = @IDTuaSach)
	--END
	--ELSE
	--BEGIN
	--	SELECT @lxb = 0
	--END

	INSERT INTO LanXuatBan(LanXB, IDTuaSach, NamXB, KhoGiay, SoTrang, NhaXB, Gia, DiaCD)
	VALUES(@lxb, @IDTuaSach, @NamXB, @KhoGiay, @SoTrang, @NhaXB, @Gia, @DiaCD)

END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_MUON_BAO]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATE_MUON_BAO]
@SOTHE int,
@IDKyXB int,
@NGAYMUON Date
AS
BEGIN
	MERGE CTMuonBaoTapChi
	USING (VALUES (@SOTHE, @IDKyXB, @NGAYMUON)) AS s(sothe, idkyxb, ngaymuon)
	ON s.sothe=CTMuonBaoTapChi.SoThe AND s.idkyxb= CTMuonBaoTapChi.IDKyXB AND s.ngaymuon = CTMuonBaoTapChi.NgayMuon
	WHEN MATCHED THEN UPDATE SET NgayTra=GETDATE()
	WHEN NOT MATCHED THEN
		INSERT (SoThe, IDKyXB, NgayMuon) 
		VALUES (@SOTHE, @IDKyXB, @NGAYMUON);
END
GO
/****** Object:  StoredProcedure [dbo].[XoaTacGiaTuaSach]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaTacGiaTuaSach]
@idTuaSach int
AS
BEGIN
	SELECT TG.MaTacGia, TenTacGia, NamSinh 
	FROM TacGia AS TG INNER JOIN CTSach ON TG.MaTacGia = CTSach.MaTacGia
	WHERE IDTuaSach = @idTuaSach
END
GO
/****** Object:  Trigger [dbo].[trg_SluongBao]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_SluongBao] ON [dbo].[CTMuonBaoTapChi] AFTER INSERT AS 
BEGIN
	UPDATE KyXuatBan
	SET SoLuongTon = SoLuongTon - 1
	WHERE (SELECT IDKyXB FROM inserted) = KyXuatBan.IDKyXuatBan
END
GO
ALTER TABLE [dbo].[CTMuonBaoTapChi] ENABLE TRIGGER [trg_SluongBao]
GO
/****** Object:  Trigger [dbo].[trg_TraBao]    Script Date: 7/10/2023 4:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_TraBao] ON [dbo].[CTMuonBaoTapChi] AFTER UPDATE AS 
BEGIN
	UPDATE KyXuatBan
	SET SoLuongTon = SoLuongTon + 1
	WHERE (SELECT IDKyXB FROM inserted) = KyXuatBan.IDKyXuatBan AND (SELECT NgayTra FROM deleted) IS NULL
END
GO
ALTER TABLE [dbo].[CTMuonBaoTapChi] ENABLE TRIGGER [trg_TraBao]
GO

GRANT EXECUTE ON [dbo].[SP_GET_READER_INFO] TO [DocGia]
GRANT EXECUTE ON [dbo].[UPDATE_MUON_BAO] TO [DocGia]
GRANT EXECUTE ON [dbo].[SP_GET_CTMUONBAO] TO [DocGia]
GRANT EXECUTE ON [dbo].[SP_THEM_MUON_SACH] TO [DocGia]
GRANT EXECUTE ON [dbo].[SP_GET_CTMUONSACH] TO [DocGia]
