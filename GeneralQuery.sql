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
-- Xóa chi tiết phiếu thuê (Đã test)
--create trigger HuyThueSach on chitietthuesach for delete as
--begin
--declare @masach nvarchar(10)
--select @masach= MaSach from deleted
--update Sach
--set SoLuong=SoLuong + 1
--where MaSach=@masach
--end

-- Mới
create trigger HuyThueSachThuVien on ChiTietThueSach for delete as
begin
	declare @masach nvarchar(10)

	declare MaThueCursor cursor for select MaSach from deleted
	open MaThueCursor
		fetch next from MaThueCursor into @masach
		while @@FETCH_STATUS=0
			begin
				update Sach
				set SoLuong=SoLuong+1
				where MaSach=@masach

				fetch next from MaThueCursor into @masach
			end
	close MaThueCursor
	deallocate MaThueCursor
end
--Mới


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
--create trigger HuyTraSach on ChiTietTraSach for delete as
--begin
--declare @masach nvarchar(10)
--select @masach= MaSach from deleted
--update Sach
--set SoLuong=SoLuong - 1
--where MaSach=@masach
--end


--Mới
create trigger HuyTraSachThuVien on ChiTietTraSach for delete as
begin
	declare @masach nvarchar(10),@mathue nvarchar(10)
	select @masach= MaSach from deleted
	select	@mathue= MaThue from deleted,TraSach
	where TraSach.MaTra=deleted.MaTra
	and @masach=MaSach

	declare MaTraCursor cursor for select MaSach from deleted
	open MaTraCursor
		fetch next from MaTraCursor into @masach
		while @@FETCH_STATUS=0
			begin
				print @mathue
				print @masach
				update ChiTietThueSach
				set DaTra=0
				where MaSach=@masach and MaThue=@mathue
				update Sach
				set SoLuong=SoLuong-1
				where MaSach=@masach

				fetch next from MaTraCursor into @masach
			end
	close MaTraCursor
	deallocate MaTraCursor
end
-- Mới

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
create trigger TraSachThuVien2 on ChiTietTraSach for insert, update as
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
alter function ReportSachThueChuaTra()
returns table
	return select TenSach, COUNT(TenSach) as SoLuong
			from ChiTietThueSach, Sach
			where Sach.MaSach = ChiTietThueSach.MaSach and DaTra=0
			group by TenSach

select * from ReportSachThueChuaTra()

--## 8. Báo cáo tổng tiền cho thuê thu được của cửa hàng theo tháng, quý, năm.
-- (Đang chỉnh sửa)
--báo cáo doanh thu tháng
alter function ChiTietTongTienThueThang(@Thang int, @nam int)
returns table
	return select day(NgayTra)as Ngay,sum(ThanhTien)as Tong,count(NgayTra) as SoDonHang
			from ChiTietTraSach,TraSach
			where month(NgayTra)=@Thang and YEAR(NgayTra)=@nam and TraSach.MaTra=ChiTietTraSach.MaTra
			group by day(NgayTra)

select * from ChiTietTongTienThueThang(11, 2022)


-- báo cáo doanh thu năm
alter function ChiTietTongTienThueNam(@nam int)
returns table
	return select  month(NgayTra) as Thang,sum(ThanhTien)as Tong, count(NgayTra) as SoDonHang
			from ChiTietTraSach,TraSach
			where  YEAR(NgayTra)=@nam and TraSach.MaTra=ChiTietTraSach.MaTra
			group by MONTH(NgayTra)

select * from ChiTietTongTienThueNam(2022)


--## 9. Báo cáo danh sách 5 sách truyện đạt doanh thu nhiều nhất

create function Top5Doanhthu()
returns table
as
	return (
		select top(5) TenSach,sum(thanhtien) as TongDoanhThu from ChiTietTraSach,Sach
		where sach.MaSach=ChiTietTraSach.MaSach
		group by TenSach
		order by sum(thanhtien) desc
	)

	select * from Top5Doanhthu()

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

-- Lấy ra năm tồn tại trong các đơn hàng
create function LoadExistYears()
returns table
	return select YEAR(NgayTra) as Nam from TraSach group by (YEAR(NgayTra))

go
select * from LoadExistYears()
-- Lấy ra tháng tồn tại trong các đơn hàng
alter function LoadExistMonths()
returns table
	return select MONTH(NgayTra) as Thang from TraSach group by (MONTH(NgayTra))

select * from LoadExistMonths()
