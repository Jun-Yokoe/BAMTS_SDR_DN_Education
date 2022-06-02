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
        private static string _TARGET_INFO_TEXT = Common.TARGET_DATABASE_CONNECTION_SETTINGS;
        private IDataAccessor _dataAccess = new SQLServerAccessor(DatabaseAccessController._TARGET_INFO_TEXT);
        [HttpGet]
        [Route("api/DatabaseAccessController/GetEmployeeAll")]
        public IList<RecEmployeeAll> GetEmployeeAll() => this._dataAccess.GetEmployeeAll();
        [HttpPost]
        [Route("api/DatabaseAccessController/UpdateEmployeeAll")]
        public void UpdateEmployeeAll(IList<RecEmployeeAll> list) => this._dataAccess.UpdateEmployeeAll(list);
    }
}