--## 1. Trong bảng Chi tiết thuê sách chỉ hiển thị các sách có số lượng > 0.
select *
from Sach
where SoLuong > 0

go

--## 2. Khi khách hàng thuê sách hoặc trả sách thì cập nhật lại Số lượng sách 						
--trong bảng Sách truyện.
-- Thêm, sửa phiếu thuê (Đã test thêm phiếu thuê)
create trigger ThueSachThuVien on chitietthuesach for insert, update as
begin
declare @masach nvarchar(10)
select @masach= MaSach from inserted
update Sach
set SoLuong=SoLuong - 1
where MaSach=@masach
end

go
-- Xóa phiếu thuê (Đã test)
create trigger HuyThueSach on chitietthuesach for delete as
begin
declare @masach nvarchar(10)
select @masach= MaSach from deleted
update Sach
set SoLuong=SoLuong + 1
where MaSach=@masach
end

go
-- Thêm, sửa phiếu trả
create trigger TraSachThuVien on ChiTietTraSach for insert, update as
begin
declare @masach nvarchar(10)
select @masach= MaSach from inserted
update Sach
set SoLuong=SoLuong + 1
where MaSach=@masach
end

go
-- Xóa phiếu trả
create trigger HuyTraSach on ChiTietTraSach for delete as
begin
declare @masach nvarchar(10)
select @masach= MaSach from deleted
update Sach
set SoLuong=SoLuong - 1
where MaSach=@masach
end

go

--## 3. Khi khách hàng trả sách chỉ hiển thị các sách chưa trả từ mã thuê sách tương ứng.
create function UnpaidBook(@mathue nvarchar(10))
returns table
as
	return (
		select Sach.*
		from ChiTietThueSach, Sach
		where MaThue = @mathue and DaTra=0 and Sach.MaSach= ChiTietThueSach.MaSach
	)
go

select * from UnpaidBook(N'TH01')

go
--## 4. Tính Thành tiền trong bảng Chi tiết trả sách
-- bằng Đơn giá thuê * Số ngày thuê + Tiền phạt (nếu có)
create alter trigger TraSachThuVien2 on ChiTietTraSach for insert, update as
begin
	declare @masach nvarchar(10),@mathue nvarchar(10),@matra nvarchar(10),@thanhtien int,@tongtien int
	select @masach= MaSach from inserted
	select @matra= MaTra from inserted
	select @mathue= MaThue from inserted,TraSach where @matra=TraSach.MaTra

	update ChiTietThueSach
	set DaTra=1
	where MaSach=@masach and MaThue=@mathue
	select @thanhtien=(DGThue*DATEDIFF(DAY, NgayThue, NgayTra)+TienPhat) from ChiTietTraSach, ViPham,Sach,TraSach,ThueSach
						where ChiTietTraSach.MaVP=ViPham.MaVP and Sach.MaSach=ChiTietTraSach.MaSach and TraSach.MaTra=ChiTietTraSach.MaTra
						and ThueSach.MaThue=TraSach.MaThue
						and Sach.MaSach=@masach and TraSach.MaTra=@matra
	update ChiTietTraSach
	set ThanhTien=@thanhtien
	where MaTra=@matra and MaSach=@masach
	
	
	select @tongtien=sum(ThanhTien) from TraSach, ChiTietTraSach
						where TraSach.MaTra= ChiTietTraSach.MaTra
						and @matra=TraSach.MaTra
						group by TraSach.MaTra 
	update TraSach 
	set TongTien=@tongtien
	where MaTra=@matra
end

-- test
select * from ChiTietTraSach

insert TraSach values ('TR05', 'TH07', 'NV01', '2022-11-20', 0)

insert ChiTietTraSach
values
('TR05', 'S05', 'VP00', null)


--## 5. Tìm kiếm Sách truyện theo tiêu chí: Tên sách, lĩnh vực, tác giả, NXB.
-- (Đã xong)
--## 6. Tìm kiếm Nhân viên theo tiêu chí: Tên nhân viên, ca làm, giới tính.
-- (Đã xong)

--## 7. Báo cáo danh sách các sách truyện đang được thuê chưa trả.	
select TenSach, COUNT(TenSach) as N'Số lượng', N'Chưa Trả' as DaTra from ChiTietThueSach, Sach
where Sach.MaSach = ChiTietThueSach.MaSach and DaTra=0
group by TenSach

--## 8. Báo cáo tổng tiền cho thuê thu được của cửa hàng theo tháng, quý, năm.
-- (Đang chỉnh sửa)

--## 9. Báo cáo danh sách 5 sách truyện đạt doanh thu nhiều nhất
select top(5) TenSach,sum(thanhtien) as TongDoanhThu from ChiTietTraSach,Sach
where sach.MaSach=ChiTietTraSach.MaSach
group by TenSach
order by sum(thanhtien) desc

-- ============ PHẦN BỔ SUNG ============
-- Load danh sách phiếu thuê bổ sung thêm trường TenKH
create function LoadBookRental()
returns table
as
	return (
		select TS.MaThue, TS.MaKH, KH.TenKH, TS.MaNV, TS.NgayThue, TS.TienCoc
		from ThueSach as TS, KhachHang as KH
		where TS.MaKH = KH.MaKH
	)

select * from LoadBookRental()

-- Lấy ra thông tin các sách ĐÃ THUÊ từ mã thuê sách tương ứng
-- (ChiTietThueSach bổ sung thêm trường TenSach)
create function BookRentalDetail(@MaThue nvarchar(10))
returns table
as
	return (
		select CT.MaThue, S.MaSach, S.TenSach, CT.MaTT, CT.DaTra
		from ChiTietThueSach as CT, Sach as S
		where CT.MaSach = S.MaSach
		and @MaThue = CT.MaThue
	)
select * from BookRentalDetail(N'TH05')


-- Lấy ra thông tin các sách ĐÃ TRẢ	 từ mã trả sách tương ứng
-- (ChiTietTraSach bổ sung thêm trường TenSach)
create function BookReturnDetail(@MaTra nvarchar(10))
returns table
as
	return (
		select CT.MaTra, CT.MaSach, S.TenSach, CT.MaVP, CT.ThanhTien
		from ChiTietTraSach as CT, Sach as S
		where CT.MaSach = S.MaSach
		and @MaTra = CT.MaTra
	)
select * from BookReturnDetail(N'TR01')
