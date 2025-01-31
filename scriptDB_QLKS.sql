USE [master]
GO
/****** Object:  Database [PMQLKS]    Script Date: 6/15/2023 12:31:02 AM ******/
CREATE DATABASE [PMQLKS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PMQLKS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PMQLKS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PMQLKS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\PMQLKS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PMQLKS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PMQLKS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PMQLKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PMQLKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PMQLKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PMQLKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PMQLKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [PMQLKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PMQLKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PMQLKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PMQLKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PMQLKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PMQLKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PMQLKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PMQLKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PMQLKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PMQLKS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PMQLKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PMQLKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PMQLKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PMQLKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PMQLKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PMQLKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PMQLKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PMQLKS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PMQLKS] SET  MULTI_USER 
GO
ALTER DATABASE [PMQLKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PMQLKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PMQLKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PMQLKS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PMQLKS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PMQLKS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PMQLKS] SET QUERY_STORE = ON
GO
ALTER DATABASE [PMQLKS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PMQLKS]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 6/15/2023 12:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[TenBooking] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 6/15/2023 12:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ChiTietHoaDonID] [int] IDENTITY(1,1) NOT NULL,
	[HoaDonID] [int] NULL,
	[DichVuID] [int] NULL,
	[GiaDV] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ChiTietHoaDonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 6/15/2023 12:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[DichVuID] [int] IDENTITY(1,1) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[GiaDV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DichVuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/15/2023 12:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
    [HoaDonID] [int] IDENTITY(1,1) NOT NULL,
    [NhanVienID] [int] NULL,
    [KhachHangID] [int] NULL,
    [PhongID] [int] NULL,
    [TenLoai] [varchar](15) NULL,
    [SoDem] AS DATEDIFF(day, [dateCheckIn], [dateCheckOut]) NULL,
    [SoKhach] [int] NULL,
    [NgayHD] [varchar](15) NULL,
    [TongTien] [int] NULL,
    [TenBooking] [nvarchar](50) NULL,
    [dateCheckIn] [date] NULL,
    [dateCheckOut] [date] NULL
);
PRIMARY KEY CLUSTERED 
(
	[HoaDonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/15/2023 12:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[KhachHangID] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[QuocTich] [varchar](50) NULL,
	[SDT] [varchar](10) NULL,
	[CCCD] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[KhachHangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichLamViec]    Script Date: 6/15/2023 12:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichLamViec](
	[LichLamViecID] [int] IDENTITY(1,1) NOT NULL,
	[NhanVienID] [int] NULL,
	[Ca] [nvarchar](10) NULL,
	[Ngay] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[LichLamViecID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 6/15/2023 12:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[LoaiPhongID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [varchar](15) NULL,
	[GiaLoaiPhong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[LoaiPhongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatKhau]    Script Date: 6/15/2023 12:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatKhau](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/15/2023 12:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[NhanVienID] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[PathImage] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[NhanVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 6/15/2023 12:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[PhongID] [int] IDENTITY(1,1) NOT NULL,
	[LoaiPhongID] [int] NULL,
	[GiaPhong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PhongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VatTu]    Script Date: 6/15/2023 12:31:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatTu](
	[VatTuID] [int] IDENTITY(1,1) NOT NULL,
	[TenVT] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[VatTuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (1, N'Agoda')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (2, N'Travel Loka')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (3, N'Booking.com')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (4, N'Expedia')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (5, N'AirBnB')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (6, N'Khách Tự Đến')
INSERT [dbo].[Booking] ([BookingID], [TenBooking]) VALUES (7, N'Khách Đối Tác')
SET IDENTITY_INSERT [dbo].[Booking] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (1, 1, 1, 30000, 2, 60000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (2, 1, 1, 30000, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (3, 1, 1, 30000, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (4, 1, 1, 30000, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (5, 1, 2, 15000, 3, 45000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (6, 1, 2, 15000, 2, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (7, 1, 1, 30000, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (8, 1, 1, 30000, 1, 30000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (9, 1, 2, 15000, 1, 15000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (10, 1, 8, 200000, 1, 200000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (11, 1, 7, 485000, 1, 485000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (12, 1, 2, 15000, 1, 15000)
INSERT [dbo].[ChiTietHoaDon] ([ChiTietHoaDonID], [HoaDonID], [DichVuID], [GiaDV], [SoLuong], [ThanhTien]) VALUES (13, 1, 1, 30000, 1, 30000)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[DichVu] ON 

INSERT [dbo].[DichVu] ([DichVuID], [TenDV], [GiaDV]) VALUES (1, N'fanta', 30000)
INSERT [dbo].[DichVu] ([DichVuID], [TenDV], [GiaDV]) VALUES (2, N'trà xanh', 15000)
INSERT [dbo].[DichVu] ([DichVuID], [TenDV], [GiaDV]) VALUES (3, N'bò cụng', 15000)
INSERT [dbo].[DichVu] ([DichVuID], [TenDV], [GiaDV]) VALUES (7, N'tour củ chi', 485000)
INSERT [dbo].[DichVu] ([DichVuID], [TenDV], [GiaDV]) VALUES (8, N'tiễn sân bay', 200000)
INSERT [dbo].[DichVu] ([DichVuID], [TenDV], [GiaDV]) VALUES (9, N'tra', 2000)
SET IDENTITY_INSERT [dbo].[DichVu] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [TenBooking], [dateCheckIn], [dateCheckOut]) VALUES (2023, NULL, 3046, 7, NULL, NULL, 4, NULL, NULL, N'Travel Loka', CAST(N'2023-06-16' AS Date), CAST(N'2023-06-21' AS Date))
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [TenBooking], [dateCheckIn], [dateCheckOut]) VALUES (2024, NULL, 3047, 2, NULL, NULL, 3, NULL, NULL, N'AirBnB', CAST(N'2023-06-15' AS Date), CAST(N'2023-06-24' AS Date))
INSERT [dbo].[HoaDon] ([HoaDonID], [NhanVienID], [KhachHangID], [PhongID], [TenLoai], [SoDem], [SoKhach], [NgayHD], [TongTien], [TenBooking], [dateCheckIn], [dateCheckOut]) VALUES (2025, NULL, 3048, 1, NULL, NULL, 1, NULL, NULL, N'Travel Loka', CAST(N'2023-06-15' AS Date), CAST(N'2023-06-16' AS Date))
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich], [SDT], [CCCD], [Email]) VALUES (3046, N'Nguyễn Thị Mơ Hồ', NULL, N'0248452155', N'083164922055', N'mohoquadi@gmail.com')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich], [SDT], [CCCD], [Email]) VALUES (3047, N'Hà Chu', NULL, N'0787869551', N'031234567893', N'hachuworks@gmail.com')
INSERT [dbo].[KhachHang] ([KhachHangID], [TenKH], [QuocTich], [SDT], [CCCD], [Email]) VALUES (3051, N'Hoàng Nguyên', N'vn', N'0784563214', N'0812345678', NULL)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[LichLamViec] ON 

INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (1, 1, N'sáng', N'10/10/2023')
INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (2, 2, N'trưa', N'10/10/2023')
INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (3, 3, N'tối', N'10/10/2023')
INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (6, 8, N'sáng', N'11/10/2023')
INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (7, 9, N'trưa', N'11/10/2022')
INSERT [dbo].[LichLamViec] ([LichLamViecID], [NhanVienID], [Ca], [Ngay]) VALUES (8, 1, N'sáng', N'12/10/2022')
SET IDENTITY_INSERT [dbo].[LichLamViec] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON 

INSERT [dbo].[LoaiPhong] ([LoaiPhongID], [TenLoai], [GiaLoaiPhong]) VALUES (1, N'Standard', 500000)
INSERT [dbo].[LoaiPhong] ([LoaiPhongID], [TenLoai], [GiaLoaiPhong]) VALUES (2, N'Deluxe', 1000000)
INSERT [dbo].[LoaiPhong] ([LoaiPhongID], [TenLoai], [GiaLoaiPhong]) VALUES (3, N'Superior', 700000)
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
GO
INSERT [dbo].[MatKhau] ([username], [password]) VALUES (N'123', N'1')
INSERT [dbo].[MatKhau] ([username], [password]) VALUES (N'admin', N'admin')
INSERT [dbo].[MatKhau] ([username], [password]) VALUES (N'hoangnam', N'hoangnam')
INSERT [dbo].[MatKhau] ([username], [password]) VALUES (N'quocviet', N'quocviet')
INSERT [dbo].[MatKhau] ([username], [password]) VALUES (N'thuhang', N'thuhang')
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (1, N'Hữu Đạt', N'1.jpg')
INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (2, N'Phương', N'2.jpg')
INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (3, N'Thủy Tiên', N'3.jpg')
INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (8, N'Thanh Lam', N'4.jpg')
INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (9, N'Văn B', NULL)
INSERT [dbo].[NhanVien] ([NhanVienID], [TenNV], [PathImage]) VALUES (11, N'Văn C', NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[Phong] ON 

INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (1, 2, 1000000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (2, 1, 500000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (3, 1, 500000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (4, 3, 700000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (5, 3, 700000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (6, 2, 1000000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (7, 2, 1000000)
INSERT [dbo].[Phong] ([PhongID], [LoaiPhongID], [GiaPhong]) VALUES (8, 2, 1000000)
SET IDENTITY_INSERT [dbo].[Phong] OFF
GO
SET IDENTITY_INSERT [dbo].[VatTu] ON 

INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (3, N'Bàn Ủi')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (4, N'Dép')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (5, N'Bàn Gỗ')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (11, N'Thùng Rác')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (14, N'Bàn Ủi')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (17, N'Tivi')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (18, N'tủ lạnh')
INSERT [dbo].[VatTu] ([VatTuID], [TenVT]) VALUES (19, N'Tách Trà')
SET IDENTITY_INSERT [dbo].[VatTu] OFF
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([DichVuID])
REFERENCES [dbo].[DichVu] ([DichVuID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH NOCHECK ADD FOREIGN KEY([HoaDonID])
REFERENCES [dbo].[HoaDon] ([HoaDonID])
GO
ALTER TABLE [dbo].[HoaDon]  WITH NOCHECK ADD FOREIGN KEY([KhachHangID])
REFERENCES [dbo].[KhachHang] ([KhachHangID])
GO
ALTER TABLE [dbo].[HoaDon]  WITH NOCHECK ADD FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NhanVien] ([NhanVienID])
GO
ALTER TABLE [dbo].[HoaDon]  WITH NOCHECK ADD FOREIGN KEY([PhongID])
REFERENCES [dbo].[Phong] ([PhongID])
GO
ALTER TABLE [dbo].[LichLamViec]  WITH CHECK ADD FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[NhanVien] ([NhanVienID])
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong] FOREIGN KEY([LoaiPhongID])
REFERENCES [dbo].[LoaiPhong] ([LoaiPhongID])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong]
GO
USE [master]
GO
ALTER DATABASE [PMQLKS] SET  READ_WRITE 
GO
