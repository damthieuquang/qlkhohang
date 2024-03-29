/* Mọi người viết các Stored Procedures - Function vào file này */
/* ------------------- Don Hang---------------------*/

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
				where dh.MaDonHang = @MaDonHang
	end
go

/* Insert Don Hang - Tran Quang Hau*/
create procedure usp_InsertDonHang 
	@MaDonHang varchar(15),
	@NgayLap datetime,
	@MaNhanVien varchar(5),
	@ThanhTien float,
	@TrangThai nvarchar(15)
as
	begin
		insert into DonHang (MaDonHang, NgayLap, MaNhanVien, ThanhTien, TrangThai)
		values (@MaDonHang, @NgayLap, @MaNhanVien, @ThanhTien, @TrangThai)
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
go

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
go



								
/* ------------------- Chi Tiet Don Hang---------------------*/

/* Select Chi Tiet Don Hang - Nguyen Hoang Long */
create proc usp_SelectChiTietDonHangAll 
as
	begin
				select ct.MaChiTietDonHang, ct.MaDonHang, ct.MaSanPham, ct.CV, ct.SoLuong, ct.DonGia, ct.ThanhTien, ct.SLDaNhan
				from ChiTietDonHang ct			
				where ct.Xoa = 0
	end
go

/* Select Chi Tiet Don Hang By Id - Nguyen Hoang Long */
create proc usp_SelectChiTietDonHangById @MaChiTietDonHang varchar(18)
as
	begin
				select ct.MaChiTietDonHang, ct.MaDonHang, ct.MaSanPham, ct.CV, ct.SoLuong, ct.DonGia, ct.ThanhTien, ct.SLDaNhan
				from ChiTietDonHang ct
				where ct.MaChiTietDonHang = @MaChiTietDonHang
	end
go


/* Insert Chi Tiet Don Hang - Tran Quang Hau*/
create procedure usp_InsertChiTietDonHang 
	@MaChiTietDonHang varchar(18) ,
	@MaDonHang varchar(15)  ,
	@MaSanPham varchar(5)  ,
	@CV int ,
	@SoLuong int ,
	@DonGia float ,
	@ThanhTien float,
	@SLDaNhan int
as
	begin
		insert into ChiTietDonHang (MaChiTietDonHang, MaDonHang, MaSanPham, CV, SoLuong, DonGia, ThanhTien, SLDaNhan)
		values (@MaChiTietDonHang, @MaDonHang, @MaSanPham, @CV, @SoLuong, @DonGia, @ThanhTien, @SLDaNhan)
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
go

/* Update Chi Tiet Don Hang - Dam Thieu Quang*/
create procedure usp_UpdateChiTietDonHangById 
	@MaChiTietDonHang varchar(18),
	@MaDonHang varchar(15),
	@MaSanPham varchar(5),
	@CV int,
	@SoLuong int,
	@DonGia float,
	@ThanhTien float,
	@SLDaNhan int
as
	begin
		update	ChiTietDonHang
		set		MaDonHang = @MaDonHang,  MaSanPham = @MaSanPham, CV = @CV, SoLuong = @SoLuong, DonGia = @DonGia, ThanhTien = @ThanhTien, SLDaNhan  = @SLDaNhan
		where	MaChiTietDonHang = @MaChiTietDonHang
	end
go

/*Select Chi Tiet Don Hang By Ma Don Hang-Nguyễn Hoàng Minh*/
create proc usp_SelectChiTietDonHangByMaDonHang @MaDonHang	 varchar(15)
as
	begin
				select ct.MaChiTietDonHang, ct.MaDonHang, ct.MaSanPham, ct.CV, ct.SoLuong, ct.DonGia, ct.ThanhTien, ct.SLDaNhan
				from ChiTietDonHang ct
				where ct.MaDonHang = @MaDonHang		and  ct.Xoa = 0
	end
go




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
				where sp.MaSanPham = @MaSanPham 
	end
go

/* Insert San Pham - Tran Quang Hau*/
create procedure usp_InsertSanPham
	@MaSanPham varchar(5),
	@TenSanPham nvarchar(100),
	@CV int,
	@DonGia float,
	@DonGiaTV float,
	@SoLuongTon int,
	@MaLoaiSanPham varchar(5)
