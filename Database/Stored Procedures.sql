/* Mọi người viết các Stored Procedures - Function vào file này */
/* ------------------- Don Hang---------------------*/

/* Insert Don Hang - Tran Quang Hau*/
create procedure usp_InsertDonHang 
	@MaDonHang varchar(13),
	@NgayLap datetime,
	@MaNhanVien varchar(5),
	@ThanhTien float,
	@TrangThai nvarchar(15),
	@Xoa bit
as
begin
	insert into DonHang values 
	(
		@MaDonHang,
		@NgayLap,
		@MaNhanVien,
		@ThanhTien,
		@TrangThai,
		@Xoa
	)
end

/* Select Don Hang - Nguyen Hoang Long */
create proc usp_SelectDonHangAll 
as
	begin
				select dh.MaDonHang, dh.NgayLap, dh.MaNhanVien, dh.ThanhTien, dh.TrangThai
				from DonHang dh				
				where dh.Xoa = 0
	end
go
/* Select Don Hang By Id - Nguyen Hoang Long */
create proc usp_SelectDonHangById @MaDonHang varchar(15)
as
	begin
				select dh.MaDonHang, dh.NgayLap, dh.MaNhanVien, dh.ThanhTien, dh.TrangThai
				from DonHang dh		
				where dh.MaDonHang = @MaDonHang		and dh.Xoa = 0
	end
go

/* Xoa Don Hang - Dam Thieu Quang*/
create procedure usp_DeleteDonHangById @MaDonHang varchar(15)
as
begin
	/*xoa chi tiet don hang*/
	update	ChiTietDonHang
	set		Xoa = 1
	where	MaDonHang = @MaDonHang
	
	/*xoa Phieu nhap*/
	update	PhieuNhap
	set		Xoa = 1
	where	MaDonHang = @MaDonHang

	update	DonHang
	set		Xoa = 1
	where	MaDonHang = @MaDonHang
end

/* Update Don Hang - Dam Thieu Quang*/
create procedure usp_UpdateDonHangById 
	@MaDonHang varchar(15),
	@NgayLap datetime,
	@MaNhanVien varchar(5),
	@ThanhTien float,
	@TrangThai nvarchar(15)
as
begin
	update	DonHang
	set		NgayLap = @NgayLap, MaNhanVien = @MaNhanVien, ThanhTien = @ThanhTien, TrangThai = @TrangThai
	where	MaDonHang = @MaDonHang
end
								
/* ------------------- Chi Tiet Don Hang---------------------*/

/* Select Chi Tiet Don Hang - Nguyen Hoang Long */
create proc usp_SelectChiTietDonHangAll 
as
	begin
				select ct.MaChiTietDonHang, ct.MaDonHang, ct.MaSanPham, ct.CV, ct.SoLuong, ct.DonGia, ct.ThanhTien
				from ChiTietDonHang ct			
				where ct.Xoa = 0
	end
go

/* Select Chi Tiet Don Hang By Id - Nguyen Hoang Long */
create proc usp_SelectChiTietDonHangById @MaChiTietDonHang varchar(18)
as
	begin
				select ct.MaChiTietDonHang, ct.MaDonHang, ct.MaSanPham, ct.CV, ct.SoLuong, ct.DonGia, ct.ThanhTien
				from ChiTietDonHang ct
				where ct.MaChiTietDonHang = @MaChiTietDonHang		and  ct.Xoa = 0
	end
go

/* Xoa Chi Tiet Don Hang - Dam Thieu Quang*/
create procedure usp_DeleteChiTietDonHangById @MaChiTietDonHang varchar(18)
as
begin
	update	ChiTietDonHang
	set		Xoa = 1
	where	MaChiTietDonHang = @MaChiTietDonHang
end

