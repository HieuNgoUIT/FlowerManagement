using Flower_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Flower_Management_System
{
    public partial class StatiticForm : Form
    {
        System_Database_SQL Statitic = new System_Database_SQL();
        private System.Windows.Forms.SaveFileDialog SFD;
        DataTable dbPercentage;
        DataTable dbCus;


        public StatiticForm()
        {
            InitializeComponent();
            Add_Cart_Form_Setting();
            LoadDatabase();
        }

        private void Add_Cart_Form_Setting()
        {
            this.BackColor = Color.White;
            //this.TransparencyKey = Color.FromArgb(237, 28, 36);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadDatabase() {
            string query_SQL_command = "select Flower.ID as FlowerID, Flower.FullName as FullName, CONVERT(varchar, 100*  COUNT(CartDetail.Cart_ID)/ (select count(CartDetail.Cart_ID) from Flower left join CartDetail on Flower.ID = CartDetail.Flower_ID))+ '%' as Percents";
            query_SQL_command += " from Flower left join CartDetail on Flower.ID = CartDetail.Flower_ID";
            query_SQL_command  += " group by Flower.ID, Flower.FullName";
            query_SQL_command += " order by COUNT(CartDetail.Cart_ID) desc";
            dbPercentage = Statitic.Get_Database(query_SQL_command);
            DGV__Percentage.DataSource = dbPercentage;
            query_SQL_command = "select Customer.ID as Customer_ID, Customer.FullName as FullName, COUNT(Cart.ID) as Carts, SUM(coalesce(CartDetail.Quantity * Flower.Price, 0)) as Price";
            query_SQL_command += " from Customer";
            query_SQL_command += " left join Cart on Customer.ID = Cart.Customer_ID";
            query_SQL_command += " left join CartDetail on Cart.ID = CartDetail.Cart_ID";
            query_SQL_command += " left join Flower on Flower.ID = CartDetail.Flower_ID";
            query_SQL_command += " group by Customer.ID, Customer.FullName";
            query_SQL_command += " order by  SUM(coalesce(CartDetail.Quantity * Flower.Price, 0)) desc";
            dbCus = Statitic.Get_Database(query_SQL_command);
            DGV_Cus.DataSource = dbCus;
            //chart1.ChartAreas= Chart
        }

        //private void ExportButtonClick ()
        //{
        //    this.SFD = new System.Windows.Forms.SaveFileDialog();
        //    SFD.Filter = "Excel|*.xlsx";
        //    SFD.Title = "Save file Thống kê";
        //    SFD.FileName = "ThongKe.xlsx";
        //    SFD.RestoreDirectory = true;
        //    SFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //    DialogResult SFDR = SFD.ShowDialog();
        //    if (SFDR == DialogResult.OK) {
        //        ExportDataToExcel(dbPercentage, SFD.FileName);
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}

        //private void ExportDataToExcel (DataTable dt, string name)
        //{

        //    //ButtonXuatExcel.Enabled = False
        ////If System.IO.File.Exists(name) Then
        ////    If(MessageBox.Show("Do you want to replace from the existing file?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then
        ////        System.IO.File.Delete(name)
        ////    Else
        ////        Return
        ////    End If
        ////End If

        //if (System.IO.File.Exists(name)){
        //    if (MessageBox.Show("Do You want to replace from the exsting file?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        System.IO.File.Delete(name);
        //    else
        //        return;
        //}
        //Office.Excel _excel;
        //OfficeExcel.Workbook wBook;
        //OfficeExcel.Worksheet wSheet;
        //OfficeExcel.Range formatRange;

        //    wBook = _excel.Workbooks.Add();
        //    wSheet = wBook.ActiveSheet();
        //System.Data.DataColumn dc;
        //System.Data.DataRow dr;
        //int colIndex = 0;
        //int rowIndex = 3;
               
        //    foreach dc in dt.Columns {
        //        colIndex = colIndex + 1;
        //        wSheet.Cells(rowIndex + 1, colIndex) = dbCus.Columns(colIndex - 1).ColumnName;
        //    }
        //    foreach dr in dt.Columns {
        //        rowIndex = rowIndex + 1;
        //        colIndex = 0;
        //        foreach dc in dt.Columns {
        //            colIndex = colIndex + 1;
        //            wSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName);
        //        }
        //    }


        //    OfficeExcel.Range cellRang;
        //    formatRange = wSheet.UsedRange;
        //    formatRange.Borders.ColorIndex = OfficeExcel.XlColorIndex.xlColorIndexAutomatic;
        //    formatRange.BorderAround(OfficeExcel.XlLineStyle.xlContinuous, OfficeExcel.XlBorderWeight.xlMedium, OfficeExcel.XlColorIndex.xlColorIndexAutomatic, OfficeExcel.XlColorIndex.xlColorIndexAutomatic);

        //    cellRang = wSheet.Range("a1", "d3");
        //    cellRang.Merge(false);
        //    cellRang.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter;
        //    cellRang.VerticalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter;
        //    cellRang.Font.Size = 12;
        //    wSheet.Range("a1").Value = "Thong Ke";
        //    wSheet.Range("A4").ColumnWidth = 7;
        //    wSheet.Range("B4").ColumnWidth = 25;
        //    wSheet.Range("C4").ColumnWidth = 20;
        //    wSheet.Range("D4").ColumnWidth = 10;
        //    wBook.SaveAs(name);
        //    ReleaseObject(wSheet);
        //    wBook.Close(false);
        //    ReleaseObject(wBook);
        //    _excel.Quit();
        //    ReleaseObject(_excel);
        //    GC.Collect();

        //}

        //private void ReleaseObject(Object o)
        //{
        //    try
        //    {
        //        while (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
        //        {
                    
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    finally
        //    {
        //        o = null;
        //    }
        //}

        private void BT_CLose_Form_Click(object sender, EventArgs e)
        {
            Close();
     
        }
    }
}
