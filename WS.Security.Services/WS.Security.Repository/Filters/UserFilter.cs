using System;
using WS.Security.Model;

namespace WS.Security.Repository
{
    public class UserFilter : User
    {
        public bool GetInactive { get; set; }

        public int RoleId { get; set; }

        public int ClientId { get; set; }
    }
}
