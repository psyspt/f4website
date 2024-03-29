


--- F5 từng phần 1 đừng chạy hết 1 lần----------

---------
alter table CV Drop constraint FK_CV_VITRI
alter table CV Drop constraint FK_CV_VITRI1
---------



-------------
drop table VITRI
alter table NGUOITIMVIECLUUTINTUYENDUNG drop constraint FK_NGUOITIMVIECLUUTINTUYENDUNG_TINTUYENDUNG
drop table TINTUYENDUNG
-----------------



-----------------
create table THONGTINVIECLAM
(
	MaSoCongViec nvarchar(20) not null,
	SoLuong int,
	GioiTinh int,
	TuoiMin int,
	TuoiMax int,
	SoNamKinhNghiem int,
	QuocGia int,
	TinhThanh int,
	LoaiCV int,
	MucLuong int,
	PhuCapKhac nvarchar(500),
	HanNopHoSo datetime,
)

Create table LOAIUNGVIEN
(
	ID int IDENTITY(1,1) not null,
	NganhNghe nvarchar(100),
	CapBac nvarchar(100),
	BangCap nvarchar(100),
)

create table TINTUYENDUNG
(
	ID int IDENTITY(1,1) not null,
	ViTriTuyenDung nvarchar(100),
	MoTaCongViec nvarchar(500),
	KyNangCongViec nvarchar(500),
	MaSoCongViec nvarchar(100),
	LoaiUngVien int,
	NhaTuyenDung int,
)


alter table THONGTINVIECLAM add constraint PK_THONGTINVIECLAM primary key (MaSoCongViec)
alter table LOAIUNGVIEN add constraint PK_LOAIUNGVIEN primary key (ID)
alter table TINTUYENDUNG add constraint PK_TINTUYENDUNG primary key (ID)
alter table TINTUYENDUNG add constraint FK_TINTUYENDUNG_THONGTINVIECLAM foreign key (MaSoCongViec) references THONGTINVIECLAM(MaSoCongViec) 
alter table TINTUYENDUNG add constraint FK_TINTUYENDUNG_NHATUYENDUNG foreign key (NhaTuyenDung) references NHATUYENDUNG(ID) 
alter table TINTUYENDUNG add constraint FK_TINTUYENDUNG_LOAIUNGVIEN foreign key (LoaiUngVien) references LOAIUNGVIEN(ID) 
alter table THONGTINVIECLAM add constraint FK_THONGTINVIECLAM_LOAICONGVIEC foreign key (LoaiCV) references LOAICONGVIEC(ID)

insert into LOAIUNGVIEN values(N'Công nghệ thông tin', N'Trình độ cao đẳng', N'Cao đẳng')
insert into LOAIUNGVIEN values(N'Dịch vụ /Khách sạn / Nhà Hàng', N'Tốt nghiệp cấp 2', N'cấp 2')
insert into LOAIUNGVIEN values(N'Báo chí/ biên tập viên', N'Trình độ đại học', N'đại học')
insert into LOAIUNGVIEN values(N'Biêu chính viễn thông', N'Trình độ cao đẳng', N'Cao đẳng')
insert into LOAIUNGVIEN values(N'Dịch vụ /Khách sạn / Nhà Hàng', N'Trình độ cao đẳng', N'Cao đẳng')

insert into LOAICONGVIEC values(N'Full-time', N'Nhân viên chính thức', 1)
insert into LOAICONGVIEC values(N'Full-time', N'Thời vụ', 1)
insert into LOAICONGVIEC values(N'Full-time', N'Tự do', 1)
insert into LOAICONGVIEC values(N'Part-time', N'Nhân viên chính thức', 1)
insert into LOAICONGVIEC values(N'Part-time', N'Thời vụ', 1)
insert into LOAICONGVIEC values(N'Part-time', N'Tự do', 1)

---------------------------------




---------------------------------

Create Proc sp_InsertMoTaCongViec 
	@ViTriTuyenDung nvarchar(100), @Mota nvarchar(500), @KyNang nvarchar(500)
AS
Begin
	insert into MOTACONGVIEC values(@ViTriTuyenDung,@Mota,@KyNang)
End




----------------------------------


create Proc sp_insertLOAIUNGVIEN 
	@NganhNghe nvarchar(100), @CapBac nvarchar(100), @BangCap nvarchar(100)
AS
Begin
	insert into LOAIUNGVIEN values(@NganhNghe, @CapBac, @BangCap)
End 

-----------------------------------





-----------------------------------

drop proc sp_insertTINTUYENDUNG

create Proc sp_insertTINTUYENDUNG 
	@ViTriTuyenDung nvarchar(100),
	@MoTaCongViec nvarchar(500),
	@KyNangCongViec nvarchar(500),
	@MaSoCongViec nvarchar(100),
	@LoaiUngVien int,
	@NhaTuyenDung int
AS
Begin
	insert into TINTUYENDUNG values(@ViTriTuyenDung, @MoTaCongViec, @KyNangCongViec, @MaSoCongViec, @LoaiUngVien,@NhaTuyenDung)
End 
---------------------------------------------





---------------------------------------------

create proc sp_insertTHONGTINVIECLAM
	@MaSoCongViec nvarchar(20),
	@SoLuong int,
	@GioiTinh int,
	@TuoiMin int,
	@TuoiMax int,
	@SoNamKinhNghiem int,
	@QuocGia int,
	@TinhThanh int,
	@LoaiCV int,
	@MucLuong int,
	@PhuCapKhac nvarchar(500)
	
As
Begin
	insert into THONGTINVIECLAM values(@MaSoCongViec,@SoLuong, @GioiTinh, @TuoiMin, @TuoiMax, @SoNamKinhNghiem, @QuocGia, @TinhThanh,@LoaiCV, @MucLuong, @PhuCapKhac, '')
End

----------------------------------------------------------------------





----------------------------------------------------------------------
Create Proc sp_GetIDLOAIUV
	@NganhNghe nvarchar(100),
	@CapBac nvarchar(100),
	@BangCap nvarchar(100)
As
Begin
	Select ID from LOAIUNGVIEN where NganhNghe = @NganhNghe and CapBac = @CapBac and  BangCap= @BangCap
End
--------------------------------------------------------------------------





---------------------------------------------------------------------
create Proc sp_GetIDNHATUYENDUNG
	@Email varchar(50)
As
Begin
	Select ID From NHATUYENDUNG where Email = @Email
End




---------------------------------------------------------------------------


Create Proc sp_GetIDLOAICV
	@TenLoaiCongViec varchar(10),
	@MoTa nvarchar(50)
As
Begin
	Select ID from LOAICONGVIEC where TenLoaiCongViec = @TenLoaiCongViec and MoTa = @MoTa
End


exec sp_GetIDLOAICV 'Part-time', 'Thời vụ'