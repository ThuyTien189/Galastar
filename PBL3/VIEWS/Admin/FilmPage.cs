using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;
using System.Threading;
using System.IO;

namespace PBL3.VIEWS.AdminForm
{
    public partial class FilmPage : Form
    {
        string fileName = "";

        public FilmPage()
        {
            InitializeComponent();
            dataGridView2.DataSource = Management_BookingTicket_BLL.Instance.GetAllFilm_View();
        }
        void LoadGenreIntoCheckBox(CheckedListBox checkList)
        {
            List<THELOAI> list = Management_BookingTicket_BLL.Instance.GetAllGenre();
            checkList.DataSource = list;
            checkList.DisplayMember = "TenTheLoai";
        }
        
        void LoadGenreForFilm(string MaPhim)
        //Use to binding the CheckedListBox Genre of Film
        {
            LoadGenreIntoCheckBox(listGenre);
            for (int i = 0; i < listGenre.Items.Count; i++)
            {
                listGenre.SetItemChecked(i, false);
                //Uncheck all CheckBox first
            }

            List<THELOAI> listGenreOfMovie = Management_BookingTicket_BLL.Instance.GetGenreByIdFilm(Management_BookingTicket_BLL.Instance.GetDetailGenreByIdFilm(MaPhim), MaPhim);
            for (int i = 0; i < listGenre.Items.Count; i++)
            {
                THELOAI genre = (THELOAI)listGenre.Items[i];
                foreach (THELOAI item in listGenreOfMovie)
                {
                    if (genre.MaTheLoai.Trim() == item.MaTheLoai.Trim())
                    {
                        listGenre.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }
        
        void CloseAddEditForm()
        {
            pnPhim.Visible = true;
            pnAddEdit.Visible = false;
        }
        
        //Add new film
        private void btAdd_Click(object sender, EventArgs e)
        {
            pnPhim.Visible = false;
            pnAddEdit.Visible = true;
            lbMaPhim.Visible = false;
            txtMaPhim.Visible = false;
            txtMaPhim.Text = "";
            txtTenPhim.Text = "";
            LoadGenreIntoCheckBox(listGenre);
            for (int i = 0; i < listGenre.Items.Count; i++)
            {
                listGenre.SetItemChecked(i, false);
                //Uncheck all CheckBox
            }
            txtThoiLuong.Text = "";
            txtDaoDien.Text = "";
            txtDienVien.Text = "";
            FilmIMG.Image = Image.FromFile(@"..\..\Resources\DefaultFilm.png");
            txtND.Text = "";
        }

        //Update film
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                pnPhim.Visible = false;
                pnAddEdit.Visible = true;
                lbMaPhim.Visible = true;
                txtMaPhim.Visible = true;
                txtMaPhim.Text = dataGridView2.SelectedRows[0].Cells["MaPhim"].Value.ToString();
                PHIM p = Management_BookingTicket_BLL.Instance.GetFilmById(txtMaPhim.Text);
                txtMaPhim.Enabled = false;
                txtTenPhim.Text = p.TenPhim;
                LoadGenreForFilm(Management_BookingTicket_BLL.Instance.GetIdFilmByNameFilm(p.TenPhim));
                txtThoiLuong.Text = p.ThoiLuong.ToString();
                txtDaoDien.Text = p.DaoDien;
                txtDienVien.Text = p.DienVien;
                //string s = dataGridView2.SelectedRows[0].Cells["DienVien"].Value.ToString();
                //txtDienVien.Lines = Split(s, "\n|[ ]{2,}");
                if (p.IMG != null && p.IMG != "")
                    FilmIMG.Image = Image.FromFile(@"..\..\Resources\" + p.IMG);
                else
                    FilmIMG.Image = Image.FromFile(@"..\..\Resources\DefaultFilm.png");
                fileName = p.IMG;
                txtND.Text = p.NDTomTat;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            CloseAddEditForm();
        }
        private new bool Validate()
        {
            bool check = true;

            if (txtTenPhim.Text == "" || txtThoiLuong.Text == "" || txtDaoDien.Text == "" || txtDienVien.Text == "" || txtND.Text == "" || listGenre.CheckedItems.Count == 0)
            {
                check = false;
            }

            if (check == false)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Warning!");
            }
            return check;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (Validate()) 
           { 
            PHIM p = new PHIM
            {
                MaPhim = txtMaPhim.Text,
                TenPhim = txtTenPhim.Text,
                ThoiLuong = TimeSpan.Parse(txtThoiLuong.Text),
                DaoDien = txtDaoDien.Text,
                DienVien = txtDienVien.Text,
                IMG = fileName,
                NDTomTat = txtND.Text
            };
            List<THELOAI> list = new List<THELOAI>();
            foreach (THELOAI i in listGenre.CheckedItems)
            {
                list.Add(i);
            }
            Management_BookingTicket_BLL.Instance.AddUpdate(p, list);
            CloseAddEditForm();
            dataGridView2.DataSource = Management_BookingTicket_BLL.Instance.GetAllFilm_View();
           }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                List<string> listdel = new List<string>();
                foreach (DataGridViewRow i in dataGridView2.SelectedRows)
                {
                    if (Management_BookingTicket_BLL.Instance.TotalSchedule_ByFilm(i.Cells["TenPhim"].Value.ToString()) == 0)
                    {
                        listdel.Add(i.Cells["MaPhim"].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá phim có mã " + i.Cells[0].Value.ToString());
                    }
                }
                Management_BookingTicket_BLL.Instance.DeleteFilm(listdel);
                dataGridView2.DataSource = Management_BookingTicket_BLL.Instance.GetAllFilm_View();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Management_BookingTicket_BLL.Instance.SearchFilm(txtSearch.Text);
        }

        //Open IMG dialog, copy select img to resource folder
        private void ShowIMGDialog()
        {
            openFileDialog1.Title = "Select Picture";
            openFileDialog1.Filter = "JPEG Image|*.jpg|Windows Bitmap|*.bmp|All Files|*.*";
            Thread t = new Thread((ThreadStart)(() =>
            {
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string sourceFile = openFileDialog1.FileName;
                    fileName = Path.GetFileName(sourceFile);
                    string destFile = Path.Combine(@"..\..\Resources", fileName);
                    if (!new FileInfo(destFile).Exists) 
                        File.Copy(sourceFile, destFile);

                    Image img = Image.FromFile(sourceFile);
                    FilmIMG.Image = img;
                }
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }

        //Add img
        private void btAddPic_Click(object sender, EventArgs e)
        {
            ShowIMGDialog();
        }
    }
}
