using System;
using System.Collections.Generic;
using NhaKhoa.DAL;

namespace NhaKhoa.BUS
{
    public class ChuanDoanBUS
    {
        private readonly ChuanDoanDAL _dal;

        public ChuanDoanBUS()
        {
            _dal = new ChuanDoanDAL();
        }

        public List<Models.ChuanDoan> LayDanhSach()
        {
            return _dal.GetAll();
        }

        public List<Models.ChuanDoan> LayChuanDoanTheoMaBN(string maBN)
        {
            if (string.IsNullOrWhiteSpace(maBN))
                throw new ArgumentException("Mã bệnh nhân không được để trống");

            return _dal.GetByMaBN(maBN);
        }

        public Models.ChuanDoan LayChuanDoanTheoMa(string maCD)
        {
            if (string.IsNullOrWhiteSpace(maCD))
                throw new ArgumentException("Mã chẩn đoán không được để trống");

            return _dal.GetById(maCD);
        }

        public void ThemChuanDoan(Models.ChuanDoan cd)
        {
            if (string.IsNullOrWhiteSpace(cd.NoiDung))
                throw new ArgumentException("Nội dung chẩn đoán không được để trống");

            if (string.IsNullOrWhiteSpace(cd.MaBN))
                throw new ArgumentException("Mã bệnh nhân không được để trống");

            if (string.IsNullOrWhiteSpace(cd.MaNV))
                throw new ArgumentException("Mã nhân viên không được để trống");

            if (string.IsNullOrWhiteSpace(cd.MaCD))
                cd.MaCD = _dal.GetNewMaCD();

            if (cd.NgayChuanDoan == default(DateTime))
                cd.NgayChuanDoan = DateTime.Now;

            _dal.Insert(cd);
        }

        public void CapNhatChuanDoan(Models.ChuanDoan cd)
        {
            if (string.IsNullOrWhiteSpace(cd.MaCD))
                throw new ArgumentException("Mã chẩn đoán không được để trống");

            if (string.IsNullOrWhiteSpace(cd.NoiDung))
                throw new ArgumentException("Nội dung chẩn đoán không được để trống");

            var existing = _dal.GetById(cd.MaCD);
            if (existing == null)
                throw new ArgumentException($"Không tìm thấy chẩn đoán với mã {cd.MaCD}");

            _dal.Update(cd);
        }

        public void XoaChuanDoan(string maCD)
        {
            if (string.IsNullOrWhiteSpace(maCD))
                throw new ArgumentException("Mã chẩn đoán không hợp lệ");

            _dal.Delete(maCD);
        }
    }
}
