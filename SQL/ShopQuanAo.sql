
use QuanLyShopQuanAo
go


CREATE TABLE NhanVien(
    MaNhanVien char(10)PRIMARY KEY,
    MatKhau char(100) NOT NULL,
	HoTen nvarchar(255) NOT NULL,
    Email char(255),
    SDT int NOT NULL,
    NgayTao DATE NOT NULL,
    Enable bit NOT NULL
);
go

CREATE TABLE Role(
    MaRole char(10) PRIMARY KEY,
    TenRole nvarchar(35) NOT NULL,
    Path varchar(255) ,
    GhiChu nvarCHAR(255),
    Enable bit NOT NULL,
    
);
go

CREATE TABLE RoleNhanVien(
    MaRole		char(10) foreign key references Role(MaRole),
    MaNhanVien	char(10) foreign key references NhanVien(MaNhanVien),
    KhichHoat	bit NOT NULL,
    GhiChu		varchar(255) NOT NULL,
	constraint MaRole_TenTaiKhoan PRIMARY KEY (MaRole,MaNhanVien)
);
GO

CREATE TABLE KhachHang(
    MaKhachHang char(10) primary key,
    TenKhachHang nvarchar(35) NOT NULL,
    DiaChi nvarchar(100),
    SDT char(12) NOT NULL,
    Enable bit NOT NULL,
);
CREATE TABLE MauSac(
    MaMau char(10) primary Key,
    TenMau nvarchar(20) NOT NULL,
    Enable bit NOT NULL,
);
CREATE TABLE Size(
    MaSize char(10) primary Key,
    TenSize nvarchar(10) NOT NULL,
    Enable bit NOT NULL,
);
go
CREATE TABLE NhomMatHang(
    MaNhomMatHang char(3) primary Key,
    TenNhomMatHang nvarchar(50) NOT NULL,
    Enable bit NOT NULL,
);
go
CREATE TABLE SanPham(
    MaSP char(20) primary Key,
    TenSP nvarchar(35) NOT NULL,
    GiaBan FLOAT NOT NULL,
	GiamGia FLOAT,
	GiaNhap Float NOT NULL,
    SLTon int NOT NULL,
    NhaCungCap nvarchar(35) NOT NULL,
    IDMau char(10) foreign key references MauSac(MaMau),
    IDSize char(10) foreign key references Size(MaSize),
	IDNhomMatHang char(3) foreign key references NhomMatHang(MaNhomMatHang),
	GhiChu nvarchar(100),
    Enable bit NOT NULL,
);
go
CREATE TABLE HoaDon(
    MaHoaDon char(10) PRIMARY KEY,
    NgayLap DATE NOT NULL,
    TongTien int NOT NULL,
    MaKH char(10) foreign key references KhachHang(MaKhachHang),
    MaNV char(10) foreign key references NhanVien(MaNhanVien),
	GiamGiaHD float,
	PhiShip int ,
	Vat float,
	GhiChu nvarchar(255),
    TrangThai varchar(255) NOT NULL,
    Enable bit NOT NULL,
	
);
CREATE TABLE ChiTietHoaDon(
    MaHD char(10) foreign key references HoaDon(MaHoaDon),
    MaSP char(20) foreign key references SanPham(MaSP),
    SL tinyint NOT NULL,
    GiaBan FLOAT NOT NULL,
    GhiChu nvarchar(255) ,
    Enable bit NOT NULL,
	constraint MaHD_MaSP primary key(MaHD,MaSP)
);
CREATE TABLE PhieuNhapHang(
    MaPhieuNhap char(10) primary key,
    NgayNhap DATE NOT NULL,
    MaNhanVien char(10) foreign key references NhanVien(MaNhanVien),
	
	NguonHang nvarchar(50),
	TongTienHang float,
	CacPhiKhac float,
	PhiVanChuyen float,
	ThueVat float,
	GhiChu nvarchar(50),
    Enable bit NOT NULL,
);
CREATE TABLE ChiTietPhieuNhap(
    MaPhieuNhap char(10) foreign key references PhieuNhapHang(MaPhieuNhap),
    MaSP char(20) foreign key references SanPham(MaSP),
    SL int NOT NULL,
    GiaNhap BIGint NOT NULL,
    GhiChu nvarchar(255) NOT NULL,
    Enable bit NOT NULL,
	constraint MaPN_MaSP primary key(MaPhieuNhap,MaSP)
);
go
--Nhan Vien
CREATE PROCEDURE [dbo].[NhanVien_GetAll]
AS
SELECT * FROM NhanVien	
go
CREATE PROCEDURE [dbo].[NhanVien_InsertUpdateDelete]
 
 @MaNhanVien char(10)output,
 @MatKhau char(100),
 @HoTen nvarchar(255) ,
 @Email char(255),
 @SDT int,
 @NgayTao DATE,
 @Enable bit,
 @Action int
AS

