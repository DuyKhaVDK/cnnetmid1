USE [NET_MidTerm_SpaceTeam]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/18/2020 11:27:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichChieuPhim]    Script Date: 12/18/2020 11:27:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichChieuPhim](
	[MaChieuPhim] [nvarchar](450) NOT NULL,
	[GioCongChieu] [datetime2](7) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaPhim] [int] NOT NULL,
	[MaRap] [int] NOT NULL,
 CONSTRAINT [PK_LichChieuPhim] PRIMARY KEY CLUSTERED 
(
	[MaChieuPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDatVe]    Script Date: 12/18/2020 11:27:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDatVe](
	[MaNguoiDatVe] [int] IDENTITY(1,1) NOT NULL,
	[SoDienThoai] [nvarchar](max) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SoLuongDat] [int] NOT NULL,
	[MaChieuPhim] [nvarchar](450) NULL,
 CONSTRAINT [PK_NguoiDatVe] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDatVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phim]    Script Date: 12/18/2020 11:27:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phim](
	[MaPhim] [int] IDENTITY(1,1) NOT NULL,
	[TenPhim] [nvarchar](100) NOT NULL,
	[ThoiLuong] [float] NOT NULL,
	[NgayCongChieu] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Phim] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rap]    Script Date: 12/18/2020 11:27:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rap](
	[MaRap] [int] IDENTITY(1,1) NOT NULL,
	[TenRap] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
	[SoChoTrong] [int] NOT NULL,
 CONSTRAINT [PK_Rap] PRIMARY KEY CLUSTERED 
(
	[MaRap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201218042532_data1', N'3.1.10')
GO
INSERT [dbo].[LichChieuPhim] ([MaChieuPhim], [GioCongChieu], [SoLuong], [MaPhim], [MaRap]) VALUES (N'BoGia01', CAST(N'2020-03-12T09:00:00.0000000' AS DateTime2), 50, 5, 4)
INSERT [dbo].[LichChieuPhim] ([MaChieuPhim], [GioCongChieu], [SoLuong], [MaPhim], [MaRap]) VALUES (N'GaiGiaLamChieu01', CAST(N'2020-03-12T09:00:00.0000000' AS DateTime2), 50, 4, 3)
INSERT [dbo].[LichChieuPhim] ([MaChieuPhim], [GioCongChieu], [SoLuong], [MaPhim], [MaRap]) VALUES (N'HarryPoter01', CAST(N'2020-03-12T09:00:00.0000000' AS DateTime2), 50, 3, 2)
INSERT [dbo].[LichChieuPhim] ([MaChieuPhim], [GioCongChieu], [SoLuong], [MaPhim], [MaRap]) VALUES (N'IronMan01', CAST(N'2020-03-12T07:00:00.0000000' AS DateTime2), 50, 2, 1)
INSERT [dbo].[LichChieuPhim] ([MaChieuPhim], [GioCongChieu], [SoLuong], [MaPhim], [MaRap]) VALUES (N'IronMan02', CAST(N'2020-03-12T07:00:00.0000000' AS DateTime2), 50, 2, 2)
INSERT [dbo].[LichChieuPhim] ([MaChieuPhim], [GioCongChieu], [SoLuong], [MaPhim], [MaRap]) VALUES (N'TrangQuynh01', CAST(N'2020-03-12T09:00:00.0000000' AS DateTime2), 50, 6, 5)
INSERT [dbo].[LichChieuPhim] ([MaChieuPhim], [GioCongChieu], [SoLuong], [MaPhim], [MaRap]) VALUES (N'TrangQuynh02', CAST(N'2020-03-12T09:00:00.0000000' AS DateTime2), 50, 7, 6)
INSERT [dbo].[LichChieuPhim] ([MaChieuPhim], [GioCongChieu], [SoLuong], [MaPhim], [MaRap]) VALUES (N'WonderWomen01', CAST(N'2020-03-12T09:00:00.0000000' AS DateTime2), 50, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[NguoiDatVe] ON 

INSERT [dbo].[NguoiDatVe] ([MaNguoiDatVe], [SoDienThoai], [DiaChi], [SoLuongDat], [MaChieuPhim]) VALUES (1, N'0344135640', N'106 Nguyễn Tri Phương', 2, N'WonderWomen01')
INSERT [dbo].[NguoiDatVe] ([MaNguoiDatVe], [SoDienThoai], [DiaChi], [SoLuongDat], [MaChieuPhim]) VALUES (2, N'0344135640', N'106 Nguyễn Tri Phương', 20, N'IronMan01')
INSERT [dbo].[NguoiDatVe] ([MaNguoiDatVe], [SoDienThoai], [DiaChi], [SoLuongDat], [MaChieuPhim]) VALUES (3, N'0344135640', N'106 Nguyễn Tri Phương', 1, N'IronMan02')
INSERT [dbo].[NguoiDatVe] ([MaNguoiDatVe], [SoDienThoai], [DiaChi], [SoLuongDat], [MaChieuPhim]) VALUES (4, N'0344135640', N'106 Nguyễn Tri Phương', 12, N'IronMan02')
INSERT [dbo].[NguoiDatVe] ([MaNguoiDatVe], [SoDienThoai], [DiaChi], [SoLuongDat], [MaChieuPhim]) VALUES (5, N'0344135640', N'106 Nguyễn Tri Phương', 2, N'IronMan01')
INSERT [dbo].[NguoiDatVe] ([MaNguoiDatVe], [SoDienThoai], [DiaChi], [SoLuongDat], [MaChieuPhim]) VALUES (6, N'0344135640', N'106 Nguyễn Tri Phương', 1, N'IronMan01')
INSERT [dbo].[NguoiDatVe] ([MaNguoiDatVe], [SoDienThoai], [DiaChi], [SoLuongDat], [MaChieuPhim]) VALUES (7, N'0344135640', N'106 Nguyễn Tri Phương', 2, N'IronMan01')
SET IDENTITY_INSERT [dbo].[NguoiDatVe] OFF
GO
SET IDENTITY_INSERT [dbo].[Phim] ON 

INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (1, N'Wonder Women ', 250, CAST(N'2020-03-12T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (2, N'Iron Man ', 250, CAST(N'2020-03-12T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (3, N'Harry Poster ', 350, CAST(N'2020-03-12T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (4, N'Gái Gìa Lắm Chiêu ', 150, CAST(N'2020-05-06T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (5, N'Bố Gìa ', 300, CAST(N'2020-07-12T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (6, N'Trạng Quỷnh ', 250, CAST(N'2020-07-12T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (7, N'Trạng Quỳnh', 250, CAST(N'2020-07-12T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (8, N'Conan Movie 1', 250, CAST(N'2020-05-06T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (9, N'Conan Movie 2 ', 250, CAST(N'2020-11-24T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (10, N'Conan Movie 3', 250, CAST(N'2020-11-24T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (11, N'Conan Movie 4', 250, CAST(N'2020-11-12T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (12, N'Conan Movie 5', 250, CAST(N'2020-11-12T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (13, N'Wonder Women 2 ', 250, CAST(N'2020-12-12T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [NgayCongChieu]) VALUES (14, N'Wonder Women 3', 250, CAST(N'2020-12-12T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Phim] OFF
GO
SET IDENTITY_INSERT [dbo].[Rap] ON 

INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (1, N'Số 1', N'250 Thành Thái', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (2, N'Số 2', N'250 Thành Thái', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (3, N'Số 3', N'250 Thành Thái', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (4, N'Số 4', N'250 Thành Thái', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (5, N'Số 1A', N'351A Lạc Long Quân Phường 5 Quận 11', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (6, N'Số 2A', N'351A Lạc Long Quân Phường 5 Quận 11', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (7, N'Số 3A', N'351A Lạc Long Quân Phường 5 Quận 11', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (8, N'Số 4A', N'351A Lạc Long Quân Phường 5 Quận 11', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (9, N'Số 1C', N'30C Công Chúa Ngọc Hân Phường 2 Quận 11', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (10, N'Số 2C', N'30C Công Chúa Ngọc Hân Phường 2 Quận 11', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (11, N'Số 3C', N'30C Công Chúa Ngọc Hân Phường 2 Quận 11', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (12, N'Số 4C', N'30C Công Chúa Ngọc Hân Phường 2 Quận 11', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (13, N'Số 1B', N'344B An Dương Vương Phường 10 Quận ', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (14, N'Số 2B', N'344B An Dương Vương Phường 10 Quận', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (15, N'Số 3B', N'344B An Dương Vương Phường 10 Quận1', 50)
INSERT [dbo].[Rap] ([MaRap], [TenRap], [DiaChi], [SoChoTrong]) VALUES (16, N'Số 4B', N'344B An Dương Vương Phường 10 Quận', 50)
SET IDENTITY_INSERT [dbo].[Rap] OFF
GO
ALTER TABLE [dbo].[LichChieuPhim]  WITH CHECK ADD  CONSTRAINT [FK_LichChieuPhim_Phim_MaPhim] FOREIGN KEY([MaPhim])
REFERENCES [dbo].[Phim] ([MaPhim])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichChieuPhim] CHECK CONSTRAINT [FK_LichChieuPhim_Phim_MaPhim]
GO
ALTER TABLE [dbo].[LichChieuPhim]  WITH CHECK ADD  CONSTRAINT [FK_LichChieuPhim_Rap_MaRap] FOREIGN KEY([MaRap])
REFERENCES [dbo].[Rap] ([MaRap])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LichChieuPhim] CHECK CONSTRAINT [FK_LichChieuPhim_Rap_MaRap]
GO
ALTER TABLE [dbo].[NguoiDatVe]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDatVe_LichChieuPhim_MaChieuPhim] FOREIGN KEY([MaChieuPhim])
REFERENCES [dbo].[LichChieuPhim] ([MaChieuPhim])
GO
ALTER TABLE [dbo].[NguoiDatVe] CHECK CONSTRAINT [FK_NguoiDatVe_LichChieuPhim_MaChieuPhim]
GO
