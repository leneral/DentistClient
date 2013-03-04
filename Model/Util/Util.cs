using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Model.Util
{
    public class Util
    {
        public static int DateDistance(string orderDate)
        {
            //2012-2-12 11:12:13
            DateTime now = DateTime.Now.ToLocalTime();
            DateTime order = Convert.ToDateTime(orderDate);

            return (order - now).Days;
        }

        public static bool IsEnglishChars(string str)
        {
            var reg = new Regex("^[a-zA-Z]");

            if (reg.IsMatch(str))
                return true;
            return false;
        }

        public static void ExportToExcel(ListView list, string filename)
        {
            int rowNum = list.Items.Count;
            int columnNum = list.Items[0].SubItems.Count;
            int rowIndex = 1;
            int columnIndex = 0;
            if (rowNum == 0 || string.IsNullOrEmpty(filename)) return;

            if (rowNum > 0)
            {
                var xlApp = new Application
                    {
                        DefaultFilePath = "",
                        DisplayAlerts = true,
                        SheetsInNewWorkbook = 1
                    };
                Workbook xlBook = xlApp.Workbooks.Add(true);
                //将ListView的列名导入Excel表第一行
                foreach (ColumnHeader dc in list.Columns)
                {
                    columnIndex++;
                    xlApp.Cells[rowIndex, columnIndex] = dc.Text;
                }
                //将ListView中的数据导入Excel中
                for (int i = 0; i < rowNum; i++)
                {
                    rowIndex++;
                    columnIndex = 0;
                    for (int j = 0; j < columnNum; j++)
                    {
                        columnIndex++;
                        //注意这个在导出的时候加了“\t” 的目的就是避免导出的数据显示为科学计数法。可以放在每行的首尾。
                        xlApp.Cells[rowIndex, columnIndex] = Convert.ToString(list.Items[i].SubItems[j].Text) + "\t";
                    }
                }
                //例外需要说明的是用strFileName,Excel.XlFileFormat.xlExcel9795保存方式时 当你的Excel版本不是95、97 而是2003、2007 时导出的时候会报一个错误：异常来自 HRESULT:0x800A03EC。 解决办法就是换成strFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal。
                xlBook.SaveAs(filename, XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing);
            }
        }
    }
}