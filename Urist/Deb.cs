using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Localization;
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;

namespace Urist
{
    public partial class Deb : DevExpress.XtraEditors.XtraForm
    {
        public Deb()
        {
            InitializeComponent();
            GridLocalizer.Active = new CustomGridLocalizer();
        }
        public class CustomGridLocalizer : GridLocalizer
        {
            public override string GetLocalizedString(GridStringId del)
            {
                if (del == GridStringId.CheckboxSelectorColumnCaption)
                {
                    return "CustomCaption";
                }
                return base.GetLocalizedString(del);
            }
        }
        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void Main2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uristDataSet1.sud_delo' table. You can move, or remove it, as needed.
            this.sud_deloTableAdapter.Fill(this.uristDataSet1.sud_delo);
            // TODO: This line of code loads data into the 'uristDataSet1.delo_deb_prom' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'uristDataSet1.deb_prom' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'uristDataSet1.delo_deb_byt' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'uristDataSet1.deb_byt' table. You can move, or remove it, as needed.


            if (Globals.id_user == 3 || Globals.id_user == 34)
            {
                this.sprSlujbaTableAdapter.FillBySever(this.uristDataSet1.sprSlujba);
            }
            else { this.sprSlujbaTableAdapter.FillByTalas(this.uristDataSet1.sprSlujba); }


        }