as
	begin
		insert into SanPham (MaSanPham, TenSanPham, CV, DonGia, DonGiaTV, SoLuongTon, MaLoaiSanPham)
		values (@MaSanPham, @TenSanPham, @CV, @DonGia, @DonGiaTV, @SoLuongTon, @MaLoaiSanPham)
	end
go


/* Xoa San Pham - Dam Thieu Quang*/
create procedure usp_DeleteSanPhamById @MaSanPham varchar(5)
as
	begin
		update	SanPham
		set		Xoa = 1
		where	MaSanPham = @MaSanPham
	end
go

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
go

/* Create ID San Pham - Tran Quang Hau*/
create procedure usp_CreateSanPhamId
as
	begin
		declare @max varchar(5)
		select @max = max(MaSanPham) from SanPham
		if(@max is NULL)
			select '00001'
		else
			begin
			set @max =  cast(@max as int)+1
			select cast(@max as varchar(5));
			end
	end
go

/*UpdateSanPhamByMaSanPham-Nguyen Hoang Minh*/ 
create procedure usp_UpdateSanPhamByMaSanPham
	@MaSanPham varchar(5),
	@SoLuongTon int
as
	begin
		update	SanPham
		set	    SoLuongTon = @SoLuongTon
		where	MaSanPham = @MaSanPham
	end
go



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
				where lsp.MaLoaiSanPham  = @MaLoaiSanPham
	end
go

/* Insert Loai San Pham - Tran Quang Hau*/
create procedure usp_InsertLoaiSanPham
	@MaLoaiSanPham varchar(5),
	@TenLoaiSanPham nvarchar(100)
as
	begin
		insert into LoaiSanPham (MaLoaiSanPham , TenLoaiSanPham)
		values (@MaLoaiSanPham , @TenLoaiSanPham)
	end
go 


/* Xoa Loai San Pham - Dam Thieu Quang*/
create procedure usp_DeleteLoaiSanPhamById @MaLoaiSanPham varchar(5)
as
	begin
		update	SanPham
		set		MaLoaiSanPham = NULL
		where	MaLoaiSanPham = @MaLoaiSanPham

		update	LoaiSanPham
		set		Xoa = 1
		where	MaLoaiSanPham = @MaLoaiSanPham
	end
go

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
go 

/* Create ID San Pham - Tran Quang Hau*/
create procedure usp_CreateLoaiSanPhamId
as
	begin
		declare @max varchar(5)
		select @max = max(MaLoaiSanPham) from LoaiSanPham
		if(@max is NULL)
			select 'LSP01'
		else
			begin
				declare @so int
				declare @id varchar(5)
				set @so = cast(substring(@max,4,2)as int)+1
				set @id = 'LSP'
				if(@so <10)
					set @id =  @id + '0'
				set @id = @id + cast(@so as varchar(2))
				select @id
			end	
	end
go


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
				where ts.MaThamSo = @MaThamSo
	end
go

/* Insert Tham So - Tran Quang Hau*/
create procedure usp_InsertThamSo
	@MaThamSo varchar(5),
	@TenThamSo varchar(20),
	@GiaTri nvarchar (100)
as
	begin
		insert into ThamSo (MaThamSo , TenThamSo, GiaTri)
		values (@MaThamSo , @TenThamSo, @GiaTri)
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
go

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
go

create procedure usp_CreateThamSoId
as
	begin
		declare @max varchar(5)
		select @max = max(MaThamSo) from ThamSo
		if(@max is NULL)
			select 'TS001'
		else
			begin
				declare @so int
				declare @id varchar(5)
				set @so = cast(substring(@max,3,3)as int)+1
				set @id = 'TS'

				if(@so <10)
					set @id =  @id + '00'
				else if(@so <100)
					set @id =  @id + '0'

				set @id = @id + cast(@so as varchar(3))
				select @id
			end	
	end
go



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
				where nv.MaNhanVien = @MaNhanVien
	end
go

