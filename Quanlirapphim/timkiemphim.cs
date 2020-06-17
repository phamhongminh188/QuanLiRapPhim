using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quanlirapphim;

namespace Quanlirapphim
{
    public partial class timkiemphim : Form
    {
        public timkiemphim()
        {
            InitializeComponent();
        }
        private void timkiemphim_Load(object sender, EventArgs e)
        {
            Load_comboBox();
            LoadDataToGrivew();
            ResetValues();
        }
        private void ResetValues()
        {
            cboTenPhim.Text = "";
            cboLoai.Text = "";
            cboHang.Text = "";
        }

        private void Load_comboBox()
        {
            DAO.OpenConnection();
            //Load cboMaPhim tìm kiếm
            cboTenPhim.DataSource = Quanlirapphim.DAO.GetDataToTable("SELECT * FROM tblPhim");
            cboTenPhim.ValueMember = "MaPhim";
            cboTenPhim.DisplayMember = "TenPhim";
            cboTenPhim.SelectedIndex = -1;

            //Load cboMaTheLoai tìm kiếm
            cboLoai.DataSource = Quanlirapphim.DAO.GetDataToTable("SELECT MaTheLoai, TenTheLoai FROM tblTheLoai");
            cboLoai.ValueMember = "MaTheLoai";
            cboLoai.DisplayMember = "TenTheLoai";
            cboLoai.SelectedIndex = -1;

            //Load cboMaHangSX tìm kiếm
            cboHang.DataSource = Quanlirapphim.DAO.GetDataToTable("SELECT MaHangSX, TenHangSX FROM tblHangSX");
            cboHang.ValueMember = "MaHangSX";
            cboHang.DisplayMember = "TenHangSX";
            cboHang.SelectedIndex = -1;
        }



        private void LoadDataToGrivew()
        {
            //mở kết nối
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblPhim";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblPhim = new DataTable();
                myAdapter.Fill(tblPhim);
                dataGridView_TimKiemPhim.DataSource = tblPhim;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
        }

                private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboTenPhim.Text == "")
            {
                MessageBox.Show("Chưa chọn tên phim!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (cboLoai.Text == "")
            {
                MessageBox.Show("Chưa chọn mã loại phim!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboHang.Text == "")
            {
                MessageBox.Show("Chưa chọn mã hãng phim!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable tbl;
            string sql = "SELECT * FROM tblPhim WHERE (MaPhim =N'"+ cboTenPhim.SelectedValue + "' AND MaTheLoai= N'" + cboLoai.SelectedValue + "' AND MaHangSX = N'" + cboHang.SelectedValue + "')";
            tbl = DAO.GetDataToTable(sql);

            //Load dgv
            dataGridView_TimKiemPhim.DataSource = tbl;

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridView_TimKiemPhim.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridView_TimKiemPhim.EditMode = DataGridViewEditMode.EditProgrammatically;
            


        }

      
     

      
    }
}
