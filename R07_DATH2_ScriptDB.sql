--drop database DATH2
create database DATH2
go
use DATH2
--drop table KhachHang
create table KhachHang(
	MaKH varchar(10),
	HoTen nvarchar(50),
	NgSinh date,
	SoNha int,
	Duong nvarchar(30),
	Phuong nvarchar(30),
	Quan nvarchar(30),
	Tpho nvarchar(30),
	DienThoai varchar(15),
	primary key (MaKH)
)

--drop table NhanVien
create table NhanVien(
	MaNV varchar(10),
	HoTen_NV nvarchar(50),
	ChucVu nvarchar(50),
	NgSinh_NV date,
	SoNha_NV int,
	Duong_NV nvarchar(30),
	Phuong_NV nvarchar(30),
	Quan_NV nvarchar(30),
	Tpho_NV nvarchar(30),
	DienThoai_NV varchar(15),
	primary key (MaNV)
)


create table Account(
	MaND varchar(10),
	Username varchar(20),
	Password varchar(50),
	Vaitro varchar(20)
	primary key (MaND)
)

create table DonHang(
	MaDH varchar(10),
	MaKH varchar(10),
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

create table PhieuNhapHang (
	MaPNH varchar(10),
	NgayNhap date,
	MaNV varchar(10),
	TongTienNhap float,
	primary key(MaPNH)
)

create table CT_PhieuNhap (
	MaPNH varchar(10),
	MaSP varchar(10),
	SoLuongNhap int,
	GiaNhap float,
	ThanhTienNhap float null,
	primary key(MaPNH, MaSP)
)

-- Tạo khóa ngoại
Alter table Account
add constraint fk_AC_KH	
	foreign key(MaND)
	references KhachHang(MaKH);
Alter table Account
add constraint fk_AC_NV	
	foreign key(MaND)
	references NhanVien(MaNV);
Alter table DonHang
add constraint fk_DH_KH	
	foreign key(MaKH)
	references KhachHang(MaKH);
Alter table CT_DonHang
add constraint fk_CTDH_DH	
	foreign key(MaDH)
	references DonHang(MaDH);
Alter table CT_DonHang
add constraint fk_CTDH_SP
	foreign key(MaSP)
	references SanPham(MaSP);
Alter table SanPham
add constraint fk_SP_LSP
	foreign key(MaLSP)
	references LoaiSanPham(MaLSP);
Alter table PhieuNhapHang
add constraint fk_PNH_NV	
	foreign key(MaNV)
	references NhanVien(MaNV);
Alter table CT_PhieuNhap
add constraint fk_CTPN_PNH	
	foreign key(MaPNH)
	references PhieuNhapHang(MaPNH);
Alter table CT_PhieuNhap
add constraint fk_CTPN_SP	
	foreign key(MaSP)
	references SanPham(MaSP);

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
--Tính thành tiền của từng chi tiết Đơn Hàng
Create trigger ThanhTien_CTDH on CT_DonHang
for INSERT
as 
begin
	update CT_DonHang
	set ThanhTien = SoLuong * ( GiaBan - GiaGiam)
end
go

--Tổng tiền của Đơn Hàng
Create trigger TongTien_DH on CT_DonHang
for INSERT
as 
begin
	update DonHang 
	set TongTien = TongTien + (select c.ThanhTien from CT_DonHang c, inserted i where c.MaDH = h.MaDH and i.MaSP = c.MaSP) from DonHang h join inserted i on h.MaDH = i.MaDH
	select * from inserted
end
go
--Tính thành tiền của từng chi tiết nhập hàng
Create trigger ThanhTien_CTPN on CT_PhieuNhap
for INSERT
as 
begin
	update CT_PhieuNhap
	set ThanhTienNhap = SoLuongNhap * GiaNhap
end
go
--Tổng tiền của Phiếu Nhập Hàng
Create trigger TongTien_PNH on CT_PhieuNhap
for INSERT
as 
begin
	update PhieuNhapHang 
	set TongTienNhap = TongTienNhap + (select c.ThanhTienNhap from CT_PhieuNhap c, inserted i where c.MaPNH = h.MaPNH and i.MaSP = c.MaSP) from PhieuNhapHang h join inserted i on h.MaPNH = i.MaPNH
	select * from inserted
end
go

--Them du lieu mau
INSERT INTO KhachHang(MaKH,HoTen,NgSinh,SoNha,Duong,Phuong,Quan,Tpho,DienThoai) VALUES ('1','Peter Nguyen','1999-08-09',159,'Xo Viet','Thanh Cong','Buon Ma Thuot','DakLak','0912345678')