        private void sprSlujbaBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
           
        }


        private void simpleButton14_Click_1(object sender, EventArgs e)
        {
            ArrayList rows = new ArrayList();
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
            } 
           
           
                
                // gridView1.BeginUpdate();
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i] as DataRow;
                    // Change the field value.
                    object cspot = row["cspot"];

                    object cspot2 = row["cspot2"];
                    object address = row["address"];
                    object ypeni = row["ypeni"];
                    object yenergy = row["yenergy"];
                    object yakt = row["yakt"];
                    object y1 = row["y1"];
                    object y2 = row["y2"];
                    object y3 = row["y3"];
                    object y4 = row["y4"];
                    object y5 = row["y5"];
                    object y6 = row["y6"];
                    object y7 = row["y7"];
                    object y8 = row["y8"];
                    object dendbill;
                    object dendpay;
                    if (row["dendbill"] is DBNull)
                    { dendbill = ""; }
                    else
                    {
                        dendbill = row["dendbill"];
                    }
                    if (row["dendpay"] is DBNull)
                    { dendpay = ""; }
                    else
                    {
                        dendpay = row["dendpay"];
                    }
                    object carea = row["carea"];
                    object nregion = row["nregion"];
                    object id_res = row["id_zavis"];
                     this.delo_deb_bytTableAdapter.FillBycspot(this.uristDataSet1.delo_deb_byt, cspot.ToString());
                    if (delo_deb_bytBindingSource.Count < 1) 
                        { 
                    this.sud_deloTableAdapter.FillBy(this.uristDataSet1.sud_delo, cspot.ToString());
                    if (sud_deloBindingSource.Count < 1)
                    {
                        if (Convert.ToInt32(id_res) == 1 || Convert.ToInt32(id_res) == 14)
                        {
                            this.delo_deb_bytTableAdapter.InsertQuery(cspot.ToString(), cspot2.ToString(), address.ToString(), Convert.ToDouble(ypeni), Convert.ToDouble(yenergy), Convert.ToDouble(yakt), Convert.ToDouble(y1), Convert.ToDouble(y2), Convert.ToDouble(y3), Convert.ToDouble(y4), Convert.ToDouble(y5), Convert.ToDouble(y6), Convert.ToDouble(y7), Convert.ToDouble(y8), dendbill.ToString(), dendpay.ToString(), carea.ToString(), nregion.ToString(), Convert.ToInt32(nregion), Globals.id_user, DateTime.Now.ToString(), 1); 
                        }
                        else 
                        {
 
                        this.delo_deb_bytTableAdapter.InsertQuery(cspot.ToString(), cspot2.ToString(), address.ToString(), Convert.ToDouble(ypeni), Convert.ToDouble(yenergy), Convert.ToDouble(yakt), Convert.ToDouble(y1), Convert.ToDouble(y2), Convert.ToDouble(y3), Convert.ToDouble(y4), Convert.ToDouble(y5), Convert.ToDouble(y6), Convert.ToDouble(y7), Convert.ToDouble(y8), dendbill.ToString(), dendpay.ToString(), carea.ToString(), nregion.ToString(), Convert.ToInt32(id_res), Globals.id_user, DateTime.Now.ToString(), 1);
                        } 
                        this.deb_bytTableAdapter.UpdateQuery(cspot.ToString());
                    }
                        } 
                    else
                    {
                        int stat;
                        if (((DataRowView)(delo_deb_bytBindingSource.Current)).Row["status"] is DBNull || ((DataRowView)(delo_deb_bytBindingSource.Current)).Row["status"] == "")
                        { stat = 0; }
                        else { stat = (int)((DataRowView)(delo_deb_bytBindingSource.Current)).Row["status"]; }
                       if (stat == 1|| stat ==0)
                       {
                           this.deb_bytTableAdapter.UpdateQuery1(1, cspot.ToString());
                       }
                       if (stat == 2) { this.deb_bytTableAdapter.UpdateQuery1(2, cspot.ToString()); }
                       if (stat == 3) { this.deb_bytTableAdapter.UpdateQuery1(3, cspot.ToString()); }
                        }
                    
                }





                   if (Globals.id_res == 1)
                    {
                       
                           
                        this.deb_bytTableAdapter.FillBySever(this.uristDataSet1.deb_byt);

                    }
                    else if (Globals.id_res == 14)
                    {
                       
                        this.deb_bytTableAdapter.FillByTalas(this.uristDataSet1.deb_byt);
                    }
                    else
                    {
                        if (Globals.id_zavis != 1 || Globals.id_zavis != 14)
                        {
                            if (Globals.id_res == 5 || Globals.id_res == 6 || Globals.id_res == 7 || Globals.id_res == 8 || Globals.id_res == 9 || Globals.id_res == 11 || Globals.id_res == 13 || Globals.id_res == 4 || Globals.id_res == 10 || Globals.id_res == 12 || Globals.id_res == 16 || Globals.id_res == 17 || Globals.id_res == 18 || Globals.id_res == 19)
                            {
                                this.deb_bytTableAdapter.FillByRes1(this.uristDataSet1.deb_byt, Globals.id_res);
                            }
                            else { this.deb_bytTableAdapter.FillByRes(this.uristDataSet1.deb_byt, Globals.id_res); }
                        }
                        else { this.deb_bytTableAdapter.FillByUchastok(this.uristDataSet1.deb_byt, Globals.id_res.ToString()); }
                    }
                   MessageBox.Show("Абоненты отправлены!!!");
           

        }

        private void simpleButton1_Click(object sender, EventArgs e)
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
                    object cspot = row["cspot"];

                    object cspot2 = row["cspot2"];
                    object address = row["address"];
                    object y0 = row["y0"];
                    object y1 = row["y1"];
                    object y2 = row["y2"];
                    object y3 = row["y3"];
                    object y4 = row["y4"];
                    object y5 = row["y5"];
                    object y6 = row["y6"];
                    object y7 = row["y7"];
                    object y8 = row["y8"];
                    object ypeni = row["ypeni"];
                    object yakt = row["yakt"];
                    object nregion = row["nregion"];
                    object id_res = row["id_zavis"];
                    this.delo_deb_promTableAdapter.FillBycspot(this.uristDataSet1.delo_deb_prom, cspot.ToString());
                    if (delo_deb_promBindingSource.Count < 1)
                    {
                        this.sud_deloTableAdapter.FillBy(this.uristDataSet1.sud_delo, cspot.ToString());
                        if (sud_deloBindingSource.Count < 1)
                        {
                            if (Convert.ToInt32(id_res) == 1 || Convert.ToInt32(id_res) == 14)
                            { this.delo_deb_promTableAdapter.InsertQuery(cspot.ToString(), cspot2.ToString(), address.ToString(), Convert.ToDouble(y0), Convert.ToDouble(y1), Convert.ToDouble(y2), Convert.ToDouble(y3), Convert.ToDouble(y4), Convert.ToDouble(y5), Convert.ToDouble(y6), Convert.ToDouble(y7), Convert.ToDouble(y8), nregion.ToString(), Convert.ToInt32(nregion), Globals.id_user, DateTime.Now.ToString(), 1, Convert.ToDouble(ypeni), Convert.ToDouble(yakt)); }
                            else {
                                this.delo_deb_promTableAdapter.InsertQuery(cspot.ToString(), cspot2.ToString(), address.ToString(), Convert.ToDouble(y0), Convert.ToDouble(y1), Convert.ToDouble(y2), Convert.ToDouble(y3), Convert.ToDouble(y4), Convert.ToDouble(y5), Convert.ToDouble(y6), Convert.ToDouble(y7), Convert.ToDouble(y8), nregion.ToString(), Convert.ToInt32(id_res), Globals.id_user, DateTime.Now.ToString(), 1, Convert.ToDouble(ypeni), Convert.ToDouble(yakt));
                           } 
                            this.deb_promTableAdapter.UpdateQuery(cspot.ToString());
                        }
                    }
                    else
                    { int stat;
                    if (((DataRowView)(delo_deb_promBindingSource.Current)).Row["status"] is DBNull || ((DataRowView)(delo_deb_promBindingSource.Current)).Row["status"] == "") { stat = 0; }
                    else{
                       stat = (int)((DataRowView)(delo_deb_promBindingSource.Current)).Row["status"];}
                        if (stat == 1|| stat == 0)
                        {
                            this.deb_promTableAdapter.UpdateQuery1(1, cspot.ToString());
                        }
                        if (stat == 2) { this.deb_promTableAdapter.UpdateQuery1(2, cspot.ToString()); }
                        if (stat == 3) { this.deb_promTableAdapter.UpdateQuery1(3, cspot.ToString()); }
                    }
}
                    if (Globals.id_res == 1)
                    {
                        this.deb_promTableAdapter.FillBySever(this.uristDataSet1.deb_prom);

                    }
                    else if (Globals.id_res == 14)
                    {
                        this.deb_promTableAdapter.FillByTalas(this.uristDataSet1.deb_prom);
                    }
                    else
                    {
                        if (Globals.id_zavis != 1 || Globals.id_zavis != 14)
                        {
                            if (Globals.id_res == 5 || Globals.id_res == 6 || Globals.id_res == 7 || Globals.id_res == 8 || Globals.id_res == 9 || Globals.id_res == 11 || Globals.id_res == 13 || Globals.id_res == 4 || Globals.id_res == 10 || Globals.id_res == 12 || Globals.id_res ==17
|| Globals.id_res == 18 || Globals.id_res == 16 || Globals.id_res == 15
|| Globals.id_res == 19)
                            {
                                this.deb_promTableAdapter.FillByRes1(this.uristDataSet1.deb_prom, Globals.id_res);
                            }
                            else { this.deb_promTableAdapter.FillByRes(this.uristDataSet1.deb_prom, Globals.id_res); }
                        }
                        else { this.deb_promTableAdapter.FillByUchastok(this.uristDataSet1.deb_prom, Globals.id_res.ToString()); }
                    }
                    MessageBox.Show("Абоненты отправлены!!!");
                }
            
            catch (Exception ex) { }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {

                    if ((View.GetRowCellValue(e.RowHandle, View.Columns["status_delo"])) != DBNull.Value)
                    {
                        if ((int)(View.GetRowCellValue(e.RowHandle, View.Columns["status_delo"])) == 1)
                        {
                            e.Appearance.BackColor = Color.FromArgb(0xFF, 0x99, 0xCC);
                            e.Appearance.ForeColor = Color.Black;
                        }
                        if ((int)(View.GetRowCellValue(e.RowHandle, View.Columns["status_delo"])) == 2)
                        {
                            e.Appearance.BackColor = Color.FromArgb(0x66, 0xCC, 0x99);
                            e.Appearance.ForeColor = Color.Black;
                        }
                        if ((int)(View.GetRowCellValue(e.RowHandle, View.Columns["status_delo"])) == 3)
                        {
                            e.Appearance.BackColor = Color.FromArgb(0xFF, 0x33, 0x00);
                            e.Appearance.ForeColor = Color.Black;
                        }
                    }
                }
            }
            catch { }
        }

        private void gridView2_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {

                    if ((int)(View.GetRowCellValue(e.RowHandle, View.Columns["status_delo"])) == 1)
                    {
                        e.Appearance.BackColor = Color.FromArgb(0xFF, 0x99, 0xCC);
                        e.Appearance.ForeColor = Color.Black;
                    }
                    if ((int)(View.GetRowCellValue(e.RowHandle, View.Columns["status_delo"])) == 2)
                    {
                        e.Appearance.BackColor = Color.FromArgb(0x66, 0xCC, 0x99);
                        e.Appearance.ForeColor = Color.Black;
                    }
                    if ((int)(View.GetRowCellValue(e.RowHandle, View.Columns["status_delo"])) == 3)
                    {
                        e.Appearance.BackColor = Color.FromArgb(0xFF, 0x33, 0x00);
                        e.Appearance.ForeColor = Color.Black;
                    }
                }
            }
            catch { }
        }

        private void treeList1_Click(object sender, EventArgs e)
        {
            TreeListMultiSelection selectedNodes = treeList1.Selection;
           
            try
            {
                Globals.id_res = (int)(selectedNodes[0].GetValue(treeList1.Columns[5]));
                Globals.id_zavis = (int)(selectedNodes[0].GetValue(treeList1.Columns[6]));
                if (xtraTabControl1.SelectedTabPage == xtraTabPage1)
                {
                    if (Globals.id_res == 1)
                    {
                        this.deb_bytTableAdapter.FillBySever(this.uristDataSet1.deb_byt);

                    }
                    else if (Globals.id_res == 14)
                    {
                        this.deb_bytTableAdapter.FillByTalas(this.uristDataSet1.deb_byt);
                    }
                    else
                    {
                        if (Globals.id_zavis != 1 || Globals.id_zavis != 14)
                        {
                            if (Globals.id_res == 5 || Globals.id_res == 6 || Globals.id_res == 7 || Globals.id_res == 8 || Globals.id_res == 9 || Globals.id_res == 11 || Globals.id_res == 13|| Globals.id_res ==16
|| Globals.id_res ==17
|| Globals.id_res ==18
|| Globals.id_res == 19)
                            { 
                            this.deb_bytTableAdapter.FillByRes1(this.uristDataSet1.deb_byt, Globals.id_res); }
                            else {  this.deb_bytTableAdapter.FillByRes(this.uristDataSet1.deb_byt, Globals.id_res); }
                        }
                        else { this.deb_bytTableAdapter.FillByUchastok(this.uristDataSet1.deb_byt, Globals.id_res.ToString()); }
                    }
                }
                if (xtraTabControl1.SelectedTabPage == xtraTabPage2)
                {
                    if (Globals.id_res == 1)
                    {
                        this.deb_promTableAdapter.FillBySever(this.uristDataSet1.deb_prom);

                    }
                    else if (Globals.id_res == 14)
                    {
                        this.deb_promTableAdapter.FillByTalas(this.uristDataSet1.deb_prom);
                    }
                    else
                    {
                        if (Globals.id_zavis != 1 || Globals.id_zavis != 14)
                        {
                            if (Globals.id_res == 5 || Globals.id_res == 6 || Globals.id_res == 7 || Globals.id_res == 8 || Globals.id_res == 9 || Globals.id_res == 11 || Globals.id_res == 13 || Globals.id_res == 4 || Globals.id_res == 10 || Globals.id_res == 12|| Globals.id_res ==17
|| Globals.id_res == 18 || Globals.id_res == 16 || Globals.id_res == 15
|| Globals.id_res == 19)
                            {
                                this.deb_promTableAdapter.FillByRes1(this.uristDataSet1.deb_prom, Globals.id_res);
                            }
                            else { this.deb_promTableAdapter.FillByRes(this.uristDataSet1.deb_prom, Globals.id_res); }
                        }
                        else { this.deb_promTableAdapter.FillByUchastok(this.uristDataSet1.deb_prom, Globals.id_res.ToString()); }
                    }
                }
            }
            catch { }
        }

        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
           

        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsFilterRow(view.FocusedRowHandle))
            {
                view.ActiveEditor.MouseUp += Edit_MouseUp;
            }

        }
        private void Edit_MouseUp(object sender, MouseEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SelectAll();
            edit.MouseUp -= Edit_MouseUp;
        }
    }
}