/* Update Chi Tiet Don Hang - Dam Thieu Quang*/
create procedure usp_UpdateChiTietDonHangById 
	@MaChiTietDonHang varchar(18),
	@MaDonHang varchar(15),
	@MaSanPham varchar(5),
	@CV int,
	@SoLuong int,
	@DonGia float,
	@ThanhTien float
as
begin
	update	ChiTietDonHang
	set		MaDonHang = @MaDonHang,  MaSanPham = @MaSanPham, CV = @CV, SoLuong = @SoLuong, DonGia = @DonGia, ThanhTien = @ThanhTien
	where	MaChiTietDonHang = @MaChiTietDonHang
end

/* ------------------- San Pham---------------------*/

/* Select San Pham - Nguyen Hoang Long */
create proc usp_SelectSanPhamAll
as
	begin
				select sp.MaSanPham, sp.TenSanPham, sp.CV, sp.DonGia, sp.DonGiaTV, sp.SoLuongTon, sp.MaLoaiSanPham
				from SanPham sp
				where  sp.Xoa = 0
	end
go

/* Select San Pham By Id - Nguyen Hoang Long */
create proc usp_SelectSanPhamById @MaSanPham varchar(5)
as
	begin
				select sp.MaSanPham, sp.TenSanPham, sp.CV, sp.DonGia, sp.DonGiaTV, sp.SoLuongTon, sp.MaLoaiSanPham
				from SanPham sp
				where sp.MaSanPham = @MaSanPham and  sp.Xoa = 0
	end
go

/* Xoa San Pham - Dam Thieu Quang*/
create procedure usp_DeleteSanPhamById @MaSanPham varchar(5)
as
begin
	update	ChiTietDonHang
	set		Xoa = 1
	where	MaSanPham = @MaSanPham

	update	ChiTietPhieuXuat
	set		Xoa = 1
	where	MaSanPham = @MaSanPham

	update	ChiTietPhieuNhap
	set		Xoa = 1
	where	MaSanPham = @MaSanPham

	update	SanPham
	set		Xoa = 1
	where	MaSanPham = @MaSanPham
end

/* Update San Pham - Dam Thieu Quang*/
create procedure usp_UpdateSanPhamById 
	@MaSanPham varchar(5),
	@TenSanPham nvarchar(100),
	@CV int,
	@DonGia float,
	@DonGiaTV float,
	@SoLuongTon int,
	@MaLoaiSanPham varchar(5)
as
begin
	update	SanPham
	set		TenSanPham = @TenSanPham, CV = @CV, DonGia = @DonGia, DonGiaTV = @DonGiaTV, SoLuongTon = @SoLuongTon,MaLoaiSanPham = @MaLoaiSanPham
	where	MaSanPham = @MaSanPham
end
/* ------------------- Loai San Pham ---------------------*/

/* Select Loai San Pham - Nguyen Hoang Long */
create proc usp_SelectLoaiSanPhamAll
as
	begin
				select lsp.MaLoaiSanPham, lsp.TenLoaiSanPham
				from LoaiSanPham lsp 
				where  lsp.Xoa = 0
	end
go

/* Select Loai San Pham By Id - Nguyen Hoang Long */
create proc usp_SelectLoaiSanPhamById @MaLoaiSanPham varchar(5)
as
	begin
				select lsp.MaLoaiSanPham, lsp.TenLoaiSanPham, lsp.Xoa
				from LoaiSanPham lsp
				where lsp.MaLoaiSanPham  = @MaLoaiSanPham and  lsp.Xoa = 0
	end
go

/* Xoa Loai San Pham - Dam Thieu Quang*/
create procedure usp_DeleteLoaiSanPhamById @MaLoaiSanPham varchar(5)
as
begin
	update	SanPham
	set		Xoa = 1
	where	MaLoaiSanPham = @MaLoaiSanPham

	update	LoaiSanPham
	set		Xoa = 1
	where	MaLoaiSanPham = @MaLoaiSanPham
end