/* Insert Nhan Vien - Tran Quang Hau*/
create procedure usp_InsertNhanVien
	@MaNhanVien varchar(5),
	@TenNhanVien nvarchar(100),
	@MatKhau varchar(20),
	@LoaiNhanVien int
as
	begin
		insert into NhanVien (MaNhanVien , TenNhanVien, MatKhau, LoaiNhanVien)
		values (@MaNhanVien , @TenNhanVien, @MatKhau, @LoaiNhanVien)
	end
go

/* Xoa Nhan Vien - Dam Thieu Quang*/
create procedure usp_DeleteNhanVienById @MaNhanVien varchar(5)
as
	begin
		update	NhanVien
		set		Xoa = 1
		where	MaNhanVien = @MaNhanVien
	end
go

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
go

/* Create ID Nhan Vien - Tran Quang Hau*/
create procedure usp_CreateNhanVienId
as
	begin
		declare @max varchar(5)
		select @max = max(MaNhanVien) from NhanVien
		if(@max is NULL)
			select 'NV001'
		else
			begin
				declare @so int
				declare @id varchar(5)
				set @so = cast(substring(@max,3,3)as int)+1
				set @id = 'NV'

				if(@so <10)
					set @id =  @id + '00'
				else if(@so <100)
					set @id =  @id + '0'

				set @id = @id + cast(@so as varchar(3))
				select @id
			end	
	end
go





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
				where pn.MaPhieuNhap = @MaPhieuNhap
	end
go

/* Select Phieu Nhap By MaNhanVien - Nguyen Hoang Long */
create proc usp_SelectPhieuNhapByMaNhanVien @MaNhanVien varchar(5)
as
	begin	
				select pn.MaPhieuNhap, pn.MaDonHang, pn.NgayNhan, pn.MaNhanVien
				from PhieuNhap pn
				where pn.MaNhanVien = @MaNhanVien
	end
go
--exec usp_SelectPhieuNhapByMaNhanVien 'NV001'

/* Insert Phieu Nhap - Tran Quang Hau*/
create procedure usp_InsertPhieuNhap
	@MaPhieuNhap varchar(15),
	@MaDonHang varchar(15),
	@NgayNhan datetime,
	@MaNhanVien varchar(5)
as
	begin
		insert into PhieuNhap (MaPhieuNhap , MaDonHang, NgayNhan, MaNhanVien)
		values (@MaPhieuNhap , @MaDonHang, @NgayNhan, @MaNhanVien)
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
go

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
go

/*Select Phieu Nhap By Ma Don Hang-Nguyễn Hoàng Minh*/
create proc usp_SelectPhieuNhapByMaDonHang @MaDonHang varchar(15)
as
	begin	
				select pn.MaPhieuNhap, pn.MaDonHang, pn.NgayNhan, pn.MaNhanVien
				from PhieuNhap pn
				where pn.MaDonHang = @MaDonHang and  pn.Xoa = 0
	end
go



/* ------------------- Chi Tiet Phieu Nhap---------------------*/

/* Select Chi Tiet Phieu Nhap - Nguyen Hoang Long */
create proc usp_SelectChiTietPhieuNhapAll
as
	begin
				select ct.MaChiTietPhieuNhap, ct.MaPhieuNhap, ct.MaSanPham, ct.SLNhan, ct.GhiChu
				from ChiTietPhieuNhap ct
				where  ct.Xoa = 0
	end
go

/* Select Chi Tiet Phieu Nhap By Id - Nguyen Hoang Long */
create proc usp_SelectChiTietPhieuNhapById @MaChiTietPhieuNhap varchar(18)
as
	begin
				select ct.MaChiTietPhieuNhap, ct.MaPhieuNhap, ct.MaSanPham,  ct.SLNhan,  ct.GhiChu
				from ChiTietPhieuNhap ct
				where ct.MaChiTietPhieuNhap = @MaChiTietPhieuNhap 
	end
go

/* Insert Chi Tiet Phieu Nhap - Tran Quang Hau*/
create procedure usp_InsertChiTietPhieuNhap
	@MaChiTietPhieuNhap varchar(18), 
	@MaPhieuNhap varchar(15),
	@MaSanPham varchar(5),
	@SLNhan int,
	@GhiChu nvarchar(255)
