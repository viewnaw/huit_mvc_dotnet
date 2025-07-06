
-- ========================================
-- TẠO CÁC BẢNG CHÍNH
-- ========================================

CREATE TABLE tblLoaiSach (
    MaLoai INT PRIMARY KEY,
    TenLoai NVARCHAR(100),
    GhiChu NVARCHAR(255)
);

CREATE TABLE tblSach (
    MaSach INT PRIMARY KEY,
    TenSach NVARCHAR(200),
    NamXB INT,
    SoTrang INT,
    GiaBan DECIMAL(18,2),
    NoiDung NVARCHAR(MAX),
    LoaiSach INT FOREIGN KEY REFERENCES tblLoaiSach(MaLoai)
);

CREATE TABLE tblHinhAnh (
    ID INT PRIMARY KEY,
    MaSach INT FOREIGN KEY REFERENCES tblSach(MaSach),
    HinhAnh NVARCHAR(255)
);

CREATE TABLE tblKhachHang (
    MaKH INT PRIMARY KEY,
    TenKH NVARCHAR(100),
    MatKhau NVARCHAR(100),
    GioiTinh NVARCHAR(10),
    NamSinh INT,
    Avarta NVARCHAR(255),
    DienThoai NVARCHAR(20),
    Email NVARCHAR(100),
    DiaChi NVARCHAR(255)
);

CREATE TABLE tblVaiTro (
    IDVaiTro INT PRIMARY KEY,
    TenVaiTro NVARCHAR(50),
    MoTa NVARCHAR(255)
);

CREATE TABLE tblNhanVien (
    MaNV INT PRIMARY KEY,
    MatKhau NVARCHAR(100),
    TenNV NVARCHAR(100),
    GioiTinh NVARCHAR(10),
    NamSinh INT,
    VaiTro INT FOREIGN KEY REFERENCES tblVaiTro(IDVaiTro)
);

CREATE TABLE tblTinhTrang (
    ID INT PRIMARY KEY,
    TinhTrangHoaDon NVARCHAR(50)
);

CREATE TABLE tblHoaDon (
    MaHD INT PRIMARY KEY,
    MaKH INT FOREIGN KEY REFERENCES tblKhachHang(MaKH),
    MaNV INT FOREIGN KEY REFERENCES tblNhanVien(MaNV),
    NgayLap DATETIME,
    TongTien DECIMAL(18,2),
    TinhTrang INT FOREIGN KEY REFERENCES tblTinhTrang(ID),
    DiaChiGiaoHang NVARCHAR(255),
    DaThanhToan BIT
);

CREATE TABLE tblChiTietHoaDon (
    MaHD INT FOREIGN KEY REFERENCES tblHoaDon(MaHD),
    MaSach INT FOREIGN KEY REFERENCES tblSach(MaSach),
    SoLuong INT,
    GiaBan DECIMAL(18,2),
    PRIMARY KEY (MaHD, MaSach)
);

-- ========================================
-- DỮ LIỆU MẪU
-- ========================================

INSERT INTO tblLoaiSach VALUES (1, N'Tiểu thuyết', N'Văn học hư cấu');
INSERT INTO tblLoaiSach VALUES (2, N'Giáo trình', N'Sách học tập');

INSERT INTO tblSach VALUES (101, N'Đắc Nhân Tâm', 2010, 300, 75000, N'Sách phát triển bản thân', 1);
INSERT INTO tblSach VALUES (102, N'Toán cao cấp A1', 2018, 500, 95000, N'Sách đại học kinh tế', 2);

INSERT INTO tblHinhAnh VALUES (1, 101, N'dacnhantam.jpg');
INSERT INTO tblHinhAnh VALUES (2, 102, N'toancaocap.jpg');

INSERT INTO tblKhachHang VALUES (1, N'Nguyễn Văn A', N'123456', N'Nam', 1995, N'avt1.jpg', '0909123456', 'a@gmail.com', N'HCM');
INSERT INTO tblKhachHang VALUES (2, N'Lê Thị B', N'abcdef', N'Nữ', 1998, N'avt2.jpg', '0911222333', 'b@gmail.com', N'HN');

INSERT INTO tblVaiTro VALUES (1, N'Admin', N'Quản lý hệ thống');
INSERT INTO tblVaiTro VALUES (2, N'Nhân viên', N'Quản lý bán hàng');

INSERT INTO tblNhanVien VALUES (1, N'admin123', N'Phạm Văn C', N'Nam', 1990, 1);
INSERT INTO tblNhanVien VALUES (2, N'nv123', N'Trần Thị D', N'Nữ', 1992, 2);

INSERT INTO tblTinhTrang VALUES (1, N'Chưa thanh toán');
INSERT INTO tblTinhTrang VALUES (2, N'Đã thanh toán');

INSERT INTO tblHoaDon VALUES (1001, 1, 1, '2024-07-01', 150000, 1, N'HCM - Q1', 0);
INSERT INTO tblHoaDon VALUES (1002, 2, 2, '2024-07-02', 95000, 2, N'HN - Cầu Giấy', 1);

INSERT INTO tblChiTietHoaDon VALUES (1001, 101, 2, 75000);
INSERT INTO tblChiTietHoaDon VALUES (1002, 102, 1, 95000);
