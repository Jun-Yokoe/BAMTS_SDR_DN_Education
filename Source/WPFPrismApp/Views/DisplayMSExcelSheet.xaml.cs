using System.Windows.Controls;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace BAMTS.Internal
{
    /// <summary>
    /// Interaction logic for DisplayMSExcelSheet
    /// </summary>
    public partial class DisplayMSExcelSheet : UserControl
    {
        OpenFileDialog openDialog = new OpenFileDialog() { Filter = "Excel ブック (*.xlsx)|*.xlsx|Excel 97-2003 ブック (*.xls)|*.xls" };
        SaveFileDialog saveDialog = new SaveFileDialog() { Filter = "Excel ブック (*.xlsx)|*.xlsx|Excel 97-2003 ブック (*.xls)|*.xls" };

        public DisplayMSExcelSheet()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            if (openDialog.ShowDialog() == true)
            {
                using (Stream fstream = openDialog.OpenFile())
                {
                    // Excelファイルを開く
                    gcSpreadSheet1.OpenExcel(fstream);
                }
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (saveDialog.ShowDialog() == true)
                {
                    using (Stream fstream = saveDialog.OpenFile())
                    {
                        // Excelファイルを保存する
                        gcSpreadSheet1.Workbook.SaveAs(fstream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー：" + ex.Message);
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            // コントロールをリセット
            gcSpreadSheet1.Reset();
        }
    }
}