/* Update Loai San Pham - Dam Thieu Quang*/
create procedure usp_UpdateLoaiSanPhamById 
	@MaLoaiSanPham varchar(5),
	@TenLoaiSanPham nvarchar(100)
as
begin
	update	LoaiSanPham
	set		TenLoaiSanPham = @TenLoaiSanPham
	where	MaLoaiSanPham = @MaLoaiSanPham
end


/* ------------------- Tham So ---------------------*/

/* Select Tham So - Nguyen Hoang Long */
create proc usp_SelectThamSoAll
as
	begin
				select ts.MaThamSo, ts.TenThamSo, ts.GiaTri
				from ThamSo ts
				where ts.Xoa = 0
	end
go

/* Select Tham So By Id - Nguyen Hoang Long */
create proc usp_SelectThamSoById @MaThamSo varchar(5)
as
	begin
				select ts.MaThamSo, ts.TenThamSo, ts.GiaTri, ts.Xoa
				from ThamSo ts
				where ts.MaThamSo = @MaThamSo and  ts.Xoa = 0
	end
go

/* Xoa Tham So - Dam Thieu Quang*/
create procedure usp_DeleteThamSoById @MaThamSo varchar(5)
as
begin
	update	ThamSo
	set		Xoa = 1
	where	MaThamSo = @MaThamSo
end

/* Update Tham So - Dam Thieu Quang*/
create procedure usp_UpdateThamSoById 
	@MaThamSo varchar(5),
	@TenThamSo varchar(20),
	@GiaTri nvarchar (100)
as
begin
	update	ThamSo
	set		TenThamSo = @TenThamSo, GiaTri = @GiaTri
	where	MaThamSo = @MaThamSo
end

/* ------------------- Nhan Vien---------------------*/

/* Select Nhan Vien By Id - Nguyen Hoang Long */
create proc usp_SelectNhanVienAll
as
	begin
				select nv.MaNhanVien, nv.TenNhanVien, nv.MatKhau, nv.LoaiNhanVien
				from NhanVien nv
				where nv.Xoa = 0
	end
go

/* Select Nhan Vien By Id - Nguyen Hoang Long */
create proc usp_SelectNhanVienById @MaNhanVien varchar(5)
as
	begin
				select nv.MaNhanVien, nv.TenNhanVien, nv.MatKhau, nv.LoaiNhanVien
				from NhanVien nv
				where nv.MaNhanVien = @MaNhanVien and nv.Xoa = 0
	end
go

/* Xoa Nhan Vien - Dam Thieu Quang*/
create procedure usp_DeleteNhanVienById @MaNhanVien varchar(5)
as
begin
	/*Xoa Don hang*/
	update	DonHang
	set		Xoa = 1
	where	MaNhanVien = @MaNhanVien

	/*Xoa Phieu Nhap*/
	update	PhieuNhap
	set		Xoa = 1
	where	MaNhanVien = @MaNhanVien

	/*Xoa Phieu Xuat*/
	update	PhieuXuat
	set		Xoa = 1
	where	MaNhanVien = @MaNhanVien

	update	NhanVien
	set		Xoa = 1
	where	MaNhanVien = @MaNhanVien
end

/* Update Nhan Vien - Dam Thieu Quang*/
create procedure usp_UpdateNhanVienById 
	@MaNhanVien varchar(5),
	@TenNhanVien nvarchar(100),
	@MatKhau varchar(20),
	@LoaiNhanVien int
as
begin
	update	NhanVien
	set		TenNhanVien = @TenNhanVien,	MatKhau = @MatKhau, LoaiNhanVien = @LoaiNhanVien
	where	MaNhanVien = @MaNhanVien
end
/* ------------------- Phieu Nhap ---------------------*/

/* Select Phieu Nhap By Id - Nguyen Hoang Long */
create proc usp_SelectPhieuNhapAll
as
	begin	
				select pn.MaPhieuNhap, pn.MaDonHang, pn.NgayNhan, pn.MaNhanVien
				from PhieuNhap pn
				where  pn.Xoa = 0
	end