IF @Action = 0
BEGIN
DECLARE @NewCode NVARCHAR(20);
    DECLARE @NextNumber INT;

    -- Lấy số lớn nhất hiện tại và tăng lên 1
    SELECT @NextNumber = ISNULL(MAX(CAST(SUBSTRING([MaNhanVien], 5, LEN([MaNhanVien])) AS INT)), 0) + 1 
    FROM NhanVien;

    -- Tạo mã mới với tiền tố và số tự tăng
    SELECT  @MaNhanVien= 'NV' + RIGHT('0000' + CAST(@NextNumber AS NVARCHAR), 4)
INSERT INTO [NhanVien] ([MaNhanVien],[MatKhau],[HoTen],[Email],[SDT],[NgayTao],[Enable])
VALUES ( @MaNhanVien,@MatKhau,@HoTen,@Email,@SDT,@NgayTao,@Enable)
END

ELSE IF @Action = 1
BEGIN
UPDATE [NhanVien] SET  [MatKhau]=@MatKhau, [HoTen]=@HoTen, 
[Email]=@Email,[NgayTao]=@NgayTao , [SDT]=@SDT, [Enable]=@Enable
WHERE [MaNhanVien] = @MaNhanVien
END

ELSE IF @Action = 2
BEGIN
DELETE FROM [NhanVien] WHERE [MaNhanVien] = @MaNhanVien
END
go




-- Khach Hang
go
CREATE PROCEDURE [dbo].[KhachHang__GetAll] 
AS 
SELECT * FROM [KhachHang]
go
  
CREATE PROCEDURE [dbo].[KhachHang_InsertUpdateDelete] 
     @maKhachHang char(10) output,
	 @tenKhachHang nvarchar(35),
	 @diaChi nvarchar(100),
	 @sdt char(12),
	 @enable bit,
    @Action int 
AS

IF @Action = 0  
 BEGIN 
 DECLARE @NewCode NVARCHAR(20);
    DECLARE @NextNumber INT;

    -- Lấy số lớn nhất hiện tại và tăng lên 1
    SELECT @NextNumber = ISNULL(MAX(CAST(SUBSTRING([MaKhachHang], 5, LEN([MaKhachHang])) AS INT)), 0) + 1 
    FROM [KhachHang];

    -- Tạo mã mới với tiền tố và số tự tăng
    SELECT @NewCode = 'KH' + RIGHT('0000' + CAST(@NextNumber AS NVARCHAR), 4)
	select @maKhachHang=@NewCode;
  INSERT INTO [KhachHang] ([MaKhachHang],[TenKhachHang],[DiaChi],[SDT],[Enable]) 
  VALUES (@maKhachHang, @tenKhachHang,@diaChi,@sdt,@enable) 
 END 
 
ELSE IF @Action = 1  
 BEGIN 
  UPDATE [KhachHang] SET [TenKhachHang] = @tenKhachHang,[DiaChi]=@diaChi,
  [SDT]=@sdt,[Enable]=@enable
  WHERE [MaKhachHang] = @maKhachHang
 END 
ELSE IF @Action = 2  
 BEGIN 
  DELETE FROM [KhachHang] WHERE [MaKhachHang] = @maKhachHang
 END
 go
 --Size
 CREATE PROCEDURE [dbo].[Size_GetAll]
AS
SELECT * FROM Size
go
Create PROCEDURE [dbo].[Size_InsertUpdateDelete]

 @MaSize char(10)output,
 @TenSize nvarchar(10),
 @Enable int,
 @Action int 
AS
IF @Action = 0
BEGIN
DECLARE @NewCode NVARCHAR(20);
    DECLARE @NextNumber INT;

    -- Lấy số lớn nhất hiện tại và tăng lên 1
    SELECT @NextNumber = ISNULL(MAX(CAST(SUBSTRING([MaSize], 5, LEN([MaSize])) AS INT)), 0) + 1 
    FROM [Size];

    -- Tạo mã mới với tiền tố và số tự tăng
    SELECT @NewCode = 'S' + RIGHT('0000' + CAST(@NextNumber AS NVARCHAR), 4)

INSERT INTO [Size] ([MaSize],[TenSize],[Enable])
VALUES (@NewCode, @TenSize,@Enable)
select @MaSize=@NewCode
END
ELSE IF @Action = 1
BEGIN
UPDATE [Size] SET [TenSize]=@TenSize, [Enable]=@Enable
WHERE [MaSize] = @MaSize
END
ELSE IF @Action = 2
BEGIN
DELETE FROM [Size] WHERE [MaSize] = @MaSize
END
go


--Mau Sac
CREATE PROCEDURE [dbo].[MauSac_GetAll]
AS
SELECT * FROM MauSac
go
Create PROCEDURE [dbo].[MauSac_InsertUpdateDelete]

 @MaMau char(10)output,
 @TenMau nvarchar(20),
 @Enable int,
 @Action int
