using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
//using System.Web.Http;
using BAMTS.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace WebAPIService.Controllers
{
    [ApiController]
    public class DatabaseAccessController : ControllerBase
    {
        private static string _TARGET_INFO_TEXT = Common.TARGET_DATABASE_CONNECTION_SETTINGS;
        private IDataAccessor _dataAccess = new SQLServerAccessor(DatabaseAccessController._TARGET_INFO_TEXT);
        [HttpGet]
        [Route("api/DatabaseAccessController/GetEmployeeAll")]
        public IList<RecEmployeeAll> GetEmployeeAll()
        {
            //var list = new List<RecEmployeeAll>();
            //list.Add(new RecEmployeeAll(new List<string>() { "00001", "o森谷　正史", "1966/01/01", "2000/01/01", "0", "1", "090-1111-2222", "moritani-cp@bamts.ne.jp", "moritani-pc@bamts.co.jp", "passpass", "社長" }));
            //list.Add(new RecEmployeeAll(new List<string>() { "00002", "o松田　将秀", "1986/01/01", "2000/01/01", "0", "1", "090-1111-2222", "matsuda-cp@bamts.ne.jp", "matsuda-pc@bamts.co.jp", "passpass", "Superアルバイト" }));
            //list.Add(new RecEmployeeAll(new List<string>() { "00003", "o北村　順子", "1960/02/22", "2002/01/01", "0", "1", "090-1111-2222", "kitamura-cp@bamts.ne.jp", "kitamura-pc@bamts.co.jp", "passpass", "部長" }));
            //list.Add(new RecEmployeeAll(new List<string>() { "00004", "o横山　真理子", "1960/02/22", "2002/01/01", "0", "1", "090-1111-2222", "kitamura-cp@bamts.ne.jp", "kitamura-pc@bamts.co.jp", "passpass", "部長" }));
            //list.Add(new RecEmployeeAll(new List<string>() { "00005", "o西田　文彦", "1960/02/22", "2002/01/01", "0", "1", "090-1111-2222", "kitamura-cp@bamts.ne.jp", "kitamura-pc@bamts.co.jp", "passpass", "部長" }));
            //list.Add(new RecEmployeeAll(new List<string>() { "00006", "o内藤　光治", "1960/02/22", "2002/01/01", "0", "1", "090-1111-2222", "kitamura-cp@bamts.ne.jp", "kitamura-pc@bamts.co.jp", "passpass", "部長" }));
            //list.Add(new RecEmployeeAll(new List<string>() { "00007", "o横江　純", "1960/02/22", "1972/08/13", "0", "1", "090-1111-2222", "kitamura-cp@bamts.ne.jp", "kitamura-pc@bamts.co.jp", "passpass", "部長" }));
            //return list;
            return this._dataAccess.GetEmployeeAll();
        }
        [HttpPost]
        [Route("api/DatabaseAccessController/UpdateEmployeeAll")]
        public void UpdateEmployeeAll(IList<RecEmployeeAll> list) => this._dataAccess.UpdateEmployeeAll(list);
    }
}