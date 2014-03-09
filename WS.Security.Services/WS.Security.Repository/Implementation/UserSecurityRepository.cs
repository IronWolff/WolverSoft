using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.Security.DataAccess;
using WS.Security.Exceptions;
using WS.Security.Model;

namespace WS.Security.Repository.Implementation
{
    public partial class UserSecurityRepository : IUserSecurityRepository
    {
        private UserSecurityEntities _userSecurityEntities;

        ~UserSecurityRepository()
        {
            Dispose(false);
        }

        private UserSecurityEntities UserSecurityDataContext
        {
            get
            {
                if (_userSecurityEntities == null)
                {
                    _userSecurityEntities = new UserSecurityEntities();
                    ////_userSecurityEntities.ExecuteStoreCommand("SET TRANSACTION ISOLATION LEVEL READ COMMITTED");
                }
                return _userSecurityEntities;
            }
        }

        /// <summary>
        /// Saves all adds and edits done within the current repository lifetime
        /// </summary>
        public void SaveChanges()
        {
            UserSecurityDataContext.SaveChanges();
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
                if (_userSecurityEntities != null)
                {
                    //if (_userSecurityEntities.Connection.State != ConnectionState.Closed)
                    //{
                    //    _userSecurityEntities.Dispose();
                    //}
                }
            }
        }

        #endregion
    }
}
