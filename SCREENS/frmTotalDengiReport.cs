﻿using SGMOSOL.ADMIN;
using SGMOSOL.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace SGMOSOL.SCREENS
{
    public partial class frmTotalDengiReport : Form
    {
        DengiReceiptDAL obj = new DengiReceiptDAL();
        CommonFunctions cm = new CommonFunctions();
        public frmTotalDengiReport()
        {
            InitializeComponent();
        }

        private void frmTotalDengiReport_Load(object sender, EventArgs e)
        {
            CenterToParent();
            txtCounter.Text = UserInfo.Counter_Name;
            txtUserName.Text = UserInfo.UserName;
            int centerX = (ClientSize.Width - pnlMaster.Width) / 2;
            int centerY = (ClientSize.Height - pnlMaster.Height) / 2;
            pnlMaster.Location = new System.Drawing.Point(centerX, centerY);
            dtfromDate.Format = DateTimePickerFormat.Custom;
            dtfromDate.CustomFormat = "dd/MM/yyyy";
            dtToDate.Format = DateTimePickerFormat.Custom;
            dtToDate.CustomFormat = "dd/MM/yyyy";
            getTotalAmountByPaymentId();
            this.reportViewer1.RefreshReport();
        }

        private void pnlMaster_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            getTotalAmountByPaymentId();
        }
        public void getTotalAmountByPaymentId()
        {
            DataTable dt = new DataTable();
            dt = obj.GETTOTALAMOUNTBYPAYMENTID(Convert.ToDateTime(dtfromDate.Text), Convert.ToDateTime(dtToDate.Text));
            ReportParameter[] parameters = new ReportParameter[5];
            parameters[0] = new ReportParameter("COUNTER", txtCounter.Text);
            parameters[1] = new ReportParameter("USERNAME", txtUserName.Text);
            parameters[2] = new ReportParameter("FROMDATE", dtfromDate.Text);
            parameters[3] = new ReportParameter("TODATE", dtToDate.Text);
            parameters[4] = new ReportParameter("DATE", System.DateTime.Today.ToString());
            reportViewer1.LocalReport.SetParameters(parameters);
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
           // printReport("TotalDengiCalculation");
        }
        public void printReport(string docName)
        {
            string printerName = System.Configuration.ConfigurationManager.AppSettings["DengiDec_Printer_name"].ToString();

            byte[] renderedBytes = reportViewer1.LocalReport.Render("Image");
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream(renderedBytes))
            {
                using (System.Drawing.Image image = System.Drawing.Image.FromStream(stream))
                {
                    try
                    {
                        PrintDocument printDoc = new PrintDocument();
                        printDoc.PrinterSettings.PrinterName = printerName;
                        printDoc.DocumentName = docName;
                        PaperSize paperSize = new PaperSize("A4", 827, 1169);
                        printDoc.DefaultPageSettings.PaperSize = paperSize;
                        printDoc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                        printDoc.PrintPage += (s, args) =>
                        {
                            args.Graphics.DrawImage(image, args.MarginBounds);
                        };
                        printDoc.Print();
                    }
                    catch (Exception ex)
                    {
                        cm.InsertErrorLog(ex.Message, UserInfo.module, UserInfo.version);
                    }
                }
            }

        }

        private void brnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}