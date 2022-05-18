﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace BAMTS.Internal
{
    public class TextFileAccessor : IDataAccessor
    {
        private string _rootDirectoryPath;
        private string _employeeFilePath { get; } = @"\EMPLOYEE.CSV";
        private Encoding _fileEncording = Encoding.GetEncoding("utf-8");

        public TextFileAccessor(string rootDirectoryPath)
        {
            this._rootDirectoryPath = rootDirectoryPath;
        }
        public IList<RecEmployeeAll> GetEmployeeAll()
        {
            var headerExist = true;
            var res = new List<RecEmployeeAll>();
            using (var parser = new TextFieldParser($@"{this._rootDirectoryPath}\{this._employeeFilePath}", this._fileEncording))
            {
                parser.Delimiters = new string[] { "," };
                if (headerExist) parser.ReadFields();   //ヘッダが存在する場合は、ヘッダレコードを空読み
                while (!parser.EndOfData) 
                { 
                    res.Add(new RecEmployeeAll(parser.ReadFields())); 
                }
            }
            return res;
        }
        public void UpdateEmployeeAll(IList<RecEmployeeAll> list)
        {
            StringBuilder sbFile = new StringBuilder();
            sbFile.Append(RecEmployeeAll.GetCSVHeader());
            foreach (var item in list) 
            {
                sbFile.Append(item.GetCSVRecord()); 
            }
            File.WriteAllText($@"{this._rootDirectoryPath}\{this._employeeFilePath}", sbFile.ToString(), this._fileEncording);
        }
    }
}
