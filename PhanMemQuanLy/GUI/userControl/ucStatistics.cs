using Microsoft.Reporting.WinForms;
using PhanMemQuanLy.DAO;
using PhanMemQuanLy.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLy.GUI.userControl
{
    public partial class ucStatistics : UserControl
    {
        private DAO_Revenue dao_r = new DAO_Revenue();
        private DataTable table = new DataTable();
        public ucStatistics()
        {
            InitializeComponent();

            table.Columns.Add("time", typeof(string));
            table.Columns.Add("value", typeof(decimal));
            cbFilter.SelectedIndex = 0;
        }

        public void loadReport(string title)
        {
            rpvStatistics.LocalReport.ReportPath = @"..\..\GUI\report\Revenue.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "RevenueDataSet";
            rds.Value = table;
            ReportParameter rptTitle = new ReportParameter("title", title);
            rpvStatistics.LocalReport.SetParameters(new ReportParameter[] { rptTitle });
            rpvStatistics.LocalReport.DataSources.Clear();
            rpvStatistics.LocalReport.DataSources.Add(rds);
            rpvStatistics.RefreshReport();
        }

        public void daysOfWeek(string title)
        {
            List<Revenue> revenues = dao_r.getRevenueDaysOfWeek(DateTime.Now);
            Revenue revenue = revenues.Find(item => item.time == 1);
            revenues.Remove(revenue);
            revenues.Add(revenue);
            revenues.ForEach(item =>
            {
                if (item.time != 1)
                {
                    table.Rows.Add("Thứ " + item.time, item.value);
                }
                else
                {
                    table.Rows.Add("Chủ Nhật", item.value);
                }
            });
            loadReport(title);
        }

        public void filter(int type)
        {
            switch (type)
            {
                case 0:

                    break;
            }

        }
    }
}
