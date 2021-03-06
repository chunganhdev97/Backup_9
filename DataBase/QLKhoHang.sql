﻿CREATE DATABASE QLKH
GO

USE QLKH
GO

CREATE TABLE DANGNHAP
(
	USERNAME NCHAR(10) PRIMARY KEY,
	PASSWORD NCHAR(10),
	MANV NCHAR(10),
	QUYENHAN NCHAR(10)
)
GO
CREATE TABLE KHOHANG
(
	MAKHO NCHAR(10) PRIMARY KEY,
	TENKHO NVARCHAR(50) NOT NULL,
	TONGSOSP INT,
	GHICHU NVARCHAR(MAX)
)
GO
CREATE TABLE BOPHAN
(
	MABP NCHAR(10) PRIMARY KEY,
	TENBP NVARCHAR(50) UNIQUE NOT NULL,
	DIENTHOAI NCHAR(15),
	MAKHO NCHAR(10) REFERENCES KHOHANG(MAKHO),
	NQL NCHAR(10) 

)
GO
CREATE TABLE NHANVIEN
(
	MANV NCHAR(10) PRIMARY KEY,
	TENNV NVARCHAR(30) UNIQUE NOT NULL,
	EMAIL NCHAR(30),
	NS DATE,
	GT NCHAR(3) CHECK(GT IN('NAM','NỮ')),
	DIENTHOAI NCHAR(15),
	CHUCVU NVARCHAR(50),
	DIACHI NVARCHAR(50),
	LUONG FLOAT,
	MABP NCHAR(10) REFERENCES BOPHAN(MABP)
)
GO
CREATE TABLE KHACHHANG
(
	MAKH NCHAR(10) PRIMARY KEY,
	TENKH NVARCHAR(50),
	DIACHI NVARCHAR(50),
	GIOITINH NVARCHAR(5) CHECK(GIOITINH IN('NAM',N'NỮ')),
	DIENTHOAI NCHAR(15),
	EMAIL NVARCHAR(50),
	FAX NCHAR(15)
)
GO
CREATE TABLE NHACUNGCAP
(
	MANCC NCHAR(10) PRIMARY KEY,
	TENNHACC NVARCHAR(50),
	DIACHI NVARCHAR(MAX),
	GHICHU NVARCHAR(MAX)
)
GO
CREATE TABLE DANHMUC
(
	MADANHMUC NCHAR(10) PRIMARY KEY,
	TENDANHMUC NVARCHAR(50),
	GHICHU NVARCHAR(MAX),
	MAKHO NCHAR(10) REFERENCES KHOHANG(MAKHO)
)
GO
CREATE TABLE SANPHAM
(
	MASP NCHAR(10) PRIMARY KEY,
	TENSP NVARCHAR(50) UNIQUE NOT NULL,
	MANCC NCHAR(10) REFERENCES NHACUNGCAP(MANCC),
	GIA FLOAT,
	MADANHMUC NCHAR(10) REFERENCES DANHMUC(MADANHMUC),
	SERIAL NCHAR(15),
	HINHANH IMAGE,
	NGAYSANXUAT DATETIME,
	HANSUDUNG DATETIME,
	GHICHU NVARCHAR(MAX),
	SOLUONG INT,
	PHANLOAI NVARCHAR(50)
)
GO
CREATE TABLE PHIEUNHAPKHO
(
	MAPN NCHAR(10) PRIMARY KEY,
	MAKHO NCHAR(10) REFERENCES KHOHANG(MAKHO),
	NVNHAP NCHAR(10) REFERENCES NHANVIEN(MANV),
	NGAYNHAP DATETIME,
	MANCC NCHAR(10) REFERENCES NHACUNGCAP(MANCC),
	GHICHU NVARCHAR(MAX)
)
GO
CREATE TABLE CHITIETPHIEUNHAP
(
	MAPN NCHAR(10) PRIMARY KEY REFERENCES PHIEUNHAPKHO(MAPN),
	MASP NCHAR(10) REFERENCES SANPHAM(MASP),
	SOLUONG INT,
	TONGTIEN FLOAT
)
GO
CREATE TABLE PHIEUXUAT
(
	MAPX NCHAR(10) PRIMARY KEY,
	MAKHO NCHAR(10) REFERENCES KHOHANG(MAKHO),
	NVXUAT NCHAR(10) REFERENCES NHANVIEN(MANV),
	NGAYXUAT DATETIME,
	MAKH NCHAR(10) REFERENCES KHACHHANG(MAKH),
	GHICHU NVARCHAR(MAX)
)
GO
CREATE TABLE CHITIETPHIEUXUAT
(
	MAPX NCHAR(10) PRIMARY KEY REFERENCES PHIEUXUAT(MAPX),
	MASP NCHAR(10) REFERENCES SANPHAM(MASP),
	SOLUONG INT,
	TONGTIEN FLOAT
)
GO
CREATE TABLE BAOCAOTHONGKE
(
	MABC NCHAR(10) PRIMARY KEY,
	NGAYLAPBC DATE,
	NQL NCHAR(10) REFERENCES NHANVIEN(MANV),
	NGAYPHEDUYET DATE,
	MAKHO NCHAR(10) REFERENCES KHOHANG(MAKHO),
	GHICHU NVARCHAR(MAX)
)
GO
CREATE TABLE CHITIETBAOCAO
(
	MABC NCHAR(10) REFERENCES BAOCAOTHONGKE(MABC),
	SANPHAM NCHAR(10) REFERENCES SANPHAM(MASP),
	SOLUONGCU INT,
	SOLUONGMOI INT,
	TONKHO INT,
	GHICHU NVARCHAR(MAX),
	PRIMARY KEY(MABC,SANPHAM)
)
GO
-- THÊM KHÓA NGOẠI NQL VÀO BẢNG BỘ PHẬN
ALTER TABLE BOPHAN ADD FOREIGN KEY(NQL) REFERENCES NHANVIEN(MANV);
GO
ALTER TABLE DANGNHAP ADD FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV);
GO

