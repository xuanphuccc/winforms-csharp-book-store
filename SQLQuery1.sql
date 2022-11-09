

create table KhachHang(
	MaKH nvarchar(20) primary key,
	TenKH nvarchar(100),
	NgaySinh date,
	GioiTinh nvarchar(10),
	DiaChi nvarchar(200)
)
go

insert KhachHang values (N'KH001', N'Trần Xuân Phúc', '20020401', N'Nam', N'Hà Nội')
insert KhachHang values (N'KH003', N'Trần Văn A', '20031006', N'Nam', N'Thái Nguyên')
insert KhachHang values (N'KH004', N'Nguyễn Thị B', '20040810', N'Nữ', N'Hà Nội')

create table NhanVien(
	MaNV nvarchar(20) primary key,
	TenNV nvarchar(100),
	MaCa nvarchar(20),
	NgaySinh date,
	GioiTinh nvarchar(10),
	DiaChi nvarchar(200),
	SDT nvarchar(20),
	Luong int,
)
go

insert NhanVien values (N'NV001', N'Trần Xuân Phúc', N'CA01', '20020401', N'Nam', N'Hà Nội', N'01231231', 1000)
insert NhanVien values (N'NV002', N'Trần Phương Thảo', N'CA02', '20020401', N'Nam', N'Nam Định', N'01231231', 1500)
insert NhanVien values (N'NV003', N'Nguyễn Trà My', N'CA04', '20020401', N'Nam', N'Thái Nguyên', N'01231231', 800)

create table CaLam (
	MaCa nvarchar(10) primary key,
	TenCa nvarchar(20)
)
go
insert CaLam values (N'CA01', N'Ca sáng')
insert CaLam values (N'CA02', N'Ca chiều')
insert CaLam values (N'CA03', N'Ca tối')

create table LoaiSach (
	MaLS nvarchar(10) primary key,
	TenLS nvarchar(50)
)
go
insert LoaiSach values (N'CU', N'Sách cũ')
insert LoaiSach values (N'MOI', N'Sách mới')


create table NgonNgu (
	MaNN nvarchar(10) primary key,
	TenNN nvarchar(50)
)
go
insert NgonNgu values(N'VNA', N'Tiếng Việt')
insert NgonNgu values(N'ENG', N'Tiếng Anh')
insert NgonNgu values(N'LAO', N'Tiếng Lào')



create table LinhVuc (
	MaLV nvarchar(10) primary key,
	TenLV nvarchar(50)
)
go
insert LinhVuc values(N'TECH', N'Công nghệ')
insert LinhVuc values(N'TEDU', N'Giáo dục')
insert LinhVuc values(N'AGRI', N'Nông nghiệp')


create table TacGia (
	MaTG nvarchar (10) primary key,
	TenTG nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(20),
	DiaChi nvarchar(200)
)
go
insert TacGia values(N'TG001', N'Xuân Phúc', '20020401', N'Nam', N'Hà Nội')
insert TacGia values(N'TG002', N'Eimy Fukada', '20020401', N'Nữ', N'Nhật Bản')
insert TacGia values(N'TG003', N'Tokyda', '20020401', N'Nam', N'Hàn Quốc')


create table NXB (
	MaNXB nvarchar(10) primary key,
	TenNXB nvarchar(100),
	DiaChi nvarchar(200),
	SDT nvarchar(20)
)
go
insert NXB values(N'NXB001', N'Nhà Xuất Bản Kim Đồng', N'Hà Nội', N'012314')
insert NXB values(N'NXB002', N'Nhà Xuất Bản Thanh Niên', N'TP Hồ Chí Minh', N'012314')
insert NXB values(N'NXB003', N'Nhà Xuất Bản DGQGHN', N'Hà Nội', N'012314')