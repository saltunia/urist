using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;

namespace Urist
{
    public partial class otchet : DevExpress.XtraEditors.XtraForm
    {
        public otchet()
        {
            InitializeComponent();
        }

        private void otchet_Load(object sender, EventArgs e)
        { 
            comboBoxEdit1.SelectedIndex =0;
            gridControl2.Visible = true;
            gridControl1.Visible = false; 
            this.sprSlujbaTableAdapter.FillByReport(this.uristDataSet1.sprSlujba);
            // TODO: This line of code loads data into the 'uristDataSet1.users_programm' table. You can move, or remove it, as needed.
            this.users_programmTableAdapter.FillByUrist(this.uristDataSet1.users_programm);
           
            // TODO: This line of code loads data into the 'uristDataSet1.sprSlujba' table. You can move, or remove it, as needed.



          
        }

        private void comboBoxEdit1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedText == "Сводный по подразделениям")
            {
                gridControl1.Visible = true;
                gridControl2.Visible = false;
            }
            else
            {
                gridControl2.Visible = true;
                gridControl1.Visible = false;
            }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.sdate1 = Convert.ToDateTime(dateEdit1.Text);
            Globals.podate1 = Convert.ToDateTime(dateEdit2.Text);
            if (Globals.sdate1 < Globals.podate1)
            {
                var rowHandle = gridView2.FocusedRowHandle;

                for (int i = 0; i <= gridView2.RowCount; i++)
                {
                    var check = gridView2.GetRowCellValue(i, "vrem_check");
                    if (Convert.ToString(check) != "")
                    {
                        if (Convert.ToBoolean(check) == true)
                        {
                            Globals.fio_otchet = (string)(gridView2.GetRowCellValue(i, "fio"));
                            this.users_programmTableAdapter.FillByFio(uristDataSet1.users_programm, Globals.fio_otchet);
                            int rowcount = usersprogrammBindingSource.Count;
                            if (rowcount == 1)
                            {

                                Globals.id_user1 = (int)((DataRowView)(usersprogrammBindingSource.Current)).Row["user_id"];
                                Globals.id_user2 = 0;
                                Globals.id_user3 = 0;
                                Globals.id_user4 = 0;
                                Globals.id_user5 = 0;
                                svod_po_uristam report = new svod_po_uristam();
                                svod_po_uristam1 report1 = new svod_po_uristam1();
                                byt_vzyskanie report2 = new byt_vzyskanie();
                                prom_vzyskanie report3 = new prom_vzyskanie();
                                Iski report4 = new Iski();
                                Jaloby report5 = new Jaloby();
                                sogl report6 = new sogl();
                                sogl1 report7 = new sogl1();
                                report.Parameters["parameter3"].Value = Globals.id_user1;
                                report.Parameters["parameter4"].Value = Globals.id_user2;
                                report.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report.Parameters["parameter1"].Value = Globals.sdate1;
                                report.Parameters["parameter2"].Value = Globals.podate1; 
                                report.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report1.Parameters["parameter3"].Value = Globals.id_user1;
                                report1.Parameters["parameter4"].Value = Globals.id_user2;
                                report1.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report1.Parameters["parameter1"].Value = Globals.sdate1;
                                report1.Parameters["parameter2"].Value = Globals.podate1; 
                                report1.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report2.Parameters["parameter3"].Value = Globals.id_user1;
                                report2.Parameters["parameter4"].Value = Globals.id_user2;
                                report2.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report2.Parameters["parameter1"].Value = Globals.sdate1;
                                report2.Parameters["parameter2"].Value = Globals.podate1; 
                                report2.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report3.Parameters["parameter3"].Value = Globals.id_user1;
                                report3.Parameters["parameter4"].Value = Globals.id_user2;
                                report3.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report3.Parameters["parameter1"].Value = Globals.sdate1;
                                report3.Parameters["parameter2"].Value = Globals.podate1; 
                                report3.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report4.Parameters["parameter3"].Value = Globals.id_user1;
                                report4.Parameters["parameter4"].Value = Globals.id_user2;
                                report4.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report4.Parameters["parameter1"].Value = Globals.sdate1;
                                report4.Parameters["parameter2"].Value = Globals.podate1; 
                                report4.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report5.Parameters["parameter3"].Value = Globals.id_user1;
                                report5.Parameters["parameter4"].Value = Globals.id_user2;
                                report5.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report5.Parameters["parameter1"].Value = Globals.sdate1;
                                report5.Parameters["parameter2"].Value = Globals.podate1; 
                                report5.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report6.Parameters["parameter3"].Value = Globals.id_user1;
                                report6.Parameters["parameter4"].Value = Globals.id_user2;
                                report6.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report6.Parameters["parameter1"].Value = Globals.sdate1;
                                report6.Parameters["parameter2"].Value = Globals.podate1; 
                                report6.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report7.Parameters["parameter3"].Value = Globals.id_user1;
                                report7.Parameters["parameter4"].Value = Globals.id_user2;
                                report7.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report7.Parameters["parameter1"].Value = Globals.sdate1;
                                report7.Parameters["parameter2"].Value = Globals.podate1; 
                                report7.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report.RequestParameters = false;
                                report1.RequestParameters = false;
                                report2.RequestParameters = false;
                                report3.RequestParameters = false;
                                report4.RequestParameters = false;
                                report5.RequestParameters = false;
                                report6.RequestParameters = false;
                                report7.RequestParameters = false;
                                report.CreateDocument(false);
                                report1.CreateDocument(false);
                                report2.CreateDocument(false);
                                report3.CreateDocument(false);
                                report4.CreateDocument(false);
                                report5.CreateDocument(false);
                                report6.CreateDocument(false);
                                report7.CreateDocument(false);
                                report.Pages.AddRange(report1.Pages);
                                report.Pages.AddRange(report2.Pages);
                                report.Pages.AddRange(report3.Pages);
                                report.Pages.AddRange(report4.Pages);
                                report.Pages.AddRange(report5.Pages);
                                report.Pages.AddRange(report6.Pages);
                                report.Pages.AddRange(report7.Pages);
                                report.PrintingSystem.ContinuousPageNumbering = true;
                                ReportPrintTool printTool = new ReportPrintTool(report);
                                printTool.AutoShowParametersPanel = false;
                                printTool.ShowPreviewDialog();
                                this.users_programmTableAdapter.FillByUrist(this.uristDataSet1.users_programm);
                            }
                            if (rowcount == 2)
                            {

                                Globals.id_user1 = (int)((DataRowView)(usersprogrammBindingSource.Current)).Row["user_id"];
                                usersprogrammBindingSource.MoveLast();
                                Globals.id_user2 = (int)((DataRowView)(usersprogrammBindingSource.Current)).Row["user_id"];
                                Globals.id_user3 = 0;
                                Globals.id_user4 = 0;
                                Globals.id_user5 = 0;
                                Globals.sdate1 = Convert.ToDateTime(dateEdit1.Text);
                                Globals.podate1 = Convert.ToDateTime(dateEdit2.Text);
                                svod_po_uristam report = new svod_po_uristam();
                                svod_po_uristam1 report1 = new svod_po_uristam1();
                                byt_vzyskanie report2 = new byt_vzyskanie();
                                prom_vzyskanie report3 = new prom_vzyskanie();
                                Iski report4 = new Iski();
                                Jaloby report5 = new Jaloby();
                                sogl report6 = new sogl();
                                sogl1 report7 = new sogl1();
                                report.Parameters["parameter3"].Value = Globals.id_user1;
                                report.Parameters["parameter4"].Value = Globals.id_user2;
                                report.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report.Parameters["parameter1"].Value = Globals.sdate1;
                                report.Parameters["parameter2"].Value = Globals.podate1; 
                                report.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report1.Parameters["parameter3"].Value = Globals.id_user1;
                                report1.Parameters["parameter4"].Value = Globals.id_user2;
                                report1.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report1.Parameters["parameter1"].Value = Globals.sdate1;
                                report1.Parameters["parameter2"].Value = Globals.podate1; 
                                report1.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report2.Parameters["parameter3"].Value = Globals.id_user1;
                                report2.Parameters["parameter4"].Value = Globals.id_user2;
                                report2.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report2.Parameters["parameter1"].Value = Globals.sdate1;
                                report2.Parameters["parameter2"].Value = Globals.podate1; 
                                report2.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report3.Parameters["parameter3"].Value = Globals.id_user1;
                                report3.Parameters["parameter4"].Value = Globals.id_user2;
                                report3.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report3.Parameters["parameter1"].Value = Globals.sdate1;
                                report3.Parameters["parameter2"].Value = Globals.podate1; 
                                report3.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report4.Parameters["parameter3"].Value = Globals.id_user1;
                                report4.Parameters["parameter4"].Value = Globals.id_user2;
                                report4.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report4.Parameters["parameter1"].Value = Globals.sdate1;
                                report4.Parameters["parameter2"].Value = Globals.podate1; 
                                report4.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report5.Parameters["parameter3"].Value = Globals.id_user1;
                                report5.Parameters["parameter4"].Value = Globals.id_user2;
                                report5.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report5.Parameters["parameter1"].Value = Globals.sdate1;
                                report5.Parameters["parameter2"].Value = Globals.podate1; 
                                report5.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report6.Parameters["parameter3"].Value = Globals.id_user1;
                                report6.Parameters["parameter4"].Value = Globals.id_user2;
                                report6.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report6.Parameters["parameter1"].Value = Globals.sdate1;
                                report6.Parameters["parameter2"].Value = Globals.podate1; 
                                report6.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report7.Parameters["parameter3"].Value = Globals.id_user1;
                                report7.Parameters["parameter4"].Value = Globals.id_user2;
                                report7.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report7.Parameters["parameter1"].Value = Globals.sdate1;
                                report7.Parameters["parameter2"].Value = Globals.podate1; 
                                report7.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report.RequestParameters = false;
                                report1.RequestParameters = false;
                                report2.RequestParameters = false;
                                report3.RequestParameters = false;
                                report4.RequestParameters = false;
                                report5.RequestParameters = false;
                                report6.RequestParameters = false;
                                report7.RequestParameters = false;
                                report.CreateDocument(false);
                                report1.CreateDocument(false);
                                report2.CreateDocument(false);
                                report3.CreateDocument(false);
                                report4.CreateDocument(false);
                                report5.CreateDocument(false);
                                report6.CreateDocument(false);
                                report7.CreateDocument(false);
                                report.Pages.AddRange(report1.Pages);
                                report.Pages.AddRange(report2.Pages);
                                report.Pages.AddRange(report3.Pages);
                                report.Pages.AddRange(report4.Pages);
                                report.Pages.AddRange(report5.Pages);
                                report.Pages.AddRange(report6.Pages);
                                report.Pages.AddRange(report7.Pages);
                                report.PrintingSystem.ContinuousPageNumbering = true;
                                ReportPrintTool printTool = new ReportPrintTool(report);
                                printTool.AutoShowParametersPanel = false;
                                printTool.ShowPreviewDialog();
                                this.users_programmTableAdapter.FillByUrist(this.uristDataSet1.users_programm);
                            }
                            if (rowcount == 3)
                            {

                                Globals.id_user1 = (int)((DataRowView)(usersprogrammBindingSource.Current)).Row["user_id"];
                                usersprogrammBindingSource.MoveNext();
                                Globals.id_user2 = (int)((DataRowView)(usersprogrammBindingSource.Current)).Row["user_id"];
                                usersprogrammBindingSource.MoveLast();
                                Globals.id_user3 = (int)((DataRowView)(usersprogrammBindingSource.Current)).Row["user_id"];
                                Globals.id_user4 = 0;
                                Globals.id_user5 = 0;
                                Globals.sdate1 = Convert.ToDateTime(dateEdit1.Text);
                                Globals.podate1 = Convert.ToDateTime(dateEdit2.Text);
                                svod_po_uristam report = new svod_po_uristam();
                                svod_po_uristam1 report1 = new svod_po_uristam1();
                                byt_vzyskanie report2 = new byt_vzyskanie();
                                prom_vzyskanie report3 = new prom_vzyskanie();
                                Iski report4 = new Iski();
                                Jaloby report5 = new Jaloby();
                                sogl report6 = new sogl();
                                sogl1 report7 = new sogl1();
                                report.Parameters["parameter3"].Value = Globals.id_user1;
                                report.Parameters["parameter4"].Value = Globals.id_user2;
                                report.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report.Parameters["parameter1"].Value = Globals.sdate1;
                                report.Parameters["parameter2"].Value = Globals.podate1; 
                                report.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report1.Parameters["parameter3"].Value = Globals.id_user1;
                                report1.Parameters["parameter4"].Value = Globals.id_user2;
                                report1.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report1.Parameters["parameter1"].Value = Globals.sdate1;
                                report1.Parameters["parameter2"].Value = Globals.podate1; 
                                report1.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report2.Parameters["parameter3"].Value = Globals.id_user1;
                                report2.Parameters["parameter4"].Value = Globals.id_user2;
                                report2.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report2.Parameters["parameter1"].Value = Globals.sdate1;
                                report2.Parameters["parameter2"].Value = Globals.podate1; 
                                report2.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report3.Parameters["parameter3"].Value = Globals.id_user1;
                                report3.Parameters["parameter4"].Value = Globals.id_user2;
                                report3.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report3.Parameters["parameter1"].Value = Globals.sdate1;
                                report3.Parameters["parameter2"].Value = Globals.podate1; 
                                report3.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report4.Parameters["parameter3"].Value = Globals.id_user1;
                                report4.Parameters["parameter4"].Value = Globals.id_user2;
                                report4.Parameters["parameter5"].Value = Globals.id_user3;
                                 report.Parameters["parameter7"].Value = Globals.id_user4;
                                 report.Parameters["parameter8"].Value = Globals.id_user5;
                                report4.Parameters["parameter1"].Value = Globals.sdate1;
                                report4.Parameters["parameter2"].Value = Globals.podate1; 
                                report4.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report5.Parameters["parameter3"].Value = Globals.id_user1;
                                report5.Parameters["parameter4"].Value = Globals.id_user2;
                                report5.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report5.Parameters["parameter1"].Value = Globals.sdate1;
                                report5.Parameters["parameter2"].Value = Globals.podate1; 
                                report5.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report6.Parameters["parameter3"].Value = Globals.id_user1;
                                report6.Parameters["parameter4"].Value = Globals.id_user2;
                                report6.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report6.Parameters["parameter1"].Value = Globals.sdate1;
                                report6.Parameters["parameter2"].Value = Globals.podate1; 
                                report6.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report7.Parameters["parameter3"].Value = Globals.id_user1;
                                report7.Parameters["parameter4"].Value = Globals.id_user2;
                                report7.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report7.Parameters["parameter1"].Value = Globals.sdate1;
                                report7.Parameters["parameter2"].Value = Globals.podate1; 
                                report7.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report.RequestParameters = false;
                                report1.RequestParameters = false;
                                report2.RequestParameters = false;
                                report3.RequestParameters = false;
                                report4.RequestParameters = false;
                                report5.RequestParameters = false;
                                report6.RequestParameters = false;
                                report7.RequestParameters = false;
                                report.CreateDocument(false);
                                report1.CreateDocument(false);
                                report2.CreateDocument(false);
                                report3.CreateDocument(false);
                                report4.CreateDocument(false);
                                report5.CreateDocument(false);
                                report6.CreateDocument(false);
                                report7.CreateDocument(false);
                                report.Pages.AddRange(report1.Pages);
                                report.Pages.AddRange(report2.Pages);
                                report.Pages.AddRange(report3.Pages);
                                report.Pages.AddRange(report4.Pages);
                                report.Pages.AddRange(report5.Pages);
                                report.Pages.AddRange(report6.Pages);
                                report.Pages.AddRange(report7.Pages);
                                report.PrintingSystem.ContinuousPageNumbering = true;
                                ReportPrintTool printTool = new ReportPrintTool(report);
                                printTool.AutoShowParametersPanel = false;
                                printTool.ShowPreviewDialog();
                                this.users_programmTableAdapter.FillByUrist(this.uristDataSet1.users_programm);
                            }

                            if (rowcount == 5)
                            {

                                Globals.id_user1 = (int)((DataRowView)(usersprogrammBindingSource.Current)).Row["user_id"];
                                usersprogrammBindingSource.MoveNext();
                                Globals.id_user2 = (int)((DataRowView)(usersprogrammBindingSource.Current)).Row["user_id"];
                                usersprogrammBindingSource.MoveLast();
                                Globals.id_user3 = (int)((DataRowView)(usersprogrammBindingSource.Current)).Row["user_id"];
                                usersprogrammBindingSource.MoveLast();
                                Globals.id_user4 = (int)((DataRowView)(usersprogrammBindingSource.Current)).Row["user_id"];
                                usersprogrammBindingSource.MoveLast();
                                Globals.id_user5 = (int)((DataRowView)(usersprogrammBindingSource.Current)).Row["user_id"];
                                Globals.sdate1 = Convert.ToDateTime(dateEdit1.Text);
                                Globals.podate1 = Convert.ToDateTime(dateEdit2.Text);
                                svod_po_uristam report = new svod_po_uristam();
                                svod_po_uristam1 report1 = new svod_po_uristam1();
                                byt_vzyskanie report2 = new byt_vzyskanie();
                                prom_vzyskanie report3 = new prom_vzyskanie();
                                Iski report4 = new Iski();
                                Jaloby report5 = new Jaloby();
                                sogl report6 = new sogl();
                                sogl1 report7 = new sogl1();
                                report.Parameters["parameter3"].Value = Globals.id_user1;
                                report.Parameters["parameter4"].Value = Globals.id_user2;
                                report.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report.Parameters["parameter1"].Value = Globals.sdate1;
                                report.Parameters["parameter2"].Value = Globals.podate1;
                                report.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report1.Parameters["parameter3"].Value = Globals.id_user1;
                                report1.Parameters["parameter4"].Value = Globals.id_user2;
                                report1.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report1.Parameters["parameter1"].Value = Globals.sdate1;
                                report1.Parameters["parameter2"].Value = Globals.podate1;
                                report1.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report2.Parameters["parameter3"].Value = Globals.id_user1;
                                report2.Parameters["parameter4"].Value = Globals.id_user2;
                                report2.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report2.Parameters["parameter1"].Value = Globals.sdate1;
                                report2.Parameters["parameter2"].Value = Globals.podate1;
                                report2.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report3.Parameters["parameter3"].Value = Globals.id_user1;
                                report3.Parameters["parameter4"].Value = Globals.id_user2;
                                report3.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report3.Parameters["parameter1"].Value = Globals.sdate1;
                                report3.Parameters["parameter2"].Value = Globals.podate1;
                                report3.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report4.Parameters["parameter3"].Value = Globals.id_user1;
                                report4.Parameters["parameter4"].Value = Globals.id_user2;
                                report4.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report4.Parameters["parameter1"].Value = Globals.sdate1;
                                report4.Parameters["parameter2"].Value = Globals.podate1;
                                report4.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report5.Parameters["parameter3"].Value = Globals.id_user1;
                                report5.Parameters["parameter4"].Value = Globals.id_user2;
                                report5.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report5.Parameters["parameter1"].Value = Globals.sdate1;
                                report5.Parameters["parameter2"].Value = Globals.podate1;
                                report5.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report6.Parameters["parameter3"].Value = Globals.id_user1;
                                report6.Parameters["parameter4"].Value = Globals.id_user2;
                                report6.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report6.Parameters["parameter1"].Value = Globals.sdate1;
                                report6.Parameters["parameter2"].Value = Globals.podate1;
                                report6.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report7.Parameters["parameter3"].Value = Globals.id_user1;
                                report7.Parameters["parameter4"].Value = Globals.id_user2;
                                report7.Parameters["parameter5"].Value = Globals.id_user3;
                                report.Parameters["parameter7"].Value = Globals.id_user4;
                                report.Parameters["parameter8"].Value = Globals.id_user5;
                                report7.Parameters["parameter1"].Value = Globals.sdate1;
                                report7.Parameters["parameter2"].Value = Globals.podate1;
                                report7.Parameters["parameter6"].Value = Globals.fio_otchet;
                                report.RequestParameters = false;
                                report1.RequestParameters = false;
                                report2.RequestParameters = false;
                                report3.RequestParameters = false;
                                report4.RequestParameters = false;
                                report5.RequestParameters = false;
                                report6.RequestParameters = false;
                                report7.RequestParameters = false;
                                report.CreateDocument(false);
                                report1.CreateDocument(false);
                                report2.CreateDocument(false);
                                report3.CreateDocument(false);
                                report4.CreateDocument(false);
                                report5.CreateDocument(false);
                                report6.CreateDocument(false);
                                report7.CreateDocument(false);
                                report.Pages.AddRange(report1.Pages);
                                report.Pages.AddRange(report2.Pages);
                                report.Pages.AddRange(report3.Pages);
                                report.Pages.AddRange(report4.Pages);
                                report.Pages.AddRange(report5.Pages);
                                report.Pages.AddRange(report6.Pages);
                                report.Pages.AddRange(report7.Pages);
                                report.PrintingSystem.ContinuousPageNumbering = true;
                                ReportPrintTool printTool = new ReportPrintTool(report);
                                printTool.AutoShowParametersPanel = false;
                                printTool.ShowPreviewDialog();
                                this.users_programmTableAdapter.FillByUrist(this.uristDataSet1.users_programm);
                            }

                        }
                    }
                    else {// MessageBox.Show("Выберите юриста!!!");
                    }
                   
                }

            }
            else { MessageBox.Show("Выберите правильную дату!!! \n Дата С должна быть меньше чем ПО"); }

          
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Globals.sdate1 = Convert.ToDateTime(dateEdit1.Text);
            Globals.podate1 = Convert.ToDateTime(dateEdit2.Text);
            if (Globals.sdate1 < Globals.podate1)
            
