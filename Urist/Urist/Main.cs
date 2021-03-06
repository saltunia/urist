﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Deployment.Application;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Localization;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using System.Diagnostics;
using urist;

namespace Urist
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private string vershion = "";
        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uristDataSet1.sud' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'uristDataSet1.sud_delo' table. You can move, or remove it, as needed.
          
             
            Globals.click =0;
            // TODO: This line of code loads data into the 'uristDataSet1.doc_prikrep_file' table. You can move, or remove it, as needed.
            this.sprStatusSudTableAdapter.Fill(this.uristDataSet1.sprStatusSud);
         
            // TODO: This line of code loads data into the 'uristDataSet11.doc_prikrep_file' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'uristDataSet1.sprStatus' table. You can move, or remove it, as needed.
            this.sprStatusTableAdapter.Fill(this.uristDataSet1.sprStatus);
            // TODO: This line of code loads data into the 'uristDataSet1.sprPromByt' table. You can move, or remove it, as needed.
            this.sprPromBytTableAdapter.Fill(this.uristDataSet1.sprPromByt);
            // TODO: This line of code loads data into the 'uristDataSet1.delo' table. You can move, or remove it, as needed.
            this.delo_deb_bytTableAdapter.FillByRes3(this.uristDataSet1.delo_deb_byt, Globals.prava_mod_spr_res);
            // TODO: This line of code loads data into the 'uristDataSet1.delo_deb_prom' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'uristDataSet1.users_programm' table. You can move, or remove it, as needed.
            this.users_programmTableAdapter.Fill(this.uristDataSet1.users_programm);
      
            backstageViewControl1.SelectedTab=backstageViewTabItem1;
            this.Text = "Вы вошли как: " + Globals.name_user + "        Версия программы: " + vershion;
           /* Version ver = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            string str = ver.ToString();
            vershion = str;*/
           // ovalPictureBox1.Load(Globals.filename1);
            Delegate.RemoveAll(Globals.en_delegate, Globals.en_delegate);
            Delegate.RemoveAll(Globals.en_delegate1, Globals.en_delegate1);
            Globals.en_delegate = visible_main;
            Globals.en_delegate1 = visible_main_reload;
        }

        private void visible_main_reload()
        {
            Globals.click = 0;
            try
            {
                this.Enabled = true;
                this.sprStatusSudTableAdapter.Fill(this.uristDataSet1.sprStatusSud);
                // TODO: This line of code loads data into the 'uristDataSet11.doc_prikrep_file' table. You can move, or remove it, as needed.

                // TODO: This line of code loads data into the 'uristDataSet1.sprStatus' table. You can move, or remove it, as needed.
                this.sprStatusTableAdapter.Fill(this.uristDataSet1.sprStatus);
                // TODO: This line of code loads data into the 'uristDataSet1.sprPromByt' table. You can move, or remove it, as needed.
                this.sprPromBytTableAdapter.Fill(this.uristDataSet1.sprPromByt);
                this.users_programmTableAdapter.Fill(this.uristDataSet1.users_programm);
                this.sud_deloTableAdapter.FillByUrist(this.uristDataSet1.sud_delo, Globals.id_user); 
                this.sudTableAdapter.FillByDelo(this.uristDataSet1.sud, Globals.id_delo1);
                backstageViewControl1.SelectedTab = backstageViewTabItem5;
            }
            catch (Exception ex) { }
        }

        private void visible_main()
        {
            Globals.click = 0;
            try {
             this.Enabled = true;
            this.sprStatusSudTableAdapter.Fill(this.uristDataSet1.sprStatusSud);
            // TODO: This line of code loads data into the 'uristDataSet11.doc_prikrep_file' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'uristDataSet1.sprStatus' table. You can move, or remove it, as needed.
            this.sprStatusTableAdapter.Fill(this.uristDataSet1.sprStatus);
            // TODO: This line of code loads data into the 'uristDataSet1.sprPromByt' table. You can move, or remove it, as needed.
            this.sprPromBytTableAdapter.Fill(this.uristDataSet1.sprPromByt);
            this.users_programmTableAdapter.Fill(this.uristDataSet1.users_programm);
            this.sud_deloTableAdapter.FillByUrist(this.uristDataSet1.sud_delo, Globals.id_user);
            
            
            }
            catch(Exception ex){}
        }

        private void backstageViewButtonItem2_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem4_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem4_ItemHover(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem1_ItemHover(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem1_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem2_ItemHover(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem2_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem5_ItemHover(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem5_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem3_ItemHover(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem3_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem6_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem6_ItemHover(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {


        }

        private void backstageViewTabItem1_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            this.delo_deb_bytTableAdapter.FillByRes3(this.uristDataSet1.delo_deb_byt, Globals.prava_mod_spr_res);
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            Globals.sdate = dateEdit6.Text;
            Globals.podate = dateEdit5.Text;
            this.delo_deb_bytTableAdapter.FillByRes2(this.uristDataSet1.delo_deb_byt, Globals.prava_mod_spr_res, Globals.sdate, Globals.podate);
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            this.delo_deb_bytTableAdapter.FillByRes3(this.uristDataSet1.delo_deb_byt, Globals.prava_mod_spr_res);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("Библиотека не найдена", "Ошибка");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }
        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl1);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {  
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
        {
            ArrayList rows = new ArrayList();
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
            }
            try
            {
                // gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    object id = row["id"];
                    object cspot = row["cspot"];
                    /*тут проверка доделать */
                    this.delo_deb_bytTableAdapter.UpdateQuery(Globals.id_user, 1,(int)id);
                    queriesTableAdapter1.insert_delo_byt((int)id);
                }
 

                   
                    this.delo_deb_bytTableAdapter.FillByRes3(this.uristDataSet1.delo_deb_byt, Globals.prava_mod_spr_res);
  
            }
            catch (Exception ex) { }
        }
        if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
        {
            ArrayList rows = new ArrayList();
            Int32[] selectedRowHandles = gridView2.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView2.GetDataRow(selectedRowHandle));
            }
            try
            {
                // gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    object id = row["id"];
                    this.delo_deb_promTableAdapter.UpdateQuery(Globals.id_user, 1,(int)id);
                    queriesTableAdapter1.insert_delo_prom((int)id);
                }



                this.delo_deb_promTableAdapter.FillByRes3(this.uristDataSet1.delo_deb_prom, Globals.prava_mod_spr_res);

            }
            catch (Exception ex) { }
        }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Globals.sdate = dateEdit2.Text;
            Globals.podate = dateEdit1.Text;
            this.delo_deb_promTableAdapter.FillByRes2(this.uristDataSet1.delo_deb_prom, Globals.prava_mod_spr_res, Globals.sdate, Globals.podate);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.delo_deb_promTableAdapter.FillByRes3(this.uristDataSet1.delo_deb_prom, Globals.prava_mod_spr_res);
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl2);
        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl3);
        }

        private void backstageViewTabItem2_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            this.deloTableAdapter.FillByUrist(this.uristDataSet1.delo,Globals.id_user);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Globals.click = 1;
            ofdInput.ShowDialog();
        }

        private void advBandedGridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
             GridView View = sender as GridView;
             if (e.RowHandle >= 0)
             {
                 DateTime p = (DateTime)(View.GetRowCellValue(e.RowHandle, View.Columns["date_peredachi_sud"]));
                  DateTime now =DateTime.Now;
                  DateTime m=p.AddDays(-7);
                  if (m <= now && now <= p)
                  {
                      e.Appearance.BackColor = Color.Pink;
                      e.Appearance.ForeColor = Color.Black;
                  }

                  if (now > p)
                  {
                      e.Appearance.BackColor = Color.FromArgb(0xFF, 0x99, 0xCC);
                      e.Appearance.ForeColor = Color.Black;
                  }
             }
        }

        private void advBandedGridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var rowHandle = advBandedGridView1.FocusedRowHandle;
            int id = (int)(advBandedGridView1.GetRowCellValue(rowHandle, "id"));
            string fact_spot2;
     string fact_adress;
      string telephone;
          double ypeni;
      double yenergy;
      double  yakt;
      double y1;
      double y2;
      double  y3;
      double y4;
      double y5;
      double y6;
      double  y7;
      double y8;
      string dendbill;
     string dendpay;
     if (advBandedGridView1.GetRowCellValue(rowHandle, "fact_spot2") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "fact_spot2") == "")
     { fact_spot2 = null; }
     else
     {
         fact_spot2 = (string)advBandedGridView1.GetRowCellValue(rowHandle, "fact_spot2");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "fact_adress") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "fact_adress") == "")
     { fact_adress = null; }
     else
     {
         fact_adress = (string)advBandedGridView1.GetRowCellValue(rowHandle, "fact_adress");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "telephone") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "telephone") == "")
     { telephone = null; }
     else
     {
         telephone = (string)advBandedGridView1.GetRowCellValue(rowHandle, "telephone");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "dendbill") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "dendbill") == "")
     { dendbill = null; }
     else
     {
         dendbill = (string)advBandedGridView1.GetRowCellValue(rowHandle, "dendbill");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "dendpay") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "dendpay") == "")
     { dendpay = null; }
     else
     {
         dendpay = (string)advBandedGridView1.GetRowCellValue(rowHandle, "dendpay");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "ypeni") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "ypeni") == "")
     { ypeni = 0; }
     else
     {
         ypeni = (double)advBandedGridView1.GetRowCellValue(rowHandle, "ypeni");
     }


     if (advBandedGridView1.GetRowCellValue(rowHandle, "yenergy") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "yenergy") == "")
     { yenergy = 0; }
     else
     {
         yenergy = (double)advBandedGridView1.GetRowCellValue(rowHandle, "yenergy");
     }

     if (advBandedGridView1.GetRowCellValue(rowHandle, "yakt") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "yakt") == "")
     { yakt = 0; }
     else
     {
         yakt = (double)advBandedGridView1.GetRowCellValue(rowHandle, "yakt");
     }

     if (advBandedGridView1.GetRowCellValue(rowHandle, "y1") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "y1") == "")
     { y1= 0; }
     else
     {
         y1 = (double)advBandedGridView1.GetRowCellValue(rowHandle, "y1");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "y2") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "y2") == "")
     { y2 = 0; }
     else
     {
         y2 = (double)advBandedGridView1.GetRowCellValue(rowHandle, "y2");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "y3") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "y3") == "")
     { y3 = 0; }
     else
     {
         y3 = (double)advBandedGridView1.GetRowCellValue(rowHandle, "y3");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "y4") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "y4") == "")
     { y4 = 0; }
     else
     {
         y4 = (double)advBandedGridView1.GetRowCellValue(rowHandle, "y4");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "y5") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "y5") == "")
     { y5 = 0; }
     else
     {
         y5 = (double)advBandedGridView1.GetRowCellValue(rowHandle, "y5");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "y6") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "y6") == "")
     { y6= 0; }
     else
     {
         y6 = (double)advBandedGridView1.GetRowCellValue(rowHandle, "y6");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "y7") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "y7") == "")
     { y7 = 0; }
     else
     {
         y7 = (double)advBandedGridView1.GetRowCellValue(rowHandle, "y7");
     }
     if (advBandedGridView1.GetRowCellValue(rowHandle, "y8") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle, "y8") == "")
     { y8 = 0; }
     else
     {
         y8 = (double)advBandedGridView1.GetRowCellValue(rowHandle, "y8");
     }
     this.deloTableAdapter.UpdateQuery(ypeni, yenergy, yakt, y1, y2, y3, y4, y5, y6, y7, y8, dendbill, dendpay, fact_spot2, fact_adress, telephone, id);
     this.deloTableAdapter.FillByUrist(this.uristDataSet1.delo, Globals.id_user);

        }

        private void delodebbytBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
           
        }

        private void ofdInput_FileOk(object sender, CancelEventArgs e)
        {
            string inFile = ofdInput.FileName;
            string file_name = Path.GetFileName(inFile);
            try
            {

                byte[] outlen;
                using (var fs = File.Open(inFile, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    if (fs.Length > 100000000000000000)
                    {
                        MessageBox.Show("файл слишком большой для сохранения");
                        return;
                    }
                    outlen = new byte[fs.Length];
                    fs.Read(outlen, 0, Convert.ToInt32(fs.Length));

                }
                if (outlen.Length != 0)
                {
                    if (Globals.click == 1)
                    {
                        this.queriesTableAdapter1.insert_file(Globals.id_delo, outlen, file_name, null, Globals.id_user, 1, null);
                    }
                    if (Globals.click == 2)
                    {
                        this.queriesTableAdapter1.insert_file(Globals.id_delo, outlen, file_name, null, Globals.id_user, 1, Globals.id_sud);
                    }
                    if (Globals.click == 3)
                    {
                        this.queriesTableAdapter1.insert_file(Globals.id_delo1, outlen, file_name, null, Globals.id_user, Convert.ToInt32(Globals.status_sud), Globals.id_sud1);
                        this.doc_prikrep_fileTableAdapter.FillBySud(uristDataSet1.doc_prikrep_file, Globals.id_delo1, Globals.id_sud1);
                    }
                    MessageBox.Show("Файл успешно прикреплен ;) ");
                    
                }
            }

            catch (IOException ex)
            {
                MessageBox.Show("Данные не сохранились");
            }
        }

        private void xtraTabControl2_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                if (xtraTabControl2.SelectedTabPage == xtraTabPage4)
                { this.doc_prikrep_fileTableAdapter.FillByid_delo(this.uristDataSet1.doc_prikrep_file, Globals.id_delo); }
                

            }
            catch { }

        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                byte[] b1 = ((byte[])((DataRowView)(docprikrepfileBindingSource.Current)).Row["prikr_file"]);
                string exens4grid = (string)((DataRowView)(docprikrepfileBindingSource.Current)).Row["name_file"];
                exens4grid = Path.GetExtension(exens4grid);
                string filename = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid);
                var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
                bw.Write(b1);
                bw.Close();
                Process.Start(filename);
            }
            catch (Exception ex)
            { }
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно \nхотите удалить документ? \n", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var rowHandle = gridView3.FocusedRowHandle;

                for (int i = 0; i <= gridView3.RowCount; i++)
                {
                    var check = gridView3.GetRowCellValue(i, "vrem_check");
                    if (Convert.ToString(check) != "")
                    {
                        if (Convert.ToBoolean(check) == true)
                        {
                            int id = Convert.ToInt32(gridView3.GetRowCellValue(i, "id"));
                            doc_prikrep_fileTableAdapter.DeleteQuery(id);

                        }
                    }
                }
                this.doc_prikrep_fileTableAdapter.FillByid_delo(uristDataSet1.doc_prikrep_file, Globals.id_delo);
            }
            else { return; }
        }

        private void отсканироватьДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.click = 1;
            Form kk = new MainFrame();
            kk.ShowDialog();

        }

        private void передатьВСудToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var rowHandle = advBandedGridView1.FocusedRowHandle;
          
            Globals.prom_byt = (int)advBandedGridView1.GetRowCellValue(rowHandle,"prom_byt");
            if (Globals.prom_byt == 1)
            {
                if (advBandedGridView1.GetRowCellValue(rowHandle,"yenergy") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle,"yenergy") == "")
                { Globals.yenergya = 0; }
                else
                {
                    Globals.yenergya = (double)advBandedGridView1.GetRowCellValue(rowHandle,"yenergy");
                }
                if (advBandedGridView1.GetRowCellValue(rowHandle,"ypeni") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle,"ypeni") == "")
                { Globals.ypenia = 0; }
                else
                { Globals.ypenia = (double)advBandedGridView1.GetRowCellValue(rowHandle,"ypeni"); }
                if (advBandedGridView1.GetRowCellValue(rowHandle,"yakt") is DBNull || advBandedGridView1.GetRowCellValue(rowHandle,"yakt") == "")
                { Globals.yakta = 0; }
                {
                    Globals.yakta = (double)advBandedGridView1.GetRowCellValue(rowHandle,"yakt");
                }





            }
            else
            {
                if (advBandedGridView1.GetRowCellValue(rowHandle,"yenergy") is DBNull ||advBandedGridView1.GetRowCellValue(rowHandle,"yenergy") == "")
                { Globals.yenergya = 0; }
                else
                {
                    Globals.yenergya = (double)advBandedGridView1.GetRowCellValue(rowHandle,"yenergy");
                }

            }
            Globals.id_sud_spr = 2;
            Form ff = new sud_delo();
            ff.Show();

        }

        private void deloBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_delo = (int)((DataRowView)deloBindingSource.Current).Row["id"];
               
            }
            catch (Exception ex) { }
        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl3);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.deloTableAdapter.FillByUrist(this.uristDataSet1.delo, Globals.id_user);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Globals.sdate = dateEdit4.Text;
            Globals.podate = dateEdit3.Text;
            this.deloTableAdapter.FillByUristDate(this.uristDataSet1.delo, Globals.id_user, Globals.sdate, Globals.podate);
        }

        private void backstageViewTabItem5_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            this.sud_deloTableAdapter.FillByUrist(this.uristDataSet1.sud_delo,Globals.id_user);
            this.sprStatusSudTableAdapter.Fill(this.uristDataSet1.sprStatusSud);
            this.sprPromBytTableAdapter.Fill(this.uristDataSet1.sprPromByt);
        }

        private void suddeloBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try { Globals.id_delo1 = (int)((DataRowView)suddeloBindingSource.Current).Row["id_delo"];
            Globals.prom_byt = (int)((DataRowView)suddeloBindingSource.Current).Row["prom_byt"];
            if (Globals.prom_byt == 1)
            {
                if (((DataRowView)suddeloBindingSource.Current).Row["yenergy"] is DBNull || ((DataRowView)suddeloBindingSource.Current).Row["yenergy"]=="")
                { Globals.yenergy = 0; }
                else{
                Globals.yenergy = (double)((DataRowView)suddeloBindingSource.Current).Row["yenergy"];}
                if (((DataRowView)suddeloBindingSource.Current).Row["ypeni"] is DBNull || ((DataRowView)suddeloBindingSource.Current).Row["ypeni"] == "")
                { Globals.ypeni = 0; }
                else
                { Globals.ypeni = (double)((DataRowView)suddeloBindingSource.Current).Row["ypeni"]; }
                if (((DataRowView)suddeloBindingSource.Current).Row["yakt"] is DBNull || ((DataRowView)suddeloBindingSource.Current).Row["yakt"]=="")
                { Globals.yakt = 0; }
                {
                    Globals.yakt = (double)((DataRowView)suddeloBindingSource.Current).Row["yakt"];
                }
                


                if (((DataRowView)suddeloBindingSource.Current).Row["yenergy_saldo"] is DBNull || ((DataRowView)suddeloBindingSource.Current).Row["yenergy_saldo"] == "")
                { Globals.yenergy_saldo = 0; }
                else
                {
                    Globals.yenergy_saldo = (double)((DataRowView)suddeloBindingSource.Current).Row["yenergy_saldo"];
                }
                if (((DataRowView)suddeloBindingSource.Current).Row["ypeny"] is DBNull || ((DataRowView)suddeloBindingSource.Current).Row["ypeny"] == "")
                { Globals.ypeny = 0; }
                else
                { Globals.ypeny = (double)((DataRowView)suddeloBindingSource.Current).Row["ypeny"]; }
                if (((DataRowView)suddeloBindingSource.Current).Row["yakt1"] is DBNull || ((DataRowView)suddeloBindingSource.Current).Row["yakt1"] == "")
                { Globals.yakt1 = 0; }
                {
                    Globals.yakt1 = (double)((DataRowView)suddeloBindingSource.Current).Row["yakt1"];
                }

            }
            else
            {
                if (((DataRowView)suddeloBindingSource.Current).Row["yenergy"] is DBNull || ((DataRowView)suddeloBindingSource.Current).Row["yenergy"]=="")
                { Globals.yenergy = 0; }
                else
                {
                    Globals.yenergy = (double)((DataRowView)suddeloBindingSource.Current).Row["yenergy"];
                }
                if(((DataRowView)suddeloBindingSource.Current).Row["yenergy_saldo"] is DBNull || ((DataRowView)suddeloBindingSource.Current).Row["yenergy_saldo"]=="")
                { Globals.yenergy_saldo = 0; }
                else {
                    Globals.yenergy_saldo = (double)((DataRowView)suddeloBindingSource.Current).Row["yenergy_saldo"];
                }

            }
            this.sudTableAdapter.FillByDelo(this.uristDataSet1.sud, Globals.id_delo1);

            }
            catch (Exception ex)
            { }
        }

        private void gridControl5_Click(object sender, EventArgs e)
        {

        }

        private void gridControl3_Click(object sender, EventArgs e)
        {

        }

        private void gridView5_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.doc_prikrep_fileTableAdapter.FillBySud(this.uristDataSet1.doc_prikrep_file, Globals.id_delo1, Globals.id_sud1);
                byte[] b1 = ((byte[])((DataRowView)(docprikrepfileBindingSource.Current)).Row["prikr_file"]);
                string exens4grid = (string)((DataRowView)(docprikrepfileBindingSource.Current)).Row["name_file"];
                exens4grid = Path.GetExtension(exens4grid);
                string filename = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid);
                var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
                bw.Write(b1);
                bw.Close();
                Process.Start(filename);
            }
            catch (Exception ex)
            { MessageBox.Show("Прикрепленных файлов не имеется!!!"); }
        }

        private void sudBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                Globals.id_sud1 = (int)((DataRowView)sudBindingSource.Current).Row["id"];
                this.doc_prikrep_fileTableAdapter.FillBySud(this.uristDataSet1.doc_prikrep_file, Globals.id_delo1, Globals.id_sud1);
               
            }
            catch (Exception ex)
            { }
        }

        private void xtraTabControl3_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                if (xtraTabControl3.SelectedTabPage == xtraTabPage6)
                { this.doc_prikrep_fileTableAdapter.FillByid_delo(this.uristDataSet1.doc_prikrep_file, Globals.id_delo1); }


            }
            catch { }
        }

        private void gridView4_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                byte[] b1 = ((byte[])((DataRowView)(docprikrepfileBindingSource.Current)).Row["prikr_file"]);
                string exens4grid = (string)((DataRowView)(docprikrepfileBindingSource.Current)).Row["name_file"];
                exens4grid = Path.GetExtension(exens4grid);
                string filename = System.IO.Path.GetTempFileName().Replace(".tmp", exens4grid);
                var bw = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate));
                bw.Write(b1);
                bw.Close();
                Process.Start(filename);
            }
            catch (Exception ex)
            { }
        }

        private void advBandedGridView2_DoubleClick(object sender, EventArgs e)
        {
            this.Enabled = false;

            Globals.id_sud_spr = 1;
            Form ff = new sud_delo();
            ff.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Globals.click = 3;
            ofdInput.ShowDialog();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Globals.click = 3;
            Form kk = new MainFrame();
            kk.ShowDialog();
        }

      
      

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            ShowGridPreview(gridControl5);
        }

        private void backstageViewTabItem3_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            try {
            this.sud_deloTableAdapter.FillByDate(this.uristDataSet1.sud_delo, Globals.id_user, DateTime.Now, DateTime.Now.AddDays(5));
            this.sprStatusSudTableAdapter.Fill(this.uristDataSet1.sprStatusSud); }
            catch(Exception ex){}

        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
                {
                    this.delo_deb_promTableAdapter.FillByRes3(this.uristDataSet1.delo_deb_prom, Globals.prava_mod_spr_res);
                }

            }
            catch { }
        }

        private void backstageViewTabItem6_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            try
            {
                this.sud_deloTableAdapter.FillByUristZAkrytye(this.uristDataSet1.sud_delo, Globals.id_user);
                this.sprStatusSudTableAdapter.Fill(this.uristDataSet1.sprStatusSud);
            }
            catch (Exception ex) { }
        }

        private void gridControl7_Click(object sender, EventArgs e)
        {

        }

        private void передатьВСудToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            Globals.id_sud_spr = 1;
            Form ff = new sud_delo();
            ff.Show();
        }

        private void advBandedGridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if((View.GetRowCellValue(e.RowHandle, View.Columns["date_rassmoter"])!=DBNull.Value))
                {
                DateTime p = (DateTime)(View.GetRowCellValue(e.RowHandle, View.Columns["date_rassmoter"]));
                DateTime now = DateTime.Now;
                DateTime m = p.AddDays(-4);
                if (m <= now && now <= p)
                {
                    e.Appearance.BackColor = Color.Pink;
                    e.Appearance.ForeColor = Color.Black;
                }

                if (now > p)
                {
                    e.Appearance.BackColor = Color.FromArgb(0xFF, 0x99, 0xCC);
                    e.Appearance.ForeColor = Color.Black;
                }
                }
            }
        }

        private void передатьНаПроработкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                this.deloTableAdapter.UpdateStatusSbyt(Globals.id_delo);
                this.deloTableAdapter.FillByUrist(this.uristDataSet1.delo, Globals.id_user);
            
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void передатьНаПроработкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
            {
                ArrayList rows = new ArrayList();
                Int32[] selectedRowHandles = gridView1.GetSelectedRows();
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    if (selectedRowHandle >= 0)
                        rows.Add(gridView1.GetDataRow(selectedRowHandle));
                }
                try
                {
                    // gridView1.BeginUpdate();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i] as DataRow;
                        // Change the field value.
                        object id = row["id"];
                        object cspot = row["cspot"];
                        /*тут проверка доделать */
                        this.delo_deb_bytTableAdapter.UpdateQuery(Globals.id_user,  3,(int)id);
                       // queriesTableAdapter1.insert_delo_byt((int)id);
                    }



                    this.delo_deb_bytTableAdapter.FillByRes3(this.uristDataSet1.delo_deb_byt, Globals.prava_mod_spr_res);

                }
                catch (Exception ex) { }
            }
            if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
            {
                ArrayList rows = new ArrayList();
                Int32[] selectedRowHandles = gridView2.GetSelectedRows();
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    if (selectedRowHandle >= 0)
                        rows.Add(gridView2.GetDataRow(selectedRowHandle));
                }
                try
                {
                    // gridView1.BeginUpdate();
                    for (int i = 0; i < rows.Count; i++)
                    {
                        DataRow row = rows[i] as DataRow;
                        // Change the field value.
                        object id = row["id"];
                        this.delo_deb_promTableAdapter.UpdateQuery(Globals.id_user,  3,(int)id);
                        //queriesTableAdapter1.insert_delo_prom((int)id);
                    }



                    this.delo_deb_promTableAdapter.FillByRes3(this.uristDataSet1.delo_deb_prom, Globals.prava_mod_spr_res);

                }
                catch (Exception ex) { }
            }
        }

        private void backstageViewTabItem7_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
           
            this.delo_deb_bytTableAdapter.FillByBlackList(this.uristDataSet1.delo_deb_byt, Globals.prava_mod_spr_res);
        }

        private void xtraTabControl4_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            try
            {
                if (xtraTabControl4.SelectedTabPage == xtraTabPage8)
                {
                    this.delo_deb_promTableAdapter.FillByBlackList(this.uristDataSet1.delo_deb_prom, Globals.prava_mod_spr_res);
                }

            }
            catch { }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.delo_deb_bytTableAdapter.FillByBlackList(this.uristDataSet1.delo_deb_byt, Globals.prava_mod_spr_res);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            this.delo_deb_promTableAdapter.FillByBlackList(this.uristDataSet1.delo_deb_prom, Globals.prava_mod_spr_res);
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (dateEdit8.Text != "" && dateEdit7.Text != "")
            {
                this.delo_deb_bytTableAdapter.FillByBlackListDate(this.uristDataSet1.delo_deb_byt, Globals.prava_mod_spr_res, dateEdit8.Text, dateEdit7.Text);
            }
            else { MessageBox.Show("Выберите дату"); }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (dateEdit10.Text != "" && dateEdit9.Text != "")
            {
                this.delo_deb_promTableAdapter.FillByBlackListDate(this.uristDataSet1.delo_deb_prom, Globals.prava_mod_spr_res, dateEdit10.Text, dateEdit9.Text);
            }
            else { MessageBox.Show("Выберите дату"); }
        }
    }
}