-- TẠO THỦ TỤC THÊM SỬA XÓA

-- THỦ TỤC THÊM

-- Bộ Phận

CREATE PROC THEM_BOPHAN(
@MABP nchar(10),
@TENBP nvarchar(50),
@DIENTHOAI nchar(15),
@MAKHO nchar(10),
@NQL NCHAR(10)
)
AS
BEGIN
	insert into BOPHAN
	values 
		(@MABP, @TENBP, @DIENTHOAI, @MAKHO, @NQL)
END
GO

CREATE PROC CAPNHAT_BOPHAN(
@MABP nchar(10),
@TENBP nvarchar(50),
@DIENTHOAI nchar(15),
@MAKHO nchar(10),
@NQL NCHAR(10)
)
AS
BEGIN
	UPDATE BOPHAN
	SET MABP = @MABP ,TENBP = @TENBP,DIENTHOAI = @DIENTHOAI,MAKHO = @MAKHO, NQL = @NQL
	WHERE MABP = @MABP
END
GO

CREATE PROC XOA_BOPHAN(
@MABP nchar(10)
)
as
begin
	delete BOPHAN
	where MABP = @MABP
end
go

-- Bộ Phận


-- Tài Khoản

CREATE PROC THEM_TAIKHOAN(
@USERNAME NCHAR(10),
@PASSWORD NCHAR(10),
@MANV NCHAR(10),
@QUYENHAN NCHAR(10)
)
AS
BEGIN
	INSERT INTO DANGNHAP
	VALUES (@USERNAME ,@PASSWORD, @MANV, @QUYENHAN )
END
GO

CREATE PROC UPDATE_TAIKHOAN(
@USERNAME NCHAR(10),
@PASSWORD NCHAR(10),
@MANV NCHAR(10),
@QUYENHAN NCHAR(10)
)
AS
BEGIN
	UPDATE DANGNHAP
	SET USERNAME = @USERNAME ,PASSWORD = @PASSWORD,MANV = @MANV,QUYENHAN = @QUYENHAN
	WHERE USERNAME = @USERNAME
END
GO

CREATE PROC DELETE_TAIKHOAN(
@USERNAME NCHAR(10)
)
AS
BEGIN
	DELETE DANGNHAP WHERE USERNAME = @USERNAME
END
GO

-- Tài Khoản

-- Nhà Cung Cấp

