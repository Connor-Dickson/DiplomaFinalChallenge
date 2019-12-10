using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalChallenge
{
    public class AdminRequirement : IAuthorizationRequirement
    {
        public string Admin { get; set; }

        public AdminRequirement(string admin)
        {
            Admin = admin;
        }
    }
}