go

/* Select Phieu Nhap By Id - Nguyen Hoang Long */
create proc usp_SelectPhieuNhapById @MaPhieuNhap varchar(15)
as
	begin	
				select pn.MaPhieuNhap, pn.MaDonHang, pn.NgayNhan, pn.MaNhanVien
				from PhieuNhap pn
				where pn.MaPhieuNhap = @MaPhieuNhap and  pn.Xoa = 0
	end
go

/* Xoa Phieu Nhap - Dam Thieu Quang*/
create procedure usp_DeletePhieuNhapById @MaPhieuNhap varchar(15)
as
begin
	/*xoa chi tiet phieu nhap*/
	update	ChiTietPhieuNhap
	set		Xoa = 1
	where	MaPhieuNhap = @MaPhieuNhap

	update	PhieuNhap
	set		Xoa = 1
	where	MaPhieuNhap = @MaPhieuNhap
end

/* Update Phieu Nhap - Dam Thieu Quang*/
create procedure usp_UpdatePhieuNhapById 
	@MaPhieuNhap varchar(15),
	@MaDonHang varchar(15),
	@NgayNhan datetime,
	@MaNhanVien varchar(5)
as
begin
	update	PhieuNhap
	set		MaDonHang = @MaDonHang, NgayNhan = @NgayNhan, MaNhanVien = @MaNhanVien
	where	MaPhieuNhap = @MaPhieuNhap
end

/* ------------------- Chi Tiet Phieu Nhap---------------------*/

/* Select Chi Tiet Phieu Nhap - Nguyen Hoang Long */
create proc usp_SelectChiTietPhieuNhapAll
as
	begin
				select ct.MaChiTietPhieuNhap, ct.MaPhieuNhap, ct.MaSanPham, ct.SoLuong, ct.SLDaNhan, ct.SLConLai, ct.GhiChu
				from ChiTietPhieuNhap ct
				where  ct.Xoa = 0
	end
go

/* Select Chi Tiet Phieu Nhap By Id - Nguyen Hoang Long */
create proc usp_SelectChiTietPhieuNhapById @MaChiTietPhieuNhap varchar(18)
as
	begin
				select ct.MaChiTietPhieuNhap, ct.MaPhieuNhap, ct.MaSanPham, ct.SoLuong, ct.SLDaNhan, ct.SLConLai, ct.GhiChu
				from ChiTietPhieuNhap ct
				where ct.MaChiTietPhieuNhap = @MaChiTietPhieuNhap and  ct.Xoa = 0
	end
go

/* Xoa Chi Tiet Phieu Nhap - Dam Thieu Quang*/
create procedure usp_DeleteChiTietPhieuNhapById @MaChiTietPhieuNhap varchar(18)
as
begin
	update	ChiTietPhieuNhap
	set		Xoa = 1
	where	MaChiTietPhieuNhap = @MaChiTietPhieuNhap
end

/* Update Chi Tiet Phieu Nhap - Dam Thieu Quang*/
create procedure usp_UpdateChiTietPhieuNhapById
	@MaChiTietPhieuNhap varchar(18), 
	@MaPhieuNhap varchar(15),
	@MaSanPham varchar(5),
	@SoLuong int,
	@SLDaNhan int,
	@SLConLai int,
	@GhiChu nvarchar(255)
as
begin
	update	ChiTietPhieuNhap
	set		MaPhieuNhap = @MaPhieuNhap, MaSanPham = @MaSanPham, SoLuong = @SoLuong, SLDaNhan = @SLDaNhan, SLConLai = @SLConLai, GhiChu = @GhiChu
	where	MaChiTietPhieuNhap = @MaChiTietPhieuNhap
end


/* ------------------- Phieu Xuat ---------------------*/

