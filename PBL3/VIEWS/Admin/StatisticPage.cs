using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL3.VIEWS.Admin
{
    public partial class StatisticPage : Form
    {
        public StatisticPage()
        {
            InitializeComponent();
            cbbPhim.Items.AddRange(Management_BookingTicket_BLL.Instance.GetCBB().Distinct().ToArray());
            LoadDateTimePickerRevenue();
        }
        void LoadDateTimePickerRevenue()
        {
            dtpFromDay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDay.Value = dtpFromDay.Value.AddMonths(1).AddDays(-1);
        }
        
        private void butStatistical_Click(object sender, EventArgs e)
        {
            if (cbbPhim.Text =="")
            {
                MessageBox.Show("Mời bạn chọn phim!");
            }
            else if (dtpFromDay.Value > dtpToDay.Value)
            {
                MessageBox.Show("Thời gian bạn chọn không hợp lệ!");
            }
            else if (cbbPhim.Text == "All")
            {
                dgv_thongke.DataSource = Management_BookingTicket_BLL.Instance.GetAllStatistical_Film_View_ByTime(cbbPhim.Text, dtpFromDay.Value, dtpToDay.Value);
                txtTongDT.Text = Management_BookingTicket_BLL.Instance.TotalRevenueFilm_ByTime(cbbPhim.Text, dtpFromDay.Value, dtpToDay.Value).ToString();
                Chart_Statistical.DataSource = Management_BookingTicket_BLL.Instance.Get_Data_Chart_Film_View_ByTime(cbbPhim.Text, dtpFromDay.Value, dtpToDay.Value).ToList();
                Chart_Statistical.Series["Doanh Thu"].XValueMember = "TenPhim";
                Chart_Statistical.Series["Doanh Thu"].XValueType = ChartValueType.String;
                Chart_Statistical.Series["Doanh Thu"].YValueMembers = "DoanhThu";
                Chart_Statistical.Series["Doanh Thu"].YValueType = ChartValueType.Int32;
            }
            else
            {
                dgv_thongke.DataSource = Management_BookingTicket_BLL.Instance.GetAllStatistical_Schedule_Film_View_ByTime(cbbPhim.Text, dtpFromDay.Value, dtpToDay.Value);
                txtTongDT.Text = Management_BookingTicket_BLL.Instance.TotalRevenue_Schedule_Film_ByTime(cbbPhim.Text, dtpFromDay.Value, dtpToDay.Value).ToString();
                Chart_Statistical.DataSource = Management_BookingTicket_BLL.Instance.Get_Data_Chart_Schedule_Film_View_ByTime(cbbPhim.Text, dtpFromDay.Value, dtpToDay.Value).ToList();
                Chart_Statistical.Series["Doanh Thu"].XValueMember = " MaSuatChieu";
                Chart_Statistical.Series["Doanh Thu"].XValueType = ChartValueType.String;
                Chart_Statistical.Series["Doanh Thu"].YValueMembers = "DoanhThu";
                Chart_Statistical.Series["Doanh Thu"].YValueType = ChartValueType.Int32;
            }
        }

       
    }
}
