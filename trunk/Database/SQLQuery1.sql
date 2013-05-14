create database banhang


CREATE TABLE chitietdathang (
  MaCTDH varchar(255) NOT NULL,
  MaDatHang varchar(255)  NOT NULL,
  MaSanPham varchar(255)  NOT NULL,
  CV int NOT NULL,
  SoLuong int NOT NULL,
  DonGia float NOT NULL,
  ThanhTien float NOT NULL,
  PRIMARY KEY (MaCTDH)
) 

CREATE TABLE chitietphieunhap (
  MaCTPN varchar(255)  NOT NULL,
  MaPhieuNhap varchar(255)  NOT NULL,
  MaSanPham varchar(255) NOT NULL,
  SoLuong int NOT NULL,
  SLDaNhan int NOT NULL,
  SLConLai int NOT NULL,
  GhiChu varchar(255)  NOT NULL,
  PRIMARY KEY (MaCTPN)
) 

-- --------------------------------------------------------

--
-- Table structure for table `chitietphieuxuat`
--

CREATE TABLE chitietphieuxuat (
  MaCTPX varchar(255) NOT NULL,
  MaPhieuXuat varchar(255)  NOT NULL,
  MaSanPham varchar(255)  NOT NULL,
  CV int NOT NULL,
  DonGia float NOT NULL,
  SoLuong int NOT NULL,
  ThanhTien float NOT NULL,
  PRIMARY KEY (MaCTPX)
) 

-- --------------------------------------------------------

--
-- Table structure for table `dathang`
--

CREATE TABLE dathang (
  MaDatHang varchar(255)  NOT NULL,
  NgayLap datetime NOT NULL DEFAULT '0000-00-00',
  NguoiLap varchar(255)  NOT NULL,
  ThanhTien float NOT NULL,
  PRIMARY KEY (MaDatHang)
) 

-- --------------------------------------------------------

--
-- Table structure for table `loaisanpham`
--

CREATE TABLE  loaisanpham (
  MaLoaiSP varchar(255)  NOT NULL,
  TenLoaiSP varchar(255)  NOT NULL,
  PRIMARY KEY (MaLoaiSP)
) 

-- --------------------------------------------------------

--
-- Table structure for table `nhanvien`
--

CREATE TABLE nhanvien (
  MaNhanVien varchar(255)  NOT NULL,
  TenNhanVien varchar(255)  NOT NULL,
  MatKhau varchar(255)  NOT NULL,
  PRIMARY KEY (MaNhanVien)
) 

-- --------------------------------------------------------

--
-- Table structure for table `phieunhap`
--

CREATE TABLE phieunhap (
  MaPhieuNhap varchar(255)  NOT NULL,
  MaDatHang varchar(255)  NOT NULL,
  NgayNhan datetime NOT NULL DEFAULT '0000-00-00',
  MaNhanVien varchar(255)  NOT NULL,
  PRIMARY KEY (MaPhieuNhap)
)

-- --------------------------------------------------------

--
-- Table structure for table `phieuxuat`
--

CREATE TABLE phieuxuat (
  MaPhieuXuat varchar(255)  NOT NULL,
  NgayBan datetime NOT NULL DEFAULT '0000-00-00',
  MaNhanVien varchar(255)  NOT NULL,
  TenKhachHang varchar(255)  NOT NULL,
  DiaChi varchar(255)  NOT NULL,
  LoaiPhieuXuat int NOT NULL DEFAULT '1',
  PRIMARY KEY (MaPhieuXuat)
) 

-- --------------------------------------------------------

--
-- Table structure for table `sanpham`
--

CREATE TABLE sanpham (
  MaSanPham varchar(255)  NOT NULL,
  TenSanPham varchar(255)  NOT NULL,
  CV int NOT NULL,
  DonGia float NOT NULL,
  SoLuongTon int NOT NULL,
  MaLoaiSP varchar(255) NOT NULL,
  PRIMARY KEY (MaSanPham)
) 
-- --------------------------------------------------------

--
-- Table structure for table `thamso`
--

CREATE TABLE thamso (
  MaThamSo varchar(255)  NOT NULL,
  TenThamSo varchar(255) NOT NULL,
  GiaTri float NOT NULL,
  PRIMARY KEY (MaThamSo)
) 