/* Select Phieu Xuat By Id - Nguyen Hoang Long */
create proc usp_SelectPhieuXuatAll
as
	begin
				select px.MaPhieuXuat, px.NgayBan, px.MaThanhVien, px.MaNhanVien, px.TenKhachHang, px.DiaChi, px.MaLoaiPhieuXuat
				from PhieuXuat px
				where  px.Xoa = 0
	end
go

/* Select Phieu Xuat By Id - Nguyen Hoang Long */
create proc usp_SelectPhieuXuatById @MaPhieuXuat varchar(15)
as
	begin
				select px.MaPhieuXuat, px.NgayBan, px.MaThanhVien, px.MaNhanVien, px.TenKhachHang, px.DiaChi, px.MaLoaiPhieuXuat
				from PhieuXuat px
				where px.MaPhieuXuat = @MaPhieuXuat and  px.Xoa = 0
	end
go

/* Xoa Phieu Xuat - Dam Thieu Quang*/
create procedure usp_DeletePhieuXuatById @MaPhieuXuat varchar(15)
as
begin
	/* Xoa chi tiet phieu xuat */
	update	ChiTietPhieuXuat
	set		Xoa = 1
	where	MaPhieuXuat = @MaPhieuXuat

	update	PhieuXuat
	set		Xoa = 1
	where	MaPhieuXuat = @MaPhieuXuat
end

/* Update Phieu Xuat - Dam Thieu Quang*/
create procedure usp_UpdatePhieuXuatById
	@MaPhieuXuat varchar(15), 
	@NgayBan datetime,
	@MaThanhVien varchar(5),
	@MaNhanVien varchar(5),
	@TenKhachHang nvarchar(100),
	@DiaChi nvarchar(255),
	@MaLoaiPhieuXuat varchar(5)
as
begin
	update	PhieuXuat
	set		NgayBan = @NgayBan, MaThanhVien = @MaThanhVien, MaNhanVien = @MaNhanVien, TenKhachHang = @TenKhachHang, DiaChi = @DiaChi, MaLoaiPhieuXuat = @MaLoaiPhieuXuat
	where	MaPhieuXuat = @MaPhieuXuat
end

/* ------------------- Chi Tiet Phieu Xuat ---------------------*/

/* Select Chi Tiet Phieu Xuat - Nguyen Hoang Long */
create proc usp_SelectChiTietPhieuXuatAll
as
	begin
				select ct.MaChiTietPhieuXuat, ct.MaPhieuXuat, ct.MaSanPham, ct.CV, ct.DonGia, ct.SoLuong, ct.ThanhTien
				from ChiTietPhieuXuat ct
				where  ct.Xoa = 0
	end
go

/* Select Chi Tiet Phieu Xuat By Id - Nguyen Hoang Long */
create proc usp_SelectChiTietPhieuXuatById @MaChiTietPhieuXuat varchar(18)
as
	begin
				select ct.MaChiTietPhieuXuat, ct.MaPhieuXuat, ct.MaSanPham, ct.CV, ct.DonGia, ct.SoLuong, ct.ThanhTien
				from ChiTietPhieuXuat ct
				where ct.MaChiTietPhieuXuat = @MaChiTietPhieuXuat and  ct.Xoa = 0
	end
go

/* Xoa Chi Tiet Phieu Xuat - Dam Thieu Quang*/
create procedure usp_DeleteChiTietPhieuXuatById @MaChiTietPhieuXuat varchar(18)
as
begin
	update	ChiTietPhieuXuat
	set		Xoa = 1
	where	MaChiTietPhieuXuat = @MaChiTietPhieuXuat
end

/* Update Chi Tiet Phieu Xuat - Dam Thieu Quang*/
create procedure usp_UpdateChiTietPhieuXuatById
	@MaChiTietPhieuXuat varchar(18),
	@MaPhieuXuat varchar(15), 
	@MaSanPham varchar(5),
	@CV int,
	@DonGia float,
	@SoLuong int,
	@ThanhTien float