AS
IF @Action = 0
BEGIN
DECLARE @NewCode NVARCHAR(20);
    DECLARE @NextNumber INT;

    -- Lấy số lớn nhất hiện tại và tăng lên 1
    SELECT @NextNumber = ISNULL(MAX(CAST(SUBSTRING(MaMau, 5, LEN(MaMau)) AS INT)), 0) + 1 
    FROM MauSac;

    -- Tạo mã mới với tiền tố và số tự tăng
    SELECT @NewCode = 'MS' + RIGHT('0000' + CAST(@NextNumber AS NVARCHAR), 4)

INSERT INTO [MauSac] ([MaMau],[TenMau],[Enable])
VALUES (@NewCode, @TenMau,@Enable)
select @MaMau=@NewCode
END
ELSE IF @Action = 1
BEGIN

UPDATE [MauSac] SET [TenMau]=@TenMau, [Enable]=@Enable
WHERE [MaMau] = @MaMau
END
ELSE IF @Action = 2
BEGIN
DELETE FROM [MauSac] WHERE [MaMau] = @MaMau
END
go
--Nhom Mat hang
CREATE PROCEDURE [dbo].[NhomMatHang_GetAll]
AS
SELECT * FROM NhomMatHang
go
Create PROCEDURE [dbo].[NhomMatHang_InsertUpdateDelete]

 @MaNhomMatHang char(3)output,
 @TenNhomMatHang nvarchar(50),
 @Enable int,
 @Action int
AS
IF @Action = 0
BEGIN
INSERT INTO [NhomMatHang] ([MaNhomMatHang],[TenNhomMatHang],[Enable])
VALUES (@MaNhomMatHang, @TenNhomMatHang,@Enable)

END
ELSE IF @Action = 1
BEGIN
UPDATE [NhomMatHang] SET [TenNhomMatHang]=@TenNhomMatHang, [Enable]=@Enable
WHERE [MaNhomMatHang] = @MaNhomMatHang
END
ELSE IF @Action = 2
BEGIN
DELETE FROM [NhomMatHang] WHERE [MaNhomMatHang] = @MaNhomMatHang
END
go

 -- San Pham
 CREATE PROCEDURE [dbo].[SanPham_GetAll]
AS
SELECT * FROM SanPham
go

 CREATE PROCEDURE [dbo].[SanPham_InsertUpdateDelete]

 @MaSP char(20)output,
 @TenSP nvarchar(35),
 @GiaBan FLOAT,
 @GiamGia FLOAT,
 @GiaNhap float,
 @SLTon int,
 @NhaCungCap nvarchar(35),
 @IDMau char(10),
 @IDSize char(10),
 @IDNhomMatHang char(3),
 @GhiChu nvarchar(100),
 @Enable int,
 @Action int 
AS
IF @Action = 0
BEGIN
	DECLARE @NewCode NVARCHAR(20);
    DECLARE @NextNumber INT;

    -- Lấy số lớn nhất hiện tại và tăng lên 1
    SELECT @NextNumber = ISNULL(MAX(CAST(SUBSTRING(MaSP, 5, LEN(MaSP)) AS INT)), 0) + 1 
    FROM SanPham;

    -- Tạo mã mới với tiền tố và số tự tăng
    SELECT @NewCode = @IDNhomMatHang + RIGHT('0000' + CAST(@NextNumber AS NVARCHAR), 4)
	

INSERT INTO [SanPham] ([MaSP],[TenSP],[GiaBan],GiamGia,GiaNhap,[SLTon],[NhaCungCap],[IDMau],[IDSize],[IDNhomMatHang],[GhiChu],[Enable])
VALUES (@NewCode, @TenSP,@GiaBan,@GiamGia,@GiaNhap,@SLTon,@NhaCungCap,@IDMau,@IDSize,@IDNhomMatHang,@GhiChu,@Enable)
select @MaSP=@NewCode
END
ELSE IF @Action = 1
BEGIN
UPDATE [SanPham] SET [TenSP]=@TenSP,[GiaBan]=@GiaBan,[GiamGia]=@GiamGia,GiaNhap=@GiaNhap,
[SLTon]=@SLTon,[NhaCungCap]=@NhaCungCap,[IDMau]=@IDMau,[IDSize]=@IDSize,
[IDNhomMatHang]=@IDNhomMatHang,[GhiChu]=@GhiChu,[Enable]=@Enable
WHERE [MaSP] = @MaSP

END
ELSE IF @Action = 2
BEGIN
DELETE FROM [SanPham] WHERE [MaSP] = @MaSP
END
go


--Chi Tiet Hoa Don
CREATE PROCEDURE [dbo].[ChiTietHoaDon_GetAll]
AS
SELECT * FROM ChiTietHoaDon
go
Create PROCEDURE [dbo].[ChiTietHoaDon_InsertUpdateDelete]

 @MaHD char(10)output,
 @MaSP char(20)output,
 @SL int,
 @GiaBan FLOAT,
 @GhiChu nvarchar(255),
 @Enable int,
 @Action int 