as
	begin
		insert into ChiTietPhieuNhap (MaChiTietPhieuNhap, MaPhieuNhap , MaSanPham, SLNhan,  GhiChu)
		values (@MaChiTietPhieuNhap, @MaPhieuNhap , @MaSanPham, @SLNhan,  @GhiChu)
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
go

/* Update Chi Tiet Phieu Nhap - Dam Thieu Quang*/
create procedure usp_UpdateChiTietPhieuNhapById
	@MaChiTietPhieuNhap varchar(18), 
	@MaPhieuNhap varchar(15),
	@MaSanPham varchar(5),
	@SLNhan int,
	@GhiChu nvarchar(255)
as
	begin
		update	ChiTietPhieuNhap
		set		MaPhieuNhap = @MaPhieuNhap, MaSanPham = @MaSanPham,  SLNhan = @SLNhan,  GhiChu = @GhiChu
		where	MaChiTietPhieuNhap = @MaChiTietPhieuNhap
	end
go
/*Select Chi Tiet Phieu Nhap By Ma Phieu Nhap-Nguyễn Hoàng Minh*/
create proc usp_SelectChiTietPhieuNhapByMaPhieuNhap @MaPhieuNhap varchar(15)
as
	begin
				select ct.MaChiTietPhieuNhap, ct.MaPhieuNhap, ct.MaSanPham,  ct.SLNhan,  ct.GhiChu
				from ChiTietPhieuNhap ct
				where ct.MaPhieuNhap = @MaPhieuNhap and  ct.Xoa = 0
	end
go



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
				where px.MaPhieuXuat = @MaPhieuXuat
	end
go

/* Select Phieu Xuat By Ma thanh vien - Nguyen Hoang Long */
create proc usp_SelectPhieuXuatByMaThanhVien @MaThanhVien varchar(5)
as
	begin
				select px.MaPhieuXuat, px.NgayBan, px.MaThanhVien, px.MaNhanVien, px.TenKhachHang, px.DiaChi, px.MaLoaiPhieuXuat
				from PhieuXuat px
				where px.MaThanhVien = @MaThanhVien
	end
go
--exec usp_SelectPhieuXuatByMaThanhVien 'TV002'

/* Select Phieu Xuat By Ma nhan vien - Nguyen Hoang Long */
create proc usp_SelectPhieuXuatByMaNhanVien @MaNhanVien varchar(5)
as
	begin
				select px.MaPhieuXuat, px.NgayBan, px.MaThanhVien, px.MaNhanVien, px.TenKhachHang, px.DiaChi, px.MaLoaiPhieuXuat
				from PhieuXuat px
				where px.MaNhanVien = @MaNhanVien
	end
go
--exec usp_SelectPhieuXuatByMaNhanVien 'NV001'

/* Insert Phieu Xuat - Tran Quang Hau*/
create procedure usp_InsertPhieuXuat
	@MaPhieuXuat varchar(15), 
	@NgayBan datetime,
	@MaThanhVien varchar(5) = null,
	@MaNhanVien varchar(5),
	@TenKhachHang nvarchar(100),
	@DiaChi nvarchar(255),
	@MaLoaiPhieuXuat varchar(5)
as
	begin
		insert into PhieuXuat(MaPhieuXuat, NgayBan , MaThanhVien, MaNhanVien, TenKhachHang, DiaChi, MaLoaiPhieuXuat)
		values (@MaPhieuXuat, @NgayBan , @MaThanhVien, @MaNhanVien, @TenKhachHang, @DiaChi, @MaLoaiPhieuXuat)
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
go

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
go




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
				where ct.MaChiTietPhieuXuat = @MaChiTietPhieuXuat
	end
go

/* Insert Chi Tiet Phieu Xuat - Tran Quang Hau*/
create procedure usp_InsertChiTietPhieuXuat
	@MaChiTietPhieuXuat varchar(18),
	@MaPhieuXuat varchar(15), 
	@MaSanPham varchar(5),
	@CV int,
	@DonGia float,
	@SoLuong int,
	@ThanhTien float
