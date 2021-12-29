using Microsoft.Reporting.WinForms;
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

namespace PhanMemQuanLy.GUI
{
    public partial class F_Report : Form
    {
        public F_Report(string title, DataTable table)
        {
            InitializeComponent();
            rpv.LocalReport.ReportPath = @"..\..\GUI\report\Revenue.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "RevenueDataSet";
            rds.Value = table;
            ReportParameter rptTitle = new ReportParameter("title", title);
            rpv.LocalReport.SetParameters(new ReportParameter[] { rptTitle });
            rpv.LocalReport.DataSources.Clear();
            rpv.LocalReport.DataSources.Add(rds);
            rpv.RefreshReport();
        }
        public F_Report(Invoice invoice, DataTable table)
        {
            InitializeComponent();
            rpv.LocalReport.ReportPath = @"..\..\GUI\report\Invoice.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "InvoiceDataSet";
            rds.Value = table;
            ReportParameter rptInvoiceID = new ReportParameter("id", invoice.id);
            ReportParameter rptInvoiceDate = new ReportParameter("date", invoice.date.ToString("dd/MM/yyyy"));
            ReportParameter rptInvoiceCustomerName = new ReportParameter("customerName", invoice.customer.name);
            ReportParameter rptInvoiceCustomerAddress = new ReportParameter("customerAddress", invoice.customer.address);
            ReportParameter rptInvoiceCustomerPhone = new ReportParameter("customerPhone", invoice.customer.phone);
            ReportParameter rptInvoiceEmployeeName = new ReportParameter("employeeName", invoice.employee.name);
            rpv.LocalReport.SetParameters(new ReportParameter[] { rptInvoiceID, rptInvoiceDate, rptInvoiceCustomerName, rptInvoiceCustomerAddress, rptInvoiceCustomerPhone, rptInvoiceEmployeeName });
            rpv.LocalReport.DataSources.Clear();
            rpv.LocalReport.DataSources.Add(rds);
            rpv.RefreshReport();
        }

        private void F_Report_Load(object sender, EventArgs e)
        {
        }
    }
}