CREATE PROC THEM_NHACC(
@MANCC NCHAR(10),
@TENNHACC NVARCHAR(50),
@DIACHI NVARCHAR(MAX),
@GHICHU NVARCHAR(MAX)
)
AS
BEGIN
	INSERT INTO NHACUNGCAP
	VALUES (@MANCC, @TENNHACC,@DIACHI, @GHICHU)
END
GO

CREATE PROC CAPNHAT_NHACC(
@MANCC NCHAR(10),
@TENNHACC NVARCHAR(50),
@DIACHI NVARCHAR(MAX),
@GHICHU NVARCHAR(MAX)
)
AS
BEGIN
	UPDATE NHACUNGCAP
	SET MANCC = @MANCC,TENNHACC = @TENNHACC,DIACHI = @DIACHI,GHICHU = @GHICHU
	WHERE MANCC = @MANCC
END
GO

CREATE PROC XOA_NHACC(
@MANCC nchar(10)
)
as
begin
	delete NHACUNGCAP
	where MANCC = @MANCC
end
go

-- Nhà CUng Cấp

-- Nhân Viên

CREATE PROC THEM_NHANVIEN(
@MANV NCHAR(10),
@TENNV NVARCHAR(50),
@EMAIL NCHAR(30),
@NS DATE,
@GT NVARCHAR(5),
@DIENTHOAI NCHAR(15),
@CHUCVU NVARCHAR(50),
@HINHANH NVARCHAR(MAX),
@DIACHI NVARCHAR(50),
@LUONG FLOAT,
@MABP NCHAR(10)
)
AS
BEGIN
	INSERT INTO NHANVIEN
	VALUES (@MANV, @TENNV, @EMAIL, @NS, @GT, @DIENTHOAI, @CHUCVU,@HINHANH, @DIACHI,@LUONG, @MABP)
END
GO

CREATE PROC CAPNHAT_NHANVIEN(
@MANV NCHAR(10),
@TENNV NVARCHAR(50),
@EMAIL NCHAR(30),
@NS DATE,
@GT NVARCHAR(5),
@DIENTHOAI NCHAR(15),
@CHUCVU NVARCHAR(50),
@HINHANH NVARCHAR(MAX),
@DIACHI NVARCHAR(50),
@LUONG FLOAT,
@MABP NCHAR(10)
)
AS
BEGIN
	UPDATE  NHANVIEN
	SET MANV = @MANV,TENNV = @TENNV,EMAIL = @EMAIL,NS = @NS,GT = @GT,DIENTHOAI = @DIENTHOAI,CHUCVU = @CHUCVU, HINHANH = @HINHANH,DIACHI = @DIACHI,LUONG =  @LUONG ,MABP = @MABP
	WHERE MANV = @MANV
END
GO

CREATE PROC CAPNHAT_NGUOIDUNG(
@MANV NCHAR(10),
@HINHANH NVARCHAR(MAX)
)
AS
BEGIN
	UPDATE  NHANVIEN
	SET HINHANH = @HINHANH
	WHERE MANV = @MANV
END
GO

CREATE PROC XOA_NHANVIEN(
@MANV NCHAR(10)
)
AS
BEGIN
	DELETE  NHANVIEN
	WHERE MANV = @MANV
END
GO
-- Nhân Viên 


-- Kho Hàng

CREATE PROC THEM_KHOHANG(
@MAKHO NCHAR(10),
@TENKHO NVARCHAR(50),
@TONGSODMSP INT,
@GHICHU NVARCHAR(MAX)
)
AS
BEGIN
	INSERT INTO KHOHANG
	VALUES (@MAKHO, @TENKHO, @TONGSODMSP, @GHICHU)
END
GO


CREATE PROC CAPNHAT_KHOHANG(
@MAKHO NCHAR(10),
@TENKHO NVARCHAR(50),
@TONGSODMSP INT,
@GHICHU NVARCHAR(MAX)
)
AS
BEGIN
	UPDATE KHOHANG
	SET MAKHO = @MAKHO,TENKHO = @TENKHO,TONGSODMSP = @TONGSODMSP,GHICHU = @GHICHU
	WHERE MAKHO = @MAKHO
END
GO
CREATE PROC XOA_KHOHANG(
@MAKHO nchar(10)
)
as
begin
	delete KHOHANG
	where MAKHO = @MAKHO
end
go


-- Kho Hàng

-- Danh Mục