AS
IF @Action = 0
BEGIN
INSERT INTO [ChiTietHoaDon] ([MaHD],[MaSP],[SL],[GiaBan],[GhiChu],[Enable])
VALUES (@MaHD,@MaSP,@SL,@GiaBan,@GhiChu, @Enable)

END

ELSE IF @Action = 1
BEGIN
UPDATE [ChiTietHoaDon] SET [SL] = @SL, [GiaBan]=@GiaBan,[GhiChu]=@GhiChu,[Enable]=@Enable
WHERE [MaHD] = @MaHD and [MaSP]=@MaSP
END
ELSE IF @Action = 2
BEGIN
DELETE FROM [ChiTietHoaDon] WHERE [MaHD] = @MaHD and [MaSP]=@MaSP
END
go
--Chi Tiet Phieu nhap
CREATE PROCEDURE [dbo].[ChiTietPhieuNhap_GetAll]
AS
SELECT * FROM ChiTietPhieuNhap
go

CREATE PROCEDURE [dbo].[ChiTietPhieuNhap_InsertUpdateDelete]
 @MaPhieuNhap nvarchar(10)output,
 @MaSP char(20)output,
 @SL int,
 @GiaNhap int,
 @GhiChu nvarchar(255),
 @Enable int,
 @Action int
AS

IF @Action = 0
BEGIN

INSERT INTO [ChiTietPhieuNhap] ([MaPhieuNhap],[MaSP], [SL],[GiaNhap],[GhiChu],[Enable])
VALUES (@MaPhieuNhap,@MaSP,@SL,@GiaNhap,@GhiChu,@Enable)
END

ELSE IF @Action = 1
BEGIN
UPDATE [ChiTietPhieuNhap] SET [SL]=@SL, [GiaNhap]=@GiaNhap, [GhiChu]=@GhiChu, [Enable]=@Enable 
WHERE [MaPhieuNhap] = @MaPhieuNhap and [MaSP]=@MaSP
END

ELSE IF @Action = 2
BEGIN
DELETE FROM [ChiTietPhieuNhap] WHERE [MaPhieuNhap] = @MaPhieuNhap and [MaSP]=@MaSP
END
go


--Hoa Don
CREATE PROCEDURE [dbo].[HoaDon_GetAll]
AS
SELECT * FROM HoaDon
go

CREATE PROCEDURE [dbo].[HoaDon_InsertUpdateDelete]

 @MaHoaDon char(10)output,
 @NgayLap date,
 @TongTien int,
 @MaKH char(10),
 @MaNV char(10),

 @GiamGiaHD float,
 @PhiShip int ,
 @Vat float,
 @GhiChu nvarchar(255),
 @TrangThai varchar(255),
 @Enable int,
 @Action int -- Biến cho biết thêm, xóa, hay sửa
AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0
BEGIN
DECLARE @NewCode NVARCHAR(20);
    DECLARE @NextNumber INT;

    -- Lấy số lớn nhất hiện tại và tăng lên 1
    SELECT @NextNumber = ISNULL(MAX(CAST(SUBSTRING([MaHoaDon], 5, LEN([MaHoaDon])) AS INT)), 0) + 1 
    FROM [HoaDon];

    -- Tạo mã mới với tiền tố và số tự tăng
    SELECT @NewCode = 'HD' + RIGHT('0000' + CAST(@NextNumber AS NVARCHAR), 4)
INSERT INTO [HoaDon] ([MaHoaDon],[NgayLap],[TongTien],[MaKH],[MaNV], [GiamGiaHD],[PhiShip],[Vat],[GhiChu]
,[TrangThai] ,[Enable])
VALUES (@NewCode, @NgayLap,@TongTien,@MaKH,@MaNV, @GiamGiaHD,@PhiShip,@Vat,@GhiChu 
,@TrangThai,@Enable)
select @MaHoaDon=@NewCode

END
-- Nếu Action = 1, thực hiện cập nhật dữ liệu
ELSE IF @Action = 1
BEGIN
UPDATE [HoaDon] SET [NgayLap] = @NgayLap, [TongTien]=@TongTien,[MaKH]=@MaKH,[TrangThai]=@TrangThai,[Enable]=@Enable,
[GiamGiaHD]=@GiamGiaHD,[PhiShip]=@PhiShip,[Vat]=@Vat,[GhiChu]=@GhiChu
WHERE [MaHoaDon] = @MaHoaDon
END
-- Nếu Action = 2, thực hiện xóa dữ liệu
ELSE IF @Action = 2
BEGIN
DELETE FROM [HoaDon] WHERE [MaHoaDon] = @MaHoaDon
END
go


