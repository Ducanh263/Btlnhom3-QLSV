USE [master]
GO
/****** Object:  Database [Quanlysinhvienhumg]    Script Date: 5/28/2024 11:35:19 AM ******/
CREATE DATABASE [Quanlysinhvienhumg]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quanlysinhvienhumg', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSEVER\MSSQL\DATA\Quanlysinhvienhumg.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Quanlysinhvienhumg_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSEVER\MSSQL\DATA\Quanlysinhvienhumg_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Quanlysinhvienhumg] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quanlysinhvienhumg].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quanlysinhvienhumg] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET RECOVERY FULL 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET  MULTI_USER 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quanlysinhvienhumg] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quanlysinhvienhumg] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Quanlysinhvienhumg', N'ON'
GO
ALTER DATABASE [Quanlysinhvienhumg] SET QUERY_STORE = ON
GO
ALTER DATABASE [Quanlysinhvienhumg] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Quanlysinhvienhumg]
GO
USE [Quanlysinhvienhumg]
GO
/****** Object:  Sequence [dbo].[sinhvienSeq]    Script Date: 5/28/2024 11:35:19 AM ******/
CREATE SEQUENCE [dbo].[sinhvienSeq] 
 AS [bigint]
 START WITH 1000
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tentaikhoan] [varchar](50) NOT NULL,
	[matkhau] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[tentaikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDiem]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDiem](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhap] [datetime] NULL,
	[nguoicapnhap] [varchar](30) NULL,
	[masinhvien] [varchar](50) NOT NULL,
	[malophoc] [bigint] NOT NULL,
	[lanhoc] [int] NULL,
	[diemc] [float] NULL,
	[diemb] [float] NULL,
	[diema] [float] NULL,
 CONSTRAINT [PK_tblDiem] PRIMARY KEY CLUSTERED 
(
	[masinhvien] ASC,
	[malophoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDiemDanh]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDiemDanh](
	[ngayhientai] [datetime] NULL,
	[malophoc] [bigint] NULL,
	[diemdanh] [int] NOT NULL,
	[masinhvien] [varchar](50) NULL,
	[nguoitao] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDiemDanhvalue]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDiemDanhvalue](
	[trangthai] [nvarchar](20) NULL,
	[diemdanh] [int] NOT NULL,
 CONSTRAINT [PK_tblDiemDanhvalue] PRIMARY KEY CLUSTERED 
(
	[diemdanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGiangVien]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiangVien](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhap] [datetime] NULL,
	[nguoicapnhap] [varchar](30) NULL,
	[magiaovien] [int] IDENTITY(1,1) NOT NULL,
	[matkhau] [varchar](50) NULL,
	[ho] [nvarchar](10) NOT NULL,
	[tendem] [nvarchar](20) NULL,
	[ten] [nvarchar](10) NOT NULL,
	[gioitinh] [tinyint] NULL,
	[ngaysinh] [date] NULL,
	[dienthoai] [varchar](30) NULL,
	[email] [varchar](150) NULL,
	[diachi] [nvarchar](150) NULL,
 CONSTRAINT [PK_tblGiangVien] PRIMARY KEY CLUSTERED 
(
	[magiaovien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhoa]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhoa](
	[MaKhoa] [int] IDENTITY(1,1) NOT NULL,
	[TenKhoa] [nvarchar](30) NULL,
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhap] [datetime] NULL,
	[nguoicapnhap] [varchar](30) NULL,
 CONSTRAINT [PK_tblKhoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLichThi]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLichThi](
	[mamonhoc] [int] NULL,
	[masinhvien] [varchar](50) NULL,
	[magiaovien] [int] NULL,
	[ngaythi] [datetime] NULL,
	[cathi] [int] NULL,
	[tenphongthi] [varchar](30) NULL,
	[trangthai] [tinyint] NULL,
	[hinhthucthi] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLop]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLop](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhap] [datetime] NULL,
	[nguoicapnhap] [varchar](30) NULL,
	[malophoc] [bigint] IDENTITY(1,1) NOT NULL,
	[mamonhoc] [int] NOT NULL,
	[magiaovien] [int] NOT NULL,
	[daketthuc] [tinyint] NULL,
	[tietbatdau] [int] NULL,
	[ngayhoc] [int] NULL,
	[maphonghoc] [int] NULL,
	[modangky] [tinyint] NULL,
 CONSTRAINT [PK_tblLop_1] PRIMARY KEY CLUSTERED 
(
	[malophoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLopHoc]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLopHoc](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[Manganh] [int] NULL,
	[KhoaHoc] [bigint] NULL,
	[Hedaotao] [nvarchar](20) NULL,
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhap] [datetime] NULL,
	[nguoicapnhap] [varchar](30) NULL,
	[Namnhaphoc] [varchar](50) NULL,
 CONSTRAINT [PK_tblLopHoc] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMonHoc]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMonHoc](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhap] [datetime] NULL,
	[nguoicapnhap] [varchar](30) NULL,
	[mamonhoc] [int] IDENTITY(1,1) NOT NULL,
	[tenmonhoc] [nvarchar](150) NOT NULL,
	[sotinchi] [int] NULL,
 CONSTRAINT [PK_tblMonHoc] PRIMARY KEY CLUSTERED 
(
	[mamonhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNganh]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNganh](
	[Manganh] [int] IDENTITY(1,1) NOT NULL,
	[Tennganh] [nvarchar](20) NULL,
	[MaKhoa] [int] NULL,
	[ngaytao] [datetime] NULL,
	[ngaycapnhap] [datetime] NULL,
	[nguoicapnhap] [varchar](30) NULL,
	[nguoitao] [varchar](30) NULL,
 CONSTRAINT [PK_tblNganh] PRIMARY KEY CLUSTERED 
(
	[Manganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhongHoc]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhongHoc](
	[maphonghoc] [int] NOT NULL,
	[tenphonghoc] [varchar](10) NULL,
	[succhua] [bigint] NULL,
 CONSTRAINT [PK_tblPhongHoc] PRIMARY KEY CLUSTERED 
(
	[maphonghoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 5/28/2024 11:35:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[ngaytao] [datetime] NULL,
	[nguoitao] [varchar](30) NULL,
	[ngaycapnhap] [datetime] NULL,
	[nguoicapnhap] [varchar](30) NULL,
	[masinhvien] [varchar](50) NOT NULL,
	[ho] [nvarchar](10) NOT NULL,
	[tendem] [nvarchar](20) NULL,
	[ten] [nvarchar](10) NOT NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [tinyint] NULL,
	[quequan] [nvarchar](150) NULL,
	[diachi] [nvarchar](150) NULL,
	[dienthoai] [varchar](30) NULL,
	[email] [varchar](150) NULL,
	[matkhau] [varchar](50) NULL,
	[MaLop] [int] NULL,
 CONSTRAINT [PK_tblSinhVien] PRIMARY KEY CLUSTERED 
(
	[masinhvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([tentaikhoan], [matkhau]) VALUES (N'admin', N'admin')
GO
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [malophoc], [lanhoc], [diemc], [diemb], [diema]) VALUES (CAST(N'2024-05-28T11:19:45.497' AS DateTime), N'HUMG1002', CAST(N'2024-05-28T11:19:45.497' AS DateTime), N'admin', N'HUMG1002', 6, 1, 0, 0, 0)
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [malophoc], [lanhoc], [diemc], [diemb], [diema]) VALUES (CAST(N'2024-05-28T11:06:31.880' AS DateTime), N'HUMG1005', CAST(N'2024-05-28T11:07:16.260' AS DateTime), N'4', N'HUMG1005', 2, 1, 10, 10, 10)
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [malophoc], [lanhoc], [diemc], [diemb], [diema]) VALUES (CAST(N'2024-05-28T11:06:34.487' AS DateTime), N'HUMG1005', CAST(N'2024-05-28T11:06:34.487' AS DateTime), N'admin', N'HUMG1005', 5, 1, 0, 0, 0)
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [malophoc], [lanhoc], [diemc], [diemb], [diema]) VALUES (CAST(N'2024-05-28T11:06:40.317' AS DateTime), N'HUMG1005', CAST(N'2024-05-28T11:06:40.317' AS DateTime), N'admin', N'HUMG1005', 6, 1, 0, 0, 0)
INSERT [dbo].[tblDiem] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [malophoc], [lanhoc], [diemc], [diemb], [diema]) VALUES (CAST(N'2024-05-28T11:06:43.417' AS DateTime), N'HUMG1005', CAST(N'2024-05-28T11:06:43.417' AS DateTime), N'admin', N'HUMG1005', 7, 1, 0, 0, 0)
GO
INSERT [dbo].[tblDiemDanh] ([ngayhientai], [malophoc], [diemdanh], [masinhvien], [nguoitao]) VALUES (CAST(N'2024-05-28T11:08:22.857' AS DateTime), 6, 1, N'HUMG1005', N'1')
GO
INSERT [dbo].[tblDiemDanhvalue] ([trangthai], [diemdanh]) VALUES (N'DH', 0)
INSERT [dbo].[tblDiemDanhvalue] ([trangthai], [diemdanh]) VALUES (N'V', 1)
INSERT [dbo].[tblDiemDanhvalue] ([trangthai], [diemdanh]) VALUES (N'VP', 2)
GO
SET IDENTITY_INSERT [dbo].[tblGiangVien] ON 

INSERT [dbo].[tblGiangVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [magiaovien], [matkhau], [ho], [tendem], [ten], [gioitinh], [ngaysinh], [dienthoai], [email], [diachi]) VALUES (CAST(N'2024-05-07T17:23:36.260' AS DateTime), N'admin', CAST(N'2024-05-07T17:23:36.260' AS DateTime), N'admin', 1, N'1', N'Phạm', N'Văn', N'Đồng', 1, CAST(N'1992-12-12' AS Date), N'101100223', N'phamvandong@gmail.com', N'Hà Nội')
INSERT [dbo].[tblGiangVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [magiaovien], [matkhau], [ho], [tendem], [ten], [gioitinh], [ngaysinh], [dienthoai], [email], [diachi]) VALUES (CAST(N'2024-05-07T20:01:55.023' AS DateTime), N'admin', CAST(N'2024-05-08T16:32:34.110' AS DateTime), N'admin', 2, N'123', N'Trần ', N'Trường', N'Giang', 1, CAST(N'1993-12-12' AS Date), N'0099238234', N'trantruonggiang@gmail.com', N'Hà Nội')
INSERT [dbo].[tblGiangVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [magiaovien], [matkhau], [ho], [tendem], [ten], [gioitinh], [ngaysinh], [dienthoai], [email], [diachi]) VALUES (CAST(N'2024-05-08T16:32:10.050' AS DateTime), N'admin', CAST(N'2024-05-08T16:32:23.923' AS DateTime), N'admin', 3, N'123', N'Đặng', N'Văn ', N'Nam', 1, CAST(N'1990-02-11' AS Date), N'0994848855', N'dangvannam@gmail,com', N'Hà Nội')
INSERT [dbo].[tblGiangVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [magiaovien], [matkhau], [ho], [tendem], [ten], [gioitinh], [ngaysinh], [dienthoai], [email], [diachi]) VALUES (CAST(N'2024-05-08T16:33:28.817' AS DateTime), N'admin', CAST(N'2024-05-16T22:00:43.000' AS DateTime), N'admin', 4, N'123', N'Nguyễn Thị', N'Phương ', N'Bắc', 0, CAST(N'1992-11-11' AS Date), N'0884755445', N'phuongbac@gmail.com', N'Hà Nội')
INSERT [dbo].[tblGiangVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [magiaovien], [matkhau], [ho], [tendem], [ten], [gioitinh], [ngaysinh], [dienthoai], [email], [diachi]) VALUES (CAST(N'2024-05-25T02:58:10.423' AS DateTime), N'admin', CAST(N'2024-05-25T02:58:10.423' AS DateTime), N'admin', 5, N'123', N'Phạm ', N'Thế ', N'Lộc', 1, CAST(N'1993-06-12' AS Date), N'099838823', N'phamtheloc@gmail.com', N'Hà Nội')
INSERT [dbo].[tblGiangVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [magiaovien], [matkhau], [ho], [tendem], [ten], [gioitinh], [ngaysinh], [dienthoai], [email], [diachi]) VALUES (CAST(N'2024-05-25T02:59:03.480' AS DateTime), N'admin', CAST(N'2024-05-25T02:59:03.480' AS DateTime), N'admin', 6, N'123', N'Phạm', N'Thị', N'Mai', 1, CAST(N'1990-09-12' AS Date), N'0988765444', N'phamthimai@gmail.com', N'Hà Nội ')
SET IDENTITY_INSERT [dbo].[tblGiangVien] OFF
GO
SET IDENTITY_INSERT [dbo].[tblKhoa] ON 

INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap]) VALUES (1, N'Công nghệ thông tin', CAST(N'2024-05-11T20:15:43.840' AS DateTime), N'admin', CAST(N'2024-05-11T20:15:43.840' AS DateTime), N'admin')
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap]) VALUES (2, N'Kinh tế', CAST(N'2024-05-12T22:36:06.260' AS DateTime), N'admin', CAST(N'2024-05-12T22:36:06.260' AS DateTime), N'admin')
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap]) VALUES (3, N'Trắc địa', CAST(N'2024-05-12T22:36:25.143' AS DateTime), N'admin', CAST(N'2024-05-12T22:36:25.143' AS DateTime), N'admin')
INSERT [dbo].[tblKhoa] ([MaKhoa], [TenKhoa], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap]) VALUES (4, N'Dầu khí', CAST(N'2024-05-12T22:37:03.753' AS DateTime), N'admin', CAST(N'2024-05-12T22:37:03.753' AS DateTime), N'admin')
SET IDENTITY_INSERT [dbo].[tblKhoa] OFF
GO
SET IDENTITY_INSERT [dbo].[tblLop] ON 