as
	begin
		insert into ChiTietPhieuXuat(MaChiTietPhieuXuat, MaPhieuXuat, MaSanPham , CV, DonGia, SoLuong, ThanhTien)
		values (@MaChiTietPhieuXuat, @MaPhieuXuat, @MaSanPham , @CV, @DonGia, @SoLuong, @ThanhTien)
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
go

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
go

/*Select Chi Tiet Phieu Xuat by MaPhieuXuat - Nguyen Thi Yen*/
create proc usp_SelectChiTietPhieuXuatByMaPhieuXuat @MaPhieuXuat varchar(15)
as
	begin
		select ctpx.MaChiTietPhieuXuat,ctpx.MaPhieuXuat,ctpx.MaSanPham,ctpx.CV,ctpx.DonGia,ctpx.SoLuong,ctpx.ThanhTien
		from ChiTietPhieuXuat ctpx
		where ctpx.MaPhieuXuat = @MaPhieuXuat	and ctpx.Xoa = 0
	end
go




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
				where lpx.MaLoaiPhieuXuat = @MaLoaiPhieuXuat
	end
go

/* Insert Loai Phieu Xuat - Tran Quang Hau*/
create procedure usp_InsertLoaiPhieuXuat
	@MaLoaiPhieuXuat varchar(5),
	@TenLoaiPhieuXuat nvarchar(20)
as
	begin
		insert into LoaiPhieuXuat(MaLoaiPhieuXuat, TenLoaiPhieuXuat)
		values (@MaLoaiPhieuXuat, @TenLoaiPhieuXuat)
	end
go

/* Xoa Loai Phieu Xuat - Dam Thieu Quang*/
create procedure usp_DeleteLoaiPhieuXuatById @MaLoaiPhieuXuat varchar(5)
as
	begin
		update	PhieuXuat
		set		MaLoaiPhieuXuat = NULL
		where	MaLoaiPhieuXuat = @MaLoaiPhieuXuat

		update	LoaiPhieuXuat
		set		Xoa = 1
		where	MaLoaiPhieuXuat = @MaLoaiPhieuXuat
	end
go 

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
go

/* Create ID Loai Phieu Xuat  - Tran Quang Hau*/
create procedure usp_CreateLoaiPhieuXuatId
as
	begin
		declare @max varchar(5)
		select @max = max(MaLoaiPhieuXuat) from LoaiPhieuXuat
		if(@max is NULL)
			select 'LPX01'
		else
			begin
				declare @so int
				declare @id varchar(5)
				set @so = cast(substring(@max,4,2)as int)+1
				set @id = 'LPX'

				if(@so <10)
					set @id =  @id + '0'
				
				set @id = @id + cast(@so as varchar(3))
				select @id
			end	
	end
go




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
				where tv.MaThanhVien = @MaThanhVien 
	end
go

/* Insert Thanh Vien - Tran Quang Hau*/
create procedure usp_InsertThanhVien
	@MaThanhVien varchar(5),
	@TenThanhVien nvarchar(50),
	@DiaChi nvarchar(255),
	@CV int,
	@TienNo float
as
	begin
		insert into ThanhVien(MaThanhVien, TenThanhVien, DiaChi, CV, TienNo)
		values (@MaThanhVien, @TenThanhVien, @DiaChi, @CV, @TienNo)
	end
go

/* Xoa Thanh Vien - Dam Thieu Quang*/
create procedure usp_DeleteThanhVienById @MaThanhVien varchar(5)
as
	begin
		update	ThanhVien
		set		Xoa = 1
		where	MaThanhVien = @MaThanhVien
	end
go

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
go


/* Create ID Thanh Vien  - Tran Quang Hau*/
create procedure usp_CreateThanhVienId
as
	begin
		declare @max varchar(5)
		select @max = max(MaThanhVien) from ThanhVien
		if(@max is NULL)
			select 'TV001'
		else
			begin
				declare @so int
				declare @id varchar(5)
				set @so = cast(substring(@max,3,3)as int)+1
				set @id = 'TV'

				if(@so <10)
					set @id =  @id + '00'
				else if(@so <100)
					set @id =  @id + '0'
				
				set @id = @id + cast(@so as varchar(3))
				select @id
			end	
	end
go