--Phieu Nhap Hang
CREATE PROCEDURE [dbo].[PhieuNhapHang_GetAll]
AS
SELECT * FROM PhieuNhapHang
go

CREATE PROCEDURE [dbo].[PhieuNhapHang_InsertUpdateDelete]
 @MaPhieuNhap char(10)output,
 @NgayNhap date,
 @MaNhanVien char(10),

 @NguonHang nvarchar(50),
 @TongTienHang float,
 @CacPhiKhac float,
 @PhiVanChuyen float,
 @ThueVat float,
 @GhiChu nvarchar(50),
 @Enable bit ,
 @Action int

AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0
BEGIN
    DECLARE @NextNumber INT;

    -- Lấy số lớn nhất hiện tại và tăng lên 1
    SELECT @NextNumber = ISNULL(MAX(CAST(SUBSTRING([MaPhieuNhap], 5, LEN([MaPhieuNhap])) AS INT)), 0) + 1 
    FROM [PhieuNhapHang];

    -- Tạo mã mới với tiền tố và số tự tăng
    SELECT @MaPhieuNhap = 'PN' + RIGHT('0000' + CAST(@NextNumber AS NVARCHAR), 4)
INSERT INTO [PhieuNhapHang] ([MaPhieuNhap],[NgayNhap],[MaNhanVien],[NguonHang],TongTienHang,CacPhiKhac,PhiVanChuyen,
ThueVat,GhiChu,[Enable])
VALUES (@MaPhieuNhap, @NgayNhap,@MaNhanVien,@NguonHang,@TongTienHang,@CacPhiKhac,@PhiVanChuyen,@ThueVat,
@GhiChu,@Enable)
END

ELSE IF @Action = 1
BEGIN
UPDATE [PhieuNhapHang] SET [NgayNhap] = @NgayNhap, NguonHang=@NguonHang, [MaNhanVien]=@MaNhanVien,TongTienHang=@TongTienHang,
CacPhiKhac=@CacPhiKhac,PhiVanChuyen=@PhiVanChuyen,ThueVat=@ThueVat,GhiChu=@GhiChu,
[Enable]=@Enable
WHERE [MaPhieuNhap] = @MaPhieuNhap	
END
-- Nếu Action = 2, thực hiện xóa dữ liệu
ELSE IF @Action = 2
BEGIN
DELETE FROM [PhieuNhapHang] WHERE [MaPhieuNhap] = @MaPhieuNhap
END
go
----RoleNhanVien
create PROCEDURE [dbo].[RoleNhanVien_GetAll]
as
SELECT * from RoleNhanVien
go
CREATE PROCEDURE [dbo].[RoleNhanVien_InsertUpdateDelete]
  @MaRole		char(10) ,
   @MaNhanVien	char(10) ,
    @KhichHoat	bit ,
    @GhiChu		varchar(255) ,
 @Action int

AS
-- Nếu Action = 0, thực hiện thêm dữ liệu
IF @Action = 0
BEGIN
  
INSERT INTO RoleNhanVien ([MaRole],[MaNhanVien],[KhichHoat],
[GhiChu])
VALUES (@MaRole,@MaNhanVien,@KhichHoat,@GhiChu)
END

ELSE IF @Action = 1
BEGIN
UPDATE RoleNhanVien SET [KhichHoat]=@KhichHoat,[GhiChu]=@GhiChu
WHERE [MaRole] = @MaRole and [MaNhanVien]=@MaNhanVien
END
-- Nếu Action = 2, thực hiện xóa dữ liệu
ELSE IF @Action = 2
BEGIN
DELETE FROM RoleNhanVien WHERE [MaRole] = @MaRole
END
go


INSERT INTO  MauSac([MaMau], TenMau, Enable)Values('MS0000', N'Tất cả', 1);
exec MauSac_InsertUpdateDelete '', N'Đỏ', 1,0;
exec MauSac_InsertUpdateDelete '', N'Xanh Dương', 1,0;
exec MauSac_InsertUpdateDelete '', N'Xanh Lá', 1,0;
exec MauSac_InsertUpdateDelete '', N'Vàng', 1,0;
exec MauSac_InsertUpdateDelete '', N'Trắng', 1,0;
exec MauSac_InsertUpdateDelete '', N'Đen', 1,0;
exec MauSac_InsertUpdateDelete '', N'Hồng', 1,0;
exec MauSac_InsertUpdateDelete '', N'Cam', 1,0;
exec MauSac_InsertUpdateDelete '', N'Tím', 1,0;
exec MauSac_InsertUpdateDelete '', N'Xám', 1,0;

select * from MauSac