INSERT [dbo].[tblLop] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [malophoc], [mamonhoc], [magiaovien], [daketthuc], [tietbatdau], [ngayhoc], [maphonghoc], [modangky]) VALUES (CAST(N'2024-05-25T03:32:25.533' AS DateTime), N'admin', CAST(N'2024-05-10T03:32:25.533' AS DateTime), N'admin', 1, 14, 4, 0, 1, 2, 1, 1)
INSERT [dbo].[tblLop] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [malophoc], [mamonhoc], [magiaovien], [daketthuc], [tietbatdau], [ngayhoc], [maphonghoc], [modangky]) VALUES (CAST(N'2024-05-28T11:02:53.487' AS DateTime), N'admin', CAST(N'2024-05-28T11:07:18.737' AS DateTime), N'4', 2, 2, 4, 1, 1, 2, 1, 0)
INSERT [dbo].[tblLop] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [malophoc], [mamonhoc], [magiaovien], [daketthuc], [tietbatdau], [ngayhoc], [maphonghoc], [modangky]) VALUES (CAST(N'2024-05-28T11:03:11.967' AS DateTime), N'admin', CAST(N'2024-05-28T11:03:11.967' AS DateTime), N'admin', 3, 2, 1, 0, 1, 2, 2, 0)
INSERT [dbo].[tblLop] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [malophoc], [mamonhoc], [magiaovien], [daketthuc], [tietbatdau], [ngayhoc], [maphonghoc], [modangky]) VALUES (CAST(N'2024-05-28T11:03:57.637' AS DateTime), N'admin', CAST(N'2024-05-28T11:03:57.637' AS DateTime), N'admin', 4, 2, 4, 0, 5, 2, 1, 0)
INSERT [dbo].[tblLop] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [malophoc], [mamonhoc], [magiaovien], [daketthuc], [tietbatdau], [ngayhoc], [maphonghoc], [modangky]) VALUES (CAST(N'2024-05-28T11:04:13.037' AS DateTime), N'admin', CAST(N'2024-05-28T11:04:13.037' AS DateTime), N'admin', 5, 1, 2, 0, 1, 3, 1, 0)
INSERT [dbo].[tblLop] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [malophoc], [mamonhoc], [magiaovien], [daketthuc], [tietbatdau], [ngayhoc], [maphonghoc], [modangky]) VALUES (CAST(N'2024-05-28T11:04:33.053' AS DateTime), N'admin', CAST(N'2024-05-28T11:04:33.053' AS DateTime), N'admin', 6, 21, 1, 0, 2, 4, 1, 0)
INSERT [dbo].[tblLop] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [malophoc], [mamonhoc], [magiaovien], [daketthuc], [tietbatdau], [ngayhoc], [maphonghoc], [modangky]) VALUES (CAST(N'2024-05-28T11:04:59.110' AS DateTime), N'admin', CAST(N'2024-05-28T11:04:59.110' AS DateTime), N'admin', 7, 4, 6, 0, 5, 6, 12, 0)
INSERT [dbo].[tblLop] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [malophoc], [mamonhoc], [magiaovien], [daketthuc], [tietbatdau], [ngayhoc], [maphonghoc], [modangky]) VALUES (CAST(N'2024-05-28T11:14:30.060' AS DateTime), N'admin', CAST(N'2024-05-28T11:14:30.060' AS DateTime), N'admin', 8, 12, 3, 0, 5, 5, 3, 0)
INSERT [dbo].[tblLop] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [malophoc], [mamonhoc], [magiaovien], [daketthuc], [tietbatdau], [ngayhoc], [maphonghoc], [modangky]) VALUES (CAST(N'2024-05-25T03:09:21.800' AS DateTime), N'admin', CAST(N'2024-05-10T03:09:21.800' AS DateTime), N'admin', 20019, 14, 4, 0, 1, 2, 11, 1)
SET IDENTITY_INSERT [dbo].[tblLop] OFF
GO
SET IDENTITY_INSERT [dbo].[tblLopHoc] ON 

INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1, N'CNTT66K2', 1, 66, N'Chính quy', CAST(N'2024-05-11T21:42:24.253' AS DateTime), N'admin', CAST(N'2024-05-11T21:42:24.253' AS DateTime), N'admin', N'2021')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (2, N'CNTT66K1', 1, 66, N'Chính quy', CAST(N'2024-05-11T22:10:39.810' AS DateTime), N'admin', CAST(N'2024-05-11T22:10:39.810' AS DateTime), N'admin', N'2021')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (8, N'CNTT66A1', 1, 66, N'Chính quy', CAST(N'2024-05-14T21:50:30.410' AS DateTime), N'admin', CAST(N'2024-05-14T21:50:30.410' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (9, N'CNPM68A', 1, 68, N'Chính quy', CAST(N'2024-05-14T21:52:02.357' AS DateTime), N'admin', CAST(N'2024-05-14T21:52:02.357' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (10, N'CNPM68B', 1, 68, N'Chính quy', CAST(N'2024-05-14T21:52:02.357' AS DateTime), N'admin', CAST(N'2024-05-14T21:52:02.357' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (11, N'CNPM68C', 1, 68, N'Chính quy', CAST(N'2024-05-14T21:52:02.360' AS DateTime), N'admin', CAST(N'2024-05-14T21:52:02.360' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (12, N'CNPM68D', 1, 68, N'Chính quy', CAST(N'2024-05-14T21:52:02.360' AS DateTime), N'admin', CAST(N'2024-05-14T21:52:02.360' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (13, N'CNPM68E', 1, 68, N'Chính quy', CAST(N'2024-05-14T21:52:02.360' AS DateTime), N'admin', CAST(N'2024-05-14T21:52:02.360' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (14, N'KHMT68A', 2, 68, N'Chính quy', CAST(N'2024-05-15T17:37:11.693' AS DateTime), N'admin', CAST(N'2024-05-15T17:37:11.693' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (15, N'KHMT68B', 2, 68, N'Chính quy', CAST(N'2024-05-15T17:37:11.697' AS DateTime), N'admin', CAST(N'2024-05-15T17:37:11.697' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (16, N'KHMT68C', 2, 68, N'Chính quy', CAST(N'2024-05-15T17:37:11.697' AS DateTime), N'admin', CAST(N'2024-05-15T17:37:11.697' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (17, N'KHMT68D', 2, 68, N'Chính quy', CAST(N'2024-05-15T17:37:11.697' AS DateTime), N'admin', CAST(N'2024-05-15T17:37:11.697' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (18, N'KHMT68E', 2, 68, N'Chính quy', CAST(N'2024-05-15T17:37:11.697' AS DateTime), N'admin', CAST(N'2024-05-15T17:37:11.697' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (19, N'TKT68A', 3, 68, N'Chính quy', CAST(N'2024-05-15T17:49:36.777' AS DateTime), N'admin', CAST(N'2024-05-15T17:49:36.777' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (20, N'TKT68B', 3, 68, N'Chính quy', CAST(N'2024-05-15T17:49:36.780' AS DateTime), N'admin', CAST(N'2024-05-15T17:49:36.780' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (21, N'TKT68C', 3, 68, N'Chính quy', CAST(N'2024-05-15T17:49:36.780' AS DateTime), N'admin', CAST(N'2024-05-15T17:49:36.780' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (22, N'TKT68D', 3, 68, N'Chính quy', CAST(N'2024-05-15T17:49:36.780' AS DateTime), N'admin', CAST(N'2024-05-15T17:49:36.780' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (23, N'TKT68E', 3, 68, N'Chính quy', CAST(N'2024-05-15T17:49:36.780' AS DateTime), N'admin', CAST(N'2024-05-15T17:49:36.780' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (24, N'ÐH68A', 4, 68, N'Chính quy', CAST(N'2024-05-15T18:32:17.517' AS DateTime), N'admin', CAST(N'2024-05-15T18:32:17.517' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (25, N'ÐH68B', 4, 68, N'Chính quy', CAST(N'2024-05-15T18:32:17.517' AS DateTime), N'admin', CAST(N'2024-05-15T18:32:17.517' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (26, N'ÐH68C', 4, 68, N'Chính quy', CAST(N'2024-05-15T18:32:17.517' AS DateTime), N'admin', CAST(N'2024-05-15T18:32:17.517' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (27, N'ÐH68D', 4, 68, N'Chính quy', CAST(N'2024-05-15T18:32:17.517' AS DateTime), N'admin', CAST(N'2024-05-15T18:32:17.517' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (28, N'ÐH68E', 4, 68, N'Chính quy', CAST(N'2024-05-15T18:32:17.517' AS DateTime), N'admin', CAST(N'2024-05-15T18:32:17.517' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1003, N'KTÐVL68A', 15, 68, N'Chính quy', CAST(N'2024-05-16T21:48:54.343' AS DateTime), N'admin', CAST(N'2024-05-16T21:48:54.343' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1004, N'KTÐVL68B', 15, 68, N'Chính quy', CAST(N'2024-05-16T21:48:54.347' AS DateTime), N'admin', CAST(N'2024-05-16T21:48:54.347' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1005, N'KTÐVL68C', 15, 68, N'Chính quy', CAST(N'2024-05-16T21:48:54.347' AS DateTime), N'admin', CAST(N'2024-05-16T21:48:54.347' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1006, N'KTÐVL68D', 15, 68, N'Chính quy', CAST(N'2024-05-16T21:48:54.347' AS DateTime), N'admin', CAST(N'2024-05-16T21:48:54.347' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1007, N'KTÐVL68E', 15, 68, N'Chính quy', CAST(N'2024-05-16T21:48:54.347' AS DateTime), N'admin', CAST(N'2024-05-16T21:48:54.347' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1008, N'KTDK68A', 8, 68, N'Chính quy', CAST(N'2024-05-16T21:49:30.823' AS DateTime), N'admin', CAST(N'2024-05-16T21:49:30.823' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1009, N'KTDK68B', 8, 68, N'Chính quy', CAST(N'2024-05-16T21:49:30.823' AS DateTime), N'admin', CAST(N'2024-05-16T21:49:30.823' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1010, N'KTDK68C', 8, 68, N'Chính quy', CAST(N'2024-05-16T21:49:30.823' AS DateTime), N'admin', CAST(N'2024-05-16T21:49:30.823' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1011, N'KTDK68D', 8, 68, N'Chính quy', CAST(N'2024-05-16T21:49:30.823' AS DateTime), N'admin', CAST(N'2024-05-16T21:49:30.823' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1012, N'KTDK68E', 8, 68, N'Chính quy', CAST(N'2024-05-16T21:49:30.827' AS DateTime), N'admin', CAST(N'2024-05-16T21:49:30.827' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1013, N'M68A', 6, 68, N'Chính quy', CAST(N'2024-05-16T21:52:43.340' AS DateTime), N'admin', CAST(N'2024-05-16T21:52:43.340' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1014, N'M68B', 6, 68, N'Chính quy', CAST(N'2024-05-16T21:52:43.340' AS DateTime), N'admin', CAST(N'2024-05-16T21:52:43.340' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1015, N'M68C', 6, 68, N'Chính quy', CAST(N'2024-05-16T21:52:43.340' AS DateTime), N'admin', CAST(N'2024-05-16T21:52:43.340' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1016, N'M68D', 6, 68, N'Chính quy', CAST(N'2024-05-16T21:52:43.340' AS DateTime), N'admin', CAST(N'2024-05-16T21:52:43.340' AS DateTime), N'admin', N'2024')
INSERT [dbo].[tblLopHoc] ([MaLop], [TenLop], [Manganh], [KhoaHoc], [Hedaotao], [ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [Namnhaphoc]) VALUES (1017, N'M68E', 6, 68, N'Chính quy', CAST(N'2024-05-16T21:52:43.340' AS DateTime), N'admin', CAST(N'2024-05-16T21:52:43.340' AS DateTime), N'admin', N'2024')
SET IDENTITY_INSERT [dbo].[tblLopHoc] OFF
GO
SET IDENTITY_INSERT [dbo].[tblMonHoc] ON 

INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:39:20.323' AS DateTime), N'admin', CAST(N'2024-05-24T21:39:20.323' AS DateTime), N'admin', 1, N'Đại số tuyến tính', 4)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:39:35.553' AS DateTime), N'admin', CAST(N'2024-05-24T21:39:35.553' AS DateTime), N'admin', 2, N'Giải tích 1', 4)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:39:53.137' AS DateTime), N'admin', CAST(N'2024-05-24T21:39:53.137' AS DateTime), N'admin', 3, N'Xác xuất thống kê', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:40:02.763' AS DateTime), N'admin', CAST(N'2024-05-24T21:40:02.763' AS DateTime), N'admin', 4, N'Tiếng anh 1', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:40:09.873' AS DateTime), N'admin', CAST(N'2024-05-24T21:40:09.873' AS DateTime), N'admin', 5, N'Tiếng anh 2', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:40:35.390' AS DateTime), N'admin', CAST(N'2024-05-24T21:40:35.390' AS DateTime), N'admin', 6, N'Triết học Mac-Lênin', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:40:49.330' AS DateTime), N'admin', CAST(N'2024-05-24T21:40:49.330' AS DateTime), N'admin', 7, N'Nhập môn ngành CNTT', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:41:18.380' AS DateTime), N'admin', CAST(N'2024-05-24T21:41:18.380' AS DateTime), N'admin', 8, N'Giải tích 2', 4)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:41:28.110' AS DateTime), N'admin', CAST(N'2024-05-24T21:41:28.110' AS DateTime), N'admin', 9, N'Phương pháp tính', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:41:48.413' AS DateTime), N'admin', CAST(N'2024-05-24T21:41:48.413' AS DateTime), N'admin', 10, N'Vật lý đại cương 1', 4)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:42:03.887' AS DateTime), N'admin', CAST(N'2024-05-24T21:42:03.887' AS DateTime), N'admin', 11, N'Cơ sở lập trình', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:42:35.890' AS DateTime), N'admin', CAST(N'2024-05-24T21:42:35.890' AS DateTime), N'admin', 12, N'Logic đại cương', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:42:47.940' AS DateTime), N'admin', CAST(N'2024-05-24T21:42:47.940' AS DateTime), N'admin', 13, N'Hóa học đại cương 1', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:43:07.107' AS DateTime), N'admin', CAST(N'2024-05-24T21:43:07.107' AS DateTime), N'admin', 14, N'Chủ nghĩa xã hội khoa học', 2)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:43:25.480' AS DateTime), N'admin', CAST(N'2024-05-24T21:43:25.480' AS DateTime), N'admin', 15, N'Nguyên lỹ Hệ điều hành', 2)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:43:51.753' AS DateTime), N'admin', CAST(N'2024-05-24T21:43:51.753' AS DateTime), N'admin', 16, N'Kỹ thuật lập trình hướng đối tượng với C++ BTL', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:44:27.513' AS DateTime), N'admin', CAST(N'2024-05-24T21:44:27.513' AS DateTime), N'admin', 17, N'Kiến trúc máy tính', 2)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:44:47.593' AS DateTime), N'admin', CAST(N'2024-05-24T21:44:47.593' AS DateTime), N'admin', 18, N'Pháp luật đại cương ', 2)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:45:00.890' AS DateTime), N'admin', CAST(N'2024-05-24T21:45:00.890' AS DateTime), N'admin', 19, N'Tư tưởng Hồ Chí Minh', 2)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:45:18.120' AS DateTime), N'admin', CAST(N'2024-05-24T21:45:18.120' AS DateTime), N'admin', 20, N'Hệ quản trị cơ sở dữ liệu', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:45:42.790' AS DateTime), N'admin', CAST(N'2024-05-24T21:45:42.790' AS DateTime), N'admin', 21, N'Lập trình .NET 1 + BTL', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:45:55.823' AS DateTime), N'admin', CAST(N'2024-05-24T21:45:55.823' AS DateTime), N'admin', 22, N'Trí tuệ nhân tạo + BTL', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:46:09.470' AS DateTime), N'admin', CAST(N'2024-05-24T21:46:09.470' AS DateTime), N'admin', 23, N'Khai phá dữ liệu ', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:46:24.180' AS DateTime), N'admin', CAST(N'2024-05-24T21:46:24.180' AS DateTime), N'admin', 24, N'Kỹ nghệ tri thức và học máy ', 3)
INSERT [dbo].[tblMonHoc] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [mamonhoc], [tenmonhoc], [sotinchi]) VALUES (CAST(N'2024-05-24T21:46:38.617' AS DateTime), N'admin', CAST(N'2024-05-24T21:46:38.617' AS DateTime), N'admin', 25, N'Phát triển ứng dụng Iot ', 3)
SET IDENTITY_INSERT [dbo].[tblMonHoc] OFF
GO
SET IDENTITY_INSERT [dbo].[tblNganh] ON 

INSERT [dbo].[tblNganh] ([Manganh], [Tennganh], [MaKhoa], [ngaytao], [ngaycapnhap], [nguoicapnhap], [nguoitao]) VALUES (1, N'Công nghệ phần mềm', 1, CAST(N'2024-05-11T20:46:35.043' AS DateTime), CAST(N'2024-05-11T20:46:35.043' AS DateTime), N'admin', N'admin')
INSERT [dbo].[tblNganh] ([Manganh], [Tennganh], [MaKhoa], [ngaytao], [ngaycapnhap], [nguoicapnhap], [nguoitao]) VALUES (2, N'Khoa học máy tính', 1, CAST(N'2024-05-12T22:37:46.210' AS DateTime), CAST(N'2024-05-12T22:37:46.210' AS DateTime), N'admin', N'admin')
INSERT [dbo].[tblNganh] ([Manganh], [Tennganh], [MaKhoa], [ngaytao], [ngaycapnhap], [nguoicapnhap], [nguoitao]) VALUES (3, N'Tin kinh tế', 1, CAST(N'2024-05-12T22:37:56.417' AS DateTime), CAST(N'2024-05-12T22:37:56.417' AS DateTime), N'admin', N'admin')
INSERT [dbo].[tblNganh] ([Manganh], [Tennganh], [MaKhoa], [ngaytao], [ngaycapnhap], [nguoicapnhap], [nguoitao]) VALUES (4, N'Địa học', 1, CAST(N'2024-05-12T22:38:10.930' AS DateTime), CAST(N'2024-05-12T22:38:10.930' AS DateTime), N'admin', N'admin')
INSERT [dbo].[tblNganh] ([Manganh], [Tennganh], [MaKhoa], [ngaytao], [ngaycapnhap], [nguoicapnhap], [nguoitao]) VALUES (5, N'Quản trị kinh doanh', 2, CAST(N'2024-05-12T22:38:37.950' AS DateTime), CAST(N'2024-05-12T22:38:37.950' AS DateTime), N'admin', N'admin')
INSERT [dbo].[tblNganh] ([Manganh], [Tennganh], [MaKhoa], [ngaytao], [ngaycapnhap], [nguoicapnhap], [nguoitao]) VALUES (6, N'Marketing', 2, CAST(N'2024-05-12T22:38:47.730' AS DateTime), CAST(N'2024-05-12T22:38:47.730' AS DateTime), N'admin', N'admin')
INSERT [dbo].[tblNganh] ([Manganh], [Tennganh], [MaKhoa], [ngaytao], [ngaycapnhap], [nguoicapnhap], [nguoitao]) VALUES (7, N'Kế toán', 2, CAST(N'2024-05-12T22:38:53.290' AS DateTime), CAST(N'2024-05-12T22:38:53.290' AS DateTime), N'admin', N'admin')
INSERT [dbo].[tblNganh] ([Manganh], [Tennganh], [MaKhoa], [ngaytao], [ngaycapnhap], [nguoicapnhap], [nguoitao]) VALUES (8, N'Kỹ thuật dầu khí', 4, CAST(N'2024-05-15T14:38:19.050' AS DateTime), CAST(N'2024-05-15T14:38:19.050' AS DateTime), N'admin', N'admin')
INSERT [dbo].[tblNganh] ([Manganh], [Tennganh], [MaKhoa], [ngaytao], [ngaycapnhap], [nguoicapnhap], [nguoitao]) VALUES (15, N'Kỹ thuật địa vật lý', 4, CAST(N'2024-05-15T14:39:20.783' AS DateTime), CAST(N'2024-05-15T14:39:20.783' AS DateTime), N'admin', N'admin')
INSERT [dbo].[tblNganh] ([Manganh], [Tennganh], [MaKhoa], [ngaytao], [ngaycapnhap], [nguoicapnhap], [nguoitao]) VALUES (16, N'Quản lý đất đai', 3, CAST(N'2024-05-15T14:40:29.053' AS DateTime), CAST(N'2024-05-15T14:40:29.053' AS DateTime), N'admin', N'admin')
INSERT [dbo].[tblNganh] ([Manganh], [Tennganh], [MaKhoa], [ngaytao], [ngaycapnhap], [nguoicapnhap], [nguoitao]) VALUES (17, N'Địa tin học', 3, CAST(N'2024-05-15T14:40:38.350' AS DateTime), CAST(N'2024-05-15T14:40:38.350' AS DateTime), N'admin', N'admin')
SET IDENTITY_INSERT [dbo].[tblNganh] OFF
GO
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (1, N'P1', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (2, N'P2', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (3, N'P3', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (4, N'P4', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (5, N'P5', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (6, N'P6', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (7, N'P7', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (8, N'P8', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (9, N'P9', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (10, N'P10', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (11, N'P11', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (12, N'P12', 1)
INSERT [dbo].[tblPhongHoc] ([maphonghoc], [tenphonghoc], [succhua]) VALUES (13, N'P13', 1)
GO
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-07T17:22:19.850' AS DateTime), N'admin', CAST(N'2024-05-07T17:22:19.850' AS DateTime), N'admin', N'HUMG1002', N'Lê', N'Đức ', N'Anh', CAST(N'2003-03-26' AS Date), 1, N'thái xuyên thái thụy thái bình', N'Hà Nội', N'0988372832', N'ducanh@gmail.com', N'123', 2)
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-08T11:38:57.670' AS DateTime), N'admin', CAST(N'2024-05-08T11:38:57.670' AS DateTime), N'admin', N'HUMG1005', N'Đỗ', N'Cao', N'Cường', CAST(N'2003-11-11' AS Date), 1, N'Ninh Bình', N'Hà Nội', N'0020203332', N'cuong@gmail.com', N'123', 1)
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-08T16:29:42.273' AS DateTime), N'admin', CAST(N'2024-05-08T16:29:42.273' AS DateTime), N'admin', N'HUMG1006', N'Lê ', N'Tuấn', N'Long', CAST(N'2003-09-11' AS Date), 1, N'Thanh Hóa', N'Hà Nội', N'0992883223', N'long@gmail.com', N'123', 1)
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-14T21:53:51.073' AS DateTime), N'admin', CAST(N'2024-05-14T21:53:51.073' AS DateTime), N'admin', N'HUMG1012', N'Lê', N'Đức', N'Trung', CAST(N'2004-12-12' AS Date), 1, N'', N'', N'', N'', N'123', 9)
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-15T17:37:42.157' AS DateTime), N'admin', CAST(N'2024-05-15T17:37:42.157' AS DateTime), N'admin', N'HUMG1013', N'Đỗ', N'Cao', N'Tay', CAST(N'2003-12-12' AS Date), 1, N'', N'', N'', N'', N'123', 14)
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-16T21:43:32.670' AS DateTime), N'admin', CAST(N'2024-05-16T21:43:32.670' AS DateTime), N'admin', N'HUMG1062', N'phạm', N'mạnh ', N'cầm', CAST(N'2003-06-10' AS Date), 1, N'aaa', N'aaa', N'aaaa', N'aaa', N'123', 13)
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-16T21:44:40.567' AS DateTime), N'admin', CAST(N'2024-05-16T21:44:40.567' AS DateTime), N'admin', N'HUMG1063', N'lê', N'hải', N'vân', CAST(N'2024-11-11' AS Date), 0, N'1', N'1', N'1', N'11', N'123', 24)
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-16T21:47:59.693' AS DateTime), N'admin', CAST(N'2024-05-16T21:47:59.693' AS DateTime), N'admin', N'HUMG1070', N'LL', N'LLL', N'LLL', CAST(N'1111-11-11' AS Date), 1, N'', N'', N'', N'', N'123', 8)
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-16T21:49:05.007' AS DateTime), N'admin', CAST(N'2024-05-16T21:49:05.007' AS DateTime), N'admin', N'HUMG1072', N'aaa', N'aaa', N'aaa', CAST(N'1111-11-11' AS Date), 1, N'', N'', N'', N'', N'123', 1004)
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-16T21:51:22.823' AS DateTime), N'admin', CAST(N'2024-05-16T21:51:22.823' AS DateTime), N'admin', N'HUMG1073', N'lưu', N'văn', N'công', CAST(N'1111-11-11' AS Date), 1, N'', N'', N'', N'', N'123', 1003)
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-19T16:09:58.627' AS DateTime), N'admin', CAST(N'2024-05-19T16:09:58.627' AS DateTime), N'admin', N'HUMG1074', N'Lê ', N'Văn ', N'Test', CAST(N'2003-12-12' AS Date), 1, N'', N'', N'', N'', N'123', 1)
INSERT [dbo].[tblSinhVien] ([ngaytao], [nguoitao], [ngaycapnhap], [nguoicapnhap], [masinhvien], [ho], [tendem], [ten], [ngaysinh], [gioitinh], [quequan], [diachi], [dienthoai], [email], [matkhau], [MaLop]) VALUES (CAST(N'2024-05-25T02:59:37.417' AS DateTime), N'admin', CAST(N'2024-05-25T02:59:37.417' AS DateTime), N'admin', N'HUMG1112', N'Đào', N'Sông', N'Danh', CAST(N'2003-09-12' AS Date), 1, N'Hà Nội ', N'danh@gmail.com', N'', N'', N'123', 1)
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_ngaycapnhap]  DEFAULT (getdate()) FOR [ngaycapnhap]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_nguoicapnhap]  DEFAULT ('admin') FOR [nguoicapnhap]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_lanhoc]  DEFAULT ((1)) FOR [lanhoc]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_diemc]  DEFAULT ((0)) FOR [diemc]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_diemb]  DEFAULT ((0)) FOR [diemb]
GO
ALTER TABLE [dbo].[tblDiem] ADD  CONSTRAINT [DF_tblDiem_diema]  DEFAULT ((0)) FOR [diema]
GO
ALTER TABLE [dbo].[tblDiemDanh] ADD  CONSTRAINT [DF_tblDiemDanh_ngayhientai]  DEFAULT (getdate()) FOR [ngayhientai]
GO
ALTER TABLE [dbo].[tblDiemDanh] ADD  CONSTRAINT [DF_tblDiemDanh_diemdanh]  DEFAULT ((0)) FOR [diemdanh]
GO
ALTER TABLE [dbo].[tblGiangVien] ADD  CONSTRAINT [DF_tblGiangVien_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblGiangVien] ADD  CONSTRAINT [DF_tblGiangVien_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblGiangVien] ADD  CONSTRAINT [DF_tblGiangVien_ngaycapnhap]  DEFAULT (getdate()) FOR [ngaycapnhap]
GO
ALTER TABLE [dbo].[tblGiangVien] ADD  CONSTRAINT [DF_tblGiangVien_nguoicapnhap]  DEFAULT ('admin') FOR [nguoicapnhap]
GO
ALTER TABLE [dbo].[tblGiangVien] ADD  CONSTRAINT [DF_tblGiangVien_matkhau]  DEFAULT ((123)) FOR [matkhau]
GO
ALTER TABLE [dbo].[tblKhoa] ADD  CONSTRAINT [DF_tblKhoa_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblKhoa] ADD  CONSTRAINT [DF_tblKhoa_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblKhoa] ADD  CONSTRAINT [DF_tblKhoa_ngaycapnhap]  DEFAULT (getdate()) FOR [ngaycapnhap]
GO
ALTER TABLE [dbo].[tblKhoa] ADD  CONSTRAINT [DF_tblKhoa_nguoicapnhap]  DEFAULT ('admin') FOR [nguoicapnhap]
GO
ALTER TABLE [dbo].[tblLichThi] ADD  CONSTRAINT [DF_tblLichThi_trangthai]  DEFAULT ((0)) FOR [trangthai]
GO
ALTER TABLE [dbo].[tblLop] ADD  CONSTRAINT [DF_tblLop_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblLop] ADD  CONSTRAINT [DF_tblLop_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblLop] ADD  CONSTRAINT [DF_tblLop_ngaycapnhap]  DEFAULT (getdate()) FOR [ngaycapnhap]
GO
ALTER TABLE [dbo].[tblLop] ADD  CONSTRAINT [DF_tblLop_nguoicapnhap]  DEFAULT ('admin') FOR [nguoicapnhap]
GO
ALTER TABLE [dbo].[tblLop] ADD  CONSTRAINT [DF_tblLop_daketthuc]  DEFAULT ((0)) FOR [daketthuc]
GO
ALTER TABLE [dbo].[tblLop] ADD  CONSTRAINT [DF_tblLop_modangky]  DEFAULT ((0)) FOR [modangky]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_ngaycapnhap]  DEFAULT (getdate()) FOR [ngaycapnhap]
GO
ALTER TABLE [dbo].[tblLopHoc] ADD  CONSTRAINT [DF_tblLopHoc_nguoicapnhap]  DEFAULT ('admin') FOR [nguoicapnhap]
GO
ALTER TABLE [dbo].[tblMonHoc] ADD  CONSTRAINT [DF_tblMonHoc_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblMonHoc] ADD  CONSTRAINT [DF_tblMonHoc_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblMonHoc] ADD  CONSTRAINT [DF_tblMonHoc_ngaycapnhap]  DEFAULT (getdate()) FOR [ngaycapnhap]
GO
ALTER TABLE [dbo].[tblMonHoc] ADD  CONSTRAINT [DF_tblMonHoc_nguoicapnhap]  DEFAULT ('admin') FOR [nguoicapnhap]
GO
ALTER TABLE [dbo].[tblNganh] ADD  CONSTRAINT [DF_tblNganh_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblNganh] ADD  CONSTRAINT [DF_tblNganh_ngaycapnhap]  DEFAULT (getdate()) FOR [ngaycapnhap]
GO
ALTER TABLE [dbo].[tblNganh] ADD  CONSTRAINT [DF_tblNganh_nguoicapnhap]  DEFAULT ('admin') FOR [nguoicapnhap]
GO
ALTER TABLE [dbo].[tblNganh] ADD  CONSTRAINT [DF_tblNganh_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_ngaytao]  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_nguoitao]  DEFAULT ('admin') FOR [nguoitao]
GO
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_ngaycapnhap]  DEFAULT (getdate()) FOR [ngaycapnhap]
GO
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_nguoicapnhap]  DEFAULT ('admin') FOR [nguoicapnhap]
GO
ALTER TABLE [dbo].[tblSinhVien] ADD  CONSTRAINT [DF_tblSinhVien_matkhau]  DEFAULT ((123)) FOR [matkhau]
GO
ALTER TABLE [dbo].[tblDiem]  WITH CHECK ADD  CONSTRAINT [FK_tblDiem_tblLop] FOREIGN KEY([malophoc])
REFERENCES [dbo].[tblLop] ([malophoc])
GO
ALTER TABLE [dbo].[tblDiem] CHECK CONSTRAINT [FK_tblDiem_tblLop]
GO
ALTER TABLE [dbo].[tblDiem]  WITH CHECK ADD  CONSTRAINT [FK_tblDiem_tblSinhVien] FOREIGN KEY([masinhvien])
REFERENCES [dbo].[tblSinhVien] ([masinhvien])
GO
ALTER TABLE [dbo].[tblDiem] CHECK CONSTRAINT [FK_tblDiem_tblSinhVien]
GO
ALTER TABLE [dbo].[tblDiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_tblDiemDanh_tblDiemDanhvalue] FOREIGN KEY([diemdanh])
REFERENCES [dbo].[tblDiemDanhvalue] ([diemdanh])
GO
ALTER TABLE [dbo].[tblDiemDanh] CHECK CONSTRAINT [FK_tblDiemDanh_tblDiemDanhvalue]
GO
ALTER TABLE [dbo].[tblDiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_tblDiemDanh_tblLop] FOREIGN KEY([malophoc])
REFERENCES [dbo].[tblLop] ([malophoc])
GO
ALTER TABLE [dbo].[tblDiemDanh] CHECK CONSTRAINT [FK_tblDiemDanh_tblLop]
GO
ALTER TABLE [dbo].[tblDiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_tblDiemDanh_tblSinhVien] FOREIGN KEY([masinhvien])
REFERENCES [dbo].[tblSinhVien] ([masinhvien])
GO
ALTER TABLE [dbo].[tblDiemDanh] CHECK CONSTRAINT [FK_tblDiemDanh_tblSinhVien]
GO
ALTER TABLE [dbo].[tblLichThi]  WITH CHECK ADD  CONSTRAINT [FK_tblLichThi_tblGiangVien] FOREIGN KEY([magiaovien])
REFERENCES [dbo].[tblGiangVien] ([magiaovien])
GO
ALTER TABLE [dbo].[tblLichThi] CHECK CONSTRAINT [FK_tblLichThi_tblGiangVien]
GO
ALTER TABLE [dbo].[tblLichThi]  WITH CHECK ADD  CONSTRAINT [FK_tblLichThi_tblSinhVien] FOREIGN KEY([masinhvien])
REFERENCES [dbo].[tblSinhVien] ([masinhvien])
GO
ALTER TABLE [dbo].[tblLichThi] CHECK CONSTRAINT [FK_tblLichThi_tblSinhVien]
GO
ALTER TABLE [dbo].[tblLop]  WITH CHECK ADD  CONSTRAINT [FK_tblLop_tblGiangVien] FOREIGN KEY([magiaovien])
REFERENCES [dbo].[tblGiangVien] ([magiaovien])
GO
ALTER TABLE [dbo].[tblLop] CHECK CONSTRAINT [FK_tblLop_tblGiangVien]
GO
ALTER TABLE [dbo].[tblLop]  WITH CHECK ADD  CONSTRAINT [FK_tblLop_tblMonHoc] FOREIGN KEY([mamonhoc])
REFERENCES [dbo].[tblMonHoc] ([mamonhoc])
GO
ALTER TABLE [dbo].[tblLop] CHECK CONSTRAINT [FK_tblLop_tblMonHoc]
GO
ALTER TABLE [dbo].[tblLop]  WITH CHECK ADD  CONSTRAINT [FK_tblLop_tblPhongHoc] FOREIGN KEY([maphonghoc])
REFERENCES [dbo].[tblPhongHoc] ([maphonghoc])
GO
ALTER TABLE [dbo].[tblLop] CHECK CONSTRAINT [FK_tblLop_tblPhongHoc]
GO
ALTER TABLE [dbo].[tblLopHoc]  WITH CHECK ADD  CONSTRAINT [FK_tblLopHoc_tblNganh] FOREIGN KEY([Manganh])
REFERENCES [dbo].[tblNganh] ([Manganh])
GO
ALTER TABLE [dbo].[tblLopHoc] CHECK CONSTRAINT [FK_tblLopHoc_tblNganh]
GO
ALTER TABLE [dbo].[tblNganh]  WITH CHECK ADD  CONSTRAINT [FK_tblNganh_tblKhoa1] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[tblKhoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[tblNganh] CHECK CONSTRAINT [FK_tblNganh_tblKhoa1]
GO
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_tblSinhVien_tblLopHoc] FOREIGN KEY([MaLop])
REFERENCES [dbo].[tblLopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [FK_tblSinhVien_tblLopHoc]
GO
/****** Object:  StoredProcedure [dbo].[AddnewDSDiemDanh]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddnewDSDiemDanh]
    @malophoc INT,
    @masinhvien VARCHAR(50),
    @magiaovien INT
AS
BEGIN
    DECLARE @v_soluong INT;

    -- Đếm số lượng bản ghi của sinh viên trong lớp học trong ngày hiện tại
    SELECT @v_soluong = COUNT(masinhvien)
    FROM tblDiemDanh
    WHERE malophoc = @malophoc 
        AND masinhvien = @masinhvien 
        AND CONVERT(date, ngayhientai) = CONVERT(date, GETDATE()); --Chi so sanh ngay khong so sanh gio

    IF (@v_soluong > 0)
    BEGIN
        -- Nếu đã tồn tại bản ghi cho sinh viên trong ngày hiện tại, trả về -1
        RETURN -1;
    END
    ELSE
    BEGIN
        -- Nếu chưa có bản ghi cho sinh viên trong ngày hiện tại, thêm bản ghi mới vào bảng
        INSERT INTO tblDiemDanh (ngayhientai, malophoc, masinhvien, nguoitao)
        VALUES (GETDATE(), @malophoc, @masinhvien, @magiaovien);
        RETURN 0; -- Trả về 0 để biểu thị việc thêm dữ liệu thành công
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[AddNewGiangVien]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddNewGiangVien]
	@nguoitao varchar(30),
	@ho nvarchar(10),
	@tendem nvarchar(20), 
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date,
	@email varchar(150),
	@dienthoai varchar(30),
	@diachi nvarchar(150)
as
begin
	insert into tblGiangVien(nguoitao,ho,tendem,ten,gioitinh,ngaysinh,email,dienthoai,diachi)
	values(@nguoitao,@ho,@tendem,@ten,@gioitinh,@ngaysinh,@email,@dienthoai,@diachi);
	if @@ROWCOUNT > 0 return 1 else return 0 ;
end;
GO
/****** Object:  StoredProcedure [dbo].[AddNewLopHoc]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AddNewLopHoc]
	@nguoitao varchar(30),
	@magiaovien int,
	@mamonhoc int,
	@tietbatdau int,
	@ngayhoc int,
	@maphonghoc int
as
begin
	insert into tblLop(nguoitao,mamonhoc,magiaovien,tietbatdau,ngayhoc,maphonghoc)
	values(@nguoitao,@mamonhoc,@magiaovien,@tietbatdau,@ngayhoc,@maphonghoc);
	if @@ROWCOUNT > 0 return 1 else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[addNewMonHoc]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[addNewMonHoc]
	@nguoitao varchar(30),
	@tenmonhoc nvarchar(150),
	@sotinchi int
as
begin
	insert into tblMonHoc(nguoitao,tenmonhoc,sotinchi)
	values(@nguoitao,@tenmonhoc,@sotinchi);
	if @@ROWCOUNT > 0 return 1 else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[AddnewSinhVien]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AddnewSinhVien]
	@ho nvarchar(10),@tendem nvarchar(20), @ten nvarchar(10),
	@ngaysinh date, @gioitinh tinyint, @quequan nvarchar(150),
	@diachi nvarchar(150), @dienthoai varchar(30), @email varchar(150),
	@malop int
as
begin
	insert into tblSinhVien(masinhvien,ho,tendem,ten,ngaysinh,gioitinh,quequan,diachi,dienthoai,email,MaLop)
	values( 'HUMG'+cast(next value for sinhvienSeq as varchar(30)),@ho,@tendem,@ten,@ngaysinh,@gioitinh,@quequan,@diachi,@dienthoai,@email,@malop);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
end;
GO
/****** Object:  StoredProcedure [dbo].[allLopHoc]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[allLopHoc]
    @tukhoa NVARCHAR(50)
AS
BEGIN
    SELECT 
        l.ngayhoc,
        l.tietbatdau,
        l.malophoc,
        p.maphonghoc,
        m.sotinchi,
        p.tenphonghoc,
        CASE 
            WHEN LEN(TRIM(g.tendem)) > 0 THEN CONCAT(g.ho, ' ', g.tendem, ' ', g.ten)
            ELSE CONCAT(g.ho, ' ', g.ten) 
        END AS gv,
        m.tenmonhoc 
    FROM tblLop l
    INNER JOIN tblGiangVien g ON l.magiaovien = g.magiaovien
    INNER JOIN tblMonHoc m ON l.mamonhoc = m.mamonhoc
    INNER JOIN tblPhongHoc p ON l.maphonghoc = p.maphonghoc
    WHERE LOWER(m.tenmonhoc) LIKE '%' + LOWER(@tukhoa) + '%' AND l.modangky = 0;
END
GO
/****** Object:  StoredProcedure [dbo].[allMonHoc]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[allMonHoc]
AS
BEGIN
    SELECT 
        l.malophoc,
        CASE WHEN len(trim(g.tendem)) > 0 THEN concat(g.ho, '', g.tendem, '', g.ten)
            ELSE concat(g.ho, '', g.ten) END AS gv,
        m.tenmonhoc 
    FROM tblLop l
    INNER JOIN tblGiangVien g ON l.magiaovien = g.magiaovien
    INNER JOIN tblMonHoc m ON l.mamonhoc = m.mamonhoc;
END
select * from tblLop
GO
/****** Object:  StoredProcedure [dbo].[chamdiem]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[chamdiem]
@magiaovien varchar(10), -- ai chấm <-> nguoif cập nhật trong bảng
	@malop bigint, -- lớp nào
	@masinhvien varchar(30),-- chấm cho ai
	@diemc float,
	@diemb float,
	@diema float
as
begin
	update tblDiem
	set
		ngaycapnhap = getdate(),--getdate() là hàm lấy giờ hiện tại của hệ thống
		nguoicapnhap = @magiaovien,
		diemc = @diemc,
		diemb = @diemb,
		diema = @diema
	where malophoc = @malop and masinhvien = @masinhvien
end
GO
/****** Object:  StoredProcedure [dbo].[dangnhap]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[dangnhap]
	@loaitaikhoan nvarchar(10),
	@taikhoan varchar(50),
	@matkhau varchar(50)
as
begin
	if @loaitaikhoan = 'admin' 
		select * from taikhoan where tentaikhoan = @taikhoan and matkhau = @matkhau
		else if @loaitaikhoan = 'gv' 
			select * from tblGiangVien where cast(magiaovien as varchar(50)) = @taikhoan and matkhau = @matkhau
		else select * from tblSinhVien where masinhvien = @taikhoan and matkhau = @matkhau ;
end
GO
/****** Object:  StoredProcedure [dbo].[danhsachdiemdanh]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[danhsachdiemdanh]
   @malophoc VARCHAR(50),
   @ngayhientai datetime
AS 
BEGIN
    SELECT 
		d.masinhvien,
		e.trangthai,
        CASE 
            WHEN LEN(s.tendem) > 0 THEN CONCAT(s.ho,' ',s.tendem,' ',s.ten) 
            ELSE CONCAT(s.ho,' ',s.ten)
        END AS hoten,
        CONVERT(date,ngayhientai)
    FROM tblDiemDanh AS d
    INNER JOIN tblSinhVien AS s ON d.masinhvien = s.masinhvien
	INNER JOIN tblDiemDanhvalue e on d.diemdanh =  e.diemdanh
    WHERE d.malophoc = @malophoc AND CONVERT(date, ngayhientai) = CONVERT(date, @ngayhientai);
END
GO
/****** Object:  StoredProcedure [dbo].[danhsachlopchamdiem]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[danhsachlopchamdiem]
    @magiaovien int,
    @malophoc bigint
AS
BEGIN
    SELECT 
        d.masinhvien,
        CASE 
            WHEN LEN(s.tendem) > 0 THEN CONCAT(s.ho,' ',s.tendem,' ',s.ten) 
            ELSE CONCAT(s.ho,' ',s.ten)
        END AS hoten,
        d.diemc,
        d.diemb,
        d.diema
    FROM
        (
            SELECT 
                l.malophoc,
                l.mamonhoc,
                m.tenmonhoc,
                m.sotinchi
            FROM tblLop l
            INNER JOIN tblMonHoc m ON l.mamonhoc = m.mamonhoc
            WHERE daketthuc = 0
            AND magiaovien = @magiaovien 
            AND malophoc = @malophoc 
        ) AS tb
    INNER JOIN tblDiem d ON d.malophoc = tb.malophoc
    INNER JOIN tblSinhVien s ON s.masinhvien = d.masinhvien
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteSinhVien]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteSinhVien]
	@masinhvien varchar(100)
as
begin
	declare @v_result int;
	set @v_result = (select count(*) from tblDiem where masinhvien = @masinhvien);
	if @v_result > 0
	begin
		return -1;
	end
	else
	begin
		delete from tblSinhVien where masinhvien = @masinhvien;
		return @@rowcount;
	end
end
GO
/****** Object:  StoredProcedure [dbo].[dkyhoc]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dkyhoc]
		@masinhvien varchar(50),
		@malophoc bigint
	as
	begin
		declare @v_lanhoc int,
				@v_mamonhoc int,
				@v_dadangky int;
		-- lấy mã môn học dựa vào mã lớp
		select @v_mamonhoc = mamonhoc
		from tblLop
		where malophoc = @malophoc;

		-- từ mã môn học + mã sinh viên => tính được số lần học trước đó
		select @v_lanhoc = count(*)
		from tblDiem d
		inner join tblLop l on d.malophoc = l.malophoc
		where l.daketthuc = 1 --> chỉ tính số lần học từ các lớp có trạng thái đã kết thúc
		and d.masinhvien = @masinhvien
		and l.mamonhoc = @v_mamonhoc;

		-- kiểm tra xem sinh viên này hiện có đăng ký lớp khác học cùng 1 môn hay không
		select @v_dadangky = count(*)
		from tblDiem d
		inner join tblLop l on d.malophoc = l.malophoc
		where l.daketthuc = 0 --> lớp đang mở
		and l.mamonhoc = @v_mamonhoc --> môn học này đã đăng ký
		and d.masinhvien = @masinhvien; --> sinh viên xác định

		if @v_dadangky>0 return -1;

		set @v_lanhoc = @v_lanhoc + 1;

		--> insert dữ liệu vào bảng điểm <-> đăng ký môn học
		insert into tblDiem(nguoitao,masinhvien,malophoc,lanhoc)
		values(@masinhvien,@masinhvien,@malophoc,@v_lanhoc);--sinh viên đăng ký -> người tạo = mã sinh viên

		--kiểm tra thực thi câu lệnh sql
		if @@ROWCOUNT > 0 return 1 else return 0;
	end
GO
/****** Object:  StoredProcedure [dbo].[doimatkhau]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[doimatkhau]
    @loaitaikhoan NVARCHAR(10),
	@taikhoan VARCHAR(50),
	@matkhau VARCHAR(50)
AS
BEGIN
    IF @loaitaikhoan = 'admin' 
        UPDATE TaiKhoan SET matkhau = @matkhau WHERE tentaikhoan = @taikhoan;
    ELSE IF @loaitaikhoan = 'gv' 
        UPDATE tblGiangVien SET matkhau = @matkhau WHERE magiaovien = @taikhoan;
    ELSE 
        UPDATE tblSinhVien SET matkhau = @matkhau WHERE masinhvien = @taikhoan;
END
GO
/****** Object:  StoredProcedure [dbo].[dsLopChuaDKy]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[dsLopChuaDKy]
	@masinhvien varchar(50)
as
begin
	select
		l.tietbatdau,
		l.ngayhoc,
		l.malophoc,
		l.mamonhoc,
		m.tenmonhoc,
		m.sotinchi,
		p.tenphonghoc,
		case when len(g.tendem)>0 then concat(g.ho,' ',g.tendem,' ',g.ten)
		else concat(g.ho,' ',g.ten) end as gvien
	from tblLop l
	inner join tblGiangVien g on l.magiaovien = g.magiaovien
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	inner join tblPhongHoc p on l.maphonghoc = p.maphonghoc
	where l.daketthuc = 0 and l.modangky = 0-- lấy các lớp đang mở
	and l.malophoc not in ( select malophoc from tblDiem where masinhvien = @masinhvien);
end
GO
/****** Object:  StoredProcedure [dbo].[giangvienxemlichcoithi]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[giangvienxemlichcoithi]
	@magiangvien int
as
begin
	select mamonhoc,ngaythi,cathi,tenphongthi from tblLichThi where magiaovien = @magiangvien and trangthai = 0;
end
GO
/****** Object:  StoredProcedure [dbo].[huyhocphan]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[huyhocphan]
    @masinhvien VARCHAR(50),
    @malophoc BIGINT
AS
BEGIN
    -- Xóa bản ghi trong bảng tblDiem dựa trên mã sinh viên và mã lớp học
    DELETE FROM tblDiem
    WHERE masinhvien = @masinhvien
    AND malophoc = @malophoc;

    -- Kiểm tra số bản ghi bị xóa
    IF @@ROWCOUNT > 0
        RETURN 1; -- Hủy đăng ký thành công
    ELSE
        RETURN 0; -- Không có bản ghi nào bị xóa
END
GO
/****** Object:  StoredProcedure [dbo].[ketthuchocphan]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ketthuchocphan]
	@magiaovien varchar(30), --người kết thúc
	@malop bigint -- kết thúc lớp học phần nào
as
begin
	update tblLop
	set
		nguoicapnhap = @magiaovien,
		ngaycapnhap = getdate(),
		daketthuc = 1
	where malophoc = @malop;
	if @@ROWCOUNT>0 return 1 -- cập nhật thành công
	else return 0; -- thất bại
end
GO
/****** Object:  StoredProcedure [dbo].[laydsmatrantrunglap]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[laydsmatrantrunglap]
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa);
	select 
			tb.malophoc,
			tb.mamonhoc,
			tb.tenmonhoc,
			d.masinhvien
		from
		(
			select 
				l.tietbatdau,
				l.ngayhoc,
				l.malophoc,
				l.mamonhoc,
				m.tenmonhoc,
				m.sotinchi,
				p.tenphonghoc
			from tblLop l
			inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
			inner join tblPhongHoc p on p.maphonghoc = l.maphonghoc
			where daketthuc = 0 and lower(m.tenmonhoc) like '%'+@tukhoa+'%'
		) as tb inner join tblDiem d on d.malophoc = tb.malophoc
		group by tb.malophoc,tb.mamonhoc,tb.tenmonhoc,tb.tietbatdau,tb.ngayhoc,tb.tenphonghoc,d.masinhvien,
			tb.sotinchi;
end
GO
/****** Object:  StoredProcedure [dbo].[laylichthichosinhvien]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[laylichthichosinhvien]
	@masinhvien varchar(50)
as
begin
	select m.tenmonhoc,l.ngaythi,l.cathi,l.hinhthucthi,l.tenphongthi from tblLichThi l inner join tblMonhoc m on m.mamonhoc = l.mamonhoc
	where masinhvien = @masinhvien and trangthai = 0; 
end
GO
/****** Object:  StoredProcedure [dbo].[layngaydadiemdanh]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[layngaydadiemdanh]
	@malophoc int
as
begin
	SELECT DISTINCT CONVERT(date, ngayhientai) as ngayhientai
	FROM tblDiemDanh where malophoc = @malophoc 
	order by ngayhientai desc;
end
GO
/****** Object:  StoredProcedure [dbo].[laysucchuacualop]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[laysucchuacualop] 
 @tenlophoc varchar(30)
as
begin 
	select succhua from tblPhongHoc where tenphonghoc = @tenlophoc
end
GO
/****** Object:  StoredProcedure [dbo].[laytatcasinhvienchohocphan]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[laytatcasinhvienchohocphan]
	@mamonhoc int
as
begin
select d.masinhvien from tblDiem d inner join tblLop l on d.malophoc = l.malophoc
	where daketthuc = 0 and mamonhoc = @mamonhoc and d.masinhvien not in (select masinhvien from tblLichThi where mamonhoc = @mamonhoc)
end
GO
/****** Object:  StoredProcedure [dbo].[laythongtinlophocmdk]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[laythongtinlophocmdk]
	@malophoc varchar(50)
as
begin
	select
		l.tietbatdau,
		l.ngayhoc,
		m.sotinchi
	from tblLop l 
	inner join tblMonHoc m on m.mamonhoc = l.mamonhoc
	where malophoc = @malophoc
end
GO
/****** Object:  StoredProcedure [dbo].[loaddldanhsachdiemdanh]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[loaddldanhsachdiemdanh]
	@magiaovien int,
    @malophoc bigint
AS
BEGIN 
	SELECT 
        d.masinhvien,
		d.malophoc,
        CASE 
            WHEN LEN(s.tendem) > 0 THEN CONCAT(s.ho,' ',s.tendem,' ',s.ten) 
            ELSE CONCAT(s.ho,' ',s.ten)
        END AS hoten
    FROM
        (
            SELECT 
                l.malophoc,
                l.mamonhoc,
                m.tenmonhoc,
                m.sotinchi
            FROM tblLop l
            INNER JOIN tblMonHoc m ON l.mamonhoc = m.mamonhoc
            WHERE daketthuc = 0
            AND magiaovien = @magiaovien 
            AND malophoc = @malophoc 
        ) AS tb
    INNER JOIN tblDiem d ON d.malophoc = tb.malophoc
    INNER JOIN tblSinhVien s ON s.masinhvien = d.masinhvien
END;
GO
/****** Object:  StoredProcedure [dbo].[modangky]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[modangky]
    @ngayhientai DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ngayCapNhatMin DATETIME;

    -- Lấy ngày cập nhật nhỏ nhất với modangky = 0
    SELECT @ngayCapNhatMin = MIN(ngaycapnhap)
    FROM tblLop
    WHERE modangky = 0;

    -- So sánh ngày hiện tại và ngày cập nhật nhỏ nhất
    IF DATEDIFF(DAY, @ngayCapNhatMin, @ngayhientai) > 14
    BEGIN
        -- Cập nhật giá trị modangky thành 1
        UPDATE tblLop
        SET modangky = 1
        WHERE modangky = 0;
    END
END
GO
/****** Object:  StoredProcedure [dbo].[monDaDKy]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[monDaDKy]
	@masinhvien varchar(50)
as
begin
	select 
		l.tietbatdau,
		l.ngayhoc,
		l.malophoc,
		m.tenmonhoc,
		p.tenphonghoc,
		case when(len(g.tendem) > 0 ) then concat(g.ho,' ',g.tendem,' ',g.ten)
		else concat(g.ho,' ',g.ten) end as gvien,
		m.sotinchi
	from tblDiem d
	inner join tblLop l on d.malophoc = l.malophoc
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	inner join tblGiangVien g on l.magiaovien = g.magiaovien
	inner join tblPhongHoc p on p.maphonghoc = l.maphonghoc
	where l.daketthuc = 0 -- môn đã đăng ký <-> lớp đang/chưa mở  => trạng thái kết thúc là 0; nếu trạng thái đã kết thúc = 1 => học phần đã học xong, điểm chác đã xong @@
	and d.masinhvien = @masinhvien;
end
GO
/****** Object:  StoredProcedure [dbo].[selectAllGiangVien]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllGiangVien]
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		magiaovien,
		case when len(ltrim(rtrim(tendem))) > 0 then concat(ltrim(rtrim(ho)),' ',ltrim(rtrim(tendem)), ' ', ltrim(rtrim(ten)))
		else  concat(ltrim(rtrim(ho)),' ', ltrim(rtrim(ten))) end as hoten,
		convert(varchar(10),ngaysinh,103) as ngaysinh,
		case when gioitinh = 1 then 'Nam' else N'Nữ' end as gioitinh,
		dienthoai,
		email,
		diachi
	from tblGiangVien
	where lower(ho) like '%'+@tukhoa+'%'
	or lower(tendem) like '%'+@tukhoa+'%'
	or lower(ten) like '%'+@tukhoa+'%'
	or lower(ho) like '%'+@tukhoa+'%'
	or lower(email) like '%'+@tukhoa+'%'
	or lower(dienthoai) like '%'+@tukhoa+'%'
	or lower(magiaovien) like '%'+@tukhoa+'%'
	order by ten;
end
GO
/****** Object:  StoredProcedure [dbo].[selectAllKhoa]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllKhoa]
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		MaKhoa,
		TenKhoa
	from tblKhoa
	where MaKhoa like '%'+@tukhoa+'%'
	or lower(TenKhoa) like '%'+@tukhoa+'%'
	order by TenKhoa;	
end;
GO
/****** Object:  StoredProcedure [dbo].[selectAllLopNhapHoc]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[selectAllLopNhapHoc]
    @tukhoa NVARCHAR(100), 
    @manganh INT
AS
BEGIN
    SELECT 
        MaLop,
        TenLop,
		KhoaHoc,
		Hedaotao,
		NamNhapHoc
    FROM tblLopHoc
    WHERE Manganh = @manganh
    AND lower(TenLop) LIKE N'%' + LOWER(@tukhoa) + N'%'; 
END;
GO
/****** Object:  StoredProcedure [dbo].[selectAllMonHoc]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllMonHoc]
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		mamonhoc,
		tenmonhoc,
		sotinchi
	from tblMonHoc
	where mamonhoc like '%'+@tukhoa+'%'
	or lower(tenmonhoc) like '%'+@tukhoa+'%'
	order by tenmonhoc;	
end;
GO
/****** Object:  StoredProcedure [dbo].[selectAllNganh]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[selectAllNganh]
    @tukhoa NVARCHAR(100), 
    @makhoa INT
AS
BEGIN
    SELECT 
        Manganh,
        Tennganh
    FROM tblNganh
    WHERE MaKhoa = @makhoa
    AND lower(Tennganh) LIKE N'%' + LOWER(@tukhoa) + N'%'; 
END;
GO
/****** Object:  StoredProcedure [dbo].[selectAllPhonghoc]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[selectAllPhonghoc]
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		maphonghoc,
		tenphonghoc,
		succhua
	from tblPhongHoc
	where maphonghoc like '%'+@tukhoa+'%'
	or lower(tenphonghoc) like '%'+@tukhoa+'%'
	order by tenphonghoc;	
end;
GO
/****** Object:  StoredProcedure [dbo].[selectAllSinhVien]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllSinhVien]
	@tukhoa nvarchar(50),
	@malop int
as
begin
	set @tukhoa = lower(ltrim(rtrim(@tukhoa)));
	select 
		masinhvien,
		case when len(tendem)>0 then concat(ho,' ',tendem,' ',ten)
		else concat(ho,' ',ten) end as hoten,
		convert(varchar(10),ngaysinh,103) as ngaysinh,
		case when gioitinh = 1 then 'Nam' else N'Nữ' end as gioitinh,
		quequan,diachi,dienthoai,email
	from tblSinhVien
	where MaLop = @malop and 
		(lower(ho) like '%'+@tukhoa+'%'
		or lower(tendem) like '%'+@tukhoa+'%'
		or lower(ten) like '%'+@tukhoa+'%'
		or lower(email) like '%'+@tukhoa+'%'
		or lower(diachi) like '%'+@tukhoa+'%')
	order by ten;
end
GO
/****** Object:  StoredProcedure [dbo].[selectAllTrangthaidd]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllTrangthaidd]
	@tukhoa nvarchar(20)
as
begin
	select * from tblDiemDanhvalue where
	diemdanh like '%'+@tukhoa+'%'
	or lower(trangthai) like '%'+@tukhoa+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[selectgv]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectgv]
	@mgv int
as
begin
	select
		ho,tendem,ten,
		gioitinh,convert(varchar(10),ngaysinh,103) as ngaysinh,
		dienthoai,email,diachi
	from tblGiangVien
	where magiaovien = @mgv;
end
GO
/****** Object:  StoredProcedure [dbo].[selectLopHoc]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectLopHoc]
	@malophoc bigint
as
begin
	select
		m.tenmonhoc,
		g.magiaovien,
		l.mamonhoc,
		l.tietbatdau,
		l.ngayhoc,
		l.maphonghoc
	from tblLop l
	inner join tblGiangVien g on l.magiaovien = g.magiaovien
	inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
	where malophoc = @malophoc;
end
GO
/****** Object:  StoredProcedure [dbo].[selectmh]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectmh]
	@mamh int
as
begin
	select 
		tenmonhoc,
		sotinchi
	from tblMonHoc
	where mamonhoc = @mamh;
end
GO
/****** Object:  StoredProcedure [dbo].[selectsv]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectsv]
	@msv varchar(50)
as
begin
	select
		ho,tendem,ten,
		convert(varchar(10),ngaysinh,103) as ngaysinh,
		gioitinh,
		quequan,diachi,dienthoai,email
	from tblSinhVien
	where masinhvien = @msv;
end
GO
/****** Object:  StoredProcedure [dbo].[selectTennganh]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectTennganh]
	@manganh int
as
begin
	select Tennganh from tblNganh where Manganh = @manganh
end
GO
/****** Object:  StoredProcedure [dbo].[selectthongtinsinhvien]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectthongtinsinhvien]
	@msv varchar(50)
as
begin
	select
		case when len(s.tendem)>0 then concat(s.ho,' ',s.tendem,' ',s.ten)
		else concat(s.ho,' ',s.ten) end as hoten,
		convert(varchar(10),s.ngaysinh,103) as ngaysinh,
		s.gioitinh,
		s.quequan,s.diachi,s.dienthoai,s.email,n.Tennganh,k.TenKhoa,l.Hedaotao,l.TenLop

	from tblSinhVien s inner join tblLopHoc l ON s.MaLop = l.MaLop
	inner join tblNganh n on n.Manganh = l.Manganh
	inner join tblKhoa k on k.MaKhoa = n.MaKhoa
	where masinhvien = @msv;
end
GO
/****** Object:  StoredProcedure [dbo].[selecttrangthaiddsinhvienduocchon]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[selecttrangthaiddsinhvienduocchon]
	@masinhvien varchar(50),
	@malophoc int,
	@ngayhientai datetime
as
begin
	select diemdanh from tblDiemDanh
	where masinhvien = @masinhvien and malophoc = @malophoc and CONVERT(date, ngayhientai) = CONVERT(date, @ngayhientai)
end
GO
/****** Object:  StoredProcedure [dbo].[sosinhvienthamgiahocphandangxet]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sosinhvienthamgiahocphandangxet]
	@mamonhoc int
as
begin
	select count(d.masinhvien) as soluong from tblDiem d inner join tblLop l on d.malophoc = l.malophoc
	where daketthuc = 0 and mamonhoc = @mamonhoc
end
GO
/****** Object:  StoredProcedure [dbo].[taoLopHocchokhoahocmoi]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[taoLopHocchokhoahocmoi]
	@manganh int,
	@tenlop varchar(50),
	@hedaotao nvarchar(50),
	@khoahoc int
as 
begin
	insert into tblLopHoc(Manganh,TenLop,KhoaHoc,Hedaotao,NamNhapHoc) VALUES(@manganh,@tenlop,@khoahoc,@hedaotao,YEAR(GETDATE()))
end
GO
/****** Object:  StoredProcedure [dbo].[themlichthi]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[themlichthi] 
    @mamonhoc int,
    @tenphongthi varchar(50),
    @magiaovien int,
    @cathi int,
    @ngaythi datetime,
	@masinhvien varchar(50),
	@hinhthucthi nvarchar(50)
as
begin
        INSERT INTO tblLichThi(mamonhoc, magiaovien, tenphongthi, cathi, ngaythi,masinhvien,hinhthucthi) 
        VALUES (@mamonhoc, @magiaovien, @tenphongthi, @cathi,@ngaythi,@masinhvien,@hinhthucthi); 
end
GO
/****** Object:  StoredProcedure [dbo].[thongtinsinhvienthamgiathihocphandangxet]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[thongtinsinhvienthamgiathihocphandangxet]
	@mamonhoc int
as
begin
	select d.masinhvien as soluong from tblDiem d inner join tblLop l on d.malophoc = l.malophoc
	where daketthuc = 0 and mamonhoc = @mamonhoc
end
GO
/****** Object:  StoredProcedure [dbo].[tracuudiem]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tracuudiem]
    @masinhvien varchar(50),
    @tukhoa nvarchar(50) -- cái này dùng để lọc dữ liệu tìm kiếm
AS
BEGIN
    SET NOCOUNT ON;
    SET @tukhoa = LOWER(@tukhoa); -- lower là cho toàn bộ kí tự in thường
    
    SELECT 
        m.mamonhoc,
        m.tenmonhoc,
        d.lanhoc,
        CASE 
            WHEN LEN(g.magiaovien) > 0 THEN CONCAT(g.ho, ' ', g.tendem, ' ', g.ten)
            ELSE CONCAT(g.ho, ' ', g.ten)
        END AS gvien, -- kiểm tra nếu có tên đệm thì nối họ + tên đệm + tên ngược lại thì nối họ + tên
        d.diemc,
        d.diemb,
        d.diema,
        -- Tính điểm chữ dựa trên điểm A, B, C
        CASE 
            WHEN (d.diema * 0.6 + d.diemb * 0.3 + d.diemc * 0.1) >= 9 THEN 'A+'
            WHEN (d.diema * 0.6 + d.diemb * 0.3 + d.diemc * 0.1) >= 8.5 THEN 'A'
            WHEN (d.diema * 0.6 + d.diemb * 0.3 + d.diemc * 0.1) >= 8 THEN 'B+'
            WHEN (d.diema * 0.6 + d.diemb * 0.3 + d.diemc * 0.1) >= 7 THEN 'B'
            WHEN (d.diema * 0.6 + d.diemb * 0.3 + d.diemc * 0.1) >= 6 THEN 'C+'
            WHEN (d.diema * 0.6 + d.diemb * 0.3 + d.diemc * 0.1) >= 5 THEN 'C'
            WHEN (d.diema * 0.6 + d.diemb * 0.3 + d.diemc * 0.1) >= 4 THEN 'D'
            ELSE 'F'
        END AS diemchu
    FROM tblDiem d
    INNER JOIN tblLop l ON d.malophoc = l.malophoc
    INNER JOIN tblMonHoc m ON l.mamonhoc = m.mamonhoc
    INNER JOIN tblGiangVien g ON l.magiaovien = g.magiaovien
    WHERE l.daketthuc = 1
    AND d.masinhvien = @masinhvien
    AND LOWER(m.tenmonhoc) LIKE '%' + @tukhoa + '%'; -- lọc theo từ khóa tìm kiếm truyền vào
END
GO
/****** Object:  StoredProcedure [dbo].[tracuulop]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[tracuulop]
	@magiaovien int,
	@tukhoa nvarchar(50)
as
begin
	set @tukhoa = lower(@tukhoa);--cho toàn bộ kí tự trở thành lowercase/viết thường
	select 
		tb.malophoc,
		tb.mamonhoc,
		tb.tenmonhoc,
		tb.sotinchi,
		tb.tietbatdau,
		tb.ngayhoc,
		tb.tenphonghoc,
		count(d.masinhvien) as siso
	from
	(
		select 
			l.tietbatdau,
			l.ngayhoc,
			l.malophoc,
			l.mamonhoc,
			m.tenmonhoc,
			m.sotinchi,
			p.tenphonghoc
		from tblLop l
		inner join tblMonHoc m on l.mamonhoc = m.mamonhoc
		inner join tblPhongHoc p on p.maphonghoc = l.maphonghoc
		where daketthuc = 0
		and magiaovien = @magiaovien
		and lower(m.tenmonhoc) like '%'+@tukhoa+'%' -- tìm kiếm tương đối <--> có chứa từ khóa 
	) as tb inner join tblDiem d on d.malophoc = tb.malophoc
	group by tb.malophoc,tb.mamonhoc,tb.tenmonhoc,tb.tietbatdau,tb.ngayhoc,tb.tenphonghoc,
		tb.sotinchi;
end
GO
/****** Object:  StoredProcedure [dbo].[Updatediemdanh]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Updatediemdanh]
	@masinhvien varchar(50),
	@malophoc int,
	@magiaovien int,
	@diemdanh int,
	@ngayhientai datetime
as 
begin
	update tblDiemDanh set diemdanh = @diemdanh where masinhvien = @masinhvien and malophoc =  @malophoc and nguoitao = @magiaovien and CONVERT(date, ngayhientai) = CONVERT(date, @ngayhientai)
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateGiangVien]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateGiangVien]
	@magiaovien int,
	@nguoicapnhat varchar(30),
	@ho nvarchar(10),
	@tendem nvarchar(20), 
	@ten nvarchar(10),
	@gioitinh tinyint,
	@ngaysinh date,
	@email varchar(150),
	@dienthoai varchar(30),
	@diachi nvarchar(150)
as
begin
	update tblGiangVien
	set nguoicapnhap = @nguoicapnhat,
		ngaycapnhap = getdate(),
		ho = @ho,tendem = @tendem, ten = @ten,
		gioitinh = @gioitinh, ngaysinh = @ngaysinh, email = @email, dienthoai = @dienthoai, diachi = @diachi
	where magiaovien = @magiaovien;
	if @@ROWCOUNT > 0 return 1 else return 0;
end;
GO
/****** Object:  StoredProcedure [dbo].[updatelichthisinhvien]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updatelichthisinhvien]
	@masinhvien varchar(1500),
	@mamonhoc int,
	@tenphongthi varchar(30)
as 
begin
	update tblLichThi set masinhvien = @masinhvien where mamonhoc = @mamonhoc and tenphongthi = @tenphongthi
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateLoHoc]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateLoHoc]
	@nguoicapnhat varchar(30),
	@malophoc bigint,
	@magiaovien int,
	@mamonhoc int,
	@tietbatdau int,
	@ngayhoc int,
	@maphonghoc int
as
begin
	update tblLop
	set
		ngaycapnhap = getdate(),
		nguoicapnhap = @nguoicapnhat,		
		magiaovien = @magiaovien,
		tietbatdau = @tietbatdau,
		ngayhoc = @ngayhoc,
		maphonghoc = @maphonghoc
	where malophoc = @malophoc;
	if @@ROWCOUNT > 0 return 1 else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[updateMH]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateMH]
	@nguoicapnhat varchar(30),
	@mamonhoc bigint,
	@tenmonhoc nvarchar(150),
	@sotinchi int
as
begin
	update tblMonHoc
	set
		nguoicapnhap = @nguoicapnhat,
		ngaycapnhap = getdate(),
		tenmonhoc = @tenmonhoc,
		sotinchi = @sotinchi
	where mamonhoc = @mamonhoc;
	if @@ROWCOUNT > 0 return 1 else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateSinhVien]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateSinhVien]
--Khai báo danh sách tham số truyền vào
	@masinhvien varchar(50),
	@ho nvarchar(10),
	@tenDem nvarchar(20),
	@ten nvarchar(10),
	@ngaysinh date,
	@gioitinh tinyint,
	@quequan nvarchar(150),
	@diachi	 nvarchar(150),
	@dienthoai varchar(30),
	@email varchar(150)
AS
BEGIN
	UPDATE tblSinhVien
	SET
	ho = @ho,
	tendem = @tendem,
	ngaysinh = @ngaysinh,
	gioitinh = @gioitinh,
	diachi = @diachi,
	dienthoai = @dienthoai,
	email = @email
	WHERE masinhvien = @masinhvien;
	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
END
GO
/****** Object:  StoredProcedure [dbo].[xinchao]    Script Date: 5/28/2024 11:35:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[xinchao]
    @taikhoan VARCHAR(50),
    @loaitaikhoan VARCHAR(50)
AS
BEGIN
    IF @loaitaikhoan = 'sv'
    BEGIN
        SELECT 
            CASE 
                WHEN LEN(tendem) > 0 THEN CONCAT(ho, ' ', tendem, ' ', ten)
                ELSE CONCAT(ho, ' ', ten) 
            END AS hoten
        FROM 
            tblSinhVien
        WHERE 
            masinhvien = @taikhoan;
    END
    ELSE IF @loaitaikhoan = 'gv'
    BEGIN
        SELECT 
            CASE 
                WHEN LEN(tendem) > 0 THEN CONCAT(ho, ' ', tendem, ' ', ten)
                ELSE CONCAT(ho, ' ', ten) 
            END AS hoten
        FROM 
            tblGiangVien
        WHERE 
            magiaovien = @taikhoan;
    END
END
GO
USE [master]
GO
ALTER DATABASE [Quanlysinhvienhumg] SET  READ_WRITE 
GO
