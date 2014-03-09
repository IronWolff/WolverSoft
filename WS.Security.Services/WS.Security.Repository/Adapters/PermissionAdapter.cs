using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.Security.Model;

namespace WS.Security.Repository.Adapters
{
    public static class PermissionAdapter
    {
        public static Permission GetModelObject(DataAccess.PermissionLevel permissionDA, int roleId = 0)
        {
            return new Permission()
            {
                PermissionDescription = permissionDA.Description,
                PermissionName = permissionDA.Name,
                PermissionLevelId = permissionDA.PermissionLevelId
            };
        }

        public static IList<Permission> GetModelObjectList(IList<DataAccess.PermissionLevel> permissionDA, int roleId = 0)
        {
            return permissionDA.Select(pl => GetModelObject(pl, roleId)).ToList();
        }

        public static DataAccess.PermissionLevel GetDAObject(Permission permission)
        {
            return new DataAccess.PermissionLevel()
            {
                Name = permission.PermissionName,
                Description = permission.PermissionDescription
            };
        }
    }
}
