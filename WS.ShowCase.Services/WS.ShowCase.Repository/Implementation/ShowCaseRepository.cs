using System;
using WS.ShowCase.DataAccess;
using System.Data.EntityClient;
using System.Data;
using System.Data.Common;

namespace WS.ShowCase.Repository
{
    /// <summary>
    /// General method repository of the ShowCase service.
    /// </summary>
    public partial class ShowCaseRepository : IShowCaseRepository
    {
        private ShowCaseEntities _channelIncentiveEntities;

        private ShowCaseEntities ShowCaseDataContext
        {
            get
            {
                if (_channelIncentiveEntities == null)
                {
                    _channelIncentiveEntities = new ShowCaseEntities();
                }

                return _channelIncentiveEntities;
            }
        }

        ~ShowCaseRepository()
        {
            Dispose(false);
        }

        public void SaveChanges()
        {
            ShowCaseDataContext.SaveChanges();
        }

        protected DataTable ExecuteSql(string sql)
        {
            var entityConnection = (EntityConnection)ShowCaseDataContext.Connection;
            DbConnection conn = entityConnection.StoreConnection;
            ConnectionState initialState = conn.State;

            try
            {
                if (initialState != ConnectionState.Open)
                {
                    conn.Open();
                }

                using (DbCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    IDataReader reader = cmd.ExecuteReader();
                    var ds = new DataSet();
                    ds.Load(reader, LoadOption.PreserveChanges, string.Empty);
                    return ds.Tables[0];
                }
            }
            finally
            {
                if (initialState != ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

    #region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_channelIncentiveEntities != null)
                {
                    if (_channelIncentiveEntities.Connection.State != ConnectionState.Closed)
                    {
                        _channelIncentiveEntities.Dispose();
                    }
                }
            }
        }


        #endregion
    }
}
