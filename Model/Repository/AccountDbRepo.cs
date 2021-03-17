using System;
using System.Data;

namespace Model.Repository
{
    public class AccountDbRepo : IAccountDbRepo
    {
        public DataTable Login(string username, string password)
        {
            var errorCode = -1;
            try
            {
                errorCode = Db.GetPasswordBy(username.ToLower()).Equals(password) ? 0 : -1;
            }
            catch (Exception)
            {
                // ignored
            }

            var dt = new DataTable();
            dt.Columns.Add("ErrorCode", typeof(int));
            var dr = dt.NewRow();
            dr["ErrorCode"] = errorCode;
            dt.Rows.Add(dr);
            return dt;
        }
    }
}