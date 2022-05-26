using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BAMTS.Internal;

namespace WebAPIService.Controllers
{
    public class DatabaseAccessController : ApiController 
    {
        private static string _TARGET_INFO_TEXT = "Data Source=BAMTS-ISFSERV01;Initial Catalog=BAMTS_DB;Persist Security Info=True;User ID=naitou;Password=naitou";
        private IDataAccessor _dataAccess = new SQLServerAccessor(DatabaseAccessController._TARGET_INFO_TEXT);
        [HttpGet]
        [Route("api/DatabaseAccessController/GetEmployeeAll")]
        public IList<RecEmployeeAll> GetEmployeeAll()
        {
            return this._dataAccess.GetEmployeeAll();
        }
    }
}