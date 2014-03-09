using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.Security.Model;
using System.Transactions;
using System.ServiceModel;
using WS.Security.Services.Task;

namespace WS.Security.Services.BussinesLogic.Implementation
{
    public class UserSecurityBLService : IUserSecurityBLService
    {
        /// <summary>
        /// Performs all the necessary actions to add a user to the UserSecurity database and assign roles and permissions
        /// </summary>
        /// <param name = "user">New user to be saved</param>
        /// <param name = "userRoles">Roles that will be assigned to the just-created user</param>
        /// <returns></returns>
        public int CreateUser(User user, IList<Role> userRoles)
        {
            int userId = 0;

            try
            {
                //Run all the task sevice methods inside of a transaction
                using (var transactionScope = new TransactionScope())
                {
                    //Add the user record
                    using (var userService = new UserService())
                    {
                        userId = userService.InsertUser(user);
                    }

                    //if (userRoles != null && userRoles.Count > 0)
                    //{
                    //    using (var roleService = new RoleService())
                    //    {
                    //        foreach (Role role in userRoles)
                    //        {
                    //            roleService.AddUserToRole(userId, role.Id);
                    //        }
                    //    }
                    //}

                    transactionScope.Complete();
                }
            }
            catch
            {
                userId = 0;
                throw;
            }

            return userId;
        }

        /// <summary>
        /// Method that update an aspnet user. Assign data of aspnet user. Clean and insert updated roles and permissions.
        /// </summary>
        /// <param name = "user">Desired user to update</param>
        /// <param name = "userRoles">User roles that will be assigned to a given user</param>
        public void UpdateUser(User user, IList<Role> userRoles)
        {
            //Run all the task sevice methods inside of a transaction
            using (var transactionScope = new TransactionScope())
            {
                //Update the User and Aspuser
                using (var userService = new UserService())
                {
                    userService.UpdateUser(user);
                }

                //Clear the existing roles and add the ones passed in
                //using (var roleService = new RoleService())
                //{
                //    roleService.RemoveAllRolesFromUser(user.UserId);

                //    foreach (Role role in userRoles)
                //    {
                //        roleService.AddUserToRole(user.UserId, role.RoleId);
                //    }
                //}

                transactionScope.Complete();
            }
        }

        #region FaultExceptions

        protected FaultException<ServiceFault> GetFaultException(Exception ex)
        {
            var fault = new ServiceFault
            {
                ErrorCode = ex.GetType().ToString(),
                ErrorDetail = ex.ToString(),
                ErrorMessage = ex.Message
            };

            return new FaultException<ServiceFault>(fault, new FaultReason(ex.Message));
        }

        #endregion FaultExceptions
    }
}
