using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.Security.Model;

namespace WS.Security.Repository
{
    public interface IUserSecurityRepository : IDisposable
    {
        void SaveChanges();

        IList<User> GetFilteredUsers(UserFilter userFilter);

        int InsertUser(User user);

        void UpdateUser(User user, bool changePassword);

        void DeactivateUser(int userId);

        //IList<Role> GetFilteredRoles(RoleFilter filter);

        //int InsertRole(Role roleToSave);

        //void UpdateRole(Role roleToUpdate);

        //void DeleteRole(int roleId);

        //void AddUserRole(int userId, int roleId);

        //void RemoveAllRolesFromUser(int userId);

        //void AddPermissionToRole(int roleId, int applicationModuleId, int permissionLevelId);

        //void ClearPermissionsFromRole(int roleId);

        //IList<Permission> GetFilteredPermissions(PermissionFilter filter);

        //IList<Permission> GetPermissionsByRole(int roleId);

        //IList<Application> GetFilteredApplications(ApplicationFilter filter);

        // InsertPermission(Permission permission);

        //void UpdatePermission(Permission permission);

        //void DeletePermission(int permissionId);

        //int InsertApplication(Application permission);

        //void UpdateApplication(Application permission);

        //void DeleteApplication(int permissionId);

        //void RemoveAllUsersFromRole(int roleId);

        //IList<ApplicationModule> GetApplicationModulesFiltered(ApplicationModuleFilter filter);

        //int InsertApplicationModule(ApplicationModule applicationModule);

        //void DeleteApplicationModule(int applicationModuleId);

        //void RemoveAllRolePermissionsFromApplicationModule(int applicationModuleId);
    }
}
