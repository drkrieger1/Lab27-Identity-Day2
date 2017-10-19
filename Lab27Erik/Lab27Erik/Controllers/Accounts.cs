using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab27Erik.Controllers
{
    public class Accounts : Controller 
    {
        public string Email { get; set; }

        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
