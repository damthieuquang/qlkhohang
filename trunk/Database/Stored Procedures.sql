/* Mọi người viết các Stored Procedures - Function vào file này */
/* ------------------- Don Hang---------------------*/
/* Create id Don Hang - Tran Quang Hau*/
create procedure usp_CreateDonHangId 
as
begin
	select 'DH' +	CONVERT(varchar(12),GETDATE(), 112)
end


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

								
/* ------------------- Chi Tiet Don Hang---------------------*/
/* ------------------- San Pham---------------------*/
/* ------------------- Loai San Pham ---------------------*/
/* ------------------- Tham So ---------------------*/
/* ------------------- Nhan Vien---------------------*/
/* ------------------- Phieu Nhap ---------------------*/
/* ------------------- Chi Tiet Phieu Nhap---------------------*/
/* ------------------- Phieu Xuat ---------------------*/
/* ------------------- Chi Tiet Phieu Xuat ---------------------*/
/* ------------------- Loai Phieu Xuat ---------------------*/
/* ------------------- Thanh Vien ---------------------*/