CREATE PROC THEM_DANHMUC(
@MADANHMUC NCHAR(10),
@TENDANHMUC NVARCHAR(50),
@GHICHU NVARCHAR(MAX),
@MAKHO NCHAR(10)
)
AS
BEGIN
	INSERT INTO DANHMUC
	VALUES (@MADANHMUC, @TENDANHMUC, @GHICHU, @MAKHO)
END
GO

CREATE PROC CAPNHAT_DANHMUC(
@MADANHMUC NCHAR(10),
@TENDANHMUC NVARCHAR(50),
@GHICHU NVARCHAR(MAX),
@MAKHO NCHAR(10)
)
AS
BEGIN
	UPDATE DANHMUC
	SET MADANHMUC = @MADANHMUC,TENDANHMUC = @TENDANHMUC,GHICHU = @GHICHU,MAKHO = @MAKHO
END
GO

CREATE PROC XOA_DANHMUC(
@MADANHMUC nchar(10)
)
as
begin
	delete DANHMUC
	where MADANHMUC = @MADANHMUC
end
go
-- Danh Mục



-- NHẬP LIỆU SẢN PHẨM
CREATE PROC VIEW_NHAPSP
AS
	BEGIN
		SELECT N.MAPN, CTN.MASP, N.MAKHO, N.MANCC, N.NVNHAP, N.NGAYNHAP, CTN.SOLUONG,SP.GIA, CTN.TONGTIEN, N.GHICHU
		FROM PHIEUNHAPKHO N, CHITIETPHIEUNHAP CTN, SANPHAM SP
		WHERE N.MAPN = CTN.MAPN and CTN.MASP = SP.MASP
	END
GO

CREATE PROC THEM_NHAP
(
	@MAPN NCHAR(10),
	@MASP NCHAR(10),
	@MAKHO NCHAR(10),
	@MANCC NCHAR(10),
	@NVNHAP NCHAR(10),
	@NGAYNHAP DATE,
	@SOLUONG INT,
	@TONGTIEN FLOAT,
	@GHICHU NVARCHAR(MAX)
)
AS
	BEGIN
		INSERT INTO PHIEUNHAPKHO
		VALUES (@MAPN, @MAKHO, @MANCC, @NVNHAP, @NGAYNHAP, @GHICHU)
		INSERT INTO CHITIETPHIEUNHAP
		VALUES (@MAPN, @MASP, @SOLUONG, @TONGTIEN)
	END
GO

CREATE PROC CAPNHAT_NHAP
(
	@MAPN NCHAR(10),
	@MASP NCHAR(10),
	@MAKHO NCHAR(10),
	@MANCC NCHAR(10),
	@NVNHAP NCHAR(10),
	@NGAYNHAP DATE,
	@SOLUONG INT,
	@TONGTIEN FLOAT,
	@GHICHU NVARCHAR(MAX)
)
AS
	BEGIN
		UPDATE PHIEUNHAPKHO
		SET MAPN = @MAPN,MAKHO = @MAKHO,MANCC = @MANCC,NVNHAP = @NVNHAP,NGAYNHAP = @NGAYNHAP,GHICHU = @GHICHU
		WHERE MAPN =@MAPN
		UPDATE CHITIETPHIEUNHAP
		SET MASP = @MASP,SOLUONG = @SOLUONG,TONGTIEN = @TONGTIEN
		WHERE MAPN = @MAPN
	END
GO

CREATE PROC XOA_NHAP
(
	@MAPN NCHAR(10)
)
AS
	BEGIN
		DELETE PHIEUNHAPKHO
		WHERE MAPN =@MAPN
		DELETE CHITIETPHIEUNHAP
		WHERE MAPN = @MAPN
	END
GO

-- NHẬP LIỆU SẢN PHẨM

-- XUẤT SẢN PHẨM

CREATE PROC VIEW_XUATSP
AS
	BEGIN
		SELECT X.MAPX, CTX.MASP, X.MAKHO, X.MAKH, X.NVXUAT, X.NGAYXUAT, CTX.SOLUONG,SP.GIA ,CTX.TONGTIEN, X.GHICHU
		FROM PHIEUXUAT X, CHITIETPHIEUXUAT CTX, SANPHAM SP
		WHERE X.MAPX = CTX.MAPX and CTX.MASP = SP.MASP
	END
GO