as
begin
	update	ChiTietPhieuXuat
	set		MaPhieuXuat = @MaPhieuXuat, MaSanPham = @MaSanPham, CV = @CV, DonGia = @DonGia, SoLuong = @SoLuong, ThanhTien = @ThanhTien
	where	MaChiTietPhieuXuat = @MaChiTietPhieuXuat
end


/* ------------------- Loai Phieu Xuat ---------------------*/

/* Select Loai Phieu Xuat - Nguyen Hoang Long */
create proc usp_SelectLoaiPhieuXuatAll
as
	begin
				select lpx.MaLoaiPhieuXuat, lpx.TenLoaiPhieuXuat
				from LoaiPhieuXuat lpx
				where  lpx.Xoa = 0
	end
go

/* Select Loai Phieu Xuat By Id - Nguyen Hoang Long */
create proc usp_SelectLoaiPhieuXuatById @MaLoaiPhieuXuat varchar(5)
as
	begin
				select lpx.MaLoaiPhieuXuat, lpx.TenLoaiPhieuXuat
				from LoaiPhieuXuat lpx
				where lpx.MaLoaiPhieuXuat = @MaLoaiPhieuXuat and  lpx.Xoa = 0
	end
go

/* Xoa Loai Phieu Xuat - Dam Thieu Quang*/
create procedure usp_DeleteLoaiPhieuXuatById @MaLoaiPhieuXuat varchar(5)
as
begin
	update	PhieuXuat
	set		Xoa = 1
	where	MaLoaiPhieuXuat = @MaLoaiPhieuXuat

	update	LoaiPhieuXuat
	set		Xoa = 1
	where	MaLoaiPhieuXuat = @MaLoaiPhieuXuat
end

/* Update Loai Phieu Xuat - Dam Thieu Quang*/
create procedure usp_UpdateLoaiPhieuXuatById
	@MaLoaiPhieuXuat varchar(5),
	@TenLoaiPhieuXuat nvarchar(20)
as
begin
	update	LoaiPhieuXuat
	set		TenLoaiPhieuXuat = @TenLoaiPhieuXuat
	where	MaLoaiPhieuXuat = @MaLoaiPhieuXuat
end

/* ------------------- Thanh Vien ---------------------*/

/* Select Thanh Vien By Id - Nguyen Hoang Long */
create proc usp_SelectThanhVienAll
as
	begin
				select tv.MaThanhVien, tv.TenThanhVien, tv.DiaChi, tv.CV, tv.TienNo
				from ThanhVien tv
				where  tv.Xoa = 0
	end
go

/* Select Thanh Vien By Id - Nguyen Hoang Long */
create proc usp_SelectThanhVienById @MaThanhVien varchar(5)
as
	begin
				select tv.MaThanhVien, tv.TenThanhVien, tv.DiaChi, tv.CV, tv.TienNo
				from ThanhVien tv
				where tv.MaThanhVien = @MaThanhVien and  tv.Xoa = 0
	end
go

/* Xoa Thanh Vien - Dam Thieu Quang*/
create procedure usp_DeleteThanhVienById @MaThanhVien varchar(5)
as
begin
	/*Xoa phieu xuat */
	update	PhieuXuat
	set		Xoa = 1
	where	MaThanhVien = @MaThanhVien
	
	update	ThanhVien
	set		Xoa = 1
	where	MaThanhVien = @MaThanhVien
end

/* Update Thanh Vien - Dam Thieu Quang*/
create procedure usp_UpdateThanhVienById
	@MaThanhVien varchar(5),
	@TenThanhVien nvarchar(50),
	@DiaChi nvarchar(255),
	@CV int,
	@TienNo float
as
begin
	update	ThanhVien
	set		TenThanhVien = @TenThanhVien, DiaChi = @DiaChi, CV = @CV, TienNo = @TienNo
	where	MaThanhVien = @MaThanhVien
end