INSERT INTO Size (MaSize, TenSize, Enable)values('S0000', N'Tất cả', 1);
--VALUES exec 
exec Size_InsertUpdateDelete '', 'XS', 1,0;
exec Size_InsertUpdateDelete '', 'S', 1,0;
exec Size_InsertUpdateDelete '', 'M', 1,0;
exec Size_InsertUpdateDelete '', 'L', 1,0;
exec Size_InsertUpdateDelete '', 'XL', 1,0;
exec Size_InsertUpdateDelete '', 'XXL', 1,0;
exec Size_InsertUpdateDelete '', 'XXXL', 1,0;
exec Size_InsertUpdateDelete '', '4XL', 1,0;
exec Size_InsertUpdateDelete '', '5XL', 1,0;
exec Size_InsertUpdateDelete '', '6XL', 1,0;

select * from Size

--insert into NhomMatHang(MaNhomMatHang,TenNhomMatHang,Enable)
--values exec NhomMatHang_InsertUpdateDelete
exec NhomMatHang_InsertUpdateDelete '001',N'Tất Cả',1,0;
exec NhomMatHang_InsertUpdateDelete 'VAY',N'Váy',1,0;
exec NhomMatHang_InsertUpdateDelete 'AOT',N'Áo thun',1,0;
exec NhomMatHang_InsertUpdateDelete 'ASM',N'Áo sơ mi',1,0;
exec NhomMatHang_InsertUpdateDelete 'AOK',N'áo khoác',1,0;
exec NhomMatHang_InsertUpdateDelete 'QUA',N'quần',1,0;
exec NhomMatHang_InsertUpdateDelete 'GIA',N'giày',1,0;
exec NhomMatHang_InsertUpdateDelete 'TUI',N'túi xách',1,0;
exec NhomMatHang_InsertUpdateDelete 'NON',N'nón',1,0;
exec NhomMatHang_InsertUpdateDelete 'THL',N'thắt lưng',1,0;

select * from NhomMatHang
--INSERT INTO SanPham (MaSP, TenSP, GiaBan, SLTon, NhaCungCap, IDMau, IDSize,IDNhomMatHang, GhiChu, Enable)
--VALUES 
exec SanPham_InsertUpdateDelete '', N'Áo Thun', 200000, 0.0,190000,100,'Nike', 'MS0001', 'S0001','AOT', N'Áo thun nam', 1,0;
exec SanPham_InsertUpdateDelete '', N'Áo Khoác', 500000,0.0,490000, 50,'gucci', 'MS0002', 'S0002','AOK', N'Áo khoác nữ', 1,0;
exec SanPham_InsertUpdateDelete '', N'Quần Jean', 300000,0.0,290000, 70,'gucci', 'MS0003', 'S0003','QUA', N'Quần jean xanh', 1,0;
exec SanPham_InsertUpdateDelete '', N'Giày Sneaker', 700000,0.0,790000, 40,'Nike', 'MS0004', 'S0004','GIA', N'Giày thể thao', 1,0;
exec SanPham_InsertUpdateDelete '', N'Túi Xách', 250000,9.99,240000, 90,'gucci', 'MS0005', 'S0005','TUI', N'Túi xách nữ', 1,0;
exec SanPham_InsertUpdateDelete '', N'Nón Lưỡi Trai', 150000, 0.0,140000,150,'Nike', 'MS0006', 'S0006','NON', N'Nón thời trang', 1,0;
exec SanPham_InsertUpdateDelete '', N'Váy Dạ Hội', 900000,0.0,800000, 30,'Nike', 'MS0007', 'S0007','VAY', N'Váy nữ cao cấp', 1,0;
exec SanPham_InsertUpdateDelete '', N'Thắt Lưng', 120000,0.0,110000, 90,'gucci', 'MS0008', 'S0008','THL', N'Thắt lưng da', 1,0;
exec SanPham_InsertUpdateDelete '', N'Áo Sơ Mi', 350000,10.1,340000, 60,'gucci', 'MS0009', 'S0009','ASM', N'Áo sơ mi trắng', 1,0;
exec SanPham_InsertUpdateDelete '', N'Giày Cao Gót', 450000,0.0,440000, 45,'gucci', 'MS0010', 'S0010','GIA', N'Giày nữ cao gót', 1,0;

select * from SanPham
--INSERT INTO KhachHang (MaKhachHang, TenKhachHang, DiaChi, SDT, Enable)
--VALUES 
exec KhachHang_InsertUpdateDelete 'KH001', N'Nguyen Van A', N'123 Nguyen Trai, Hanoi', '0912345678', 1,0;
exec KhachHang_InsertUpdateDelete 'KH002', N'Tran Thi B', N'456 Tran Hung Dao, HCMC', '0987654321', 1,0;
exec KhachHang_InsertUpdateDelete 'KH003', N'Le Thi C', N'789 Le Loi, Da Nang', '0923456789', 1,0;
exec KhachHang_InsertUpdateDelete 'KH004', N'Pham Van D', N'101 Phan Chu Trinh, Hai Phong', '0945678901', 1,0;
exec KhachHang_InsertUpdateDelete 'KH005', N'Hoang Thi E', N'202 Hoang Van Thu, Hue', '0961234567', 1,0;
exec KhachHang_InsertUpdateDelete 'KH006', N'Dang Van F', N'303 Hai Ba Trung, HCMC', '0934567890', 1,0;
exec KhachHang_InsertUpdateDelete 'KH007', N'Bui Thi G', N'404 Bach Dang, Da Nang', '0976543210', 1,0;
exec KhachHang_InsertUpdateDelete 'KH008', N'Do Van H', N'505 Ly Thuong Kiet, Hanoi', '0901234567', 1,0;
exec KhachHang_InsertUpdateDelete 'KH009', N'Vu Thi I', N'606 Nguyen Hue, HCMC', '0954321098', 1,0;
exec KhachHang_InsertUpdateDelete 'KH010', N'Nguyen Van J', N'707 Tran Phu, Nha Trang', '0998765432', 1,0;
select * from KhachHang