CREATE PROC THEM_XUAT
(
	@MAPX NCHAR(10),
	@MASP NCHAR(10),
	@MAKHO NCHAR(10),
	@MAKH NCHAR(10),
	@NVXUAT NCHAR(10),
	@NGAYXUAT DATE,
	@SOLUONG INT,
	@TONGTIEN FLOAT,
	@GHICHU NVARCHAR(MAX)
)
AS
	BEGIN
		INSERT INTO PHIEUXUAT
		VALUES (@MAPX, @MAKHO, @MAKH, @NVXUAT, @NGAYXUAT, @GHICHU)
		INSERT INTO CHITIETPHIEUXUAT
		VALUES (@MAPX, @MASP, @SOLUONG, @TONGTIEN)
	END
GO

CREATE PROC CAPNHAT_XUAT
(
	@MAPX NCHAR(10),
	@MASP NCHAR(10),
	@MAKHO NCHAR(10),
	@MAKH NCHAR(10),
	@NVXUAT NCHAR(10),
	@NGAYXUAT DATE,
	@SOLUONG INT,
	@TONGTIEN FLOAT,
	@GHICHU NVARCHAR(MAX)
)
AS
	BEGIN
		UPDATE PHIEUXUAT
		SET MAPX = @MAPX,MAKHO = @MAKHO,MAKH = @MAKH, NVXUAT = @NVXUAT, NGAYXUAT = @NGAYXUAT,GHICHU = @GHICHU
		WHERE MAPX =@MAPX
		UPDATE CHITIETPHIEUXUAT
		SET MASP = @MASP,SOLUONG = @SOLUONG,TONGTIEN = @TONGTIEN
		WHERE MAPX =@MAPX
	END
GO

CREATE PROC XOA_XUAT
(
	@MAPX NCHAR(10)
)
AS
	BEGIN
		DELETE PHIEUXUAT
		WHERE MAPX =@MAPX
		DELETE CHITIETPHIEUXUAT
		WHERE MAPX =@MAPX
	END
GO

-- XUẤT SẢN PHẨM


-- Báo Cáo

CREATE PROC THEM_BAOCAOTHONGKE(
@MABC NCHAR(10),
@NGAYLAPBC DATE,
@NQL NCHAR(10),
@NGAYPHEDUYET DATE,
@MAKHO NCHAR(10),
@GHICHU NVARCHAR(MAX)
)
AS
BEGIN
	INSERT INTO BAOCAOTHONGKE
	VALUES (@MABC,@NGAYLAPBC, @NQL, @NGAYPHEDUYET, @MAKHO,@GHICHU)
END
GO

CREATE PROC XOA_BAOCAOTHONGKE(
@MABC nchar(10)
)
as
begin
	delete BAOCAOTHONGKE
	where MABC = @MABC
end
go

-- Báo Cáo

-- Chi Tiết Báo Cáo

CREATE PROC THEM_CHITIETBAOCAO(
@MABC NCHAR(10),
@MASP NCHAR(10),
@SOLUONGCU INT,
@SOLUONGMOI INT,
@TONKHO INT,
@GHICHU NVARCHAR(MAX)
)
AS
BEGIN
	INSERT INTO CHITIETBAOCAO
	VALUES (@MABC, @MASP, @SOLUONGCU, @SOLUONGMOI, @TONKHO, @GHICHU )
END
GO

-- CHi Tiết Báo cáo

-- Khách Hàng

CREATE PROC THEM_KHACHHANG(
@MAKH NCHAR(10),
@TENKH NVARCHAR(50),
@DIACHI NVARCHAR(50),
@GIOITINH NVARCHAR(5),
@DIENTHOAI NCHAR(15),
@EMAIL NVARCHAR(50),
@FAX NCHAR(15)
)
AS
BEGIN
	INSERT INTO KHACHHANG
	VALUES (@MAKH, @TENKH, @DIACHI, @GIOITINH, @DIENTHOAI, @EMAIL, @FAX)
END
GO

CREATE PROC XOA_KHACHHANG(
@MAKH nchar(10)
)
as
begin
	delete KHACHHANG
	where MAKH = @MAKH
end
go

-- Khách Hàng

-- Sản Phẩm