            {
                
                svod_pret_res report = new svod_pret_res();
                svod_pret_res1 report1 = new svod_pret_res1();
                svod_vzys_res report2 = new svod_vzys_res();
                svod_vzys_res1 report3 = new svod_vzys_res1();
                report.Parameters["parameter2"].Value = Globals.sdate1;
                report.Parameters["parameter3"].Value = Globals.podate1;
                report1.Parameters["parameter1"].Value = Globals.sdate1;
                report1.Parameters["parameter2"].Value = Globals.podate1;
                report2.Parameters["parameter1"].Value = Globals.sdate1;
                report2.Parameters["parameter2"].Value = Globals.podate1;
                report3.Parameters["parameter1"].Value = Globals.sdate1;
                report3.Parameters["parameter2"].Value = Globals.podate1;
                report.RequestParameters = false;
                report1.RequestParameters = false;
                report2.RequestParameters = false;
                report3.RequestParameters = false;
                report.CreateDocument(false);
                report1.CreateDocument(false);
                report2.CreateDocument(false);
                report3.CreateDocument(false);
                report.Pages.AddRange(report1.Pages);
                report.Pages.AddRange(report2.Pages);
                report.Pages.AddRange(report3.Pages);
                report.PrintingSystem.ContinuousPageNumbering = true;
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.AutoShowParametersPanel = false;
                printTool.ShowPreviewDialog();
            }
             //MessageBox.Show("Выберите правильную дату!!! \n Дата С должна быть меньше чем ПО"); }
            
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            Globals.sdate1 = Convert.ToDateTime(dateEdit1.Text);
            Globals.podate1 = Convert.ToDateTime(dateEdit2.Text);
            if (Globals.sdate1 < Globals.podate1)
            {

                svod_res_otpr_byt report = new svod_res_otpr_byt();
                svod_res_otpr_prom report1 = new svod_res_otpr_prom();
              //  svod_vzys_res report2 = new svod_vzys_res();
               // svod_vzys_res1 report3 = new svod_vzys_res1();
                report.Parameters["parameter1"].Value = Globals.sdate1;
                report.Parameters["parameter2"].Value = Globals.podate1;
                report1.Parameters["parameter1"].Value = Globals.sdate1;
                report1.Parameters["parameter2"].Value = Globals.podate1;
               // report2.Parameters["parameter1"].Value = Globals.sdate1;
               // report2.Parameters["parameter2"].Value = Globals.podate1;
              //  report3.Parameters["parameter1"].Value = Globals.sdate1;
              //  report3.Parameters["parameter2"].Value = Globals.podate1;
                report.RequestParameters = false;
                report1.RequestParameters = false;
              //  report2.RequestParameters = false;
              //  report3.RequestParameters = false;
                report.CreateDocument(false);
                report1.CreateDocument(false);
            //    report2.CreateDocument(false);
             //   report3.CreateDocument(false);
                report.Pages.AddRange(report1.Pages);
              //  report.Pages.AddRange(report2.Pages);
              //  report.Pages.AddRange(report3.Pages);
                report.PrintingSystem.ContinuousPageNumbering = true;
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.AutoShowParametersPanel = false;
                printTool.ShowPreviewDialog();
            }
            else { MessageBox.Show("Выберите правильную дату!!! \n Дата С должна быть меньше чем ПО"); }
            
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form dd = new Sheduler();
            dd.Show();
        }
    }
}