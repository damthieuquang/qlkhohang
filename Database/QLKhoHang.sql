create database QLKhoHang

/* Tao Bang */
/* Don Hang*/
CREATE TABLE DonHang (
	MaDonHang varchar(15),
	NgayLap datetime,
	MaNhanVien varchar(5),
	ThanhTien float ,
	TrangThai nvarchar(15),
	Xoa bit  DEFAULT 0

	PRIMARY KEY (MaDonHang)
) 


/* Chi Tiet Don Hang*/
CREATE TABLE ChiTietDonHang 
(
	MaChiTietDonHang varchar(18) ,
	MaDonHang varchar(15)  ,
	MaSanPham varchar(5)  ,
	CV int ,
	SoLuong int ,
	DonGia float ,
	ThanhTien float ,
	SLDaNhan int ,
	Xoa bit  DEFAULT 0 
	
	PRIMARY KEY (MaChiTietDonHang)
) 

/* San Pham*/
CREATE TABLE SanPham 
(
	MaSanPham varchar(5)  ,
	TenSanPham nvarchar(100)  ,
	CV int ,
	DonGia float ,
	DonGiaTV float ,
	SoLuongTon int ,
	MaLoaiSanPham varchar(5) ,
	Xoa bit  DEFAULT 0 
	
	PRIMARY KEY (MaSanPham)
) 

/* Loai San Pham*/
CREATE TABLE  LoaiSanPham 
(
	MaLoaiSanPham varchar(5)  ,
	TenLoaiSanPham nvarchar(100)  ,
	Xoa bit  DEFAULT 0 
	
	PRIMARY KEY (MaLoaiSanPham)
) 

/* Nhan Vien*/
CREATE TABLE NhanVien 
(
	MaNhanVien varchar(5)  ,
	TenNhanVien nvarchar(100)  ,
	MatKhau varchar(20)  ,
	LoaiNhanVien int,
	Xoa bit  DEFAULT 0 

	PRIMARY KEY (MaNhanVien)
) 

/* Tham So */
CREATE TABLE ThamSo 
(
	MaThamSo varchar(5)  ,
	TenThamSo varchar(20) ,
	GiaTri nvarchar (100) ,
	Xoa bit  DEFAULT 0 
	
	PRIMARY KEY (MaThamSo)
)

/* Phieu Nhap */
CREATE TABLE PhieuNhap 
(
	MaPhieuNhap varchar(15)  ,
	MaDonHang varchar(15)  ,
	NgayNhan datetime ,
	MaNhanVien varchar(5)  ,
	Xoa bit  DEFAULT 0 
	
	PRIMARY KEY (MaPhieuNhap)
)

/* Chi Tiet Phieu Nhap */
CREATE TABLE ChiTietPhieuNhap 
(
	MaChiTietPhieuNhap varchar(18)  ,
	MaPhieuNhap varchar(15)  ,
	MaSanPham varchar(5) ,
	SLNhan int ,
	GhiChu nvarchar(255)  ,
	Xoa bit  DEFAULT 0 
	
	PRIMARY KEY (MaChiTietPhieuNhap)
) 

/* Phieu Xuat */
CREATE TABLE PhieuXuat 
(
	MaPhieuXuat varchar(15)  ,
	NgayBan datetime ,
	MaThanhVien varchar(5)  ,
	MaNhanVien varchar(5)  ,
	TenKhachHang nvarchar(100)  ,
	DiaChi nvarchar(255)  ,
	MaLoaiPhieuXuat varchar(5),
	Xoa bit  DEFAULT 0 
	
	PRIMARY KEY (MaPhieuXuat)
) 

/* Chi Tiet Phieu Xuat */
CREATE TABLE ChiTietPhieuXuat 
(
	MaChiTietPhieuXuat varchar(18) ,
	MaPhieuXuat varchar(15)  ,
	MaSanPham varchar(5)  ,
	CV int ,
	DonGia float ,
	SoLuong int ,
	ThanhTien float ,
	Xoa bit  DEFAULT 0 
	
	PRIMARY KEY (MaChiTietPhieuXuat)
) 

/* Loai Phieu Xuat */
CREATE TABLE LoaiPhieuXuat 
(
	MaLoaiPhieuXuat  varchar(5) ,
	TenLoaiPhieuXuat  nvarchar(20)  ,
	Xoa bit  DEFAULT 0 
	
	PRIMARY KEY (MaLoaiPhieuXuat)
)

/* Thanh Vien */
CREATE TABLE ThanhVien
(
	MaThanhVien varchar(5) ,
	TenThanhVien nvarchar(50)  ,
	DiaChi nvarchar(255)  ,
	CV int ,
	TienNo float ,
	Xoa bit  DEFAULT 0 
	
	PRIMARY KEY (MaThanhVien)
) 


/* Khoa Ngoai */
/* Don Hang */
alter table DonHang
add constraint FK_DonHang_NhanVien
foreign key (MaNhanVien)
references NhanVien (MaNhanVien)

/* Chi Thiet Don Hang */
alter table ChiTietDonHang
add constraint FK_ChiTietDonHang_DonHang
foreign key (MaDonHang)
references DonHang (MaDonHang)