exec NhanVien_InsertUpdateDelete '','1','Nguyen van t','nguyenvant@gmail.com','0908888888','2024-11-21',1,0;
exec NhanVien_InsertUpdateDelete '','1','Nguyen van b','nguyenvanb@gmail.com','0908888889','2024-11-21',1,0;
exec NhanVien_InsertUpdateDelete '','1','Nguyen van p','nguyenvanp@gmail.com','0908888899','2024-11-21',1,0;

select * from NhanVien

insert into [Role] ([MaRole],[TenRole],[Path],[GhiChu],[Enable])values
('001',N'chủ cửa hàng','',N'được tất nhiều quyền',1),
('002',N'Quản lý','',N'được tất nhiều quyền',1),
('003',N'Nhân viên','',N'được tất nhiều quyền',1);

select * from [Role];
go
exec RoleNhanVien_InsertUpdateDelete '001','NV0001',1,'',0;
 exec RoleNhanVien_InsertUpdateDelete '002','NV0002',1,'',0;
 exec RoleNhanVien_InsertUpdateDelete '003','NV0003',1,'',0;

 select * from [RoleNhanVien];
--INSERT INTO HoaDon (MaHoaDon, NgayLap, TongTien, MaKH, MaNV, TrangThai, Enable)
--VALUES;
exec HoaDon_InsertUpdateDelete '', '2024-01-01', 500000, 'KH0001', 'NV0001',1.2,12000,1.2,N'', N'Đã thanh toán', 1, 0;
exec HoaDon_InsertUpdateDelete '', '2024-01-02', 300000, 'KH0002', 'NV0002',1.2,12000,1.2,N'', N'Đã thanh toán', 1,0;
exec HoaDon_InsertUpdateDelete '', '2024-01-03', 450000, 'KH0003', 'NV0001',1.2,12000,1.2,N'', N'Chưa thanh toán', 1,0;
exec HoaDon_InsertUpdateDelete '', '2024-01-04', 250000, 'KH0004', 'NV0002',1.2,12000,1.2,N'', N'Đã thanh toán', 1,0;
exec HoaDon_InsertUpdateDelete '', '2024-01-05', 700000, 'KH0005', 'NV0001',1.2,12000,1.2,N'', N'Đã thanh toán', 1,0;
exec HoaDon_InsertUpdateDelete '', '2024-01-06', 800000, 'KH0006', 'NV0001',1.2,12000,1.2,N'', N'Chưa thanh toán', 1,0;
exec HoaDon_InsertUpdateDelete '', '2024-01-07', 200000, 'KH0007', 'NV0001',1.2,12000,1.2,N'', N'Đã thanh toán', 1,0;
exec HoaDon_InsertUpdateDelete '', '2024-01-08', 150000, 'KH0008', 'NV0001',1.2,12000,1.2,N'', N'Đã thanh toán', 1,0;
exec HoaDon_InsertUpdateDelete '', '2024-01-09', 650000, 'KH0009', 'NV0002',1.2,12000,1.2,N'', N'Chưa thanh toán', 1,0;
exec HoaDon_InsertUpdateDelete '', '2024-01-10', 300000, 'KH0010', 'NV0001',1.2,12000,1.2,N'', N'Đã thanh toán', 1,0;
select * from HoaDon
--INSERT INTO ChiTietHoaDon (MaHD, MaSP, SL, GiaBan, GhiChu, Enable)
--VALUES 
exec ChiTietHoaDon_InsertUpdateDelete 'HD0001', 'AOT0001', 2, 200000, N'Áo thun', 1,0;
exec ChiTietHoaDon_InsertUpdateDelete 'HD0001', 'AOK0002', 1, 500000, N'Áo khoác', 1,0;
exec ChiTietHoaDon_InsertUpdateDelete 'HD0003', 'QUA0003', 3, 300000, N'Quần jean xanh', 1,0;
exec ChiTietHoaDon_InsertUpdateDelete 'HD0002', 'GIA0004', 1, 700000, N'Giày sneaker', 1,0;
exec ChiTietHoaDon_InsertUpdateDelete 'HD0002', 'TUI0005', 2, 250000, N'Túi xách', 1,0;
exec ChiTietHoaDon_InsertUpdateDelete 'HD0004', 'NON0006', 5, 150000, N'Nón lưỡi trai', 1,0;
exec ChiTietHoaDon_InsertUpdateDelete 'HD0005', 'VAY0007', 1, 900000, N'Váy dạ hội', 1,0;
exec ChiTietHoaDon_InsertUpdateDelete 'HD0006', 'THL0008', 3, 120000, N'Thắt lưng', 1,0;
exec ChiTietHoaDon_InsertUpdateDelete 'HD0007', 'ASM0009', 2, 350000, N'Áo sơ mi', 1,0;
exec ChiTietHoaDon_InsertUpdateDelete 'HD0008', 'GIA0010', 1, 450000, N'Giày cao gót', 1,0;

