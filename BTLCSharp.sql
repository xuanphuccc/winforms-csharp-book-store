
create table LoaiSach (
	MaLS nvarchar(10) not null primary key,
	TenLS nvarchar(50)
)
go

create table LinhVuc (
	MaLV nvarchar(10) not null primary key,
	TenLV nvarchar(50)
)
go

create table TacGia(
	MaTG nvarchar(10) not null primary key,
	TenTG nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(10),
	DiaChi nvarchar(50)
)
go

create table NXB(
	MaNXB nvarchar(10) not null primary key,
	TenNXB nvarchar(200),
	DiaChi nvarchar(50),
	SDT nvarchar(15)
)
go

create table NgonNgu(
	MaNN nvarchar(10) not null primary key,
	TenNN nvarchar(50)
)
go

create table Sach (
	MaSach nvarchar(10) not null primary key,
	TenSach nvarchar(200) ,
	MaLS nvarchar(10),
	MaLV nvarchar(10),
	MaTG nvarchar(10),
	MaNXB nvarchar(10),
	MaNN nvarchar(10),
	SoTrang int,
	GiaSach int,
	DGThue int,
	SoLuong int,
	Anh nvarchar(200),
	GhiChu ntext,
	constraint fk_sach_mals foreign key (MaLS) references LoaiSach(MaLS),
	constraint fk_sach_malv foreign key (MaLV) references LinhVuc(MaLV),
	constraint fk_sach_matg foreign key (MaTG) references TacGia(MaTG),
	constraint fk_sach_manxb foreign key (MaNXB) references NXB(MaNXB),
	constraint fk_sach_mann foreign key (MaNN) references NgonNgu(MaNN)
)
go

create table CaLam(
	MaCa nvarchar(10) not null primary key,
	TenCa nvarchar(50)
)
go

create table NhanVien(
	MaNV nvarchar(10) not null primary key,
	TenNV nvarchar(50),
	MaCa nvarchar(10),
	NgaySinh date,
	GioiTinh nvarchar(10),
	DiaChi nvarchar(50),
	SDT nvarchar(15),
	Luong int,
	constraint fk_nv_macl foreign key (MaCa) references CaLam(MaCa)
)
go

create table KhachHang(
	MaKH nvarchar(10) not null primary key,
	TenKH nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(10),
	DiaChi nvarchar(50)
)
go

create table ThueSach(
	MaThue nvarchar(10) not null primary key,
	MaKH nvarchar(10),
	MaNV nvarchar(10),
	NgayThue date,
	TienCoc int,
	constraint fk_thue_manv foreign key (MaNV) references NhanVien(MaNV),
	constraint fk_thue_makh foreign key (MaKH) references KhachHang(MaKH)
)
go

create table TinhTrang(
	MaTT nvarchar(10) not null primary key,
	TenTT nvarchar(50)
)
go

create table ChiTietThueSach(
	MaThue nvarchar(10) not null ,
	MaSach nvarchar(10) ,
	MaTT nvarchar(10) ,
	DaTra bit,
	constraint pk_chitietthue primary key (MaThue, MaSach, MaTT),
	constraint fk_chitietthue_mathue foreign key (MaThue) references ThueSach(MaThue),
	constraint fk_chitietthue_mas foreign key (MaSach) references Sach(MaSach),
	constraint fk_chitiethue_matt foreign key (MaTT) references TinhTrang(MaTT)
)
go

create table TraSach(
	MaTra nvarchar(10) not null primary key,
	MaThue nvarchar(10),
	MaNV nvarchar(10),
	NgayTra date,
	TongTien int,
	constraint fk_tra_mathue foreign key (MaThue) references ThueSach(MaThue),
	constraint fk_tra_manv foreign key (MaNV) references NhanVien(MaNV)
)
go

create table ViPham(
	MaVP nvarchar(10) not null primary key,
	TenVP nvarchar(50),
	TienPhat int
)
go

create table ChiTietTraSach(
	MaTra nvarchar(10) not null,
	MaSach nvarchar(10),
	MaVP nvarchar(10),
	ThanhTien int
	constraint pk_chitiettra primary key (MaTra, MaSach, MaVP),
	constraint fk_chitiettra_matra foreign key (MaTra) references TraSach(MaTra),
	constraint fk_chitiettra_mas foreign key (MaSach) references Sach(MaSach),
	constraint fk_chitiettra_mavp foreign key (MaVP) references ViPham(MaVP)
)
go


-- insert data

insert LoaiSach
values 
('L01', N'Mới'),
('L02', N'Cũ')
go

insert LinhVuc 
values
('LV01', N'Kinh Doanh'),
('LV02', N'Cuộc sống'),
('LV03', N'Thể thao, Du Lịch'),
('LV04', N'Văn hoá, Nghệ thuật')
go

