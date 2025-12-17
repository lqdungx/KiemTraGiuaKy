using System;
using System.Linq;
using System.Windows.Forms;
using KiemTraGiuaKy.Models;

namespace KiemTraGiuaKy
{
    public partial class Form1 : Form
    {
        DiaPhuongModel db = new DiaPhuongModel();
        bool sortDesc = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTinhHinhDP.AutoGenerateColumns = false;
            LoadTrangThai();
            LoadDataGrid();
            ResetForm();
        }

        void LoadDataGrid()
        {
            dgvTinhHinhDP.DataSource = db.DiaPhuongs
                .Select(dp => new
                {
                    MaDP = dp.MaDP,
                    TenDP = dp.TenDP,
                    SoCaNhiemMoi = dp.SoCaNhiemMoi,
                    TenTT = dp.TrangThai.TenTT,
                    MaTT = dp.MaTT
                }).ToList();
        }

        void LoadTrangThai()
        {
            cbbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;

            var dsTrangThai = db.TrangThais.ToList();

            cbbTrangThai.DataSource = dsTrangThai;
            cbbTrangThai.DisplayMember = "TenTT"; 
            cbbTrangThai.ValueMember = "MaTT";     

            if (dsTrangThai.Count > 0)
                cbbTrangThai.SelectedIndex = 0;
        }

        void ResetForm()
        {
            txtMaDP.Clear();
            txtTenDP.Clear();
            txtSoCaNhiemMoi.Clear();
            cbbTrangThai.SelectedIndex = 0;
        }

        private void dgvTinhHinhDP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaDP.Text = dgvTinhHinhDP.Rows[e.RowIndex].Cells["colMaDP"].Value.ToString();
            txtTenDP.Text = dgvTinhHinhDP.Rows[e.RowIndex].Cells["colTenDP"].Value.ToString();
            txtSoCaNhiemMoi.Text = dgvTinhHinhDP.Rows[e.RowIndex].Cells["colCaNhiem"].Value.ToString();
            cbbTrangThai.SelectedValue = dgvTinhHinhDP.Rows[e.RowIndex].Cells["colTenTT"].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDP.Text == "" || txtTenDP.Text == "" || txtSoCaNhiemMoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (txtMaDP.Text.Length != 3 || int.Parse(txtSoCaNhiemMoi.Text) < 0)
            {
                MessageBox.Show("Mã ĐP phải 3 ký tự và số ca nhiễm ≥ 0!");
                return;
            }

            if (db.DiaPhuongs.Any(x => x.MaDP == txtMaDP.Text))
            {
                MessageBox.Show("Mã địa phương đã tồn tại!");
                return;
            }

            DiaPhuong dp = new DiaPhuong
            {
                MaDP = txtMaDP.Text,
                TenDP = txtTenDP.Text,
                SoCaNhiemMoi = int.Parse(txtSoCaNhiemMoi.Text),
                MaTT = (int)cbbTrangThai.SelectedValue
            };

            db.DiaPhuongs.Add(dp);
            db.SaveChanges();

            MessageBox.Show("Thêm mới thành công!");
            LoadDataGrid();
            ResetForm();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DiaPhuong dp = db.DiaPhuongs.FirstOrDefault(x => x.MaDP == txtMaDP.Text);

            if (dp == null)
            {
                MessageBox.Show("Không tìm thấy thông tin địa phương");
                return;
            }

            string trangThaiCu = dp.TrangThai.TenTT;
            string trangThaiMoi = cbbTrangThai.Text;

            if (trangThaiCu != trangThaiMoi)
            {
                if (MessageBox.Show(
                    $"Địa phương có sự thay đổi từ {trangThaiCu} -> {trangThaiMoi}?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            dp.TenDP = txtTenDP.Text;
            dp.SoCaNhiemMoi = int.Parse(txtSoCaNhiemMoi.Text);
            dp.MaTT = (int)cbbTrangThai.SelectedValue;

            db.SaveChanges();

            MessageBox.Show("Cập nhật thành công!");
            LoadDataGrid();
            ResetForm();
        }

        private void sắpXếpTheoSốCaNhiễmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = sortDesc
                ? db.DiaPhuongs.OrderByDescending(x => x.SoCaNhiemMoi)
                : db.DiaPhuongs.OrderBy(x => x.SoCaNhiemMoi);

            dgvTinhHinhDP.DataSource = data
                .Select(dp => new
                {
                    dp.MaDP,
                    dp.TenDP,
                    dp.SoCaNhiemMoi,
                    TenTT = dp.TrangThai.TenTT,
                    dp.MaTT
                }).ToList();

            sortDesc = !sortDesc;
        }

        private void cácĐịaPhươngNhómNguyCơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvTinhHinhDP.DataSource = db.DiaPhuongs
                .Where(x => x.TrangThai.TenTT != "Bình thường")
                .Select(dp => new
                {
                    dp.MaDP,
                    dp.TenDP,
                    dp.SoCaNhiemMoi,
                    TenTT = dp.TrangThai.TenTT,
                    dp.MaTT
                }).ToList();
        }
    }
}
