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
				select dh.MaDonHang, dh.NgayLap, dh.MaNhanVien, dh.ThanhTien, dh.TrangThai, dh.Xoa
				from DonHang dh				
	end
go

/* Select Don Hang By Id - Nguyen Hoang Long */
create proc usp_SelectDonHangById @MaDonHang varchar(13)
as
	begin
				select dh.MaDonHang, dh.NgayLap, dh.MaNhanVien, dh.ThanhTien, dh.TrangThai, dh.Xoa
				from DonHang dh		
				where dh.MaDonHang = @MaDonHang		
	end
go

								
/* ------------------- Chi Tiet Don Hang---------------------*/

/* Select Chi Tiet Don Hang - Nguyen Hoang Long */
create proc usp_SelectChiTietDonHangAll 
as
	begin
				select ct.MaChiTietDonHang, ct.MaDonHang, ct.MaSanPham, ct.CV, ct.SoLuong, ct.DonGia, ct.ThanhTien, ct.Xoa
				from ChiTietDonHang ct			
	end
go

/* Select Chi Tiet Don Hang By Id - Nguyen Hoang Long */
create proc usp_SelectChiTietDonHangById @MaChiTietDonHang varchar(15)
as
	begin
				select ct.MaChiTietDonHang, ct.MaDonHang, ct.MaSanPham, ct.CV, ct.SoLuong, ct.DonGia, ct.ThanhTien, ct.Xoa
				from ChiTietDonHang ct
				where ct.MaChiTietDonHang = @MaChiTietDonHang		
	end
go


/* ------------------- San Pham---------------------*/

/* Select San Pham - Nguyen Hoang Long */
create proc usp_SelectSanPhamAll
as
	begin
				select sp.MaSanPham, sp.TenSanPham, sp.CV, sp.DonGia, sp.DonGiaTV, sp.SoLuongTon, sp.MaLoaiSanPham, sp.Xoa
				from SanPham sp
	end
go

/* Select San Pham By Id - Nguyen Hoang Long */
create proc usp_SelectSanPhamById @MaSanPham varchar(5)
as
	begin
				select sp.MaSanPham, sp.TenSanPham, sp.CV, sp.DonGia, sp.DonGiaTV, sp.SoLuongTon, sp.MaLoaiSanPham, sp.Xoa
				from SanPham sp
				where sp.MaSanPham = @MaSanPham
	end
go


/* ------------------- Loai San Pham ---------------------*/

/* Select Loai San Pham - Nguyen Hoang Long */
create proc usp_SelectLoaiSanPhamAll
as
	begin
				select lsp.MaLoaiSanPham, lsp.TenLoaiSanPham, lsp.Xoa
				from LoaiSanPham lsp
	end
go

/* Select Loai San Pham By Id - Nguyen Hoang Long */
create proc usp_SelectLoaiSanPhamById @MaLoaiSanPham varchar(5)
as
	begin
				select lsp.MaLoaiSanPham, lsp.TenLoaiSanPham, lsp.Xoa
				from LoaiSanPham lsp
				where lsp.MaLoaiSanPham  = @MaLoaiSanPham
	end
go


/* ------------------- Tham So ---------------------*/

/* Select Tham So - Nguyen Hoang Long */
create proc usp_SelectThamSoAll
as
	begin
				select ts.MaThamSo, ts.TenThamSo, ts.GiaTri, ts.Xoa
				from ThamSo ts
	end
go

/* Select Tham So By Id - Nguyen Hoang Long */
create proc usp_SelectThamSoById @MaThamSo varchar(5)
as
	begin
				select ts.MaThamSo, ts.TenThamSo, ts.GiaTri, ts.Xoa
				from ThamSo ts
				where ts.MaThamSo = @MaThamSo
	end
go


/* ------------------- Nhan Vien---------------------*/

/* Select Nhan Vien By Id - Nguyen Hoang Long */
create proc usp_SelectNhanVienAll
as
	begin
				select nv.MaNhanVien, nv.TenNhanVien, nv.MatKhau, nv.LoaiNhanVien, nv.Xoa
				from NhanVien nv
	end
go

/* Select Nhan Vien By Id - Nguyen Hoang Long */
create proc usp_SelectNhanVienById @MaNhanVien varchar(5)
as
	begin
				select nv.MaNhanVien, nv.TenNhanVien, nv.MatKhau, nv.LoaiNhanVien, nv.Xoa
				from NhanVien nv
				where nv.MaNhanVien = @MaNhanVien
	end
go


/* ------------------- Phieu Nhap ---------------------*/

/* Select Phieu Nhap By Id - Nguyen Hoang Long */
create proc usp_SelectPhieuNhapAll
as
	begin	
				select pn.MaPhieuNhap, pn.MaDonHang, pn.NgayNhan, pn.MaNhanVien, pn.Xoa
				from PhieuNhap pn
	end
go