--INSERT INTO PhieuNhapHang (MaPhieuNhap, NgayNhap, NhaCungCap, MaNhanVien, Enable)
--VALUES 
exec PhieuNhapHang_InsertUpdateDelete '', '2024-01-01', 'NV0001','nike',12000,12200,1232,1.2,'ha', 1,0;
exec PhieuNhapHang_InsertUpdateDelete '', '2024-01-02', 'NV0002','nike',12000,12200,1232,1.2,'ha', 1,0;
exec PhieuNhapHang_InsertUpdateDelete '', '2024-01-03', 'NV0001','nike',12000,12200,1232,1.2,'ha', 1,0;
exec PhieuNhapHang_InsertUpdateDelete '', '2024-01-04', 'NV0002','nike',12000,12200,1232,1.2,'ha', 1,0;
exec PhieuNhapHang_InsertUpdateDelete '', '2024-01-05', 'NV0001','nike',12000,12200,1232,1.2,'ha', 1,0;
exec PhieuNhapHang_InsertUpdateDelete '', '2024-01-06', 'NV0002','nike',12000,12200,1232,1.2,'ha', 1,0;
exec PhieuNhapHang_InsertUpdateDelete '', '2024-01-07', 'NV0002','nike',12000,12200,1232,1.2,'ha', 1,0;
exec PhieuNhapHang_InsertUpdateDelete '', '2024-01-08', 'NV0001','nike',12000,12200,1232,1.2,'ha', 1,0;
exec PhieuNhapHang_InsertUpdateDelete '', '2024-01-09', 'NV0002','nike',12000,12200,1232,1.2,'ha', 1,0;
exec PhieuNhapHang_InsertUpdateDelete '', '2024-01-10', 'NV0001','nike',12000,12200,1232,1.2,'ha', 1,0;

--INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaSP, SL, GiaNhap, GhiChu, Enable)
--VALUES 

exec ChiTietPhieuNhap_InsertUpdateDelete 'PN0001', 'AOT0001', 10, 180000, N'Nhập áo thun', 1,0;
exec ChiTietPhieuNhap_InsertUpdateDelete 'PN0002', 'AOK0002', 5, 450000 , N'Nhập áo khoác', 1,0;
exec ChiTietPhieuNhap_InsertUpdateDelete 'PN0003', 'QUA0003', 8, 270000 , N'Nhập quần jean', 1,0;
exec ChiTietPhieuNhap_InsertUpdateDelete 'PN0004', 'GIA0004', 2, 650000 , N'Nhập giày sneaker', 1,0;
exec ChiTietPhieuNhap_InsertUpdateDelete 'PN0005', 'TUI0005', 7, 220000 , N'Nhập túi xách', 1,0;
exec ChiTietPhieuNhap_InsertUpdateDelete 'PN0006', 'NON0006', 15, 120000, N'Nhập nón lưỡi trai', 1,0;
exec ChiTietPhieuNhap_InsertUpdateDelete 'PN0007', 'VAY0007', 3, 850000 , N'Nhập váy dạ hội', 1,0;
exec ChiTietPhieuNhap_InsertUpdateDelete 'PN0008', 'THL0008', 10, 100000, N'Nhập thắt lưng', 1,0;
exec ChiTietPhieuNhap_InsertUpdateDelete 'PN0009', 'ASM0009', 4, 320000 , N'Nhập áo sơ mi', 1,0;
exec ChiTietPhieuNhap_InsertUpdateDelete 'PN0010', 'GIA0010', 5, 420000 , N'Nhập giày cao gót', 1,0;

--INSERT INTO NhanVien (MaNhanVien, TenNhanVien, Role, MatKhau, Enable)
--VALUES 



select * from MauSac
select * from Size
select * from SanPham

select * from HoaDon
select * from ChiTietHoaDon
select * from KhachHang

select * from PhieuNhapHang
select * from ChiTietPhieuNhap
select * from NhomMatHang

select * from NhanVien
select * from Role
select * from RoleNhanVien


go