CREATE PROC THEM_SANPHAM(
@MASP NCHAR(10),
@TENSP NVARCHAR(50),
@MANCC NCHAR(10),
@GIA FLOAT,
@MADANHMUC NCHAR(10),
@SERIAL NCHAR(15),
@HINHANH IMAGE,
@GHICHU NVARCHAR(MAX),
@SOLUONG INT
)
AS
BEGIN
	INSERT INTO SANPHAM
	VALUES (@MASP, @TENSP, @MANCC, @GIA, @MADANHMUC, @SERIAL, @HINHANH, @GHICHU, @SOLUONG)
END
GO

CREATE PROC XOA_SANPHAM(
@MASP nchar(10)
)
as
begin
	delete SANPHAM
	where MASP = @MASP
end
go
-- Sản Phẩm

-- UPDATE VALUES
CREATE PROC UPDATE_GIASANPHAM(
@MASP nchar(10),
@GIA FLOAT
)
as
begin
	update SANPHAM
	set GIA = @GIA 
	where MASP = @MASP
end
go

-- SỬ DỤNG CÁCH TĂNG  MÃ TƯ ĐỌNG ĐỂ TRÁNH TRÙNG MÀ KHI NHẬP MỚI VÀ HẠN CHẾ VIỆC PHẢI KIỂM TRA TRÙNG MÃ
-- @lastid là mã cuối cùng (fixwidth)
-- @prefix là tiền tố mã: vd HS0001 => HS
-- @size là số lượng ký tự trong mã HS0001 => 6
CREATE FUNCTION FUN_TANGMA (@lastid varchar(10),@prefix varchar(10),@size int)
  returns varchar(10)
as
    BEGIN
        IF(@lastid = '')
            set @lastid = @prefix + REPLICATE (0,@size - LEN(@prefix))
        declare @num_nextid int, @nextid varchar(10)
        set @lastid = LTRIM(RTRIM(@lastid))
        set @num_nextid = replace(@lastid,@prefix,'') + 1
        set @size = @size - len(@prefix)
        set @nextid = @prefix + REPLICATE (0,@size - LEN(@prefix))
        set @nextid = @prefix + RIGHT(REPLICATE(0, @size) + CONVERT (VARCHAR(MAX), @num_nextid), @size)
        return @nextid
    END;
 GO

create trigger TRIG_TANGMANV on NHANVIEN
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MANV from NHANVIEN order by MANV desc)
        UPDATE NHANVIEN set MANV = dbo.FUN_TANGMA(@lastid,'NV',5) where MANV = ''
    end
GO

create trigger TRIG_TANGMAKH on KHACHHANG
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MAKH from KHACHHANG order by MAKH desc)
        UPDATE KHACHHANG set MAKH = dbo.FUN_TANGMA(@lastid,'NV',5) where MAKH = ''
    end
GO

create trigger TRIG_TANGMABP on BOPHAN
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MABP from BOPHAN order by MABP desc)
        UPDATE BOPHAN set MABP = dbo.FUN_TANGMA(@lastid,'BP',5) where MABP = ''
    end
GO

create trigger TRIG_TANGNCC on NHACUNGCAP
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MANCC from NHACUNGCAP order by MANCC desc)
        UPDATE NHACUNGCAP set MANCC = dbo.FUN_TANGMA(@lastid,'NCC',5) where MANCC = ''
    end
GO

create trigger TRIG_TANGKHO on KHOHANG
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MAKHO from KHOHANG order by MAKHO desc)
        UPDATE KHOHANG set MAKHO = dbo.FUN_TANGMA(@lastid,'KHO',5) where MAKHO = ''
    end
GO

create trigger TRIG_TANGSP on SANPHAM
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MASP from SANPHAM order by MASP desc)
        UPDATE SANPHAM set MASP = dbo.FUN_TANGMA(@lastid,'SP',5) where MASP = ''
    end
GO

create trigger TRIG_TANGDANHMUC on DANHMUC
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MADANHMUC from DANHMUC order by MADANHMUC desc)
        UPDATE DANHMUC set MADANHMUC = dbo.FUN_TANGMA(@lastid,'DM',5) where MADANHMUC = ''
    end
GO

create trigger TRIG_TANGPHIEUXUAT on PHIEUXUAT
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MAPX from PHIEUXUAT order by MAPX desc)
        UPDATE PHIEUXUAT set MAPX = dbo.FUN_TANGMA(@lastid,'PX',5) where MAPX = ''
    end
