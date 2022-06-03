using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAMTS.Internal
{
    public class Common
    {
        public static string TARGET_DATABASE_CONNECTION_SETTINGS = "Data Source=BAMTS-ISFSERV01;Initial Catalog=BAMTS_DB;Persist Security Info=True;User ID=naitou;Password=naitou";
        public static string TARGET_CSV_FILE_PATH = @"C:\User\Projects\Practice\Education\Test\Data\EMPLOYEE.CSV";
        public static string TARGET_EXCEL_FILE_PATH = @"C:\User\Projects\Practice\Education\Test\Data\EMPLOYEE.xlsx";
        public static string TARGET_EXCEL_FILE_SHEET = "EMPLOYEE";
        public static string TARGET_WEBAPI_HOST = "192.168.1.12";
        public static int TARGET_WEBAPI_PORTNO = 1486;      
        public static string TARGET_WEBAPI_CONTROLLER = "DatabaseAccessController";
    }
}
