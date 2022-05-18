using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BAMSS.Data;

namespace BAMTS.Internal
{
    public class StoredProcessor
    {
        public IsolationLevel TipicalIsolationLevel { get; set; } = IsolationLevel.Snapshot;
        public string ConnectionString { get; set; } = null;
        public int MaxRetryCount { get; set; } = 30;
        public int RetryIntervalMS { get; set; } = 100;
        public StoredProcessor(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public List<RecEmployeeAll> P_Get_T_EMPLOYEE_ALL()
        {
            var result = new List<RecEmployeeAll>();
            for (int tryCount = 0; tryCount <= this.MaxRetryCount; tryCount++)
            {
                using (SQLServerAccessMethods db = new SQLServerAccessMethods(this.ConnectionString))
                {
                    db.Open();
                    try
                    {
                        SqlCommand cmd = (SqlCommand)db.GetCommand(false);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "P_Get_T_EMPLOYEE_ALL";
                        //cmd.Parameters.Add("@PLANT_CD", SqlDbType.VarChar).Value = PLANT_CD ?? (object)DBNull.Value;
                        var ds = db.GetDataSet(cmd, false);
                        {
                            var dt = ds.Tables[0];
                            for (var i = 0; i < dt.Rows.Count; i++)
                            {
                                var rec = new RecEmployeeAll();
                                rec.BuildRecord(dt.Rows[i]);
                                result.Add(rec);
                            }
                        }
                        break;
                    }
                    catch (Exception ex)
                    {
                        if (tryCount >= this.MaxRetryCount) throw;
                        System.Threading.Thread.Sleep(this.RetryIntervalMS);
                    }
                }
            }
            return result;
        }
        public void P_Replace_T_EMPLOYEE_ALL(IList<RecEmployeeAll> list)
        {
            for (int tryCount = 0; tryCount <= this.MaxRetryCount; tryCount++)
            {
                using (SQLServerAccessMethods db = new SQLServerAccessMethods(this.ConnectionString))
                {
                    db.Open();
                    db.BeginTrans(this.TipicalIsolationLevel);
                    try
                    {
                        SqlCommand cmd = (SqlCommand)db.GetCommand(true);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "P_Replace_T_EMPLOYEE_ALL";
                        cmd.Parameters.Add("@recList", SqlDbType.Structured);
                        cmd.Parameters["@recList"].Direction = ParameterDirection.Input;
                        cmd.Parameters["@recList"].TypeName = "S_T_EMPLOYEE";
                        var test = list.BuildDataTable();
                        cmd.Parameters["@recList"].Value = list.BuildDataTable();
                        var ds = db.GetDataSet(cmd, true);
                        {
                            var dt = ds.Tables[0];
                            var rec = new RecRESULT_MESSAGE();
                            rec.BuildRecord(dt.Rows[0]);
                            if (!string.IsNullOrEmpty(rec.RESULT_MESSAGE))
                            {
                                throw new Exception(rec.RESULT_MESSAGE);
                            }
                            else
                            {
                                db.CommitTrans();
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        db.RollbackTrans();
                        if (tryCount >= this.MaxRetryCount)
                        {
                            throw;
                        }
                        System.Threading.Thread.Sleep(this.RetryIntervalMS);
                    }
                }
            }
        }
    }
}