/* Select Phieu Nhap By Id - Nguyen Hoang Long */
create proc usp_SelectPhieuNhapById @MaPhieuNhap varchar(13)
as
	begin	
				select pn.MaPhieuNhap, pn.MaDonHang, pn.NgayNhan, pn.MaNhanVien, pn.Xoa
				from PhieuNhap pn
				where pn.MaPhieuNhap = @MaPhieuNhap
	end
go


/* ------------------- Chi Tiet Phieu Nhap---------------------*/

/* Select Chi Tiet Phieu Nhap - Nguyen Hoang Long */
create proc usp_SelectChiTietPhieuNhapAll
as
	begin
				select ct.MaChiTietPhieuNhap, ct.MaPhieuNhap, ct.MaSanPham, ct.SoLuong, ct.SLDaNhan, ct.SLConLai, ct.GhiChu, ct.Xoa
				from ChiTietPhieuNhap ct
	end
go

/* Select Chi Tiet Phieu Nhap By Id - Nguyen Hoang Long */
create proc usp_SelectChiTietPhieuNhapById @MaChiTietPhieuNhap varchar(15)
as
	begin
				select ct.MaChiTietPhieuNhap, ct.MaPhieuNhap, ct.MaSanPham, ct.SoLuong, ct.SLDaNhan, ct.SLConLai, ct.GhiChu, ct.Xoa
				from ChiTietPhieuNhap ct
				where ct.MaChiTietPhieuNhap = @MaChiTietPhieuNhap
	end
go


/* ------------------- Phieu Xuat ---------------------*/

/* Select Phieu Xuat By Id - Nguyen Hoang Long */
create proc usp_SelectPhieuXuatAll
as
	begin
				select px.MaPhieuXuat, px.NgayBan, px.MaThanhVien, px.MaNhanVien, px.TenKhachHang, px.DiaChi, px.MaLoaiPhieuXuat, px.Xoa
				from PhieuXuat px
	end
go

/* Select Phieu Xuat By Id - Nguyen Hoang Long */
create proc usp_SelectPhieuXuatById @MaPhieuXuat varchar(13)
as
	begin
				select px.MaPhieuXuat, px.NgayBan, px.MaThanhVien, px.MaNhanVien, px.TenKhachHang, px.DiaChi, px.MaLoaiPhieuXuat, px.Xoa
				from PhieuXuat px
				where px.MaPhieuXuat = @MaPhieuXuat
	end
go



/* ------------------- Chi Tiet Phieu Xuat ---------------------*/

/* Select Chi Tiet Phieu Xuat - Nguyen Hoang Long */
create proc usp_SelectChiTietPhieuXuatAll
as
	begin
				select ct.MaChiTietPhieuXuat, ct.MaPhieuXuat, ct.MaSanPham, ct.CV, ct.DonGia, ct.SoLuong, ct.ThanhTien, ct.Xoa
				from ChiTietPhieuXuat ct
	end
go

/* Select Chi Tiet Phieu Xuat By Id - Nguyen Hoang Long */
create proc usp_SelectChiTietPhieuXuatById @MaChiTietPhieuXuat varchar(15)
as
	begin
				select ct.MaChiTietPhieuXuat, ct.MaPhieuXuat, ct.MaSanPham, ct.CV, ct.DonGia, ct.SoLuong, ct.ThanhTien, ct.Xoa
				from ChiTietPhieuXuat ct
				where ct.MaChiTietPhieuXuat = @MaChiTietPhieuXuat
	end
go


/* ------------------- Loai Phieu Xuat ---------------------*/

/* Select Loai Phieu Xuat - Nguyen Hoang Long */
create proc usp_SelectLoaiPhieuXuatAll
as
	begin
				select lpx.MaLoaiPhieuXuat, lpx.TenLoaiPhieuXuat, lpx.Xoa
				from LoaiPhieuXuat lpx
	end
go

/* Select Loai Phieu Xuat By Id - Nguyen Hoang Long */
create proc usp_SelectLoaiPhieuXuatById @MaLoaiPhieuXuat varchar(5)
as
	begin
				select lpx.MaLoaiPhieuXuat, lpx.TenLoaiPhieuXuat, lpx.Xoa
				from LoaiPhieuXuat lpx
				where lpx.MaLoaiPhieuXuat = @MaLoaiPhieuXuat
	end
go



/* ------------------- Thanh Vien ---------------------*/

/* Select Thanh Vien By Id - Nguyen Hoang Long */
create proc usp_SelectThanhVienAll
as
	begin
				select tv.MaThanhVien, tv.TenThanhVien, tv.DiaChi, tv.CV, tv.TienNo, tv.Xoa
				from ThanhVien tv
	end
go

/* Select Thanh Vien By Id - Nguyen Hoang Long */
create proc usp_SelectThanhVienById @MaThanhVien varchar(5)
as
	begin
				select tv.MaThanhVien, tv.TenThanhVien, tv.DiaChi, tv.CV, tv.TienNo, tv.Xoa
				from ThanhVien tv
				where tv.MaThanhVien = @MaThanhVien
	end
go



