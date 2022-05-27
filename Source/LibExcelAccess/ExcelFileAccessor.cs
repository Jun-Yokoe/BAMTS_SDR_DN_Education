using ClosedXML.Excel;
using System.Collections.Generic;

namespace BAMTS.Internal
{
    public class ExcelFileAccessor : IDataAccessor
    {
        private string _targetFilePath;
        private string _targetSheetName;
        public ExcelFileAccessor(string targetFilePath, string targetSheetName)
        {
            this._targetFilePath = targetFilePath;
            this._targetSheetName = targetSheetName;
        }
        public IList<RecEmployeeAll> GetEmployeeAll()
        {
            var res = new List<RecEmployeeAll>();
            using (var workbook = new XLWorkbook(this._targetFilePath))
            {
                var worksheet = workbook.Worksheet(this._targetSheetName);
                int row = 2;
                bool endOfRow = false;
                while (endOfRow == false)
                {
                    if (string.IsNullOrEmpty(worksheet.Cell(row, 1).Value.ToString().Trim()))
                    {
                        endOfRow = true;
                        break;
                    }
                    string[] list = new string[11];
                    for (int col = 1; col <= 11; col++)
                    {
                        list[col-1] = worksheet.Cell(row, col).Value.ToString();
                    }
                    res.Add(new RecEmployeeAll(list));
                    row++;
                }
            }
            return res;
        }
        public void UpdateEmployeeAll(IList<RecEmployeeAll> list)
        {
        }
    }
}
