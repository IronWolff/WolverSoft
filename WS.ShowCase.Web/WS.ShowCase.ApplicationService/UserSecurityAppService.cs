using Gpg.Common.Wcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.ShowCase.ViewModels;

namespace WS.ShowCase.ApplicationService
{
    public static class UserSecurityAppService
    {
        public static UserModel AuthenticateUser(UserLoginModel userLogin, out string validationError)
        {
            validationError = string.Empty;

            //Get user from UserSecurityEx
            UserSvc.User userDomainModel = null;

            //Get by username and password
            if (!string.IsNullOrWhiteSpace(userLogin.Password))
            {
                WcfUtility.Use<UserSvc.UserServiceClient>(svc =>
                {
                    userDomainModel = svc.GetUserByLogin(userLogin.UserName, userLogin.Password);
                });

                if (userDomainModel == null || !userDomainModel.IsActive)
                {
                    validationError = "An active user was not found with the specified credentials";
                    return null;
                }
            }
            else
            {
                //Get by username only
                //Get user from UserSecurityEx
                IList<UserSvc.User> users = null;
                //WcfUtility.Use<UserSvc.UserServiceClient>(svc =>
                //{
                //    //users = svc.GetFilteredUsers(new UserSvc.User { UserName = userLogin.UserName }, false);
                //});
                if (users == null || users.Count == 0)
                {
                    validationError = "An active user was not found with the specified username";
                    return null;
                }
                userDomainModel = users.SingleOrDefault();
                if (!userDomainModel.IsActive)
                {
                    validationError = "An active user was not found with the specified username";
                    return null;
                }
            }

            
            //Get permissions for this user for ChannelIncentive
            //var permissions = new List<PermissionSvc.Permission>();
            //if (userRoles != null)
            //{
            //    WcfUtility.Use<PermissionSvc.PermissionServiceClient>(svc =>
            //    {
            //        foreach (RoleSvc.Role role in userRoles)
            //        {
            //            List<PermissionSvc.Permission> permissionsForRole = svc.GetPermissionsByRoleId(role.Id);
            //            if (permissionsForRole != null)
            //            {
            //                foreach (PermissionSvc.Permission perm in permissionsForRole)
            //                {
            //                    if (!permissions.Contains(perm) && perm.ApplicationCode == Settings.Default.ApplicationCode)
            //                    {
            //                        permissions.Add(perm);
            //                    }
            //                }
            //            }
            //        }
            //    });
            //}
            validationError = "asdasd";
            return userDomainModel != null ? UserAdapter.GetViewModel(userDomainModel) : null;
        }
    }
}
