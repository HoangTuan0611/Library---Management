set dateformat dmy
go
create database QLTV
go
use QLTV
go
create table DangNhap(
USERNAME varchar(20) primary key,
PASS varchar(20)
)
go
create table DocGia(
iddocgia varchar(10) primary key,
hoten nvarchar(50),
loaidocgia char(5),
ngaysinh smalldatetime,
diachi nvarchar(50),
email varchar(50),
ngaylapthe smalldatetime,
)
go

create table Sach(
masach varchar(10) primary key,
tensach nvarchar(50),
theloai char(5),
tacgia nvarchar(50),
namsx smalldatetime,
nhaxuatban nvarchar(50),
ngaynhap smalldatetime,
trigia money
)
go
create table DanhSachSach(
stt int,
masach varchar(10) primary key,
tensach nvarchar(50),
theloai char(5),
tacgia nvarchar(50),
tinhtrang nvarchar(30)
)
go
alter table DanhSachSach add constraint Fk_DanhSachSach FOREIGN KEY(masach) REFERENCES Sach(masach)
go
create table PhieuMuonSach(
idmuonsach varchar(10),
masach varchar(10),
iddocgia varchar(10),
stt int,
tensach nvarchar(50),
theloai char(5),
tacgia nvarchar(50),
hoten nvarchar(50),
ngaymuon smalldatetime,
constraint PK_PhieuMuonSach primary key(masach,iddocgia)
)
go
alter table PhieuMuonSach add constraint FK1_PHIEUMUONSACH FOREIGN KEY(masach) REFERENCES Sach(masach)
go
alter table PhieuMuonSach add constraint FK2_PHIEUMUONSACH FOREIGN KEY(iddocgia) REFERENCES DocGia(iddocgia)
go

create table BaoCaoI(
thang smalldatetime,
stt int,
masach varchar(10),
theloai char(5),
soluotmuon int,
tile int,
tongsoluotmuon int,
constraint PK_BAOCAOI primary key(masach)
)
go
alter table BaoCaoI add constraint FK1_BAOCAOI FOREIGN KEY(masach) REFERENCES Sach(masach)
go

create table BaoCaoII(
ngay smalldatetime,
stt int,
masach varchar(10),
tensach nvarchar(50),
ngaymuon smalldatetime,
songaytratre int,
constraint PK_BAOCAOII primary key(masach)
)
go
alter table BaoCaoII add constraint FK1_BAOCAOII foreign key (masach) references Sach(masach)
go

create proc DangNhap_Login
@username nchar(20),
@password nchar(20)
as
SELECT *
  FROM DangNhap
	where @username = USERNAME
			and @password = PASS