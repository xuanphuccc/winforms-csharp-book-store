

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

delete KhachHang where MaKH = N'KH002'

select * from KhachHang