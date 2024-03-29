USE [QLKhoHang]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 03/08/2014 11:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [varchar](5) NOT NULL,
	[TenLoaiSanPham] [nvarchar](100) NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 03/08/2014 11:03:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](5) NOT NULL,
	[TenNhanVien] [nvarchar](100) NULL,
	[MatKhau] [varchar](20) NULL,
	[LoaiNhanVien] [int] NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThamSo]    Script Date: 03/08/2014 11:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThamSo](
	[MaThamSo] [varchar](5) NOT NULL,
	[TenThamSo] [varchar](20) NULL,
	[GiaTri] [nvarchar](100) NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaThamSo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiPhieuXuat]    Script Date: 03/08/2014 11:03:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiPhieuXuat](
	[MaLoaiPhieuXuat] [varchar](5) NOT NULL,
	[TenLoaiPhieuXuat] [nvarchar](20) NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhieuXuat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 03/08/2014 11:03:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[MaThanhVien] [varchar](5) NOT NULL,
	[TenThanhVien] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[CV] [int] NULL,
	[TienNo] [float] NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaThanhVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 03/08/2014 11:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [varchar](15) NOT NULL,
	[MaDonHang] [varchar](15) NULL,
	[NgayNhan] [datetime] NULL,
	[MaNhanVien] [varchar](5) NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 03/08/2014 11:03:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaChiTietDonHang] [varchar](18) NOT NULL,
	[MaDonHang] [varchar](15) NULL,
	[MaSanPham] [varchar](5) NULL,
	[CV] [int] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
	[SLDaNhan] [int] NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaChiTietDonHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 03/08/2014 11:03:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaChiTietPhieuNhap] [varchar](18) NOT NULL,
	[MaPhieuNhap] [varchar](15) NULL,
	[MaSanPham] [varchar](5) NULL,
	[SLNhan] [int] NULL,
	[GhiChu] [nvarchar](255) NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 03/08/2014 11:03:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuat](
	[MaChiTietPhieuXuat] [varchar](18) NOT NULL,
	[MaPhieuXuat] [varchar](15) NULL,
	[MaSanPham] [varchar](5) NULL,
	[CV] [int] NULL,
	[DonGia] [float] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuXuat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 03/08/2014 11:03:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [varchar](5) NOT NULL,
	[TenSanPham] [nvarchar](100) NULL,
	[CV] [int] NULL,
	[DonGia] [float] NULL,
	[DonGiaTV] [float] NULL,
	[SoLuongTon] [int] NULL,
	[MaLoaiSanPham] [varchar](5) NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 03/08/2014 11:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPhieuXuat] [varchar](15) NOT NULL,
	[NgayBan] [datetime] NULL,
	[MaThanhVien] [varchar](5) NULL,
	[MaNhanVien] [varchar](5) NULL,
	[TenKhachHang] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[MaLoaiPhieuXuat] [varchar](5) NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 03/08/2014 11:03:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [varchar](15) NOT NULL,
	[NgayLap] [datetime] NULL,
	[MaNhanVien] [varchar](5) NULL,
	[ThanhTien] [float] NULL,
	[TrangThai] [nvarchar](15) NULL,
	[Xoa] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_ChiTietDonHang_DonHang]    Script Date: 03/08/2014 11:03:15 ******/
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_DonHang] FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_DonHang]
GO
/****** Object:  ForeignKey [FK_ChiTietDonHang_SanPham]    Script Date: 03/08/2014 11:03:15 ******/
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_SanPham]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_PhieuNhap]    Script Date: 03/08/2014 11:03:16 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_SanPham]    Script Date: 03/08/2014 11:03:16 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_SanPham]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuXuat_PhieuXuat]    Script Date: 03/08/2014 11:03:18 ******/
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PhieuXuat] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuXuat_SanPham]    Script Date: 03/08/2014 11:03:18 ******/
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_SanPham]
GO
/****** Object:  ForeignKey [FK_DonHang_NhanVien]    Script Date: 03/08/2014 11:03:19 ******/
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuNhap_DonHang]    Script Date: 03/08/2014 11:03:23 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_DonHang] FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_DonHang]
GO
/****** Object:  ForeignKey [FK_PhieuNhap_NhanVien]    Script Date: 03/08/2014 11:03:23 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuXuat_LoaiPhieuXuat]    Script Date: 03/08/2014 11:03:25 ******/
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_LoaiPhieuXuat] FOREIGN KEY([MaLoaiPhieuXuat])
REFERENCES [dbo].[LoaiPhieuXuat] ([MaLoaiPhieuXuat])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_LoaiPhieuXuat]
GO
/****** Object:  ForeignKey [FK_PhieuXuat_NhanVien]    Script Date: 03/08/2014 11:03:25 ******/
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuXuat_ThanhVien]    Script Date: 03/08/2014 11:03:25 ******/
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_ThanhVien] FOREIGN KEY([MaThanhVien])
REFERENCES [dbo].[ThanhVien] ([MaThanhVien])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_ThanhVien]
GO
/****** Object:  ForeignKey [FK_SanPham_LoaiSanPham]    Script Date: 03/08/2014 11:03:27 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
