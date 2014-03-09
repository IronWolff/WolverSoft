using System;
using WS.Security.Model;

namespace WS.Security.Repository
{
    public class RoleFilter : Role
    {
        public int UserId { get; set; }

        public bool IncludeInactive { get; set; }
    }
}