insert TacGia
values
('TG01', N'Trần Đăng Khoa', N'1958-04-26', N'Nam', N'Hải Dương'),
('TG02', N'Triệu Phàm Vũ', N'1962-07-30', N'Nữ', N'Nghệ An'),
('TG03', N'Nguyễn Văn Đạt', N'1949-11-12', N'Nam', N'Thái Bình'),
('TG04', N'Nguyễn Thị Đoan', N'1953-02-23', N'Nữ', N'Nam Định'),
('TG05', N'Đặng Hoàng Giang', N'1960-07-15', N'Nam', N'Hà Nội')
go

insert NXB
values
('NXB01', N'NXB Kim Đồng', N'Hà Nội', '0989352899'),
('NXB02', N'NXB Trẻ', N'Hải Dương', '0968866868'),
('NXB03', N'NXB Phương Nam', N'Nam Định', '0326445651'),
('NXB04', N'NXB Thăng Long', N'Hà Nội', '0868521662')
go

insert NgonNgu
values
('ENG', N'English'),
('VNA', N'Tiếng Việt')
go

insert Sach
values
('S01', N'Sống và khát vọng', 'L01','LV02', 'TG01', 'NXB03', 'VNA', 365, 180000, 30000, 120, null, null),
('S02', N'Đón đầu xu hướng', 'L02', 'LV01', 'TG03', 'NXB01', 'VNA', 220, 250000, 30000, 60, null, null),
('S03', N'Cát bụi thời gian', 'L02', 'LV04', 'TG02', 'NXB04', 'VNA', 482, 150000, 20000, 45, null, null),
('S04', N'Thế giới phẳng', 'L01', 'LV03', 'TG05', 'NXB02', 'ENG', 818, 200000, 30000, 56, null, null),
('S05', N'Búc xúc làm ta vô cảm', 'L01', 'LV02', 'TG04', 'NXB03', 'ENG', 400, 120000, 15000, 30, null, null)
go

insert CaLam
values 
('C01', N'Ca sáng'),
('C02', N'Ca chiều'),
('C03', N'Ca tối')
go

insert NhanVien
values
('NV01', N'Trần Huy Nam', 'C01', '2000-08-09', N'Nam', 'Hà Nội', '0976589345', 3500000),
('NV02', N'Nguyễn Thị Huế', 'C02', '2001-11-15', N'Nữ', 'Hải Dương', '0347898814', 2950000),
('NV03', N'Nguyễn Đình Đạt', 'C03', '2000-04-23', N'Nam', 'Hà Nội', '0868455779', 4000000),
('NV04', N'Phạm Đình Thái', 'C02', '1999-02-19', N'Nam', 'Hải Dương', '0989354221', 3200000),
('NV05', N'Vũ Thảo Hiền', 'C01', '2000-10-28', N'Nữ', 'Hà Nội', '0189445729', 3450000)
go

insert KhachHang
values
('KH01', N'Mạnh Thường Quân', '2002-10-30', N'Nam', N'Hà Nội'),
('KH02', N'Nguyễn Thị Phương', '1999-05-11', N'Nữ', N'Hà Nội'),
('KH03', N'Hoàng Thị Hồng', '2000-06-19', N'Nữ', N'Hải Phòng'),
('KH04', N'Mai Văn Hùng', '1998-12-03', N'Nam', N'Thái Nguyên'),
('KH05', N'Đỗ Văn Bắc', '2001-01-21', N'Nam', N'Yên Bái')
go


insert ThueSach
values
('TH01', 'KH01', 'NV02', '2022-06-12', 100000),
('TH02', 'KH02', 'NV05', '2022-06-15', 100000),
('TH03', 'KH03', 'NV01', '2022-08-24', 100000),
('TH04', 'KH04', 'NV04', '2022-11-05', 100000),
('TH05', 'KH05', 'NV03', '2022-10-31', 100000)
go


insert TinhTrang
values
('TT01', N'Còn nguyên vẹn'),
('TT02', N'Đã bị cũ, rách')
go

insert ChiTietThueSach
values
('TH01', 'S01', 'TT01', 0),
('TH01', 'S02', 'TT01', 0),
('TH02', 'S02', 'TT01', 0),
('TH03', 'S05', 'TT01', 0),
('TH04', 'S04', 'TT01', 0),
('TH05', 'S03', 'TT01', 0)
go

insert TraSach
values 
('TR01', 'TH01', 'NV02', '2022-07-20', 60000),
('TR02', 'TH02', 'NV05', '2022-07-15', 30000),
('TR03', 'TH03', 'NV01', '2022-12-24', 15000),
('TR04', 'TH04', 'NV04', '2022-11-19', 30000),
('TR05', 'TH05', 'NV03', '2022-11-15', 20000)
go

insert ViPham
values
('VP00', N'Sách không có vấn đề gì', 0),
('VP01', N'Sách bị rách', 100000),
('VP02', N'Trả muộn', 15000)
go

-- Nếu thành tiền là null thì lỗi
insert ChiTietTraSach
values
('TR01', 'S01', 'VP00', 41000),
('TR01', 'S02', 'VP01', 21000),
('TR02', 'S02', 'VP00', 31000),
('TR03', 'S05', 'VP01', 16000),
('TR04', 'S04', 'VP01', 31000),
('TR05', 'S03', 'VP02', 21000)
go