alter table ChiTietDonHang
add constraint FK_ChiTietDonHang_SanPham
foreign key (MaSanPham)
references SanPham (MaSanPham)

/* San Pham */
alter table SanPham
add constraint FK_SanPham_LoaiSanPham
foreign key (MaLoaiSanPham)
references LoaiSanPham (MaLoaiSanPham)

/* Phieu Nhap */
alter table PhieuNhap
add constraint FK_PhieuNhap_DonHang
foreign key (MaDonHang)
references DonHang (MaDonHang)

alter table PhieuNhap
add constraint FK_PhieuNhap_NhanVien
foreign key (MaNhanVien)
references NhanVien (MaNhanVien)

/* Chi Tiet Phieu Nhap */
alter table ChiTietPhieuNhap
add constraint FK_ChiTietPhieuNhap_PhieuNhap
foreign key (MaPhieuNhap)
references PhieuNhap (MaPhieuNhap)

alter table ChiTietPhieuNhap
add constraint FK_ChiTietPhieuNhap_SanPham
foreign key (MaSanPham)
references SanPham (MaSanPham)


/* Phieu Xuat */
alter table PhieuXuat
add constraint FK_PhieuXuat_ThanhVien
foreign key (MaThanhVien)
references ThanhVien(MaThanhVien)

alter table PhieuXuat
add constraint FK_PhieuXuat_NhanVien
foreign key (MaNhanVien)
references NhanVien (MaNhanVien)

alter table PhieuXuat
add constraint FK_PhieuXuat_LoaiPhieuXuat
foreign key (MaLoaiPhieuXuat)
references LoaiPhieuXuat (MaLoaiPhieuXuat)


/* Chi Tiet Phieu Xuat */
alter table ChiTietPhieuXuat
add constraint FK_ChiTietPhieuXuat_PhieuXuat
foreign key (MaPhieuXuat)
references PhieuXuat (MaPhieuXuat)

alter table ChiTietPhieuXuat
add constraint FK_ChiTietPhieuXuat_SanPham
foreign key (MaSanPham)
references SanPham (MaSanPham)


/* Nhap Du Lieu */ 
/* Tham So */
insert into ThamSo values ('TS001','ChietKhau',N'0.4',0)
insert into ThamSo values('TS002','MaStockist',N'MaStockist',0)
insert into ThamSo values ('TS003','DiaChiStockist',N'DiaChiStockist',0)
insert into ThamSo values ('TS004','TongCV',N'0',0)

/* Loai San Pham */
insert into LoaiSanPham VALUES ('LSP01',N'Synergy',0)
insert into LoaiSanPham VALUES ('LSP02',N'Tài liệu hỗ trợ kinh doanh',0)

/* San Pham */
insert into SanPham VALUES('74187',N'Liquid Chlorophyll 2 oz',2,63636,63636, 0, 'LSP01', 0) 
insert into SanPham VALUES ('74191',N'Liquid Chlorophyll 32 oz',15,372727,372727, 0, 'LSP01', 0) 
insert into SanPham VALUES ('74888',N'Liquid Chlorophyll 25 oz',12,327273,327273, 0, 'LSP01', 0) 
insert into SanPham VALUES ('74005',N'Mistica',25,772727,772727, 0, 'LSP01', 0) 
insert into SanPham VALUES ('74162',N'Pro Argi 9',40,1227273,1227273, 0, 'LSP01', 0) 
insert into SanPham VALUES ('74167',N'Pro Argi 9 hộp giấy',40,1227273,1227273, 0, 'LSP01', 0) 
insert into SanPham VALUES  ('77247',N'Starter Kit',0,163637,163637, 0, 'LSP02', 0) 
insert into SanPham VALUES  ('77207',N'Túi giấy',0,5453,5453, 0, 'LSP02', 0) 
insert into SanPham VALUES  ('77203',N'Ví để Business Card',0,27273,27273, 0, 'LSP02', 0) 
insert into SanPham VALUES  ('77204',N'Tờ rơi sản phẩm Pro argi 9 Plus',0,1600,1600, 0, 'LSP02', 0) 
insert into SanPham VALUES  ('77205',N'Tờ rơi sản phẩm Mistica',0,1600,1600, 0, 'LSP02', 0) 
insert into SanPham VALUES  ('77206',N'Tờ rơi sản phẩm Chlorophyll',0,1600,1600, 0, 'LSP02', 0) 
insert into SanPham VALUES  ('77171',N'Bộ chứng nhận tiêu chuẩn chất lượng sp',0,27273,27273, 0, 'LSP02', 0) 
insert into SanPham VALUES  ('77169',N'Bộ hợp đồng đăng ký Thành viên',0,22727,22727, 0, 'LSP02', 0) 

/* Loai Phieu Xuat */
insert into LoaiPhieuXuat VALUES('LPX01',N'Thành Viên',0) 
insert into LoaiPhieuXuat VALUES('LPX02',N'Thông Thường', 0) 

/* Nhan Vien */
insert into NhanVien VALUES('NV001',N'Hoa', '123456', 0, 0) 
insert into NhanVien VALUES('NV002',N'Trần Quang Hậu', '123456', 1, 0) 

/* Thanh Vien */
insert into ThanhVien VALUES('TV001',N'Hoa', N'TPHCM', 0, 0, 0) 