GO

create trigger TRIG_TANGCTPHIEUXUAT on CHITIETPHIEUXUAT
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MAPX from CHITIETPHIEUXUAT order by MAPX desc)
        UPDATE CHITIETPHIEUXUAT set MAPX = dbo.FUN_TANGMA(@lastid,'PX',5) where MAPX = ''
    end
GO

create trigger TRIG_TANGPHIEUNHAP on PHIEUNHAPKHO
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MAPN from PHIEUNHAPKHO order by MAPN desc)
        UPDATE PHIEUNHAPKHO set MAPN = dbo.FUN_TANGMA(@lastid,'PN',5) where MAPN = ''
    end
GO

create trigger TRIG_TANGCTPHIEUNHAP on CHITIETPHIEUNHAP
for insert
as
    begin
        DECLARE @lastid nvarchar(10)
        SET @lastid  = (SELECT TOP 1 MAPN from CHITIETPHIEUNHAP order by MAPN desc)
        UPDATE CHITIETPHIEUNHAP set MAPN = dbo.FUN_TANGMA(@lastid,'PN',5) where MAPN = ''
    end
GO

-- KHAI THÁC CÓ TỔNG HỢP DƯ LIỆU

Select  * 
from DANGNHAP 
Where USERNAME like  '%A%' OR PASSWORD like  '%A%'OR MANV like '%A%' OR QUYENHAN like '%A%'

-- SẮP XẾP NHÂN VIÊN THEO MỨC LƯƠNG VÀ NGÀY SINH THEO THỨ TỰ TĂNG DẦN
SELECT MANV, TENNV, NS, GT, DIACHI, CHUCVU, LUONG
FROM NHANVIEN
ORDER BY LUONG ASC
GO

SELECT MANV, TENNV, NS, GT, DIACHI, CHUCVU, LUONG
FROM NHANVIEN
ORDER BY NS ASC
GO


-- CHO BIẾT MÃ NHÂN VIÊN, TÊN NHÂN VIÊN, CHỨC VỤ, TÀI KHOẢN , MẬT KHÂU VÀ QUYỀN HẠN CỦA NHÂN VIÊN ĐÓ
SELECT NV.MANV, NV.TENNV, NV.CHUCVU, DN.USERNAME, DN.PASSWORD, DN.QUYENHAN
FROM NHANVIEN NV, DANGNHAP DN
WHERE DN.USERNAME = '1' AND DN.MANV = NV.MANV
GO

-- CHO BIẾT SẢN PHẨM THUỘC NHÀ CUNG CẤP A VÀ NẰM Ở KHO B
SELECT SP.MASP, SP.TENSP, SP.NGAYSANXUAT, SP.SOLUONG, SP.SERIAL, SP.HANSUDUNG
FROM SANPHAM SP, DANHMUC DM
WHERE SP.MANCC LIKE 'NCC1' AND SP.MADANHMUC = DM.MADANHMUC AND DM.MAKHO = 'K1'
GO

-- CHO BIẾT TÊN KHO MÃ KHO VÀ TỔNG SẢN PHẨM CÓ TRONG KHO CỦA SẢN PHẨM A
SELECT KHO.MAKHO, KHO.TENKHO,KHO.TONGSODMSP
FROM KHOHANG KHO, (SELECT DM.MAKHO FROM SANPHAM SP, DANHMUC DM WHERE SP.MASP = 'SP1' AND SP.MADANHMUC = DM.MADANHMUC ) DMSP 
WHERE KHO.MAKHO = DMSP.MAKHO
GO

-- CHO BIÊT CHI TIẾT PHIẾU XUẤT CỦA NHÂN VIÊN CÓ MÃ A XUẤT NGÀY B VÀ Ở PHÒNG BAN C
SELECT CTX.MAPX, CTX.MASP, CTX.SOLUONG, CTX.TONGTIEN
FROM CHITIETPHIEUXUAT CTX, ( SELECT PX.MAPX FROM NHANVIEN NV, PHIEUXUAT PX WHERE NV.MABP = 'BP1' AND NV.MANV = 'NV1' AND NV.MANV = PX.NVXUAT ) AS XNV
WHERE CTX.MAPX = XNV.MAPX
GO


