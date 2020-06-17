using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlirapphim
{
    public partial class timkiemlich : Form
    {
        public timkiemlich()
        {
            InitializeComponent();
        }

        private void timkiemlich_Load(object sender, EventArgs e)
        {
            Load_comboBox();
            LoadDataToGrivew();
            ResetValues();
        }
        private void ResetValues()
        {
            cboRap.Text = "";
            cboPhim.Text = "";
           
        }

        private void Load_comboBox()
        {
            DAO.OpenConnection();
            //Load cboMaRap tìm kiếm
            cboRap.DataSource = Quanlirapphim.DAO.GetDataToTable("SELECT MaRap, TenRap FROM tblRap");
            cboRap.ValueMember = "MaRap";
            cboRap.DisplayMember = "MaRap";
            cboRap.SelectedIndex = -1;

            //Load cboMaPhim tìm kiếm
            cboPhim.DataSource = Quanlirapphim.DAO.GetDataToTable("SELECT MaPhim, TenPhim FROM tblPhim");
            cboPhim.ValueMember = "MaPhim";
            cboPhim.DisplayMember = "MaPhim";
            cboPhim.SelectedIndex = -1;

          
        }



        private void LoadDataToGrivew()
        {
            //mở kết nối
            try
            {
                DAO.OpenConnection();
                string sql = "select * from tblLichChieu";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable tblLichChieu = new DataTable();
                myAdapter.Fill(tblLichChieu);
                dataGridView_TimKiemLich.DataSource = tblLichChieu;
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
           

            if (cboRap.Text == "")
            {
                MessageBox.Show("Chưa chọn mã rạp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboPhim.Text == "")
            {
                MessageBox.Show("Chưa chọn mã phim!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable tbl;
            string sql = "SELECT * FROM tblLichChieu WHERE (MaRap =N'"
            + cboRap.SelectedValue + "' AND MaPhim= N'" + cboPhim.SelectedValue + "')";
            tbl = DAO.GetDataToTable(sql);
              
            //Load dgv
            dataGridView_TimKiemLich.DataSource = tbl;

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridView_TimKiemLich.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridView_TimKiemLich.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
    }
}
    
