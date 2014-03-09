using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WS.Security.Model;

namespace WS.Security.Repository.Adapters
{
    public static class RoleAdapter
    {
        public static Role GetModelObject(DataAccess.Role rolesDA)
        {
            return new Role()
            {
                RoleId = rolesDA.RoleId,
                Name = rolesDA.Name,
                Description = rolesDA.Description,
                IsActive = rolesDA.IsActive,
                ClientId = rolesDA.ClientId
            };
        }

        public static IList<Role> GetModelObjectList(IList<DataAccess.Role> rolesDA)
        {
            return rolesDA.Select(daRole => GetModelObject(daRole)).ToList();
        }

        public static DataAccess.Role GetDAObject(Role role)
        {
            return new DataAccess.Role()
            {
                RoleId = role.RoleId,
                Name = role.Name,
                Description = role.Description,
                IsActive = role.IsActive,
                ClientId = role.ClientId
            };
        }
    }
}
