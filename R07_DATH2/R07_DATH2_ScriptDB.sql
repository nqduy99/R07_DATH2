create database DATH2
go
use DATH2

create table NguoiDung(
	MaND varchar(10),
	HoTen nvarchar(10),
	NgSinh date,
	SoNha int,
	Duong nvarchar(30),
	Phuong nvarchar(30),
	Quan nvarchar(30),
	Tpho nvarchar(30),
	DienThoai varchar(15),
	VaiTro varchar(10),--Vai tro co the la admin hoac khach hang
	primary key (MaND)
)

create table DonHang(
	MaDH varchar(10),
	MaND varchar(10),
	NgayLap date,
	TongTien float,
	primary key (MaDH)
)

create table SanPham(
	MaSP varchar(10),
	TenSP nvarchar(60),
	SoLuongTon int,
	Mota nvarchar(100),
	Gia float,
	HanSuDung date,
	MaLSP varchar(10),
	Primary key(MaSP)
)

create table LoaiSanPham(
	MaLSP varchar(10),
	TenLSP varchar(20),
	Primary key(MaLSP)
)

create table CT_DonHang (
	MaDH varchar(10),
	MaSP varchar(10),
	SoLuong int,
	GiaBan float,
	GiaGiam float,
	ThanhTien float null,
	primary key(MaDH, MaSP)
)
-- Tạo khóa ngoại
Alter table DonHang
add constraint fk_DH_ND	
	foreign key(MaND)
	references KhachHang(MaND);
Alter table CT_DonHang
add constraint fk_CTDH_DH	
	foreign key(MaDH)
	references HoaDon(MaDH);
Alter table CT_DonHang
add constraint fk_CTDH_SP
	foreign key(MaSP)
	references SanPham(MaSP);
Alter table SanPham
add constraint fk_SP_LSP
	foreign key(MaLSP)
	references LoaiSanPham(MaLSP);

--Cài Trigger
--Cập nhật giá bán bằng giá sản phẩm
go
Create trigger GiaBan_CTDH on CT_DonHang
for INSERT
as 
begin
	update CT_DonHang
	set GiaBan = s.Gia from SanPham s, CT_DonHang c join inserted i on c.MaSP = i.MaSP and c.MaDH = i.MaDH where s.MaSP = c.MaSP
end
go
--Tính thành tiền của từng chi tiết hóa đơn
Create trigger ThanhTien_CTDH on CT_DonHang
for INSERT
as 
begin
	update CT_DonHang
	set ThanhTien = SoLuong * ( GiaBan - GiaGiam)
end
go

--Tổng tiền của hóa đơn
Create trigger TongTien_DH on CT_DonHang
for INSERT
as 
begin
	update DonHang 
	set TongTien = TongTien + (select c.ThanhTien from CT_DonHang c, inserted i where c.MaDH = h.MaDH and i.MaSP = c.MaSP) from DonHang h join inserted i on h.MaDH = i.MaDH
	select * from inserted
end
go
